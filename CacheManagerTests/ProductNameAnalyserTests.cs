using NUnit.Framework;
using CacheManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManager.Tests
{
    [TestFixture()]
    public class ProductNameAnalyserTests
    {
        [Test()]
        public void MeasureNameCoverRatioForSummaryTest()
        {
            string name = "Điện thoại Apple Iphone 6S Plus - 16GB, màu vàng (Gold)";
            string summary = "Iphone 6S Plus 16GB Quốc Tế";
            double expectedRatio = (double)2/3;
            var ratio = ProductNameAnalyser.MeasureNameCoverRatioForSummary(name, summary);
            Assert.AreEqual(expectedRatio, ratio);
        }
    }
}