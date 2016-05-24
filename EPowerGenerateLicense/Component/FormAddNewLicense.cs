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
using System.Globalization;
using SoftTech;

namespace EPowerGenerateLicense
{
    public partial class FormAddNewLicense : MetroForm
    {
        
        public FormAddNewLicense()
        {
            InitializeComponent();
        }
        TBL_LICENSE_DATA_ACCESS lda = new TBL_LICENSE_DATA_ACCESS();

        private string LICENSE_NUMBER = string.Empty;
        private bool invalid()
        {
            
            using (TBL_LICENSE_DATA_ACCESS lda = new TBL_LICENSE_DATA_ACCESS())
            {
                foreach (var item in lda.CheckLicenseNumber(txtLicenseNumber.Text))
                {
                    LICENSE_NUMBER = item.ACCOUNT_NO.ToString();
                }
            }
            bool flag = false;
            if (this.txtLicenseNumber.Text == LICENSE_NUMBER )
            {
                this.txtLicenseNumber.SetValidation(string.Format(Properties.Resources.LICENSENUMBER_ADREADY, this.label1.Text));
                flag = true;
            }
            if (this.txtLicenseNumber.Text == "")
            {
                this.txtLicenseNumber.SetValidation(string.Format(Properties.Resources.REQUIRED_LICENSENUMBER, this.label1.Text));
                flag = true;
            } 
            if (this.txtFirstname.Text == "")
            {
                this.txtFirstname.SetValidation(string.Format(Properties.Resources.REQUIRED_FIRSTNAME, this.label1.Text));
                flag = true;
            }
            //if (this.txtLastname.Text == "")
            //{
            //    this.txtLastname.SetValidation(string.Format(Properties.Resources.REQUIRED_LASTNAME, this.label1.Text));
            //    flag = true;
            //}
            if (this.txtContactName.Text == "")
            {
                this.txtContactName.SetValidation(string.Format(Properties.Resources.REQUIRED_CONTACTNAME, this.label1.Text));
                flag = true;
            }
            if (this.txtPhone.Text == "")
            {
                this.txtPhone.SetValidation(string.Format(Properties.Resources.REQUIRED_PHONE, this.label1.Text));
                flag = true;
            }
            if (this.txtAddress.Text == "")
            {
                this.txtAddress.SetValidation(string.Format(Properties.Resources.REQUIRED_ADDRESS, this.label1.Text));
                flag = true;
            }

            return flag;
        }

        private void FormAddNewLicense_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!invalid())
            {
                try
                {
                    using (LicenseDataContext _context = new LicenseDataContext())
                    {
                        TBL_LICENSE l = new TBL_LICENSE();

                        l.ACCOUNT_NAME = txtLastname.Text.Trim();
                        l.ACCOUNT_NO = txtLicenseNumber.Text.Trim();
                        l.CONTACT_NAME = txtContactName.Text.Trim();
                        l.PHONE = txtPhone.Text.Trim();
                        l.ADDRESS = txtAddress.Text.Trim();
                        l.IS_ACTIVE = true;
                        l.CREATE_ON = Convert.ToDateTime(DateTime.Now.ToString());
                        lda.SaveLicense(l);
                    };
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
               
            }
            
        }

        private void txtLicenseNumber_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
