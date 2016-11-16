﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImboForm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ImboForm.Tests
{
    [TestClass()]
    public class HandlerProductWaitUpImgTests
    {
        [TestMethod()]
        public void PostImageToImboServerTest()
        {
            HandlerProductWaitUpImg h = new HandlerProductWaitUpImg();
            h.PostImageToImboServer(new JobProductWaitUpImg()
            {
                ImageUrl = "http://trachannhan.com/image/cache/no_image-600x600.jpg",
                ImgPathOld = "Store/t/trachannhan_com/tra/tra-kim-tien-cao-cap-nha-san-xuat-tan-cuong-thai-nguyen-ma-san-pham-tra-tn-3-tinh-trangcon-hang-gia_187333520648717463.jpg",
                ProductId = 187333520648717463
            });
        }
    }
}