using System.Collections.Generic;

namespace QT.Entities
{
    public class ProductMasOffer
    {
        public string affiliate_url { get; set; }
        public string _id { get; set; }
        public string offer_id { get; set; }
        public string product_sku { get; set; }
        public string product_name { get; set; }
        public string product_category { get; set; }
        public string product_url { get; set; }
        public decimal product_price { get; set; }
        public decimal product_sale_price { get; set; }
        public List<string> product_image_urls { get; set; }
        public int product_inventory_quantity { get; set; }
        public string product_commission_type { get; set; }
        public List<ProductVariant> product_variants { get; set; }
        public int product_version { get; set; }
    }
    public class ProductVariant
    {
        public string product_sku { get; set; }
        public int product_inventory_quantity { get; set; }
        public decimal product_price { get; set; }
        public string product_name { get; set; }
        public decimal product_sale_price { get; set; }
    }
    public class MasOfferInfo
    {
        public int status { get; set; }
        public int totalPage { get; set; }
        public string data { get; set; }
    }
}