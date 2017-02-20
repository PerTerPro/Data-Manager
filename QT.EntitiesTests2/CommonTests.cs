using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;
using NUnit.Framework;
namespace QT.Entities.Tests
{
    [TestFixture()]
    public class CommonTests
    {
        [Test()]
        public void ShouldPostForImageWIthTransference()
        {
            string url = @"http://nobacks.com/wp-content/uploads/2014/11/Peach-50-500x329.png";
            string x = Common.DownloadImageProductWithImboServer(url, "wss_write", "123websosanh@195", "wss", @"https://172.22.1.226", 443);
            Assert.Greater(x.Length, 10);
        }

        [Test()]
        public void ShouldPostForImageWIthNormalTransference()
        {
            string url = @"http://eva-img.24hstatic.com/upload/1-2017/images/2017-02-11/truongthienaitranankieu_langsao_eva--1--1486832250-width650height860.jpg";
            string x = Common.DownloadImageProductWithImboServer(url, "wss_write", "123websosanh@195", "wss", @"https://172.22.1.226", 443);
            Assert.Greater(x.Length, 10);
        }
        
    }
}
