using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QT.Moduls.CrawlerProduct.Service;
using NUnit.Framework;
namespace QT.Moduls.CrawlerProduct.Service.Tests
{
    [TestFixture()]
    public class WorkerChangePriceToHistoryPriceSqlUiTests
    {
        [Test()]
        public void WorkerChangePriceToHistoryPriceSqlUiTest()
        {
            WorkerChangePriceToHistoryPriceSqlUi w = new WorkerChangePriceToHistoryPriceSqlUi(new CancellationToken());
            w.Start();

        }
    }
}
