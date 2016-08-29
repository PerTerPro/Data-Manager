using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities
{
    [ProtoBuf.ProtoContract]
    public class MqChangeImage
    {
        [ProtoBuf.ProtoMember(1)]
        public long ProductID { get; set; }

        /// <summary>
        /// 1.Thông thường. 2. Tự public sản phẩm sau khi download ảnh. 3. sản phẩm gốc
        /// </summary>
        [ProtoBuf.ProtoMember(2)]
        public int Type { set; get; }

        public static byte[] GetMess(MqChangeImage mss)
        {
            byte[] msgOut;

            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, mss);
                msgOut = stream.ToArray();
            }
            return msgOut;
        }
        public static MqChangeImage GetDataFromMessage(byte[] message)
        {
            MqChangeImage result = new MqChangeImage();
            using (var stream = new MemoryStream(message))
            {
                result = Serializer.Deserialize <MqChangeImage>(stream);
            }
            return result;
        }
    }


    [ProtoBuf.ProtoContract]
    public class MqThumbImageInfo
    {
        [ProtoBuf.ProtoMember(1)]
        public long ProductId { get; set; }

        [ProtoBuf.ProtoMember(2)]
        public string FolderImage { set; get; }

        [ProtoBuf.ProtoMember(3)]
        public string ImageName { set; get; }
       
        /// <summary>
        /// 1. SP thường 2.SP gốc
        /// </summary>
        [ProtoBuf.ProtoMember(4)]
      
        public int TypeProduct { set; get; }

        public static byte[] GetMess(MqThumbImageInfo mss)
        {
            byte[] msgOut;

            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, mss);
                msgOut = stream.ToArray();
            }
            return msgOut;
        }
        public static MqThumbImageInfo GetDataFromMessage(byte[] message)
        {
            var result = new MqThumbImageInfo();
            using (var stream = new MemoryStream(message))
            {
                result = Serializer.Deserialize<MqThumbImageInfo>(stream);
            }
            return result;
        }
    }
}
