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
    public class InitQueueTests
    {
        [Test()]
        public void StartTest()
        {
            InitQueue iq = new InitQueue();
            iq.Start();
        }
    }
}