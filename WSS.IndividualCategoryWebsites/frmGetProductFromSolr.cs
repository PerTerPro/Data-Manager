using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Castle.Components.DictionaryAdapter;
using DevExpress.XtraGrid.Views.Grid;
using log4net;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.Images;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.Drivers.Solr;
using WSS.IndividualCategoryWebsites.SolrProduct;

namespace WSS.IndividualCategoryWebsites
{
    public partial class frmGetProductFromSolr : Form
    {
        private SolrProductClient solrProductClient;
        private static readonly ILog Log = LogManager.GetLogger(typeof(frmGetProductFromSolr));
        private long _websiteId = 1;
        private string _domain;
        public frmGetProductFromSolr()
        {
            InitializeComponent();
            InitData();
        }
        public frmGetProductFromSolr(int idwebsite, string domain)
        {
            InitializeComponent();
            _websiteId = idwebsite;
            txtWebsiteId.Text = _websiteId.ToString();
            _domain = domain;
            txtDomain.Text = domain;
            InitData();
        }
        private void InitData()
        {
            solrProductClient = SolrProductClient.GetClient(SolrClientManager.GetSolrClient("solrProducts"));
        }
        private void btnGetListProductFromSolr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text))
            {
                MessageBox.Show(@"Nhập từ khóa!");
                txtKeyword.Focus();
            }
            else
            {
                Wait.Show("Loading...");
                var listkeywords =
                    txtKeyword.Text.Split(new string[] {"\n"}, StringSplitOptions.RemoveEmptyEntries).ToList();
                int numberFound;
                var result = solrProductClient.GetListCategoryProductByKeyword(listkeywords, 0, 1, out numberFound);
                grdCategory.DataSource = result;
                txtNumberFound.Text = numberFound.ToString();
                txtLimitPushMessage.Text = numberFound.ToString();
                Wait.Close();
            }
        }

        private void btnPushAllProductToServiceRootProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text))
            {
                MessageBox.Show(@"Nhập từ khóa!");
                txtKeyword.Focus();
            }
            else
            {
                Wait.Show("Loading...");
                var limitResult = Convert.ToInt32(txtLimitPushMessage.Text);
                var listkeywords =
                    txtKeyword.Text.Split(new string[] {"\n"}, StringSplitOptions.RemoveEmptyEntries).ToList();
                int numberFound = 0;
                var listProduct = solrProductClient.GetAllProductsByKeywords(listkeywords, 0, limitResult,
                    out numberFound);
                foreach (var product in listProduct)
                {
                    product.WebsiteId = _websiteId;
                }
                var jsonobject = JsonConvert.SerializeObject(listProduct);
                SendMessageToServiceRootProduct(jsonobject);
                Wait.Close();
            }
        }

        private void SendMessageToServiceRootProduct(string jsonObject)
        {
            var rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigRabbitMqIndividualCategoryWebsites.RabbitMqServerName);
            var individualJobClient = new ProducerBasic(rabbitMqServer, ConfigRabbitMqIndividualCategoryWebsites.ExchangeIndividual, ConfigRabbitMqIndividualCategoryWebsites.RoutingKeyProduct);
            while (true)
            {
                try
                {
                    individualJobClient.Publish(UtilZipFile.Zip(jsonObject));
                    Log.Info(string.Format("Push message to services success."));
                    break;
                }
                catch (Exception exception)
                {
                    Log.Error(string.Format("Push message error."), exception);
                    Thread.Sleep(60000);
                }
            }
        }

        private void gvCategory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.grdCategory, new Point(e.X, e.Y));
                GetRowAt(gvCategory, e.X, e.Y);
            }
        }
        private void gvProduct_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip2.Show(this.grdProduct, new Point(e.X, e.Y));
                //GetRowAt(gvProduct, e.X, e.Y);
            }
        }
        public void GetRowAt(GridView view, int x, int y)
        {
            if (view == gvCategory)
            {
                txtCategoryId.Text = gvCategory.GetRowCellValue(view.CalcHitInfo(new Point(x, y)).RowHandle, "CategoryId").ToString();
                txtCategoryName.Text =
                    gvCategory.GetRowCellValue(view.CalcHitInfo(new Point(x, y)).RowHandle, "CategoryName").ToString();
            }
        }

        private void gvCategory_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.RowHandle>=0)
            {
                txtCategoryId.Text = gvCategory.GetRowCellValue(e.RowHandle, "CategoryId").ToString();
                txtCategoryName.Text = gvCategory.GetRowCellValue(e.RowHandle, "CategoryName").ToString();
            }
        }

        private void ViewDetailProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wait.Show("Loading...");
            var limitResult = Convert.ToInt32(txtLimitPushMessage.Text);
            var listkeywords = txtKeyword.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var listProduct = solrProductClient.GetProductsByKeywordsAndCategory(listkeywords,Convert.ToInt32(txtCategoryId.Text), 0, limitResult);
            foreach (var product in listProduct)
            {
                product.WebsiteId = _websiteId;
            }
            grdProduct.DataSource = listProduct;
            Wait.Close();
        }
        private void ViewAllProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wait.Show("Loading...");
            var limitResult = Convert.ToInt32(txtLimitPushMessage.Text);
            var listkeywords = txtKeyword.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int numberFound;
            var listProduct = solrProductClient.GetAllProductsByKeywords(listkeywords, 0, limitResult,
                    out numberFound);
            foreach (var product in listProduct)
            {
                product.WebsiteId = _websiteId;
            }
            grdProduct.DataSource = listProduct;
            Wait.Close();
        }
        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGetListProductFromSolr_Click(sender, e);
            }
        }

        private void SendListProductToServiceRootProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var arrIndexRowSelected = gvProduct.GetSelectedRows();
            if (arrIndexRowSelected.Length > 0)
            {
                var listProductItems = new List<SolrProductItem>();
                foreach (var rowHande in arrIndexRowSelected)
                {
                    var productItem = new SolrProductItem
                    {
                        Id = Common.Obj2Int64(gvProduct.GetRowCellValue(rowHande, "Id")),
                        Name = gvProduct.GetRowCellValue(rowHande, "Name").ToString(),
                        Price = Common.Obj2Int64(gvProduct.GetRowCellValue(rowHande, "Price")),
                        MerchantScore = Common.Obj2Int(gvProduct.GetRowCellValue(rowHande, "MerchantScore")),
                        CategoryId = Common.Obj2Int(gvProduct.GetRowCellValue(rowHande, "CategoryId")),
                        WebsiteId = _websiteId
                    };
                    listProductItems.Add(productItem);
                }
                var jsonobject = JsonConvert.SerializeObject(listProductItems);
                SendMessageToServiceRootProduct(jsonobject);
            }
            else
                MessageBox.Show(@"Chọn sản phẩm rồi push message lên hệ thống");
        }

        

        
    }
}
