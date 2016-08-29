using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct.Cache
{
    public class CompanyCache
    {
        public long Id { get; set; }

        public string Domain { get; set; }

        public DateTime LastUpdateRedisCrawler { get; set; }

        public bool InQueue_FindNew { get; set; }

        public double Time_NextFindNew { get; set; }

        public bool Running { get; set; }

        public long LastJobCrawler { get; set; }
    }
}
