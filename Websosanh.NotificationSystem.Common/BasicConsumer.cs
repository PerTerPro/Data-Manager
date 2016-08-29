using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;

namespace Websosanh.NotificationSystem.Common
{
    public class NotificationConsumer : Websosanh.Core.Drivers.RabbitMQ.BasicGetConsumer
    {
        public NotificationConsumer(RabbitMQServer rabbitMQServer, string queueName, bool autoAck, string Pasword)
            : base(rabbitMQServer, queueName, autoAck)
        {
            this._rabbitMQServer = rabbitMQServer;
            this._queueName = queueName;
            this._autoAck = autoAck;
        }

        public BasicGetResult GetMessage()
        {
            return base.GetMessage();
        }

        public override void Init()
        {

        }
    }
}
