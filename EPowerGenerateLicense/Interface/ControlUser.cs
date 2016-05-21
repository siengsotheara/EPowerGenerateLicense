using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPowerGenerateLicense.Interface;
using EPowerGenerateLicense.Model;
using EPowerGenerateLicense.Class;
using EPowerGenerateLicense.Component;

namespace EPowerGenerateLicense.Interface
{
    public partial class ControlUser : UserControl
    {
        public ControlUser()
        {
            InitializeComponent();
        }
        private FormAddUser adduser;
        private LicenseDataContext _context;
        
        private void ControlUser_Load(object sender, EventArgs e)
        {
             
            adduser = new FormAddUser();
            using (TBL_USER_DATA_ACCESS uda = new TBL_USER_DATA_ACCESS())
            {
                dataGridViewUser.DataSource = uda.ShowUserAllIncludeInActive();
            }
        }

        private void dataGridViewUser_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewUser.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }

        private void dataGridViewUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int index = 3;  // COLOR_ID
            foreach (DataGridViewRow row in dataGridViewUser.Rows)
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
        public static int USER_ID;
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                btnAddNew.UseSelectable = false;
                using (adduser = new FormAddUser())
                {
                    adduser.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                GC.Collect();
            }
            finally
            {
                using (TBL_USER_DATA_ACCESS uda = new TBL_USER_DATA_ACCESS())
                {
                    dataGridViewUser.DataSource = uda.ShowUserAllIncludeInActive();
                }
                GC.Collect();
            }
            btnAddNew.UseSelectable = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            USER_ID = 0;
            try
            {
                foreach (DataGridViewRow row in dataGridViewUser.SelectedRows)
                {
                    USER_ID = Convert.ToInt32(row.Cells[0].Value);
                }
                //MessageBox.Show(SEASON_ID.ToString());
                if (USER_ID != 0)
                {
                    using (LicenseDataContext _context = new LicenseDataContext())
                    {
                        TBL_USER user = (from u in _context.TBL_USERs
                                             where u.USER_ID == USER_ID
                                             select u).FirstOrDefault();
                        user.IS_ACTIVE = false;
                        _context.SubmitChanges();
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                using (TBL_USER_DATA_ACCESS uda = new TBL_USER_DATA_ACCESS())
                {
                    dataGridViewUser.DataSource = uda.ShowUserAllIncludeInActive();
                }
                GC.Collect();
            }
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            USER_ID = 0;
            try
            {
                foreach (DataGridViewRow row in dataGridViewUser.SelectedRows)
                {
                    USER_ID = Convert.ToInt32(row.Cells[0].Value);
                }
                if (USER_ID != 0)
                {
                    FormUpdateUser update = new FormUpdateUser();
                    update.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                using (TBL_USER_DATA_ACCESS uda = new TBL_USER_DATA_ACCESS())
                {
                    dataGridViewUser.DataSource = uda.ShowUserAllIncludeInActive();
                }
                GC.Collect();
            }
        }
    }
}
