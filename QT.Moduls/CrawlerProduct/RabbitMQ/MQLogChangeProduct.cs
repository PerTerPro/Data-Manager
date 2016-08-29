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
    public class MQLogChangeProduct
    {
        readonly RabbitMQServer _rabbitMqServer = null;
        static MQLogChangeProduct _obj = null;
        readonly JobClient _jobClient = null;
        readonly log4net.ILog _log = null;


        private MQLogChangeProduct(string rabbitMqServer = "rabbitMQLogProduct")
        {
            while (true)
            {
                try
                {
                    _log = log4net.LogManager.GetLogger(typeof(MQLogChangeProduct));
                    _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(rabbitMqServer);
                    _jobClient = new JobClient("CrawlerProduct", GroupType.Topic, "CrawlerProduct.LogProduct", true,
                        _rabbitMqServer);
                    break;
                }
                catch (Exception ex01)
                {
                    _log.Error(ex01);
                    Thread.Sleep(1000);
                }
            }
        }

        public static MQLogChangeProduct Instance(string rabbitMqServer = "rabbitMQLogProduct")
        {
            return _obj ?? (_obj = new MQLogChangeProduct(rabbitMqServer));
        }

        public void PushChangeProduct(QT.Entities.CrawlerProduct.RabbitMQ.MsProduct product)
        {
            int count = 0;
            while (true)
            {
                try
                {
                    _jobClient.PublishJob(new Job()
                        {
                            Data = product.GetArByte(),
                            Type = 0
                        }, 0);
                    break;
                }
                catch (Exception ex01)
                {
                    _log.Error(typeof(MQLogChangeProduct).ToString() + ".PushChangeProduct:" + count++ );
                    Thread.Sleep(1000);
                }
            }
        }
    }

    public class MQAddProduct
    {
        readonly RabbitMQServer _rabbitMqServer = null;
        private static MQAddProduct _obj = null;
        readonly JobClient _jobClient = null;
        log4net.ILog log = null;

        private MQAddProduct(string rabbitMQ = "rabbitMQLogAddProduct")
        {
            while (true)
            {
                try
                {
                    log = log4net.LogManager.GetLogger(typeof(MQAddProduct));
                    _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(rabbitMQ);
                    _jobClient = new JobClient("CrawlerProduct", GroupType.Topic, "CrawlerProduct.AddProduct", true, _rabbitMqServer);
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                }
            }
        }

        public static MQAddProduct Instance(string rabbitMq = "rabbitMQLogAddProduct")
        {
            return _obj ?? (_obj = new MQAddProduct(rabbitMq));
        }

        public void PushChangeProduct(QT.Entities.CrawlerProduct.RabbitMQ.MSLogAddProduct product)
        {
            try
            {
                _jobClient.PublishJob(new Job()
                {
                    Data = product.GetArByte(),
                    Type = 0
                }, 0);
            }
            catch (Exception ex01)
            {

            }
        }
    }
}
