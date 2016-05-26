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
using EPowerGenerateLicense.Component;
using MetroFramework.Forms;
using SoftTech;

namespace EPowerGenerateLicense.Component
{
    public partial class FormAddNewSpecialLicense : MetroForm
    {
        public FormAddNewSpecialLicense()
        {
            InitializeComponent();
        }
      
        private bool invalid()
        {
            bool flag = false;
            
            if (this.txtLicenseNumber.Text == "")
            {
                this.txtLicenseNumber.SetValidation(string.Format(Properties.Resources.REQUIRED_LICENSENUMBER, this.label1.Text));
                flag = true;
            }  
            return flag;
        }

        private void FormAddNewSpecialLicense_Load(object sender, EventArgs e)
        {
            cboColor.SelectedIndex = 0;
            try
            {
                using (TBL_LICENSE_TYPE_DATA_ACCESS lda = new TBL_LICENSE_TYPE_DATA_ACCESS())
                {
                    dataGridViewLicense.DataSource = lda.ShowLicenseTypeNotSpecial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);          
            }
            
        }

      

        private LicenseDataContext _context;
        private void dataGridViewLicense_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewLicense.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }
        int ID;
        private int LICENSE_ID;
     
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewLicense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (TBL_LICENSE_DATA_ACCESS lda = new TBL_LICENSE_DATA_ACCESS())
            {
                foreach (DataGridViewRow row in dataGridViewLicense.SelectedRows)
                {
                    ID = Convert.ToInt32(row.Cells["L_ID"].Value);
                }
                foreach (var item in lda.ShowLicenseByID(ID))
                {
                    txtAccountName.Text = item.ACCOUNT_NAME;
                    txtLicenseNumber.Text = item.ACCOUNT_NO;
                    LICENSE_ID = item.LICENSE_ID;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!invalid())
            {
                try
                {
                    using (TBL_LICENSE_TYPE_DATA_ACCESS lda = new TBL_LICENSE_TYPE_DATA_ACCESS())
                    {
                        using (_context = new LicenseDataContext())
                        {
                            TBL_LICENSE_TYPE lt = new TBL_LICENSE_TYPE();
                            lt.LICENSE_ID = LICENSE_ID;
                            if (cboColor.SelectedIndex == 0)
                            {
                                lt.PERCENTAGE = 100;
                                lt.COLOR_ID = 1;
                            }
                            if (cboColor.SelectedIndex == 1)
                            {
                                lt.PERCENTAGE = 75;
                                lt.COLOR_ID = 2;
                            }
                            else if (cboColor.SelectedIndex == 2)
                            {
                                lt.PERCENTAGE = 50;
                                lt.COLOR_ID = 3;
                            }
                            lt.CREATE_DATE = DateTime.Now;
                            lt.IS_ACTIVE = true;
                            lt.CREATE_BY = "admin";
                            lda.SaveLicense(lt);
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
            GC.Collect();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text.Length > 0)
                {
                    using (TBL_LICENSE_TYPE_DATA_ACCESS ltda = new TBL_LICENSE_TYPE_DATA_ACCESS())
                    {
                       
                    }
                }
                else
                {
                    using (TBL_LICENSE_TYPE_DATA_ACCESS ltda = new TBL_LICENSE_TYPE_DATA_ACCESS())
                    {
                        dataGridViewLicense.DataSource = ltda.ShowLicenseTypeNotSpecial();
                    }
                }
                

            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
