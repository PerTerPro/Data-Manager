using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateSolrTools;
using NUnit.Framework;
namespace UpdateSolrTools.Tests
{
    [TestFixture()]
    public class IndexProductToolsTests
    {
        const string productConnectionString = "Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price";
        [Test()]
        public void GetUnitNormalizedNameTest()
        {
            var otherNames =
                UnitNormalization.GetUnitNormalizedName("Dép hàng không Vietnam Airlines mẫu mới màu vàng mới 100%");
            var otherNames2 =
                UnitNormalization.GetUnitNormalizedName("Dép hàng không Vietnam Airlines mẫu mới màu vàng mới 100 %");
            var otherNames3 =
                UnitNormalization.GetUnitNormalizedName("Dép hàng không Vietnam Airlines mẫu mới màu vàng mới 100m");
            var otherNames4 =
                UnitNormalization.GetUnitNormalizedName("Dép hàng không Vietnam Airlines mẫu mới màu vàng mới 100 m");
            var otherNames5 =
                UnitNormalization.GetUnitNormalizedName("Dép hàng không Vietnam Airlines mẫu mới màu vàng mới 100% tuy");
            var otherNames6 =
                UnitNormalization.GetUnitNormalizedName("Dép hàng không Vietnam Airlines mẫu mới màu vàng mới 100 % tuy");
            var otherNames7 =
                UnitNormalization.GetUnitNormalizedName("Dép hàng không Vietnam Airlines mẫu mới màu vàng mới 100m tuy");
            var otherNames8 =
                UnitNormalization.GetUnitNormalizedName("Dép hàng không Vietnam Airlines mẫu mới màu vàng mới 100 m tuy");
            return;
        }

        [Test()]
        public void GetAllPriorMerchantsTest()
        {
            var priorMerchant = IndexProductTools.GetAllPriorMerchants(productConnectionString);
            return;
        }

        [Test()]
        public void GetAllBadMerchantIdTest()
        {
            var priorMerchant = IndexProductTools.GetAllBadMerchantId(productConnectionString, 45);
            return;
        }

        [Test()]
        public void GetListMerchantUseDatafeedIDTest()
        {
            var priorMerchant = IndexProductTools.GetListMerchantUseDatafeedID(productConnectionString);
            return;
        }

        [Test()]
        public void GetListSpecialMerchantIDTest()
        {
            var priorMerchant = IndexProductTools.GetListSpecialMerchantID(productConnectionString);
            return;
        }
    }
}
