using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPowerGenerateLicense.Class;
using EPowerGenerateLicense.Model;

namespace EPowerGenerateLicense.Interface
{
    public partial class ControlSchedule : UserControl
    {
        public ControlSchedule()
        {
            InitializeComponent();
        }

        private void ControlSchedule_Load(object sender, EventArgs e)
        {
            using (TBL_SCHEDULE_DATA_ACCESS sda = new TBL_SCHEDULE_DATA_ACCESS())
            {
                dataGridViewSchedule.DataSource = sda.AvaibleLicenseToGenerateBySeasonID(1);
            };
        }

        private void dataGridViewSchedule_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewSchedule.ClearSelection();
        }
    }
}
