using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPowerGenerateLicense.Component;
using EPowerGenerateLicense.Interface;
using EPowerGenerateLicense.Model;
using SoftTech;
using MetroFramework.Forms;

namespace EPowerGenerateLicense.Component
{
    public partial class FormUpdateUser : MetroForm
    {
        public FormUpdateUser()
        {
            InitializeComponent();
        }

        private void FormUpdateUser_Load(object sender, EventArgs e)
        {
            user_data = new TBL_USER_DATA_ACCESS();
            try
            {
                using (TBL_USER_DATA_ACCESS uda = new TBL_USER_DATA_ACCESS())
                {
                    foreach (var item in uda.ShowUserByID(ControlUser.USER_ID))
                    {
                        txtUsername.Text = item.USERNAME;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string username;
        private string new_password;
        private string old_password;
        private LicenseDataContext _contex;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Invalid())
            {
                try
                {
                    using (TBL_USER_DATA_ACCESS uda = new TBL_USER_DATA_ACCESS())
                    {
                        using (_contex = new LicenseDataContext())
                        {
                            TBL_USER user = (from u in _contex.TBL_USERs 
                                             where u.USER_ID == ControlUser.USER_ID
                                             select u).FirstOrDefault();
                            user.PASSWORD = user_data.Encrypt(txtPwdNew.Text.Trim(), true);
                            _contex.SubmitChanges();
                            
                        }
                        
                    }
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
        private TBL_USER_DATA_ACCESS user_data;
        private bool Invalid()
        {
            bool flag = false;
            using (TBL_USER_DATA_ACCESS uda = new TBL_USER_DATA_ACCESS())
            {
                foreach (var item in uda.ShowUserByID(ControlUser.USER_ID))
                {
                    old_password = item.PASSWORD;
                }
            }
            if (old_password != user_data.Encrypt(txtPwdOld.Text.Trim(), true))
            {
                this.txtPwdOld.SetValidation(string.Format(Properties.Resources.WRONG_PASSWORD, this.label1.Text));
                flag = true;
                txtPwdOld.Focus();
            }
            if (txtPwdOld.Text == string.Empty)
            {
                this.txtPwdOld.SetValidation(string.Format(Properties.Resources.REQUIRED_PASSWORD, this.label1.Text));
                flag = true;
                txtPwdOld.Focus();
            }
            if (txtPwdNew.Text == string.Empty)
            {
                this.txtPwdNew.SetValidation(string.Format(Properties.Resources.REQUIRED_PASSWORD, this.label1.Text));
                flag = true;
                txtPwdNew.Focus();
            }
            return flag;
        }
    }
}
