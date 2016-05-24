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
                    txtAccountName.Text = license.ACCOUNT_NAME;
                    txtPhone.Text = license.PHONE;
                    txtContactName.Text = license.CONTACT_NAME;
                    txtPhone.Text = license.PHONE;
                    txtProvince.Text = license.PROVINCE_NAME;
                    txtDistrict.Text = license.DISTRICT_NAME;
                    txtCommune.Text = license.COMMUNE_NAME;
                    txtVillage.Text = license.VILLAGE_NAME;
                    txtAddress.Text = license.ADDRESS;
                    txtEmail.Text = license.EMAIL;
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

                license.ACCOUNT_NO = txtLicenseNumber.Text.Trim();
                license.ACCOUNT_NAME = txtAccountName.Text.Trim();
                license.PHONE = txtPhone.Text.Trim();
                license.EMAIL = txtEmail.Text.Trim();
                license.CONTACT_NAME = txtContactName.Text.Trim();
                license.PHONE = txtPhone.Text.Trim();
                license.ADDRESS = txtAddress.Text.Trim();
                license.PROVINCE_NAME = txtProvince.Text.Trim();
                license.DISTRICT_NAME = txtDistrict.Text.Trim();
                license.COMMUNE_NAME = txtCommune.Text.Trim();
                license.VILLAGE_NAME = txtVillage.Text.Trim();
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
