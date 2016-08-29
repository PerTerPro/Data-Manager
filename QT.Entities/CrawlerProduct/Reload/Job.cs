using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct.Reload
{
    [ProtoBuf.ProtoContract()]
    public class Job
    {
        public bool Valid;
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
        public long ProductId { get; set; }

        [ProtoBuf.ProtoMember(5)]
        public long ConfigID { get; set; }
    }
}