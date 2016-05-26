namespace EPowerGenerateLicense.Component
{
    partial class FormAddNewSpecialLicense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewLicense = new System.Windows.Forms.DataGridView();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.L_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LICENSE_TYPE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTACT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_ACTIVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewLicense.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewLicense.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLicense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLicense.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS System", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLicense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLicense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.L_ID,
            this.EMAIL,
            this.LICENSE_TYPE_ID,
            this.ACCOUNT_NO,
            this.ACCOUNT_NAME,
            this.CONTACT_NAME,
            this.PHONE,
            this.ADDRESS,
            this.IS_ACTIVE,
            this.COLOR_ID});
            this.dataGridViewLicense.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Khmer OS System", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLicense.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLicense.EnableHeadersVisualStyles = false;
            this.dataGridViewLicense.Location = new System.Drawing.Point(8, 191);
            this.dataGridViewLicense.MultiSelect = false;
            this.dataGridViewLicense.Name = "dataGridViewLicense";
            this.dataGridViewLicense.ReadOnly = true;
            this.dataGridViewLicense.RowHeadersVisible = false;
            this.dataGridViewLicense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLicense.Size = new System.Drawing.Size(674, 256);
            this.dataGridViewLicense.TabIndex = 4;
            this.dataGridViewLicense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLicense_CellClick);
            this.dataGridViewLicense.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewLicense_RowPrePaint);
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(135, 58);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.ReadOnly = true;
            this.txtLicenseNumber.Size = new System.Drawing.Size(219, 27);
            this.txtLicenseNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 59;
            this.label3.Text = "លេខអាជ្ញាប័ណ្ឌ";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(135, 93);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(547, 27);
            this.txtAccountName.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 61;
            this.label1.Text = "គណនី";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(652, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(8, 162);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowClearButton = true;
            this.txtSearch.Size = new System.Drawing.Size(674, 23);
            this.txtSearch.TabIndex = 62;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "៖";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 19);
            this.label2.TabIndex = 71;
            this.label2.Text = "៖";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(607, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.Text = "បោះបង់";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(526, 133);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 73;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboColor
            // 
            this.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Items.AddRange(new object[] {
            "ក្រហម",
            "ផ្កាឈូក",
            "ខៀវ"});
            this.cboColor.Location = new System.Drawing.Point(453, 59);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(229, 27);
            this.cboColor.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 19);
            this.label4.TabIndex = 75;
            this.label4.Text = "៖";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 22);
            this.label6.TabIndex = 76;
            this.label6.Text = "ព័ណ";
            // 
            // L_ID
            // 
            this.L_ID.DataPropertyName = "LICENSE_ID";
            this.L_ID.HeaderText = "LICENSE_ID";
            this.L_ID.Name = "L_ID";
            this.L_ID.ReadOnly = true;
            this.L_ID.Visible = false;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Visible = false;
            // 
            // LICENSE_TYPE_ID
            // 
            this.LICENSE_TYPE_ID.DataPropertyName = "LICENSE_TYPE_ID";
            this.LICENSE_TYPE_ID.HeaderText = "LICENSE_TYPE_ID";
            this.LICENSE_TYPE_ID.Name = "LICENSE_TYPE_ID";
            this.LICENSE_TYPE_ID.ReadOnly = true;
            this.LICENSE_TYPE_ID.Visible = false;
            // 
            // ACCOUNT_NO
            // 
            this.ACCOUNT_NO.DataPropertyName = "ACCOUNT_NO";
            this.ACCOUNT_NO.FillWeight = 50.76142F;
            this.ACCOUNT_NO.HeaderText = "លេខកូថ";
            this.ACCOUNT_NO.Name = "ACCOUNT_NO";
            this.ACCOUNT_NO.ReadOnly = true;
            // 
            // ACCOUNT_NAME
            // 
            this.ACCOUNT_NAME.DataPropertyName = "ACCOUNT_NAME";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ACCOUNT_NAME.DefaultCellStyle = dataGridViewCellStyle2;
            this.ACCOUNT_NAME.FillWeight = 116.4129F;
            this.ACCOUNT_NAME.HeaderText = "គណនី";
            this.ACCOUNT_NAME.Name = "ACCOUNT_NAME";
            this.ACCOUNT_NAME.ReadOnly = true;
            // 
            // CONTACT_NAME
            // 
            this.CONTACT_NAME.DataPropertyName = "CONTACT_NAME";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CONTACT_NAME.DefaultCellStyle = dataGridViewCellStyle3;
            this.CONTACT_NAME.FillWeight = 116.4129F;
            this.CONTACT_NAME.HeaderText = "ទំនាក់ទំនង";
            this.CONTACT_NAME.Name = "CONTACT_NAME";
            this.CONTACT_NAME.ReadOnly = true;
            // 
            // PHONE
            // 
            this.PHONE.DataPropertyName = "PHONE";
            this.PHONE.FillWeight = 116.4129F;
            this.PHONE.HeaderText = "ទូរស័ព្ទ";
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            // 
            // ADDRESS
            // 
            this.ADDRESS.DataPropertyName = "ADDRESS";
            this.ADDRESS.HeaderText = "ADDRESS";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            this.ADDRESS.Visible = false;
            // 
            // IS_ACTIVE
            // 
            this.IS_ACTIVE.DataPropertyName = "IS_ACTIVE";
            this.IS_ACTIVE.HeaderText = "IS_ACTIVE";
            this.IS_ACTIVE.Name = "IS_ACTIVE";
            this.IS_ACTIVE.ReadOnly = true;
            this.IS_ACTIVE.Visible = false;
            // 
            // COLOR_ID
            // 
            this.COLOR_ID.DataPropertyName = "COLOR_ID";
            this.COLOR_ID.HeaderText = "COLOR_ID";
            this.COLOR_ID.Name = "COLOR_ID";
            this.COLOR_ID.ReadOnly = true;
            this.COLOR_ID.Visible = false;
            // 
            // FormAddNewSpecialLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 460);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLicenseNumber);
            this.Controls.Add(this.dataGridViewLicense);
            this.Font = new System.Drawing.Font("Khmer OS System", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddNewSpecialLicense";
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 5);
            this.Resizable = false;
            this.Text = "គណនីពិសេស";
            this.Load += new System.EventHandler(this.FormAddNewSpecialLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLicense;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn L_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LICENSE_TYPE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTACT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_ACTIVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOR_ID;


    }
}