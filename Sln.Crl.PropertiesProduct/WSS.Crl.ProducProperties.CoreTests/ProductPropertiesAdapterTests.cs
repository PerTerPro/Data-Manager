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
    public class ProductPropertiesAdapterTests
    {
        [Test()]
        public void GetConfigTest()
        {
            ProductPropertiesAdapter ppa = new ProductPropertiesAdapter();
            var x =  ppa.GetConfig(3433481253691794480);
            Assert.NotNull(x);
        }

        [Test()]
        public void GetConfigTest1()
        {
            
        }
    }
}
