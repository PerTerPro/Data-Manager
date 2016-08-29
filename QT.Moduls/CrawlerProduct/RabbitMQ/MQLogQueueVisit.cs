using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace QT.Moduls.CrawlerProduct.RabbitMQ
{
    public class MQLogQueueVisit
    {
        RabbitMQServer rabbitMQServer = null;
        static MQLogQueueVisit obj = null;
        JobClient jobClient = null;
        log4net.ILog log = null;

        private MQLogQueueVisit()
        {
            while (true)
            {
                try
                {
                    log = log4net.LogManager.GetLogger(typeof(MQLogChangeProduct));
                    rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitLogQueueVisit");
                    jobClient = new JobClient("CrawlerProduct", GroupType.Topic, "CrawlerProduct.FindNew", true, rabbitMQServer);
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(1000);
                }
            }
        }

        public static MQLogQueueVisit Instance()
        {
            return obj == null ? obj = new MQLogQueueVisit() : obj;
        }

        public void PushChangeProduct(QT.Entities.CrawlerProduct.RabbitMQ.MssLogFindNewProduct product)
        {
            int count = 0;
            while (true)
            {
                try
                {
                    jobClient.PublishJob(new Job()
                    {
                        Data = product.ToMss(),
                        Type = 0
                    }, 0);
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(typeof(MQLogChangeProduct).ToString() + ".PushChangeProduct:" + count++);
                }
            }
        }
    }

    public class MQLogWarningFindNew
    {
        RabbitMQServer rabbitMQServer = null;
        static MQLogWarningFindNew obj = null;
        JobClient jobClient = null;
        log4net.ILog log = null;

        private MQLogWarningFindNew()
        {
            while (true)
            {
                try
                {
                    log = log4net.LogManager.GetLogger(typeof(MQLogChangeProduct));
                    rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitLogQueueWarningFindNew");
                    jobClient = new JobClient("CrawlerProduct", GroupType.Topic, "CrawlerProduct.WarningFindNew",true, rabbitMQServer);
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(1000);
                }
            }
        }

        public static MQLogWarningFindNew Instance()
        {
            return obj == null ? obj = new MQLogWarningFindNew() : obj;
        }

        public void PushChangeProduct(string mss)
        {
            int count = 0;
            while (true)
            {
                try
                {
                    jobClient.PublishJob(new Job()
                    {
                        Data = QT.Entities.Common.StringToArByte(mss),
                        Type = 0
                    }, 0);
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(typeof(MQLogChangeProduct).ToString() + ".PushChangeProduct:" + count++);
                }
            }
        }
    }
}
