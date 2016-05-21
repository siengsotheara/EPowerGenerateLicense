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
using SoftTech.Helper;
using SoftTech;

namespace EPowerGenerateLicense.Component
{
    public partial class FormAddNewSeason : MetroForm
    {
        private LicenseDataContext _context;
        public FormAddNewSeason()
        {
            InitializeComponent();
        }
        private int SEASON_ID;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Invalid())
            {
                try
                {
                    using (TBL_SEASON_DATA_ACCESS sda = new TBL_SEASON_DATA_ACCESS())
                    {
                        using (_context = new LicenseDataContext())
                        {
                            TBL_SEASON season = new TBL_SEASON()
                            {
                                SEASON_NAME = txtSeasonName.Text,
                                CREATE_BY = cboUser.Text,
                                IS_ACTIVE = true,
                                CREATE_DATE = DateTime.Now,
                                NOTE = txtNote.Text.Trim()
                            };
                            sda.SaveSeason(season);
                            foreach (var item in sda.ShowSeasonNameByName(txtSeasonName.Text))
                            {
                                SEASON_ID = item.SEASON_ID;
                            }
                            TBL_SCHEDULE schedule = new TBL_SCHEDULE();
                            foreach (var item in ListSchedule)
                            {
                                schedule.LICENSE_ID = item;
                                schedule.SEASON_ID = SEASON_ID;
                                sda.SaveSchedule(schedule);
                            }
                            this.Close();
                        };
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
        private string SEASON_NAME;
        private bool Invalid()
        {
            bool flag = false;
            using (TBL_SEASON_DATA_ACCESS sda = new TBL_SEASON_DATA_ACCESS())
            {
                foreach (var item in sda.CheckSeason(txtSeasonName.Text))
                {
                    SEASON_NAME = item.SEASON_NAME;
                }

            }
            if (txtSeasonName.Text == SEASON_NAME)
            {
                this.txtSeasonName.SetValidation(string.Format(Properties.Resources.SEASON_AREADY, this.label1.Text));
                flag = true;
                txtSeasonName.Focus();
            }
            if (txtSeasonName.Text == string.Empty)
            {
                this.txtSeasonName.SetValidation(string.Format(Properties.Resources.REQUIRED_SEASON, this.label1.Text));
                flag = true;
                txtSeasonName.Focus();
            }
            using(TBL_USER_DATA_ACCESS uda = new TBL_USER_DATA_ACCESS())
            {
                if (!uda.Authentication(cboUser.Text, txtPassword.Text.Trim()))
                {
                    this.txtPassword.SetValidation(string.Format(Properties.Resources.WRONG_PASSWORD, this.label1.Text));
                    flag = true;
                    txtPassword.Focus();
                }
            }
            
            return flag;
        }
        private List<int> ListSchedule;
        private void FormAddNewSeason_Load(object sender, EventArgs e)
        {
            try
            {
                ListSchedule = new List<int>();
                cboUser.SelectedIndex = 0;
                using (TBL_USER_DATA_ACCESS uda = new TBL_USER_DATA_ACCESS())
                {
                    cboUser.DataSource = uda.ShowUserActive();
                    cboUser.DisplayMember = "USERNAME";
                    cboUser.ValueMember = "USER_ID";
                }
                using (TBL_SEASON_DATA_ACCESS sda = new TBL_SEASON_DATA_ACCESS())
                {
                    foreach (var item in sda.ShowAllLicense())
                    {
                        ListSchedule.Add(item.LICENSE_ID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void txtSeasonName_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = UIHelper.Khmer;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = UIHelper.English;
        }

        private void txtNote_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = UIHelper.English;
        }
    }
}
