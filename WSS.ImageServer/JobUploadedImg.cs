using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.ImageServer
{
    public class JobUploadedImg
    {
        public JobUploadedImg()
        {
            ProductId = 0;
            ImageId = "";
            TimeUpload = DateTime.Now;
        }

        public long ProductId { get; set; }
        public string ImageId { get; set; }
        public DateTime TimeUpload { get; set; }
        public string NameImage { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);

        }

        public static JobUploadedImg FromJson(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobUploadedImg>(str);
        }
    }
}
