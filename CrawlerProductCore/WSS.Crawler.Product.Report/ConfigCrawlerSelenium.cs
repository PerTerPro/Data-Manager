using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crawler.Product.Report
{
    public class ConfigCrawlerSelenium
    {
        public List<string> QueueInit { get; set; }
        public List<string> RegexAcceptProduct { get; set; }
        public List<string> RegexToQueue { get; set; }
        public int MaxDeep { get; set; }
        public List<string> XPathProduct { get; set; }

        internal string GetJSON()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ConfigCrawlerSelenium FromJSON(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigCrawlerSelenium>(json);
        }

        public string RootLInk { get; set; }
    }
}
