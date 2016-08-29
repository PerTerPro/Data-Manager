using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
    public class VisitedLinkFindNew
    {
        public string Session { get; set; }
        public long ProductId { get; set; }
        public long CompanyId { get; set; }
        public DateTime LastUpdate { get; set; }
        public string ProductEntityJson { get; set; }
        public string Url { get; set; }
    }
}
