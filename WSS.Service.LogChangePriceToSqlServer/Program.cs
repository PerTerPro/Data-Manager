using log4net;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.Drivers.Redis;
using Websosanh.Core.JobServer;


namespace WSS.Service.LogChangePriceToRedis
{
    public class Program
    {
        public static void Main()
        {
            ILog log = log4net.LogManager.GetLogger(typeof(Program));
            var rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            var worker = new Worker("ChangePriceQueue.LogToRedis", false, rabbitMQServer);
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
                    catch (Exception ex01)
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
    }
}
