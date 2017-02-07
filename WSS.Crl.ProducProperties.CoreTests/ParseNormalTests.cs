using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using WSS.Crl.ProducProperties.Core;
using NUnit.Framework;
using System.IO;
using log4net.Util;

namespace WSS.Crl.ProducProperties.Core.Tests
{
    [TestFixture()]
    public class ParseNormalTests
    {
        [Test()]
        public void ParseNormal_Adayroi_Test()
        {
            ProductPropertiesAdapter ppa = new ProductPropertiesAdapter();
            var x = ppa.GetConfig(3433481253691794480);
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(System.Web.HttpUtility.HtmlDecode(File.ReadAllText("TestData/Adayroi.html")));
            ParseNormal parseNormal = new ParseNormal(x);
            var productPropertis = parseNormal.ParseData(htmlDocument);
            string str = productPropertis.GetJSonDisplay();
            Assert.IsNotNullOrEmpty(str);
        }

        

       [Test()]
        public void ParseNormal_Adayroi_1_Test()
       {
           string str1 = "https://www.adayroi.com/nap-rua-bon-cau-dien-tu-ls-daewon-dib-1500r-p-N6891-f1-2?pi=MYVnp&w=K69N";
            ProductPropertiesAdapter ppa = new ProductPropertiesAdapter();
            var x = ppa.GetConfig(3433481253691794480);
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(System.Web.HttpUtility.HtmlDecode(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(str1, 45, 2)));
            ParseNormal parseNormal = new ParseNormal(x);
            var productPropertis = parseNormal.ParseData(htmlDocument);
            string str = productPropertis.GetJSonDisplay();
            Assert.IsNotNullOrEmpty(str);
        }

        [Test()]
        public void ParseNormal_Lazada_Test()
        {
            ProductPropertiesAdapter ppa = new ProductPropertiesAdapter();
            var x = ppa.GetConfig(3502170206813664485);
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(System.Web.HttpUtility.HtmlDecode(File.ReadAllText("TestData/Lazada.html")));
            ParseNormal parseNormal = new ParseNormal(x);
            var productPropertis = parseNormal.ParseData(htmlDocument);
            string str = productPropertis.GetJSonDisplay();
            Assert.IsNotNullOrEmpty(str);
        }

        [Test()]
        public void ParseNormal_Tiki_Test()
        {
            ProductPropertiesAdapter ppa = new ProductPropertiesAdapter();
            var x = ppa.GetConfig(2642071820174507179);
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(System.Web.HttpUtility.HtmlDecode(File.ReadAllText("TestData/Tiki.html")));
            ParseNormal parseNormal = new ParseNormal(x);
            var productPropertis = parseNormal.ParseData(htmlDocument);
            string str = productPropertis.GetJSonDisplay();
            Assert.IsNotNullOrEmpty(str);
        }


    }
}
