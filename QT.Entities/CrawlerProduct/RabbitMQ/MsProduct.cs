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
    public class MsProduct
    {
        public MsProduct ()
        {
            Date_Update = DateTime.Now;
            DateSearch = QT.Entities.Common.Obj2Int64(DateTime.Now.ToString("yyMMddHHmm"));
        }

        [ProtoBuf.ProtoMember(1)]
        public string Classification { get; set; }
        [ProtoBuf.ProtoMember(2)]
        public DateTime Date_Update { get; set; }
        [ProtoBuf.ProtoMember(3)]
        public string Image_Url { get; set; }
        [ProtoBuf.ProtoMember(4)]
        public bool Is_Black_Link { get; set; }
        [ProtoBuf.ProtoMember(5)]
        public bool Is_New { get; set; }
        [ProtoBuf.ProtoMember(6)]
        public string Name { get; set; }
        [ProtoBuf.ProtoMember(7)]
        public string Note { get; set; }
        [ProtoBuf.ProtoMember(8)]
        public long Price { get; set; }
        [ProtoBuf.ProtoMember(9)]
        public long Product_Id { get; set; }
        [ProtoBuf.ProtoMember(10)]
        public int Status { get; set; }
        [ProtoBuf.ProtoMember(11)]
        public string Summary { get; set; }
        [ProtoBuf.ProtoMember(12)]
        public bool Valid { get; set; }
        [ProtoBuf.ProtoMember(13)]
        public string Url { get; set; }
        [ProtoBuf.ProtoMember(14)]
        public DateTime? Date { get; set; }
        [ProtoBuf.ProtoMember(15)]
        public long DateSearch { get; set; }

        [ProtoBuf.ProtoMember(16)]
        public long CompanyId { get; set; }
        [ProtoBuf.ProtoMember(17)]
        public string Session { get; set; }
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

        

        public static MsProduct GetDataFromMessage(byte[] message)
        {
            MsProduct result = new MsProduct();
            using (var stream = new MemoryStream(message))
            {
                result = Serializer.Deserialize<MsProduct>(stream);
            }
            return result;
        }
         
    }
}
