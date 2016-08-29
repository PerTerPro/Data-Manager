using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GABIZ.Base;
using System.Text.RegularExpressions;
using MongoDB.Bson.IO;
using QT.Entities.Data;
using StackExchange.Redis;

namespace QT.Entities
{
    public class ProductStatusChange
    {
        public bool IsNew { get; set; }
        public bool IsChangeImage { get; set; }
        public bool IsChangeDesc { get; set; }
        public bool IsChangePrice { get; set; }
        public bool IsChangeBasic { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDuplicate { get; set; }

        public ProductStatusChange()
        {
            IsChangeBasic =
                IsChangeImage =
                    IsChangePrice =
                        IsChangeDesc =
                            IsDelete =
                                IsDuplicate =
                                    IsNew = false;
        }


        public bool CheckChange()
        {
            return IsNew | IsChangeBasic | IsChangeDesc | IsChangeImage | IsChangePrice | IsDelete | IsDuplicate;
        }
    }

    public class ProductEntity
    {
        public ProductStatusChange StatusChange = new ProductStatusChange();

        private string[] _blackCategory = new string[] { "trang chủ" };

        public bool Valid { get; set; }
        public string PromotionInfo { get; set; }
        public string VatInfo { get; set; }
        public long ID { get; set; }
        public long OldPrice { get; set; }
        public long HashName { get; set; }
        public string Name { get; set; }
        public string MerchantSku { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Session { get; set; }

        public long IdCategories
        {
            get
            {
                return Categories == null ? 0 : Common.GetIDClassification(Common.ConvertToString(Categories, " -> "));
            }
        }

        public string GetCategoryString()
        {
            return (Categories == null) ? "" : Common.ConvertToString(Categories, " -> ");
        }

        public List<string> Categories { get; set; }
        public long Price { get; set; }
        public long CompanyId { get; set; }

        public string ImageUrl
        {
            get { return (ImageUrls == null || ImageUrls.Count == 0) ? "" : ImageUrls[0]; }
        }

        public string GetFullDesc()
        {
            return this.FullDescHtml + this.SpecsDescHtml + this.VideoDescHtml + this.ShortDescription;
        }

        public byte[] GetArbyteJson()
        {
            return Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(this));
        }

        public static ProductEntity GetFromJson(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ProductEntity>(input);
        }

        public static ProductEntity GetFromJson(byte[] input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ProductEntity>(UTF8Encoding.UTF8.GetString(input));
        }

        public string GetJSON()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public bool IsSuccessData(bool checkPrice)
        {
            if (checkPrice)
                return (Price >= 1000) && (Price % 100 == 0) && (Name.Trim().Length > 0) &&
                       !string.IsNullOrEmpty(ImageUrl);
            return Price > 0 && (Name.Trim().Length > 0) && !string.IsNullOrEmpty(ImageUrl);
        }

        public long OriginPrice { get; set; }
        public string DeliveryInfo { get; set; }
        public bool CheckPriceVn { get; set; }
        public int Warranty { get; set; }
        public List<string> ImageUrls { get; set; }
        public Common.ProductStatus Status { get; set; }
        public string Manufacture { get; set; }
        public string Origin { get; set; }
        public String DetailUrl { get; set; }
        public String Promotion { get; set; }
        public String Summary { get; set; }
        public String ProductContent { get; set; }
        public int AddPosition { get; set; }
        public string ShortDescription { get; set; }
        public int VATStatus { set; get; }
        public string VideoDescHtml { get; set; }
        public string FullDescHtml { get; set; }
        public string SpecsDescHtml { get; set; }
        public String Domain { get; set; }

        public ProductEntity()
        {
            CompanyId = 0;
            Name = "";
            Categories = new List<string> { };
            Promotion = "";
            PromotionInfo = "";
            VatInfo = "";
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
            return GetHashChangeInfo(Convert.ToInt32(this.Instock), this.Valid, this.Price, this.Name, this.ImageUrl,
                this.IdCategories, ShortDescription, OriginPrice);

        }

        public static long GetHashChangeInfo(int instock, bool valid, long price, string name, string imageUrl,
            long idCategories, string shortDescription, long originPrice)
        {
            var fullHashChange =
                Convert.ToInt32(instock)
                + "_" + price
                + "_" + name
                + "_" + imageUrl
                + "_" + idCategories
                + "_" + shortDescription
                + "_" + originPrice;
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

        public long GetHashDuplicate()
        {
            return Product.GetHashDuplicate(this.Domain, this.Price, this.Name, this.ImageUrl);
        }

        public static long GetHashDuplicate(string domain, long price, string name, string imageUrl)
        {
            var realPathImage = Common.GetRealPathInWeb(imageUrl);
            var strHash = domain + price + name + realPathImage;
            var hash = Math.Abs(Tools.getCRC64(strHash));
            return hash;
        }

        public Common.ProductInstock Instock { get; set; }
        public long ProductDuplicate { get; set; }

        public bool IsNews { get; set; }

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



        public long GetHashDesc()
        {
            return Math.Abs(Tools.getCRC64(FullDescHtml + SpecsDescHtml + VideoDescHtml + ShortDescHtml));
        }


        public string ShortDescHtml { get; set; }


        public override string ToString()
        {
            string strReturn = "";
            strReturn += string.Format("\nID:{0}", ID);
            strReturn += string.Format("\nName:{0}", Name);
            strReturn += string.Format("\nPrice:{0}", Price);
            strReturn += string.Format("\nPromotionInfo:{0}", PromotionInfo);
            strReturn += string.Format("\nVATInfo:{0}", VatInfo);
            strReturn += string.Format("\nSortDescription:{0}", ShortDescription);
            strReturn += string.Format("\nCategories:{0} \nCategoryID:{1}", Common.ConvertToString(Categories, " -> "), IdCategories);
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

        public string NameFT
        {
            get { return Common.UnicodeToKoDauFulltext(Name + " " + Domain); }
        }
    }
}
