using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websosanh.NotificationSystem.Common
{
    public class MessageEntity
    {
        public long MessageID { get; set; }
        public string MessageContent { get; set; }
        public DateTime CreatedDate { get; set; }
        public string QueueName { get; set; }
    }
}
