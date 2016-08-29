using Newtonsoft.Json;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.FindWebInVatGia
{



    [ProtoBuf.ProtoContract]
    public class JobCrawler
    {

        public static JobCrawler Deserialize(byte[] JobCrawler)
        {
            try
            {
                Encoding enc = new UTF8Encoding(true, true);
                string strData = enc.GetString(JobCrawler);
                JobCrawler job = JsonConvert.DeserializeObject<JobCrawler>(strData);
                return job;
            }
            catch (Exception ex01)
            {
                return null;
            }
        }   


        public byte[] Serialize()
        {
            return System.Text.Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(this));
        }

        [ProtoBuf.ProtoMember(1)]
        public string urlDetail { get; set; }

         [ProtoBuf.ProtoMember(2)]
        public int level { get; set; }
    }
}
