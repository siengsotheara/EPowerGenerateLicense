using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPowerGenerateLicense.Interface
{
    public partial class ControlWorkMenuLeft : UserControl
    {
        FormMain parent = null;
        ControlSchedule cs = null;
        public ControlWorkMenuLeft()
        {
            InitializeComponent();
            
        }

        public void metroLink1_Click(object sender, EventArgs e)
        {
            metroLink2.Enabled = true;
            metroLink1.Enabled = false;
            metroLink3.Enabled = true;
            metroLink4.Enabled = true;
            parent.ShowWork(null, null);
            GC.Collect();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            metroLink3.Enabled = true;
            metroLink2.Enabled = false;
            metroLink1.Enabled = true;
            metroLink4.Enabled = true;
            parent.ShowSeason(null, null);
            GC.Collect();
        }

        private void ControlWorkMenuLeft_Load(object sender, EventArgs e)
        {
            parent = this.ParentForm as FormMain;
            metroLink4.Enabled = false;
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            metroLink3.Enabled = false;
            metroLink2.Enabled = true;
            metroLink1.Enabled = true;
            metroLink4.Enabled = true;
            parent.ShowUser(null, null);
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            parent.ShowSurvey(null, null);
            metroLink1.Enabled = true;
            metroLink2.Enabled = true;
            metroLink3.Enabled = true;
            metroLink4.Enabled = false;
        }
    }
}
