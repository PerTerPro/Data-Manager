using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using QT.Moduls.Company;

namespace QT.Entities.Test
{
    [TestFixture()]
    public class DataFeedTest
    {
        [Test]
        public void GetAllProduct()
        {
            CompanyFunctions companyFunctions = new CompanyFunctions();
            companyFunctions.ReturnListProduct(new Company()
            {
                CompanyDataFeedType = Company.DataFeedType.AllProductsFromFile,
                DataFeedPath = "",
                ID = 3502170206813664485,
                Domain = "lazada.vn"
            });
        }
    }
}
