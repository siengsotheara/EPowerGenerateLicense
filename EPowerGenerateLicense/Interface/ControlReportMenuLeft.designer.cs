namespace EPowerGenerateLicense.Interface
{
    partial class ControlReportMenuLeft
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.panel1.Size = new System.Drawing.Size(206, 24);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "របាយការណ៏";
            // 
            // metroLink1
            // 
            this.metroLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink1.Image = global::EPowerGenerateLicense.Properties.Resources.arrow_icon_left;
            this.metroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink1.Location = new System.Drawing.Point(3, 30);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(200, 23);
            this.metroLink1.TabIndex = 4;
            this.metroLink1.Text = "បញ្ជីអ្នកកាន់អាជ្ញាប័ណ្ឌ";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink2.Image = global::EPowerGenerateLicense.Properties.Resources.arrow_icon_left;
            this.metroLink2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink2.Location = new System.Drawing.Point(3, 54);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(200, 23);
            this.metroLink2.TabIndex = 5;
            this.metroLink2.Text = "ការចេញលេខអាជ្ញាប័ណ្ដ";
            this.metroLink2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // metroLink3
            // 
            this.metroLink3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink3.Image = global::EPowerGenerateLicense.Properties.Resources.arrow_icon_left;
            this.metroLink3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink3.Location = new System.Drawing.Point(3, 78);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(200, 23);
            this.metroLink3.TabIndex = 6;
            this.metroLink3.Text = "អាជ្ញាប័ណ្ឌមិនទាន់ចេញ";
            this.metroLink3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink3.UseSelectable = true;
            this.metroLink3.Click += new System.EventHandler(this.metroLink3_Click);
            // 
            // ControlReportMenuLeft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.metroLink3);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.panel1);
            this.Name = "ControlReportMenuLeft";
            this.Size = new System.Drawing.Size(206, 508);
            this.Load += new System.EventHandler(this.ControlReportMenuLeft_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public MetroFramework.Controls.MetroLink metroLink1;
        public MetroFramework.Controls.MetroLink metroLink2;
        public MetroFramework.Controls.MetroLink metroLink3;
    }
}
