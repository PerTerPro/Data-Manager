using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Crl.ProducProperties.Core;
using NUnit.Framework;
namespace WSS.Crl.ProducProperties.Core.Tests
{
    [TestFixture()]
    public class MD5Tests
    {
        [Test()]
        public void CalculateMD5HashTest()
        {
            string x = MD5.CalculateMD5Hash("123");
            Assert.Greater(x.Length, 0);
        }
    }
}
