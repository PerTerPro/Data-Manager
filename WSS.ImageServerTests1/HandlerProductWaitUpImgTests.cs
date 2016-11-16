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
    public class HandlerProductWaitUpImgTests
    {
        private ILog log = log4net.LogManager.GetLogger(typeof(HandlerProductWaitUpImgTests));

        [TestMethod()]
        public void PostImageToImboServerTest()
        {
            var h = new HandlerProductWaitUpImg();
            h.ProcessJob(new JobProductWaitUpImg()
            {
                ImageUrl = "http://trachannhan.com/image/cache/no_image-600x600.jpg",
                ImgPathOld = "Store/t/trachannhan_com/tra/tra-kim-tien-cao-cap-nha-san-xuat-tan-cuong-thai-nguyen-ma-san-pham-tra-tn-3-tinh-trangcon-hang-gia_187333520648717463.jpg",
                ProductId = 187333520648717463
            });
        }

        [TestMethod()]
        public void ProcessJobTest()
        {
            HandlerDelImgImbo h1 = new HandlerDelImgImbo();
            var h = new HandlerProductWaitUpImg();
            for (int i = 0; i < 10000; i++)
            {
                
                log.Info(i);
            }

        }
    }
}
