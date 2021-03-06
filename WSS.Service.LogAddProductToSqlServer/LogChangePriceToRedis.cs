﻿using log4net;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using WSS.Product.Utilities;

namespace WSS.Service.LogProduct
{
    public class LogChangePriceToRedis
    {
        ILog log = log4net.LogManager.GetLogger(typeof(LogChangePriceToRedis));
        private Worker worker;
        public void Start()
        {
            log.Info("Start LogChangePriceToRedis");

            var rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            worker = new Worker("ChangePriceQueue.LogToRedis", false, rabbitMQServer);

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
                catch (Exception ex01)
                {
                    log.Error("Exception:", ex01);
                    return true;
                }
            };
            worker.Start();
        }

        ~LogChangePriceToRedis()
        {
            worker.Stop();
        }
    }
}
