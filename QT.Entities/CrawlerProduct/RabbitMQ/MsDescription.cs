using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
    public class MssDescription
    {
        public string GetJSON ()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        public long Product_item_id { get; set; }
        public String Product_item_name { get; set; }
        public String Html { get; set; }
        public string Name { get; set; }

        public string Url { get; set; }
    }
}
