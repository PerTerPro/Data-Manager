using log4net;
using QT.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Service.Report.ProductOnClick.Error.Class;
using WSS.Service.Report.ProductOnClick.Error.Object;

namespace WSS.Service.Report.ProductOnClick.Error.Worker
{
    public class WorkerReportErrorProductOnClick : QueueingConsumer
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(WorkerCheckError));
        public WorkerReportErrorProductOnClick()
            : base(RabbitMQManager.GetRabbitMQServer("rabbitMQ177"), "Product.OnClick", false)
        {

        }
        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            Regex regex = new Regex(@"http.+html");
            MsProduct msProduct = MsProduct.FromJson(Encoding.UTF8.GetString(message.Body));

            if (msProduct != null)
            {
                long ProductId = msProduct.ProductId;
                string url = msProduct.DetailUrlMerchant;
                string Keyword = "";
                int Type = 2;
                if (ProductProcess.IsUrlEncoded(url))
                {
                    string urlencode = url;
                    string urldecode = HttpUtility.UrlDecode(HttpUtility.UrlDecode(urlencode));
                    MatchCollection matches = regex.Matches(urldecode);
                    url = matches[0].Value.ToString().Trim();
                    Regex regexReplace = new Regex(@"http.+url=");
                    url = regexReplace.Replace(url, "");
                }
                try
                {
                    HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                    webRequest.AllowAutoRedirect = false;
                    webRequest.Credentials = CredentialCache.DefaultCredentials;
                    webRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36";
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                           | SecurityProtocolType.Tls11
                                                           | SecurityProtocolType.Tls12
                                                           | SecurityProtocolType.Ssl3;
                    ServicePointManager
                        .ServerCertificateValidationCallback +=
                        (sender, cert, chain, sslPolicyErrors) => true;

                    HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                    if (response.StatusCode.ToString() != "OK" && response.StatusCode.ToString() != "MovedPermanently")
                    {
                        var company = CompanyProcess.GetCompanyId(ProductId);
                        if (ProductProcess.IsAdsScore(ProductId))
                        {
                            Keyword = ProductProcess.GetKeywordAds(ProductId);
                            Type = 1;
                        }

                        ProductProcess.UpdateError(new ProductError
                        {
                            ProductId = ProductId,
                            CompanyId = company.Id,
                            DetailUrl = url,
                            DateLog = DateTime.Now,
                            Keyword = Keyword,
                            Type = Type

                        });

                        Log.InfoFormat("Saved Product: {0}", ProductId);
                    }
                    response.Close();
                    Thread.Sleep(3000);
                }
                catch (WebException ex)
                {
                    MsProduct reqError = new MsProduct();
                    reqError.ProductId = ProductId;
                    reqError.DetailUrlMerchant = url;
                    reqError.Error = ex.ToString();
                    PushlishErrorWhenRequest(reqError);
                    Log.ErrorFormat("Error: {0}", ex.Status);
                    Thread.Sleep(60000);
                }
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
        private void PushlishErrorWhenRequest(MsProduct msProductError)
        {
            ProducerBasic producer = new ProducerBasic(RabbitMQManager.GetRabbitMQServer("rabbitMQ177"), "Product.ErrorRequest");
            producer.PublishString(msProductError.GetJson());
        }
        public override void Init()
        {
            
        }
    }
}
