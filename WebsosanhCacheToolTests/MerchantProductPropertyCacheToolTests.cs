using NUnit.Framework;
using WebsosanhCacheTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsosanhCacheTool.Tests
{
    [TestFixture()]
    public class MerchantProductPropertyCacheToolTests
    {
        [Test()]
        public void GetProductPropertyFromCacheTest()
        {
            long productId = 100163053828019456;
            var result = MerchantProductPropertyCacheTool.GetProductPropertyFromCache(productId);
            Assert.GreaterOrEqual(result.Count, 1);
            return;
        }
    }
}