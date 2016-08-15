namespace PrintJob
{
    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.documentPages = new System.Windows.Forms.TextBox();
            this.documentName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labeel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printerName = new System.Windows.Forms.TextBox();
            this.submittedBy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submitted = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.ComboBox();
            this.SaveAndPrint = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numberOfCopies = new System.Windows.Forms.NumericUpDown();
            this.customerNo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // documentPages
            // 
            this.documentPages.Location = new System.Drawing.Point(211, 206);
            this.documentPages.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.documentPages.Name = "documentPages";
            this.documentPages.ReadOnly = true;
            this.documentPages.Size = new System.Drawing.Size(658, 21);
            this.documentPages.TabIndex = 199;
            this.documentPages.TabStop = false;
            // 
            // documentName
            // 
            this.documentName.Location = new System.Drawing.Point(211, 67);
            this.documentName.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.documentName.Name = "documentName";
            this.documentName.ReadOnly = true;
            this.documentName.Size = new System.Drawing.Size(658, 21);
            this.documentName.TabIndex = 198;
            this.documentName.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 204;
            this.label8.Text = "Document Pages :";
            // 
            // labeel
            // 
            this.labeel.AutoSize = true;
            this.labeel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.labeel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeel.Location = new System.Drawing.Point(40, 67);
            this.labeel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeel.Name = "labeel";
            this.labeel.Size = new System.Drawing.Size(121, 16);
            this.labeel.TabIndex = 203;
            this.labeel.Text = "Document Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 202;
            this.label1.Text = "Printer Name :";
            // 
            // printerName
            // 
            this.printerName.Location = new System.Drawing.Point(211, 33);
            this.printerName.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.printerName.Name = "printerName";
            this.printerName.ReadOnly = true;
            this.printerName.Size = new System.Drawing.Size(658, 21);
            this.printerName.TabIndex = 197;
            this.printerName.TabStop = false;
            // 
            // submittedBy
            // 
            this.submittedBy.Location = new System.Drawing.Point(211, 102);
            this.submittedBy.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.submittedBy.Name = "submittedBy";
            this.submittedBy.ReadOnly = true;
            this.submittedBy.Size = new System.Drawing.Size(658, 21);
            this.submittedBy.TabIndex = 206;
            this.submittedBy.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 207;
            this.label2.Text = "Submitted By :";
            // 
            // submitted
            // 
            this.submitted.Location = new System.Drawing.Point(211, 136);
            this.submitted.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.submitted.Name = "submitted";
            this.submitted.ReadOnly = true;
            this.submitted.Size = new System.Drawing.Size(658, 21);
            this.submitted.TabIndex = 208;
            this.submitted.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 136);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 209;
            this.label9.Text = "Submitted At:";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(211, 241);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(658, 21);
            this.userName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 211;
            this.label3.Text = "User Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 213;
            this.label4.Text = "Customer Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 215;
            this.label5.Text = "Customer No :";
            // 
            // customerName
            // 
            this.customerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customerName.FormattingEnabled = true;
            this.customerName.Location = new System.Drawing.Point(211, 275);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(658, 21);
            this.customerName.TabIndex = 1;
            this.customerName.SelectedIndexChanged += new System.EventHandler(this.customerName_SelectedIndexChanged);
            // 
            // SaveAndPrint
            // 
            this.SaveAndPrint.Location = new System.Drawing.Point(211, 349);
            this.SaveAndPrint.Name = "SaveAndPrint";
            this.SaveAndPrint.Size = new System.Drawing.Size(104, 23);
            this.SaveAndPrint.TabIndex = 3;
            this.SaveAndPrint.Text = "Save and Print";
            this.SaveAndPrint.UseVisualStyleBackColor = true;
            this.SaveAndPrint.Click += new System.EventHandler(this.SaveAndPrint_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 220;
            this.label6.Text = "Number Of Copies  :";
            // 
            // numberOfCopies
            // 
            this.numberOfCopies.Location = new System.Drawing.Point(211, 171);
            this.numberOfCopies.Name = "numberOfCopies";
            this.numberOfCopies.Size = new System.Drawing.Size(658, 21);
            this.numberOfCopies.TabIndex = 5;
            this.numberOfCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfCopies.ValueChanged += new System.EventHandler(this.numberOfCopies_ValueChanged);
            // 
            // customerNo
            // 
            this.customerNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customerNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customerNo.FormattingEnabled = true;
            this.customerNo.Location = new System.Drawing.Point(211, 309);
            this.customerNo.Name = "customerNo";
            this.customerNo.Size = new System.Drawing.Size(658, 21);
            this.customerNo.TabIndex = 2;
            this.customerNo.SelectedIndexChanged += new System.EventHandler(this.customerNo_SelectedIndexChanged);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 386);
            this.Controls.Add(this.customerNo);
            this.Controls.Add(this.numberOfCopies);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SaveAndPrint);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submitted);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.submittedBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.documentPages);
            this.Controls.Add(this.documentName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labeel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printerName);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DataForm";
            this.Text = "Print Job Data";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox documentPages;
        private System.Windows.Forms.TextBox documentName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labeel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox printerName;
        private System.Windows.Forms.TextBox submittedBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox submitted;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox customerName;
        private System.Windows.Forms.Button SaveAndPrint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numberOfCopies;
        private System.Windows.Forms.ComboBox customerNo;
    }
}