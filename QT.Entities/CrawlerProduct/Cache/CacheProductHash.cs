using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct.Cache
{
    [ProtoBuf.ProtoContract()]
    public class ProductHash
    {
        [ProtoBuf.ProtoMember(1)]
        public long HashChange { get; set; }

        [ProtoBuf.ProtoMember(2)]
        public long HashImage { get; set; }

        [ProtoBuf.ProtoMember(3)]
        public long HashDuplicate { get; set; }

        [ProtoBuf.ProtoMember(4)]
        public long Price { get; set; }

        public string getJSON()
        {
            MemoryStream msTestString = new MemoryStream();
            Serializer.Serialize(msTestString, this);
            string stringBase64 = Convert.ToBase64String(msTestString.ToArray());
            return stringBase64;
        }

        [ProtoBuf.ProtoMember(5)]
        public long Id { get; set; }


        public static ProductHash FromJSON(string valueProductId)
        {
            return Serializer.Deserialize<ProductHash>(new MemoryStream(Convert.FromBase64String(valueProductId), false));
        }


        [ProtoBuf.ProtoMember(7)]
        public string url { get; set; }
    }
}
