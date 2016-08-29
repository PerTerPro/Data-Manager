using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GABIZ.Base.Keyword
{
    [ProtoBuf.ProtoContract]
    public class RankKeywordInfo
    {
        [ProtoBuf.ProtoMember(1)]
        public int KeywordID { get; set; }
        [ProtoBuf.ProtoMember(2)]
        public string Keyword { set; get; }
        [ProtoBuf.ProtoMember(3)]
        public int RankKeyword { set; get; }
        [ProtoBuf.ProtoMember(4)]
        public DateTime DateCheck { set; get; }

        public static byte[] GetMess(RankKeywordInfo mss)
        {
            byte[] msgOut;

            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, mss);
                msgOut = stream.ToArray();
            }
            return msgOut;
        }
        public static RankKeywordInfo GetDataFromMessage(byte[] message)
        {
            RankKeywordInfo result = new RankKeywordInfo();
            try
            {
                
                using (var stream = new MemoryStream(message))
                {
                    result = Serializer.Deserialize<RankKeywordInfo>(stream);
                }
            }
            catch (Exception ex) 
            {
                string a = ex.Message;
                string b = a;
            }
            return result;
        }
    }
}
