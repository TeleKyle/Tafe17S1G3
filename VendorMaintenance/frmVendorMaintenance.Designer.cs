namespace VendorMaintenance
{
    partial class frmVendorMaintenance
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnGetVendor = new System.Windows.Forms.Button();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();            this.btnGoToInvoices = new System.Windows.Forms.Button();            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            this.btnExit.Name = "btnExit";

            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;

            this.btnDelete.Name = "btnDelete";

            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;

            this.btnModify.Name = "btnModify";

            this.btnModify.TabIndex = 48;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 

            this.btnAdd.Name = "btnAdd";

            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtState
            // 

            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;

            this.txtState.TabIndex = 46;
            this.txtState.TabStop = false;
            // 
            // btnGetVendor
            // 

            this.btnGetVendor.Name = "btnGetVendor";

            this.btnGetVendor.TabIndex = 45;
            this.btnGetVendor.Text = "Get Vendor";
            this.btnGetVendor.UseVisualStyleBackColor = true;
            this.btnGetVendor.Click += new System.EventHandler(this.btnGetVendor_Click);
            // 
            // txtVendorID
            // 

            this.txtVendorID.Name = "txtVendorID";

            this.txtVendorID.TabIndex = 44;
            this.txtVendorID.Tag = "Vendor ID";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;

            this.Label1.Name = "Label1";

            this.Label1.TabIndex = 43;
            this.Label1.Text = "Vendor ID:";
            // 
            // txtZipCode
            // 

            this.txtZipCode.MaxLength = 20;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.ReadOnly = true;

            this.txtZipCode.TabIndex = 42;
            this.txtZipCode.TabStop = false;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;

            this.Label7.Name = "Label7";

            this.Label7.TabIndex = 41;
            this.Label7.Text = "Zip code:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;

            this.Label6.Name = "Label6";

            this.Label6.TabIndex = 40;
            this.Label6.Text = "State:";
            // 
            // txtCity
            // 

            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;

            this.txtCity.TabIndex = 39;
            this.txtCity.TabStop = false;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;

            this.Label5.Name = "Label5";

            this.Label5.TabIndex = 38;
            this.Label5.Text = "City:";
            // 
            // txtAddress2
            // 

            this.txtAddress2.MaxLength = 50;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.ReadOnly = true;

            this.txtAddress2.TabIndex = 37;
            this.txtAddress2.TabStop = false;
            // 
            // txtAddress1
            // 

            this.txtAddress1.MaxLength = 50;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.ReadOnly = true;

            this.txtAddress1.TabIndex = 36;
            this.txtAddress1.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;

            this.Label3.Name = "Label3";

            this.Label3.TabIndex = 35;
            this.Label3.Text = "Address:";
            // 
            // txtName
            // 

            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;

            this.txtName.TabIndex = 34;
            this.txtName.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;

            this.Label2.Name = "Label2";

            this.Label2.TabIndex = 33;
            this.Label2.Text = "Name:";
            // 
// button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "State";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);            // btnGoToInvoices
            // 
            this.btnGoToInvoices.Location = new System.Drawing.Point(18, 239);
            this.btnGoToInvoices.Name = "btnGoToInvoices";
            this.btnGoToInvoices.Size = new System.Drawing.Size(93, 23);
            this.btnGoToInvoices.TabIndex = 51;
            this.btnGoToInvoices.Text = "Go To Invoices";
            this.btnGoToInvoices.UseVisualStyleBackColor = true;
            this.btnGoToInvoices.Click += new System.EventHandler(this.btnGoToInvoices_Click);
            //             // frmVendorMaintenance
            // 

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
this.ClientSize = new System.Drawing.Size(380, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGoToInvoices);            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.btnGetVendor);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVendorMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnModify;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.TextBox txtState;
        internal System.Windows.Forms.Button btnGetVendor;
        internal System.Windows.Forms.TextBox txtVendorID;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtZipCode;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtAddress2;
        internal System.Windows.Forms.TextBox txtAddress1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btnGoToInvoices;
        private System.Windows.Forms.Button button1;    }
}

