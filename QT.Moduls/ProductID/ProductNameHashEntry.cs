using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.ProductID
{
    [ProtoContract]
    public class ProductNameHashEntry
    {
        [ProtoMember(1)]
        public int Price;
        [ProtoMember(2)]
        public long LastUpdate;
        [ProtoMember(3)]
        public long CompanyID;
        [ProtoMember(4)]
        public int RootProductID;

        public long IDKey = 0;
        public string NameRedis;
    }
}
