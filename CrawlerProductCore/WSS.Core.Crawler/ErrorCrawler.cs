using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Core.Crawler
{
    public class ErrorCrawler
    {
        public string Message { get; set; }
        public long CompanyId { get; set; }
        public long ProductId { get; set; }
        public DateTime TimeError { get; set; }
        public string Url { get; set; }
    }
}
