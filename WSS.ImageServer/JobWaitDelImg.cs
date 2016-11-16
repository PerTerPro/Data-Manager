using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImboForm
{
    public class JobWaitDelImg
    {
        public string ImageId { get; set; }

        public string GetJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static JobWaitDelImg GetJson(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobWaitDelImg>(str);
        }
    }
}
