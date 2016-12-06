using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImboForm;
using log4net;
using NUnit.Framework;
using WSS.ImageServer;
namespace WSS.ImageServer.Tests
{
    [TestFixture()]
    public class ImboImageServiceTests
    {
        [Test()]
        public void CallThumbTest()
        {
            ImboImageService.CallThumb("WKSHOovrY7h7", new List<Tuple<int, int>>
            {new Tuple<int, int>(200,200)
            });
        }
    }
}

namespace ImboForm.Tests
{
    [TestFixture()]
    public class ImboImageServiceTests
    {
        private ILog log = LogManager.GetLogger(typeof (ImboImageService));
        [Test()]
        public void PushFromFileTest()
        {
            DateTime dtStart = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                string imgId = ImboImageService.PushFromFile("wss", "123websosanh@195", "test.jpg", "wss", @"http://172.22.1.226");

                if (i % 100 == 0)
                {
                    log.Info(string.Format("{0} {1} => item/s {2}", i, imgId, i / (DateTime.Now - dtStart).TotalSeconds));
                }
            }
        }

        [Test()]
        public void DeleteImgById()
        {
       
        }

        [Test()]
        public void CallThumbTest()
        {
            ImboImageService.CallThumb("Q_ty6yrQ8OE4", new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(200, 200),
                new Tuple<int, int>(78, 78),
                new Tuple<int, int>(50, 50),
                new Tuple<int, int>(45, 45)
            });
        }
    }
}
