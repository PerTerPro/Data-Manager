using NUnit.Framework;
using WSS.Core.Crawler.CrlProduct;

namespace WSS.Core.CrawlerTests2.CrlProduct
{
    [TestFixture()]
    public class ControlCmpCrlwTests
    {
        [Test()]
        public void PushCmpFnTest()
        {
           ControlCmpCrlw.PushCmp();
        }
    }
}
