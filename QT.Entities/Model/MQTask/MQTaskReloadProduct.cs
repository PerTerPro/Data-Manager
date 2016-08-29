using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Model
{
     [ProtoContract]
    public class MQTask_UpdateReloadPriceProduct
    {
         [ProtoMember(1)]
         public Int64 ProductID { get; set; }
    }

   
}
