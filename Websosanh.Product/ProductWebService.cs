using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace Websosanh.Product
{
    public class ProductWebService : IProductWebService
    {
        private readonly JobClient _jobClientRedis;
        private readonly JobClient _jobClientSolr;

        public ProductWebService(string rabbitMq, string queueRedis, string queueSolr)
        {
            _jobClientRedis = new JobClient("", GroupType.Direct, queueRedis, true, RabbitMQManager.GetRabbitMQServer(rabbitMq));
            _jobClientSolr = new JobClient("", GroupType.Direct, queueSolr, true, RabbitMQManager.GetRabbitMQServer(rabbitMq));
        }

        public void PushMqToRedisProduct(long productId)
        {
            _jobClientRedis.PublishJob(new Job()
            {
                Type = 1,
                Data = BitConverter.GetBytes(productId)
            });
        }

        public void PushMqToSoldProduct(long productId)
        {
            _jobClientSolr.PublishJob(new Job()
            {
                Type = 1,
                Data = BitConverter.GetBytes(productId)
            });
        }
    }
}
