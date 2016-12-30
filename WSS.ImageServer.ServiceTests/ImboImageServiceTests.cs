using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImboForm;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ImboForm.Tests
{
    [TestClass()]
    public class ImboImageServiceTests
    {
        private ILog log = LogManager.GetLogger(typeof (ImboImageService));
        [TestMethod()]
        public void PushFromFileTest()
        {
            DateTime dtStart = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                string imgId = ImboImageService.PushFromFile("wss", "123websosanh@195", "test.jpg", "wss", @"http://172.22.1.226");

                if (i%100 == 0)
                {
                    log.Info(string.Format("{0} {1} => item/s {2}", i, imgId, i/(DateTime.Now - dtStart).TotalSeconds));
                }
            }
        }
    }
}
