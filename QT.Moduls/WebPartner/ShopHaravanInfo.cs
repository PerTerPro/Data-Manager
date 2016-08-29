using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.WebPartner
{
    public class Shop
    {
        public string address1 { get; set; }
        public object city { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string country_name { get; set; }
        public string created_at { get; set; }
        public string customer_email { get; set; }
        public string currency { get; set; }
        public string domain { get; set; }
        public string email { get; set; }
        public object google_apps_domain { get; set; }
        public object google_apps_login_enabled { get; set; }
        public int id { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string money_format { get; set; }
        public string money_with_currency_format { get; set; }
        public string myharavan_domain { get; set; }
        public string name { get; set; }
        public object plan_name { get; set; }
        public object display_plan_name { get; set; }
        public bool password_enabled { get; set; }
        public string phone { get; set; }
        public string province { get; set; }
        public object province_code { get; set; }
        public object @public { get; set; }
        public string shop_owner { get; set; }
        public object source { get; set; }
        public bool tax_shipping { get; set; }
        public object taxes_included { get; set; }
        public object county_taxes { get; set; }
        public string timezone { get; set; }
        public object zip { get; set; }
        public bool has_storefront { get; set; }
    }

    public class ShopHaravanInfo
    {
        public Shop shop { get; set; }
    }
}
