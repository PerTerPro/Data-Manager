using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QT.Entities;
using Websosanh.Core.JobServer;
using log4net;
using Websosanh.Core.Drivers.RabbitMQ;
using QT.Entities.Images;

namespace QT.Moduls.RabbitMQ
{
    public class MQPushDownloadImage
    {
        private ILog _log = LogManager.GetLogger(typeof(MQPushDownloadImage));
        private RabbitMQServer _rabbitMQServer;
        private JobClient _jobClient = null;

        public MQPushDownloadImage(RabbitMQServer rabbitMQServer)
        {
            _rabbitMQServer = rabbitMQServer;
            _jobClient = new JobClient(ConfigImages.ImboExchangeImages, GroupType.Topic, ConfigImages.ImboRoutingKeyDownloadImageProduct, true, RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName));
        }
        public MQPushDownloadImage()
        {
            _rabbitMQServer = RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct);
            _jobClient = new JobClient(ConfigImages.ImboExchangeImages, GroupType.Topic, ConfigImages.ImboRoutingKeyDownloadImageProduct, true, RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName));
        }

        public void PushQueueChangeChangeImage(ImageProductInfo mss)
        {
            while (true)
            {
                try
                {
                    _jobClient.PublishJob(new Websosanh.Core.JobServer.Job() {Data = ImageProductInfo.GetMessage(mss)});
                    return;
                }
                catch (Exception ex01)
                {
                    _log.Error(string.Format("Error push job ChangeMainInfo to MQ:{0}.{1}", ex01.Message, ex01.StackTrace));
                    Thread.Sleep(10000);
                }
            }
        }
    }
}
