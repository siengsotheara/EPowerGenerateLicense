using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPowerGenerateLicense.Interface
{
    public partial class ControlReportMenuLeft : UserControl
    {
        public ControlReportMenuLeft()
        {
            InitializeComponent();
        }
        FormMain parent = null;
        private void metroLink1_Click(object sender, EventArgs e)
        {
            metroLink2.Enabled = true;
            metroLink1.Enabled = false;
            metroLink3.Enabled = true;
            parent.ShowReportLicenseAccount(null, null);
            GC.Collect();
        }

        private void ControlReportMenuLeft_Load(object sender, EventArgs e)
        {
            parent = this.ParentForm as FormMain;
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            metroLink1.Enabled = true;
            metroLink2.Enabled = false;
            metroLink3.Enabled = true;
            parent.ShowReportLicenseGenerate(null, null);
            GC.Collect();
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            metroLink3.Enabled = false;
            metroLink2.Enabled = true;
            metroLink1.Enabled = true;
            parent.ShowReportLicenseAvailable(null, null);
            GC.Collect();
        }
    }
}
