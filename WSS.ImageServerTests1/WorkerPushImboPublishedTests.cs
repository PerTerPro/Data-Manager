using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.ImageServer;
using NUnit.Framework;
namespace WSS.ImageServer.Tests
{
    [TestFixture()]
    public class WorkerPushImboPublishedTests
    {
        [Test()]
        public void WorkerPushImboPublishedTest()
        {
           WorkerPushImboPublished w = new WorkerPushImboPublished();
            w.StartConsume();
        }

        [Test()]
        public void InitTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void ProcessMessageTest()
        {
            Assert.Fail();
        }
    }
}
