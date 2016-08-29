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
    public class MsSaveProduct
    {
        [ProtoBuf.ProtoMember(1)]
        public string Url { get; set; }


        public byte[] ToMss()
        {
            byte[] result;
            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, this);
                result = stream.ToArray(); //GetBuffer was giving me a Protobuf.ProtoException of "Invalid field in source data: 0" when deserializing
            }
            return result;
        }


        public static MsSaveProduct GetDataFromMessage(byte[] message)
        {
            MsSaveProduct result = new MsSaveProduct();
            using (var stream = new MemoryStream(message))
            {
                result = Serializer.Deserialize<MsSaveProduct>(stream);
            }
            return result;
        }
    }
}
