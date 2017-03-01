using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Service.ReportProductAdsScoreError.Object;
using Dapper;
using System.Data;
using System.Configuration;
using System.Web;
using System.Text.RegularExpressions;
using System.Net;
using System.Threading;
using log4net;
using WSS.LibExtra;

namespace WSS.Service.ReportProductAdsScoreError
{
    public class WorkerCheckError : QueueingConsumer
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(WorkerCheckError));
        public WorkerCheckError()
            : base(RabbitMQManager.GetRabbitMQServer("rabbitMqCrlProperties"), "Product.Ads.Score.OnClick", false)
        {

        }
        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            Regex regex = new Regex(@"http.+html");
            ProductAdsScore productAds = ProductAdsScore.FromJson(Encoding.UTF8.GetString(message.Body));
            if (productAds != null)
            {
                long ProductId = productAds.ProductId;
                long CompanyId = productAds.CompanyId;
                string Keyword = productAds.Keyword;
                //ProductId = 43971110850365896;

                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    var product = db.Query<Product>("Select * from Product where Id = @Id", new { Id = ProductId }).FirstOrDefault();
                    string Domain = db.Query<Company>("Select Domain from Company where Id = @Id", new { Id = CompanyId }).FirstOrDefault().Domain.ToString();
                    if (product != null)
                    {
                        string url = product.DetailUrl;
                        if (IsUrlEncoded(url))
                        {
                            string urlencode = product.DetailUrl;
                            string urldecode = HttpUtility.UrlDecode(HttpUtility.UrlDecode(urlencode));
                            MatchCollection matches = regex.Matches(urldecode);
                            url = matches[0].Value.ToString().Trim();
                            Regex regexReplace = new Regex(@"http.+url=");
                            url = regexReplace.Replace(url, "");
                        }
                        //if (product.Company == 3502170206813664485)
                        //{

                        //}

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
                        try
                        {
                            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                            if (response.StatusCode.ToString() != "OK" && response.StatusCode.ToString() != "MovedPermanently")
                            {
                                db.Execute("Insert into Product_AdsScore_Error (ProductId,CompanyId,Keyword,Domain,DetailUrl) values (@ProductId,@CompanyId,@Keyword,@Domain,@DetailUrl)",
                                    new ProductAdsScore
                                    {
                                        ProductId = ProductId,
                                        CompanyId = CompanyId,
                                        Keyword = Keyword,
                                        Domain = Domain,
                                        DetailUrl = product.DetailUrl
                                    });
                                Log.InfoFormat("Saved Product: {0}", ProductId);
                            }
                            response.Close();
                            Thread.Sleep(5000);
                        }
                        catch (WebException ex)
                        {
                            ProductAdsScore reqError = new ProductAdsScore();
                            reqError.ProductId = ProductId;
                            reqError.CompanyId = CompanyId;
                            reqError.Keyword = Keyword;
                            reqError.Domain = Domain;
                            reqError.DetailUrl = product.DetailUrl;

                            db.Execute("Insert into Product_AdsScore_Error (ProductId,CompanyId,Keyword,Domain,DetailUrl) values (@ProductId,@CompanyId,@Keyword,@Domain,@DetailUrl)", reqError);
                            Log.InfoFormat("Saved Product: {0}", ProductId);
                            PushlishErrorWhenRequest(reqError);
                            Log.ErrorFormat("Error: {0}", ex.Status);
                            Thread.Sleep(3600000);
                        }
                    }
                    else
                    {
                        db.Execute("Insert into Product_AdsScore_Error (ProductId,CompanyId,Keyword,Domain) values (@ProductId,@CompanyId,@Keyword,@Domain)",
                                     new ProductAdsScore
                                     {
                                         ProductId = ProductId,
                                         CompanyId = CompanyId,
                                         Keyword = Keyword,
                                         Domain = Domain
                                     });
                        Log.InfoFormat("Saved Product: {0}", ProductId);
                    }
                }
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }

        private void PushlishErrorWhenRequest(ProductAdsScore reqError)
        {
            ProducerBasic producer = new ProducerBasic(RabbitMQManager.GetRabbitMQServer("rabbitMqCrlProperties"), "Product.Ads.Score.ErrorRequest");
            producer.PublishString(reqError.GetJson());
        }
        private bool IsUrlEncoded(string text)
        {
            return (HttpUtility.UrlDecode(text) != text);
        }
        public override void Init()
        {

        }
    }
}
