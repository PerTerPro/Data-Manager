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
    public class PublisherDesciption
    {
        private ILog _log = LogManager.GetLogger(typeof(PublisherDesciption));

        public PublisherDesciption() 
        {

        }
        public void Publish(JobMqChangeDesc mss)
        {
            
        }
    }
}
