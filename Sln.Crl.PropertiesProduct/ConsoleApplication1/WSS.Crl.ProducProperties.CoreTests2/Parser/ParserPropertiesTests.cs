using System.IO;
using GABIZ.Base.HtmlAgilityPack;
using NUnit.Framework;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.Crl.ProducProperties.Core.Parser;

namespace WSS.Crl.ProducProperties.CoreTests2.Parser
{
    [TestFixture()]
    public class ParserPropertiesTests
    {


        [Test()]
        public void ShouldParedForLazadaProduct()
        {
            //string json = File.ReadAllText("DataTest/ConfigLazada.json");
            //ParserProperties parser = new ParserProperties(Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigProperty>(json));
            //string html = File.ReadAllText("DataTest/HtmlProductLazada.html");
            //HtmlDocument htmlDocument =new HtmlDocument();
            //htmlDocument.LoadHtml(html);
            //var productProperty =  parser.ParseData(htmlDocument);
            //Assert.Greater(productProperty.Properties.Count, 1);
        }


        [Test()]
        public void ShouldParedForAdayroiProduct()
        {
            //string json = File.ReadAllText("DataTest/ConfigLazada.json");
            //ParserProperties parser = new ParserProperties(Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigProperty>(json));
            //string html = File.ReadAllText("DataTest/HtmlProductLazada.html");
            //HtmlDocument htmlDocument = new HtmlDocument();
            //htmlDocument.LoadHtml(html);
            //var productProperty = parser.ParseData(htmlDocument);
            //Assert.Greater(productProperty.Properties.Count, 1);
        }
     
    }
}
