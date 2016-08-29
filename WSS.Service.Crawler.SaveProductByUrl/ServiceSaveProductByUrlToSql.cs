using log4net;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;


namespace WSS.Service.Crawler.SaveProductByUrl
{
    public partial class ServiceSaveProductByUrlToSql : ServiceBase
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(ServiceSaveProductByUrlToSql));
        CancellationTokenSource cancelTokenSource = null;
        RabbitMQServer rabbitMQServer = null;
        string AddProductToSqlJobName = "";
        private string _htmlSource = "";
        Worker[] workers = null;
        int workerCount = 4;
        private QT.Entities.Company _company;
        public ServiceSaveProductByUrlToSql()
        {
            InitializeComponent();
            workerCount = QT.Entities.Common.Obj2Int(ConfigurationManager.AppSettings["workerCount"], 1);
            AddProductToSqlJobName = ConfigurationManager.AppSettings["JobName"];
        }

        protected override void OnStart(string[] args)
        {
            log.Info("Start service");
            try
            {
                InitializeComponent();
                cancelTokenSource = new CancellationTokenSource();
                string rabbitMQServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];
                workers = new Worker[workerCount];
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);

                string connectToSQL = @"Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
                string connectToConnection = @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
                CrawlerProductAdapter crawlerProductAdapter = new CrawlerProductAdapter(new SqlDb(connectToSQL));
                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(connectToConnection));


                for (int i = 0; i < workerCount; i++)
                {
                    log.InfoFormat("Start worker {i}", i.ToString());
                    var worker = new Worker(AddProductToSqlJobName, false, rabbitMQServer);
                    workers[i] = worker;
                    var token = this.cancelTokenSource.Token;
                    Task workerTask = new Task(() =>
                    {
                        worker.JobHandler = (downloadImageJob) =>
                        {
                            try
                            {
                                token.ThrowIfCancellationRequested();

                                QT.Entities.CrawlerProduct.RabbitMQ.MsSaveProduct Mss = QT.Entities.CrawlerProduct.RabbitMQ.MsSaveProduct.GetDataFromMessage(downloadImageJob.Data);
                                string Url = Mss.Url;
                                string Domain = QT.Entities.Common.GetDomainFromUrl(Url);
                                long CompanyID = QT.Entities.Common.GetIDCompany(Domain);
                                QT.Entities.Configuration config = new QT.Entities.Configuration(CompanyID);
                                if (_company.Status == Common.CompanyStatus.WEB_CRAWLERDOMAIN)
                                {
                                    List<QT.Entities.Company> ls = new List<QT.Entities.Company>();
                                    QT.Entities.CrawlerDomain obj = new CrawlerDomain();
                                    string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(Url.Trim(), 15, 1);
                                    GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                                    html = html.Replace("<form", "<div");
                                    html = html.Replace("</form", "</div");
                                    doc.LoadHtml(html);
                                }
                                else
                                {
                                    int numberItemSaved = 0;
                                    string[] arLink = Url.Trim().Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries);
                                    foreach (var item in arLink)
                                    {
                                        QT.Entities.Product _product = new Product();
                                        string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(item, 45, 2);
                                        if (config.ContentAnanyticXPath.Count >= 1)
                                        {
                                            int i1 = 0, i2 = 0;
                                            i1 = html.IndexOf(config.ContentAnanyticXPath[0]);
                                            if (i1 >= 0)
                                            {
                                                html = html.Substring(i1);
                                                if (config.ContentAnanyticXPath.Count >= 2)
                                                {
                                                    i2 = html.IndexOf(config.ContentAnanyticXPath[1]);
                                                    if (i2 >= 0)
                                                    {
                                                        html = html.Substring(0, i2 + config.ContentAnanyticXPath[1].Length);
                                                    }
                                                }
                                            }
                                            html = html.Replace("<form", "<div");
                                            html = html.Replace("</form", "</div");
                                            html = Common.TidyCleanR(html);
                                        }

                                        _htmlSource = html;
                                        GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                                        html = html.Replace("<form", "<div");
                                        html = html.Replace("</form", "</div");
                                        doc.LoadHtml(html);

                                        List<Product> lstUpdateProduct = new List<Product>();
                                        List<Product> lstInsertProduct = new List<Product>();

                                        _product.Analytics(doc, item, config, true, _company.Domain);

                                        if (_product != null && _product.IsSuccessData(config.CheckPrice))
                                        {
                                            numberItemSaved++;
                                            if (productAdapter.CheckExistInDb(_product.ID))
                                            {
                                                lstUpdateProduct.Add(_product);
                                            }
                                            else
                                            {
                                                lstInsertProduct.Add(_product);
                                            }

                                            productAdapter.UpdateProductsChangeToDb(lstUpdateProduct);
                                            productAdapter.InsertListProduct(lstInsertProduct);

                                            productAdapter.PushQueueIndexCompany(config.CompanyID);
                                            productAdapter.PushQueueChangeChangeImage(new MQChangeImage()
                                            {
                                                ProductID = _product.ID,
                                                Type = 1
                                            });

                                            log.InfoFormat("Saved {0} item product!", _product.Name);
                                        }
                                    }
                                }

                                return true;
                            }
                            catch (OperationCanceledException opc)
                            {
                                log.Info("End worker");
                                return false;
                            }
                        };
                        worker.Start();
                    }, token);
                    workerTask.Start();
                    log.InfoFormat("Worker {0} started", i);
                }
            }
            catch (Exception ex)
            {
                log.Error("Start error", ex);
                throw;
            }
        }

        protected override void OnStop()
        {
            if (this.cancelTokenSource != null
                && !this.cancelTokenSource.IsCancellationRequested)
            {
                log.Info("Cancellation all thread");
                this.cancelTokenSource.Cancel();
            }
        }
    }
}
