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


namespace WSS.Service.CrawlerProduct.UpdateLastJob
{
    public partial class ServiceCrawlerProductUpdateLastJob : ServiceBase
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(ServiceCrawlerProductUpdateLastJob));
        string connectionString = "";
        CancellationTokenSource cancelTokenSource = null;
        RabbitMQServer rabbitMQServer = null;
        string CrawlerProductLastJob = "";
        Worker[] workers = null;
        int workerCount = 4;
        SqlDb sqldb = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        long CompanyID = 0;
        DateTime DatePush = DateTime.Now;


        public ServiceCrawlerProductUpdateLastJob()
        {
            InitializeComponent();
            rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            workerCount = QT.Entities.Common.Obj2Int(ConfigurationManager.AppSettings["workerCount"], 1);
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            CrawlerProductLastJob = ConfigurationManager.AppSettings["CrawlerProductLastJobNane"];
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
                for (int i = 0; i < workerCount; i++)
                {
                    log.InfoFormat("Start worker {i}", i.ToString());
                    var worker = new Worker(CrawlerProductLastJob, false, rabbitMQServer);
                    workers[i] = worker;
                    var token = this.cancelTokenSource.Token;
                    Task workerTask = new Task(() =>
                    {
                        int CountMss = 0;
                        worker.JobHandler = (updateDatafeedJob) =>
                        {
                            try
                            {
                                CountMss++;
                                token.ThrowIfCancellationRequested();
                                QT.Entities.CrawlerProduct.RabbitMQ.MSLastJob mss = QT.Entities.CrawlerProduct.RabbitMQ.MSLastJob.GetDataFromMessage(updateDatafeedJob.Data);
                                CompanyID = mss.Company;
                                DatePush = mss.DatePush;
                                if (updateDatafeedJob.Type == 1)
                                {
                                    UpdateReload(CompanyID, DatePush);
                                    log.InfoFormat("Update Last Job Reload Company: {0}: {1}", CompanyID, DatePush);
                                }
                                else if (updateDatafeedJob.Type == 0)
                                {
                                    UpdateFindNew(CompanyID, DatePush);
                                    log.InfoFormat("Update Last Job Findnew Company: {0}: {1}", CompanyID, DatePush);
                                }
                                if (CountMss % 20 == 0) Thread.Sleep(10000);
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

        private void UpdateFindNew(long CompanyID, DateTime DatePush)
        {
            sqldb.RunQuery("update Company set LastJobCrawlerFindNew = @LastJobCrawlerFindNew where ID = @CompanyID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                sqldb.CreateParamteter("@CompanyID",CompanyID,SqlDbType.BigInt),
                sqldb.CreateParamteter("@LastJobCrawlerFindNew",DatePush,SqlDbType.DateTime)
           });
        }

        private void UpdateReload(long CompanyID, DateTime DatePush)
        {
            sqldb.RunQuery("update Company set LastJobCrawlerReload = @LastJobCrawlerReload where ID = @CompanyID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                sqldb.CreateParamteter("@CompanyID",CompanyID,SqlDbType.BigInt),
                sqldb.CreateParamteter("@LastJobCrawlerReload",DatePush,SqlDbType.DateTime)
           });
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
