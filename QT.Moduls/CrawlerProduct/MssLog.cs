using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlerProduct
{
    [ProtoBuf.ProtoContract]
    public class MssLog
    {

        public static byte[] GetMess(MssLog mss)
        {
            byte[] msgOut;

            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, mss);
                msgOut = stream.ToArray();
            }
            return msgOut;
        }
        public static MssLog GetDataFromMessage(byte[] message)
        {
            MssLog result = new MssLog();
            using (var stream = new MemoryStream(message))
            {
                result = Serializer.Deserialize<MssLog>(stream);
            }
            return result;
        }
        public string Runner { get; set; }

        [ProtoBuf.ProtoMember(1)]
        public long CompanyID { get; set; }
        [ProtoBuf.ProtoMember(2)]
        public int TypeCrawler { get; set; }
        [ProtoBuf.ProtoMember(3)]
        public string Mss { get; set; }
        [ProtoBuf.ProtoMember(4)]
        public DateTime DateLog { get; set; }
    }
}
