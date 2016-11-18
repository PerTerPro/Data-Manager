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
    public partial class FrmSetNextCrawler : Form
    {
        public FrmSetNextCrawler()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler redisCompanyWaitCrawler = QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler.Instance();
            List<long> companyIDS = new List<long>();
            foreach (var rowSelected in this.richTextBox1.Text.Split(new char[] { ';', ',', '\n', ' ' }))
            {
                companyIDS.Add(Convert.ToInt64(rowSelected));
            }

            if (rbFN.Checked) 
                redisCompanyWaitCrawler.SetNexFindNew(companyIDS, dtpTimeRun.Value);
            else
                redisCompanyWaitCrawler.SetNexReload(companyIDS, this.dtpTimeRun.Value);
            MessageBox.Show("Success");
        }
    }
}
