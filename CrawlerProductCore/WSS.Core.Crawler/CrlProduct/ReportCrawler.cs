using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Core.Crawler.CrlProduct
{
    public class ReportCrawler
    {
        public DateTime LastRlStart { get; set; }
        public DateTime LastFnStart { get; set; }
        public DateTime LastRlEnd { get; set; }
        public DateTime LastFnEnd { get; set; }
        public int NumberLinkDl { get; set; }
        public int NumberNewProduct { get; set; }
        public int NumberCurrentProduct { get; set; }

    }
}
