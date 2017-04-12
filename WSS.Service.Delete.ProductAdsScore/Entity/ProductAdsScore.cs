using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.Delete.ProductAdsScore.Entity
{
    [ProtoContract]
    public class ProductAdsScore
    {
        [ProtoMember(1)]
        public long ProductId { get; set; }
        [ProtoMember(2)]
        public long CompanyId { get; set; }
        [ProtoMember(3)]
        public string Keyword { get; set; }


        public string GetJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ProductAdsScore FromJson(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ProductAdsScore>(str);
        }
    }
}
