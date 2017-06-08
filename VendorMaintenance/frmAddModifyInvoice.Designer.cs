namespace VendorMaintenance
{
    partial class frmAddModifyInvoice
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
            this.txtCreditTotal = new System.Windows.Forms.TextBox();
            this.txtPaymentTotal = new System.Windows.Forms.TextBox();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.txtInvoiceNum = new System.Windows.Forms.TextBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblCredTotal = new System.Windows.Forms.Label();
            this.lblPayTotal = new System.Windows.Forms.Label();
            this.lblInvoiceTotal = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.cboVendor = new System.Windows.Forms.ComboBox();
            this.cboTerm = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.dtiInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.dtiDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtiPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtCreditTotal
            // 
            this.txtCreditTotal.Location = new System.Drawing.Point(136, 170);
            this.txtCreditTotal.Name = "txtCreditTotal";
            this.txtCreditTotal.Size = new System.Drawing.Size(307, 20);
            this.txtCreditTotal.TabIndex = 23;
            // 
            // txtPaymentTotal
            // 
            this.txtPaymentTotal.Location = new System.Drawing.Point(136, 145);
            this.txtPaymentTotal.Name = "txtPaymentTotal";
            this.txtPaymentTotal.Size = new System.Drawing.Size(307, 20);
            this.txtPaymentTotal.TabIndex = 22;
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Location = new System.Drawing.Point(136, 120);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.Size = new System.Drawing.Size(307, 20);
            this.txtInvoiceTotal.TabIndex = 21;
            // 
            // txtInvoiceNum
            // 
            this.txtInvoiceNum.Location = new System.Drawing.Point(136, 70);
            this.txtInvoiceNum.Name = "txtInvoiceNum";
            this.txtInvoiceNum.Size = new System.Drawing.Size(307, 20);
            this.txtInvoiceNum.TabIndex = 19;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(13, 221);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(87, 15);
            this.lblPaymentDate.TabIndex = 14;
            this.lblPaymentDate.Text = "Payment Date:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(13, 196);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(62, 15);
            this.lblDueDate.TabIndex = 12;
            this.lblDueDate.Text = "Due Date:";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(13, 45);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(36, 15);
            this.lblTerm.TabIndex = 11;
            this.lblTerm.Text = "Term";
            // 
            // lblCredTotal
            // 
            this.lblCredTotal.AutoSize = true;
            this.lblCredTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredTotal.Location = new System.Drawing.Point(13, 170);
            this.lblCredTotal.Name = "lblCredTotal";
            this.lblCredTotal.Size = new System.Drawing.Size(72, 15);
            this.lblCredTotal.TabIndex = 10;
            this.lblCredTotal.Text = "Credit Total:";
            // 
            // lblPayTotal
            // 
            this.lblPayTotal.AutoSize = true;
            this.lblPayTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayTotal.Location = new System.Drawing.Point(13, 145);
            this.lblPayTotal.Name = "lblPayTotal";
            this.lblPayTotal.Size = new System.Drawing.Size(88, 15);
            this.lblPayTotal.TabIndex = 9;
            this.lblPayTotal.Text = "Payment Total:";
            // 
            // lblInvoiceTotal
            // 
            this.lblInvoiceTotal.AutoSize = true;
            this.lblInvoiceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTotal.Location = new System.Drawing.Point(13, 120);
            this.lblInvoiceTotal.Name = "lblInvoiceTotal";
            this.lblInvoiceTotal.Size = new System.Drawing.Size(78, 15);
            this.lblInvoiceTotal.TabIndex = 8;
            this.lblInvoiceTotal.Text = "Invoice Total:";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(13, 95);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(77, 15);
            this.lblInvoiceDate.TabIndex = 7;
            this.lblInvoiceDate.Text = "Invoice Date:";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumber.Location = new System.Drawing.Point(13, 70);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(96, 15);
            this.lblInvoiceNumber.TabIndex = 6;
            this.lblInvoiceNumber.Text = "Invoice Number:";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendor.Location = new System.Drawing.Point(13, 21);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(49, 15);
            this.lblVendor.TabIndex = 5;
            this.lblVendor.Text = "Vendor:";
            // 
            // cboVendor
            // 
            this.cboVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendor.FormattingEnabled = true;
            this.cboVendor.Location = new System.Drawing.Point(136, 17);
            this.cboVendor.Name = "cboVendor";
            this.cboVendor.Size = new System.Drawing.Size(121, 21);
            this.cboVendor.TabIndex = 29;
            // 
            // cboTerm
            // 
            this.cboTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerm.FormattingEnabled = true;
            this.cboTerm.Location = new System.Drawing.Point(136, 44);
            this.cboTerm.Name = "cboTerm";
            this.cboTerm.Size = new System.Drawing.Size(121, 21);
            this.cboTerm.TabIndex = 29;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(368, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(136, 256);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 30;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // dtiInvoiceDate
            // 
            this.dtiInvoiceDate.Location = new System.Drawing.Point(136, 95);
            this.dtiInvoiceDate.Name = "dtiInvoiceDate";
            this.dtiInvoiceDate.Size = new System.Drawing.Size(307, 20);
            this.dtiInvoiceDate.TabIndex = 32;
            // 
            // dtiDueDate
            // 
            this.dtiDueDate.Location = new System.Drawing.Point(136, 196);
            this.dtiDueDate.Name = "dtiDueDate";
            this.dtiDueDate.Size = new System.Drawing.Size(307, 20);
            this.dtiDueDate.TabIndex = 32;
            // 
            // dtiPaymentDate
            // 
            this.dtiPaymentDate.Location = new System.Drawing.Point(136, 221);
            this.dtiPaymentDate.Name = "dtiPaymentDate";
            this.dtiPaymentDate.Size = new System.Drawing.Size(307, 20);
            this.dtiPaymentDate.TabIndex = 32;
            // 
            // frmAddModifyInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 291);
            this.Controls.Add(this.dtiPaymentDate);
            this.Controls.Add(this.dtiDueDate);
            this.Controls.Add(this.dtiInvoiceDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cboTerm);
            this.Controls.Add(this.cboVendor);
            this.Controls.Add(this.txtCreditTotal);
            this.Controls.Add(this.txtPaymentTotal);
            this.Controls.Add(this.txtInvoiceTotal);
            this.Controls.Add(this.txtInvoiceNum);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblCredTotal);
            this.Controls.Add(this.lblPayTotal);
            this.Controls.Add(this.lblInvoiceTotal);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.lblInvoiceNumber);
            this.Controls.Add(this.lblVendor);
            this.Name = "frmAddModifyInvoice";
            this.Text = "Add/Modify Invoice";
            this.Load += new System.EventHandler(this.frmAddModifyInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCreditTotal;
        private System.Windows.Forms.TextBox txtPaymentTotal;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.TextBox txtInvoiceNum;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblCredTotal;
        private System.Windows.Forms.Label lblPayTotal;
        private System.Windows.Forms.Label lblInvoiceTotal;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.ComboBox cboVendor;
        private System.Windows.Forms.ComboBox cboTerm;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DateTimePicker dtiInvoiceDate;
        private System.Windows.Forms.DateTimePicker dtiDueDate;
        private System.Windows.Forms.DateTimePicker dtiPaymentDate;
    }
}