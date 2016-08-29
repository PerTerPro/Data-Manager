using System;
using System.Configuration;
using System.Text;
using System.Threading;
using log4net;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace QT.Moduls.CrawlerProduct.RabbitMQ
{
    public class MqLogChangePrice : JobClient
    {
        readonly ILog _log = LogManager.GetLogger(typeof(MqLogChangePrice));

        public void PushQueueChangePriceLog(JobRabbitChangePrice job)
        {
            while (true)
            {
                try
                {
                    this.PublishJob(new Job
                    {
                        Type = 0,
                        Data = job.ToArrayByte()
                    });
                    return;
                }
                catch (Exception ex01)
                {
                    _log.Error("Ex when push change price log:", ex01);
                    Thread.Sleep(10000);
                }
            }
        }


        public MqLogChangePrice() :
            base(
            ConfigRun.ExchangeChangePrice, GroupType.Topic, ConfigRun.RottingChangePrice, true,
            RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct))
        {
        }
    }
}
