using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace QT.Entities.Images
{
    [ProtoBuf.ProtoContract]
    public class LogHistoryImageProduct
    {
        
        [ProtoBuf.ProtoMember(1)]
        public long ProductId { set; get; }
        [ProtoBuf.ProtoMember(2)]
        public DateTime DateLog { set; get; }
        [ProtoBuf.ProtoMember(3)]
        public bool IsDownloaded { set; get; }
        [ProtoBuf.ProtoMember(4)]
        public string ErrorName { set; get; }
        [ProtoBuf.ProtoMember(5)]
        public bool NewsToValid{ set; get; } 
        public static byte[] GetMessage(LogHistoryImageProduct mss)
        {
            byte[] msgOut;
            using (var stream = new MemoryStream()){
                Serializer.Serialize(stream, mss);
                msgOut = stream.ToArray();
            }
            return msgOut;
        }
        public static LogHistoryImageProduct GetDataFromMessage(byte[] message)
        {
            LogHistoryImageProduct result;
            using (var stream = new MemoryStream(message)){
                result = Serializer.Deserialize<LogHistoryImageProduct>(stream);
            }
            return result;
        }
    }
}
