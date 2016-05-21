namespace EPowerGenerateLicense.Interface
{
    partial class ControlReportLicenseAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlReportLicenseAccount));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblHeaderReportName = new System.Windows.Forms.Label();
            this.btnLook = new MetroFramework.Controls.MetroButton();
            this.axCrystalActiveXReportViewer1 = new AxCrystalActiveXReportViewerLib105.AxCrystalActiveXReportViewer();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCrystalActiveXReportViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.btnLook);
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
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Controls.Add(this.lblHeaderReportName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.panel1.Size = new System.Drawing.Size(1135, 24);
            this.panel1.TabIndex = 4;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeading.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(5, 3);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(0, 22);
            this.lblHeading.TabIndex = 2;
            // 
            // lblHeaderReportName
            // 
            this.lblHeaderReportName.AutoSize = true;
            this.lblHeaderReportName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeaderReportName.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderReportName.Location = new System.Drawing.Point(5, 3);
            this.lblHeaderReportName.Name = "lblHeaderReportName";
            this.lblHeaderReportName.Size = new System.Drawing.Size(0, 22);
            this.lblHeaderReportName.TabIndex = 0;
            // 
            // btnLook
            // 
            this.btnLook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLook.Highlight = true;
            this.btnLook.Location = new System.Drawing.Point(1061, 30);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(71, 23);
            this.btnLook.TabIndex = 2;
            this.btnLook.Text = "មើល";
            this.btnLook.UseSelectable = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // axCrystalActiveXReportViewer1
            // 
            this.axCrystalActiveXReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axCrystalActiveXReportViewer1.Enabled = true;
            this.axCrystalActiveXReportViewer1.Location = new System.Drawing.Point(5, 60);
            this.axCrystalActiveXReportViewer1.Name = "axCrystalActiveXReportViewer1";
            this.axCrystalActiveXReportViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCrystalActiveXReportViewer1.OcxState")));
            this.axCrystalActiveXReportViewer1.Size = new System.Drawing.Size(1135, 431);
            this.axCrystalActiveXReportViewer1.TabIndex = 2;
            this.axCrystalActiveXReportViewer1.UseWaitCursor = true;
            // 
            // ControlReportLicenseAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axCrystalActiveXReportViewer1);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.Name = "ControlReportLicenseAccount";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Size = new System.Drawing.Size(1140, 491);
            this.Load += new System.EventHandler(this.ControlReport_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCrystalActiveXReportViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroButton btnLook;
        private System.Windows.Forms.Panel panel1;
        private AxCrystalActiveXReportViewerLib105.AxCrystalActiveXReportViewer axCrystalActiveXReportViewer1;
        public System.Windows.Forms.Label lblHeaderReportName;
        private System.Windows.Forms.Label lblHeading;
    }
}
