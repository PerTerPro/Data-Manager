using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websosanh.Datafeed.Entity
{
    public class DataFeedConfigDapper
    {
        public string DatafeedConfigID { get; set; }
        public string CompanyID { get; set; }
        public string ProductListNode { get; set; }
        public string ProductItemNode { get; set; }
        public string SkuNode { get; set; }
        public string InstockNode { get; set; }
        public string BrandNode { get; set; }
        public string ProductNameNode { get; set; }
        public string ShortDescriptionNode { get; set; }
        public string DescriptionNode { get; set; }
        public string CurrencyNode { get; set; }
        public string PriceNode { get; set; }
        public string DiscountedPriceNode { get; set; }
        public string DiscountNode { get; set; }
        public string Category1Node { get; set; }
        public string ParentOfCategory1Node { get; set; }
        public string ParentOfParentOfCategory1Node { get; set; }
        public string Category2Node { get; set; }
        public string ParentOfCategory2Node { get; set; }
        public string ParentOfParentOfCategory2Node { get; set; }
        public string PictureUrl1Node { get; set; }
        public string PictureUrl2Node { get; set; }
        public string PictureUrl3Node { get; set; }
        public string PictureUrl4Node { get; set; }
        public string PictureUrl5Node { get; set; }
        public string UrlNode { get; set; }
        public string CurrencyFormat { get; set; }
        public string WarrantyNode { get; set; }
        public string XNameSpace { get; set; }
        public string RegexConfigUrl { get; set; }
        public string VATStatusNode { get; set; }
    }
}
