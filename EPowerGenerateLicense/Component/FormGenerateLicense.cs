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
using EPowerGenerateLicense.Interface;
using EPowerGenerateLicense.Model;
using MetroFramework;

namespace EPowerGenerateLicense.Component
{
    public partial class FormGenerateLicense : MetroForm
    {
        public FormGenerateLicense()
        {
            InitializeComponent();
        }
     
        private int SEASON_ID;
        private LicenseDataContext _context;
    
        private void FormGenerateLicense_Load(object sender, EventArgs e)
        {            
            try
            {
                parent = this.ParentForm as FormMain;
                cboTake.SelectedIndex = 9;
                cboUser.SelectedIndex = 0;
                dateTimePickerLicenseGenerate.MinDate = DateTime.Today;
                using (TBL_SEASON_DATA_ACCESS sda = new TBL_SEASON_DATA_ACCESS())
                {
                    var season_name = sda.ShowSeasonNameByID(ControlWork.SEASON_ID);
                    foreach (var item in season_name)
                    {
                        txtSeason.Text = item.SEASON_NAME.ToString();
                        SEASON_ID = item.SEASON_ID;
                    }
                }
                using (TBL_USER_DATA_ACCESS uda = new TBL_USER_DATA_ACCESS())
                {
                    cboUser.DataSource = uda.ShowUserActive();
                    cboUser.DisplayMember = "USERNAME";
                    cboUser.ValueMember = "USER_ID";
                }
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        FormMain parent;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        FormMain frmmain;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            frmmain = new FormMain();
            try
            {
                using (TBL_LICENSE_GENERATE_DATA_ACCESS lgda = new TBL_LICENSE_GENERATE_DATA_ACCESS())
                {
                    List<int> SCHEDULE_ID = new List<int>();
                    List<int> temp = new List<int>();
                    List<int> result = new List<int>();
                    //MessageBox.Show(SEASON_ID.ToString());
                    foreach (var schedule_id in lgda.RunningAvailableLicenseBySeasonID(SEASON_ID))
                    {
                        SCHEDULE_ID.Add(schedule_id.SCHEDULE_ID);
                        //  MessageBox.Show(schedule_id.SCHEDULE_ID.ToString());
                    }
                    Random rnd = new Random();
                    for (int i = 0; i < SCHEDULE_ID.Count; i++)
                    {
                        int num = rnd.Next(SCHEDULE_ID.Count);
                        if (!temp.Contains(num))
                        {
                            temp.Add(num);
                            result.Add(SCHEDULE_ID[num]);
                        }
                        else
                            i--;
                    }
                    try
                    {
                        //  MessageBox.Show(cboUser.Text.ToString());
                        foreach (var item in result.Take(Convert.ToInt32(cboTake.SelectedItem)))
                        {
                            using (_context = new LicenseDataContext())
                            {
                                TBL_LICENSE_GENERATE lg = new TBL_LICENSE_GENERATE()
                                {
                                    SCHEDULE_ID = Convert.ToInt32(item),
                                    CREATE_ON = Convert.ToDateTime(dateTimePickerLicenseGenerate.Value.ToString("yyy-MM-dd hh:mm")),
                                    CREATE_BY = cboUser.Text,
                                    NOTE = "-",
                                    LAST_MODIFIED = DateTime.Now,
                                    IS_ACTIVE = true

                                };
                                lgda.SaveLicenseGenerate(lg);
                            }
                        }
                        var dialog = MetroMessageBox.Show(this, Properties.Resources.SUCCESSFULL, Properties.Resources.INFORMATION, MessageBoxButtons.OK);
                        if (dialog == System.Windows.Forms.DialogResult.OK)
                        {
                            frmmain.RefreshMain();
                            frmmain.ShowWork(null, null);
                            this.Close();
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
