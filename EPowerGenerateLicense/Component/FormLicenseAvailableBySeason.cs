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

namespace EPowerGenerateLicense.Component
{
    public partial class FormLicenseAvailableBySeason : MetroForm
    {
        public FormLicenseAvailableBySeason()
        {
            InitializeComponent();
        }

        private void FormLicenseAvailableBySeason_Load(object sender, EventArgs e)
        {
            try
            {
                using (TBL_LICENSE_DATA_ACCESS lda = new TBL_LICENSE_DATA_ACCESS())
                {
                    dataGridViewLicense.DataSource = lda.DisplayAvailableLicenseBySeasonID(ControlWork.SEASON_ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewLicense_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewLicense.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }

        private void dataGridViewLicense_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = 5;  // COLOR_ID
            foreach (DataGridViewRow row in dataGridViewLicense.Rows)
            {
                if (row.Cells[index].Value == null)
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
                else if ((int)row.Cells[index].Value == 1)
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

        private void dataGridViewLicense_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewLicense.ClearSelection();
        }
    }
}
