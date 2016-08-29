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
    public class MsCacheCompany
    {
        [ProtoBuf.ProtoMember(1)]
        public long CompanyID { get; set; }

      
        public byte[] GetArByte()
        {
            byte[] msgOut;

            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, this);
                msgOut = stream.ToArray();
            }
            return msgOut;
        }

        public static MsCacheCompany GetMs(byte[] p)
        {
            return null;
        }
    }
}
