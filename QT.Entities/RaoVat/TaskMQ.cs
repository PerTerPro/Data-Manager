using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Model.SaleNews
{

    [ProtoBuf.ProtoContract]
    public class TaskMQ
    {
        public TaskMQ()
        {
            ConfigID = 0;
            Url = "";
            Deep = 0;
            TypeCrawler = 0;
        }

        [ProtoBuf.ProtoMember(1)]
        public int ConfigID { get; set; }

        [ProtoBuf.ProtoMember(2)]
        public string Url { get; set; }

        [ProtoBuf.ProtoMember(3)]
        public int Deep { get; set; }

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
        public long ProductID { get; set; }
    }
}
