using System.Net;
using NUnit.Framework;
using Telerik.JustMock;
using Telerik.JustMock.Helpers;
using WSS.Crl.ProducProperties.Core;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.Crl.ProducProperties.Core.Handler;
using WSS.Crl.ProducProperties.Core.Storage;
using WSS.LibExtra;

namespace WSS.Crl.ProducProperties.CoreTests2.Handler
{
    [TestFixture()]
    public class HandlerDownloadHtmlTests
    {

        [Test()]
        public void ShouldCallSaveHtmlOneTimeAfterDownloadedHtml()
        {
            //Arrange
            WebExceptionStatus w = WebExceptionStatus.Success;
            var downloadHtml = Mock.Create<IDownloadHtml>();
            Mock.Arrange(() => downloadHtml.GetHtml(Arg.AnyString, Arg.AnyInt, Arg.AnyInt, out w)).Returns("<htm>Test</html>");

            var storagHtml =  Mock.Create<IStorageHtml>();
            Mock.Arrange(() => storagHtml.SaveHtml(Arg.IsAny<HtmlProduct>())).OccursAtLeast(1);

            var publisherParse = Mock.Create<IProducerBasic>();
            Mock.Arrange(() => publisherParse.PublishString(Arg.AnyString, Arg.AnyBool, Arg.AnyInt)).OccursOnce();

            var setting = Mock.Create<HandlerDownloadHtml.ISetting>();
            Mock.Arrange(() => setting.Domain).Returns("domain").OccursAtLeast(1);

            //Act
            HandlerDownloadHtml handlerDownloadHtml = new HandlerDownloadHtml(downloadHtml, storagHtml, publisherParse, setting);
            handlerDownloadHtml.ProcessJob(new JobCrlProperties()
            {
                DetailUrl = "test.html",
                Domain = "aha.html",
                ProductId = 0
            });

            //Asert
            Mock.Assert(storagHtml);
        }
    }
}
