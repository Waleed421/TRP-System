using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintJob
{
    public partial class DataForm : Form
    {
        public int printId = 0;
        int numberOfPages = 0;
        PrintJobDbEntities1 db = new PrintJobDbEntities1();
        public DataForm()
        {
            InitializeComponent();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            try
            {
                var result = (from x in db.Customers select new { x.Customer_Name, x.Id }).ToList();
                customerName.DataSource = result;
                customerName.DisplayMember = "Customer_Name";
                customerName.ValueMember = "Id";
                customerName.SelectedIndex = -1;

                var customerNumbers = (from x in db.Customers select new { x.Customer_No, x.Id }).ToList();
                customerNo.DataSource = customerNumbers;
                customerNo.DisplayMember = "Customer_No";
                customerNo.ValueMember = "Id";
                customerNo.SelectedIndex = -1;


                userName.Text = Main.userName;
                customerName.Text = Main.customerName;
                PrintServer myPrintServer = new PrintServer();
                PrintQueueCollection myPrintQueues = myPrintServer.GetPrintQueues();

                foreach (PrintQueue pq in myPrintQueues)
                {
                    pq.Refresh();
                    PrintJobInfoCollection jobs = pq.GetPrintJobInfoCollection();
                    foreach (PrintSystemJobInfo job in jobs)
                    {
                        if (job.JobIdentifier == printId)
                        {

                            printerName.Text = pq.Name;
                            documentName.Text = job.Name;
                            documentPages.Text = job.NumberOfPages.ToString();
                            submitted.Text = job.TimeJobSubmitted.ToLocalTime().ToString();
                            submittedBy.Text = job.Submitter.ToString();
                            numberOfPages = job.NumberOfPages;
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message);
            }

        }

        private void SaveAndPrint_Click(object sender, EventArgs e)
        {

            if (userName.Text == "" || customerName.Text == "")
            {
                MessageBox.Show("Data is incomplete");
            }
            else
            {
                PrintServer myPrintServer = new PrintServer();           
                PrintQueueCollection myPrintQueues = myPrintServer.GetPrintQueues();

                foreach (PrintQueue pq in myPrintQueues)

                {


                    pq.Refresh();
                    PrintJobInfoCollection jobs = pq.GetPrintJobInfoCollection();
                    foreach (PrintSystemJobInfo job in jobs)
                    {
                        if (job.JobIdentifier == printId)
                        {


                            if (pq.IsOffline)
                            {

                                MessageBox.Show("Printer is offline, printing paused. Please connect to printer and try again.");
                                this.Close();
                            }
                            else
                            {
                                using (PrintServer ps = new PrintServer())
                                {

                                    using (PrintQueue pq1 = new PrintQueue(ps, pq.Name,
                                          PrintSystemDesiredAccess.AdministratePrinter))
                                    {
                                        pq1.Resume();
                                    }
                                }
                                job.Resume();
                                PrintJob j = new PrintJob();
                                j.Printer_Name = printerName.Text;
                                j.Document_Name = documentName.Text;
                                j.Document_Pages = documentPages.Text;
                                j.Submitted_By = submittedBy.Text;
                                j.Submitted_At = Convert.ToDateTime(submitted.Text);
                                j.Username = userName.Text;
                                j.Customer_Id = Convert.ToInt32(customerName.SelectedValue);
                                db.PrintJobs.Add(j);
                                db.SaveChanges();

                                using (PrintServer ps = new PrintServer())
                                {
                                    using (PrintQueue pq1 = new PrintQueue(ps, pq.Name,
                                          PrintSystemDesiredAccess.AdministratePrinter))
                                    {
                                        pq1.Pause();
                                    }
                                }

                                MessageBox.Show("Print Job Saved !");
                                Main.userName = userName.Text;
                                Main.customerName = customerName.Text;
                                this.Close();

                            }

                        }

                    }

                }

            }


        }

        private void customerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(customerName.SelectedValue);
                var result = (from x in db.Customers where x.Id == id select x.Customer_No).FirstOrDefault();
                customerNo.Text = result;
            }
            catch (Exception ex)
            {


            }

        }

        private void numberOfCopies_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                documentPages.Text = (numberOfCopies.Value * numberOfPages).ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void customerNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(customerNo.SelectedValue);
                var result = (from x in db.Customers where x.Id == id select x.Customer_Name).FirstOrDefault();
                customerName.Text = result;
            }
            catch (Exception ex)
            {


            }
        }
    }
}
