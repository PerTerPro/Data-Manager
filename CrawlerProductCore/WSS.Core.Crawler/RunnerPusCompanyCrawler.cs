using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using log4net.Util;
using QT.Entities;
using QT.Entities.CrawlerProduct.Comment;
using QT.Moduls;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlerProduct.Cache;
using RabbitMQ.Client;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Core.Crawler.CrlProduct;

namespace WSS.Core.Crawler
{
    public class RunnerPushCompanyCrawler
    {
        private ILog log = LogManager.GetLogger(typeof(RunnerPushCompanyCrawler));
        public void Start()
        {
          
            
        }
    }
}
