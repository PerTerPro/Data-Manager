using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QT.Moduls.Bizweb
{
    public class ListStoreSetting
    {
        public int id { get; set; }
        public int store_id { get; set; }
        public string setting_key { get; set; }
        public string setting_value { get; set; }
    }

    public class Package
    {
        public int id { get; set; }
        public string package_name { get; set; }
        public string description { get; set; }
        public int products { get; set; }
        public int storage { get; set; }
    }

    public class Store
    {
        public int id { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
        public int active_theme_id { get; set; }
        public string meta_title { get; set; }
        public object meta_description { get; set; }
        public string email { get; set; }
        public string customer_email { get; set; }
        public int store_package_id { get; set; }
        public object start_date { get; set; }
        public object end_date { get; set; }
        public string created_on { get; set; }
        public string modified_on { get; set; }
        public object trade_name { get; set; }
        public object shop_owner { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
        public int province_id { get; set; }
        public string province { get; set; }
        public string country_code { get; set; }
        public string country { get; set; }
        public string timezone { get; set; }
        public string currency { get; set; }
        public string money_format { get; set; }
        public string money_with_currency_format { get; set; }
        public int status { get; set; }
        public bool under_construction_mode { get; set; }
        public bool deleted { get; set; }
        public List<ListStoreSetting> list_store_setting { get; set; }
        public bool has_storefront { get; set; }
        public Package package { get; set; }
    }
    public class StoreBizwebInfo
    {
        public Store store { get; set; }
    }
}