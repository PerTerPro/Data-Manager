using QT.Entities;
using QT.Entities.Images;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Drivers.RabbitMQ;
using Wss.Lib.RabbitMq;
using WSS.ImageServer;

namespace WSS.ImageImbo.UploadImageToImboServer.Websosanh
{
    public partial class FrmDownloadImageProduct : Form
    {
        private RabbitMQServer _rabbitMqServer;
        private ProducerBasic _producerUpdateImageIdSql;
        public FrmDownloadImageProduct()
        {
            InitializeComponent();
        }

        private void FrmUploadLogoWebsosanh_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Connection.ConnectionString = ConnectionCommon.ConnectionWebsosanh;
            _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
            _producerUpdateImageIdSql = new ProducerBasic(_rabbitMqServer, ConfigImages.ImboExchangeImages, ConfigImages.ImboRoutingKeyUploadImageIdSql);
        }
        private void btnDownloadByLink_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(iDTextEdit.Text))
            {
                ImageProductInfo product = new ImageProductInfo();
                product.Id = Common.Obj2Int64(iDTextEdit.Text);
                product.ImageUrls = imageUrlsTextEdit.Text;
                string message = string.Empty;
                if (CommonDownloadImage.DownloadImageProduct(product, _producerUpdateImageIdSql, ref message))
                    rbMessage.AppendText(string.Format("ProductId {0} success", product.Id) + System.Environment.NewLine);
                else rbMessage.AppendText(string.Format("ProductId {0} success fails: {1}", product.Id, message) + System.Environment.NewLine);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var Id = Common.Obj2Int64(idCheck.Text);
            try
            {
                productTableAdapter.FillBy_ID(dBWss.Product, Id);
            }
            catch (Exception ex)
            {
                rbMessage.AppendText(string.Format("ProductId {0} check Error: {1}", Id, ex.ToString()) + System.Environment.NewLine);
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblPath.Text = openFileDialog1.FileName;
                string path = openFileDialog1.FileName;
                if (!string.IsNullOrEmpty(path))
                {
                    ImageProductInfo product = new ImageProductInfo();
                    product.Id = Common.Obj2Int64(iDTextEdit.Text);
                    string message = string.Empty;
                    if (CommonDownloadImage.UploadImageProductByHand(path, product, _producerUpdateImageIdSql, ref message))
                        rbMessage.AppendText(string.Format("ProductId {0} success", product.Id) + System.Environment.NewLine);
                    else rbMessage.AppendText(string.Format("ProductId {0} success fails: {1}", product.Id, message) + System.Environment.NewLine);
                }
            }

        }
    }
}
