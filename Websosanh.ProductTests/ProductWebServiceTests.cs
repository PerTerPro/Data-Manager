using NUnit.Framework;

namespace Websosanh.Product.Tests
{
    [TestFixture()]
    public class ProductWebServiceTests
    {
        [Test()]
        public void ProductWebServiceTest()
        {
            ProductWebService productWebService = new ProductWebService("rabbitMqCrlProperties", "QueueTestPush1", "QueueTestPush2");
            productWebService.PushMqToRedisProduct(100);
            productWebService.PushMqToSoldProduct(100);
        }

    }
}
