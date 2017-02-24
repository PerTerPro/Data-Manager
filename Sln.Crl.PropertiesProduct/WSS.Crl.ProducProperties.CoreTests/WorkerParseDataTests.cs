using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Crl.ProducProperties.Core;
using NUnit.Framework;
namespace WSS.Crl.ProducProperties.Core.Tests
{
    [TestFixture()]
    public class WorkerParseDataTests
    {
        [Test()]
        public void ProcessMessageTest()
        {
            QT.Entities.Server.ConnectionString = ConfigurationManager.AppSettings["ConnectionProduct"];
            WorkerParseData w = new WorkerParseData("adayroi.com");
            w.StartConsume();
        }

        [Test()]
        public void InitTest()
        {
            QT.Entities.Server.ConnectionString = ConfigurationManager.AppSettings["ConnectionProduct"];
        }

        [Test()]
        public void WorkerParseDataTest()
        {
            
        }
    }
}
