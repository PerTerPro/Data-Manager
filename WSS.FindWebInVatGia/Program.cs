using GABIZ.Base.HtmlAgilityPack;
using log4net;
using Newtonsoft.Json;
using OpenQA.Selenium.Firefox;
using ProtoBuf;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using WSS.FindWebInVatGia.FindNewWebSiteInChonGiaDung;

namespace WSS.FindWebInVatGia
{
    class Program
    {
        FirefoxDriver firefoxdriver = new FirefoxDriver();
        SqlDb sqlVisited = new SqlDb("Data Source=WIN-6ICNIQVFE0A;Initial Catalog=VatGiaProduct;Integrated Security=True");
        SqlDb sqlSaveData = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            FindWebSiteInChonGiaDung();
            Console.ReadLine();
            return;
            
            Program program = new Program();
            program.SearchProductAll();
            Console.ReadLine();
        }

        private static void FindWebSiteInChonGiaDung()
        {
            TaskFindNewWebSite taskFind = new TaskFindNewWebSite();
            //taskFind.FindCatUrl();
            //taskFind.FindWebSiteUrl();

            taskFind.FindKeywordUrl("");
            //taskFind.FindWebSiteUrlByKeyword();
            //taskFind.CheckDumpInWSSWebsite();
        }

        private void SearchProductAll()
        {
            DataTable tblCat = sqlSaveData.GetTblData("Select * from VatGiaClassification where IsProcessed = 0 or IsProcessed is null");
            foreach (DataRow dr in tblCat.Rows)
            {
                long IDCat = QT.Entities.Common.Obj2Int64(dr["IDCat"].ToString());
                SearchProduct(IDCat);
                sqlSaveData.RunQuery("update VatGiaClassification set IsProcessed  = 1 where IDCat = @IDCat", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                               SqlDb.CreateParamteterSQL("@IDCat",IDCat,SqlDbType.NVarChar)});
            }
        }

        public void GetCatID()
        {
            DataTable tbl = sqlSaveData.GetTblData("select * from VatGiaClassification");
            foreach (DataRow rowInfo in tbl.Rows)
            {
                try
                {
                    long ID = Convert.ToInt64(rowInfo["ID"]);
                    string Url = Convert.ToString(rowInfo["Url"]);
                    long Cat = Convert.ToInt64(Regex.Match(Url, @"\d+", RegexOptions.IgnoreCase).Captures[0].Value.ToString());
                    sqlSaveData.RunQuery("update VatGiaClassification set IDCat = @IDCat Where ID = @ID", CommandType.Text,
                        new System.Data.SqlClient.SqlParameter[]{
                            SqlDb.CreateParamteterSQL("ID",ID,SqlDbType.BigInt),
                            SqlDb.CreateParamteterSQL("IDCat",Cat,SqlDbType.BigInt)
                        });
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                }
            }
        }

        private void SearchProduct(long IDCat)
        {
            List<ProductVatGia> lstProduct = new List<ProductVatGia>();
            string url = @"http://vatgia.com/home/listudv.php?iCat=" + IDCat.ToString() + @"&page={0}";
            string regexProduct = @"^.*vatgia.com\/\d*\/\d*\/[^\/]*.*html";
            int iCount = 0;
            int iPage = 0;
            do
            {
                string urlCurrent = string.Format(url, iPage++);
                Console.WriteLine(urlCurrent);

                Thread.Sleep(15000);
                firefoxdriver.Url = urlCurrent;


                var nodesLink = firefoxdriver.FindElementsByClassName("teaser");
                List<string> lstDetailUrl = new List<string>();
                foreach (var itemNode in nodesLink)
                {
                    lstDetailUrl.Add(itemNode.GetAttribute("href").ToString());
                }

                if (nodesLink != null)
                {
                    foreach (var itemNode in lstDetailUrl)
                    {
                        string urlDetail = itemNode;
                        urlDetail = QT.Entities.Common.GetAbsoluteUrl(urlDetail, "http://vatgia.com");
                        if (Regex.IsMatch(urlDetail, regexProduct))
                        {
                            Thread.Sleep(15000);
                            firefoxdriver.Url = urlDetail;
                            //string xpathname = @"//*[@id='detail_product_name']";
                            //string xpathNumberCom = @"//div[@class='price_quality']";
                            var nodeName = firefoxdriver.FindElementById("detail_product_name");
                            string name = (nodeName == null) ? "" : nodeName.Text.Trim();
                            int NumberCom = 0;
                            try
                            {
                                var nodeNumberComp = firefoxdriver.FindElementByClassName("price_quality");
                                NumberCom = (nodeNumberComp == null) ? 0 : CountCompany(nodeNumberComp.Text.Trim());
                            }
                            catch (Exception ex01)
                            {
                            }

                            if (name != "")
                            {
                                lstProduct.Add(new ProductVatGia()
                                    {
                                        id = Math.Abs(GABIZ.Base.Tools.getCRC64(urlDetail)),
                                        name = name,
                                        url = urlDetail,
                                        NumberMerchant = NumberCom
                                    });
                            }
                        }
                    }
                }

                iCount = lstProduct.Count;
                if (lstProduct.Count > 100)
                {
                    SaveProduct(lstProduct);

                    Console.WriteLine("Saved 100 product!");
                }
            }
            while (iCount > 0);
        }

        private void SaveProduct(List<ProductVatGia> lstProduct)
        {
            foreach (var productItem in lstProduct)
            {
                this.sqlSaveData.RunQuery
                    ("if not exists (select top 1 * from VatGiaProduct where id = @id) insert into VatGiaProduct (id, name, url, numbermerchant) values (@id, @name, @url, @numbermerchant)"
                    , CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                        SqlDb.CreateParamteterSQL("id",productItem.id,SqlDbType.BigInt),
                        SqlDb.CreateParamteterSQL("name",productItem.name,SqlDbType.NVarChar),
                        SqlDb.CreateParamteterSQL("url",productItem.url,SqlDbType.NVarChar),
                        SqlDb.CreateParamteterSQL("numbermerchant",productItem.NumberMerchant,SqlDbType.Int)
                    });
            }
            lstProduct.Clear();
        }

        private int CountCompany(string data)
        {
            string regex1 = @"\d+ sản phẩm mới từ.*";
            if (Regex.IsMatch(data, regex1))
            {
                return QT.Entities.Common.Obj2Int(data.Split(' ')[0]);
            }
            return 0;
        }

        private void PushListCat()
        {
            DataTable tbl = this.sqlSaveData.GetTblData("select * from VatGiaClassification");
            foreach (DataRow rowInfo in tbl.Rows)
            {
                string strUrl = Convert.ToString(rowInfo["Url"]);
                PushJobToQueue(new JobCrawler()
                    {
                        level = 0,
                        urlDetail = strUrl
                    });
            }
            return;
        }

        private void FindProduct()
        {


            var rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            var worker = new Worker("VatGia_Queue", false, rabbitMQServer);
            Task workerTask = new Task(() =>
            {
                log.Info("Start consumer!");
                worker.JobHandler = (downloadImageJob) =>
                {
                    log.Info("Get job from MQ");
                    try
                    {
                        JobCrawler jobData = JobCrawler.Deserialize(downloadImageJob.Data);
                        if (jobData == null) return true;
                        return true;
                    }
                    catch (Exception ex01)
                    {
                        log.Error("Exception:", ex01);
                        return true;
                    }
                };
                worker.Start();
            });
            workerTask.Start();
        }

        public void PushJobToQueue(WSS.FindWebInVatGia.JobCrawler jobCrawlwer)
        {
            while (true)
            {
                try
                {
                    var rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
                    JobClient jobClient = new JobClient("", GroupType.Topic, "VatGia_Queue", true, rabbitMQServer);
                    jobClient.PublishJob(new Job() { Data = jobCrawlwer.Serialize(), Type = 1 }, 0);
                    return;
                }
                catch (Exception ex01)
                {
                    log.Info(ex01);
                }
            }
        }


        public void FindClassification()
        {
            List<long> addedToDb = new List<long>();
            Dictionary<long, string> addedLink = this.LoadVisitedLink();
            ILog log = log4net.LogManager.GetLogger(typeof(Program));

            var rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            var worker = new Worker("VatGia_Queue", false, rabbitMQServer);
            Task workerTask = new Task(() =>
            {
                log.Info("Start consumer!");
                worker.JobHandler = (downloadImageJob) =>
                {
                    log.Info("Get job from MQ");
                    try
                    {
                        JobCrawler jobData = JobCrawler.Deserialize(downloadImageJob.Data);
                        if (jobData == null) return true;

                        Console.WriteLine("Get Job:" + jobData.urlDetail);
                        long IDUrl = Math.Abs(GABIZ.Base.Tools.getCRC64(jobData.urlDetail));
                        if (!addedLink.ContainsKey(IDUrl))
                        {
                            addedLink.Add(IDUrl, "");
                            string regexExtract = @"^.*vatgia.com\/\d+\/[^\/]*html$";
                            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(jobData.urlDetail, 120, 2);

                            GABIZ.Base.HtmlAgilityPack.HtmlDocument htmlDocument = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                            htmlDocument.LoadHtml(html);
                            var nodesLink = htmlDocument.DocumentNode.SelectNodes("//a");
                            if (nodesLink != null)
                                foreach (var nodeLink in nodesLink)
                                {
                                    string url = QT.Entities.Common.GetAbsoluteUrl(nodeLink.Attributes["href"].Value.ToString(), "http://vatgia.com");
                                    long IDUrlNew = Math.Abs(GABIZ.Base.Tools.getCRC64(url));
                                    if (!addedLink.ContainsKey(IDUrlNew))
                                    {
                                        if (Regex.IsMatch(url, regexExtract))
                                        {
                                            PushJobToQueue(new JobCrawler()
                                                {
                                                    level = jobData.level + 1,
                                                    urlDetail = url
                                                });

                                            sqlSaveData.RunQuery("if not exists (select id from VatGiaClassification where id = @id) insert into VatGiaClassification (id, url) values (@id, @url)", CommandType.Text,
                                               new System.Data.SqlClient.SqlParameter[]{
                                                SqlDb.CreateParamteterSQL("@id",Math.Abs(GABIZ.Base.Tools.getCRC64(url)), SqlDbType.BigInt),
                                                SqlDb.CreateParamteterSQL("@url",url,SqlDbType.NVarChar)
                                            });

                                            addedLink.Add(IDUrlNew, "");
                                            addedToDb.Add(IDUrlNew);

                                            Console.WriteLine(url);
                                        }

                                        if (addedToDb.Count > 100)
                                        {
                                            foreach (var item in addedToDb)
                                            {
                                                this.sqlVisited.RunQuery("if not exists (select id from visitedlink where id = @id) insert into VisitedLink (id) values (@id)"
                                                    , CommandType.Text
                                                    , new System.Data.SqlClient.SqlParameter[]{
                                                      SqlDb.CreateParamteterSQL("@id",item,SqlDbType.BigInt)});
                                            }
                                            addedToDb.Clear();
                                        }
                                    }
                                }
                        }
                        return true;
                    }
                    catch (Exception ex01)
                    {
                        log.Error("Exception:", ex01);
                        return true;
                    }
                };
                worker.Start();
            });
            workerTask.Start();
            Console.ReadLine();
        }

        private Dictionary<long, string> LoadVisitedLink()
        {
            Dictionary<long, string> dicVisited = new Dictionary<long, string>();
            DataTable tblData = null;
            do
            {
                tblData = this.sqlVisited.GetTblData("select id from VisitedLink", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { });
                foreach (DataRow rowInfo in tblData.Rows)
                {
                    if (!dicVisited.ContainsKey(Convert.ToInt64(rowInfo["ID"])))
                        dicVisited.Add(Convert.ToInt64(rowInfo["ID"]), "");
                }

                return dicVisited;
            }
            while (tblData.Rows.Count > 0);
            return dicVisited;
        }
    }
}
