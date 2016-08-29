using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Data
{
    public class LogToMQ
    {
        public static void WriteLog(string eventLog, IModel channel, string consumerName, string queueName, string mss, string company="")
        {
            try
            {
                var a = Websosanh.Core.Common.BAL.ProtobufTool.Serialize(new LogTask()
                {
                    EventLog = eventLog,
                    Computer = "Computer",
                    Consumer = consumerName,
                    Message = mss,
                    Company=company
                });
                channel.BasicPublish("", queueName, null, a);
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                str = "";
            }
        }
    }

    [ProtoBuf.ProtoContract()]
    public class LogTask
    {


        [ProtoBuf.ProtoMember(1)]
        public string Computer { get; set; }

        [ProtoBuf.ProtoMember(2)]
        public string Consumer { get; set; }

        [ProtoBuf.ProtoMember(3)]
        public string Message { get; set; }

        [ProtoBuf.ProtoMember(4)]
        public string EventLog { get; set; }

        [ProtoBuf.ProtoMember(5)]
        public string Company { get; set; }
    }
}
