using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmVCompanyConfigCrawler : Form
    {
        public FrmVCompanyConfigCrawler()
        {
            InitializeComponent();
        }

        private void FrmVCompanyConfigCrawler_Load(object sender, EventArgs e)
        {
         this.Refresh();

        }

        private void Refresh()
        {
            // TODO: This line of code loads data into the 'dsQT2.V_Company_CrawlerFail' table. You can move, or remove it, as needed.
            this.v_Company_CrawlerFailTableAdapter.Fill(this.dsQT2.V_Company_CrawlerFail);
            // TODO: This line of code loads data into the 'dsQT2.V_Company_ConfigCrawler' table. You can move, or remove it, as needed.
            this.v_Company_ConfigCrawlerTableAdapter.Fill(this.dsQT2.V_Company_ConfigCrawler);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh(); 
        }
    }
}
