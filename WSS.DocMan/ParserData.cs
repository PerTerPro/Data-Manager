using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GABIZ.Base.HtmlAgilityPack;
using log4net;
using QT.Entities;
using QT.Moduls.CrawlerProduct;
using HtmlDocument = GABIZ.Base.HtmlAgilityPack.HtmlDocument;

namespace WSS.DocMan
{
    internal class ParserData
    {
        private ILog logInfo = log4net.LogManager.GetLogger(typeof (ParserData));
        public DocInfo ParseInfoDoc(HtmlDocument doc, string url)
        {
            DocInfo info = new DocInfo();
            var trNodes = doc.DocumentNode.SelectNodes("//table[@class='tableproperties']//tr");
            if (trNodes != null)
            {
                foreach (var VARIABLE in trNodes)
                {
                    var tdNodes = VARIABLE.SelectNodes("./td");
                    if (tdNodes != null)
                    {
                        for (int i = 0; i < tdNodes.Count; i++)
                        {
                            if (tdNodes[i].Attributes.Contains("class") &&
                                tdNodes[i].GetAttributeValue("class", "") == "headerproperties")
                            {
                                if (tdNodes[i + 1].GetAttributeValue("class", "") == "contentproperties")
                                {
                                    string file = tdNodes[i].InnerText.Trim().ToLower();
                                    string properties = tdNodes[i + 1].InnerText.Trim();
                                    ParseData(file, properties, info);
                                }
                            }
                        }
                    }
                }

                return info;
            }
            else
            {
                return null;
            }
        }

        public void ParseData(string nameProperties, string valueProperties, DocInfo docinfo)
        {
            if (nameProperties == "số, ký hiệu")
            {
                docinfo.DocNumber = valueProperties;
            }
            else if (nameProperties == "ngày ban hành")
            {
                docinfo.DatePublish = valueProperties;
            }
            else if (nameProperties == "loại văn bản")
            {
                docinfo.TypeDoc = valueProperties;
            }
            else if (nameProperties == "nguồn trích")
            {
                docinfo.Source = valueProperties;
            }
            else if (nameProperties == "phạm vi")
            {
                docinfo.Scope = valueProperties;
            }
            else if (nameProperties == "ngày đăng công báo")
            {
                docinfo.DatePost = valueProperties;
            }
            else if (nameProperties == "tình trạng hiệu lực")
            {
                docinfo.Enable = valueProperties;
            }
            else if (nameProperties == "ngày có hiệu lực")
            {
                docinfo.DateEnable = valueProperties;
            }
            else if (nameProperties == "ngày hết hiệu lực")
            {
                docinfo.DateNoEnable = valueProperties;
            }
            else if (nameProperties == "lí do hết hiệu lực")
            {
                docinfo.ReasonNoEnable = valueProperties;
            }
            else if (nameProperties == "phần hết hiệu lực")
            {
                docinfo.PartNoEnable = valueProperties;
            }
            else if (nameProperties == "ngày áp dụng")
            {
                docinfo.DateUsed = valueProperties;
            }
            else if (nameProperties == "văn bản dẫn chiếu")
            {
                docinfo.DocRef = valueProperties;
            }
            else if (nameProperties == "văn bản căn cứ")
            {
                docinfo.DocFrom = valueProperties;
            }
            else if (nameProperties == "văn bản bị thay thế")
            {
                docinfo.DocIsReplate = valueProperties;
            }
            else if (nameProperties == "văn bản bị sửa đổi bổ sung")
            {
                docinfo.DocIsAlter = valueProperties;
            }
            else
            {
                logInfo.Info(nameProperties);
            }
        }

        public bool Parse(ref Documet document, HtmlDocument doc, string url)
        {
            bool bOk = true;
            var nodeData = doc.DocumentNode.SelectSingleNode("//table[@class='detailcontent']");
            if (nodeData == null) bOk = false;
            else
            {
                document.TextDoc = nodeData.InnerText;
                document.HtmlDoc = nodeData.InnerHtml;
                document.Id = Common.CrcProductID(url);
                document.Url = url;
                var nodeDetail =
                    doc.DocumentNode.SelectSingleNode(@"//table[@class='detailcontent']//tr/td/div[@align='justify']");
                var nodeParagrap = nodeDetail.SelectNodes(".//p");
                List<Tuple<HtmlNode, List<HtmlNode>, List<String>>> structurtData =
                    new List<Tuple<HtmlNode, List<HtmlNode>, List<String>>>();

                if (nodeParagrap == null) bOk = false;
                else
                {
                    for (int i = 0; i < nodeParagrap.Count; i++)
                    {
                        var nodeCurrent = nodeParagrap[i];
                        var nodeTreeNav = nodeCurrent.SelectSingleNode(".//a[@name]");

                        if (nodeTreeNav != null &&
                            nodeTreeNav.GetAttributeValue("name", "").ToLower().StartsWith("chuong_"))
                        {
                            Tuple<HtmlNode, List<HtmlNode>, List<String>> newItem =
                                new Tuple<HtmlNode, List<HtmlNode>, List<string>>(nodeTreeNav,
                                    new List<HtmlNode>(), new List<string>());
                            structurtData.Add(newItem);
                        }
                        else if (structurtData.Count == 0 && nodeTreeNav != null &&
                                 nodeTreeNav.GetAttributeValue("name", "").ToLower().StartsWith("dieu_"))
                        {
                            Tuple<HtmlNode, List<HtmlNode>, List<String>> newItem =
                                new Tuple<HtmlNode, List<HtmlNode>, List<string>>(
                                    new HtmlNode(HtmlNodeType.Element, doc, -1),
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
            return bOk;
        }
    }
}
