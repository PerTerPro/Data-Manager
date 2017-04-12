using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Service.Report.ProductOnClick.Error.Class;

namespace WSS.Service.Report.ProductOnClick.Error.Test
{
    [TestFixture]
    public class ProductProcessTest
    {
        [Test]
        public void ProductIsAdsScoreTest()
        {
            long ProductId = 42839061800553;
            bool x = ProductProcess.IsAdsScore(ProductId);
            Assert.Greater(x, true);
        }

        [Test]
        public void ProductIsUrlEncodedTest()
        {
            string url = @"http://ho.lazada.vn/SHDCvl?url=http%3A%2F%2Fwww.lazada.vn%2Fday-nhay-patch-cord-amp-cat6-dai-3m-xanh-duong-1891739.html%3Foffer_id%3D%7Boffer_id%7D%26affiliate_id%3D%7Baffiliate_id%7D%26offer_name%3D%7Boffer_name%7D_%7Boffer_file_id%7D%26affiliate_name%3D%7Baffiliate_name%7D%26transaction_id%3D%7Btransaction_id%7D%26aff_source%3D%7Bsource%7D&aff_sub=&aff_sub2=&aff_sub3=&aff_sub4=&aff_sub5=&source=";
            bool x = ProductProcess.IsUrlEncoded(url);
            Assert.Greater(x, true);
        }
    }
}
