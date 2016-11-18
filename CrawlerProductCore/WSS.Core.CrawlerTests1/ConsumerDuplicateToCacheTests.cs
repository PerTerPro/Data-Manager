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
    public class ConsumerDuplicateToCacheTests
    {
        [Test()]
        public void ConsumerDuplicateToCacheTest()
        {
            var consumer = new ConsumerDuplicateToCache();
            consumer.StartConsume();
        }

        [Test()]
        public void ConsumerDuplicateToCacheTest1()
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
