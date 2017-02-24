//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using GABIZ.Base.HtmlAgilityPack;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using GABIZ.Base;
//using WSS.Crl.ProducProperties.Core.Entity;
//using WSS.Crl.ProducProperties.Core.Parser;
//using WSS.LibExtra;

//namespace WSS.Crl.ProducProperties.Core
//{
//    public class ParseNormal : IParser
//    {
//        private readonly ConfigProperty _configPropertyNomal = null;

//        public ParseNormal(ConfigProperty confif)
//        {
//            this._configPropertyNomal = confif;
//        }

//        public PropertyProduct ParseData(HtmlDocument document)
//        {
//            PropertyProduct propertyData = new PropertyProduct();
//            propertyData.Category = ParseCategory(_configPropertyNomal.CategoryXPath, "", document);
//            propertyData.Domain = _configPropertyNomal.Domain;
//            propertyData.CategoryId = CommonConvert.CrcProductID(propertyData.Category);
//            var nodeRows = document.DocumentNode.SelectNodes(_configPropertyNomal.XPath);
//            dynamic configOtherData = JObject.Parse(_configPropertyNomal.JSonOtherConfig);
//            string colH = configOtherData.IndexColHeader.ToString();
//            string colB = configOtherData.IndexColData.ToString();
//            if (nodeRows != null)
//            {
//                foreach (var variable in nodeRows)
//                {
//                    var nodeCell = variable.SelectNodes("./td");
//                    if (nodeCell != null)
//                    {
//                        try
//                        {
//                            propertyData.Properties.Add(
//                                nodeCell[Convert.ToInt32(colH)].InnerText.Trim(),
//                                nodeCell[Convert.ToInt32(colB)].InnerText.Trim());
//                        }
//                        catch (Exception ex)
//                        {
//                        }
//                    }

//                }
//            }
//            return propertyData;
//        }
//        private string ParseCategory(string xpaths, string detailUrl, HtmlDocument doc)
//        {
//            var categories = new List<string> {this._configPropertyNomal.Domain};
//            if (xpaths != "")
//            {
//                var nodeCategories = doc.DocumentNode.SelectNodes(xpaths);
//                if (nodeCategories != null)
//                {
//                    int K = nodeCategories.Count;
//                    for (int i = 0; i < K; i++)
//                    {
//                        string s =
//                            Tools.removeHTML(nodeCategories[i].InnerText)
//                                .Trim(new char[] {' ', '-', '»', '>', '<'});
//                        if (!categories.Contains(s) && s.ToLower().Trim() != "trang chủ")
//                        {
//                            categories.Add(s.Trim());
//                        }
//                    }
//                }
//            }
//            if (this._configPropertyNomal.RemoveLastItemClassification && categories.Count > 1)
//            {
//                categories.RemoveAt(categories.Count - 1);
//            }
//            return string.Join(">", categories).Trim().ToLower();
//        }


//        public void Init(string domain)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
