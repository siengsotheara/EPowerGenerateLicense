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
using MetroFramework.Forms;

namespace EPowerGenerateLicense.Component
{
    public partial class FormLicenseAvailableByCreateOn : MetroForm
    {
        public FormLicenseAvailableByCreateOn()
        {
            InitializeComponent();
        }

        private void FormLicenseAvailableByCreateOn_Load(object sender, EventArgs e)
        {
            lblHeader.Text = ControlSurvey.SEASON_NAME;
            lblDate.Text = Convert.ToString(ControlSurvey.DATE);
            lblBy.Text = ControlSurvey.BY;
             using (TBL_LICENSE_GENERATE_DATA_ACCESS lgda = new TBL_LICENSE_GENERATE_DATA_ACCESS())
            {
                dataGridViewFollowUP.DataSource = lgda.ShowLicenseByCreateOn(ControlSurvey.DATE);
            }
        }

        private void dataGridViewFollowUP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int index = 10;  // COLOR_ID
            foreach (DataGridViewRow row in dataGridViewFollowUP.Rows)
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

        private void dataGridViewFollowUP_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewFollowUP.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
            GC.Collect();
        }
    }
}
