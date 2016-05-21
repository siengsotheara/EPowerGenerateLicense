using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPowerGenerateLicense.Interface;

namespace EPowerGenerateLicense.Interface
{
    public partial class ControlLicenseMenuLeft : UserControl
    {
        
        public ControlLicenseMenuLeft()
        {
            InitializeComponent();
        }
        private FormMain parent = null;
        private void ControlLicenseMenuLeft_Load(object sender, EventArgs e)
        {
            parent = this.ParentForm as FormMain;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            try
            {
                metroLink1.Enabled = false;
                metroLink2.Enabled = true;
                parent.ShowLicense(null, null);
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            try
            {
                metroLink2.Enabled = false;
                metroLink1.Enabled = true;
                parent.ShowLicenseSpecial(null, null);
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
