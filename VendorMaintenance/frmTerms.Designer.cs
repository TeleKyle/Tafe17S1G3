namespace VendorMaintenance
{
    partial class frmTerms
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
            this.Delete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBoxDueDays = new System.Windows.Forms.TextBox();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetTermsID = new System.Windows.Forms.Button();
            this.TxtBoxTermsID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(188, 218);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 17;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(97, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtBoxDueDays
            // 
            this.txtBoxDueDays.Location = new System.Drawing.Point(86, 164);
            this.txtBoxDueDays.Name = "txtBoxDueDays";
            this.txtBoxDueDays.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDueDays.TabIndex = 15;
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Location = new System.Drawing.Point(24, 167);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(56, 13);
            this.DueDateLabel.TabIndex = 14;
            this.DueDateLabel.Text = "Due Date:";
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(27, 82);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(200, 66);
            this.txtBoxDescription.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Description:";
            // 
            // btnGetTermsID
            // 
            this.btnGetTermsID.Location = new System.Drawing.Point(149, 19);
            this.btnGetTermsID.Name = "btnGetTermsID";
            this.btnGetTermsID.Size = new System.Drawing.Size(75, 23);
            this.btnGetTermsID.TabIndex = 11;
            this.btnGetTermsID.Text = "Get TermsID";
            this.btnGetTermsID.UseVisualStyleBackColor = true;
            // 
            // TxtBoxTermsID
            // 
            this.TxtBoxTermsID.Location = new System.Drawing.Point(77, 21);
            this.TxtBoxTermsID.Name = "TxtBoxTermsID";
            this.TxtBoxTermsID.Size = new System.Drawing.Size(66, 20);
            this.TxtBoxTermsID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "TermsID:";
            // 
            // frmTerms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBoxDueDays);
            this.Controls.Add(this.DueDateLabel);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGetTermsID);
            this.Controls.Add(this.TxtBoxTermsID);
            this.Controls.Add(this.label2);
            this.Name = "frmTerms";
            this.Text = "frmTerms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxDueDays;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetTermsID;
        private System.Windows.Forms.TextBox TxtBoxTermsID;
        private System.Windows.Forms.Label label2;
    }
}