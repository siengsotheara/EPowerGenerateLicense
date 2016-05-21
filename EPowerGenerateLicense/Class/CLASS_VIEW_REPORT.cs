using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Windows.Forms;

namespace EPowerGenerateLicense.Class
{
    class CLASS_VIEW_REPORT
    {
        public void OpenReport()
        {
            PrinterSettings printer = new PrinterSettings();
            string file_path = Application.StartupPath + @"\Report\ReportLicenseAccount.rpt";
            CRAXDDRT.Application crxApp = new CRAXDDRT.Application();
            CRAXDDRT.Report crxReport = new CRAXDDRT.Report();
            crxReport = crxApp.OpenReport(file_path, null);
            foreach (CRAXDDRT.DatabaseTable crxdt in crxReport.Database.Tables)
            {
                crxdt.SetLogOnInfo(@".", "EPOWERLICENSE", "sa", "underadmin");
            }
            crxReport.SelectPrinter("", printer.PrinterName, "");
            crxReport.ParameterFields.GetItemByName("COMPANY_NAME", Missing.Value).AddCurrentValue("អ៊ី-ផៅវើ E-Power");
            crxReport.ParameterFields.GetItemByName("COMPANY_ADDRESS", Missing.Value).AddCurrentValue("ផ្ទះលេខ១៨ ផ្លូវលេខ ៦១៨​​ ខណ្ឌទួលគោក រាជធានីភ្នំពេញ");
        }
            
    }
}
