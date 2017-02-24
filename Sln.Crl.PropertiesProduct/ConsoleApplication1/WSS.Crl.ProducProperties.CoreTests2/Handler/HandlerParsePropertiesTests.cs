using System.IO;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using NUnit.Framework;
using Telerik.JustMock;
using Telerik.JustMock.Helpers;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.Crl.ProducProperties.Core.Handler;
using WSS.Crl.ProducProperties.Core.Parser;
using WSS.Crl.ProducProperties.Core.Storage;

namespace WSS.Crl.ProducProperties.CoreTests2.Handler
{
    [TestFixture()]
    public class HandlerParsePropertiesTests
    {
        [Test()]
        public void HandlerParsePropertiesTest()
        {
            
        }

        [Test()]
        public void ShoudRunOrderOfLogic()
        {
            var storageHtml = Mock.Create<IStorageHtml>();
            var x1 = new HtmlProduct()
            {
                Domain = "test.vn",
                ProductId = 123,
                Html = File.ReadAllText("DataTest/HtmlProductLazada.html")
            };
            Mock.Arrange(() => storageHtml.GetHtml(Arg.IsAny<long>())).Returns(x1);
            var storagePropertiesProduct = Mock.Create<IStoragePropertiesProduct>();
            Mock.Arrange(() => storagePropertiesProduct.SaveProperiesProduct(Arg.IsAny<PropertyProduct>()));

            var parser = Mock.Create<IParser>();
            Mock.Arrange(() => parser.ParseData(Arg.IsAny<HtmlDocument>())).Returns(new PropertyProduct()
            {
                ProductId = 1
            });

            //Act
            HandlerParseProperties hander = new HandlerParseProperties(storageHtml, storagePropertiesProduct, parser);
            hander.ProcessJob(100);

            //Assert
            Mock.Assert(parser);
            Mock.Assert(storageHtml);
            Mock.Assert(storagePropertiesProduct);
        }
    }
}
