using System;
using System.Collections.Generic;
using System.Linq;
using GABIZ.Base;
using QT.Entities.Data;
using System.Text.RegularExpressions;
using StackExchange.Redis;
using System.IO;
using ProtoBuf;

namespace QT.Entities
{
    [ProtoBuf.ProtoContract]
    public class Product
    {
        public override string ToString()
        {
            string strReturn = "";
            strReturn += string.Format("\nID:{0}", ID);
            strReturn += string.Format("\nName:{0}", Name);
            strReturn += string.Format("\nPrice:{0}", Price);
            strReturn += string.Format("\nPromotionInfo:{0}", PromotionInfo);
            strReturn += string.Format("\nVATInfo:{0}", VATInfo);
            strReturn += string.Format("\nSortDescription:{0}", ShortDescription);
            strReturn += string.Format("\nCategories:{0} \nCategoryID:{1}", Common.ConvertToString(Categories, " -> "), IDCategories);
            strReturn += string.Format("\nWarranty:{0}", Warranty);
            strReturn += string.Format("\nStatus:{0}", Status);
            strReturn += string.Format("\nSummary:{0}", Summary);
            strReturn += string.Format("\nOriginal:{0}", Origin);
            strReturn += string.Format("\nDetailUrl:{0}", DetailUrl);
            strReturn += string.Format("\nStartDeal:{0}", StartDeal);
            strReturn += string.Format("\nEndDeal:{0}", EndDeal);
            strReturn += string.Format("\nDetailUrl:{0}", DetailUrl);
            strReturn += string.Format("\nStartDeal:{0}", StartDeal.ToString("dd/MM/yyyy"));
            strReturn += string.Format("\nEndDeal:{0}", EndDeal.ToString("dd/MM/yyyy"));
            strReturn += string.Format("\nIsValid:{0}", Valid.ToString());
            return strReturn;
        }

        public bool Valid { get; set; }


        [ProtoBuf.ProtoMember(1)]
        public string PromotionInfo { get; set; }

        [ProtoBuf.ProtoMember(2)]
        public string VATInfo { get; set; }

        [ProtoBuf.ProtoMember(3)]
        public long ID { get; set; }

        [ProtoBuf.ProtoMember(4)]
        public long HashName { get; set; }

        [ProtoBuf.ProtoMember(5)]
        public string Name { get; set; }

        [ProtoBuf.ProtoMember(6)]
        public string MerchantSku { get; set; }

        //ID trong bảng Classification
        [ProtoBuf.ProtoMember(7)]
        public long IDCategories { get; set; }

        [ProtoBuf.ProtoMember(8)]
        public List<string> Categories { get; set; }

        [ProtoBuf.ProtoMember(9)]
        public int Price { get; set; }

        public bool IsSuccessData(bool checkPrice)
        {
            if (checkPrice)
                return (Price >= 1000) && (Price%100 == 0) && (Name.Trim().Length > 0) &&
                       !string.IsNullOrEmpty(ImageUrl);
            return Price > 0 && (Name.Trim().Length > 0) && !string.IsNullOrEmpty(ImageUrl);
        }
        [ProtoBuf.ProtoMember(24)]
        public int OriginPrice { get; set; }
        public string DeliveryInfo { get; set; }


        [ProtoBuf.ProtoMember(10)]
        public bool CheckPriceVn { get; set; }

        [ProtoBuf.ProtoMember(11)]
        public int Warranty { get; set; }

        [ProtoBuf.ProtoMember(12)]
        public List<string> ImageUrls { get; set; }

        public string ImageUrl
        {
            get
            {
                return (ImageUrls == null || ImageUrls.Count == 0) ? "" : ImageUrls[0];
            }
        }

        [ProtoBuf.ProtoMember(13)]
        public Common.ProductStatus Status { get; set; }

        [ProtoBuf.ProtoMember(14)]
        public string Manufacture { get; set; }

        [ProtoBuf.ProtoMember(15)]
        public string Origin { get; set; }
        //public string Content { get; set; }

        [ProtoBuf.ProtoMember(16)]
        public String DetailUrl { get; set; }

        [ProtoBuf.ProtoMember(17)]
        public String Promotion { get; set; }

        [ProtoBuf.ProtoMember(18)]
        public String Summary { get; set; }

        [ProtoBuf.ProtoMember(19)]
        public String ProductContent { get; set; }

