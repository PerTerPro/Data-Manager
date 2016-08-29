using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct.RabbitMQ
{
    [ProtoBuf.ProtoContract]
    public class MsJobKeywordSuggest
    {

        public static MsJobKeywordSuggest FromArByte(byte[] message)
        {
            MsJobKeywordSuggest result = new MsJobKeywordSuggest();
            using (var stream = new MemoryStream(message))
            {
                result = Serializer.Deserialize<MsJobKeywordSuggest>(stream);
            }
            return result;
        }

        [ProtoBuf.ProtoMember(1)]
        public string Keyword { get; set; }

        public byte[] GetArByte()
        {
            byte[] result;
            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, this);
                result = stream.ToArray();
            }
            return result;
        }
    }
}
