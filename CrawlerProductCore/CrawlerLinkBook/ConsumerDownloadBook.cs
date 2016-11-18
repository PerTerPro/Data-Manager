using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using GABIZ.Base.Statistics.Kernels;
using log4net;using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.CrawlerProduct.Cache;
using QT.Entities.Data;
using QT.Entities.Solr;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlerProduct.Cache;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;
using QT.Moduls;
using QT.Moduls.CrawlerProduct.NoSql;
using QT.Moduls.CrawlerProduct.RabbitMQ;
using RabbitMQ.Client;
using RabbitMQ.Client.Framing;
using CrawlerLinkBook;
using GABIZ.Base.HtmlAgilityPack;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace WSS.Core.Crawler.CrawlerLinkBook
{
    public class ConsumerDownloadBook : QueueingConsumer
    {
        HashVisited hashCrcVisited = new HashVisited();
        SqlDb sqldb = new SqlDb(ConfigDownloadBook.ConnectionSql);
        private Uri uriRoot = new Uri(@"http://it-ebooks.info/");private ILog _log = LogManager.GetLogger(typeof (ConsumerHistoryProductToSolr));
        private int iCount = 0;
        private ProducerBasic _producerBasicDownloadHtml = new ProducerBasic(
            RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigDownloadBook.QueueDownloadBook);

        public ConsumerDownloadBook() : base(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler), ConfigDownloadBook.QueueDownloadBook, false)
        {
            InitData();
        }

        private void InitData()
        {
        }
        public ConsumerDownloadBook(string queueName)
            : base(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler), queueName, false)
        {
            InitData();
        }

        public override void Init()
        {

        }

        public bool CheckVisitCrc(long crc)
        {
            return hashCrcVisited.CheckVisited(crc);
        }


        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            Thread.Sleep(500);
            string linkProcess = UTF8Encoding.UTF8.GetString(message.Body);
            HtmlDocument document = new HtmlDocument();
            string html =  GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(linkProcess, 45, 2);
            if (!string.IsNullOrEmpty(html))
            {
                document.LoadHtml(html);


                if (Regex.IsMatch(linkProcess, ConfigDownloadBook.RegexProduct, RegexOptions.None))
                {
                    string urlDownload = "";
                    string nameBook = "";
                    int countPage = 0;

                    var nodeFindLink = document.DocumentNode.SelectNodes(@"//td//a/@href");
                    foreach (var varData in nodeFindLink)
                    {
                        string href = varData.GetAttributeValue("href", ""); if (Regex.IsMatch(href, "filepi.com/i/.*"))
                        {
                            urlDownload = href;
                            nameBook = varData.InnerText;
                        }
                    }
                    bool bOK = this.sqldb.RunQuery("insert into LinkItbook (Link, Name, CountPage, LinkDownload) values (@Link, @Name, @CountPage, @LinkDownload)"
                        , CommandType.Text, new SqlParameter[]
                                       {
                                          SqlDb.CreateParamteterSQL("Link", linkProcess, SqlDbType.NVarChar) ,
                                           SqlDb.CreateParamteterSQL("Name", nameBook, SqlDbType.NVarChar) ,
                                            SqlDb.CreateParamteterSQL("CountPage", countPage, SqlDbType.Int) ,
                                                 SqlDb.CreateParamteterSQL("LinkDownload", urlDownload, SqlDbType.NVarChar) 
                                       });
                }
                
                
                var nodeLinks = document.DocumentNode.SelectNodes("//a");
                if (nodeLinks != null)
                {
                    foreach (HtmlNode VARIABLE in nodeLinks)
                    {
                        string link = VARIABLE.GetAttributeValue("href","");string fullLink = Common.GetFullUrlFromLink(link, uriRoot);

                        if (!CheckVisitCrc(Common.CrcProductID(fullLink)) &&
                            !Regex.IsMatch(fullLink, ConfigDownloadBook.RegexNoVisit, RegexOptions.None) &&
                            Regex.IsMatch(fullLink, ConfigDownloadBook.RegexVisit, RegexOptions.None))
                        {
                            _producerBasicDownloadHtml.PublishString(fullLink);
                            hashCrcVisited.SetCrcVisited(Common.CrcProductID(fullLink));

                            if (Regex.IsMatch(fullLink, ConfigDownloadBook.RegexProduct, RegexOptions.None))
                            {
                                string urlDownload = "";
                                string nameBook = "";
                                int countPage = 0;

                                var nodeFindLink = document.DocumentNode.SelectNodes(@"//td//a/@href");
                                foreach (var varData in nodeFindLink)
                                {
                                    string href = varData.GetAttributeValue("href", "");if (Regex.IsMatch(href, "filepi.com/i/.*"))
                                    {
                                        urlDownload=href;
                                        nameBook = varData.InnerText;
                                    }
                                }



                                bool bOK = this.sqldb.RunQuery("insert into LinkItbook (Link, Name, CountPage, LinkDownload) values (@Link, @Name, @CountPage, @LinkDownload)"
                                    , CommandType.Text, new SqlParameter[]
                                       {
                                          SqlDb.CreateParamteterSQL("Link", fullLink, SqlDbType.NVarChar) ,
                                           SqlDb.CreateParamteterSQL("Name", nameBook, SqlDbType.NVarChar) ,
                                            SqlDb.CreateParamteterSQL("CountPage", countPage, SqlDbType.Int) ,
                                                 SqlDb.CreateParamteterSQL("LinkDownload", urlDownload, SqlDbType.NVarChar) 
                                       });
                            }
                        }
                    }
                }
            }

            _log.InfoFormat("Processed link {0}", linkProcess);this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
