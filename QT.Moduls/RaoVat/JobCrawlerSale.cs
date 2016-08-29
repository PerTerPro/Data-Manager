using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlSale
{
    [ProtoBuf.ProtoContract()]
    public class JobCrawlerSale
    {
        public override string ToString()
        {
            string strResult = string.Format("url:{0} deep:{1}", url, deep);
            return strResult;
        }

        [ProtoBuf.ProtoMember(2)]
        public string url { get; set; }

        
        [ProtoBuf.ProtoMember(3)]
        public int deep { get; set; }

        
        [ProtoBuf.ProtoMember(4)]
        public long product_id { get; set; }

        
        [ProtoBuf.ProtoMember(5)]
        public long ConfigID { get; set; }

        
        [ProtoBuf.ProtoMember(6)]
        public int TypeCrawler { get; set; }

        [ProtoBuf.ProtoMember(7)]
        public bool IsTest { get; set; }

    }
}
