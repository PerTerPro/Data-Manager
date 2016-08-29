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


namespace WSS.Service.LogCrawlerProductRabbitToCassandra
{
    public partial class ServiceLogProductToCassandra : ServiceBase
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(ServiceLogProductToCassandra));
        string connectionString = "";
        CancellationTokenSource cancelTokenSource = null;
        RabbitMQServer rabbitMQServer = null;
        string CrawlerProductLog = "";
        Worker[] workers = null;
        int workerCount = 4;
        SqlDb sqldb = new SqlDb("Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200");
        
        public ServiceLogProductToCassandra()
        {
            InitializeComponent();
            workerCount = QT.Entities.Common.Obj2Int(ConfigurationManager.AppSettings["workerCount"], 1);
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            CrawlerProductLog = ConfigurationManager.AppSettings["CrawlerProductLogJobName"];
        }

        protected override void OnStart(string[] args)
        {
            log.Info("Start service");
            try
            {
                InitializeComponent();
                cancelTokenSource = new CancellationTokenSource();
                string rabbitMQServerName = ConfigurationManager.AppSettings["rabbitMQ31ServerName"];
                workers = new Worker[workerCount];
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                QT.Moduls.LogCassandra.LogCrawler logCass = new QT.Moduls.LogCassandra.LogCrawler();
                var db = new QT.Entities.Data.SqlDb(this.connectionString);
                for (int i = 0; i < workerCount; i++)
                {
                    log.InfoFormat("Start worker {i}", i.ToString());
                    var worker = new Worker(CrawlerProductLog, false, rabbitMQServer);
                    workers[i] = worker;
                    var token = this.cancelTokenSource.Token;
                    Task workerTask = new Task(() =>
                    {
                        worker.JobHandler = (updateDatafeedJob) =>
                        {
                            try
                            {
                                token.ThrowIfCancellationRequested();
                                
                                QT.Entities.CrawlerProduct.RabbitMQ.MssLogCassandra mss = QT.Entities.CrawlerProduct.RabbitMQ.MssLogCassandra.GetDataFromMessage(updateDatafeedJob.Data);
                                logCass.SaveLogToCassandra(mss.log,
                                                           (QT.Moduls.LogCassandra.LogCode)mss.logCode,
                                                           (QT.Moduls.LogCassandra.TypeLog)mss.typeLog, 
                                                           mss.data_id, 
                                                           mss.data_second_id,
                                                           null,
                                                           mss.session);
                                log.InfoFormat("Log crawler company {0} : {1} ", mss.data_id, mss.data_second_id);
                                return true;
                            }
                            catch (OperationCanceledException opc)
                            {
                                log.Info("End worker");
                                return true;
                            }
                            catch (Exception ex01)
                            {
                                log.Info(ex01);
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
                this.cancelTokenSource.Cancel();
                log.Info("Cancellation all thread");
            }
        }
    }
}
