using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPowerGenerateLicense.Model;
using System.Drawing.Printing;
using System.Reflection;

namespace EPowerGenerateLicense.Interface
{
    public partial class ControlReportLicenseAvailable : UserControl
    {
        public ControlReportLicenseAvailable()
        {
            InitializeComponent();
        }
        private PrinterSettings printer = null;
        private CRAXDDRT.Application crxApp = null;
        private CRAXDDRT.Report crxReport = null;
        private string COMPANY_NAME;
        private string COMPANY_ADDRESS;
        private void ControlLicenseAvailable_Load(object sender, EventArgs e)
        {
            lblHeading.Text = Properties.Resources.REPORT_LICENSE_AVAILABLE;
            try
            {
                using (TBL_SEASON_DATA_ACCESS sda = new TBL_SEASON_DATA_ACCESS())
                {
                    cboSeason.DataSource = sda.ShowAllSeasonToComboBox();
                    cboSeason.DisplayMember = "SEASON_NAME";
                    cboSeason.ValueMember = "SEASON_ID";
                };
                using (TBL_COMPANY_DATA_ACCESS cda = new TBL_COMPANY_DATA_ACCESS())
                {
                    var company = cda.ShowCompany();
                    foreach (var item in company)
                    {
                        COMPANY_NAME = item.COMPANY_NAME;
                        COMPANY_ADDRESS = item.COMPANY_ADDRESS;
                    }
                }
                printer = new PrinterSettings();
                crxApp = new CRAXDDRT.Application();
                crxReport = new CRAXDDRT.Report();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
             try
            {
                string rpt_path = Application.StartupPath + @"\Report\ReportLicenseAvailable.rpt";
                crxReport = crxApp.OpenReport(rpt_path, null);
                foreach (CRAXDDRT.DatabaseTable crxdt in crxReport.Database.Tables)
                {
                    crxdt.SetLogOnInfo(Properties.Resources.INSTANCE_NAME, "EPOWERLICENSE", "sa", "underadmin");
                }
                crxReport.SelectPrinter("", printer.PrinterName, "");
                crxReport.ParameterFields.GetItemByName("@COMPANY_NAME", Missing.Value).AddCurrentValue(COMPANY_NAME);
                crxReport.ParameterFields.GetItemByName("@COMPANY_ADDRESS", Missing.Value).AddCurrentValue(COMPANY_ADDRESS);
                crxReport.ParameterFields.GetItemByName("@SEASON_ID", Missing.Value).AddCurrentValue(Convert.ToInt32(cboSeason.SelectedValue));
                crxReport.ParameterFields.GetItemByName("@SEASON_NAME", Missing.Value).AddCurrentValue(cboSeason.GetItemText(cboSeason.SelectedItem));
                axCrystalActiveXReportViewer1.ReportSource = crxReport;
                axCrystalActiveXReportViewer1.ViewReport();
                axCrystalActiveXReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }
    }
}
