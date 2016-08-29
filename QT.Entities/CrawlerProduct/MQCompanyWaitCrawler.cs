using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
    [ProtoBuf.ProtoContract]
    public class MQCompanyWaitCrawler
    {
        [ProtoBuf.ProtoMember(5)]
        public bool ExtractionLink { get; set; }
        [ProtoBuf.ProtoMember(1)]
        public long CompanyID { get; set; }

        [ProtoBuf.ProtoMember(2)]
        public bool IsTest { get; set; }


        /// <summary>
        /// 0- FullCrawler.
        /// 1- ReloadCrawler.
        /// 2- Find New Items.
        /// </summary>
        [ProtoBuf.ProtoMember(3)]
        public int TypeCrawler { get; set; }

        /// <summary>
        /// Thời điểm  Push
        /// </summary>
        [ProtoBuf.ProtoMember(4)]
        public DateTime datePush { get; set; }
    }
}
