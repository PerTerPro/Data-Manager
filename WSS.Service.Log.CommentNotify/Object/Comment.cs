using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.Log.CommentNotify.Object
{
    [ProtoContract]
    public class Comment
    {
        [ProtoMember(1)]
        public long CommentID { get; set; }
        [ProtoMember(2)]
        public int TypeComment { get; set; }
        [ProtoMember(3)]
        public bool IsCommentParent { get; set; }



        public static byte[] GetMessage(Comment mss)
        {
            byte[] msgOut;
            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, mss);
                msgOut = stream.ToArray();
            }
            return msgOut;
        }
        public static Comment GetDataFromMessage(byte[] message)
        {
            Comment result;
            using (var stream = new MemoryStream(message))
            {
                result = Serializer.Deserialize<Comment>(stream);
            }
            return result;
        }
    }
}
