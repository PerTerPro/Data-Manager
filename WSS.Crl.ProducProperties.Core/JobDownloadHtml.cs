using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crl.ProducProperties.Core
{
    public class JobDownloadHtml
    {
        public long ProductId { get; set; }
 

        public string GetJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static JobDownloadHtml FromJson(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobDownloadHtml>(str);
        }

        public string DetailUrl { get; set; }

        public string Domain { get; set; }
    }
}
