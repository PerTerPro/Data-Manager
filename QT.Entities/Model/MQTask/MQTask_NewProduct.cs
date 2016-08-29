using QT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Model.MQTask
{
    [ProtoBuf.ProtoContract]
    public class MQTask_NewProduct
    {
            [ProtoBuf.ProtoMember(1)]
        public Company company { get; set; }

            [ProtoBuf.ProtoMember(2)]
        public Configuration Configuration { get; set; }
    }
}
