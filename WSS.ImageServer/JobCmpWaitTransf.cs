using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImboForm
{
    public class JobCmpWaitTransf
    {
        public long CompanyId { get; set; }

        public string GetJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static JobCmpWaitTransf FromJson(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobCmpWaitTransf>(str);
        }
    }
}
