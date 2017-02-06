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
    public class UtilCrlTests
    {
        [Test()]
        public void GetUrlTest()
        {
            Assert.AreEqual("http://www.lazada.vn/laptop-lenovo-laptop-ideapad-100-15iby-80mj0030vn-156inch-Den-1798388.html",
                UtilCrl.GetUrl(@"http://ho.lazada.vn/SHDCvl?url=http%3A%2F%2Fwww.lazada.vn%2Flaptop-lenovo-laptop-ideapad-100-15iby-80mj0030vn-156inch-Den-1798388.html%3Foffer_id%3D%7Boffer_id%7D%26affiliate_id%3D%7Baffiliate_id%7D%26offer_name%3D%7Boffer_name%7D_%7Boffer_file_id%7D%26affiliate_name%3D%7Baffiliate_name%7D%26transaction_id%3D%7Btransaction_id%7D&aff_sub=&aff_sub2=&aff_sub3=&aff_sub4=&aff_sub5="
                ,"lazada.vn"));
        }
    }
}
