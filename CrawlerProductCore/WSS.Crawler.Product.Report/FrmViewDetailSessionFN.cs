using QT.Moduls.LogCassandra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Moduls.CrawlerProduct;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmViewDetailSessionFN : Form
    {
        LogCrawler logCrawler = LogCrawler.Instance;
        private string Session = "";
        public FrmViewDetailSessionFN()
        {
            InitializeComponent();
        }
        public FrmViewDetailSessionFN(string strSession)
        {
            InitializeComponent();
            this.Session = strSession;
        }
        private void FrmViewDetailSessionFN_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            SolrHistoryCrawlerProduct solrHistoryCrawler = SolrHistoryCrawlerProduct.Instace();
            this.gridControl1.DataSource = solrHistoryCrawler.GetHistoryOfSession(this.Session);
        }
    }
}
