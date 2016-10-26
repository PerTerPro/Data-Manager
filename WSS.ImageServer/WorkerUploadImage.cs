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

namespace ImboForm
{
    internal class WorkerUploadImage : QueueingConsumer
    {
        private int iCount = 0;
        private readonly ILog _log = LogManager.GetLogger(typeof (WorkerUploadImage));
        private readonly HandlerJob _handler = new HandlerJob();

        private readonly ProducerBasic _producerBasic =
            new ProducerBasic(RabbitMQManager.GetRabbitMQServer("rabbitMQ177"),
                "TestImboServer.WaitUpToSqlServer");

        private SqlDb sql = new SqlDb(SettingSystem.GetSetting().ConnectionSql);

        public WorkerUploadImage() : base(
            RabbitMQManager.GetRabbitMQServer("rabbitMQ177"), "TestImboServer.WaitUpToSqlServer", false)
        {
        }

        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            iCount ++;
            string mss1 = UTF8Encoding.UTF8.GetString(message.Body);
            var mss = Newtonsoft.Json.JsonConvert.DeserializeObject<MssReport>(mss1);
           // _handler.ProcessJob(ref mss);
            var x = Newtonsoft.Json.JsonConvert.SerializeObject(mss);
            if (mss.ImageId != "-1")
            {
                sql.RunQuery(
                    string.Format("Update Product Set ImageId = '{0}' Where Id = {1}", mss.ImageId, mss.ProductId),
                    CommandType.Text, null);
                if (iCount%100==0) _log.Info(mss.ProductId + ":" + mss.ImageId + ":" + iCount);
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}