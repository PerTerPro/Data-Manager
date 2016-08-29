using System;
using log4net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using GABIZ.Base;
using QT.Entities.Data;
using System.Globalization;
using System.Net;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using QT.Entities.Model.SaleNews;

namespace QT.Entities.RaoVat
{
    public class HandlerContentOfHtml
    {
        LogErrorToDb logErrorDb = LogErrorToDb.Instance;
        private static readonly ILog log = LogManager.GetLogger(typeof(HandlerContentOfHtml));

        /// <summary>
        /// 1. ProductNameXPath empty
        /// 2. ParseXPathName   empty
        /// -1. Exception
        /// 0 . Success full
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="uri"></param>
        /// <param name="configXPath"></param>
        /// <param name="domain"></param>
        /// <param name="checkPrice"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        ///
        public int Analytics(HtmlDocument doc, string uri
            , Configuration configXPath
            , string domain, bool checkPrice
            , ref Product product)
        {

            product.RootUri = new Uri(uri);
            product.DetailUrl = uri;
            product.ID = Common.GetIDProduct(uri);
            try
            {
                product.Name = "";
                if (configXPath.ProductNameXPath == null || configXPath.ProductNameXPath.Count == 0)
                {
                    log.Info("Analytics. Not config XPath name for " + uri);
                    return 1;
                }
                else
                {
                    product.Name = ParseXPathName(doc, configXPath);
                    if (string.IsNullOrWhiteSpace(product.Name))
                    {
                        log.Info("Analytics.Can't parse XPathName from:" + uri);
                        return 2;
                    }
                    product.Price = ParsePrice(doc, configXPath, uri, checkPrice);
                    product.VATInfo = ParseXPathVATInfo(doc, configXPath);
                    product.PromotionInfo = ParseXPathPromotionInfo(doc, configXPath);
                    product.Warranty = ParseXPathWarranty(doc, configXPath);
                    product.Status = ParseXPathStatus(doc, configXPath);
                    product.ProductContent = ParseXPathContent(doc, configXPath);
                    product.Summary = ParseXPathSummry(doc, configXPath);
                    product.ImageUrls = ParseImage(doc, configXPath, product.RootUri);
                    product.Manufacture = ParseManufacture(doc, configXPath);
                    product.Origin = ParseOrigrin(doc, configXPath);
                    product.Promotion = ParsePromotion(doc, configXPath);
                    product.Categories = ParseCategories(doc, configXPath, domain, product.BlBackCategory);
                    product.IDCategories = Common.GetIDClassification(Common.ConvertToString(product.Categories, " -> "));
                    product.HashName = Common.GetHashNameProduct(domain, product.Name.Trim());
                    product.Price = ParsePrice(doc, configXPath, uri, checkPrice);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                return -1;
            }
            return 0;
        }




        private List<string> ParseCategories(HtmlDocument doc, Configuration configXPath, string domain, IEnumerable<string> lstBlackCategories)
        {
            List<string> lstCategories = new List<string>();
            lstCategories.Add(domain);
            for (int p = 0; p < configXPath.CategoryXPath.Count; p++)
            {
                if (configXPath.CategoryXPath[p].Trim() != "")
                {
                    var node_categories = doc.DocumentNode.SelectNodes(configXPath.CategoryXPath[p]);
                    if (node_categories != null)
                    {
                        int K = node_categories.Count;
                        for (int i = 0; i < K; i++)
                        {
                            string s = GABIZ.Base.Tools.removeHTML(node_categories[i].InnerText).Trim(new char[] { ' ', '-', '»', '>', '<' });
                            if (!lstCategories.Contains(s))
                                if (!lstCategories.Contains(s.ToLower()))
                                    lstCategories.Add(s);
                        }
                    }
                }
            }
            return lstCategories;
        }


        public int ParsePrice(HtmlDocument doc, Configuration configXPath, string i_uri, bool checkPrice)
        {
            int price = 0;
            Uri uri = new Uri(i_uri);
            switch (uri.DnsSafeHost)
            {
                case "mediamart.vn":
                    int priceOld = 0, priceGiam = 0;
                    if (configXPath.PriceXPath.Count == 2)
                    {
                        if (configXPath.PriceXPath[0].Trim() != "")
                        {
                            var node_price = doc.DocumentNode.SelectNodes(configXPath.PriceXPath[0]);
                            if (node_price != null)
                            {
                                int K = node_price.Count;
                                for (int j = 0; j < K; j++)
                                {
                                    string s = GABIZ.Base.Tools.removeHTML(node_price[j].InnerText);
                                    priceOld = Common.ParsePrice(s, checkPrice);
                                }
                            }
                        }
                        if (configXPath.PriceXPath[1].Trim() != "")
                        {
                            var node_price = doc.DocumentNode.SelectNodes(configXPath.PriceXPath[1]);
                            if (node_price != null)
                            {
                                int K = node_price.Count;

                                for (int j = 0; j < K; j++)
                                {
                                    string s = GABIZ.Base.Tools.removeHTML(node_price[j].InnerText);
                                    priceGiam = Common.ParsePrice(s, checkPrice);
                                }
                            }
                        }
                    }
                    price = priceOld - priceGiam;
                    break;
                default:
                    {
                        for (int i = 0; i < configXPath.PriceXPath.Count; i++)
                        {
                            if (configXPath.PriceXPath[i].Trim() != "")
                            {
                                var node_price = doc.DocumentNode.SelectNodes(configXPath.PriceXPath[i]);
                                if (node_price != null)
                                {
                                    foreach (var aNodePrice in node_price)
                                    {
                                        string s = GABIZ.Base.Tools.removeHTML(aNodePrice.InnerText);
                                        int v = Common.ParsePrice(s, checkPrice);
                                        if (v != -1)
                                        {
                                            price = v;
                                            break;
                                        }
                                    }
                                    if (price > 0) break;
                                }
                            }
                        }
                    }
                    break;
            }
            return price;
        }

        public int ParsePrice(HtmlDocument doc, IList<string> configXPath, string i_uri, bool checkPrice)
        {
            int price = 0;
            Uri uri = new Uri(i_uri);
            switch (uri.DnsSafeHost)
            {
                case "mediamart.vn":
                    int priceOld = 0, priceGiam = 0;
                    if (configXPath.Count == 2)
                    {
                        if (configXPath[0].Trim() != "")
                        {
                            var node_price = doc.DocumentNode.SelectNodes(configXPath[0]);
                            if (node_price != null)
                            {
                                int K = node_price.Count;
                                for (int j = 0; j < K; j++)
                                {
                                    string s = GABIZ.Base.Tools.removeHTML(node_price[j].InnerText);
                                    priceOld = Common.ParsePrice(s, checkPrice);
                                }
                            }
                        }
                        if (configXPath[1].Trim() != "")
                        {
                            var node_price = doc.DocumentNode.SelectNodes(configXPath[1]);
                            if (node_price != null)
                            {
                                int K = node_price.Count;

                                for (int j = 0; j < K; j++)
                                {
                                    string s = GABIZ.Base.Tools.removeHTML(node_price[j].InnerText);
                                    priceGiam = Common.ParsePrice(s, checkPrice);
                                }
                            }
                        }
                    }
                    price = priceOld - priceGiam;
                    break;
                default:
                    {
                        for (int i = 0; i < configXPath.Count; i++)
                        {
                            if (configXPath[i].Trim() != "")
                            {
                                var node_price = doc.DocumentNode.SelectNodes(configXPath[i]);
                                if (node_price != null)
                                {
                                    foreach (var aNodePrice in node_price)
                                    {
                                        string s = GABIZ.Base.Tools.removeHTML(aNodePrice.InnerText);
                                        int v = Common.ParsePrice(s, checkPrice);
                                        if (v != -1)
                                        {
                                            price = v;
                                            break;
                                        }
                                    }
                                    if (price > 0) break;
                                }
                            }
                        }
                    }
                    break;
            }
            return price;
        }

        private string ParsePromotion(HtmlDocument doc, Configuration configXPath)
        {
            string promotion = "";
            //get PromotionXpath
            if (configXPath.PromotionXPath != null && configXPath.PromotionXPath.Count > 0)
            {
                for (int i = 0; i < configXPath.PromotionXPath.Count; i++)
                {
                    if (configXPath.PromotionXPath[i].Trim() != "")
                    {
                        var node = doc.DocumentNode.SelectSingleNode(configXPath.PromotionXPath[i]);
                        if (node != null)
                        {
                            promotion = node.InnerHtml.Trim();
                        }
                        break;
                    }
                }
            }
            return promotion;
        }

        private string ParseOrigrin(HtmlDocument doc, Configuration configXPath)
        {
            string str = "";
            if (configXPath.OriginXPath != null)
                for (int i = 0; i < configXPath.OriginXPath.Count; i++)
                {
                    if (configXPath.OriginXPath[i].Trim() != "")
                    {
                        var node_Manufacture = doc.DocumentNode.SelectSingleNode(configXPath.OriginXPath[i]);
                        if (node_Manufacture != null)
                        {
                            str = GABIZ.Base.Tools.removeHTML(node_Manufacture.InnerText).TrimEnd(new char[] { '-', ' ', '>' });
                        }
                    }
                }
            return str;
        }

        private string ParseManufacture(HtmlDocument doc, Configuration configXPath)
        {
            string str = "";
            for (int i = 0; i < configXPath.ManufactureXPath.Count; i++)
            {
                if (configXPath.ManufactureXPath[i].Trim() != "")
                {
                    var node_Manufacture = doc.DocumentNode.SelectSingleNode(configXPath.ManufactureXPath[i]);
                    if (node_Manufacture != null)
                    {
                        str = GABIZ.Base.Tools.removeHTML(node_Manufacture.InnerText).TrimEnd(new char[] { '-', ' ', '>' });
                    }
                }
            }
            return str;
        }

        private List<string> ParseImage(HtmlDocument doc, Configuration configXPath, Uri rootUri)
        {
            List<string> lst = new List<string>();
            for (int i = 0; i < configXPath.ImageXPath.Count; i++)
            {
                if (configXPath.ImageXPath[i].Trim() != "")
                {
                    var node_image = doc.DocumentNode.SelectNodes(configXPath.ImageXPath[i]);
                    if (node_image != null)
                    {
                        for (int j = 0; j < node_image.Count; j++)
                        {
                            List<string> _imgUrl = Common.ParseImage(node_image[j].OuterHtml, rootUri, configXPath.ImageGetFromRoot);
                            lst.AddRange(_imgUrl);
                        }
                        lst = lst.Distinct().ToList();
                    }
                }
            }
            return lst;
        }

        private string ParseXPathSummry(HtmlDocument doc, Configuration configXPath)
        {
            string str = "";
            //get SummaryXpath
            if (configXPath.SummaryXPath != null && configXPath.SummaryXPath.Count > 0)
                for (int i = 0; i < configXPath.SummaryXPath.Count; i++)
                {
                    if (configXPath.SummaryXPath[i].Trim() != "")
                    {
                        var node = doc.DocumentNode.SelectSingleNode(configXPath.SummaryXPath[i]);
                        if (node != null)
                        {
                            str = Common.ChuanHoaContent(node.InnerHtml.Trim());
                        }
                    }
                    break;
                }
            return str;
        }

        private string ParseXPathContent(HtmlDocument doc, Configuration configXPath)
        {
            string str = "";
            if (configXPath.ContentXPath != null && configXPath.ContentXPath.Count > 0)
            {
                for (int i = 0; i < configXPath.ContentXPath.Count; i++)
                {
                    if (configXPath.ContentXPath[i].Trim() != "")
                    {
                        var node = doc.DocumentNode.SelectSingleNode(configXPath.ContentXPath[i]);
                        if (node != null)
                        {
                            str = Common.ChuanHoaContent(node.InnerHtml.Trim());
                        }
                    }
                    break;
                }
            }
            return str;
        }

        private Common.ProductStatus ParseXPathStatus(HtmlDocument doc, Configuration configXPath)
        {
            Common.ProductStatus a = Common.ProductStatus.Available;
            for (int i = 0; i < configXPath.StatusXPath.Count; i++)
            {
                if (configXPath.StatusXPath[i].Trim() != "")
                {
                    var node_status = doc.DocumentNode.SelectSingleNode(configXPath.StatusXPath[i]);
                    if (node_status != null)
                    {
                        string s_s = GABIZ.Base.Tools.removeHTML(node_status.InnerText);
                        //a = Common.ParseStatus(s_s);
                        if (a != Common.ProductStatus.NotDefine)
                            break;
                    }
                }
            }
            return a;
        }

        private int ParseXPathWarranty(HtmlDocument doc, Configuration configXPath)
        {
            int warrayty = 0;
            for (int i = 0; i < configXPath.WarrantyXPath.Count; i++)
            {
                if (configXPath.WarrantyXPath[i].Trim() != "")
                {
                    var node_warranty = doc.DocumentNode.SelectSingleNode(configXPath.WarrantyXPath[i]);
                    if (node_warranty != null)
                    {
                        string s_w = GABIZ.Base.Tools.removeHTML(node_warranty.InnerText);
                        int v_w = Common.ParseWarranty(s_w);
                        if (v_w != -1)
                        {
                            warrayty = v_w;
                            break;
                        }
                    }
                }
            }
            return warrayty;
        }

        private string ParseXPathPromotionInfo(HtmlDocument doc, Configuration configXPath)
        {
            string strResult = "";
            try
            {
                foreach (string PromotionInfoXPath in configXPath.PromotionInfoXPath)
                {
                    if (PromotionInfoXPath.Trim() != "")
                    {
                        var node_VAT = doc.DocumentNode.SelectSingleNode(PromotionInfoXPath);
                        if (node_VAT != null)
                        {
                            string tempPromotion = GABIZ.Base.Tools.removeHTML(node_VAT.InnerText);
                            if (Common.ParsePromotionInfo(tempPromotion) != -1)
                            {
                                strResult = (string.IsNullOrEmpty(strResult) ? "" : " ") + tempPromotion;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return strResult;
        }

        private string ParseXPathVATInfo(HtmlDocument doc, Configuration configXPath)
        {
            string strVAT = "";
            try
            {
                foreach (string VATInfoXPath in configXPath.VATInfoXPath)
                {
                    if (VATInfoXPath.Trim() != "")
                    {
                        var node_VAT = doc.DocumentNode.SelectSingleNode(VATInfoXPath);
                        if (node_VAT != null)
                        {
                            string tempVAT = GABIZ.Base.Tools.removeHTML(node_VAT.InnerText);
                            if (Common.ParseVATInfo(tempVAT) != -1)
                            {
                                strVAT += (string.IsNullOrEmpty(strVAT) ? "" : " ") + tempVAT;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return strVAT;
        }

        private string ParseXPathName(HtmlDocument doc, Configuration configXPath)
        {
            string strName = "";
            for (int i = 0; i < configXPath.ProductNameXPath.Count; i++)
            {
                if (configXPath.ProductNameXPath[i].Trim() != "")
                {
                    var node_productName = doc.DocumentNode.SelectSingleNode(configXPath.ProductNameXPath[i]);
                    if (node_productName != null)
                    {
                        var TempName = GABIZ.Base.Tools.removeHTML(node_productName.InnerText).Trim();
                        strName += (string.IsNullOrEmpty(strName) ? "" : " ") + Common.ParseName(TempName);
                    }
                }
            }
            return strName;
        }

        public static bool HandleReloadProduct(Product product, Configuration configurationCrawler)
        {
            if (product == null)
            {
                log.Error("Product from message is null");
                return true;
            }
            else if (configurationCrawler == null)
            {
                log.Error("Configuration from message is null");
                return true;
            }

            GABIZ.Base.HtmlAgilityPack.HtmlWeb web = new GABIZ.Base.HtmlAgilityPack.HtmlWeb();
            HtmlDocument doc = web.Load(product.DetailUrl);
            if (doc == null)
            {
                log.Error("Coundn't load web from:" + product.DetailUrl);
                return true;
            }
            else
            {
                Product pt = new Product();
                (new HandlerContentOfHtml()).Analytics(doc, product.DetailUrl, configurationCrawler, product.Domain, true, ref pt);
                return true;
            }
        }



        private string GetProvince(HtmlDocument document, ConfigXPaths configXPath)
        {
            try
            {
                List<string> lst = configXPath.ProvinceXPaths;
                if (lst != null && lst.Count > 0)
                {
                    foreach (string str in lst)
                    {
                        string strText = Common.ChuanHoaUnicode(Common.GetTextOfXPath(document, lst[0], true));
                        if (!string.IsNullOrEmpty(strText))
                        {
                            return strText;
                        }
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Exception:{0}", ex.Message);
                return "";
            }
        }

        private DateTime GetLastChange(string url, HtmlDocument document, ConfigXPaths configXPath)
        {
            return ParseDate(url, document, configXPath.ID, configXPath.LastChangeXPaths);
        }

        private DateTime GetPostDate(string url, HtmlDocument document, ConfigXPaths configXPath)
        {
            return ParseDate(url, document, configXPath.ID, configXPath.last_edit_xpaths);
        }

        private DateTime ParseDate(string url, HtmlDocument document, int configXPathID, List<string> list)
        {
            try
            {
                List<string> xpaths = list;
                if (xpaths != null && xpaths.Count > 0)
                {
                    foreach (string xPath in xpaths)
                    {
                        //Dạng chuẩn: "dd/MM/yyy hh:mm"
                        var textDates = Common.GetTextInNode(document, xPath);
                        foreach (var a in textDates)
                        {
                            string strOriginData = Common.ChuanHoaUnicode(a);
                            strOriginData = strOriginData.Replace("at", " ");
                            strOriginData = strOriginData.ToLower();
                            strOriginData = Common.ChangeSpaceCharacter(strOriginData);
                            strOriginData = Common.RemoveDumplicateSpace(strOriginData);
                            strOriginData = strOriginData.Replace(@"-", @"/");
                            if (!(string.IsNullOrEmpty(strOriginData)))
                            {
                                DateTime dtParse = Common.ParseDateTime(strOriginData);
                                if (dtParse != SqlDb.MinDateDb) return dtParse;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.logErrorDb.SaveError(LogErrorToDb.errorParsePostDate, url, configXPathID, ex.Message);
            }
            return SqlDb.MinDateDb;
        }

        public string GetContent(string url, HtmlDocument document, ConfigXPaths configXPath)
        {
            try
            {
                string strResult = "";
                List<string> lst = configXPath.ContentXPaths;
                if (lst != null && lst.Count > 0)
                {
                    foreach (string xPath in lst)
                    {
                        List<string> lstTitle = Common.GetTextInNode(document, xPath, configXPath);
                        strResult += Common.ConvertToString(lstTitle, " ");
                    }
                }
                return Common.ChuanHoaUnicode(strResult);
            }
            catch (Exception ex)
            {
                logErrorDb.SaveError(LogErrorToDb.errorParseContent, url, configXPath.ID, ex.Message);
                return "";
            }
        }

        private decimal GetPriceSaleNew(string url, HtmlDocument document, ConfigXPaths configXPath, out string currency)
        {
            try
            {
                currency = "";
                List<string> lst = configXPath.PriceXPaths;
                if (lst != null && lst.Count > 0)
                {
                    foreach (string xPath in lst)
                    {
                        var node = document.DocumentNode.SelectSingleNode(xPath);
                        if (node != null)
                        {
                            string textPrice = Common.RemoveDumplicateSpace(Common.ChuanHoaUnicode(node.InnerText)).Trim().ToLower();
                            if (textPrice.Contains("usd")) currency = "usd";
                            else if (textPrice.Contains("vnd") || textPrice.Contains("đ")) currency = "vnd";

                            if (!string.IsNullOrWhiteSpace(textPrice))
                            {
                                if (textPrice == "liên hệ báo giá")
                                    return 0;
                                if (Regex.IsMatch(textPrice, @"giá\s*:\s*[\d\,\.]*"))
                                {
                                    textPrice = Regex.Match(textPrice, @"giá\s*:\s*[\d\,\.]*").Captures[0].Value.ToString();
                                    textPrice = textPrice.Replace("giá:", "").Trim();
                                }
                                else if (Regex.IsMatch(textPrice, @"giá\s*\d*\s*k"))
                                {
                                    textPrice = Regex.Match(textPrice, @"giá\s*\d*\s*k").Captures[0].Value.ToString();
                                    textPrice = textPrice.Replace("giá", "").Trim();
                                    currency = "vnd";
                                }
                                if (textPrice.StartsWith("-")) textPrice = textPrice.Remove(0, 1).Trim();

                                //(~ 25,306 usd )
                                if (Regex.IsMatch(textPrice, @"[\d\,\.]* usd"))
                                {
                                    textPrice = Regex.Match(textPrice, @"[\d\,\.]* usd").Captures[0].Value.ToString().Replace("usd", "").Trim();
                                    textPrice = textPrice.Replace("giá:", "").Trim();
                                }

                                decimal price = Common.ParsePriceLong(textPrice, true);
                                if (price > 0) return price;
                            }
                        }
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                this.logErrorDb.SaveError(LogErrorToDb.errorParsePrice, url, configXPath.ID, ex.Message);
                currency = "";
                return 0;
            }
        }

        private string GetTitleSaleNew(string url, HtmlDocument document, ConfigXPaths configXPath)
        {
            try
            {
                foreach (var xPath in configXPath.TitleXPaths)
                {
                    HtmlNodeCollection a = document.DocumentNode.SelectNodes(xPath);
                    if (a != null && a.Count > 0 && a[0].InnerText != "")
                    {
                        string result = a[0].InnerText;
                        result = Regex.Replace(result, "\n|\t|\r", " ");
                        return Common.RemoveDumplicateSpace(result).Trim();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                this.logErrorDb.SaveError(LogErrorToDb.errorParseTitleProduct, url, configXPath.ID, ex.Message);
                return "";
            }
        }


        /// <summary>
        /// Nhân diện category_ids của tin
        /// 1 phần tử có dạng: Regex:Int.
        /// Ví dụ: *.ô tô.*:9
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="lstRegexToInt"></param>
        /// <param name="WebCategory"></param>
        /// <param name="doc"></param>
        /// <returns></returns>
        public int[] RecognizeCategory(string url, ConfigXPaths config
            , string WebCategory, int defaultReturn = 0
            , bool breakFirstFind = true)
        {
            List<int> lstResult = new List<int>();
            try
            {

                int iCat = 0;
                List<string> lstRegexToInt = config.RegexStringToCategory;
                if (lstRegexToInt != null && lstRegexToInt.Count > 0)
                {
                    foreach (string aRule in lstRegexToInt)
                    {
                        if (aRule.Contains(":"))
                        {
                            string[] regexs = aRule.Split(new char[] { ':' });
                            if (regexs.Length > 1)
                            {
                                if (Regex.IsMatch(WebCategory, regexs[0]))
                                {
                                    //Khớp mẫu => Lấy danh sách.
                                    string[] data = regexs[1].Split(new char[] { ',' }, 100, StringSplitOptions.RemoveEmptyEntries);
                                    foreach (var item in data)
                                    {
                                        if (Int32.TryParse(item, out iCat))
                                        {
                                            lstResult.Add(iCat);
                                        }
                                    }
                                    if (breakFirstFind) break;
                                }
                            }
                        }
                    }
                }
                return lstResult.ToArray();
            }
            catch (Exception ex)
            {
                this.logErrorDb.SaveError(LogErrorToDb.errorRegonizeCategory, url, config.ID, ex.Message);
            }
            return lstResult.ToArray();
        }


        public int AnalyticsProductSaleNew(string domain, string url, ConfigXPaths confgID, ProductSaleNew product,
            Dictionary<long, int[]> dicMapClassAndMap,
            Dictionary<int, string[]> dicCity)
        {
            try
            {
                GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new HtmlDocument();
                string html1 = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2, true);
                doc.LoadHtml(html1);
                return AnalyticsProductSaleNew(domain, url, doc, confgID, product, dicMapClassAndMap, dicCity);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Exception:{0}", ex.Message);
                return 100;
            }
        }

        /// <summary>
        /// Phân tích sản phẩm từ document.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="document"></param>
        /// <param name="configXPath"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        public int AnalyticsProductSaleNew(string domain, string url, HtmlDocument document
            , ConfigXPaths configXPath, ProductSaleNew product, Dictionary<long, int[]> dicMapClassAndCat, Dictionary<int, string[]> arRegexCity)
        {
            try
            {
                product.id = Common.CrcProductID(url);
                product.url = url;
                product.name = Common.ChuanHoaTextOfHtml(System.Web.HttpUtility.HtmlDecode(GetTitleSaleNew(url, document, configXPath)));
                product.post_date = GetPostDate(url, document, configXPath);
                product.source_updated_at = GetLastEdit(url, document, configXPath);
                try
                {
                    product.province = Common.ChuanHoaUnicode(GetProvince(document, configXPath).ToLower());

                    //Phân tích thành phố.
                    for (int iCityIndex = 0; iCityIndex < arRegexCity.Count; iCityIndex++)
                    {
                        var itemCity = arRegexCity.ElementAt(iCityIndex);
                        foreach (var strRegex in itemCity.Value)
                        {
                            if (!product.city_ids.Contains(itemCity.Key) && Regex.IsMatch(product.province, strRegex))
                            {
                                product.city_ids.Add(itemCity.Key);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.ErrorFormat(ex.Message);
                }

                //Sửa thời gian tương đối
                if ((product.post_date - DateTime.Now).TotalDays > 1)
                {
                    product.post_date = product.post_date.AddYears(-1);
                    product.source_updated_at = product.post_date;
                }

                product.web_category = Common.ConvertToString(GetWebCategory(url, document, configXPath), ">");
                product.classification_id = (product.web_category == "") ? 0 : Math.Abs(GABIZ.Base.Tools.getCRC64(product.web_category));

                if (dicMapClassAndCat.ContainsKey(product.classification_id))
                    product.category_ids = dicMapClassAndCat[product.classification_id].ToList();

                product.is_crawled = true;
                product.is_standard = false;

                #region {Domain}
                try
                {
                    foreach (var item in ProductSaleNew.lst)
                    {
                        if (url.Contains(item))
                        {
                            product.source_name = item;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                #endregion

                if (product.category_ids.Contains(14))
                {
                    product.status = 1;
                }
                else product.status = 3;

                string currency = "";
                product.price = Convert.ToInt64(GetPriceSaleNew(url, document, configXPath, out currency));

                //Chuyển về giá vnđ.
                if (product.currency == "usd")
                {
                    currency = "vnd";
                    product.price = Common.TiGiaUsd * product.price;
                }
                //So khớp giá tương đối.
                if ((product.currency == "vnd" || product.currency == "")
                    && (product.price < 5000 || product.price > 100000000))
                {
                    product.price = 0; //Không bán ô tô >100 tỷ.
                }

                product.currency = currency.ToLower();

                product.slug = GetSlug(configXPath.ID, product.category_ids[0], product.price, product.post_date, product.name, product.id);

                product.content = Common.ChuanHoaTextOfHtml(GetContent(url, document, configXPath));
                product.description = Common.ParseExcerpt(Common.ChuanHoaTextOfHtml(product.content));

                product.images = GetImage(domain, document, configXPath);
                product.thumb_url = FindThumberFromImages(product.images, 80, product.slug);


                product.TagsString = GetTagsString(document, configXPath);
                product.tags = (string.IsNullOrEmpty(product.TagsString)) ? new List<string>() : product.TagsString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                product.website_id = configXPath.website_id;

                try
                {
                    //ViewCount-Xử lí riêng.
                    if (configXPath.Name.Contains("nhattao.com"))
                    {
                        string xpath = "//*[@class='pollResults']";
                        List<string> lstData = Common.GetTextInNode(document, xpath);
                        foreach (string item in lstData)
                        {
                            string data = Common.ChuanHoaUnicode(item).ToLower().Trim();
                            if (Regex.IsMatch(data, @"\d*\s*xem"))
                            {
                                string textViewCount = Regex.Match(data, @"\d*\s*xem").Captures[0].Value.ToLower().Replace("xem", "").Trim();
                                int ViewCount = 0;
                                int.TryParse(textViewCount, out ViewCount);
                                product.source_view_count = ViewCount;
                            }
                        }
                    }
                    else
                    {

                        foreach (var item in configXPath.view_count_xpaths)
                        {
                            List<string> lst = Common.GetTextInNode(document, item);
                            foreach (var itemCount in lst)
                            {
                                int iViewCount = ParseViewCount(itemCount);
                                if (iViewCount > 0)
                                {
                                    product.source_view_count = iViewCount;
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.ErrorFormat("{0}-{1}", ex.Message, product.url);
                }

                try
                {

                    product.phone_saler = Common.ChuanHoaUnicode(GetPhoneSaler(document, configXPath));
                    product.address = Common.ChuanHoaUnicode(GetAddress(document, configXPath));
                    product.quality = GetQuality(document, configXPath);

                    if (string.IsNullOrEmpty(product.currency))
                    {
                        if (product.name.ToLower().Contains("usd")) product.currency = "usd";
                        else if (product.name.ToLower().Contains("vnd")) product.currency = "vnd";
                        else if (product.price < 1000000) product.currency = "usd";
                        else product.currency = "vnd";
                    }

                }
                catch (Exception ex)
                {
                    log.ErrorFormat("Exception extend property:{0}", ex.Message);
                }
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Exception type 00001:{0}, Url:{1}", ex.Message, url);
                return 4;
            }

            return 0;
        }

        private string FindThumberFromImages(List<string> list, int width, string title)
        {
            //string strTempService = @"http://img.tonghopraovat.com/Services/GetThumbNail.ashx?ImgFilePath={0}&width={1}&title={2}&publishDate={3}";
            //string strDate = DateTime.Now.ToString("yyyy/MM/dd");

            //if (list == null || list.Count == 0) return "";
            //else
            //{
            //    foreach(string itemImage in list)
            //    {
            //        try
            //        {
            //            string strFullLinkService = string.Format(strTempService, itemImage, width.ToString(), title, strDate);
            //            WebRequest request = WebRequest.Create(strFullLinkService);
            //            WebResponse respose = request.GetResponse();
            //            string a = respose.ResponseUri.OriginalString;
            //            return a;
            //        }
            //        catch (Exception ex)
            //        {
            //            log.Error(string.Format("Exception:" + ex.Message));
            //        }
            //    }
            //}
            return (list == null || list.Count == 0) ? "" : list[0];
        }

        private int ParseViewCount(string itemCount)
        {
            string data = itemCount.Trim().Replace(",", "").Replace(".", "");
            int iOut = 0;
            int.TryParse(data, out iOut);

            if (iOut == 0)
            {
                data = Common.RemoveDumplicateSpace(Common.ChuanHoaUnicode(data.ToLower()));
                string Regex1 = @"đã xem\s*:\s*\d*";
                if (Regex.IsMatch(data, Regex1))
                {
                    data = Regex.Match(data, Regex1).Captures[0].Value.ToString().Replace("đã xem", "").Replace(" ", "").Replace(":", "");
                    int.TryParse(data, out iOut);
                }
            }
            return iOut;
        }

        private string GetSlug(int config_id, int category_id, decimal price, DateTime post_date, string title, long product_id)
        {
            string str = Common.GetSplug(title);
            if (str.Length > 120) str = str.Substring(0, 100);

            return string.Format("cat{1}-{4}-{5}"
                , config_id.ToString()
                , category_id.ToString()
                , price.ToString()
                , post_date.ToString("yyMMdd")
                , str
                , product_id.ToString());
        }

        private DateTime GetLastComment(string url, HtmlDocument document, ConfigXPaths configXPath)
        {
            return ParseDate(url, document, configXPath.ID, configXPath.last_comment_xpaths);
        }

        private DateTime GetLastEdit(string url, HtmlDocument document, ConfigXPaths configXPath)
        {
            return ParseDate(url, document, configXPath.ID, configXPath.last_edit_xpaths);
        }

        public void LoadExtendPropertyOfStandard(ProductSaleNew product, ConfigXPaths configXPath, HtmlDocument document)
        {
            if (configXPath.ID == 21)
            {
                Dictionary<string, string> lstDicValue = new Dictionary<string, string>();
                var nodesExt = document.DocumentNode.SelectNodes(@"//div[@id='specs-pod']//li");
                foreach (var nodeProperty in nodesExt)
                {
                    if (GetNodeByName(nodeProperty, "span") != null && GetNodeByName(nodeProperty, "em") != null)
                    {
                        string nameProperty = GetNodeByName(nodeProperty, "span").InnerText.Trim();
                        nameProperty = Common.ReplaceCassCharacter(Common.RemoveDumplicateSpace(nameProperty).ToLower(), "").Replace(" ", "");
                        string valueProperty = GetNodeByName(nodeProperty, "em").InnerText.Trim();
                        valueProperty = Common.ReplaceCassCharacter(Common.RemoveDumplicateSpace(valueProperty), "");
                        lstDicValue.Add(nameProperty, valueProperty);
                    }
                }
                product.extend_properties = lstDicValue;
            }
            else if (configXPath.ID == 22)
            {
                string xPathToRowData = @"//table//tr";
                var nodeRows = document.DocumentNode.SelectNodes(xPathToRowData);
                foreach (var nodesRow in nodeRows)
                {
                    var nodesOfRow = nodesRow.SelectNodes("td");
                    string NameField = nodesOfRow[0].InnerText.ToLower().Replace(" ", "").Replace(":", "").Trim();
                    string ValueField = nodesOfRow[1].InnerText.Trim();
                    switch (NameField)
                    {
                        case "drivetype": { product.car_driver_type = ValueField; } break;
                        case "enginesize": { product.car_engine_size = ValueField; } break;
                        case "numberofcylinders": { product.car_number_of_cylinders = ValueField; } break;
                        case "horsepower": { product.car_horsepower = ValueField; } break;
                        case "torque(ft.-lbs.)": { product.car_torque = ValueField; } break;
                        case "compressionratio": { product.car_compression_ratio = ValueField; } break;
                        case "camshaft": { product.car_camshaft = ValueField; } break;
                        case "enginetype": { product.car_engine_type = ValueField; } break;
                        case "bore": { product.car_bore = ValueField; } break;
                        case "stroke": { product.car_stroke = ValueField; } break;
                        case "valvespercylinder": { product.car_valves_per_cylinder = ValueField; } break;
                        case "fuelcapacity(gals.)": { product.car_fuel_capacity = ValueField; } break;
                        case "epampg(city/hwy)": { product.car_epa_mpg = ValueField; } break;
                        case "wheelbase": { product.car_wheelbase = ValueField; } break;
                        case "overalllength": { product.car_overall_length = ValueField; } break;
                        case "width": { product.car_width = ValueField; } break;
                        case "height": { product.car_height = ValueField; } break;
                        case "curbweight": { product.car_curb_weight = ValueField; } break;
                        case "legroomf/r": { product.car_leg_room = ValueField; } break;
                        case "headroomf/r": { product.car_head_room = ValueField; } break;
                        case "seatingcapacity(std.)": { product.car_seating_capacity = ValueField; } break;
                        case "cargocapacityforcars": { product.car_cargo_capacity_for_cars = ValueField; } break;
                        case "towingcapacity(max)": { product.car_towing_capacity_max = ValueField; } break;
                        case "payloadcapacityfortrucks": { product.car_payload_capacity_for_trucks = ValueField; } break;
                        case "grossvehicleweightfortrucks": { product.car_gross_vehicle_weight_for_trucks = ValueField; } break;
                        case "tires(std.)": { product.car_tires = ValueField; } break;
                        case "transmission": { product.car_transmission = ValueField; } break;
                        default: { product.car_all = product.car_all + ValueField; } break;
                    }
                }
            }
        }

        public HtmlNode GetNodeByName(HtmlNode node, string name)
        {
            foreach (HtmlNode node1 in node.ChildNodes)
            {
                if (node1.Name.Trim() == name) return node1;
            }
            return null;
        }




        private Dictionary<string, string> GetDicProperties(string url, HtmlDocument document, ConfigXPaths configXPath)
        {
            Dictionary<string, string> dicProperties = new Dictionary<string, string>();
            foreach (string xPath in configXPath.extend_xpaths)
            {
                if (!string.IsNullOrEmpty(xPath) && xPath.Contains(":"))
                {
                    string key = xPath.Substring(0, xPath.IndexOf(';')).Trim();
                    string valueXPath = xPath.Substring(xPath.LastIndexOf(':')).Trim();
                    if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(valueXPath))
                    {
                        string valueText = Common.GetTextInNode(document, xPath, configXPath)[0];
                        dicProperties.Add(key, valueText);
                    }
                }
            }
            return dicProperties;
        }



        public string GetTagsString(HtmlDocument document, ConfigXPaths configXPath)
        {
            string str = "";
            List<string> lst = configXPath.tags_xpaths;
            if (lst != null && lst.Count > 0)
            {
                foreach (var xPath in lst)
                {
                    string sItem = "";
                    List<string> arData = Common.GetTextInNode(document, xPath, configXPath);
                    for (int i = 0; i < arData.Count; i++)
                    {
                        sItem = (arData == null || arData.Count > 0) ? arData[i] : "";
                        sItem = Common.RemoveDumplicateSpace(sItem);
                        sItem = sItem.ToLower();
                        sItem = sItem.Replace("-", " ").Trim();
                        str = str + (string.IsNullOrEmpty(str) ? "" : ",") + sItem;
                    }
                }
            }
            return str.ToLower();
        }

        private List<string> GetTags(HtmlDocument document, ConfigXPaths configXPath)
        {
            return null;
        }

        public List<string> GetImage(string uri, HtmlDocument document, ConfigXPaths configXPath)
        {
            try
            {
                List<string> lstReuslt = new List<string>();
                List<string> lst = configXPath.ImageUrlsXPaths;
                if (lst != null && lst.Count > 0)
                {
                    foreach (string str in lst)
                    {
                        List<string> lstImage = Common.GetTextInNode(document, str, configXPath);
                        if (lstImage != null)
                        {
                            foreach (string s in lstImage)
                            {
                                if (s.Length < 1000)
                                {
                                    string imageUrl = Common.GetAbsoluteUrl(s, uri);
                                    bool bCheckRegex = Common.CheckRegex(imageUrl, configXPath.image_regex, configXPath.noimage_regex, true);
                                    if (bCheckRegex) lstReuslt.Add(imageUrl);
                                }
                            }
                        }
                    }
                }
                return lstReuslt;
            }
            catch (Exception ex)
            {
                logErrorDb.SaveError(LogErrorToDb.errorParseImage, "", configXPath.ID, ex.Message);
                return new List<string>();
            }
        }



        private string GetExcerpt(string input)
        {
            return Common.ParseExcerpt(input);

        }



        private byte[] GetPhoneImage(HtmlDocument document, ConfigXPaths configXPath)
        {
            try
            {
                if (configXPath.ID == 9) return null;
                Uri uri = new Uri(configXPath.RootLink[0]);
                List<string> lst = configXPath.PhoneSalerXPaths;
                foreach (string xPath in lst)
                {
                    string phoneLink = GetLinkToImage(document, xPath, uri);
                    if (!string.IsNullOrEmpty(phoneLink))
                    {
                        byte[] arByte = GetImageFromLink(phoneLink);
                        if (arByte != null) return arByte;
                    }
                }
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Exception:{0}", ex.Message);
            }
            return null;
        }

        private string GetLinkToImage(HtmlDocument document, string xPath, Uri uri)
        {
            try
            {
                string text = Common.GetTextOfXPath(document, xPath).Trim();
                string urlLinkToImage = "";
                if (string.IsNullOrEmpty(text))
                {
                    return "";
                }
                else if (text.Contains("/"))
                {
                    urlLinkToImage = text;
                    return urlLinkToImage;
                }
                else if (text.Contains("?"))
                {
                    string linkToNumber = document.DocumentNode.SelectSingleNode(xPath).GetAttributeValue("src", "").ToString();
                    urlLinkToImage = uri.Scheme + "://" + uri.Host + "/" + linkToNumber;
                    return urlLinkToImage;
                }
                else if (Regex.IsMatch(text, @"\d.*"))
                {
                    return text;
                }
                return "";
            }
            catch (Exception ex)
            {
                return "";
            }
            return "";
        }

        private int GetNumberFromNodes(HtmlDocument document, List<string> list)
        {
            throw new NotImplementedException();
        }

        private string GetDataFromNodes(HtmlDocument document, List<string> list, bool bAddComp = false)
        {
            try
            {
                string strReturn = "";
                List<string> listProcess = list;
                if (listProcess != null && listProcess.Count > 0)
                {
                    foreach (string xPath in listProcess)
                    {
                        var signleNode = document.DocumentNode.SelectSingleNode(xPath);
                        if (signleNode != null)
                        {
                            if (!bAddComp) return signleNode.InnerText.ToString();
                            else strReturn += signleNode.InnerText;
                        }
                    }
                }
                return strReturn;
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Exception:" + ex.Message);
                return "";
            }
        }





        public List<string> GetWebCategory(string url, HtmlDocument document, ConfigXPaths config)
        {
            string domain = Common.ParseDomain(config.domain).ToLower();
            List<string> lstCategory = new List<string>();
            lstCategory.Add(domain);
            try
            {
                var xpaths = config.WebCategoryXPaths;
                if (xpaths != null || xpaths.Count != 0)
                {
                    string xPath = xpaths[0];
                    var nodes = document.DocumentNode.SelectNodes(xPath);
                    if (nodes != null)
                    {
                        foreach (var node in nodes)
                        {
                            string s = Common.ChuanHoaUnicode(node.InnerText.ToLower());
                            s = Common.ChangeSpaceCharacter(s);
                            s = Common.RemoveDumplicateSpace(s).Trim();
                            if (s != domain && s != "") lstCategory.AddRange(s.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries));
                        }
                    }
                }
                return lstCategory;
            }
            catch (Exception ex)
            {
                this.logErrorDb.SaveError(LogErrorToDb.errorParseWebCategory, url, config.ID, ex.Message);
                return lstCategory;
            }
        }

        private string GetQuality(HtmlDocument document, ConfigXPaths configXPath)
        {
            try
            {
                List<string> lst = configXPath.QualityXPaths;
                if (lst != null && lst.Count > 0)
                {
                    if (configXPath.ID == 1)
                    {
                        var node = document.DocumentNode.SelectSingleNode(lst[0]);
                        if (node != null)
                        {
                            string textTable = node.InnerText;
                            string[] ar = textTable.Replace("&gt;", "").Split(new char[] { '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                            for (int i = 0; i < ar.Length; i++)
                            {
                                if (ar[i].Contains("Tình trạng:") && i < ar.Length - 1)
                                {
                                    return ar[i + 1];
                                }
                            }

                        }
                    }
                    else
                    {
                        return Regex.Replace(this.GetDataFromNodes(document, lst, false), "\n|\t|\r", "").Trim();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Exception:{0}", ex.Message);
                return "";
            }
        }

        private String GetAddress(HtmlDocument document, ConfigXPaths configXPath)
        {
            try
            {
                List<string> lst = configXPath.AddressXPaths;
                if (lst != null && lst.Count > 0)
                {
                    if (configXPath.ID == 1)
                    {
                        var node = document.DocumentNode.SelectSingleNode(lst[0]);
                        if (node != null)
                        {
                            string textTable = node.InnerText;
                            string[] ar = Regex.Replace(textTable, "\r|\t", "").ToString().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                            for (int i = 0; i < ar.Length; i++)
                            {
                                if (ar[i].Contains("Địa chỉ:") && i < ar.Length - 1)
                                {
                                    return ar[i + 1];
                                }
                            }

                        }
                    }
                    else
                    {
                        return Regex.Replace(this.GetDataFromNodes(document, lst, false), "\n|\r|\t", "").Trim();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Exception:{0}", ex.Message);
                return "";
            }
        }

        private string GetPhoneSaler(HtmlDocument document, ConfigXPaths configXPath)
        {
            try
            {
                List<string> lst = configXPath.PhoneSalerXPaths;
                if (lst != null && lst.Count > 0)
                {
                    foreach (string xPath in lst)
                    {
                        List<string> phone01 = Common.GetTextInNode(document, xPath, configXPath);
                        if (phone01 != null && phone01.Count > 0) return phone01[0];
                    }
                }
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Exception:{0}", ex.Message);
            }
            return "";
        }

        private string TryGetPhone(HtmlDocument document, string xPath, Uri uri)
        {
            try
            {
                string text = Common.GetTextOfXPath(document, xPath).Trim();
                string urlLinkToImage = "";
                if (string.IsNullOrEmpty(text))
                {
                    return "";
                }
                else if (text.Contains("/"))
                {
                    urlLinkToImage = text;
                    return this.GetNumberfromLink(urlLinkToImage);
                }
                else if (text.Contains("?"))
                {
                    string linkToNumber = document.DocumentNode.SelectSingleNode(xPath).GetAttributeValue("src", "").ToString();
                    urlLinkToImage = uri.Scheme + "://" + uri.Host + "/" + linkToNumber;
                    return this.GetNumberfromLink(urlLinkToImage);
                }
                else if (Regex.IsMatch(text, @"\d.*"))
                {
                    return text;
                }
                return "";
            }
            catch (Exception ex)
            {
                return "";
            }
            return "";
        }


        public byte[] GetImageFromLink(string fullLink)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fullLink);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Bitmap thumbBitmap = new Bitmap(response.GetResponseStream());
                ImageConverter converter = new ImageConverter();
                return (byte[])converter.ConvertTo(thumbBitmap, typeof(byte[]));
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Exception:{0}", ex.Message);
                return null;
            }
        }

        public string GetNumberfromLink(string fullLink)
        {
            if (!string.IsNullOrEmpty(fullLink))
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fullLink);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Bitmap thumbBitmap = new Bitmap(response.GetResponseStream());
                thumbBitmap = new Bitmap(thumbBitmap, 166, 77);
                //thumbBitmap.Save("trang.png");
                for (int i = 0; i < thumbBitmap.Width; i++)
                    for (int j = 0; j < thumbBitmap.Height; j++)
                    {
                        Color cell = thumbBitmap.GetPixel(i, j);
                        if (cell == Color.Transparent || (cell.A == 0 && cell.B == 0 && cell.G == 0 && cell.R == 0))
                        {
                            thumbBitmap.SetPixel(i, j, Color.White);
                        }
                    }

                //thumbBitmap = new Bitmap(@"trang2.png");
                string str = "";

                return str;
            }
            else
                return "";
        }
        SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
    }
}