        [ProtoBuf.ProtoMember(20)]
        public int AddPosition { get; set; }

        [ProtoBuf.ProtoMember(21)]
        public String Domain
        {
            get;
            set;
        }
        public Product()
        {
            Name = "";
            Categories = new List<string> { };
            IDCategories = 0;
            Promotion = "";
            PromotionInfo = "";
            VATInfo = "";
            Price = 0;
            Summary = "";
            Warranty = 0;
            DetailUrl = "";
            ProductContent = "";
            OriginPrice = 0;
            DeliveryInfo = "";
            StartDeal = SqlDb.MinDateDb;
            EndDeal = SqlDb.MinDateDb;
            ShortDescription = "";
            ProductDuplicate = 0;

            VideoDescHtml = "";
            SpecsDescHtml = "";
            FullDescHtml = "";
            ShortDescHtml = "";

        }
        public string ShortDescription { get; set; }
        public int VATStatus { set; get; }
        [ProtoBuf.ProtoMember(22)]
        private string[] BlackCategory = new string[] { "trang chủ" };

        [ProtoBuf.ProtoMember(23)]
        public long IDCongTy;


        public void Analytics(GABIZ.Base.HtmlAgilityPack.HtmlDocument doc, String detailUrl, Configuration configXPath, bool checkPrice, string domain, IDatabase dbRedisProduct = null)
        {
            try
            {
                this.IDCongTy = configXPath.CompanyID;
                this.Domain = domain;
                this.DetailUrl = detailUrl;
                this.ID = Common.GetIDProduct(detailUrl);
                var rootUri = new Uri(detailUrl);

                #region Name
                Name = "";
                if (configXPath.ProductNameXPath.Count == 0)
                    return;
                for (int i = 0; i < configXPath.ProductNameXPath.Count; i++)
                {
                    if (configXPath.ProductNameXPath[i].Trim() != "")
                    {
                        var node_productName = doc.DocumentNode.SelectSingleNode(configXPath.ProductNameXPath[i]);
                        if (node_productName != null)
                        {
                            var TempName = Tools.removeHTML(node_productName.InnerText).Trim();
                            if (((string.IsNullOrEmpty(Name) ? "" : " ") + Common.ParseName(TempName)).Length > 500)
                            {
                                Name += ((string.IsNullOrEmpty(Name) ? "" : " ") + Common.ParseName(TempName)).Substring(0, 500);
                            }
                            else
                            {
                                Name += (string.IsNullOrEmpty(Name) ? "" : " ") + Common.ParseName(TempName);
                            }
                        }
                    }
                }
                this.HashName = Common.GetHashNameProduct(domain, Name.Trim());
                #endregion

                #region {ShortDescription}
                try
                {
                    ShortDescription = "";
                    if (configXPath.ShortDescriptionXPath != null
                        && configXPath.ShortDescriptionXPath.Count > 0)
                    {
                        for (int i = 0; i < configXPath.ShortDescriptionXPath.Count; i++)
                        {
                            if (configXPath.ShortDescriptionXPath[i].Trim() != "")
                            {
                                var node_ShortDescription = doc.DocumentNode.SelectSingleNode(configXPath.ShortDescriptionXPath[i]);
                                if (node_ShortDescription != null)
                                {
                                    var TempName = Tools.removeHTML(node_ShortDescription.InnerText).Trim();
                                    ShortDescription += (string.IsNullOrEmpty(ShortDescription) ? "" : " ") + Common.ParseName(TempName);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
                #endregion

                #region Categories
                #region Get Cat
                Categories = new List<string>();
                Categories.Add(domain);
                if (configXPath.CategoryXPath.Count == 1 && configXPath.CategoryXPath[0] == "url")
                {
                    Categories = Common.CompactUrl(detailUrl.ToLower()).Split(new char[] { '/' }
                        , StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                else
                {
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
                                    string s = Tools.removeHTML(node_categories[i].InnerText).Trim(new char[] { ' ', '-', '»', '>', '<' });
                                    if (!Categories.Contains(s))
                                        if (!BlackCategory.Contains(s.ToLower()))
                                            Categories.Add(s);
                                }
                            }
                        }
                    }
                }
                if (configXPath.RemoveLastItemClassification && Categories.Count > 1) Categories.RemoveAt(Categories.Count - 1);
                #endregion

                #region {Get OriginalPrice}
                if (configXPath.OriginPriceXPath != null
                    && configXPath.OriginPriceXPath.Count > 0
                    && configXPath.OriginPriceXPath[0].Trim() != "")
                {
                    var node_price = doc.DocumentNode.SelectNodes(configXPath.OriginPriceXPath[0]);
                    if (node_price != null)
                    {
                        int K = node_price.Count;
                        for (int j = 0; j < K; j++)
                        {
                            string s = Tools.removeHTML(node_price[j].InnerText);
                            OriginPrice = Common.ParsePrice(s, checkPrice);
                            if (OriginPrice > 0) break;
                        }
                    }
                }
                #endregion

                #region {Get DeliveryInfo}
                if (configXPath.OriginPriceXPath != null
                    && configXPath.DeliveryInfoXPath.Count > 0
                    && configXPath.DeliveryInfoXPath[0].Trim() != "")
                {
                    var node_DeliveryInfo = doc.DocumentNode.SelectNodes(configXPath.DeliveryInfoXPath[0]);
                    if (node_DeliveryInfo != null)
                    {
                        int K = node_DeliveryInfo.Count;
                        for (int j = 0; j < K; j++)
                        {
                            string s = QT.Entities.Common.RemoveDumplicateSpace(Tools.removeHTML(node_DeliveryInfo[j].InnerText));
                            if (!string.IsNullOrEmpty(s) && Common.CheckRegex(s, configXPath.RegexDeliveryInfoXPath, null, false))
                            {
                                DeliveryInfo = s;
                                break;
                            }
                        }
                    }
                }
                #endregion


                Categories = Categories.ToList();
                IDCategories = Common.GetIDClassification(Common.ConvertToString(Categories, " -> ")); 
                #endregion

                #region get Price
                switch (rootUri.DnsSafeHost)
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
                                        string s = Tools.removeHTML(node_price[j].InnerText);
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
                                        string s = Tools.removeHTML(node_price[j].InnerText);
                                        priceGiam = Common.ParsePrice(s, checkPrice);
                                    }
                                }
                            }
                        }
                        Price = priceOld - priceGiam;
                        break;
                    case "www.trananh.vn":
                        for (int i = 0; i < configXPath.PriceXPath.Count; i++)
                        {
                            if (configXPath.PriceXPath[i].Trim() != "")
                            {
                                var node_price = doc.DocumentNode.SelectNodes(configXPath.PriceXPath[i]);
                                if (node_price != null && node_price.Count > 0)
                                {
                                    int K = node_price.Count;
                                    for (int j = 0; j < K; j++)
                                    {
                                        int v = 0;
                                        string s = QT.Entities.Common.ChuanHoaUnicode(Tools.removeHTML(node_price[j].InnerText).Trim().ToLower());
                                        try
                                        {
                                            if (s == "" && System.Text.RegularExpressions.Regex.IsMatch(configXPath.PriceXPath[i], ".*@[a-z1-9]*$"))
                                            {
                                                List<string> lstData = QT.Entities.Common.GetTextInNode(doc, configXPath.PriceXPath[i]);
                                                if (lstData != null && lstData.Count > 0)
                                                {
                                                    s = QT.Entities.Common.GetTextInNode(doc, configXPath.PriceXPath[i])[0];
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                        }


                                        if (Common.CheckRegex(s,
                                            new List<string> { configXPath.RegexPrice },
                                            new List<string> { configXPath.RegexNoPrice },
                                            configXPath.DefaultRegexPrice))
                                        {
                                            s = QT.Entities.Common.SubPriceString(s);
                                            v = Common.ParsePrice(s, checkPrice) * 1000;
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
                    default:
                        for (int i = 0; i < configXPath.PriceXPath.Count; i++)
                        {
                            if (configXPath.PriceXPath[i].Trim() != "")
                            {
                                var node_price = doc.DocumentNode.SelectNodes(configXPath.PriceXPath[i]);
                                if (node_price != null && node_price.Count > 0)
                                {
                                    int K = node_price.Count;
                                    for (int j = 0; j < K; j++)
                                    {
                                        int v = 0;
                                        string s = QT.Entities.Common.ChuanHoaUnicode(Tools.removeHTML(node_price[j].InnerText).Trim().ToLower());
                                        try
                                        {
                                            if (s == "" && System.Text.RegularExpressions.Regex.IsMatch(configXPath.PriceXPath[i], ".*@[a-z1-9]*$"))
                                            {
                                                List<string> lstData = QT.Entities.Common.GetTextInNode(doc, configXPath.PriceXPath[i]);
                                                if (lstData != null && lstData.Count > 0)
                                                {
                                                    s = QT.Entities.Common.GetTextInNode(doc, configXPath.PriceXPath[i])[0];
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                        }


                                        if (Common.CheckRegex(s,
                                            new List<string> { configXPath.RegexPrice },
                                            new List<string> { configXPath.RegexNoPrice },
                                            configXPath.DefaultRegexPrice))
                                        {
                                            s = QT.Entities.Common.SubPriceString(s);
                                            v = Common.ParsePrice(s, checkPrice);
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
                #endregion

                VATStatus = configXPath.VATStatus;

                #region Get VAT Info.
                //XuanTrang-20150106.1
                try
                {
                    foreach (string VATInfoXPath in configXPath.VATInfoXPath)
                    {
                        if (VATInfoXPath.Trim() != "")
                        {
                            var node_VAT = doc.DocumentNode.SelectSingleNode(VATInfoXPath);
                            if (node_VAT != null)
                            {
                                string tempVAT = Tools.removeHTML(node_VAT.InnerText);
                                if (Common.ParseVATInfo(tempVAT) != -1)
                                {
                                    VATInfo += (string.IsNullOrEmpty(VATInfo) ? "" : " ") + tempVAT;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }

                try
                {
                    foreach (string PromotionInfoXPath in configXPath.PromotionInfoXPath)
                    {
                        if (PromotionInfoXPath.Trim() != "")
                        {
                            var node_VAT = doc.DocumentNode.SelectSingleNode(PromotionInfoXPath);
                            if (node_VAT != null)
                            {
                                string tempPromotion = Tools.removeHTML(node_VAT.InnerText);
                                if (Common.ParsePromotionInfo(tempPromotion) != -1)
                                {
                                    PromotionInfo = Common.RemoveDumplicateSpace((string.IsNullOrEmpty(PromotionInfo) ? "" : " ") + tempPromotion);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }

                //End.1
                #endregion

                #region {StartDeal}
                try
                {
                    for (int i = 0; i < configXPath.StartDealXPath.Count; i++)
                    {
                        if (configXPath.StartDealXPath[i].Trim() != "")
                        {
                            var node_StartDeal = doc.DocumentNode.SelectSingleNode(configXPath.StartDealXPath[i]);
                            if (node_StartDeal != null)
                            {
                                string data = Tools.removeHTML(node_StartDeal.InnerText).TrimEnd(new char[] { '-', ' ', '>' });
                                DateTime dt = Common.ParseDateTime(data);
                                if (dt != SqlDb.MinDateDb)
                                {
                                    this.StartDeal = dt;
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    this.EndDeal = SqlDb.MinDateDb;
                }
                #endregion

                #region {EndDeal}
                try
                {
                    for (int i = 0; i < configXPath.EndDealXPath.Count; i++)
                    {
                        if (configXPath.EndDealXPath[i].Trim() != "")
                        {
                            var node_EndDate = doc.DocumentNode.SelectSingleNode(configXPath.EndDealXPath[i]);
                            if (node_EndDate != null)
                            {
                                string data = Tools.removeHTML(node_EndDate.InnerText).TrimEnd(new char[] { '-', ' ', '>' });
                                DateTime dt = Common.ParseDateTime(data);
                                if (dt != SqlDb.MinDateDb)
                                {
                                    this.EndDeal = dt;
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    this.StartDeal = SqlDb.MinDateDb;
                }
                #endregion

                #region get Warranty
                try
                {
                    for (int i = 0; i < configXPath.WarrantyXPath.Count; i++)
                    {
                        if (configXPath.WarrantyXPath[i].Trim() != "")
                        {
                            var node_warranty = doc.DocumentNode.SelectSingleNode(configXPath.WarrantyXPath[i]);
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
                }
                catch (Exception ex)
                {

                }
                #endregion

                #region get Status
                try
                {
                    for (int i = 0; i < configXPath.StatusXPath.Count; i++)
                    {
                        if (configXPath.StatusXPath[i].Trim() != "")
                        {
                            var ls_node_status = doc.DocumentNode.SelectNodes(configXPath.StatusXPath[i]);
                            if (ls_node_status != null && ls_node_status.Count > 0)
                            {
                                foreach (var node_status in ls_node_status)
                                {
                                    string s_s = QT.Entities.Common.ChuanHoaUnicode(Tools.removeHTML(node_status.InnerText).Trim().Replace("&nbsp;", "")).ToLower();
                                    if (s_s == "không còn hàng")
                                    {
                                        s_s = s_s.Replace(" còn hàng", "");
                                    }
                                    Status = QT.Entities.CrawlerProduct.ProductStatusRegex.Instance().GetStatusProduct(s_s);             // Common.ParseStatus(s_s);
                                    if (Status != Common.ProductStatus.NotDefine) break;
                                }
                                if (Status != Common.ProductStatus.NotDefine) break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                this.Instock = QT.Entities.Common.GetProductInstockFormStatus(this.Status);
                #endregion

                #region get Images
                try
                {
                    ImageUrls = new List<string>();
                    for (int i = 0; i < configXPath.ImageXPath.Count; i++)
                    {
                        if (configXPath.ImageXPath[i].Trim() != "")
                        {
                            var node_image = doc.DocumentNode.SelectNodes(configXPath.ImageXPath[i]);
                            if (node_image != null && node_image.Count > 0)
                            {
                                List<string> _imgUrl = null;
                                for (int j = 0; j < node_image.Count; j++)
                                {
                                    //Chỉ định thẻ.
                                    if (Regex.IsMatch(configXPath.ImageXPath[i], @".*\/@[^\/]+$"))
                                    {
                                        List<string> lst = new List<string>();
                                        string attribute = Regex.Match(configXPath.ImageXPath[i], @"\/@[^\/]+$").Captures[0].Value.ToString().Replace("@", "").Replace("/", "");
                                        string image = node_image[j].Attributes[attribute].Value.ToString();
                                        if (!string.IsNullOrEmpty(image))
                                        {
                                            if (!image.Contains("http")) image = QT.Entities.Common.GetAbsoluteUrl(image, QT.Entities.Common.GetWebsiteFromUrl(detailUrl));
                                            ImageUrls.Add((configXPath.AutoFixLinkImage) ? QT.Entities.Common.FixParalinkImage(image) : image);
                                        }
                                    }
                                    else
                                    {
                                        _imgUrl = Common.ParseImage(node_image[j].OuterHtml, rootUri, configXPath.ImageGetFromRoot);
                                        foreach (var image in _imgUrl)
                                        {
                                            string image1 = (configXPath.AutoFixLinkImage) ? QT.Entities.Common.FixParalinkImage(image) : image;
                                            ImageUrls.Add(image1);
                                        }
                                    }
                                }
                                ImageUrls = ImageUrls.Distinct().ToList();
                            }
                        }
                    }
                }
                catch (Exception ex01)
                {

                }
                #endregion

                #region get Manufacture
                for (int i = 0; i < configXPath.ManufactureXPath.Count; i++)
                {
                    if (configXPath.ManufactureXPath[i].Trim() != "")
                    {
                        var node_Manufacture = doc.DocumentNode.SelectSingleNode(configXPath.ManufactureXPath[i]);
                        if (node_Manufacture != null)
                        {
                            Manufacture = Tools.removeHTML(node_Manufacture.InnerText).TrimEnd(new char[] { '-', ' ', '>' });
                        }
                    }
                }
                #endregion

                #region OriginPrice
                //get Origin
                for (int i = 0; i < configXPath.OriginXPath.Count; i++)
                {
                    if (configXPath.OriginXPath[i].Trim() != "")
                    {
                        var node_Origin = doc.DocumentNode.SelectSingleNode(configXPath.OriginXPath[i]);
                        if (node_Origin != null)
                        {
                            Manufacture = Tools.removeHTML(node_Origin.InnerText).TrimEnd(new char[] { '-', ' ', '>' });
                        }
                    }
                }
                #endregion

                #region {Promotion}
                for (int i = 0; i < configXPath.PromotionXPath.Count; i++)
                {
                    if (configXPath.PromotionXPath[i].Trim() != "")
                    {
                        var node = doc.DocumentNode.SelectSingleNode(configXPath.PromotionXPath[i]);
                        if (node != null)
                        {
                            Promotion = node.InnerHtml.Trim();
                        }
                        break;
                    }
                }
                #endregion

                this.VideoDescHtml = GetDesc(doc, configXPath.VideoXpath);
                this.SpecsDescHtml = GetDesc(doc, configXPath.SpecsXPath);
                this.FullDescHtml = GetDesc(doc, configXPath.FullDescXPath);
                this.ShortDescHtml = GetDesc(doc, configXPath.ShortDescriptionXPath);
               

                for (int i = 0; i < configXPath.SummaryXPath.Count; i++)
                {
                    if (configXPath.SummaryXPath[i].Trim() != "")
                    {
                        var node = doc.DocumentNode.SelectSingleNode(configXPath.SummaryXPath[i]);
                        if (node != null)
                        {
                            Summary = Common.ChuanHoaContent(node.InnerHtml.Trim());
                        }
                    }
                    break;
                }

                try
                {
                    if (configXPath.RegexNotValid != null && configXPath.RegexNotValid.Count > 0
                        && configXPath.ValidXPath != null && configXPath.ValidXPath.Count > 0)
                    {
                        string allText = "";
                        foreach (var itemXPath in configXPath.ValidXPath)
                        {
                            string text = Common.ConvertToString(Common.GetTextInNode(doc, itemXPath), ">");
                            allText = allText + ">" + text;
                        }
                        foreach (var itemRegex in configXPath.RegexNotValid)
                        {
                            if (Regex.IsMatch(allText, itemRegex)) this.Valid = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                }

                //get Content
                try
                {
                    if (configXPath.ContentXPath != null && configXPath.ContentXPath.Count > 0)
                    {
                        for (int i = 0; i < configXPath.ContentXPath.Count; i++)
                        {
                            if (configXPath.ContentXPath[i].Trim() != "")
                            {
                                var node = doc.DocumentNode.SelectSingleNode(configXPath.ContentXPath[i]);
                                if (node != null)
                                {
                                    Common.ReplaceNodeValue(node, "style", "");
                                    ProductContent = Common.ChuanHoaContent(node.InnerHtml.Trim());

                                    //Xóa các thẻ xuống dòng.
                                    ProductContent = Regex.Replace(ProductContent, @"<\/*\s*br\s*\/*>", "");

                                    if (ProductContent != "") break;
                                }
                            }
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
            catch (Exception ex01)
            {
                var str = ex01.Message;
                str += "1";
            }
            Valid = IsSuccessData(checkPrice);
        }

        private string GetDesc(GABIZ.Base.HtmlAgilityPack.HtmlDocument doc, string p)
        {
            try
            {
                return GetDesc(doc, p.Split(Common.arSplitToList, StringSplitOptions.RemoveEmptyEntries).ToList());
            }
            catch (Exception e)
            {
                return "";
            }
        }

        private string GetDesc(GABIZ.Base.HtmlAgilityPack.HtmlDocument doc, List<string> lstXPath)
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

     


        public Uri RootUri { get; set; }

        public IEnumerable<string> BlBackCategory { get; set; }

        public DateTime StartDeal { get; set; }
        public DateTime EndDeal { get; set; }

        public bool IsDeal
        {
            get { return this.Price > 0 && (this.OriginPrice > this.Price); }
        }

        public List<string> OriginalUrl { set; get; }
   
        public long GetHashChange()
        {
            return GetHashChangeInfo(Convert.ToInt32(this.Instock), this.Valid, this.Price, this.Name, this.ImageUrl, this.IDCategories, ShortDescription);            
        }

        public static long GetHashChangeInfo(int instock, bool valid, long price, string name, string imageUrl, long idCategories, string shortDescription)
        {
            var fullHashChange =
                Convert.ToInt32(instock)
                + "_" + price
                + "_" + name
                + "_" + imageUrl
                + "_" + idCategories + "_" + shortDescription;
            return Math.Abs(Tools.getCRC64(fullHashChange));
        }

   

        public long GetHashImage()
        {
            return Math.Abs(Tools.getCRC64(this.ImageUrl));
        }

        public static long GetHashImageInfo(string imageUrl)
        {
            return Math.Abs(Tools.getCRC64(imageUrl));
        }

        public long GetHashCheckDuplicate()
        {
            return Product.GetHashDuplicate(this.Domain, this.Price, this.Name, this.ImageUrl);
        }

        public static long GetHashDuplicate(string Domain, long Price, string Name, string ImageUrl)
        {
            string RealPathImage = QT.Entities.Common.GetRealPathInWeb(ImageUrl);
            string strHash = Domain + Price.ToString() + Name.ToString() + RealPathImage.ToString();
            long hash = Math.Abs(GABIZ.Base.Tools.getCRC64(strHash));
            return hash;
        }

        public Common.ProductInstock Instock { get; set; }

        public long ProductDuplicate { get; set; }

        public static byte[] GetMess(Product _product)
        {
            throw new NotImplementedException();
        }
        public static byte[] GetMessage(Product product)
        {
            byte[] msgOut;

            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, product);
                msgOut = stream.ToArray();
            }
            return msgOut;
        }
        public static Product GetDataFromMessage(byte[] message)
        {
            Product result = new Product();
            using (var stream = new MemoryStream(message))
            {
                result = Serializer.Deserialize<Product>(stream);
            }
            return result;
        }

        public string TestXpath(string DetailUrl, string configXpath)
        {
            string Text = "";
            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(DetailUrl, 45, 2);
            html = html.Replace("<form", "<div");
            html = html.Replace("</form", "</div");
            doc.LoadHtml(html);
            if (!string.IsNullOrEmpty(configXpath))
            {
                var Nodes = doc.DocumentNode.SelectNodes(configXpath);
                if (Nodes != null)
                {
                    foreach (var node in Nodes)
                    {
                        Text = node.InnerText.ToString();
                    }
                }
            }
            else
            {
                Text = "Không phân tích được!";
            }
            return Text;
        }

        public string VideoDescHtml { get; set; }

        public string FullDescHtml { get; set; }

        public string SpecsDescHtml { get; set; }

        public long GetHashDesc()
        {
           return Math.Abs(GABIZ.Base.Tools.getCRC64(this.FullDescHtml+this.SpecsDescHtml+this.VideoDescHtml+this.ShortDescHtml));
        }

        public string GetFullDesc()
        {

            return this.FullDescHtml + this.SpecsDescHtml + this.VideoDescHtml + this.ShortDescription;

        }

        public string ShortDescHtml { get; set; }
    }


    public class Alexa
    {
        public string Contries { get; set; }
        public int AlexaRank { get; set; }
        public int AlexaRankContries { get; set; }
    }

    public class CrawlerDomain
    {
        /// <summary>
        /// Bóc tách nội dữ liệu
        /// </summary>
        /// <param name="html"></param>
        /// <param name="detailUrl"></param>
        /// <param name="configXPath"></param>
        /// <param name="checkPrice"></param>
        public List<QT.Entities.Company> Analytics(GABIZ.Base.HtmlAgilityPack.HtmlDocument docRoot, Configuration configXPath, string urlAnalytics)
        {
            List<QT.Entities.Company> r = new List<Company>();
            try
            {
                List<string> listCompany = new List<string>();

                #region Get List block domain
                for (int p = 0; p < configXPath.ContentAnanyticXPath.Count; p++)
                {
                    if (configXPath.ContentAnanyticXPath[p].Trim() != "")
                    {
                        var node_categories = docRoot.DocumentNode.SelectNodes(configXPath.ContentAnanyticXPath[p]);
                        if (node_categories != null)
                        {
                            int K = node_categories.Count;

                            for (int i = 0; i < K; i++)
                            {
                                string s = node_categories[i].OuterHtml;
                                listCompany.Add(s);
                            }
                        }
                    }
                }
                #endregion
                for (int j = 0; j < listCompany.Count; j++)
                {
                    QT.Entities.Company item = new Company(0);
                    GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                    String html = listCompany[j];
                    doc.LoadHtml(html);
                    /// get name
                    for (int i = 0; i < configXPath.ProductNameXPath.Count; i++)
                    {
                        if (configXPath.ProductNameXPath[i].Trim() != "")
                        {
                            var node_productName = doc.DocumentNode.SelectSingleNode(configXPath.ProductNameXPath[i]);
                            if (node_productName != null)
                            {
                                item.Name = Tools.removeHTML(node_productName.InnerText).Trim();
                                item.Name = Common.ParseName(item.Name);
                                break;
                            }
                        }
                    }
                    #region  get domain
                    for (int i = 0; i < configXPath.PriceXPath.Count; i++)
                    {
                        if (configXPath.PriceXPath[i].Trim() != "")
                        {
                            var node = doc.DocumentNode.SelectSingleNode(configXPath.PriceXPath[i]);
                            if (node != null)
                            {
                                string s = node.Attributes["href"].Value;
                                item.Website = s;
                                Uri uri = new Uri(s);
                                String domain = uri.Host.ToLower();
                                item.Domain = domain.Replace("www.", "");
                                item.ID = Common.GetIDCompany(item.Domain);
                                break;
                            }
                        }
                    }
                    #endregion
                    #region get Images
                    Uri uriRoot = new Uri(urlAnalytics);
                    for (int i = 0; i < configXPath.ImageXPath.Count; i++)
                    {
                        if (configXPath.ImageXPath[i].Trim() != "")
                        {
                            var node_image = doc.DocumentNode.SelectNodes(configXPath.ImageXPath[i]);
                            if (node_image != null)
                            {
                                for (int jj = 0; jj < node_image.Count; jj++)
                                {
                                    List<string> _imgUrl = Common.ParseImage(node_image[jj].OuterHtml, uriRoot, configXPath.ImageGetFromRoot);
                                    if (_imgUrl.Count > 0)
                                    {
                                        item.Image = _imgUrl[0].ToString();
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    #endregion

                    #region  get Address
                    for (int i = 0; i < configXPath.WarrantyXPath.Count; i++)
                    {
                        if (configXPath.WarrantyXPath[i].Trim() != "")
                        {
                            var node = doc.DocumentNode.SelectSingleNode(configXPath.WarrantyXPath[i]);
                            if (node != null)
                            {
                                item.Address = Tools.removeHTML(node.InnerText).Trim();
                                item.Address = Common.ParseName(item.Address);
                                break;
                            }
                        }
                    }
                    #endregion
                    #region  get Phone
                    for (int i = 0; i < configXPath.StatusXPath.Count; i++)
                    {
                        if (configXPath.StatusXPath[i].Trim() != "")
                        {
                            var node = doc.DocumentNode.SelectSingleNode(configXPath.StatusXPath[i]);
                            if (node != null)
                            {
                                item.Phone = Tools.removeHTML(node.InnerText).Trim();
                                item.Phone = Common.ParsePhone(item.Phone);
                                break;
                            }
                        }
                    }
                    #endregion
                    #region  get Faxx
                    for (int i = 0; i < configXPath.ManufactureXPath.Count; i++)
                    {
                        if (configXPath.ManufactureXPath[i].Trim() != "")
                        {
                            var node = doc.DocumentNode.SelectSingleNode(configXPath.ManufactureXPath[i]);
                            if (node != null)
                            {
                                item.Fax = Tools.removeHTML(node.InnerText).Trim();
                                item.Fax = Common.ParseName(item.Phone);
                                break;
                            }
                        }
                    }
                    #endregion

                    #region  get Yahoo
                    for (int i = 0; i < configXPath.OriginXPath.Count; i++)
                    {
                        if (configXPath.OriginXPath[i].Trim() != "")
                        {
                            var node = doc.DocumentNode.SelectSingleNode(configXPath.OriginXPath[i]);
                            if (node != null)
                            {
                                string s = Tools.removeHTML(node.InnerText).Trim();
                                item.Yahoo = s;
                            }
                        }
                    }
                    #endregion
                    if (item.Domain.Length > 0)
                    {
                        r.Add(item);
                    }
                }
            }
            catch (Exception)
            {
            }
            return r;

        }
    }

    //public class CompanyEntities
    //{
    //    public long ID { get; set; }
    //    public string Name { get; set; }
    //    public string Domain { get; set; }
    //    public string URLRoot { get; set; }
    //    public string Phone { get; set; }
    //    public string Fax { get; set; }
    //    public string Address { get; set; }
    //    public string Yahoo{ get; set; }
    //    public string Logo{ get; set; }
    //}
    #region Product concung.com
    public class CuaHang
    {
        public string name { get; set; }
    }

    public class ThuocTinh
    {
        public string attribute_name { get; set; }
        public string attribute_group { get; set; }
        public string img { get; set; }
    }

    public class ProductConCung
    {
        public string MaHang { get; set; }
        public string TenSanPham { get; set; }
        public string reference { get; set; }
        public string MoTaNgan { get; set; }
        public string Mota { get; set; }
        public string GiaNiemYet { get; set; }
        public string GiaBan { get; set; }
        public string ProductUrl { get; set; }
        public string image_default { get; set; }
        public List<CuaHang> CuaHang { get; set; }
        public string ThuongHieu { get; set; }
        public List<ThuocTinh> ThuocTinh { get; set; }
        public List<string> Category { get; set; }
    }
    #endregion
}
