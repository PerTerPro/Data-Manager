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
    public class ConsumerAsCommentTests
    {
        [Test()]
        public void ConsumerAsCommentTest()
        {
            var rabbitMqServer = RabbitMQManager.GetRabbitMQServer(Config.RabbitMQServerComment);
            var consumer = new ConsumerAsComment(rabbitMqServer, Config.QueueWaitDownloadHtml);
            consumer.StartConsume();
        }

        [Test()]
        public void InitTest()
        {
          
        }

        [Test()]
        public void ProcessMessageTest()
        {
          
        }
    }
}
