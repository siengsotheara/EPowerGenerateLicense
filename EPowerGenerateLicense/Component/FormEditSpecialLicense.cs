using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftTech;
using EPowerGenerateLicense.Component;
using EPowerGenerateLicense.Interface;
using EPowerGenerateLicense.Model;
using MetroFramework.Forms;

namespace EPowerGenerateLicense.Component
{
    public partial class FormEditSpecialLicense : MetroForm
    {
        public FormEditSpecialLicense()
        {
            InitializeComponent();
        }
        private int LICENSE_ID;
        private LicenseDataContext _context;
        private void FormEditSpecialLicense_Load(object sender, EventArgs e)
        {
            try
            {
                if (ControlLicenseSpecial.COLOR_ID == 1)
                {
                    cboColor.SelectedIndex = 0;
                }
                else if (ControlLicenseSpecial.COLOR_ID == 2)
                {
                    cboColor.SelectedIndex = 1;
                }
                else if (ControlLicenseSpecial.COLOR_ID == 3)
                {
                    cboColor.SelectedIndex = 2;
                }
                using (TBL_LICENSE_DATA_ACCESS lda = new TBL_LICENSE_DATA_ACCESS())
                {
                    foreach (var item in lda.ShowLicenseByID(ControlLicenseSpecial.LICENSE_ID))
                    {
                        txtAccountName.Text = item.FIRST_NAME + " " + item.LAST_NAME;
                        txtLicenseNumber.Text = item.LICENSE_NUMBER;
                        LICENSE_ID = item.LICENSE_ID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                    using (TBL_LICENSE_TYPE_DATA_ACCESS ltda = new TBL_LICENSE_TYPE_DATA_ACCESS())
                    {
                        using(_context = new LicenseDataContext())
                        {
                            TBL_LICENSE_TYPE lt = (from l in _context.TBL_LICENSE_TYPEs
                                                   where l.LICENSE_ID == LICENSE_ID
                                                   select l).FirstOrDefault();
                            if (cboColor.SelectedIndex == 0)
                            {
                                lt.COLOR_ID = 1;
                                lt.PERCENTAGE = 100;
                            }
                            else if (cboColor.SelectedIndex == 1)
                            {
                                lt.COLOR_ID = 2;
                                lt.PERCENTAGE = 75;
                            }
                            else if (cboColor.SelectedIndex == 2)
                            {
                                lt.COLOR_ID = 3;
                                lt.PERCENTAGE = 50;
                            }
                            _context.SubmitChanges();
                        }
                    }
                    this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
