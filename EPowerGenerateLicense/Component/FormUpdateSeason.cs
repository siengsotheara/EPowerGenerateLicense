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
    public partial class FormUpdateSeason : MetroForm
    {
        public FormUpdateSeason()
        {
            InitializeComponent();
        }
        private int SEASON_ID;
        private LicenseDataContext _context;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
        }

        private void FormUpdateSeason_Load(object sender, EventArgs e)
        {
            using (TBL_SEASON_DATA_ACCESS sda = new TBL_SEASON_DATA_ACCESS())
            {
                foreach (var item in sda.CheckSeasonWithoutExisting(txtSeasonName.Text))
                {
                    SEASON_NAME = item.SEASON_NAME;
                    MessageBox.Show(SEASON_NAME);
                }

            }
            try
            {
                using (TBL_SEASON_DATA_ACCESS sda = new TBL_SEASON_DATA_ACCESS())
                {
                    foreach (var item in sda.ShowSeasonNameByID(Convert.ToInt32(ControlSeason.SEASON_ID)))
                    {
                        txtSeasonName.Text = item.SEASON_NAME;
                        txtNote.Text = item.NOTE;
                        txtCreateBy.Text = item.CREATE_BY;
                        SEASON_ID = item.SEASON_ID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            GC.Collect();
        }
        private string SEASON_NAME;
        public bool Invalid()
        {
            bool flag = false;
            using (TBL_SEASON_DATA_ACCESS sda = new TBL_SEASON_DATA_ACCESS())
            {
                foreach (var item in sda.CheckSeasonWithoutExisting(txtSeasonName.Text))
                {
                    SEASON_NAME = item.SEASON_NAME;
                    MessageBox.Show(SEASON_NAME);
                     if (txtSeasonName.Text == SEASON_NAME)
                    {
                        this.txtSeasonName.SetValidation(string.Format(Properties.Resources.SEASON_AREADY, this.label1.Text));
                        flag = true;
                        txtSeasonName.Focus();
                    }

                }

            }
           
            return flag;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (_context = new LicenseDataContext())
                {
                    TBL_SEASON season = (from s in _context.TBL_SEASONs
                                         where s.SEASON_ID == SEASON_ID
                                         select s).FirstOrDefault();
                    season.SEASON_NAME = txtSeasonName.Text.Trim().ToString();
                    season.NOTE = txtNote.Text.Trim().ToString();
                    if (ckUseAgain.Checked == true)
                    {
                        season.IS_ACTIVE = true;
                    }
                    _context.SubmitChanges();
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
