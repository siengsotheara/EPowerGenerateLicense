using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPowerGenerateLicense.Component;
using EPowerGenerateLicense.Model;

namespace EPowerGenerateLicense.Interface
{
    public partial class ControlSurvey : UserControl
    {
        public ControlSurvey()
        {
            InitializeComponent();
        }
        public static DateTime DATE;
        public static string SEASON_NAME;
        public static string BY;
        string REMAIN_LICENSE;
        private TBL_SEASON_DATA_ACCESS sda = null;
        private void lblRemainNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(lblRemainNumber.Text.ToString());
        }

        private void ControlSurvey_Load(object sender, EventArgs e)
        {
            cboSeason.SelectedIndexChanged -= new EventHandler(cboSeason_SelectedIndexChanged);
            using (sda = new TBL_SEASON_DATA_ACCESS())
            {
                cboSeason.DataSource = sda.ShowAllSeason();
                cboSeason.DisplayMember = "SEASON_NAME";
                cboSeason.ValueMember = "SEASON_ID";
                dataGridViewSurvey.DataSource = sda.ShowSurvey(Convert.ToInt32(cboSeason.SelectedValue));
            }
            cboSeason.SelectedIndexChanged += new EventHandler(cboSeason_SelectedIndexChanged);
        }

        private void dataGridViewSurvey_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            REMAIN_LICENSE = "";
            SEASON_NAME = cboSeason.Text;
            foreach (DataGridViewRow row in dataGridViewSurvey.SelectedRows)
            {
                DATE = Convert.ToDateTime(row.Cells[1].Value);
                BY = row.Cells[2].Value.ToString();
                //REMAIN_LICENSE = row.Cells[5].Value.ToString();
                //string RESULT = Regex.Match(REMAIN_LICENSE, @"\d+").Value;
            }
            if (e.ColumnIndex == 3)
            {
                FormLicenseAvailableByCreateOn frm = new FormLicenseAvailableByCreateOn();
                frm.ShowDialog();
             //   MessageBox.Show(DATE.ToString());
            }
            else
            {
                GC.Collect();
            }
        }

        private void dataGridViewSurvey_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewSurvey.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
            GC.Collect();
        }

        private void cboSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (sda = new TBL_SEASON_DATA_ACCESS())
            {
                foreach (var item in sda.ShowSeason(Convert.ToInt32(cboSeason.SelectedValue)))
                {
                    lblRemainNumber.Text = item.REMAIN_LICENSE.ToString();
                }
                dataGridViewSurvey.DataSource = sda.ShowSurvey(Convert.ToInt32(cboSeason.SelectedValue));
            }
        }
    }
}
