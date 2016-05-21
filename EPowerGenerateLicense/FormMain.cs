using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPowerGenerateLicense.Model;
using System.Globalization;
using EPowerGenerateLicense.Interface;

namespace EPowerGenerateLicense
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        private TBL_LICENSE_DATA_ACCESS lda = null;
        private ControlLicense cl = null;
        private ControlLicenseMenuLeft clm = null;
        private ControlWork cw = null;
        private ControlWorkMenuLeft cwl = null;
        private ControlReportLicenseAccount reportlicenseaccount = null;
        private ControlReportMenuLeft rpl = null;
        private ControlReportLicenseGenerate reportlicensegenerate = null;
        private ControlReportLicenseAvailable reportlicenseavailable = null;
        private ControlSeason cse = null;
        private ControlLicenseSpecial licenspecial = null;
        private ControlUser user = null;
        public FormMain()
        {
            InitializeComponent();
        }
        public void RefreshMain()
        {
            panelContainer.Controls.Clear();
        }
        public void ShowUser(object sender, EventArgs e)
        {
            try
            {
                panelContainer.Controls.Clear();
                user = new ControlUser();
                user.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(user);
                GC.Collect();
            }
            catch (Exception ex)
            {
                
          
            }
        }
        public void ShowLicenseSpecial(object sender, EventArgs e)
        {
            try
            {
                panelContainer.Controls.Clear();
                licenspecial = new ControlLicenseSpecial();
                licenspecial.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(licenspecial);
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ShowLicense(object sender, EventArgs e)
        {
            try
            {
                panelContainer.Controls.Clear();
                cl = new ControlLicense();
                cl.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(cl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ShowReportLicenseAvailable(object sender, EventArgs e)
        {
            try
            {
                panelContainer.Controls.Clear();
                reportlicenseavailable = new ControlReportLicenseAvailable();
                reportlicenseavailable.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(reportlicenseavailable);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public void ShowReportLicenseGenerate(object sender, EventArgs e)
        {
            try
            {
                panelContainer.Controls.Clear();
                reportlicensegenerate = new ControlReportLicenseGenerate();
                reportlicensegenerate.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(reportlicensegenerate);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public void ShowReportLicenseAccount(object sender, EventArgs e)
        {
            try
            {
                panelContainer.Controls.Clear();
                reportlicenseaccount = new ControlReportLicenseAccount();
                reportlicenseaccount.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(reportlicenseaccount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Loading(object sender, EventArgs e)
        {
            //loading.Left = (this.ClientSize.Width - loading.Width) / 2;
            //loading.Top = (this.ClientSize.Height - loading.Height) / 2;
        }
        public void ShowWork(object sender, EventArgs e) 
        {
            try
            {
                panelContainer.Controls.Clear();
                cw = new ControlWork();
                cw.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(cw);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ShowSeason(object sender, EventArgs e)
        {
            try
            {
                panelContainer.Controls.Clear();
                cse = new ControlSeason();
                panelContainer.Controls.Add(cse);
                cse.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            btnMenuLicense.Enabled = false;
            lda = new TBL_LICENSE_DATA_ACCESS();
            clm = new ControlLicenseMenuLeft();
            cl = new ControlLicense();
            clm.Dock = DockStyle.Fill;
            panelLeft.Controls.Add(clm);
            cl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(cl);
            GC.Collect();
        }
        string time = DateTime.Now.ToString("yyyy-mmm-dd hh:mm:ss.fff", CultureInfo.CreateSpecificCulture("en-US"));

        private void btnMenuLicense_Click(object sender, EventArgs e)
        {
            btnMenuLicense.Enabled = false;
            btnMenuReport.Enabled = true;
            btnMenuWork.Enabled = true;
            panelLeft.Controls.Clear();
            panelContainer.Controls.Clear();
            clm = new ControlLicenseMenuLeft();
            cl = new ControlLicense();
            clm.Dock = DockStyle.Fill;
            cl.Dock = DockStyle.Fill;
            panelLeft.Controls.Add(clm);
            panelContainer.Controls.Add(cl);
            GC.Collect();
        }

        private void btnMenuWork_Click(object sender, EventArgs e)
        {
            btnMenuWork.Enabled = false;
            btnMenuLicense.Enabled = true;
            btnMenuReport.Enabled = true;
            panelLeft.Controls.Clear();
            panelContainer.Controls.Clear();
            cw = new ControlWork();
            cwl = new ControlWorkMenuLeft();
            cw = new ControlWork();
            cwl.Dock = DockStyle.Fill;
            cw.Dock = DockStyle.Fill;
            panelLeft.Controls.Add(cwl);
            panelContainer.Controls.Add(cw);
            GC.Collect();
        }

        private void btnMenuReport_Click(object sender, EventArgs e)
        {
            btnMenuReport.Enabled = false;
            btnMenuWork.Enabled = true;
            btnMenuLicense.Enabled = true;
            panelLeft.Controls.Clear();
            panelContainer.Controls.Clear();
            reportlicenseaccount = new ControlReportLicenseAccount();
            rpl = new ControlReportMenuLeft();
            panelLeft.Controls.Add(rpl);
            reportlicenseaccount.Dock = DockStyle.Fill;
            rpl.Dock = DockStyle.Fill;
            GC.Collect();

        }
    }
}
