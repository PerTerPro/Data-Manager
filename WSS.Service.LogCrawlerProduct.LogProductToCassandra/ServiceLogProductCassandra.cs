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


namespace WSS.Service.LogCrawlerProduct.LogProductToCassandra
{
    public partial class ServiceLogProductCassandra : ServiceBase
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(ServiceLogProductCassandra));
        CancellationTokenSource cancelTokenSource = null;
        RabbitMQServer rabbitMQServer = null;
        string CrawlerProductLog = "";
        Worker[] workers = null;
        int workerCount = 10;
        public ServiceLogProductCassandra()
        {
            InitializeComponent();
            workerCount = QT.Entities.Common.Obj2Int(ConfigurationManager.AppSettings["workerCount"], 1);
            CrawlerProductLog = ConfigurationManager.AppSettings["CrawlerProductLogJobName"];
            //OnStart(new string[] { });
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
                QT.Moduls.LogCassandra.LogCrawler logCass = new QT.Moduls.LogCassandra.LogCrawler();
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
                                QT.Entities.CrawlerProduct.RabbitMQ.MsProduct mss = QT.Entities.CrawlerProduct.RabbitMQ.MsProduct.GetDataFromMessage(updateDatafeedJob.Data);
                                logCass.LogProductToCassandra(mss.Classification,
                                    mss.Date_Update, 
                                    mss.Image_Url,
                                    mss.Is_Black_Link,
                                    mss.Is_New,
                                    mss.Name,
                                    mss.Note,
                                    mss.Price,
                                    mss.Product_Id,
                                    mss.Status,
                                    mss.Summary,
                                    mss.Valid,
                                    mss.Session,
                                    mss.CompanyId,
                                    mss.Url);
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
