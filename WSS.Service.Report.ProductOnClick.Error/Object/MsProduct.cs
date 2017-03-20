﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.Report.ProductOnClick.Error.Object
{
    [ProtoContract]
    public class MsProduct
    {
        [ProtoMember(1)]
        public long ProductId { get; set; }
        [ProtoMember(2)]
        public string DetailUrlMerchant { get; set; }
        [ProtoMember(3)]
        public string Error { get; set; }
        public string GetJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static MsProduct FromJson(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MsProduct>(str);
        }
        public static byte[] GetMessage(MsProduct mss)
        {
            byte[] msgOut;
            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, mss);
                msgOut = stream.ToArray();
            }
            return msgOut;
        }
        public static MsProduct GetDataFromMessage(byte[] message)
        {
            MsProduct result;
            using (var stream = new MemoryStream(message))
            {
                result = Serializer.Deserialize<MsProduct>(stream);
            }
            return result;
        }
    }
}
