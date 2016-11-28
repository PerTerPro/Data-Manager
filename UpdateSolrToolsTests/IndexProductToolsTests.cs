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
    }
}
