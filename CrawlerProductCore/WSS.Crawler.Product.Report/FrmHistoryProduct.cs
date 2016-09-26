using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities;
using QT.Entities.Solr;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlerProduct.NoSql;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmHistoryProduct : Form
    {
        BindingList<ProductEntity> lstProduct = new BindingList<ProductEntity>();
        
        public FrmHistoryProduct()
        {
            InitializeComponent();
            this.gridControl1.DataSource = lstProduct;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            if (txtSession.Text != "")
            {
                string sesssion = Convert.ToString(txtSession.Text);
                lstProduct.Clear();
                SolrHistoryCrawlerProduct solrHistoryCrawlerProduct =SolrHistoryCrawlerProduct.Instace();
                NoSqlHistoryCrawler _noSqlHistoryCrawler = NoSqlHistoryCrawler.Instance();
                foreach (HistoryProductSorl historySolr in solrHistoryCrawlerProduct.GetHistoryOfSession(sesssion))
                {
                    lstProduct.Add(_noSqlHistoryCrawler.GetProduct(historySolr.Session, historySolr.ProductId,
                        historySolr.CompanyId));
                }
            }
            else if (txtProductId.Text != "")
            {
                long productId = Convert.ToInt64(txtProductId.Text);
                lstProduct.Clear();
                SolrHistoryCrawlerProduct solrHistoryCrawlerProduct = SolrHistoryCrawlerProduct.Instace();
                NoSqlHistoryCrawler noSqlHistoryCrawler = NoSqlHistoryCrawler.Instance();
                foreach (HistoryProductSorl historySolr in solrHistoryCrawlerProduct.GetHistoryOfProduct(productId))
                {
                    lstProduct.Add(noSqlHistoryCrawler.GetProduct(historySolr.Session, historySolr.ProductId,
                        historySolr.CompanyId));
                }
            }
        }

        public void LoadBySession(string session)
        {
            txtSession.Text = session;
            LoadData();
        }

       
    }
}
