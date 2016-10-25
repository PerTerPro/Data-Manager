using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities.MasOffer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace QT.Entities.MasOffer.Tests
{
    [TestClass()]
    public class MasOfferAdapterTests
    {
        [TestMethod()]
        public void MasOfferAdapterTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InstanceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetConnectionTest()
        {
            MasOfferAdapter.SetConnection(
                @"Data Source=172.22.1.82;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu");
            MasOfferAdapter m = MasOfferAdapter.Instance();
            bool x = m.CheckIsMasOffer(2642071820174507179);

        }

        [TestMethod()]
        public void CheckIsMasOfferTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetFullUrlTest()
        {
            MasOfferAdapter.SetConnection(
            @"Data Source=172.22.1.82;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu");
            MasOfferAdapter m = MasOfferAdapter.Instance();
            var x =
                m.GetFullUrl(2642071820174507179,
                    @"https://tiki.vn/the-nho-sd-sandisk-ultra-class-10-16gb-48mb-s-p169551.html?src=may_anh_home_top&ref=c1801.c1815.c1818.c7108.c7247.c1839.c3644.c4782.c4924.c5057.c7250.c2681.");
        }
    }
}
