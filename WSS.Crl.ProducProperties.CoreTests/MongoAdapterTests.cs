using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WSS.Crl.ProducProperties.Core;
using NUnit.Framework;
using QT.Moduls.CrawlerProduct;

namespace WSS.Crl.ProducProperties.Core.Tests
{
    [TestFixture()]
    public class MongoAdapterTests
    {
        [Test()]
        public void SavePropertiesTest()
        {
            
            PropertyData pd = new PropertyData();
            pd.Category = "TestCategory";
            pd.ProductId = 0;
            pd.Properties.Add("name", "Test");
            MongoAdapter mongoAdapter = MongoAdapter.Instance();
            mongoAdapter.SaveProperties(pd);
            mongoAdapter.DelPropertyData(pd.ProductId);


        }

        [Test()]
        public void UpdateCategoryIdTest()
        {
            MongoAdapter mongoAdapter = MongoAdapter.Instance();
            mongoAdapter.UpdateCategoryId();
            Thread.Sleep(100000);
        }

        [Test()]
        public void PardataToSql()
        {
            MongoAdapter mongoAdapter = MongoAdapter.Instance();
            mongoAdapter.UpdateCategoryId();
            Thread.Sleep(100000);
        }
    }
}
