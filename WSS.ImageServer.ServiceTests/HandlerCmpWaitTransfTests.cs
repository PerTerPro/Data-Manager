using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImboForm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSS.ImageServer;

namespace ImboForm.Tests
{
    [TestClass()]
    public class HandlerCmpWaitTransfTests
    {
        [TestMethod()]
        public void PushDownloadImageByCompanyTest()
        {
            HandlerCmpWaitTransf h = new HandlerCmpWaitTransf();
            h.PushDownloadImageByCompany(3261647328632530363, 1);
        }
    }
}
