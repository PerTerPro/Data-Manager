using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{

    [ProtoBuf.ProtoContract]
    public class TaskMQProduct
    {
        public TaskMQProduct()
        {
            CompanyID = 0;
            Url = "";
            Deep = 0;
            TypeCrawler = 0;
        }

        [ProtoBuf.ProtoMember(1)]
        public long CompanyID { get; set; }

        [ProtoBuf.ProtoMember(2)]
        public string Url { get; set; }

        [ProtoBuf.ProtoMember(3)]
        public int Deep { get; set; }

        /// <summary>
        /// 1. Crawler all
        /// 3. Crawler new product
        /// </summary>
        [ProtoBuf.ProtoMember(4)]
        public int TypeCrawler { get; set; }

        /// <summary>
        /// Đường dẫn đến ảnh nếu cần.
        /// </summary>
        [ProtoBuf.ProtoMember(5)]
        public string ImageUrl { get; set; }

        [ProtoBuf.ProtoMember(6)]
        public int Session { get; set; }

        [ProtoBuf.ProtoMember(7)]
        public bool IsExtraction { get; set; }

        [ProtoBuf.ProtoMember(8)]
        public bool IsProduct { get; set; }

        [ProtoBuf.ProtoMember(9)]
        public bool IsTest { get; set; }

        [ProtoBuf.ProtoMember(10)]
        public bool AllowSaveNewProduct { get; set; }

        [ProtoBuf.ProtoMember(11)]
        public bool AllowSaveOldProduct { get; set; }
    }
}
