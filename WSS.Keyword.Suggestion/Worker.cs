using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Keyword.Suggestion
{
    class Worker
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Worker));
        public void Run()
        {
            Console.WriteLine("You want get all mss not process?");
            bool SkipAll = Console.ReadLine().ToUpper() == "Y";
            string xpathExcel = Convert.ToString(ConfigurationManager.AppSettings["PathExcelDowload"]);
            bool AllowAdd = true;
            SqlDb sqlDb = new SqlDb(@"Data Source=183.91.14.82;Initial Catalog=News;Persist Security Info=True;User ID=wss_news;Password=@F4sJ=l9/ryJt9MT");
            DataTable tblKeywordID = sqlDb.GetTblData("select id from Keyword_Volume");
            string user = "nguyendinhtung1201@gmail.com";
            string pass = "Tung01268691102";
            string startUrl = @"https://keywordtool.io/user?destination=node";
            FirefoxDriver driver = new FirefoxDriver();
            driver.Url = startUrl;
            driver.FindElement(By.Id("edit-name")).SendKeys(user);
            driver.FindElement(By.Id("edit-pass")).SendKeys(pass);
            driver.FindElement(By.Id("edit-submit")).Submit();
            RabbitMQServer rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQKeywordSuggest");
            var worker = new Websosanh.Core.JobServer.Worker("UpdateKeywordSuggest", false, rabbitMQServer);
            int countNumberKeyword = 0;
            Task workerTask = new Task(() =>
            {
                worker.JobHandler = (updateDatafeedJob) =>
                {
                    try
                    {
                        if (SkipAll == true) return true;

                        QT.Entities.CrawlerProduct.RabbitMQ.MsJobKeywordSuggest jobKeywordSuggest = QT.Entities.CrawlerProduct.RabbitMQ.MsJobKeywordSuggest.FromArByte(updateDatafeedJob.Data);
                        string keyword = jobKeywordSuggest.Keyword;
                        log.InfoFormat("Get keyword:{0} {1}", countNumberKeyword++, keyword);
                        driver.FindElement(By.Id("edit-keyword")).Clear();
                        driver.FindElement(By.Id("edit-keyword")).SendKeys(keyword);
                        driver.FindElement(By.Id("edit-keyword")).SendKeys(Keys.Enter);
                        Thread.Sleep(10000);
                        GABIZ.Base.HtmlAgilityPack.HtmlDocument document = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                        document.LoadHtml(driver.PageSource);

                        int countFail = 0;
                        while (countFail < 5)
                        {
                            try
                            {
                                IWebElement itemExcel = driver.FindElement(By.XPath("//button[@class='btn btn-primary pull-right dropdown-toggle export']"));
                                if (itemExcel != null)
                                {
                                    itemExcel.Click();
                                    driver.FindElement(By.LinkText("Excel")).Click();
                                    break;
                                }
                                else
                                {
                                    log.Info("Sleep 2 s to continute");
                                    Thread.Sleep(2000);
                                    countFail++;
                                }
                            }
                            catch (Exception ex)
                            {
                                log.Info("Sleep 2 s to continute");
                                Thread.Sleep(2000);
                                countFail++;
                            }
                        }
                        #region AnalysicContaint
                        //var items = document.DocumentNode.SelectNodes(@"//table[@class='table search-results tablesorter tablesorter-default']//tr");
                        //if (items != null && items.Count > 0)
                        //{
                        //    foreach (var rowKeyword in items)
                        //    {
                        //        try
                        //        {
                        //            if (rowKeyword.Attributes.Contains("data-text") && !rowKeyword.Attributes.Contains("class"))
                        //            {

                        //                string keywordItem = rowKeyword.Attributes["data-text"].Value;
                        //                int crc = GABIZ.Base.Tools.getCRC32(keywordItem);
                        //                string strVolume = rowKeyword.SelectNodes("./td")[3].InnerText.Trim();
                        //                int countVoume = strVolume == "n/a" ? -1 : QT.Entities.Common.Obj2Int(strVolume);
                        //                if (countVoume > 0)
                        //                {
                        //                    sqlDb.RunQuery("delete keyword_volume where id =@id; insert Keyword_Volume (id, keyword, volume, lastupdatevolume, keywordsource) values (@id, @keyword, @volume, getdate(), @keywordsource)", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                        //            SqlDb.CreateParamteterSQL("@id",crc,SqlDbType.Int),
                        //            SqlDb.CreateParamteterSQL("@keyword",keywordItem,SqlDbType.NVarChar),
                        //            SqlDb.CreateParamteterSQL("@volume",countVoume,SqlDbType.Int),
                        //            SqlDb.CreateParamteterSQL("@keywordsource",keyword,SqlDbType.VarChar)
                        //            });
                        //                    log.InfoFormat("insert keyword:{0}:{1}", keywordItem, countVoume);
                        //                }

                        //            }
                        //        }
                        //        catch (Exception ex01)
                        //        {
                        //            log.Error(ex01.Message + ex01.StackTrace);
                        //        }
                        //    }
                        //} 
                        #endregion
                        return true;
                    }
                    catch (Exception ex02)
                    {
                        log.Error(ex02);
                        return false;
                    }
                };
                worker.Start();
            });
            workerTask.Start();
        }
    }
}