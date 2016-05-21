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
    public partial class ControlSeason : UserControl
    {
        private FormAddNewSeason _addseason;
        public ControlSeason()
        {
            InitializeComponent();
        }

        private void ControlSeason_Load(object sender, EventArgs e)
        {
            using (TBL_SEASON_DATA_ACCESS sda = new TBL_SEASON_DATA_ACCESS())
            {
                dataGridViewSeason.DataSource = sda.ShowAllSeasonIncludeInactive();
            }
        }

        private void dataGridViewSeason_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int index = 5;  // COLOR_ID
            foreach (DataGridViewRow row in dataGridViewSeason.Rows)
            {
                if ((bool)row.Cells[index].Value == false)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                    row.DefaultCellStyle.SelectionForeColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
        }

        private void dataGridViewSeason_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewSeason.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                btnAddNew.UseSelectable = false;
                using (_addseason = new FormAddNewSeason())
                {
                    _addseason.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                GC.Collect();
            }
            finally
            {
                using (TBL_SEASON_DATA_ACCESS sda = new TBL_SEASON_DATA_ACCESS())
                {
                    dataGridViewSeason.DataSource = sda.ShowAllSeasonIncludeInactive();
                }
                GC.Collect();
            }
            btnAddNew.UseSelectable = false;
        }  
        public static int SEASON_ID;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SEASON_ID = 0; 
            btnUpdate.UseSelectable = false;
            try
            {
                foreach (DataGridViewRow row in dataGridViewSeason.SelectedRows)
                {
                    SEASON_ID = Convert.ToInt32(row.Cells[0].Value);
                }
                //MessageBox.Show(SEASON_ID.ToString());
                if (SEASON_ID != 0)
                {
                    FormUpdateSeason update = new FormUpdateSeason();
                    update.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                using (TBL_SEASON_DATA_ACCESS sda = new TBL_SEASON_DATA_ACCESS())
                {
                    dataGridViewSeason.DataSource = sda.ShowAllSeasonIncludeInactive();
                }
            }
        }

        private void dataGridViewSeason_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewSeason.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SEASON_ID = 0;
            try
            {
                foreach (DataGridViewRow row in dataGridViewSeason.SelectedRows)
                {
                    SEASON_ID = Convert.ToInt32(row.Cells[0].Value);
                }
                //MessageBox.Show(SEASON_ID.ToString());
                if (SEASON_ID != 0)
                {
                    using (LicenseDataContext _context = new LicenseDataContext())
                    {
                        TBL_SEASON season = (from s in _context.TBL_SEASONs
                                              where s.SEASON_ID == SEASON_ID
                                              select s).FirstOrDefault();
                        season.IS_ACTIVE = false;
                        _context.SubmitChanges();
                    };
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                GC.Collect();
            }
            finally
            {
                using (TBL_SEASON_DATA_ACCESS sda = new TBL_SEASON_DATA_ACCESS())
                {
                    dataGridViewSeason.DataSource = sda.ShowAllSeasonIncludeInactive();
                }
            }
            btnDelete.UseSelectable = false;
        }
    }
}
