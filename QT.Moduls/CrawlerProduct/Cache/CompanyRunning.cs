using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlerProduct.Cache
{
    public class CompanyRunning
    {
        public int LastJob { get; set; }
        public DateTime Start { get; set; }
        public string Domain { get; set; }
        public long ID { get; set; }
        public string Server { get; set; }
        public int Type { get; set; }

        public int MinuteRun { get; set; }

        public int CountVisited { get; set; }

        public int CountQueue { get; set; }

        public int CountProduct { get; set; }
    }
}
