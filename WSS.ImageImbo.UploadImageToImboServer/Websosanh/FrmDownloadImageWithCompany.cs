using QT.Entities;
using QT.Entities.Images;
using QT.Moduls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.ImageServer;

namespace WSS.ImageImbo.UploadImageToImboServer.Websosanh
{
    public partial class FrmDownloadImageWithCompany : Form
    {
        public FrmDownloadImageWithCompany()
        {
            InitializeComponent();
        }

        private void FrmUploadLogoWebsosanh_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Connection.ConnectionString = ConnectionCommon.ConnectionWebsosanh;
            this.companyTableAdapter.Connection.ConnectionString = ConnectionCommon.ConnectionWebsosanh;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string domain = "%" + txtDomain.Text + "%";
            try
            {
                companyTableAdapter.FillBy_LikeDomain(dBWss.Company, domain);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            long idCompany = Common.Obj2Int64(iDTextEdit.Text);
            rbSuccess.Text = "";
            rbFail.Text = "";
            rbListIdFails.Clear();
            Thread thread = new Thread(() => DownloadImageWithCompany(idCompany));
            thread.Start();
        }

        private void DownloadImageWithCompany(long idCompany)
        {
            this.Invoke(new Action(() =>
            {
                rbSuccess.AppendText(string.Format("Start get from Database with CompanyId = {0}", idCompany) + System.Environment.NewLine);
            }));
            try
            {
                if (idCompany == 6619858476258121218)
                {
                    this.Invoke(new Action(() =>
                    {
                        rbSuccess.AppendText("STOP download with ID = 6619858476258121218");
                    }));
                    return;
                    //productTableAdapter.FillBy_CompanyRootProductNotImageId(dBWss.Product);
                }
                else if (checkEditReloadAll.Checked)
                    productTableAdapter.FillAllBy_CompanyAndValid(dBWss.Product, idCompany, true);
                else
                    productTableAdapter.FillBy_CompanyAndValidAndImageId(dBWss.Product, idCompany, true);
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    rbFail.AppendText("Get data product from SQL error:" + System.Environment.NewLine +
                                        ex.ToString() + System.Environment.NewLine);
                }));

            }
            if (dBWss.Product.Rows.Count > 0)
            {
                this.Invoke(new Action(() =>
                {
                    lbCount.Text = dBWss.Product.Rows.Count.ToString();
                    rbSuccess.AppendText(string.Format("Get {1} product need download from Database with CompanyId = {0}", idCompany, dBWss.Product.Rows.Count) + System.Environment.NewLine);
                }));

                var rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
                var producerUpdateImageIdSql = new ProducerBasic(rabbitMqServer, ConfigImages.ImboExchangeImages, ConfigImages.ImboRoutingKeyUploadImageIdSql);
                int success = 0;
                int fail = 0;
                for (int i = 0; i < dBWss.Product.Rows.Count; i++)
                {
                    ImageProductInfo product = new ImageProductInfo();
                    product.Id = Common.Obj2Int64(dBWss.Product.Rows[i]["ID"]);
                    product.ImageUrls = dBWss.Product.Rows[i]["ImageUrls"].ToString();
                    string message = string.Empty;
                    if (CommonDownloadImage.DownloadImageProduct(product, producerUpdateImageIdSql, ref message))
                    {
                        success++;
                        this.Invoke(new Action(() =>
                        {
                            lbSuccess.Text = success.ToString();
                            rbSuccess.AppendText(string.Format("CompanyId = {0}: {1}/{2} success", idCompany, i, dBWss.Product.Count) + System.Environment.NewLine);
                        }));
                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            rbSuccess.AppendText(string.Format("CompanyId = {0}: {1}/{2} fails", idCompany, i, dBWss.Product.Count) + System.Environment.NewLine);
                        }));

                        fail++;
                        this.Invoke(new Action(() =>
                        {
                            if (rbFail.TextLength > 1000000)
                            {
                                rbFail.Clear();
                            }
                            lbFails.Text = fail.ToString();
                            rbFail.AppendText(string.Format("CompanyId = {0}: {1}/{2} fails: {3}", idCompany, i, dBWss.Product.Count, message) + System.Environment.NewLine);
                            rbListIdFails.AppendText(product.Id + System.Environment.NewLine);
                        }));

                    }
                }
                this.Invoke(new Action(() =>
                {
                    rbSuccess.AppendText(string.Format("CompanyId = {0} downloaded {1}/{2} image", idCompany, success, dBWss.Product.Count) + System.Environment.NewLine);
                }));

                rabbitMqServer.Stop();
            }
            else
                this.Invoke(new Action(() =>
                {
                    rbSuccess.AppendText(string.Format("CompanyId {0} 0 product download image", idCompany) + System.Environment.NewLine);
                }));

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var url = txtImageUrlsTest.Text;
            try
            {
                url = url.Replace(@"///", @"//").Replace(@"////", @"//");
                var regexhttp = Regex.Match(url, "http").Captures;
                if (regexhttp.Count > 1)
                    url = url.Substring(url.LastIndexOf("http"));
                else if (regexhttp.Count == 0)
                    url = "http://" + url;
                var requestdownload = (HttpWebRequest)WebRequest.Create(url);
                requestdownload.Credentials = CredentialCache.DefaultCredentials;
                requestdownload.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                       | SecurityProtocolType.Tls11
                                                       | SecurityProtocolType.Tls12
                                                       | SecurityProtocolType.Ssl3;

                //ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                var responseImageDownload = (HttpWebResponse)requestdownload.GetResponse();
                var streamImageDownload = responseImageDownload.GetResponseStream();
                rbSuccess.AppendText(url + "download Success!" + System.Environment.NewLine);
            }
            catch (Exception ex)
            {
                rbFail.AppendText(url + ex.ToString() + System.Environment.NewLine);
            }

        }

        private void btnDownloadImageRootProduct_Click(object sender, EventArgs e)
        {

        }


        private void DownloadImageRootProduct()
        {
            this.Invoke(new Action(() =>
            {
                rbSuccess.AppendText(string.Format("Start get from Database with CompanyId = {0}", 6619858476258121218) + System.Environment.NewLine);
            }));
            try
            {
                productTableAdapter.FillBy_CompanyRootProductNotImageId(dBWss.Product);
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    rbFail.AppendText("Get data product from SQL error:" + System.Environment.NewLine +
                                        ex.ToString() + System.Environment.NewLine);
                }));

            }
            if (dBWss.Product.Rows.Count > 0)
            {
                this.Invoke(new Action(() =>
                {
                    lbCount.Text = dBWss.Product.Rows.Count.ToString();
                    rbSuccess.AppendText(string.Format("Get {1} product need download from Database with CompanyId = {0}", 6619858476258121218, dBWss.Product.Rows.Count) + System.Environment.NewLine);
                }));

                var rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
                var producerUpdateImageIdSql = new ProducerBasic(rabbitMqServer, ConfigImages.ImboExchangeImages, ConfigImages.ImboRoutingKeyUploadImageIdSql);
                int success = 0;
                int fail = 0;
                for (int i = 0; i < dBWss.Product.Rows.Count; i++)
                {
                    ImageProductInfo product = new ImageProductInfo();
                    product.Id = Common.Obj2Int64(dBWss.Product.Rows[i]["ID"]);
                    product.ImageUrls = dBWss.Product.Rows[i]["ImageUrls"].ToString();
                    string message = string.Empty;
                    if (CommonDownloadImage.DownloadImageRootProduct(product, producerUpdateImageIdSql, ref message))
                    {
                        success++;
                        this.Invoke(new Action(() =>
                        {
                            lbSuccess.Text = success.ToString();
                            rbSuccess.AppendText(string.Format("CompanyId = {0}: {1}/{2} success", 6619858476258121218, i, dBWss.Product.Count) + System.Environment.NewLine);
                        }));
                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            rbSuccess.AppendText(string.Format("CompanyId = {0}: {1}/{2} fails", 6619858476258121218, i, dBWss.Product.Count) + System.Environment.NewLine);
                        }));

                        fail++;
                        this.Invoke(new Action(() =>
                        {
                            if (rbFail.TextLength > 1000000)
                            {
                                rbFail.Clear();
                            }
                            lbFails.Text = fail.ToString();
                            rbFail.AppendText(string.Format("CompanyId = {0}: {1}/{2} fails: {3}", 6619858476258121218, i, dBWss.Product.Count, message) + System.Environment.NewLine);
                            rbListIdFails.AppendText(product.Id + System.Environment.NewLine);
                        }));

                    }
                }
                this.Invoke(new Action(() =>
                {
                    rbSuccess.AppendText(string.Format("CompanyId = {0} downloaded {1}/{2} image", 6619858476258121218, success, dBWss.Product.Count) + System.Environment.NewLine);
                }));

                rabbitMqServer.Stop();
            }
            else
                this.Invoke(new Action(() =>
                {
                    rbSuccess.AppendText(string.Format("CompanyId {0} 0 product download image", 6619858476258121218) + System.Environment.NewLine);
                }));

        }
    }
}
