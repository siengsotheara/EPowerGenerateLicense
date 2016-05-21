using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Reflection;
using EPowerGenerateLicense.Model;

namespace EPowerGenerateLicense.Interface
{
    public partial class ControlReportLicenseAccount : UserControl
    {
        public ControlReportLicenseAccount()
        {
            InitializeComponent();
        }
        private PrinterSettings printer = null;
        private CRAXDDRT.Application crxApp = null;
        private CRAXDDRT.Report crxReport = null;
        private string COMPANY_NAME;
        private string COMPANY_ADDRESS;
        private void btnLook_Click(object sender, EventArgs e)
        {
            try
            {
                string rpt_path = Application.StartupPath + @"\Report\ReportLicenseAccount.rpt";
                crxReport = crxApp.OpenReport(rpt_path, null);
                foreach (CRAXDDRT.DatabaseTable crxdt in crxReport.Database.Tables)
                {
                    crxdt.SetLogOnInfo(Properties.Resources.INSTANCE_NAME, "EPOWERLICENSE", "sa", "underadmin");
                }
                crxReport.SelectPrinter("", printer.PrinterName, "");
                crxReport.ParameterFields.GetItemByName("@COMPANY_NAME", Missing.Value).AddCurrentValue(COMPANY_NAME);
                crxReport.ParameterFields.GetItemByName("@COMPANY_ADDRESS", Missing.Value).AddCurrentValue(COMPANY_ADDRESS);
                crxReport.PaperOrientation = CRAXDDRT.CRPaperOrientation.crLandscape;
                axCrystalActiveXReportViewer1.Zoom(100);
                axCrystalActiveXReportViewer1.ReportSource = crxReport;
                axCrystalActiveXReportViewer1.ViewReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            GC.Collect();
        }

        private void ControlReport_Load(object sender, EventArgs e)
        {
            lblHeading.Text = Properties.Resources.REPORT_LICENSE_ACOUNT;
            using (TBL_COMPANY_DATA_ACCESS cda = new TBL_COMPANY_DATA_ACCESS())
            {
                var company = cda.ShowCompany();
                foreach (var item in company)
                {
                    COMPANY_NAME = item.COMPANY_NAME;
                    COMPANY_ADDRESS = item.COMPANY_ADDRESS;
                }
            }
            try
            {
                printer = new PrinterSettings();
               
                crxApp = new CRAXDDRT.Application();
                crxReport = new CRAXDDRT.Report();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                GC.Collect();
            }

        }
    }
}
