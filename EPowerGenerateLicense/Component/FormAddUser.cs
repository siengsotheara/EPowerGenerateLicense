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
using EPowerGenerateLicense.Interface;
using SoftTech;
using EPowerGenerateLicense.Class;
using EPowerGenerateLicense.Properties;
using MetroFramework.Forms;

namespace EPowerGenerateLicense.Component
{
    public partial class FormAddUser : MetroForm
    {
        public FormAddUser()
        {
            InitializeComponent();
        }
        private string username;
        private void FormAddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        }

        private void ckShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShowpassword.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Invalid())
            {
                try
                {
                    using (TBL_USER_DATA_ACCESS uda = new TBL_USER_DATA_ACCESS())
                    {
                        TBL_USER user = new TBL_USER();
                        user.USERNAME = txtUsername.Text.Trim();
                        user.PASSWORD = uda.Encrypt(txtPassword.Text.Trim(), true);
                        user.IS_ACTIVE = true;
                        uda.SaveUser(user);
                        this.Close();
                    }
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
        private bool Invalid()
        {
            bool flag = false;
            using (TBL_USER_DATA_ACCESS uda = new TBL_USER_DATA_ACCESS())
            {
                foreach (var item in uda.CheckUniqueUsername(txtUsername.Text.Trim()))
                {
                    username = item.USERNAME;
                }
            }
            if (txtUsername.Text == username)
            {
                this.txtUsername.SetValidation(string.Format(Properties.Resources.ALREADY_USERNAME, this.label1.Text));
                flag = true;
                txtUsername.Focus();
            }
            if (txtUsername.Text == string.Empty)
            {
                this.txtUsername.SetValidation(string.Format(Properties.Resources.REQUIRED_USERNAME, this.label1.Text));
                flag = true;
                txtPassword.Focus();
            }
            if (txtPassword.Text == string.Empty)
            {
                this.txtPassword.SetValidation(string.Format(Properties.Resources.REQUIRED_PASSWORD, this.label1.Text));
                flag = true;
                txtPassword.Focus();
            }
            return flag;
        }
    }
}
