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
using MetroFramework;
using EPowerGenerateLicense.Class;


namespace EPowerGenerateLicense.Interface
{
    public partial class ControlLicense : UserControl
    {
        public ControlLicense()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ControlLicense_Load(object sender, EventArgs e)
        {
            LICENSE_NUMBER = string.Empty;   
            using (TBL_LICENSE_DATA_ACCESS lda = new TBL_LICENSE_DATA_ACCESS())
            {
                dataGridViewLicense.DataSource = lda.ShowLicense();
            };
            GC.Collect();
        }


        
        public static string LICENSE_NUMBER;

       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                using (TBL_LICENSE_DATA_ACCESS lda = new TBL_LICENSE_DATA_ACCESS())
                {
                    dataGridViewLicense.DataSource = lda.Search(txtSearch.Text);
                }
            }
            else
            {
                using (TBL_LICENSE_DATA_ACCESS lda = new TBL_LICENSE_DATA_ACCESS())
                {
                    dataGridViewLicense.DataSource = lda.ShowLicense();
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormAddNewLicense add = new FormAddNewLicense();
            add.ShowDialog(this);
            using (TBL_LICENSE_DATA_ACCESS lda = new TBL_LICENSE_DATA_ACCESS())
            {
                dataGridViewLicense.DataSource = lda.ShowLicense();
            }
            btnAddNew.UseSelectable = false;
            GC.Collect();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewLicense.SelectedRows)
            {
                LICENSE_NUMBER = row.Cells[1].Value.ToString();
            }
       //     MessageBox.Show(LICENSE_NUMBER);
            if (LICENSE_NUMBER == string.Empty || LICENSE_NUMBER == null)
            {

            }
            else
            {
                var result = MetroMessageBox.Show(this, "Are you sure to delete it?", "Delete", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    using (LicenseDataContext _context = new LicenseDataContext())
                    {
                        TBL_LICENSE license = (from l in _context.TBL_LICENSEs
                                               where l.LICENSE_NUMBER == LICENSE_NUMBER
                                               select l).FirstOrDefault();
                        license.IS_ACTIVE = false;
                        _context.SubmitChanges();

                    }
                    using (TBL_LICENSE_DATA_ACCESS lda = new TBL_LICENSE_DATA_ACCESS())
                    {
                        dataGridViewLicense.DataSource = lda.ShowLicense();
                    }
                    GC.Collect();
                }
            }
            GC.Collect();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //FormUpdateLicense frmupdate = new FormUpdateLicense();

            foreach (DataGridViewRow row in dataGridViewLicense.SelectedRows)
            {
                LICENSE_NUMBER = row.Cells[1].Value.ToString();
            }
         //   MessageBox.Show(LICENSE_NUMBER.ToString());
            if (LICENSE_NUMBER != string.Empty)
            {
                FormUpdateLicense update = new FormUpdateLicense();
                update.ShowDialog(this);
            }
            else
            {

            }
            using (TBL_LICENSE_DATA_ACCESS lda = new TBL_LICENSE_DATA_ACCESS())
            {
                dataGridViewLicense.DataSource = lda.ShowLicense();
            }
            btnEdit.UseSelectable = false;
            GC.Collect();
        }

        private void dataGridViewLicense_DataMemberChanged(object sender, EventArgs e)
        {
            dataGridViewLicense.ClearSelection();
        }

        private void dataGridViewLicense_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewLicense.ClearSelection();
        }

        private void dataGridViewLicense_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewLicense.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }

        private void dataGridViewLicense_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int index = 6;  // COLOR_ID
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

    }
}
