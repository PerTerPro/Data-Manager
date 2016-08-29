using QT.Entities.RaoVat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Model.MQTask
{
    [ProtoBuf.ProtoContract]
    public class MQ_CrawlerProduct_CompanyWait
    {
        [ProtoBuf.ProtoMember(1)]
        public long CompanyID { get; set; }
    }

    [ProtoBuf.ProtoContract]
    public class MQ_CrawlerNews_FullSaleNew
    {
         [ProtoBuf.ProtoMember(1)]
        public ConfigXPaths Configuration { get; set; }
    }
}
