namespace VendorMaintenance
{
    partial class frmInvoice
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
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblInvoiceTotal = new System.Windows.Forms.Label();
            this.lblPayTotal = new System.Windows.Forms.Label();
            this.lblCredTotal = new System.Windows.Forms.Label();
            this.lblTermsID = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.btnGetInvoice = new System.Windows.Forms.Button();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.txtInvoiceNum = new System.Windows.Forms.TextBox();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.txtPaymentTotal = new System.Windows.Forms.TextBox();
            this.txtCreditTotal = new System.Windows.Forms.TextBox();
            this.txtTermsID = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.txtPaymentDate = new System.Windows.Forms.TextBox();
            this.lblInvSeq = new System.Windows.Forms.Label();
            this.listInvoiceSequence = new System.Windows.Forms.ListBox();
            this.lblAccountNum = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtAccountNum = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddInv = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddInvSeq = new System.Windows.Forms.Button();
            this.btnModifyInvSeq = new System.Windows.Forms.Button();
            this.btnDeleteInvoiceItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceID.Location = new System.Drawing.Point(12, 20);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(63, 15);
            this.lblInvoiceID.TabIndex = 0;
            this.lblInvoiceID.Text = "Invoice ID:";
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorID.Location = new System.Drawing.Point(12, 60);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(64, 15);
            this.lblVendorID.TabIndex = 0;
            this.lblVendorID.Text = "Vendor ID:";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumber.Location = new System.Drawing.Point(12, 85);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(96, 15);
            this.lblInvoiceNumber.TabIndex = 0;
            this.lblInvoiceNumber.Text = "Invoice Number:";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(12, 110);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(77, 15);
            this.lblInvoiceDate.TabIndex = 0;
            this.lblInvoiceDate.Text = "Invoice Date:";
            // 
            // lblInvoiceTotal
            // 
            this.lblInvoiceTotal.AutoSize = true;
            this.lblInvoiceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTotal.Location = new System.Drawing.Point(12, 135);
            this.lblInvoiceTotal.Name = "lblInvoiceTotal";
            this.lblInvoiceTotal.Size = new System.Drawing.Size(78, 15);
            this.lblInvoiceTotal.TabIndex = 0;
            this.lblInvoiceTotal.Text = "Invoice Total:";
            // 
            // lblPayTotal
            // 
            this.lblPayTotal.AutoSize = true;
            this.lblPayTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayTotal.Location = new System.Drawing.Point(12, 160);
            this.lblPayTotal.Name = "lblPayTotal";
            this.lblPayTotal.Size = new System.Drawing.Size(88, 15);
            this.lblPayTotal.TabIndex = 0;
            this.lblPayTotal.Text = "Payment Total:";
            // 
            // lblCredTotal
            // 
            this.lblCredTotal.AutoSize = true;
            this.lblCredTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredTotal.Location = new System.Drawing.Point(12, 185);
            this.lblCredTotal.Name = "lblCredTotal";
            this.lblCredTotal.Size = new System.Drawing.Size(72, 15);
            this.lblCredTotal.TabIndex = 0;
            this.lblCredTotal.Text = "Credit Total:";
            // 
            // lblTermsID
            // 
            this.lblTermsID.AutoSize = true;
            this.lblTermsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermsID.Location = new System.Drawing.Point(12, 210);
            this.lblTermsID.Name = "lblTermsID";
            this.lblTermsID.Size = new System.Drawing.Size(60, 15);
            this.lblTermsID.TabIndex = 0;
            this.lblTermsID.Text = "Terms ID:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(12, 235);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(62, 15);
            this.lblDueDate.TabIndex = 0;
            this.lblDueDate.Text = "Due Date:";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(12, 260);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(87, 15);
            this.lblPaymentDate.TabIndex = 0;
            this.lblPaymentDate.Text = "Payment Date:";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Location = new System.Drawing.Point(135, 20);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(90, 20);
            this.txtInvoiceID.TabIndex = 1;
            // 
            // btnGetInvoice
            // 
            this.btnGetInvoice.Location = new System.Drawing.Point(231, 19);
            this.btnGetInvoice.Name = "btnGetInvoice";
            this.btnGetInvoice.Size = new System.Drawing.Size(75, 22);
            this.btnGetInvoice.TabIndex = 2;
            this.btnGetInvoice.Text = "Get Invoice";
            this.btnGetInvoice.UseVisualStyleBackColor = true;
            this.btnGetInvoice.Click += new System.EventHandler(this.btnGetInvoice_Click);
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(135, 60);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.ReadOnly = true;
            this.txtVendorID.Size = new System.Drawing.Size(307, 20);
            this.txtVendorID.TabIndex = 1;
            // 
            // txtInvoiceNum
            // 
            this.txtInvoiceNum.Location = new System.Drawing.Point(135, 85);
            this.txtInvoiceNum.Name = "txtInvoiceNum";
            this.txtInvoiceNum.ReadOnly = true;
            this.txtInvoiceNum.Size = new System.Drawing.Size(307, 20);
            this.txtInvoiceNum.TabIndex = 1;
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(135, 110);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.ReadOnly = true;
            this.txtInvoiceDate.Size = new System.Drawing.Size(307, 20);
            this.txtInvoiceDate.TabIndex = 1;
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Location = new System.Drawing.Point(135, 135);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.ReadOnly = true;
            this.txtInvoiceTotal.Size = new System.Drawing.Size(307, 20);
            this.txtInvoiceTotal.TabIndex = 1;
            // 
            // txtPaymentTotal
            // 
            this.txtPaymentTotal.Location = new System.Drawing.Point(135, 160);
            this.txtPaymentTotal.Name = "txtPaymentTotal";
            this.txtPaymentTotal.ReadOnly = true;
            this.txtPaymentTotal.Size = new System.Drawing.Size(307, 20);
            this.txtPaymentTotal.TabIndex = 1;
            // 
            // txtCreditTotal
            // 
            this.txtCreditTotal.Location = new System.Drawing.Point(135, 185);
            this.txtCreditTotal.Name = "txtCreditTotal";
            this.txtCreditTotal.ReadOnly = true;
            this.txtCreditTotal.Size = new System.Drawing.Size(307, 20);
            this.txtCreditTotal.TabIndex = 1;
            // 
            // txtTermsID
            // 
            this.txtTermsID.Location = new System.Drawing.Point(135, 210);
            this.txtTermsID.Name = "txtTermsID";
            this.txtTermsID.ReadOnly = true;
            this.txtTermsID.Size = new System.Drawing.Size(307, 20);
            this.txtTermsID.TabIndex = 1;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(135, 235);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.ReadOnly = true;
            this.txtDueDate.Size = new System.Drawing.Size(307, 20);
            this.txtDueDate.TabIndex = 1;
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.Location = new System.Drawing.Point(135, 260);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.ReadOnly = true;
            this.txtPaymentDate.Size = new System.Drawing.Size(307, 20);
            this.txtPaymentDate.TabIndex = 1;
            // 
            // lblInvSeq
            // 
            this.lblInvSeq.AutoSize = true;
            this.lblInvSeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvSeq.Location = new System.Drawing.Point(12, 330);
            this.lblInvSeq.Name = "lblInvSeq";
            this.lblInvSeq.Size = new System.Drawing.Size(107, 15);
            this.lblInvSeq.TabIndex = 0;
            this.lblInvSeq.Text = "Invoice Sequence:";
            // 
            // listInvoiceSequence
            // 
            this.listInvoiceSequence.FormattingEnabled = true;
            this.listInvoiceSequence.Location = new System.Drawing.Point(135, 330);
            this.listInvoiceSequence.Name = "listInvoiceSequence";
            this.listInvoiceSequence.Size = new System.Drawing.Size(65, 82);
            this.listInvoiceSequence.TabIndex = 3;
            this.listInvoiceSequence.SelectedIndexChanged += new System.EventHandler(this.listInvoiceSequence_SelectedIndexChanged);
            // 
            // lblAccountNum
            // 
            this.lblAccountNum.AutoSize = true;
            this.lblAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNum.Location = new System.Drawing.Point(12, 418);
            this.lblAccountNum.Name = "lblAccountNum";
            this.lblAccountNum.Size = new System.Drawing.Size(101, 15);
            this.lblAccountNum.TabIndex = 0;
            this.lblAccountNum.Text = "Account Number:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(12, 443);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 15);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 468);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 15);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            // 
            // txtAccountNum
            // 
            this.txtAccountNum.Location = new System.Drawing.Point(135, 418);
            this.txtAccountNum.Name = "txtAccountNum";
            this.txtAccountNum.ReadOnly = true;
            this.txtAccountNum.Size = new System.Drawing.Size(307, 20);
            this.txtAccountNum.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(135, 443);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(307, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(135, 468);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(307, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // btnAddInv
            // 
            this.btnAddInv.Location = new System.Drawing.Point(135, 286);
            this.btnAddInv.Name = "btnAddInv";
            this.btnAddInv.Size = new System.Drawing.Size(75, 23);
            this.btnAddInv.TabIndex = 4;
            this.btnAddInv.Text = "Add Invoice";
            this.btnAddInv.UseVisualStyleBackColor = true;
            this.btnAddInv.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(367, 530);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(255, 286);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(96, 23);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "Modify Invoice";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(357, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DeleteInvoice";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddInvSeq
            // 
            this.btnAddInvSeq.Enabled = false;
            this.btnAddInvSeq.Location = new System.Drawing.Point(135, 494);
            this.btnAddInvSeq.Name = "btnAddInvSeq";
            this.btnAddInvSeq.Size = new System.Drawing.Size(103, 23);
            this.btnAddInvSeq.TabIndex = 4;
            this.btnAddInvSeq.Text = "Add Invoice Item";
            this.btnAddInvSeq.UseVisualStyleBackColor = true;
            this.btnAddInvSeq.Click += new System.EventHandler(this.btnAddInvoiceSeq_Click);
            // 
            // btnModifyInvSeq
            // 
            this.btnModifyInvSeq.Enabled = false;
            this.btnModifyInvSeq.Location = new System.Drawing.Point(244, 494);
            this.btnModifyInvSeq.Name = "btnModifyInvSeq";
            this.btnModifyInvSeq.Size = new System.Drawing.Size(117, 23);
            this.btnModifyInvSeq.TabIndex = 4;
            this.btnModifyInvSeq.Text = "Modify Invoice Item";
            this.btnModifyInvSeq.UseVisualStyleBackColor = true;
            this.btnModifyInvSeq.Click += new System.EventHandler(this.btnModifyListItem_Click);
            // 
            // btnDeleteInvoiceItem
            // 
            this.btnDeleteInvoiceItem.Enabled = false;
            this.btnDeleteInvoiceItem.Location = new System.Drawing.Point(367, 494);
            this.btnDeleteInvoiceItem.Name = "btnDeleteInvoiceItem";
            this.btnDeleteInvoiceItem.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteInvoiceItem.TabIndex = 4;
            this.btnDeleteInvoiceItem.Text = "Delete Item";
            this.btnDeleteInvoiceItem.UseVisualStyleBackColor = true;
            this.btnDeleteInvoiceItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 566);
            this.Controls.Add(this.btnDeleteInvoiceItem);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModifyInvSeq);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddInvSeq);
            this.Controls.Add(this.btnAddInv);
            this.Controls.Add(this.listInvoiceSequence);
            this.Controls.Add(this.btnGetInvoice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPaymentDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.txtAccountNum);
            this.Controls.Add(this.txtTermsID);
            this.Controls.Add(this.txtCreditTotal);
            this.Controls.Add(this.txtPaymentTotal);
            this.Controls.Add(this.txtInvoiceTotal);
            this.Controls.Add(this.txtInvoiceDate);
            this.Controls.Add(this.txtInvoiceNum);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.txtInvoiceID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.lblAccountNum);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblTermsID);
            this.Controls.Add(this.lblCredTotal);
            this.Controls.Add(this.lblPayTotal);
            this.Controls.Add(this.lblInvoiceTotal);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.lblInvoiceNumber);
            this.Controls.Add(this.lblVendorID);
            this.Controls.Add(this.lblInvSeq);
            this.Controls.Add(this.lblInvoiceID);
            this.Name = "frmInvoice";
            this.Text = "Invoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceTotal;
        private System.Windows.Forms.Label lblPayTotal;
        private System.Windows.Forms.Label lblCredTotal;
        private System.Windows.Forms.Label lblTermsID;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Button btnGetInvoice;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.TextBox txtInvoiceNum;
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.TextBox txtPaymentTotal;
        private System.Windows.Forms.TextBox txtCreditTotal;
        private System.Windows.Forms.TextBox txtTermsID;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.TextBox txtPaymentDate;
        private System.Windows.Forms.Label lblInvSeq;
        private System.Windows.Forms.ListBox listInvoiceSequence;
        private System.Windows.Forms.Label lblAccountNum;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtAccountNum;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddInv;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddInvSeq;
        private System.Windows.Forms.Button btnModifyInvSeq;
        private System.Windows.Forms.Button btnDeleteInvoiceItem;
    }
}