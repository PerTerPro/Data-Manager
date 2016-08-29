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
    public partial class frmMerchantRankByWebsosanh : Form
    {
        private string connectionString = "";
        public frmMerchantRankByWebsosanh()
        {
            InitializeComponent();
            LoadData(0);
        }
        public frmMerchantRankByWebsosanh(long idmerchant)
        {
            InitializeComponent();
            LoadData(idmerchant);
        }

        private void frmMerchantRankByWebsosanh_Load(object sender, EventArgs e)
        {
            connectionString = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
            merchantScoreTableAdapter.Connection.ConnectionString = connectionString;
        }
        private void LoadData(long idmerchant)
        {
            dBScore.MerchantScore.Rows.Clear();
            if (idmerchant == 0)
            {
                try
                {
                    merchantScoreTableAdapter.Fill(dBScore.MerchantScore);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
            }
            else
            {
                try
                {
                    merchantScoreTableAdapter.FillBy_MerchantID(dBScore.MerchantScore,idmerchant);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
            }
        }
    }
}
