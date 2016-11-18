using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;

namespace WSS.Core.Crawler
{
    public class Classification
    {
        public long CompanyId { get; set; }
        public long Id { get; set; }
        public string Category { get; set; }

        public byte[] GetArbyteJson()
        {
            return Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(this));
        }

        public static ProductEntity GetFromJson(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ProductEntity>(input);
        }

        public static ProductEntity GetFromJson(byte[] input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ProductEntity>(Encoding.UTF8.GetString(input));
        }

        public string GetJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

    }
}
