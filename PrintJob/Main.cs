using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Management;
using System.Collections.Specialized;
using System.Printing;
using Microsoft.Office.Interop.Excel;

namespace PrintJob
{
    public partial class Main : Form
    {

        PrintJobDbEntities1 db = new PrintJobDbEntities1();
        public static string userName = "";
        public static string customerName = "";
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;  // Turn on WS_EX_TOOLWINDOW
                return cp;
            }
        }
        private void RefreshPrintJobs()
        {
            try
            {
                LocalPrintServer myPrintServer = new LocalPrintServer();
                PrintQueueCollection myPrintQueues = myPrintServer.GetPrintQueues();
                dataGridView1.Rows.Clear();
                foreach (PrintQueue pq in myPrintQueues)
                {

                    pq.Refresh();
                    PrintJobInfoCollection jobs = pq.GetPrintJobInfoCollection();

                    foreach (PrintSystemJobInfo job in jobs)
                    {
                        // Get default PrintTicket from printer
                        PrintTicket printTicket = pq.DefaultPrintTicket;

                        PrintCapabilities printCapabilites = pq.GetPrintCapabilities();

                        // Modify PrintTicket
                        if (printCapabilites.CollationCapability.Contains(Collation.Collated))
                        {
                            printTicket.Collation = Collation.Collated;
                        }

                        if (printCapabilites.DuplexingCapability.Contains(
                                Duplexing.TwoSidedLongEdge))
                        {
                            printTicket.Duplexing = Duplexing.TwoSidedLongEdge;
                        }

                        if (printCapabilites.StaplingCapability.Contains(Stapling.StapleDualLeft))
                        {
                            printTicket.Stapling = Stapling.StapleDualLeft;
                        }
                        job.Pause();
                        string[] row = new string[] { job.JobIdentifier.ToString(),
                                                  pq.Name,
                                                  job.Name,
                                                  job.JobStatus.ToString(),
                                                  job.Submitter,
                                                  (job.NumberOfPages).ToString(),
                                                  ((job.JobSize / 1024f) / 1024f).ToString("N2") + " MB",
                                                  job.TimeJobSubmitted.ToLocalTime().ToString() };
                        dataGridView1.Rows.Add(row);
                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                System.Printing.PrintServer myPrintServer = new System.Printing.PrintServer();
                PrintQueueCollection myPrintQueues = myPrintServer.GetPrintQueues();
                dataGridView1.Rows.Clear();
                foreach (PrintQueue pq in myPrintQueues)
                {
                    using (System.Printing.PrintServer ps = new System.Printing.PrintServer())
                    {
                        using (PrintQueue pq1 = new PrintQueue(ps, pq.Name,
                              PrintSystemDesiredAccess.AdministratePrinter))
                        {
                            pq1.Pause();
                        }
                    }
                }

            }
            catch (Exception ex)
            {

            }
            RefreshPrintJobs();
        }

        private static StringCollection GetPrintersCollection()
        {
            try
            {
                StringCollection printerNameCollection = new StringCollection();
                string searchQuery = "SELECT * FROM Win32_Printer";
                ManagementObjectSearcher searchPrinters =
                      new ManagementObjectSearcher(searchQuery);
                ManagementObjectCollection printerCollection = searchPrinters.Get();
                foreach (ManagementObject printer in printerCollection)
                {
                    printerNameCollection.Add(printer.Properties["Name"].Value.ToString());
                }
                return printerNameCollection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new StringCollection();

            }

        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RefreshPrintJobs();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = dataGridView1.SelectedRows[0].Cells["Id"].Value;
                DataForm F = new DataForm();
                F.printId = Convert.ToInt32(id);
                F.ShowDialog(this);
                RefreshPrintJobs();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshPrintJobs();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Are your sure you want to Cancel Print Job " + dataGridView1.SelectedRows[0].Cells[2].Value, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    System.Printing.PrintServer myPrintServer = new System.Printing.PrintServer();
                    PrintQueueCollection myPrintQueues = myPrintServer.GetPrintQueues();

                    foreach (PrintQueue pq in myPrintQueues)
                    {
                        pq.Refresh();
                        PrintJobInfoCollection jobs = pq.GetPrintJobInfoCollection();
                        foreach (PrintSystemJobInfo job in jobs)
                        {
                            if (job.JobIdentifier == Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value))
                            {
                                job.Cancel();
                            }
                        }
                    }
                }
                RefreshPrintJobs();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void print_Click(object sender, EventArgs e)
        {
            try
            {
                var id = dataGridView1.SelectedRows[0].Cells["Id"].Value;
                DataForm F = new DataForm();
                F.printId = Convert.ToInt32(id);
                F.ShowDialog(this);
                RefreshPrintJobs();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var result = (from x in db.PrintJobs
                          select new
                          {
                              x.Printer_Name,
                              x.Document_Name,
                              x.Document_Pages,
                              x.Submitted_By,
                              x.Submitted_At,
                              x.Username,
                              x.Customer.Customer_Name,
                              x.Customer.Customer_No
                          }).ToList();
            // Creating a Excel object. 
            dataGridView2.DataSource = result;

            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = workbook.ActiveSheet;

            worksheet.Name = "ExportedPrintJobData";

            int cellRowIndex = 1;
            int cellColumnIndex = 1;

            //Loop through each row and read value from each column. 
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                    if (cellRowIndex == 1)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView2.Columns[j].HeaderText;
                    }
                    else
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                    }
                    cellColumnIndex++;
                }
                cellColumnIndex = 1;
                cellRowIndex++;
            }

            //Getting the location and file name of the excel to save from user. 
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveDialog.FilterIndex = 2;

            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                workbook.SaveAs(saveDialog.FileName);
                MessageBox.Show("Export Successful");
            }
            excel.Quit();
            workbook = null;
            excel = null;

        }
    }
}
