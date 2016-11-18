using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace ImboForm
{
    public class WorkerImgIdToSql:QueueingConsumer
        
    {
        HandlerImgIdToSql h = new HandlerImgIdToSql();
        private ILog _log = LogManager.GetLogger(typeof (WorkerImgIdToSql));

        public WorkerImgIdToSql() : base (RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), ConfigImbo.QueueJobProductWaitUpImg, false)
        {
        }

        public override void Init()
        {
            
        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            string strMss = UTF8Encoding.UTF8.GetString(message.Body);
            _log.Info(string.Format("Process mss: {0}", strMss));
            h.ProcessJob(strMss);
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
