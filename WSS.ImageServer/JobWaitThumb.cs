using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImboForm
{
    public class JobWaitThumb
    {
        public string ImageId { get; set; }
        public List<Tuple<int,int>> Sizes { set; get; } 
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
