using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.Company
{
    public class ProductAccesstrade
    {
        public string aff_link { get; set; }
        public string category { get; set; }
        public string desc { get; set; }
        public double discount { get; set; }
        public string domain { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string product_id { get; set; }
        public string sku { get; set; }
        public string sub_category { get; set; }
        public string url { get; set; }
    }

    public class DatafeedAccesstrade
    {
        public List<ProductAccesstrade> data { get; set; }
        public int total { get; set; }
    }
}
