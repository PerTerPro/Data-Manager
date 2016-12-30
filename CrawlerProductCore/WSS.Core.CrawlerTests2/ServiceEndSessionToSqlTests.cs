using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Service.CR.EndSession.ToSql;
using NUnit.Framework;
using WSS.Core.Crawler;

namespace WSS.Service.CR.EndSession.ToSql.Tests
{
    [TestFixture()]
    public class ServiceEndSessionToSqlTests
    {
        [Test()]
        public void ServiceEndSessionToSqlTest()
        {
            ConsumerSaveEndSession w = new ConsumerSaveEndSession(ConfigCrawler.QueueEndSessionToSql);
            w.StartConsume();
        }
    }
}
