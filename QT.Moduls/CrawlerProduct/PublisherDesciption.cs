using log4net;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using Websosanh.Core.Drivers.RabbitMQ;

namespace QT.Moduls.CrawlerProduct
{
    public class PublisherDesciption:Producer
    {
        private ILog _log = LogManager.GetLogger(typeof(PublisherDesciption));

        public PublisherDesciption() : base(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct)
            , "", ConfigRun.QueueChangeDescription, ConfigRun.QueueChangeDescription)
        {

        }

        public void Publish(JobMqChangeDesc mss)
        {
            this.Publish(true, null, UtilZipFile.Zip(mss.GetJSON()));
        }

        public override bool Init()
        {

            return true;
        }

        protected override void MessageReturn(object sender, BasicReturnEventArgs args)
        {
           
        }
    }
}
