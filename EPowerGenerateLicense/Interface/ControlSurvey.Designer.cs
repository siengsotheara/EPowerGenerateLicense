namespace EPowerGenerateLicense.Interface
{
    partial class ControlSurvey
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRemainNumber = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSeason = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewSurvey = new System.Windows.Forms.DataGridView();
            this.ROW_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATE_ON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOLLOW_UP_BY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATE_BY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSurvey)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblRemainNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboSeason);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 60);
            this.panel1.TabIndex = 1;
            // 
            // lblRemainNumber
            // 
            this.lblRemainNumber.AutoSize = true;
            this.lblRemainNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemainNumber.Font = new System.Drawing.Font("Khmer OS System", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainNumber.Location = new System.Drawing.Point(283, 30);
            this.lblRemainNumber.Name = "lblRemainNumber";
            this.lblRemainNumber.Size = new System.Drawing.Size(49, 24);
            this.lblRemainNumber.TabIndex = 7;
            this.lblRemainNumber.TabStop = true;
            this.lblRemainNumber.Text = "​​​​០ នាក់";
            this.lblRemainNumber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRemainNumber_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "ចំនួននៅសល់";
            // 
            // cboSeason
            // 
            this.cboSeason.DropDownHeight = 100;
            this.cboSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeason.Font = new System.Drawing.Font("Khmer OS System", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSeason.FormattingEnabled = true;
            this.cboSeason.IntegralHeight = false;
            this.cboSeason.Location = new System.Drawing.Point(2, 28);
            this.cboSeason.Name = "cboSeason";
            this.cboSeason.Size = new System.Drawing.Size(198, 27);
            this.cboSeason.TabIndex = 5;
            this.cboSeason.SelectedIndexChanged += new System.EventHandler(this.cboSeason_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.panel2.Size = new System.Drawing.Size(1135, 24);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ការស្ទង់មត្តិ(Survey)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.dataGridViewSurvey);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(1135, 431);
            this.panel3.TabIndex = 2;
            // 
            // dataGridViewSurvey
            // 
            this.dataGridViewSurvey.AllowUserToAddRows = false;
            this.dataGridViewSurvey.AllowUserToDeleteRows = false;
            this.dataGridViewSurvey.AllowUserToResizeColumns = false;
            this.dataGridViewSurvey.AllowUserToResizeRows = false;
            this.dataGridViewSurvey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSurvey.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSurvey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSurvey.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSurvey.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSurvey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSurvey.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ROW_ID,
            this.CREATE_ON,
            this.FOLLOW_UP_BY,
            this.CREATE_BY,
            this.Column7});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSurvey.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSurvey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSurvey.EnableHeadersVisualStyles = false;
            this.dataGridViewSurvey.Location = new System.Drawing.Point(2, 0);
            this.dataGridViewSurvey.MultiSelect = false;
            this.dataGridViewSurvey.Name = "dataGridViewSurvey";
            this.dataGridViewSurvey.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSurvey.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSurvey.RowHeadersVisible = false;
            this.dataGridViewSurvey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSurvey.Size = new System.Drawing.Size(1133, 431);
            this.dataGridViewSurvey.TabIndex = 2;
            this.dataGridViewSurvey.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSurvey_CellContentClick);
            this.dataGridViewSurvey.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewSurvey_RowPrePaint);
            // 
            // ROW_ID
            // 
            this.ROW_ID.DataPropertyName = "ROW_ID";
            this.ROW_ID.HeaderText = "ROW_ID";
            this.ROW_ID.Name = "ROW_ID";
            this.ROW_ID.ReadOnly = true;
            this.ROW_ID.Visible = false;
            // 
            // CREATE_ON
            // 
            this.CREATE_ON.DataPropertyName = "CREATE_ON";
            dataGridViewCellStyle2.Format = "f";
            dataGridViewCellStyle2.NullValue = null;
            this.CREATE_ON.DefaultCellStyle = dataGridViewCellStyle2;
            this.CREATE_ON.FillWeight = 180.0726F;
            this.CREATE_ON.HeaderText = "ប្រវត្តិថ្ងៃចេញ";
            this.CREATE_ON.Name = "CREATE_ON";
            this.CREATE_ON.ReadOnly = true;
            // 
            // FOLLOW_UP_BY
            // 
            this.FOLLOW_UP_BY.DataPropertyName = "FOLLOW_UP_BY";
            this.FOLLOW_UP_BY.HeaderText = "អ្នក Follow Up ដោយ";
            this.FOLLOW_UP_BY.Name = "FOLLOW_UP_BY";
            this.FOLLOW_UP_BY.ReadOnly = true;
            // 
            // CREATE_BY
            // 
            this.CREATE_BY.DataPropertyName = "CREATE_BY";
            this.CREATE_BY.FillWeight = 41.75197F;
            this.CREATE_BY.HeaderText = "ចេញដោយ";
            this.CREATE_BY.Name = "CREATE_BY";
            this.CREATE_BY.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TOTAL_LICENSE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column7.FillWeight = 52.34668F;
            this.Column7.HeaderText = "សរុប";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ControlSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.Name = "ControlSurvey";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Size = new System.Drawing.Size(1140, 491);
            this.Load += new System.EventHandler(this.ControlSurvey_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSurvey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cboSeason;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dataGridViewSurvey;
        private System.Windows.Forms.LinkLabel lblRemainNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROW_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATE_ON;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOLLOW_UP_BY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATE_BY;
        private System.Windows.Forms.DataGridViewLinkColumn Column7;
    }
}
