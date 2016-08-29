using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QT.Moduls.Bizweb
{
    public class Image
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public int position { get; set; }
        public object variant_ids { get; set; }
        public string created_on { get; set; }
        public string modified_on { get; set; }
        public string src { get; set; }
        public string alt { get; set; }
        public object file_name { get; set; }
        public double size { get; set; }
    }

    public class Image2
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public int position { get; set; }
        public object variant_ids { get; set; }
        public string created_on { get; set; }
        public string modified_on { get; set; }
        public string src { get; set; }
        public string alt { get; set; }
        public object file_name { get; set; }
        public double size { get; set; }
    }

    public class Variant
    {
        public int id { get; set; }
        public object barcode { get; set; }
        public object sku { get; set; }
        public double price { get; set; }
        public double? compare_at_price { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public object option3 { get; set; }
        public bool taxable { get; set; }
        public string inventory_management { get; set; }
        public string inventory_policy { get; set; }
        public int inventory_quantity { get; set; }
        public bool requires_shipping { get; set; }
        public double weight { get; set; }
        public string weight_unit { get; set; }
        public object image_id { get; set; }
        public int position { get; set; }
        public string created_on { get; set; }
        public object modified_on { get; set; }
        public string title { get; set; }
        public int grams { get; set; }
        public int product_id { get; set; }
    }

    public class Option
    {
        public int id { get; set; }
        public string name { get; set; }
        public int position { get; set; }
        public string created_on { get; set; }
        public object modified_on { get; set; }
    }

    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
        public string vendor { get; set; }
        public string product_type { get; set; }
        public double price_max { get; set; }
        public double price_min { get; set; }
        public bool price_varies { get; set; }
        public double compare_at_price_max { get; set; }
        public double compare_at_price_min { get; set; }
        public bool compare_at_price_varies { get; set; }
        public string meta_title { get; set; }
        public string meta_description { get; set; }
        public string published_on { get; set; }
        public object template_layout { get; set; }
        public string created_on { get; set; }
        public object modified_on { get; set; }
        public object content { get; set; }
        public string tags { get; set; }
        public List<Image> images { get; set; }
        public Image2 image { get; set; }
        public List<Variant> variants { get; set; }
        public List<Option> options { get; set; }
    }
    public class ProductBizwebInfo
    {
        public List<Product> products { get; set; }
    }
}