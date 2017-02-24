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
    public partial class FrmPromotionListProduct : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmPromotionSingleProduct));
        RabbitMQServer _rabbitMqServer;
        JobClient _updateProductJobClient;
        public FrmPromotionListProduct()
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
                        productTableAdapter.Product_GetListProductByNameAndCompanyId(dBProduct.Product, nameSearch, companyId);
                    else
                        productTableAdapter.FillBy_CompanyId(dBProduct.Product, companyId);
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
            int i = 0;
            while (true)
            {
                try
                {
                    _updateProductJobClient.PublishJob(job);
                    break;
                }
                catch (Exception ex)
                {
                    if (i == 5)
                    {
                        MessageBox.Show("Error push message");
                        break;
                    }
                    else
                    {
                        Log.Error(string.Format("Publish Message update solr and redis product error. ProductId: {0}", productId), ex);
                        Thread.Sleep(10000);
                        i++;
                    }

                }
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

        private void btnUpdatePromotionListProduct_Click(object sender, EventArgs e)
        {
            Wait.Show("Cập nhật Promotion!");
            var listProductId = GetListIdProductSelectedInGrid();
            if (listProductId.Count > 0)
            {
                for (int i = 0; i < listProductId.Count; i++)
                {
                    productTableAdapter.UpdatePromotion(rbPromotionListProduct.Text, listProductId[i]);
                    SendMessageUpdateProductSolrAndRedisService(listProductId[i]);
                    Wait.Show(string.Format("{0}/{1} Updated productId = {2}", i + 1, listProductId.Count, listProductId[i]));
                }

            }
            else
                MessageBox.Show("Chưa chọn sản phẩm để cập nhật Promotion");
            Wait.Close();
        }
        private List<long> GetListIdProductSelectedInGrid()
        {
            var listResult = new List<long>();
            var listIndexSelected = gvProduct.GetSelectedRows();
            foreach (var item in listIndexSelected)
            {
                listResult.Add(Common.Obj2Int64(dBProduct.Product.Rows[item]["ID"]));
            }
            return listResult;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var dtProductFile = Common.GetDataTableFromExcelUsingOLEDB(openFileDialog1.FileName, "YES");
                    if (dtProductFile.Rows.Count == 0)
                    {
                        lbCount.Text = "Count: 0";
                        MessageBox.Show("File không có dữ liệu!");
                    }
                    else
                    {
                        int checkedSql = 0;
                        int uncheckedSql = 0;
                        for (int i = 0; i < dtProductFile.Rows.Count; i++)
                        {
                            var drProduct = dBProduct.Product.NewRow();
                            drProduct["Name"] = dtProductFile.Rows[i][0];
                            drProduct["DetailUrl"] = dtProductFile.Rows[i][1];
                            var productId = Common.GetIDProduct(dtProductFile.Rows[i][1].ToString());
                            var productTemp = new DBProduct.ProductDataTable();
                            productTableAdapter.FillBy_Id(productTemp, productId);
                            if (productTemp.Rows.Count == 0)
                            {
                                uncheckedSql++;
                                continue;
                            }

                            else
                            {
                                drProduct["ID"] = productId;
                                checkedSql++;
                            }
                            dBProduct.Product.Rows.Add(drProduct);
                        }
                        lbCheckedSql.Text = checkedSql.ToString();
                        lbUnCheckedSql.Text = uncheckedSql.ToString();
                        productGridControl.RefreshDataSource();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        }
    }
}
