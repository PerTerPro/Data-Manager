using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.Report.ProductOnClick.Error.Object
{
    [ProtoContract]
    public class ProductAds
    {
        [ProtoMember(1)]
        public long ProductId { get; set; }
        [ProtoMember(2)]
        public long CompanyId { get; set; }
        [ProtoMember(4)]
        public DateTime StartDate { get; set; }
        [ProtoMember(5)]
        public DateTime EndDate { get; set; }
        [ProtoMember(6)]
        public string Keyword { get; set; }
        [ProtoMember(7)]
        public DateTime DateCreate { get; set; }
        [ProtoMember(8)]
        public DateTime LastUpdate { get; set; }
        [ProtoMember(9)]
        public int Order { get; set; }
        [ProtoMember(10)]
        public int OrderAdsScore { get; set; }
        [ProtoMember(11)]
        public int KeywordAdsId { get; set; }
        [ProtoMember(12)]
        public string Domain { get; set; }
        [ProtoMember(13)]
        public string DetailUrl { get; set; }


    }
}
