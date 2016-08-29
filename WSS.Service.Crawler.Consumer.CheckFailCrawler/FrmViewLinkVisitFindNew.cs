using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities.Solr;
using QT.Moduls.CrawlerProduct;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmViewLinkVisitFindNew : Form
    {
        public FrmViewLinkVisitFindNew()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        public void LoadBySession(string sesion)
        {
            textBox1.Text = sesion;
            RefreshData();
        }

        private void RefreshData()
        {
            string session = textBox1.Text;
            SolrFindNewCrawlerProduct solr = SolrFindNewCrawlerProduct.Instace();
            solr.GetHistoryOfSession(session);
            this.gridControl1.DataSource = solr.GetHistoryOfSession(session);
        }

        private void FrmViewLinkVisitFindNew_Load(object sender, EventArgs e)
        {

        }
    }
}
