using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImboForm
{
    public class JobDelImgImbo
    {
        public string ImageId { get; set; }

        public string GetJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static JobDelImgImbo GetJson(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobDelImgImbo>(str);
        }
    }
}
