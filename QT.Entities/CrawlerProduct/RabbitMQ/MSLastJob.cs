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
    public class MSLastJob
    {
        [ProtoBuf.ProtoMember(1)]
        public long Company { get; set; }
        [ProtoBuf.ProtoMember(2)]
        public DateTime DatePush { get; set; }
        public byte[] GetArByte()
        {
            byte[] result;
            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, this);
                result = stream.ToArray(); //GetBuffer was giving me a Protobuf.ProtoException of "Invalid field in source data: 0" when deserializing
            }
            return result;

        }
        public static MSLastJob GetDataFromMessage(byte[] message)
        {
            MSLastJob result = new MSLastJob();
            using (var stream = new MemoryStream(message))
            {
                result = Serializer.Deserialize<MSLastJob>(stream);
            }
            return result;
        }

    }
}
