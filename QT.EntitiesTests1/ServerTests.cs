using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;
using NUnit.Framework;
namespace QT.Entities.Tests
{
    [TestFixture()]
    public class ServerTests
    {
        [Test()]
        public void GetMachineCodeTest()
        {
            string str =   Server.IPHost;
            Assert.AreNotEqual(str, "");
        }
    }
}
