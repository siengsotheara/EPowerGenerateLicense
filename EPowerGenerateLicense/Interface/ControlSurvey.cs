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
    public partial class ControlSurvey : UserControl
    {
        public ControlSurvey()
        {
            InitializeComponent();
        }

        private void cboSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (TBL_SCHEDULE_DATA_ACCESS sda = new TBL_SCHEDULE_DATA_ACCESS())
            {
                dataGridViewGenerate.DataSource = sda.DisplayToGenerate(Convert.ToInt32(cboSeason.SelectedValue));
            }
        }

        private void ControlSurvey_Load(object sender, EventArgs e)
        {
            TBL_SEASON_DATA_ACCESS seda = new TBL_SEASON_DATA_ACCESS();

            cboSeason.DataSource = seda.ShowSeason();
            cboSeason.DisplayMember = "SEASON_NAME";
            cboSeason.ValueMember = "SEASON_ID";
        }
    }
}
