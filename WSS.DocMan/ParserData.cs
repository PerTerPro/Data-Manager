using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GABIZ.Base.HtmlAgilityPack;
using QT.Entities;
using HtmlDocument = GABIZ.Base.HtmlAgilityPack.HtmlDocument;

namespace WSS.DocMan
{
    internal class ParserData
    {
        public void Parse(ref Documet document, HtmlDocument doc, string url)
        {
            
            var nodeData = doc.DocumentNode.SelectSingleNode("//table[@class='detailcontent']");
            document.TextDoc = nodeData.InnerText;
            document.HtmlDoc = nodeData.InnerHtml;
            document.Id = Common.CrcProductID(url);
            document.Url = url;
            var nodeDetail =
                doc.DocumentNode.SelectSingleNode(@"//table[@class='detailcontent']//tr/td/div[@align='justify']");
            var nodeParagrap = nodeDetail.SelectNodes(".//p");
            List<Tuple<HtmlNode, List<HtmlNode>, List<String>>> structurtData = new List<Tuple<HtmlNode, List<HtmlNode>, List<String>>>();

            for (int i = 0; i < nodeParagrap.Count; i++)
            {
                var nodeCurrent = nodeParagrap[i];
                var nodeTreeNav = nodeCurrent.SelectSingleNode(".//a[@name]");

                if (nodeTreeNav != null &&
                    nodeTreeNav.GetAttributeValue("name", "").ToLower().StartsWith("chuong_"))
                {
                    Tuple<HtmlNode, List<HtmlNode>, List<String>> newItem = new Tuple<HtmlNode, List<HtmlNode>, List<string>>(nodeParagrap[i],
                        new List<HtmlNode>(), new List<string>());
                    structurtData.Add(newItem);
                }
                else if (structurtData.Count==0 && nodeTreeNav != null &&
                         nodeTreeNav.GetAttributeValue("name", "").ToLower().StartsWith("dieu_"))
                {
                    Tuple<HtmlNode, List<HtmlNode>, List<String>> newItem =
                   new Tuple<HtmlNode, List<HtmlNode>, List<string>>(new HtmlNode(HtmlNodeType.Element, doc, -1),
                       new List<HtmlNode>(), new List<string>());
                    structurtData.Add(newItem);
                }
                else if (structurtData.Count > 0)
                {
                    structurtData[structurtData.Count - 1].Item2.Add(nodeParagrap[i]);
                }
            }
            document.LstStructure = structurtData;
            document.ParseDieu();
        }
    }
}
