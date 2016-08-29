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
    public class MssLogCassandra
    {
        [ProtoBuf.ProtoMember(1)]
        public string log { get; set; }
        [ProtoBuf.ProtoMember(2)]
        public int logCode { get; set; }
        [ProtoBuf.ProtoMember(3)]
        public int typeLog { get; set; }
        [ProtoBuf.ProtoMember(4)]
        public long data_id { get; set; }
        [ProtoBuf.ProtoMember(5)]
        public long data_second_id { get; set; }
        [ProtoBuf.ProtoMember(6)]
        public string session { get; set; }

        public byte[] ToMss()
        {byte[] result;
          using (var stream = new MemoryStream())
          {
            Serializer.Serialize(stream, this);
            result = stream.ToArray(); //GetBuffer was giving me a Protobuf.ProtoException of "Invalid field in source data: 0" when deserializing
          }
          return result;
        }
        public static MssLogCassandra GetDataFromMessage(byte[] message)
        {
            MssLogCassandra result = new MssLogCassandra();
            using (var stream = new MemoryStream(message))
            {
                result = Serializer.Deserialize<MssLogCassandra>(stream);
            }
            return result;
        }
    }
}