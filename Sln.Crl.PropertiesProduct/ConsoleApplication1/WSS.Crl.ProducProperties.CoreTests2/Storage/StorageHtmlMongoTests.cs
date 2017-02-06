using NUnit.Framework;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.Crl.ProducProperties.Core.Storage;

namespace WSS.Crl.ProducProperties.CoreTests2.Storage
{
    [TestFixture()]
    public class StorageHtmlMongoTests
    {
        [Test()]
        [Ignore]
        public void StorageHtmlMongoTest()
        {
        }

        [Test()]
        [Ignore]
        public void SaveHtmlTest()
        {
            StorageHtmlMongo storage = new StorageHtmlMongo();
            storage.SaveHtml(new HtmlProduct()
            {
                Domain = "test.vn",
                Html = "html test",
                ProductId = 123
            });
        }

        [Test()]
        [Ignore]
        public void DeleteHtmlTest()
        {
            StorageHtmlMongo storage = new StorageHtmlMongo();
            storage.DeleteHtml(123);
        }

        [Test()]
        [Ignore]
        public void GetHtmlTest()
        {
            StorageHtmlMongo storage = new StorageHtmlMongo();
            storage.SaveHtml(new HtmlProduct()
            {
                Domain = "test.vn",
                Html = "html test",
                ProductId = 123
            });

            var productHtml = storage.GetHtml(123);
            Assert.AreEqual(productHtml.Domain, "test.vn");
        }
    }
}
