using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlerProduct
{
    public class LogCrawlerMQ
    {
        public string Machine { get; set; }
        public string Worker { get; set; }
        public string Mss { get; set; }
        public int VisitedLink { get; set; }
        public long Product { get; set; }
        public int QueueLink { get; set; }
        public DateTime DatePush { get; set; }

        public string ProductData { get; set; }

        public string Domain { get; set; }

        public string ToJSON ()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
