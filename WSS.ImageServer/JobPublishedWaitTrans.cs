using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.ImageServer
{
    public class JobPublishedWaitTrans
    {
        public long Id { get;set; }
        public string Url { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static JobPublishedWaitTrans FromJson(string strJob)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobPublishedWaitTrans>(strJob);
        }
    }
}

