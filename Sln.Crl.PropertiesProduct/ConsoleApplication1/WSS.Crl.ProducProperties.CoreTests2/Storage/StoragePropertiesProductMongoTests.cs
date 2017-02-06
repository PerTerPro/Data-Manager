using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using WSS.Crl.ProducProperties.Core;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.Crl.ProducProperties.Core.Storage;

namespace WSS.Crl.ProducProperties.CoreTests2.Storage
{
    [TestFixture()]
    public class StoragePropertiesProductMongoTests
    {
        [SetUp]
        public void Settup()
        {
            
        }

        [Test()]
        [Ignore]
        public void SaveProperiesProductTest()

        {
            StoragePropertiesProductMongo spp = new StoragePropertiesProductMongo();
            spp.SaveProperiesProduct(new PropertyProduct()
            {
                Category = "category_test",
                CompanyID = 123,
                Domain = "test.vn",
                ProductId = 1234,
                LastModified = DateTime.Now,
                Url = "test.vn.url",
                Properties = new Dictionary<string, string>()
                {
                    {"key_test", "value_test"}
                }
            });
        }

        [Test()]
        [Ignore]
        public void GetProperiesProductTest()
        {
            StoragePropertiesProductMongo spp = new StoragePropertiesProductMongo();
            var x = spp.GetProperiesProduct(12346);
            var y = x.Result;

        }

        [Test()]
        [Ignore]
        public void DelProperiesProductTest()
        {
            StoragePropertiesProductMongo spp = new StoragePropertiesProductMongo();
            spp.DelProperiesProduct(1234);
        }
    }
}
