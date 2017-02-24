using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Crl.ProducProperties.Core;
using NUnit.Framework;
using QT.Entities;

namespace WSS.Crl.ProducProperties.Core.Tests
{
    [TestFixture()]
    public class HanderDownloadHtmlTests
    {
        [Test()]
        public void ProcessJobTest()
        {
            HanderDownloadHtml hander = new HanderDownloadHtml("adayroi.com");
            hander.ProcessJob(new JobDownloadHtml()
            {
                DetailUrl = @"https://www.adayroi.com/nap-rua-bon-cau-dien-tu-ls-daewon-dib-1500r-p-N6891-f1-2?pi=MYVnp&w=K69N",
                Domain = "adayroi.com",
                ProductId = 50336238657187
            });
        }
    }
}
