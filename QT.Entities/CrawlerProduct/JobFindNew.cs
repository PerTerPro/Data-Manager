using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
    public class JobFindNew
    {
        public string Url { get; set; }
        public int Deep { get; set; }
        public long Id { get; set; }
        public long ParentId { get; set; }

        public string ToJSON()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}

