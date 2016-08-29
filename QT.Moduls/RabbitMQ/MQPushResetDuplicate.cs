using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace QT.Moduls.RabbitMQ
{
    public class MQPushResetDuplicate
    {
        private ILog _log = LogManager.GetLogger(typeof (MQPushResetDuplicate));
        private RabbitMQServer rabbitMQServer;

        public MQPushResetDuplicate(RabbitMQServer rabbitMqServer)
        {
            this.rabbitMQServer = rabbitMqServer;
        }

        public void PushQueueReloadCacheDuplicate(long CompanyID, string Domain)
        {
            try
            {

                JobClient jobClientReloadCacheProductInfo = new JobClient("CacheCrawlerProduct", GroupType.Topic, "CacheCrawlerProduct.Refresh.CheckDuplicate.#", true, this.rabbitMQServer);
                QT.Entities.CrawlerProduct.RabbitMQ.MssRefreshCacheProductInfo mss = new Entities.CrawlerProduct.RabbitMQ.MssRefreshCacheProductInfo()
                {
                    CompanyID = CompanyID,
                    Domain = Domain
                };

                var updateProductJob = new Websosanh.Core.JobServer.Job();
                updateProductJob.Data = System.Text.Encoding.UTF8.GetBytes(mss.GetMss());
                int updateProductJobExpirationMS = 3600000;
                jobClientReloadCacheProductInfo.PublishJob(updateProductJob, updateProductJobExpirationMS);
            }
            catch (Exception ex01)
            {
                _log.Error(string.Format("Error push job ChangeMainInfo to MQ:{0}.{1}", ex01.Message, ex01.StackTrace));
                Thread.Sleep(10000);
            }
        }
    }
}
