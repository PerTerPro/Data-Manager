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
    public class HandlerNewPublisherTests
    {
        [Test()]
        public void RePushJobTest()
        {
            HandlerNewPublisher p = new HandlerNewPublisher();
            p.RePushJob();
        }
    }
}
