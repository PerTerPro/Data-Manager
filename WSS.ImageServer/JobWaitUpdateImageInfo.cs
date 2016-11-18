using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImboForm
{
    public class JobWaitUpdateImageInfo
    {
        public string ImageId { get; set; }
        public long ProductId { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
