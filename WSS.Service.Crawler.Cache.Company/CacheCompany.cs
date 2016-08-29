using log4net;
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


namespace WSS.Service.Crawler.Cache.Company
{
    public partial class CacheCompanyService : ServiceBase
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(CacheCompanyService));
        string connectionString = "";
        CancellationTokenSource cancelTokenSource = null;
        RabbitMQServer rabbitMQServer = null;
        string jobName = "";
        Worker[] workers = null;
        int workerCount = 4;

        public CacheCompanyService()
        {
            InitializeComponent();
            rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            workerCount = QT.Entities.Common.Obj2Int(ConfigurationManager.AppSettings["workerCount"], 1);
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            jobName = ConfigurationManager.AppSettings["checkDuplicateRefreshJobName"];
        }

        protected override void OnStart(string[] args)
        {
//            log.Info("Start service");
//            try
//            {
//                InitializeComponent();
//                cancelTokenSource = new CancellationTokenSource();
//                Server.LogConnectionString = ConfigurationManager.AppSettings["LogConnectionString"];
//                QT.Entities.Server.ConnectionString = connectionString;
//                string rabbitMQServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];
//                workers = new Worker[workerCount];
//                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
//                for (int i = 0; i < workerCount; i++)
//                {
//                    log.InfoFormat("Start worker {i}", i.ToString());
//                    var worker = new Worker(jobName, false, rabbitMQServer);
//                    workers[i] = worker;
//                    var token = this.cancelTokenSource.Token;
//                    Task workerTask = new Task(() =>
//                    {
//                        SqlDb sqlDb = new SqlDb(this.connectionString);
//                        QT.Moduls.CrawlerProduct.Cache.RedisCacheCompanyCrawler blo = QT.Moduls.CrawlerProduct.Cache.RedisCacheCompanyCrawler.Instance();
//                        QT.Moduls.CrawlerProduct.Cache.RedisCacheCompanyCrawler cacheCompany = QT.Moduls.CrawlerProduct.Cache.RedisCacheCompanyCrawler.Instance();
//                        QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler cacheWait = QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler.Instance();
//                        worker.JobHandler = (updateDatafeedJob) =>
//                        {
//                            QT.Entities.CrawlerProduct.RabbitMQ.MsCacheCompany msCompany =QT.Entities.CrawlerProduct.RabbitMQ.MsCacheCompany.GetMs(updateDatafeedJob.Data);
//                            try
//                            {
//                                DataTable tbl = sqlDb.GetTblData(@"select a.id
//	, a.domain 
//	, isnull(b.MinHourReload,12) as MinHourReload
//	, isnull(b.MinHourFindNew,8) as MinHourFindNew
//from Company a inner join Configuration b on a.id = b.companyID
//where 1=1
//and a.DataFeedType=0
//and a.Status=1 and a.id = @CompanyID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
//                                         SqlDb.CreateParamteterSQL("CompanyID",)
//                                     });
//                                foreach (DataRow companyRow in tbl.Rows)
//                                {
                                  
//                                    long companyID = QT.Entities.Common.Obj2Int64(companyRow["ID"]);
//                                    string domain = QT.Entities.Common.Obj2String(companyRow["Domain"]);
//                                    int minHourReload = QT.Entities.Common.Obj2Int(companyRow["MinHourReload"]);
//                                    int minHourFindNew = QT.Entities.Common.Obj2Int(companyRow["MinHourFindNew"]);
//                                    cacheCompany.SetCompanyInfo(companyID, domain, minHourReload, minHourFindNew);
//                                    if (!cacheWait.CheckHaveItemReload(companyID)) cacheWait.SetWaitNextReload(companyID, minHourReload);
//                                    if (!cacheWait.CheckHaveItemFindNew(companyID)) cacheWait.SetWaitNextFindNew(companyID, minHourFindNew);
//                                }
//                                return true;
//                            }
//                            catch (OperationCanceledException opc)
//                            {
//                                log.Info("End worker");
//                                return true;
//                            }
//                            catch (Exception ex01)
//                            {
//                                log.Info(ex01);
//                                return false;
//                            }
//                        };
//                        worker.Start();
//                    },token);
//                    workerTask.Start();
//                    log.InfoFormat("Worker {0} started", i);
//                }
//            }
//            catch (Exception ex)
//            {
//                log.Error("Start error", ex);
//                throw;
//            }
        }

        protected override void OnStop()
        {
            if (this.cancelTokenSource != null
                && !this.cancelTokenSource.IsCancellationRequested)
            {
                this.cancelTokenSource.Cancel();
                log.Info("Cancellation all thread");
            }
        }
    }
}
