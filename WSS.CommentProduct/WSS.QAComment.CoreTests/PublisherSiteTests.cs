using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.QAComment.Core;
using NUnit.Framework;
namespace WSS.QAComment.Core.Tests
{
    [TestFixture()]public class PublisherSiteTests
    {
        [Test()]
        public void PushCompanyDownloadTest()
        {
        
             QT.Entities.Server.ConnectionString = Config.ConnectionSQL;
            var p = new  PublisherSite();
            p.PushCompanyDownload(3502170206813664485); //Lazada

        }
    }
}