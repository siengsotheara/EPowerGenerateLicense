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
using MetroFramework;
using EPowerGenerateLicense.Component;
using System.Text.RegularExpressions;

namespace EPowerGenerateLicense.Interface
{
    public partial class ControlWork : UserControl
    {
        public ControlWork()
        {
            InitializeComponent();
        }
        FormMain parent = null;
        public static int SEASON_ID = 0;
        string REMAIN_LICENSE;
        string RESULT;
       
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.UseSelectable = false;
            try
            {
                SEASON_ID = 0;
                REMAIN_LICENSE = "";
               
                foreach (DataGridViewRow row in dataGridViewGenerate.SelectedRows)
                {
                    REMAIN_LICENSE = row.Cells[5].Value.ToString();
                    RESULT = Regex.Match(REMAIN_LICENSE, @"\d+").Value;
                  
                    SEASON_ID = Convert.ToInt32(row.Cells[0].Value);
                }
                if (Int32.Parse(RESULT) == 0)
                {
                    var result = MetroMessageBox.Show(this, "សូមអភ័យទោសចំនួនអាជា្ញប័ណ្ឌដែលត្រូវចេញអស់ហើយ ! ", "ពត៏មាន", MessageBoxButtons.OK);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {

                    }
                }
                else
                {
                    FormGenerateLicense generate = new FormGenerateLicense();
                    generate.ShowDialog(this);
                    GC.Collect();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());                
            }
            finally
            {
                using (TBL_SCHEDULE_DATA_ACCESS sda = new TBL_SCHEDULE_DATA_ACCESS())
                {
                    dataGridViewGenerate.DataSource = sda.DisplayToGenerate(Convert.ToInt32(cboSeason.SelectedValue));
                }
            }
        }

        private void ControlWork_Load(object sender, EventArgs e)
        {
            cboSeason.SelectedIndexChanged -= new EventHandler(cboSeason_SelectedIndexChanged); 
            TBL_SCHEDULE_DATA_ACCESS sda = new TBL_SCHEDULE_DATA_ACCESS();
            TBL_SEASON_DATA_ACCESS seda = new TBL_SEASON_DATA_ACCESS();
            
            cboSeason.DataSource = seda.ShowSeason();
            cboSeason.DisplayMember = "SEASON_NAME";
            cboSeason.ValueMember = "SEASON_ID";
            dataGridViewGenerate.DataSource = sda.DisplayToGenerate(Convert.ToInt32(cboSeason.SelectedValue));
            cboSeason.SelectedIndexChanged += new EventHandler(cboSeason_SelectedIndexChanged);
        }
        private void dataGridViewGenerate_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
         //   dataGridViewGenerate.ClearSelection();
        }

        public void cboSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(TBL_SCHEDULE_DATA_ACCESS sda = new TBL_SCHEDULE_DATA_ACCESS())
            {
                dataGridViewGenerate.DataSource = sda.DisplayToGenerate(Convert.ToInt32(cboSeason.SelectedValue));
            }
        }

        public void ckShowAllSeason_CheckedChanged(object sender, EventArgs e)
        {
            // by Sieng Sotheara 2016-4-28 
            if (ckShowAllSeason.Checked == true)
            {
                using (TBL_SEASON_DATA_ACCESS sda = new TBL_SEASON_DATA_ACCESS())
                {
                    DataTable dt = new DataTable();
                    
                        dt.Columns.Add("SEASON_ID");
                        dt.Columns.Add("SEASON_NAME");
                        DataRow row1 = dt.NewRow();
                        row1[0] = 0;
                        row1[1] = Properties.Resources.ALL_SEASON;
                        dt.Rows.Add(row1);
                        foreach (var item in sda.ShowAllSeason())
                        {
                            DataRow row = dt.NewRow();
                            row[0] = item.SEASON_ID;
                            row[1] = item.SEASON_NAME;
                            dt.Rows.Add(row);
                        }
                        cboSeason.DataSource = dt;
                        cboSeason.DisplayMember = "SEASON_NAME";
                        cboSeason.ValueMember = "SEASON_ID";
                };
            }
            else
            {
                using (TBL_SEASON_DATA_ACCESS sda = new TBL_SEASON_DATA_ACCESS())
                {
                    cboSeason.DataSource = sda.ShowSeason();
                };
            }
            GC.Collect();
        }

        private void dataGridViewGenerate_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
        private void dataGridViewGenerate_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewGenerate.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
            GC.Collect();
        }

        private void dataGridViewGenerate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            REMAIN_LICENSE = "";
            foreach (DataGridViewRow row in dataGridViewGenerate.SelectedRows)
            {
                SEASON_ID = (int)row.Cells[0].Value;
                //REMAIN_LICENSE = row.Cells[5].Value.ToString();
                //string RESULT = Regex.Match(REMAIN_LICENSE, @"\d+").Value;
            }
            if (e.ColumnIndex == 5)
            {
                FormLicenseAvailableBySeason frm = new FormLicenseAvailableBySeason();
                frm.ShowDialog();
            }
            else
            {
                GC.Collect();
            }
        }
    }
}
