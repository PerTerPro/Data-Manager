using log4net;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;


namespace WSS.Service.CheckPriceProduct
{
    public partial class ServiceCheckPriceProduct : ServiceBase
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(ServiceCheckPriceProduct));
        CancellationTokenSource cancelTokenSource = null;
        RabbitMQServer rabbitMQServer = null;
        string ChangePriceToRedisJobName = "";
        Worker[] workers = null;
        int workerCount = 4;
        public ServiceCheckPriceProduct()
        {
            InitializeComponent();
            workerCount = QT.Entities.Common.Obj2Int(ConfigurationManager.AppSettings["workerCount"], 1);
            ChangePriceToRedisJobName = ConfigurationManager.AppSettings["ChangePriceToRedisJobName"];
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
                Encoding enc = new UTF8Encoding(true, true);
                for (int i = 0; i < workerCount; i++)
                {
                    log.InfoFormat("Start worker {i}", i.ToString());
                    var worker = new Worker(ChangePriceToRedisJobName, false, rabbitMQServer);
                    workers[i] = worker;
                    var token = this.cancelTokenSource.Token;
                    Task workerTask = new Task(() =>
                    {
                        worker.JobHandler = (downloadImageJob) =>
                        {
                            try
                            {
                                token.ThrowIfCancellationRequested();
                                JobRabbitChangePrice job = JsonConvert.DeserializeObject<JobRabbitChangePrice>(enc.GetString(downloadImageJob.Data));
                                WebRequest client = WebRequest.Create(string.Format(@"http://172.22.1.108:8983/api/PriceDetector/price_detect.htm?pn={0}", Uri.EscapeDataString(job.Name)));
                                string strData = (new StreamReader(client.GetResponse().GetResponseStream()).ReadToEnd());
                                MsCheckPrice msCheckPrice = WSS.Service.CheckPriceProduct.MsCheckPrice.FromJSON(strData);
                                bool failPrice = false;
                                if (job.NewPrice > 0)
                                {
                                    if (msCheckPrice.price > 100000)
                                    {
                                        if (job.NewPrice > msCheckPrice.price * (decimal)2 || job.NewPrice < msCheckPrice.price / (decimal)2) failPrice = true;
                                        log.Info(string.Format("CompanyID: {0} ProductID: {1} OldPrice: {2} OldPrice: {3} FailProduct: {4} SuggestPrice: {5}", job.CompanyID, job.ProductID, job.OldPrice, job.NewPrice, failPrice, msCheckPrice.price));
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
