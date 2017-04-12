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
    public class ImageProductInfo
    {
        [ProtoBuf.ProtoMember(1)]
        public long Id { set; get; }
        [ProtoBuf.ProtoMember(2)]
        public string Name { set; get; }
        [ProtoBuf.ProtoMember(3)]
        public string DetailUrl { set; get; }
        [ProtoBuf.ProtoMember(4)]
        public string ImageUrls { set; get; }
        [ProtoBuf.ProtoMember(5)]
        public string ImagePath { set; get; }
        /// <summary>
        /// 1.Product
        /// 2.RootProduct
        /// </summary>
        [ProtoBuf.ProtoMember(6)]
        public int ProductType { set; get; }
        [ProtoBuf.ProtoMember(7)]
        public string ErrorMessage { set; get; }
        [ProtoBuf.ProtoMember(8)]
        public bool IsNew { set; get; }
        [ProtoBuf.ProtoMember(9)]
        public DateTime DownloadedTime { set; get; }

        [ProtoBuf.ProtoMember(10)]
        public string ImageId { get; set; }

        public ImageProductInfo()
        {
            
        }
        public ImageProductInfo(long id, string name, string detailUrl, string imageUrl, bool isnew)
        {
            Id = id;
            Name = name;
            DetailUrl = detailUrl;
            ImageUrls = imageUrl;
            ImagePath = "";
            ProductType = 1;
            ErrorMessage = "";
            IsNew = isnew;
            DownloadedTime = DateTime.Now;
        }

        public static byte[] GetMessage(ImageProductInfo mss)
        {
            byte[] msgOut;
            using (var stream = new MemoryStream()){
                Serializer.Serialize(stream, mss);
                msgOut = stream.ToArray();
            }
            return msgOut;
        }
        public static ImageProductInfo GetDataFromMessage(byte[] message)
        {
            ImageProductInfo result;
            using (var stream = new MemoryStream(message))
            {
                result = Serializer.Deserialize<ImageProductInfo>(stream);
            }
            return result;
        }

        public string GetJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ImageProductInfo FromJson(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ImageProductInfo>(str);
        }
    }

    //public enum MqChangeImageType
    //{
    //    NormalProduct = 1,
    //    AutoValidProduct = 2,
    //    RootProduct = 3
    //};
}
