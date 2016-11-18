using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Core.Crawler
{
    public class JobBackupProductToDel
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public long Price { get; set; }
        public string ProductUrl { get; set; }
        public string ImageId { get; set; }
        public string ImageUrl { get; set; }

        internal string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static JobBackupProductToDel FromString(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobBackupProductToDel>(str);
        }
    }
}
