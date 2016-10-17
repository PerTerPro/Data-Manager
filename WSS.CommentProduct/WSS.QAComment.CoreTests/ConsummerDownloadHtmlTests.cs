using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.QAComment.Core;
using NUnit.Framework;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.QAComment.Core.Tests
{
    [TestFixture()]
    public class ConsummerDownloadHtmlTests
    {
        [Test()]
        public void ConsummerDownloadHtmlTest()
        {
            var rabbitMqServer = RabbitMQManager.GetRabbitMQServer(Config.RabbitMQServerComment);
            var consumer = new ConsumerDownloadHtml(rabbitMqServer, Config.QueueWaitDownloadHtml);
            consumer.StartConsume();
        }

        [Test()]
        public void ProcessMessageTest()
        {
            
        }

        [Test()]
        public void InitTest()
        {
            
        }
    }
}
