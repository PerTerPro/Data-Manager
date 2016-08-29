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
    public class MssLogFindNewProduct
    {
        public MssLogFindNewProduct()
        {
            DateSearch = QT.Entities.Common.Obj2Int64(DateTime.Now.ToString("yyMMddHHmm"));
        }
        [ProtoBuf.ProtoMember(1)]
        public long Product_ID { get; set; }
        [ProtoBuf.ProtoMember(2)]
        public string Detail_Url { get; set; }
        [ProtoBuf.ProtoMember(3)]
        public string Session { get; set; }
        [ProtoBuf.ProtoMember(4)]
        public bool is_OK { get; set; }
        [ProtoBuf.ProtoMember(5)]
        public long CRC { get; set; }
        [ProtoBuf.ProtoMember(6)]
        public DateTime Date_Log { get; set; }

        [ProtoBuf.ProtoMember(7)]
        public long DateSearch { get; set; }
         
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
        public static MssLogFindNewProduct GetDataFromMessage(byte[] message)
        {
            MssLogFindNewProduct result = new MssLogFindNewProduct();
            using (var stream = new MemoryStream(message))
            {
                result = Serializer.Deserialize<MssLogFindNewProduct>(stream);
            }
            return result;
        }
    }
}
