using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.ImageServer
{
    public class JobDelImgImbo
    {
        public string ImageId { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static JobDelImgImbo From(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobDelImgImbo>(str);
        }

     
    }
}
