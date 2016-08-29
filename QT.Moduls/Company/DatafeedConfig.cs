using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QT.Moduls.Company
{
    public class DatafeedConfig
    {
        public string ProductListNode {get; set; }
        public string ProductItemNode {get; set; }
        public string SkuNode {get; set; }
        public string InstockNode {get; set; }
        public string BrandNode {get; set; }
        public string ProductNameNode {get; set; }
        public string ShortDescriptionNode { get; set; }
        public string DescriptionNode {get; set; }
        public string CurrencyNode {get; set; }
        public string PriceNode {get; set; }
        public string DiscountedPriceNode {get; set; }
        public string DiscountNode { get; set; } 
        public string Category1Node {get; set; }
        public string ParentOfCategory1Node {get; set; }
        public string ParentOfParentOfCategory1Node {get; set; }
        public string Category2Node {get; set; }
        public string ParentOfCategory2Node {get; set; }
        public string ParentOfParentOfCategory2Node {get; set; }
        public string PictureUrl1Node {get; set; }
        public string PictureUrl2Node {get; set; }
        public string PictureUrl3Node {get; set; }
        public string PictureUrl4Node {get; set; }
        public string PictureUrl5Node {get; set; }
        public string UrlNode {get; set; }
        public CurrencyFormat CurrencyFormat { get; set; }

        public string WarrantyNode { set; get; }
        public string XNameSpace { set; get; }
        public string RegexConfigUrl { set; get; }

        public string VATStatus { set; get; }
        public static DatafeedConfig GetDefaultXMLDatafeedConfig()
        {
            return new DatafeedConfig
            {
                ProductListNode = "Products",
                ProductItemNode = "Product",
                SkuNode = "simple_sku",
                InstockNode = "availability_instock",
                BrandNode = "brand",
                ProductNameNode = "product_name",
                ShortDescriptionNode = "short_description",
                DescriptionNode = "description",
                CurrencyNode = "currency",
                PriceNode = "price",
                DiscountedPriceNode = "discounted_price",
                DiscountNode = "discount",
                Category1Node = "category_1",
                ParentOfCategory1Node = "parent_of_cat_1",
                ParentOfParentOfCategory1Node = "parent_of_parent_of_cat1",
                Category2Node = "category_2",
                ParentOfCategory2Node = "parent_of_cat_2",
                ParentOfParentOfCategory2Node = "parent_of_parent_of_cat2",
                PictureUrl1Node = "picture_url",
                PictureUrl2Node = "picture_url2",
                PictureUrl3Node = "picture_url3",
                PictureUrl4Node = "picture_url4",
                PictureUrl5Node = "picture_url5",
                UrlNode = "URL",
                CurrencyFormat = CurrencyFormat.US,
                WarrantyNode = "warranty",
                VATStatus ="vat_status"
            };
        }
        public static DatafeedConfig GetDefaultCSVDatafeedConfig()
        {
            return new DatafeedConfig
            {
                //ProductListNode = "Products",
                //ProductItemNode = "Product",
                SkuNode = "1",
                //InstockNode = "availability_instock",
                //BrandNode = "brand",
                ProductNameNode = "2",
                DescriptionNode = "5",
                //CurrencyNode = "currency",
                PriceNode = "6",
                DiscountedPriceNode = "7",
                //DiscountNode = "discount",
                Category1Node = "8",
                ParentOfCategory1Node = "9",
                //ParentOfParentOfCategory1Node = "parent_of_parent_of_cat1",
                //Category2Node = "category_2",
                //ParentOfCategory2Node = "parent_of_cat_2",
                //ParentOfParentOfCategory2Node = "parent_of_parent_of_cat2",
                PictureUrl1Node = "3",
                //PictureUrl2Node = "picture_url2",
                //PictureUrl3Node = "picture_url3",
                //PictureUrl4Node = "picture_url4",
                //PictureUrl5Node = "picture_url5",
                UrlNode = "4",
                CurrencyFormat = CurrencyFormat.Vietnamese,
                WarrantyNode = "10"
            };
        }
    }

    public enum CurrencyFormat
    {
        Vietnamese =1,
        US = 2,
    }
}
