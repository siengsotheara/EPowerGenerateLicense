using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPowerGenerateLicense.Model;
using EPowerGenerateLicense.Component;

namespace EPowerGenerateLicense.Interface
{
    public partial class ControlLicenseSpecial : UserControl
    {
        public ControlLicenseSpecial()
        {
            InitializeComponent();
        }

        private void ControlLicenseSpecial_Load(object sender, EventArgs e)
        {
            try
            {
                using (TBL_LICENSE_TYPE_DATA_ACCESS ltda = new TBL_LICENSE_TYPE_DATA_ACCESS())
                {
                    dataGridViewLicense.DataSource = ltda.ShowLicenseType();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           
        }

        private void dataGridViewLicense_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int index = 12;  // COLOR_ID
            foreach (DataGridViewRow row in dataGridViewLicense.Rows)
            {
                if ((int)row.Cells[index].Value == 1)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                    row.DefaultCellStyle.SelectionForeColor = Color.Red;
                }
                else if ((int)row.Cells[index].Value == 2)
                {
                    row.DefaultCellStyle.ForeColor = Color.Fuchsia;
                    row.DefaultCellStyle.SelectionForeColor = Color.Fuchsia;
                }
                else if ((int)row.Cells[index].Value == 3)
                {
                    row.DefaultCellStyle.ForeColor = Color.Blue;
                    row.DefaultCellStyle.SelectionForeColor = Color.Blue;
                }
                else if ((int)row.Cells[index].Value == 4)
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
                else
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
        }

        private void dataGridViewLicense_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewLicense.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (TBL_LICENSE_TYPE_DATA_ACCESS ltda = new TBL_LICENSE_TYPE_DATA_ACCESS())
                {
                    dataGridViewLicense.DataSource = ltda.Search(txtSearch.Text.Trim());
                }

            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddNewSpecialLicense frmspecial = new FormAddNewSpecialLicense();
                frmspecial.ShowDialog();
                using (TBL_LICENSE_TYPE_DATA_ACCESS ltda = new TBL_LICENSE_TYPE_DATA_ACCESS())
                {
                    dataGridViewLicense.DataSource = ltda.ShowLicenseType();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        public static int LICENSE_ID;
        public static int COLOR_ID;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            LICENSE_ID = 0;
            COLOR_ID = 0;
            try
            {
                foreach (DataGridViewRow row in dataGridViewLicense.SelectedRows)
                {
                    LICENSE_ID = Convert.ToInt32(row.Cells[0].Value);
                    COLOR_ID = Convert.ToInt32(row.Cells[12].Value);
                }
               // MessageBox.Show(LICENSE_ID.ToString());
                FormEditSpecialLicense frmeditspeciallicense = new FormEditSpecialLicense();
                frmeditspeciallicense.ShowDialog();
               
                using (TBL_LICENSE_TYPE_DATA_ACCESS ltda = new TBL_LICENSE_TYPE_DATA_ACCESS())
                {
                    dataGridViewLicense.DataSource = ltda.ShowLicenseType();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            GC.Collect();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
