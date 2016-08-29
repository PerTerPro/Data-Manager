using log4net;
using QT.Entities;
using QT.Entities.CrawlerProduct;
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


namespace WSS.Service.CacheCrawlerProduct
{
    public partial class ServiceCacheProductInfo : ServiceBase
    {
        //QT.Moduls.LogCassandra.Log logCassandra = QT.Moduls.LogCassandra.Log.Instance;

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(ServiceCacheProductInfo));
        string connectionString = "";
        CancellationTokenSource cancelTokenSource = null;
        RabbitMQServer rabbitMQServer = null;
        string refreshCacheProductInfoJobName = "";
        Worker[] workers = null;
        int workerCount = 4;

        public ServiceCacheProductInfo()
        {
            InitializeComponent();
            rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            workerCount = QT.Entities.Common.Obj2Int(ConfigurationManager.AppSettings["workerCount"], 1);
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            refreshCacheProductInfoJobName = ConfigurationManager.AppSettings["productInfoRefreshJobName"];
        }

        protected override void OnStart(string[] args)
        {
           
            log.Info("Start service");
            try
            {
                InitializeComponent();
                cancelTokenSource = new CancellationTokenSource();
                Server.LogConnectionString = ConfigurationManager.AppSettings["LogConnectionString"];
                QT.Entities.Server.ConnectionString = connectionString;
                string rabbitMQServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];
                workers = new Worker[workerCount];
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                for (int i = 0; i < workerCount; i++)
                {
                    log.InfoFormat("Start worker {i}", i.ToString());
                    var worker = new Worker(refreshCacheProductInfoJobName, false, rabbitMQServer);
                    workers[i] = worker;
                    var token = this.cancelTokenSource.Token;
                    Task workerTask = new Task(() =>
                    {
                        var db = new QT.Entities.Data.SqlDb(this.connectionString);
                        QT.Moduls.CrawlerProduct.Cache.CacheProductInfo cacheProductInfo = new QT.Moduls.CrawlerProduct.Cache.CacheProductInfo(db);
                        
                        worker.JobHandler = (jobMss) =>
                        {
                            try
                            {
                                token.ThrowIfCancellationRequested();
                                
                                QT.Entities.CrawlerProduct.RabbitMQ.MssRefreshCacheProductInfo mss = QT.Entities.CrawlerProduct.RabbitMQ.MssRefreshCacheProductInfo.FromJSON(QT.Entities.Common.ByteToString(jobMss.Data));
                                log.InfoFormat("Start run refresh company {0} : {1}", mss.CompanyID, mss.Domain);
                                RedisCacheProductInfoAdapter rediscacheProductForCompany = RedisCacheProductInfoAdapter.Instance();
                                int numberProduct = cacheProductInfo.ReloadCacheForCompany(mss.CompanyID, mss.Domain);
                                log.InfoFormat("End refresh company {0} : {1} {2} products", mss.CompanyID, mss.Domain, numberProduct);
                                return true;
                            }
                            catch (OperationCanceledException opc)
                            {
                                log.Info("End worker");
                                return true;
                            }
                        };
                        worker.Start();
                    },token);
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
