using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using GABIZ.Base;
using GABIZ.Base.HtmlAgilityPack;
using log4net;
using QT.Entities;
using QT.Entities.Data;
using StackExchange.Redis;
using System.Data;

namespace QT.Moduls.CrawlerProduct
{
    public class ProductParse
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(ProductParse));


        public void ParseProduct(ProductEntity pt, DataRow row)
        {
            pt.CompanyId = Convert.ToInt64(row["CompanyId"]);
            pt.Domain = Convert.ToString(row["Domain"]);
            pt.DetailUrl = Convert.ToString(row["DetailUrl"]);
            pt.ID = Convert.ToInt64(row["Id"]);
            pt.Name = Convert.ToString(row["Name"]);
            pt.HashName = Common.CellToInt64(row, "HashName", 0);
            pt.ShortDescription = Common.CellToString(row, "ShortDescription", "");
            pt.Categories = null;

            pt.OriginPrice = Common.CellToInt64(row, "OriginPrice", 0);
            pt.Price = Common.CellToInt64(row, "Price", 0);

            pt.VatInfo = Common.CellToString(row, "VatInfo", "");
            pt.IsNews = Common.CellToBool(row, "IsNews", false);
            pt.PromotionInfo = Common.CellToString(row, "PromotionInfo", "");
            
            pt.StartDeal = Common.CellToDateTime(row, "StartDeal", SqlDb.MinDateDb);
            pt.EndDeal = Common.CellToDateTime(row, "EndDeal", SqlDb.MinDateDb);

            pt.Warranty = Common.CellToInt(row, "Warranty", 0);
            pt.Status = (Common.ProductStatus) Common.CellToInt(row, "Status", 0);
            pt.Instock = (Common.ProductInstock) Common.CellToInt(row, "InStock", 0);
            pt.ImageUrls = new List<string>()
            {
                Common.CellToString(row, "ImageUrls", "")
            };
        }
        public void Analytics(ProductEntity pt, HtmlDocument doc, String detailUrl, Configuration conf, string domain)
        {
            try
            {
                pt.CompanyId = conf.CompanyID;
                pt.Domain = domain;
                pt.DetailUrl = detailUrl;
                pt.ID = Common.GetIDProduct(detailUrl);
                pt.Name = ParseName(doc, conf.ProductNameXPath);
                pt.HashName = Common.GetHashNameProduct(domain, pt.Name);
                pt.ShortDescription = ParseShortDescription(doc, conf.ShortDescriptionXPath);
                pt.Categories = ParseCategories(doc, conf.CategoryXPath, domain, conf.RemoveLastItemClassification, detailUrl);

                pt.OriginPrice = ParsePrice(doc, conf.OriginPriceXPath, conf.CheckPrice, new Uri(detailUrl), null);
                pt.Price = ParsePrice(doc, conf.PriceXPath, conf.CheckPrice, new Uri(detailUrl), conf.RegexPrice.Split(Common.arSplitToList, StringSplitOptions.RemoveEmptyEntries).ToList());
                
                pt.VATStatus = conf.VATStatus;
                pt.VatInfo = ParseVatInfo(doc, conf.VATInfoXPath);
                if (!string.IsNullOrEmpty(pt.VatInfo))
                {
                    if (pt.VatInfo.ToLower().Contains("chưa"))
                    {
                        pt.VATStatus = 0;
                    }
                    if (pt.VatInfo.ToLower().Contains("đã"))
                    {
                        pt.VATStatus = 1;
                    }
                }
                pt.PromotionInfo = ParsePromotionInfo(doc, conf.PromotionInfoXPath);
               
                pt.StartDeal = ParseStartDeal(doc, conf.StartDealXPath);
                pt.EndDeal = ParseEndDeal(doc, conf.EndDealXPath);
                
                pt.Warranty = ParseWarranty(doc, conf.WarrantyXPath);
                pt.Status = ParseStatus(doc, conf.StatusXPath);
                pt.Instock = Common.GetProductInstockFormStatus(pt.Status);
                pt.ImageUrls = ParseImages(doc, conf.ImageXPath, conf.AutoFixLinkImage, detailUrl);
                pt.Manufacture = ParseManufacture(doc, conf.ManufactureXPath);
                pt.Origin = ParseOrigin(doc, conf.OriginXPath);
                pt.Promotion = ParsePromotion(doc, conf.PromotionXPath);
                pt.Summary = ParseSummary(doc, conf.SummaryXPath);
                pt.ProductContent = ParseContent(doc, conf.ContentXPath);
                pt.VideoDescHtml = GetDesc(doc, conf.VideoXpath.Split(Common.arSplitToList, StringSplitOptions.RemoveEmptyEntries).ToList());
                pt.SpecsDescHtml = GetDesc(doc, conf.SpecsXPath.Split(Common.arSplitToList, StringSplitOptions.RemoveEmptyEntries).ToList());
                pt.FullDescHtml = GetDesc(doc, conf.FullDescXPath.Split(Common.arSplitToList, StringSplitOptions.RemoveEmptyEntries).ToList());
                pt.ShortDescHtml = GetDesc(doc, conf.ShortDescriptionXPath);
                

                pt.Valid = pt.IsSuccessData(conf.CheckPrice);
            }
            catch (Exception ex)
            {
                Exception ex01 = new Exception(string.Format("Company: {0} Product: {1} Url: {2}: {3}", pt.CompanyId, pt.ID, pt.DetailUrl, ex.Message + ex.StackTrace));
                throw ex01;
            }
        }




        private string GetDesc(HtmlDocument doc, List<string> lstXPath)
        {
            var str = "";
            foreach (var xp in lstXPath)
            {
                var datas = doc.DocumentNode.SelectNodes(xp);
                if (datas != null)
                {
                    foreach (var data in datas)
                    {
                        str += (" " + data.InnerHtml.Trim());
                    }
                }
            }
            return str.Trim();
        }

        private string ParseContent(HtmlDocument doc, List<string> ContentXPath)
        {
            string strContent = "";

            if (ContentXPath != null && ContentXPath.Count > 0)
            {
                for (int i = 0; i < ContentXPath.Count; i++)
                {
                    if (ContentXPath[i].Trim() != "")
                    {
                        var node = doc.DocumentNode.SelectSingleNode(ContentXPath[i]);
                        if (node != null)
                        {
                            Common.ReplaceNodeValue(node, "style", "");
                            strContent = Common.ChuanHoaContent(node.InnerHtml.Trim());

                            //Xóa các thẻ xuống dòng.
                            strContent = Regex.Replace(strContent, @"<\/*\s*br\s*\/*>", "");

                            if (strContent != "") break;
                        }
                    }
                    break;
                }
            }

            return strContent;
        }

        private string ParseSummary(HtmlDocument doc, List<string> SummaryXPath)
        {
            string summary = "";
            for (int i = 0; i < SummaryXPath.Count; i++)
            {
                if (SummaryXPath[i].Trim() != "")
                {
                    var node = doc.DocumentNode.SelectSingleNode(SummaryXPath[i]);
                    if (node != null)
                    {
                        summary = Common.ChuanHoaContent(node.InnerHtml.Trim());
                    }
                }
                break;
            }
            return summary;
        }

        private string ParsePromotion(HtmlDocument doc, List<string> PromotionXPath)
        {
            string promotion = "";
            for (int i = 0; i < PromotionXPath.Count; i++)
            {
                if (PromotionXPath[i].Trim() != "")
                {
                    var node = doc.DocumentNode.SelectSingleNode(PromotionXPath[i]);
                    if (node != null)
                    {
                        promotion = node.InnerHtml.Trim();
                    }
                    break;
                }
            }
            return promotion;
        }

        private string ParseOrigin(HtmlDocument doc, List<string> OriginXPath)
        {
            string origin = "";
            for (int i = 0; i < OriginXPath.Count; i++)
            {
                if (OriginXPath[i].Trim() != "")
                {
                    var node_Origin = doc.DocumentNode.SelectSingleNode(OriginXPath[i]);
                    if (node_Origin != null)
                    {
                        origin = Tools.removeHTML(node_Origin.InnerText).TrimEnd(new char[] { '-', ' ', '>' });
                    }
                }
            }
            return origin;
        }

        private string ParseManufacture(HtmlDocument doc, List<string> ManufactureXPath)
        {
            var manufacture = "";
            for (int i = 0; i < ManufactureXPath.Count; i++)
            {
                if (ManufactureXPath[i].Trim() != "")
                {
                    var node_Manufacture = doc.DocumentNode.SelectSingleNode(ManufactureXPath[i]);
                    if (node_Manufacture != null)
                    {
                        manufacture = Tools.removeHTML(node_Manufacture.InnerText).TrimEnd(new char[] { '-', ' ', '>' });
                    }
                }
            }
            return manufacture;
        }

        private List<string> ParseImages(HtmlDocument doc, List<string> ImageXPath,
            bool AutoFixLink, string urlDetail)
        {
            var ImageUrls = new List<string>();
            for (int i = 0; i < ImageXPath.Count; i++)

                if (ImageXPath[i].Trim() != "")
                {
                    var node_image = doc.DocumentNode.SelectNodes(ImageXPath[i]);
                    if (node_image != null && node_image.Count > 0)
                    {
                        List<string> _imgUrl = null;
                        for (int j = 0; j < node_image.Count; j++)
                        {
                            //Chỉ định thẻ.
                            if (Regex.IsMatch(ImageXPath[i], @".*\/@[^\/]+$"))
                            {
                                List<string> lst = new List<string>();
                                string attribute =
                                    Regex.Match(ImageXPath[i], @"\/@[^\/]+$").Captures[0].Value
                                        .ToString().Replace("@", "").Replace("/", "");
                                string image = node_image[j].Attributes[attribute].Value.ToString();
                                if (!string.IsNullOrEmpty(image))
                                {
                                    if (!image.Contains("http"))
                                        image = Common.GetAbsoluteUrl(image,
                                            Common.GetWebsiteFromUrl(urlDetail));
                                    ImageUrls.Add((AutoFixLink) ? Common.FixParalinkImage(image) : image);
                                }
                            }
                            else
                            {
                                _imgUrl = Common.ParseImage(node_image[j].OuterHtml, new Uri(urlDetail), true);
                                foreach (var image in _imgUrl)
                                {
                                    string image1 = (AutoFixLink)
                                        ? QT.Entities.Common.FixParalinkImage(image)
                                        : image;
                                    ImageUrls.Add(image1);
                                }
                            }
                        }
                        ImageUrls = ImageUrls.Distinct().ToList();
                    }
                }
            return ImageUrls;
        }

        private Common.ProductStatus ParseStatus(GABIZ.Base.HtmlAgilityPack.HtmlDocument doc, List<string> StatusXPath)
        {
            Common.ProductStatus pt = Common.ProductStatus.LienHe;
            for (int i = 0; i < StatusXPath.Count; i++)
            {
                if (StatusXPath[i].Trim() != "")
                {
                    var ls_node_status = doc.DocumentNode.SelectNodes(StatusXPath[i]);
                    if (ls_node_status != null && ls_node_status.Count > 0)
                    {
                        foreach (var node_status in ls_node_status)
                        {
                            string s_s = QT.Entities.Common.ChuanHoaUnicode(Tools.removeHTML(node_status.InnerText).Trim().Replace("&nbsp;", "")).ToLower();
                            if (s_s == "không còn hàng")
                            {
                                s_s = s_s.Replace(" còn hàng", "");
                            }
                            pt = QT.Entities.CrawlerProduct.ProductStatusRegex.Instance().GetStatusProduct(s_s);             // Common.ParseStatus(s_s);
                            if (pt != Common.ProductStatus.NotDefine) break;
                        }
                        if (pt != Common.ProductStatus.NotDefine) break;
                    }
                }
            }
            return pt;
        }

        private int ParseWarranty(GABIZ.Base.HtmlAgilityPack.HtmlDocument doc, List<string> WarrantyXPath)
        {
            int Warranty = 0;
            for (int i = 0; i < WarrantyXPath.Count; i++)
            {
                if (WarrantyXPath[i].Trim() != "")
                {
                    var node_warranty = doc.DocumentNode.SelectSingleNode(WarrantyXPath[i]);
                    if (node_warranty != null)
                    {
                        string s_w = Tools.removeHTML(node_warranty.InnerText);
                        int v_w = Common.ParseWarranty(s_w);
                        if (v_w != -1)
                        {
                            Warranty = v_w;
                            break;
                        }
                    }
                }
            }
            return Warranty;
        }

        private DateTime ParseEndDeal(GABIZ.Base.HtmlAgilityPack.HtmlDocument doc, List<string> EndDealXPath)
        {
            DateTime dtEnd = SqlDb.MinDateDb;
            for (int i = 0; i < EndDealXPath.Count; i++)
            {
                if (EndDealXPath[i].Trim() != "")
                {
                    var node_EndDate = doc.DocumentNode.SelectSingleNode(EndDealXPath[i]);
                    if (node_EndDate != null)
                    {
                        string data =
                            Tools.removeHTML(node_EndDate.InnerText).TrimEnd(new char[] { '-', ' ', '>' });
                        DateTime dt = Common.ParseDateTime(data);
                        if (dt != SqlDb.MinDateDb)
                        {
                            dtEnd = dt;
                            break;
                        }
                    }
                }
            }
            return dtEnd;
        }

        private DateTime ParseStartDeal(HtmlDocument doc, List<string> StartDealXPath)
        {
            DateTime startDeal = SqlDb.MinDateDb;
            for (int i = 0; i < StartDealXPath.Count; i++)
            {
                if (StartDealXPath[i].Trim() != "")
                {
                    var node_StartDeal = doc.DocumentNode.SelectSingleNode(StartDealXPath[i]);
                    if (node_StartDeal != null)
                    {
                        string data =
                            Tools.removeHTML(node_StartDeal.InnerText).TrimEnd(new char[] { '-', ' ', '>' });
                        DateTime dt = Common.ParseDateTime(data);
                        if (dt != SqlDb.MinDateDb)
                        {
                            startDeal = dt;
                            break;
                        }
                    }
                }
            }
            return startDeal;
        }

        private string ParsePromotionInfo(GABIZ.Base.HtmlAgilityPack.HtmlDocument doc, List<string> PromotionInfoXPaths)
        {
            var promotionInfo = "";
            foreach (string PromotionInfoXPath in PromotionInfoXPaths)
            {
                if (PromotionInfoXPath.Trim() != "")
                {
                    var node_VAT = doc.DocumentNode.SelectSingleNode(PromotionInfoXPath);
                    if (node_VAT != null)
                    {
                        string tempPromotion = Tools.removeHTML(node_VAT.InnerText);
                        if (Common.ParsePromotionInfo(tempPromotion) != -1)
                        {
                            promotionInfo =
                                Common.RemoveDumplicateSpace((string.IsNullOrEmpty(promotionInfo) ? "" : " ") +
                                                             tempPromotion);
                        }
                    }
                }
            }
            return promotionInfo;
        }

        private string ParseVatInfo(GABIZ.Base.HtmlAgilityPack.HtmlDocument doc, IEnumerable<string> VATInfoXPaths)
        {
            var vatInfo = "";
            foreach (var VATInfoXPath in VATInfoXPaths)
            {
                if (VATInfoXPath.Trim() != "")
                {
                    var node_VAT = doc.DocumentNode.SelectSingleNode(VATInfoXPath);
                    if (node_VAT != null)
                    {
                        string tempVAT = Tools.removeHTML(node_VAT.InnerText);
                        if (Common.ParseVATInfo(tempVAT) != -1)
                        {
                            vatInfo += (string.IsNullOrEmpty(vatInfo) ? "" : " ") + tempVAT;
                        }
                    }
                }
            }
            return vatInfo;
        }

        private long ParsePrice(HtmlDocument doc, List<string> xpathsPrice, bool checkPrice, Uri rootUri, List<string> regexPrice)
        {
            long Price = 0;
            switch (rootUri.DnsSafeHost)
            {
                case "mediamart.vn":
                    int priceOld = 0, priceGiam = 0;
                    if (xpathsPrice.Count == 2)
                    {
                        if (xpathsPrice[0].Trim() != "")
                        {
                            var node_price = doc.DocumentNode.SelectNodes(xpathsPrice[0]);
                            if (node_price != null)
                            {
                                int K = node_price.Count;
                                for (int j = 0; j < K; j++)
                                {
                                    string s = Tools.removeHTML(node_price[j].InnerText);
                                    priceOld = Common.ParsePrice(s, checkPrice);
                                }
                            }
                        }
                        if (xpathsPrice[1].Trim() != "")
                        {
                            var node_price = doc.DocumentNode.SelectNodes(xpathsPrice[1]);
                            if (node_price != null)
                            {
                                int K = node_price.Count;

                                for (int j = 0; j < K; j++)
                                {
                                    string s = Tools.removeHTML(node_price[j].InnerText);
                                    priceGiam = Common.ParsePrice(s, checkPrice);
                                }
                            }
                        }
                    }
                    Price = priceOld - priceGiam;
                    break;
                case "www.trananh.vn":
                    Price = ParsePriceTranAnh(doc, xpathsPrice);
                    break;
                default:
                    for (int i = 0; i < xpathsPrice.Count; i++)
                    {
                        if (xpathsPrice[i].Trim() != "")
                        {
                            var node_price = doc.DocumentNode.SelectNodes(xpathsPrice[i]);
                            if (node_price != null && node_price.Count > 0)
                            {
                                int K = node_price.Count;
                                for (int j = 0; j < K; j++)
                                {
                                    int v = 0;
                                    string s =
                                        QT.Entities.Common.ChuanHoaUnicode(
                                            Tools.removeHTML(node_price[j].InnerText).Trim().ToLower());
                                    try
                                    {
                                        if (s == "" &&
                                            Regex.IsMatch(xpathsPrice[i],
                                                ".*@[a-z1-9]*$"))
                                        {
                                            List<string> lstData = QT.Entities.Common.GetTextInNode(doc,
                                                xpathsPrice[i]);
                                            if (lstData != null && lstData.Count > 0)
                                            {
                                                s =
                                                    QT.Entities.Common.GetTextInNode(doc, xpathsPrice[i])
                                                        [0];
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                    }

                                    if (regexPrice == null || regexPrice.Count == 0)
                                    {
                                        s = QT.Entities.Common.SubPriceString(s);
                                        v = Common.ParsePrice(s, checkPrice);
                                    }
                                    else
                                    {
                                        if (Common.CheckRegex(s, regexPrice, null, false))
                                        {
                                            s = QT.Entities.Common.SubPriceString(s);
                                            v = Common.ParsePrice(s, checkPrice);
                                        }
                                    }
                                    if (v > 0)
                                    {
                                        Price = v;
                                        break;
                                    }
                                }
                                if (Price > 0)
                                    break;
                            }
                        }
                    }
                    break;
            }
            return Price;
        }

        private long ParsePriceTranAnh(HtmlDocument doc, List<string> xpaths)
        {
          
            long price = 0;
            if (xpaths.Count > 0)
            {
                var nodes = doc.DocumentNode.SelectNodes(xpaths[0]);
                if (nodes != null)
                {
                    string strData = Common.JoinList(nodes.ToList(), "", (objData) =>
                    {
                        string dataText = objData.GetAttributeValue("class", "").ToLower();
                        if (Regex.IsMatch(dataText, @"number\d-sw"))
                            return Regex.Match(dataText, @"\d").Captures[0].Value.ToString();
                        else if (dataText == "numberdot-sw") return ".";
                        else return "";
                    });
                    strData = strData + ".000";
                    strData = strData.Replace(".", "");
                    return Convert.ToInt64(strData);
                }
            }
            return 0;
        }

        private List<string> ParseCategories(HtmlDocument doc, List<string> xpaths,
            string domain, bool removeLastItem, string detailUrl)
        {
            var categories = new List<string> { domain };
            if (xpaths.Count == 1 && xpaths[0] == "url")
            {
                categories = Common.CompactUrl(detailUrl.ToLower()).Split(new char[] { '/' }
                    , StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            else
            {
                foreach (string t in xpaths)
                {
                    if (t != "")
                    {
                        var nodeCategories = doc.DocumentNode.SelectNodes(t);
                        if (nodeCategories != null)
                        {
                            int K = nodeCategories.Count;
                            for (int i = 0; i < K; i++)
                            {
                                string s =
                                    Tools.removeHTML(nodeCategories[i].InnerText)
                                        .Trim(new char[] { ' ', '-', '»', '>', '<' });
                                if (!categories.Contains(s) && s.ToLower().Trim() != "trang chủ")
                                {
                                    categories.Add(s.Trim());
                                }
                            }
                        }
                    }
                }
            }
            if (removeLastItem && categories.Count > 1)
                categories.RemoveAt(categories.Count - 1);
            return categories;
        }

        private string ParseShortDescription(GABIZ.Base.HtmlAgilityPack.HtmlDocument doc, List<string> xpaths)
        {
            var description = "";
            List<string> descriptions = new List<string>();
            foreach (var xpath in xpaths)
            {
                var desc = doc.DocumentNode.SelectSingleNode(xpath);
                if (desc != null)
                {
                    descriptions.Add(desc.InnerText.Trim());
                }
            }
            description = string.Join(" ", descriptions);
            return description;
        }


        private string ParseName(GABIZ.Base.HtmlAgilityPack.HtmlDocument doc, List<string> xpaths)
        {
            string name = "";
            var lstName = new List<string>();
            foreach (var xpath in xpaths)
            {
                var nodeProductName = doc.DocumentNode.SelectSingleNode(xpath);
                if (nodeProductName != null)
                {
                    var nameNode = Tools.removeHTML(nodeProductName.InnerText).Trim();
                    if (!string.IsNullOrEmpty(nameNode))
                        lstName.Add(nameNode);
                }
            }
            name = string.Join(" ", lstName);
            return name;
        }

    }
}
