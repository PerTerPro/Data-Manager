using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace QT.Entities.Images
{
    public class ThumbImageProductInfo
    {
        public long ProductId { set; get; }
        public string FileNameImage { set; get; }
        public string FolderImage { set; get; }
        public string FullDirectoryImage { set; get; }
        public List<WidthHeightImage> SizeImage { set; get; }
        /// <summary>
        /// 1: Normal Product
        /// 2: Root Product
        /// </summary>
        public int TypeProduct { set; get; }
        public static string ConvertToJson(ThumbImageProductInfo thumbImage)
        {
            return JsonConvert.SerializeObject(thumbImage);
        }
        public static byte[] GetMessage(ThumbImageProductInfo thumbImageInfo)
        {
            byte[] msgOut;
            //using (var stream = new MemoryStream())
            //{
            //    Serializer.Serialize(stream, );
            //    msgOut = stream.ToArray();
            //}
            msgOut = UTF8Encoding.UTF8.GetBytes(ConvertToJson(thumbImageInfo));
            return msgOut;
        }
        public static ThumbImageProductInfo GetDataFromMessage(byte[] message)
        {
            ThumbImageProductInfo result;
            //using (var stream = new MemoryStream(message))
            //{
            //    var thumbImageJson = Serializer.Deserialize<string>(stream);
            //    result = JsonConvert.DeserializeObject<ThumbImageProductInfo>(thumbImageJson);
            //}
            var thumbImageJson = UTF8Encoding.UTF8.GetString(message);
            result = JsonConvert.DeserializeObject<ThumbImageProductInfo>(thumbImageJson);
            return result;
        }
    }

    public class WidthHeightImage
    {
        public int Width { set; get; }
        public int Height { set; get; }
    }
}
