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
using QT.Entities.Data;

namespace WSS.Service.LogChangePriceSqlServer
{
    public partial class LogChangePriceToSql : ServiceBase
    {
        Worker worker = null;
        RabbitMQServer rabbitMQServer = null;
       private static readonly ILog log = LogManager.GetLogger(typeof(LogChangePriceToSql));
        public LogChangePriceToSql()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            worker = new Worker("ChangePriceQueue.LogToSql", false, rabbitMQServer);
            Task workerTask = new Task(() =>
            {
                log.Info("Start consumer!");
                worker.JobHandler = (downloadImageJob) =>
                {
                    string connectToSQL = @"Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
                    CrawlerProductAdapter crawlerProductAdapter = new CrawlerProductAdapter(new SqlDb(connectToSQL));
                    log.Info("Get job from MQ");
                    try
                    {
                        Encoding enc = new UTF8Encoding(true, true);
                        string strData = enc.GetString(downloadImageJob.Data);
                        JobRabbitChangePrice job = JsonConvert.DeserializeObject<JobRabbitChangePrice>(strData);
                        crawlerProductAdapter.SaveLog(job.ProductID, job.NewPrice, job.OldPrice);
                        log.Info (string.Format("Log for {0}", strData));
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
