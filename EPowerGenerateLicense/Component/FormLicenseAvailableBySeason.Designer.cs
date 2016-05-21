namespace EPowerGenerateLicense.Component
{
    partial class FormLicenseAvailableBySeason
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewLicense = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLicense
            // 
            this.dataGridViewLicense.AllowUserToAddRows = false;
            this.dataGridViewLicense.AllowUserToDeleteRows = false;
            this.dataGridViewLicense.AllowUserToResizeColumns = false;
            this.dataGridViewLicense.AllowUserToResizeRows = false;
            this.dataGridViewLicense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLicense.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLicense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLicense.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLicense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLicense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewLicense.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLicense.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLicense.EnableHeadersVisualStyles = false;
            this.dataGridViewLicense.Location = new System.Drawing.Point(5, 60);
            this.dataGridViewLicense.MultiSelect = false;
            this.dataGridViewLicense.Name = "dataGridViewLicense";
            this.dataGridViewLicense.ReadOnly = true;
            this.dataGridViewLicense.RowHeadersVisible = false;
            this.dataGridViewLicense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLicense.Size = new System.Drawing.Size(680, 335);
            this.dataGridViewLicense.TabIndex = 3;
            this.dataGridViewLicense.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewLicense_CellFormatting);
            this.dataGridViewLicense.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewLicense_DataBindingComplete);
            this.dataGridViewLicense.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewLicense_RowPrePaint);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "LICENSE_NUMBER";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS System", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FillWeight = 35.97894F;
            this.Column1.HeaderText = "លេខគណនី";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ACCOUNT_NAME";
            this.Column2.FillWeight = 140.0721F;
            this.Column2.HeaderText = "ឈ្មោះគណនី";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CONTACT_NAME";
            this.Column3.FillWeight = 86.43465F;
            this.Column3.HeaderText = "ទំនាក់ទំនង";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PHONE";
            this.Column4.FillWeight = 120.4686F;
            this.Column4.HeaderText = "ទូរស័ព្ទ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ADDRESS";
            this.Column5.FillWeight = 150.0457F;
            this.Column5.HeaderText = "អសយដ្ខាន";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "COLOR_ID";
            this.Column6.HeaderText = "COLOR_ID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // FormLicenseAvailableBySeason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 400);
            this.Controls.Add(this.dataGridViewLicense);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLicenseAvailableBySeason";
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 5);
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "អាជ្ញាប័ណ្ឌមិនទាន់ចេញ";
            this.Load += new System.EventHandler(this.FormLicenseAvailableBySeason_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}