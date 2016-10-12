using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Moduls;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace ImboForm
{
    class WorkerUploadImage : QueueingConsumer
    {
        private readonly ILog _log = LogManager.GetLogger(typeof (WorkerUploadImage));
        private readonly HandlerJob _handler=new HandlerJob();
        private readonly ProducerBasic _producerBasic = new ProducerBasic(RabbitMQManager.GetRabbitMQServer("rabbitMQ177"),
            "TestImboServer.WaitUpToSqlServer");
        public WorkerUploadImage() : base(
            RabbitMQManager.GetRabbitMQServer("rabbitMQ177"), "TestImboServer.WaitUpToServer", false)
        {
           
        }

        public override void Init()
        {
           
        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            string mss1 = UTF8Encoding.UTF8.GetString(message.Body);
            var mss = Newtonsoft.Json.JsonConvert.DeserializeObject<MssReport>(mss1);
            _handler.ProcessJob(ref mss);
            var x = Newtonsoft.Json.JsonConvert.SerializeObject(mss);
            _producerBasic.PublishString(x);
            _log.Info(x);
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
