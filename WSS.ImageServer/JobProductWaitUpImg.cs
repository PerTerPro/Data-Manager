using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImboForm
{
    public class JobProductWaitUpImg
    {
        public long ProductId { get; set; }
        public string ImgPathOld { get; set; }
        public string ImageUrl { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
