using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlerProduct
{
    public class JobCrawler
    {

        public long CompanyID { get; set; }
        public string GuidCheckFinish { get; set; }

        public string ToJSON()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static JobCrawler FromJSon (string str)
        {
            return JsonConvert.DeserializeObject<JobCrawler>(str);
        }
    }
}
