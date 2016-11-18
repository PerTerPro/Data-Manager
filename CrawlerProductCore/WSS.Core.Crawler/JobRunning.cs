using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Core.Crawler
{
    public class JobRunning
    {
        public long CompanyId { get; set; }
        public long Thread { get; set; }
        public string Ip { get; set; }
        public string Session { get; set; }
        public int TimeLongRun { get; set; }
    }
}
