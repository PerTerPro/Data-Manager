using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.MerchantRankByWebsosanh
{
    public partial class frmMain : Form
    {
        private string connectionString = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDomain.Text))
            {
                string domainsearch = "%" + txtDomain.Text + "%";
                DBScoreTableAdapters.CompanyTableAdapter companyAdapter = new DBScoreTableAdapters.CompanyTableAdapter();
                companyAdapter.Connection.ConnectionString = connectionString;
                try
                {
                    companyAdapter.FillByDomain(dBScore.Company, domainsearch);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nhập domain!!!");
                txtDomain.Focus();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            connectionString = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        }

        private void btnViewMerchantScore_Click(object sender, EventArgs e)
        {
            ViewMerchantScore();
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMerchantScore();
        }
        private void ViewMerchantScore()
        {
            long idmerchant = 0;
            long.TryParse(iDSpinEdit.Text, out idmerchant);
            frmMerchantRankByWebsosanh frm = new frmMerchantRankByWebsosanh(idmerchant);
            frm.ShowDialog();
        }
        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(gridControl1, e.Location);
            }
        }

        private void btnShowGoogleSheet_Click(object sender, EventArgs e)
        {
            frmGoogleSheetApi frm = new frmGoogleSheetApi();
            frm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmCheckRank frm = new frmCheckRank();
            frm.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmReadFileCSV frm = new frmReadFileCSV();
            frm.ShowDialog();
        }


    }
}
