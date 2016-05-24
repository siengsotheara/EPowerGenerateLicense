using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using EPowerGenerateLicense.Model;
using EPowerGenerateLicense.Interface;
using EPowerGenerateLicense.Class;

namespace EPowerGenerateLicense.Component
{
    public partial class FormUpdateLicense : MetroForm
    {
        public FormUpdateLicense()
        {
            InitializeComponent();
        }
        private int LICENSE_ID;
        private void FormUpdateLicense_Load(object sender, EventArgs e)
        {
            using (LicenseDataContext _context = new LicenseDataContext())
            {
                TBL_LICENSE license = (from l in _context.TBL_LICENSEs
                                       where l.ACCOUNT_NO == ControlLicense.LICENSE_NUMBER
                                       select l).FirstOrDefault();
                if (license != null)
                {
                    LICENSE_ID = license.LICENSE_ID;
                    txtLicenseNumber.Text = license.ACCOUNT_NO;
                   // txtLastname.Text = license.LAST_NAME;
                  //  txtFirstname.Text = license.FIRST_NAME;
                    txtContactName.Text = license.CONTACT_NAME;
                    txtPhone.Text = license.PHONE;
                    txtAddress.Text = license.ADDRESS;
                }
                else
                {

                }
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (LicenseDataContext _context = new LicenseDataContext())
            {
                TBL_LICENSE license = (from l in _context.TBL_LICENSEs
                                       where l.ACCOUNT_NO == txtLicenseNumber.Text
                                       select l).FirstOrDefault();

          //      license.FIRST_NAME = txtFirstname.Text.Trim();
          //      license.LAST_NAME = txtLastname.Text.Trim();
           //     license.LICENSE_NUMBER = txtLicenseNumber.Text.Trim();
                license.CONTACT_NAME = txtContactName.Text.Trim();
                license.PHONE = txtPhone.Text.Trim();
                license.ADDRESS = txtAddress.Text;
                _context.SubmitChanges();
            };
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
