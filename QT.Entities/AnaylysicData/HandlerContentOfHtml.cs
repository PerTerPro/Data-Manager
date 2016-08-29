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
using QT.Entities.Model.SaleNews;
using QT.Entities.RaoVat;

namespace QT.Entities.AnaylysicData
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
              
                return true;
            }
        }

      
      

        

      
        private string GetLocation(HtmlDocument document, ConfigXPaths configXPath)
        {
            List<string> xPaths = configXPath.XPaths08;
            if (xPaths!=null && xPaths.Count>0)
            {
                foreach(string xPath in xPaths)
                {
                    var node = document.DocumentNode.SelectSingleNode(xPath);
                    string location = System.Text.RegularExpressions.Regex.Replace(node.InnerText.Trim(), "\r|\n|\t", "");
                    if (!string.IsNullOrEmpty(location))
                        return location.Contains(':') ? location.Substring(location.LastIndexOf(':') + 1) : "";
                }
            }
            return "";
        }

        private DateTime GetLastChange(HtmlDocument document, ConfigXPaths configXPath)
        {
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

        private decimal GetPriceSaleNew(HtmlDocument document, ConfigXPaths configXPath)
        {
            if (configXPath.XPaths04 != null && configXPath.XPaths04.Count > 0)
            {
                foreach (string xPath in configXPath.XPaths04)
                {
                    var node = document.DocumentNode.SelectSingleNode(xPath);
                    if (node != null)
                    {
                        string textPrice = node.InnerText.Trim();
                        if (!string.IsNullOrWhiteSpace(textPrice))
                        {
                            decimal price = Common.ParsePrice(textPrice, true);
                            if (price > 0) return price;
                        }
                    }
                }
            }
            return 0;
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

     

       

       
       

        private string GetCategory(HtmlDocument document, ConfigXPaths configXPath)
        {
            if (configXPath.XPaths52!=null && configXPath.XPaths52.Count>0)
            {
                var nodes = document.DocumentNode.SelectSingleNode("//nav/fieldset//span");
                if (nodes != null)
                {
                    string str =  Regex.Replace(Regex.Replace(nodes.InnerText, "\n|\r|\t", ""), "&gt;", "->");
                    if (str.StartsWith("->")) str = str.Remove(0, 2);
                    else if (str.EndsWith("->")) str = str.Remove(str.Length - 2, 2);
                    return str;
                }
                   
            }
            return "";
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

        public Model.SaleNews.TypeCrawlerData GetTypeOfLink(string c_url,GABIZ.Base.HtmlAgilityPack.HtmlDocument document, ConfigXPaths config)
        {
            string category = GetCategory(document, config).Trim();
            if (!string.IsNullOrEmpty(category))
            {
                if (Regex.IsMatch(category, "Nhật tảo->Mua bán->Điện thoại.*"))
                {
                    return Model.SaleNews.TypeCrawlerData.PhoneComputer;
                }
            }
            return Model.SaleNews.TypeCrawlerData.None;
        }




   

        public List<string> GetImage(Uri uri, HtmlDocument document, ConfigXPaths configXPath)
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
                                lstReuslt.Add(Common.GetAbsoluteUrl(s, uri));
                            }
                        }
                    }
                }
                return lstReuslt;
            }
            catch (Exception ex)
            {
                logErrorDb.SaveError(LogErrorToDb.errorParseImage, uri.AbsoluteUri, configXPath.ID, ex.Message);
                return null;
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
                        string strText = Common.ChuanHoaUnicode(Common.GetTextOfXPath(document, lst[0]));
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


        private DateTime GetLastComment(string url, HtmlDocument document, ConfigXPaths configXPath)
        {
            return ParseDate(url, document, configXPath.ID, configXPath.last_comment_xpaths);
        }

        /// <summary>
        /// Trả về số dưựa ào config list
        /// 1 phần tử có dạng: Regex:Int.
        /// Ví dụ: *.ô tô.*:9
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="lstRegexToInt"></param>
        /// <param name="WebCategory"></param>
        /// <param name="doc"></param>
        /// <returns></returns>
        public int RecognizeCategory(string url, ConfigXPaths config, string WebCategory, int defaultReturn = 0)
        {
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
                                    if (Int32.TryParse(regexs[1], out iCat)) return iCat;
                                }
                            }
                        }
                    }
                }
                return defaultReturn;
            }
            catch (Exception ex)
            {
                this.logErrorDb.SaveError(LogErrorToDb.errorRegonizeCategory, url, config.ID, ex.Message);
                return 0;
            }
        }

        private DateTime GetLastEdit(string url, HtmlDocument document, ConfigXPaths configXPath)
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
                        sItem = sItem.Trim();
                        str = str + (string.IsNullOrEmpty(str) ? "" : ",") + sItem;
                    }
                }
            }
            return str;
        }



        public string GetWebCategory(string url, HtmlDocument document, ConfigXPaths config)
        {
            try
            {
                var xpaths = config.WebCategoryXPaths;
                if (xpaths == null || xpaths.Count == 0)
                {
                    return "";
                }
                else
                {
                    string xPath = xpaths[0];
                    var nodes = document.DocumentNode.SelectNodes(xPath);
                    if (nodes != null)
                    {
                        string str = "";
                        foreach (var node in nodes)
                        {
                            string s = node.InnerText;
                            s = Common.ChangeSpaceCharacter(s);
                            s = Common.RemoveDumplicateSpace(s);
                            s = s.Trim();
                            str = str + (string.IsNullOrEmpty(str) ? "" : ">") + s;
                        }
                        str = Common.RemoveDumplicateSpace(str);
                        str = str.Replace("/", ">");
                        str = str.Trim();
                        str = str.ToLower();
                        str = Common.ChuanHoaUnicode(str);
                        str = Regex.Replace(str, @"\s>", ">");
                        str = Regex.Replace(str, @">\s", ">");
                        return str;
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                this.logErrorDb.SaveError(LogErrorToDb.errorParseWebCategory, url, config.ID, ex.Message);
                return "";
            }
        }

    }
}

