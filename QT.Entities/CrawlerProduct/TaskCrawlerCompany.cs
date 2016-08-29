using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
    [ProtoBuf.ProtoContract]

    public class TaskCrawlerCompany
    {

        [ProtoBuf.ProtoMember(1)]
        public long IdCompany { get; set; }

        [ProtoBuf.ProtoMember(2)]
        public int iType { get; set; }

        [ProtoBuf.ProtoMember(3)]
        public string Domain { get; set; }

        [ProtoBuf.ProtoMember(4)]
        public DateTime DatePushJob { get; set; }


    }
}
