using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Core.Crawler;
using NUnit.Framework;
namespace WSS.Core.Crawler.Tests
{
    [TestFixture()]
    public class ConsumerProductChangeToCassandraTests
    {
        [Test()]
        public void ConsumerProductChangeToCassandraTest()
        {
            ConsumerProductChangeToCassandra c = new ConsumerProductChangeToCassandra();
            c.StartConsume();
        }

        [Test()]
        public void ConsumerProductChangeToCassandraTest1()
        {
            
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
