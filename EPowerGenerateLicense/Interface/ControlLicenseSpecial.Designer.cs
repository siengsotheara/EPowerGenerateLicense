namespace EPowerGenerateLicense.Interface
{
    partial class ControlLicenseSpecial
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNew = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewLicense = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LICENSE_TYPE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTACT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVINCE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISTRICT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMMUNE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VILLAGE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_ACTIVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOR_ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.btnAddNew);
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(5, 0);
            this.panel4.MaximumSize = new System.Drawing.Size(0, 60);
            this.panel4.MinimumSize = new System.Drawing.Size(0, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1135, 60);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.panel1.Size = new System.Drawing.Size(1135, 24);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "គណនីពិសេស";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Highlight = true;
            this.btnAddNew.Location = new System.Drawing.Point(907, 30);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(71, 23);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "បន្ថែមថ្មី";
            this.btnAddNew.UseSelectable = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Highlight = true;
            this.btnEdit.Location = new System.Drawing.Point(984, 30);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "កែប្រែ";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Highlight = true;
            this.btnDelete.Location = new System.Drawing.Point(1061, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(3, 31);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "ស្វែងរក";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowButton = true;
            this.txtSearch.ShowClearButton = true;
            this.txtSearch.Size = new System.Drawing.Size(223, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "ស្វែងរក";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.dataGridViewLicense);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(1135, 431);
            this.panel3.TabIndex = 2;
            // 
            // dataGridViewLicense
            // 
            this.dataGridViewLicense.AllowUserToAddRows = false;
            this.dataGridViewLicense.AllowUserToDeleteRows = false;
            this.dataGridViewLicense.AllowUserToResizeColumns = false;
            this.dataGridViewLicense.AllowUserToResizeRows = false;
            this.dataGridViewLicense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLicense.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.ID,
            this.LICENSE_TYPE_ID,
            this.ACCOUNT_NO,
            this.ACCOUNT_NAME,
            this.PHONE,
            this.EMAIL,
            this.CONTACT_NAME,
            this.ADDRESS,
            this.PROVINCE_NAME,
            this.DISTRICT_NAME,
            this.COMMUNE_NAME,
            this.VILLAGE_NAME,
            this.IS_ACTIVE,
            this.COLOR_ID1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLicense.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLicense.EnableHeadersVisualStyles = false;
            this.dataGridViewLicense.Location = new System.Drawing.Point(2, 0);
            this.dataGridViewLicense.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridViewLicense.MultiSelect = false;
            this.dataGridViewLicense.Name = "dataGridViewLicense";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLicense.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewLicense.RowHeadersVisible = false;
            this.dataGridViewLicense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLicense.Size = new System.Drawing.Size(1133, 431);
            this.dataGridViewLicense.TabIndex = 7;
            this.dataGridViewLicense.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewLicense_CellFormatting);
            this.dataGridViewLicense.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewLicense_RowPrePaint);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "LICENSE_ID";
            this.ID.HeaderText = "LICENSE_ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // LICENSE_TYPE_ID
            // 
            this.LICENSE_TYPE_ID.DataPropertyName = "LICENSE_TYPE_ID";
            this.LICENSE_TYPE_ID.HeaderText = "LICENSE_TYPE_ID";
            this.LICENSE_TYPE_ID.Name = "LICENSE_TYPE_ID";
            this.LICENSE_TYPE_ID.Visible = false;
            // 
            // ACCOUNT_NO
            // 
            this.ACCOUNT_NO.DataPropertyName = "ACCOUNT_NO";
            this.ACCOUNT_NO.FillWeight = 30.45685F;
            this.ACCOUNT_NO.HeaderText = "លេខកូថ";
            this.ACCOUNT_NO.Name = "ACCOUNT_NO";
            this.ACCOUNT_NO.ReadOnly = true;
            this.ACCOUNT_NO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ACCOUNT_NO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ACCOUNT_NAME
            // 
            this.ACCOUNT_NAME.DataPropertyName = "ACCOUNT_NAME";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ACCOUNT_NAME.DefaultCellStyle = dataGridViewCellStyle2;
            this.ACCOUNT_NAME.FillWeight = 133.4489F;
            this.ACCOUNT_NAME.HeaderText = "គណនី";
            this.ACCOUNT_NAME.Name = "ACCOUNT_NAME";
            this.ACCOUNT_NAME.ReadOnly = true;
            this.ACCOUNT_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ACCOUNT_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PHONE
            // 
            this.PHONE.DataPropertyName = "PHONE";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PHONE.DefaultCellStyle = dataGridViewCellStyle3;
            this.PHONE.FillWeight = 78.78029F;
            this.PHONE.HeaderText = "ទូរស៏ព្ទ";
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            this.PHONE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PHONE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EMAIL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EMAIL.Visible = false;
            // 
            // CONTACT_NAME
            // 
            this.CONTACT_NAME.DataPropertyName = "CONTACT_NAME";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CONTACT_NAME.DefaultCellStyle = dataGridViewCellStyle4;
            this.CONTACT_NAME.FillWeight = 73.15919F;
            this.CONTACT_NAME.HeaderText = "ទំនាក់ទំនង";
            this.CONTACT_NAME.Name = "CONTACT_NAME";
            this.CONTACT_NAME.ReadOnly = true;
            this.CONTACT_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CONTACT_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ADDRESS
            // 
            this.ADDRESS.DataPropertyName = "ADDRESS";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ADDRESS.DefaultCellStyle = dataGridViewCellStyle5;
            this.ADDRESS.FillWeight = 184.1548F;
            this.ADDRESS.HeaderText = "អសយដ្ឋាន";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            this.ADDRESS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ADDRESS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PROVINCE_NAME
            // 
            this.PROVINCE_NAME.DataPropertyName = "PROVINCE_NAME";
            this.PROVINCE_NAME.HeaderText = "PROVINCE_NAME";
            this.PROVINCE_NAME.Name = "PROVINCE_NAME";
            this.PROVINCE_NAME.ReadOnly = true;
            this.PROVINCE_NAME.Visible = false;
            // 
            // DISTRICT_NAME
            // 
            this.DISTRICT_NAME.DataPropertyName = "DISTRICT_NAME";
            this.DISTRICT_NAME.HeaderText = "DISTRICT_NAME";
            this.DISTRICT_NAME.Name = "DISTRICT_NAME";
            this.DISTRICT_NAME.ReadOnly = true;
            this.DISTRICT_NAME.Visible = false;
            // 
            // COMMUNE_NAME
            // 
            this.COMMUNE_NAME.DataPropertyName = "COMMUNE_NAME";
            this.COMMUNE_NAME.HeaderText = "COMMUNE_NAME";
            this.COMMUNE_NAME.Name = "COMMUNE_NAME";
            this.COMMUNE_NAME.ReadOnly = true;
            this.COMMUNE_NAME.Visible = false;
            // 
            // VILLAGE_NAME
            // 
            this.VILLAGE_NAME.DataPropertyName = "VILLAGE_NAME";
            this.VILLAGE_NAME.HeaderText = "VILLAGE_NAME";
            this.VILLAGE_NAME.Name = "VILLAGE_NAME";
            this.VILLAGE_NAME.ReadOnly = true;
            this.VILLAGE_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.VILLAGE_NAME.Visible = false;
            // 
            // IS_ACTIVE
            // 
            this.IS_ACTIVE.DataPropertyName = "IS_ACTIVE";
            this.IS_ACTIVE.HeaderText = "IS_ACTIVE";
            this.IS_ACTIVE.Name = "IS_ACTIVE";
            this.IS_ACTIVE.ReadOnly = true;
            this.IS_ACTIVE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IS_ACTIVE.Visible = false;
            // 
            // COLOR_ID1
            // 
            this.COLOR_ID1.DataPropertyName = "COLOR_ID";
            this.COLOR_ID1.HeaderText = "COLOR_ID";
            this.COLOR_ID1.Name = "COLOR_ID1";
            this.COLOR_ID1.ReadOnly = true;
            this.COLOR_ID1.Visible = false;
            // 
            // ControlLicenseSpecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.Name = "ControlLicenseSpecial";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Size = new System.Drawing.Size(1140, 491);
            this.Load += new System.EventHandler(this.ControlLicenseSpecial_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroButton btnAddNew;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dataGridViewLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LICENSE_TYPE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTACT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVINCE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISTRICT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMMUNE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn VILLAGE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_ACTIVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOR_ID1;
    }
}
