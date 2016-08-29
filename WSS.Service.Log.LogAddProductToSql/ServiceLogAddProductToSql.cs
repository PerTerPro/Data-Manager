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


namespace WSS.Service.Log.LogAddProductToSql
{
    public partial class ServiceLogAddProductToSql : ServiceBase
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(ServiceLogAddProductToSql));
        CancellationTokenSource cancelTokenSource = null;
        RabbitMQServer rabbitMQServer = null;
        string AddProductToSqlJobName = "";
        Worker[] workers = null;
        int workerCount = 4;
        public ServiceLogAddProductToSql()
        {
            InitializeComponent();
            workerCount = QT.Entities.Common.Obj2Int(ConfigurationManager.AppSettings["workerCount"], 1);
            AddProductToSqlJobName = ConfigurationManager.AppSettings["AddProductToSqlJobName"];
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

                Encoding enc = new UTF8Encoding(true, true);
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
                                string strData = enc.GetString(downloadImageJob.Data);
                                JobRabbitAddProduct job = JsonConvert.DeserializeObject<JobRabbitAddProduct>(strData);
                                if (job.DateAdd == DateTime.MinValue)
                                {
                                    job.DateAdd = productAdapter.GetLastChangeOfProduct(job.ProductID);
                                }
                                crawlerProductAdapter.SaveLogAddProduct(job.ProductID, job.DetailUrl, job.IDCompnay, job.Name, job.DateAdd);
                                log.Info(string.Format("Log for {0}", strData));
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
