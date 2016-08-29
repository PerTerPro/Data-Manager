using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using WSS.CrawlerProduct.CrawlerConsumer;

namespace QT.Moduls.CrawlerProduct
{
    public class TrackCrawler
    {

        RabbitMQServer rabbitMQServer = null;
        JobClient updateProductJobClient_TrackCrawlerProduct = null;
        static TrackCrawler _trackCrawler = null;

        public TrackCrawler ()
        {
            rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            updateProductJobClient_TrackCrawlerProduct = new JobClient("TrackCrawler", GroupType.Topic, "TrackCrawler_TrackInfo", true, rabbitMQServer);
        }

        public static TrackCrawler Instance()
        {
            return (_trackCrawler == null) ? (_trackCrawler = new TrackCrawler()) : _trackCrawler;
        }

        public void PushLog(long CompanyID, string message, int typeCrawler,DateTime datePush,string runner)
        {
            updateProductJobClient_TrackCrawlerProduct.PublishJob(new Job()
            {
                Type = 0,
                Data = MssLog.GetMess(new MssLog()
                {
                    CompanyID = CompanyID,
                    DateLog = datePush,
                    Mss = message,
                    Runner = runner,
                    TypeCrawler = typeCrawler
                })
            }, 10000000);
        }
    }
}
