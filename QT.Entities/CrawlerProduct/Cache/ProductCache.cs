using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct.Cache
{
    
    public class ProductCache
    {
        public ProductCache ()
        {
            fail = 0;
            igone = 0;
            price = 0;
        }
        public string detail_url { get; set; }

        public long price { get; set; }

        public long hash_change { get; set; }

        public long hash_image { get; set; }

        public int igone { get; set; }

        public int fail { get; set; }

        public DateTime last_change { get; set; }

        public bool valid { get; set; }

        public long id { get; set; }

        public long last_crawl { get; set; }

    }
}
