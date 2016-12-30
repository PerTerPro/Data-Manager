using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Entities.Data;
using QT.Moduls;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.ImageServer
{
    public class WorkerDownloadRootProduct : QueueingConsumer
    {
        private int iCount = 0;
        private readonly ILog _log = LogManager.GetLogger(typeof (WorkerDownloadRootProduct));
        private readonly HandlerTransRootProduct _handler = new HandlerTransRootProduct();


        public WorkerDownloadRootProduct()
            : base(
            RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), ConfigImbo.QueueRootProductWaitTrans, false)
        {
        }

        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            iCount ++;
            var mss1 = Encoding.UTF8.GetString(message.Body);
            _log.Info(string.Format("Process: {0}", mss1));
            if (mss1 != null)
            {
                _handler.ProcessJob(mss1);
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }

    public class WorkerFixDownloadRootProduct : QueueingConsumer
    {
        private int iCount = 0;
        private readonly ILog _log = LogManager.GetLogger(typeof(WorkerDownloadRootProduct));
        private readonly HandlerTransRootProduct _handler = new HandlerTransRootProduct();


        public WorkerFixDownloadRootProduct()
            : base( RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), ConfigImbo.QueueRootProductWaitFixTrans, false)
        {
        }

        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            iCount++;
            var mss1 = Encoding.UTF8.GetString(message.Body);
            _log.Info(string.Format("Process: {0}", mss1));
            if (!string.IsNullOrEmpty(mss1))
            {
                _handler.ProcessFixJob(mss1);
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}