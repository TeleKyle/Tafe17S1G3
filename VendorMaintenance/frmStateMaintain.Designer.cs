namespace VendorMaintenance
{
    partial class frmStateMaintain
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
            this.StateLable = new System.Windows.Forms.Label();
            this.comboState = new System.Windows.Forms.ComboBox();
            this.btnLoadState = new System.Windows.Forms.Button();
            this.txtFirstZIP = new System.Windows.Forms.TextBox();
            this.txtLastZIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StateLable
            // 
            this.StateLable.AutoSize = true;
            this.StateLable.Location = new System.Drawing.Point(9, 9);
            this.StateLable.Name = "StateLable";
            this.StateLable.Size = new System.Drawing.Size(32, 13);
            this.StateLable.TabIndex = 1;
            this.StateLable.Text = "State";
            this.StateLable.Click += new System.EventHandler(this.StateCode_Click);
            // 
            // comboState
            // 
            this.comboState.FormattingEnabled = true;
            this.comboState.Location = new System.Drawing.Point(12, 25);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(121, 21);
            this.comboState.TabIndex = 2;
            this.comboState.Tag = "State";
            // 
            // btnLoadState
            // 
            this.btnLoadState.Location = new System.Drawing.Point(160, 22);
            this.btnLoadState.Name = "btnLoadState";
            this.btnLoadState.Size = new System.Drawing.Size(75, 23);
            this.btnLoadState.TabIndex = 3;
            this.btnLoadState.Text = "Load State";
            this.btnLoadState.UseVisualStyleBackColor = true;
            this.btnLoadState.Click += new System.EventHandler(this.btnLoadState_Click);
            // 
            // txtFirstZIP
            // 
            this.txtFirstZIP.Enabled = false;
            this.txtFirstZIP.Location = new System.Drawing.Point(12, 69);
            this.txtFirstZIP.Name = "txtFirstZIP";
            this.txtFirstZIP.Size = new System.Drawing.Size(100, 20);
            this.txtFirstZIP.TabIndex = 4;
            // 
            // txtLastZIP
            // 
            this.txtLastZIP.Enabled = false;
            this.txtLastZIP.Location = new System.Drawing.Point(12, 112);
            this.txtLastZIP.Name = "txtLastZIP";
            this.txtLastZIP.Size = new System.Drawing.Size(100, 20);
            this.txtLastZIP.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First ZIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last ZIP";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(160, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(160, 86);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(160, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmStateMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastZIP);
            this.Controls.Add(this.txtFirstZIP);
            this.Controls.Add(this.btnLoadState);
            this.Controls.Add(this.comboState);
            this.Controls.Add(this.StateLable);
            this.Name = "frmStateMaintain";
            this.Text = "StateMaintain";
            this.Load += new System.EventHandler(this.StateMaintain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StateLable;
        private System.Windows.Forms.ComboBox comboState;
        private System.Windows.Forms.Button btnLoadState;
        private System.Windows.Forms.TextBox txtFirstZIP;
        private System.Windows.Forms.TextBox txtLastZIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

    }
}