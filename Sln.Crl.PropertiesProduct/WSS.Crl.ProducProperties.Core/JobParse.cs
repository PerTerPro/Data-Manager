using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crl.ProducProperties.Core
{
    public class JobParse
    {
        public long Id { get; set; }
        internal static JobParse FromJson(string p)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobParse>(p);
        }

        public string GetJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
