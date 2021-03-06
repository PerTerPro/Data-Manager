﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
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
                string imgId = ImboImageService.PushFromFile("wss_write", "123websosanh@195", @"C:\Image\y\yes24_vn\nuo\nuoc-hoa-nu-ines-de-la-fressange-eau-de-parfum-100ml-vang_6619017604755523100.jpg",
                    "landingpage", ConfigImbo.Host, ConfigImbo.Port);

                if (i % 100 == 0)
                {
                    log.Info(string.Format("{0} {1} => item/s {2}", i, imgId, i / (DateTime.Now - dtStart).TotalSeconds));
                }
            }
        }

        [Test()]
        public void PushFromFileTest1()
        {
            DateTime dtStart = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                string imgId = ImboImageService.PushFromFile("wss_write", "123websosanh@195", @"C:\Users\xuantrang\Downloads\12112320_539716226194750_3703686762757153458_n.jpg", "landingpage",
                    "http://192.168.100.34", 40000);

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
