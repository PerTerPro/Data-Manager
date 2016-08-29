using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.JobServer;
using System.Configuration;
using log4net;
using QT.Entities;
using Websosanh.Core.Drivers.RabbitMQ;
using System.IO;
using System.Drawing;
using Websosanh.Core.Drivers.Redis;
using QT.Entities.CrawlerProduct;
using Newtonsoft.Json;

namespace WSS.Service.LogChangePriceToRedis
{
    public partial class LogChangePriceToRedis : ServiceBase
    {
        Worker worker = null;
        RabbitMQServer rabbitMQServer = null;
       private static readonly ILog log = LogManager.GetLogger(typeof(LogChangePriceToRedis));
        public LogChangePriceToRedis()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            worker = new Worker("ChangePriceQueue.LogToRedis", false, rabbitMQServer);
            Task workerTask = new Task(() =>
            {
                log.Info("Start consumer!");
                worker.JobHandler = (downloadImageJob) =>
                {
                    log.Info("Get job from MQ");
                    try
                    {
                        Encoding enc = new UTF8Encoding(true, true);
                        string strData = enc.GetString(downloadImageJob.Data);
                        JobRabbitChangePrice job = JsonConvert.DeserializeObject<JobRabbitChangePrice>(strData);
                        RedisPriceLogAdapter.PushMerchantProductPrice(job.ProductID, job.NewPrice, DateTime.Now);
                        log.Info(string.Format("Saved for job:{0}", strData));
                        return true;
                    }
                    catch(Exception ex01)
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
        protected override void OnStop()
        {
            if (worker != null) worker.Stop();
            if (rabbitMQServer != null) rabbitMQServer.Stop();
        }
    }
}
