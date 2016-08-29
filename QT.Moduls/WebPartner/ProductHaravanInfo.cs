using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.WebPartner
{
    public class Image
    {
        public string created_at { get; set; }
        public int id { get; set; }
        public int position { get; set; }
        public int product_id { get; set; }
        public string src { get; set; }
        public string updated_at { get; set; }
        public object attachment { get; set; }
        public string filename { get; set; }
        public List<object> variant_ids { get; set; }
    }
    
    public class Variant
    {
        private int? _inventory_quantity = 0;
        private int? _old_inventory_quantity = 0;

        public string barcode { get; set; }
        public double compare_at_price { get; set; }
        public string created_at { get; set; }
        public object fulfillment_service { get; set; }
        public double grams { get; set; }
        public int id { get; set; }
        public string inventory_management { get; set; }
        public string inventory_policy { get; set; }
        public int? inventory_quantity
        {
            get { return _inventory_quantity; }
            set
            {
                if (value == null)
                {
                    _inventory_quantity = 0;
                }
                else
                    _inventory_quantity = value;
            }
        }


        public int? old_inventory_quantity
        {
            get { return _old_inventory_quantity; }
            set
            {
                if (value == null)
                {
                    _old_inventory_quantity = 0;
                }
                else
                    _old_inventory_quantity = value;
            }
        }
        public object inventory_quantity_adjustment { get; set; }
        public int position { get; set; }
        public double price { get; set; }
        public bool requires_shipping { get; set; }
        public string sku { get; set; }
        public bool taxable { get; set; }
        public string title { get; set; }
        public string updated_at { get; set; }
        public object image_id { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public object option3 { get; set; }
    }

    public class Option
    {
        public string name { get; set; }
        public int id { get; set; }
        public int position { get; set; }
        public int product_id { get; set; }
    }

    public class Product
    {
        public Product() { variants = new List<Variant>(); }

        public string body_html { get; set; }
        public string handle { get; set; }
        public int id { get; set; }
        public List<Image> images { get; set; }
        public string product_type { get; set; }
        public string published_at { get; set; }
        public string published_scope { get; set; }
        public string tags { get; set; }
        public string template_suffix { get; set; }
        public string title { get; set; }
        public string updated_at { get; set; }
        public List<Variant> variants  { get; set; }
        public string vendor { get; set; }
        public List<Option> options { get; set; }
        public bool only_hide_from_list { get; set; }
    }

    public class ProductHaravanInfo
    {
        public List<Product> products { get; set; }
    }

    public class ProductSimpleInfo
    {
        public Product product { get; set; }
    }
}
