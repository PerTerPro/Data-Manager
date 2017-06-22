﻿//using log4net;
//using QT.Moduls;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web;
//using Websosanh.Core.Drivers.RabbitMQ;
//using Wss.Lib.RabbitMq;
//using WSS.Service.Report.ProductOnClick.Error.Class;
//using WSS.Service.Report.ProductOnClick.Error.Model;
//using WSS.Service.Report.ProductOnClick.Error.Object;

//namespace WSS.Service.Report.ProductOnClick.Error.Worker
//{
//    public class WorkerReportErrorProductOnClick : QueueingConsumer
//    {
//        private static readonly ILog Log = LogManager.GetLogger(typeof(WorkerCheckError));
//        public WorkerReportErrorProductOnClick()
//            : base(RabbitMQManager.GetRabbitMQServer("rabbitMQ177"), "Product.OnClick", false)
//        {

//        }
//        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
//        {
//            Regex regex = new Regex(@"http.+html");
//            MsProduct msProduct = MsProduct.FromJson(Encoding.UTF8.GetString(message.Body));

//            if (msProduct != null)
//            {
//                long productId = msProduct.ProductId;
//                string url = msProduct.DetailUrlMerchant;
//                string Keyword = "";
//                int Type = 2;
//                if (ProductProcess.IsUrlEncoded(url))
//                {
//                    url = HttpUtility.UrlDecode(HttpUtility.UrlDecode(url));
//                    MatchCollection matches = regex.Matches(url);
//                    if (matches != null && matches.Count > 0)
//                    {
//                        url = matches[0].Value.ToString().Trim();
//                        Regex regexReplace = new Regex(@"http.+url=");
//                        url = regexReplace.Replace(url, "");
//                    }
//                }

//                try
//                {
//                    HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
//                    webRequest.AllowAutoRedirect = false;
//                    webRequest.Credentials = CredentialCache.DefaultCredentials;
//                    webRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36";
//                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
//                                                           | SecurityProtocolType.Tls11
//                                                           | SecurityProtocolType.Tls12
//                                                           | SecurityProtocolType.Ssl3;
//                    ServicePointManager
//                        .ServerCertificateValidationCallback +=
//                        (sender, cert, chain, sslPolicyErrors) => true;

//                    HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
//                    if (response.StatusCode.ToString() != "OK" && response.StatusCode.ToString() != "MovedPermanently")
//                    {
//                        var company = CompanyProcess.GetCompanyId(productId);
//                        if (ProductProcess.IsAdsScore(productId))
//                        {
//                            Keyword = ProductProcess.GetKeywordAds(productId);
//                            Type = 1;
//                        }
//                        ProductProcess.UpdateError(new ProductError
//                        {
//                            ProductId = productId,
//                            CompanyId = company.Id,
//                            DetailUrl = url,
//                            DateLog = DateTime.Now,
//                            Keyword = Keyword,
//                            Type = Type

//                        });

//                        Log.InfoFormat("Saved Product: {0}", productId);
//                    }
//                    response.Close();
//                }
//                catch (WebException ex)
//                {
//                    MsProduct reqError = new MsProduct();
//                    reqError.ProductId = productId;
//                    reqError.DetailUrlMerchant = url;
//                    reqError.Error = ex.ToString();
//                    PushlishErrorWhenRequest(reqError);
//                    Log.Error(string.Format("Product: {0} ... Error: {1}", Newtonsoft.Json.JsonConvert.SerializeObject(reqError), ex));
//                    Thread.Sleep(6000);
//                }
//            }
//            this.GetChannel().BasicAck(message.DeliveryTag, true);
//        }
//        private void PushlishErrorWhenRequest(MsProduct msProductError)
//        {
//            ProducerBasic producer = new ProducerBasic(RabbitMQManager.GetRabbitMQServer("rabbitMQ177"), "Product.ErrorRequest");
//            producer.PublishString(msProductError.GetJson());
//        }
//        public override void Init()
//        {
            
//        }
//    }
//}
