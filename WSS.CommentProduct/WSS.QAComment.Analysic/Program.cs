using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.QAComment.Core;

namespace WSS.QAComment.Analysic
{
    class Program
    {
        static void Main(string[] args)
        {var rabbitMqServer = RabbitMQManager.GetRabbitMQServer(Config.RabbitMQServerComment);
            var consumer = new ConsumerAsComment(rabbitMqServer);
            consumer.StartConsume();
        }
    }
}
