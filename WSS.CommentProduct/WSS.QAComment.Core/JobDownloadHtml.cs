using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.QAComment.Core
{
   [ProtoContract]

    public class JobWaitAS
    {
         
        [ProtoMember(1)]
        public long Id { get; set; }[ProtoMember(2)]
        public long CompanyId { get; set; }

        public static JobWaitAS FromObjMQ(byte[] data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobWaitAS>(UTF8Encoding.UTF8.GetString(data));
        }


        public byte[] ToObjMQ()
        {
            return UTF8Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(this));
        }
       internal string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }



        public string Url { get; set; }
    }

     public class JobDownloadHtml
    {
         public JobDownloadHtml()
         {
             Url = "";
             Id = 0;
             CompanyId = 0;
         }

         public string Url { get; set; }
         public long Id { get; set; }

         public byte[] GetByteArJSON()
         {
             return Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(this));
         }

         internal static JobDownloadHtml FromArByte(byte[] p)
         {
             return Newtonsoft.Json.JsonConvert.DeserializeObject<JobDownloadHtml>(Encoding.UTF8.GetString(p));
         }

         public long CompanyId { get; set; }

         public string ToJSON()
         {
             return Newtonsoft.Json.JsonConvert.SerializeObject(this);
         }
    }
}
