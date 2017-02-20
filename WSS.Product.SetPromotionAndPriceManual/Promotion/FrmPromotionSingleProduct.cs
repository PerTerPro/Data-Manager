using log4net;
using QT.Entities;
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
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
namespace WSS.Product.SetPromotionAndPriceManual.Promotion
{
    public partial class FrmPromotionSingleProduct : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmPromotionSingleProduct));
        RabbitMQServer _rabbitMqServer;
        JobClient _updateProductJobClient;
        public FrmPromotionSingleProduct()
        {
            InitializeComponent();
        }

        private void FrmPromotionSingleProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBProduct.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Connection.ConnectionString = ConnectionCommon.ConnectionProduct;
            //RabbitMq
            _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigRabbitMqCacheSolrAndRedis.RabbitMqServerName);
            _updateProductJobClient = new JobClient(ConfigRabbitMqCacheSolrAndRedis.ExchangeProduct, GroupType.Topic, ConfigRabbitMqCacheSolrAndRedis.RoutingKeyUpdateSolrAndRedis, true, _rabbitMqServer);
        }

        private void btnCheckProductName_Click(object sender, EventArgs e)
        {
            dBProduct.Product.Clear();
            long companyId = Common.Obj2Int64(txtIdCompany.Text);
            if (companyId != 0)
            {
                try
                {
                    string nameSearch = Common.UnicodeToKoDauFulltext(txtNameProduct.Text);
                    if (!string.IsNullOrEmpty(nameSearch))
                    {
                        productTableAdapter.Product_GetListProductByNameAndCompanyId(dBProduct.Product, nameSearch, companyId);
                    }
                    else
                    {
                        MessageBox.Show("Nhập tên sản phẩm cần tìm!!!");
                        txtIdCompany.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nhập dữ liệu ID công ty!!!");
                txtIdCompany.Focus();
            }

        }






        private void SendMessageUpdateProductSolrAndRedisService(long productId)
        {
            var job = new Job { Data = BitConverter.GetBytes(productId), Type = 2 };
            while (true)
            {
                try
                {
                    _updateProductJobClient.PublishJob(job);
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("Publish Message update solr and redis product error. ProductId: {0}", productId), ex);
                    Thread.Sleep(10000);
                }
            }
        }

        private void btnCheckProductSku_Click(object sender, EventArgs e)
        {

        }

        private void txtDetailUrl_EditValueChanged(object sender, EventArgs e)
        {
            txtIdProductByLink.Text = Common.GetIDProduct(txtDetailUrl.Text).ToString();
        }

        private void btnCheckProductLinkDetail_Click(object sender, EventArgs e)
        {
            dBProduct.Product.Clear();
            try
            {
                long productId = Common.Obj2Int64(txtIdProductByLink.Text);
                if (productId != 0)
                {
                    productTableAdapter.FillBy_Id(dBProduct.Product, productId);
                }
                else
                {
                    MessageBox.Show("Nhập link sản phẩm hoặc ID sản phẩm!");
                    txtDetailUrl.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var productId = Common.Obj2Int64(iDTextEdit.Text);
            if (productId == 0)
                MessageBox.Show("Chưa chọn sản phẩm để cập nhật Promotion!");
            else
            {
                try
                {
                    productTableAdapter.UpdatePromotion(rbPromotionInfo.Text, productId);
                    SendMessageUpdateProductSolrAndRedisService(productId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void FrmPromotionSingleProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            _rabbitMqServer.Stop();
        }
    }
}
