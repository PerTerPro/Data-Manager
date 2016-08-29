using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Model.MQTask
{
    [ProtoContract]
    public class MQTask_UpdateReloadPriceProduct
    {
        [ProtoMember(1)]
        public Int64 ProductID { get; set; }
    }

    [ProtoContract]
    public class MQTask_ReloadPriceProduct
    {
        public MQTask_ReloadPriceProduct()
        {
            ProductID = 0;
            DetailUrl = "";
            Price = 0;
            CompanyID = 0;
        }

        [ProtoMember(1)]
        public Int64 ProductID { get; set; }
        [ProtoMember(2)]
        public string DetailUrl { get; set; }
        [ProtoMember(3)]
        public int Price { get; set; }
        [ProtoMember(4)]
        public long CompanyID { get; set; }
    }
}
