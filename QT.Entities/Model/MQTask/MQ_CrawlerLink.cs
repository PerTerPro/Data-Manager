using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Model.MQTask
{
    [ProtoBuf.ProtoContract]
    public class MQ_CrawlerWaitLink
    {
        [ProtoBuf.ProtoMember(1)]
        public string url { get; set; }
    }
}
