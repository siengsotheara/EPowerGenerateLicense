namespace EPowerGenerateLicense.Component
{
    partial class FormGenerateLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerLicenseGenerate = new System.Windows.Forms.DateTimePicker();
            this.txtSeason = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTake = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboFollowUpBy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "សម្រាប់ថ្ងៃទី";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "រដូវកាល";
            // 
            // dateTimePickerLicenseGenerate
            // 
            this.dateTimePickerLicenseGenerate.CustomFormat = "ថ្ងៃ dd -​ ខែ MM -​​ ឆ្នាំ yyy";
            this.dateTimePickerLicenseGenerate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerLicenseGenerate.Location = new System.Drawing.Point(191, 65);
            this.dateTimePickerLicenseGenerate.Name = "dateTimePickerLicenseGenerate";
            this.dateTimePickerLicenseGenerate.Size = new System.Drawing.Size(223, 29);
            this.dateTimePickerLicenseGenerate.TabIndex = 0;
            // 
            // txtSeason
            // 
            this.txtSeason.Enabled = false;
            this.txtSeason.Location = new System.Drawing.Point(191, 100);
            this.txtSeason.Name = "txtSeason";
            this.txtSeason.Size = new System.Drawing.Size(223, 29);
            this.txtSeason.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "ចេញម្តង";
            // 
            // cboTake
            // 
            this.cboTake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTake.FormattingEnabled = true;
            this.cboTake.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cboTake.Location = new System.Drawing.Point(191, 172);
            this.cboTake.Name = "cboTake";
            this.cboTake.Size = new System.Drawing.Size(223, 30);
            this.cboTake.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "៖";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "៖";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "៖";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(339, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "បោះបង់";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Location = new System.Drawing.Point(258, 244);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "ដំណើរការ";
            this.btnGenerate.UseSelectable = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "៖";
            // 
            // cboUser
            // 
            this.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cboUser.Location = new System.Drawing.Point(191, 135);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(223, 30);
            this.cboUser.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "ដោយ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Follow Up by";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 22);
            this.label10.TabIndex = 15;
            this.label10.Text = "៖";
            // 
            // cboFollowUpBy
            // 
            this.cboFollowUpBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFollowUpBy.FormattingEnabled = true;
            this.cboFollowUpBy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cboFollowUpBy.Location = new System.Drawing.Point(191, 208);
            this.cboFollowUpBy.Name = "cboFollowUpBy";
            this.cboFollowUpBy.Size = new System.Drawing.Size(223, 30);
            this.cboFollowUpBy.TabIndex = 16;
            // 
            // FormGenerateLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 276);
            this.Controls.Add(this.cboFollowUpBy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboTake);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSeason);
            this.Controls.Add(this.dateTimePickerLicenseGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGenerateLicense";
            this.Padding = new System.Windows.Forms.Padding(23, 102, 23, 34);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "ដំណើរការលេខអាជ្ញាប័ណ្ឌ";
            this.Load += new System.EventHandler(this.FormGenerateLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerLicenseGenerate;
        private System.Windows.Forms.TextBox txtSeason;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTake;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboFollowUpBy;
    }
}