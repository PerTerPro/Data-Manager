using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websosanh.NotificationSystem.Common
{
    [ProtoBuf.ProtoContract]
    public class Message
    {
        [ProtoBuf.ProtoMember(1)]
        public string MessageContent { get; set; }

        [ProtoBuf.ProtoMember(2)]
        public ulong MessageValue { get; set; }


    }
}
