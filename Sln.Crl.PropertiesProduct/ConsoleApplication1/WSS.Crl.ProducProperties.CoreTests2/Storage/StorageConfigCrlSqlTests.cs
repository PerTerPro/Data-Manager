using NUnit.Framework;
using WSS.Crl.ProducProperties.Core.Storage;

namespace WSS.Crl.ProducProperties.CoreTests2.Storage
{
    [TestFixture()]
    public class StorageConfigCrlSqlTests
    {
        [Test()]
        public void ShouldGetConfigOfLazadaInDbIsNotNull()
        {
            StorageConfigCrl storageConfigCrl = new StorageConfigCrl();
            var config = storageConfigCrl.GetConfig("lazada.vn");
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(config);
            Assert.IsNotNull(config);
            Assert.IsNotNull(json);
        }

        [Test()]
        public void ShouldGetConfigOfAdayroiInDbIsNotNull()
        {
            StorageConfigCrl storageConfigCrl = new StorageConfigCrl();
            var config = storageConfigCrl.GetConfig("adayoi.com");
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(config);
            Assert.IsNotNull(config);
            Assert.IsNotNull(json);
        }
    }
}
