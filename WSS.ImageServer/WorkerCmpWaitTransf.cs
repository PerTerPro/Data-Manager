using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.ImageServer;

namespace ImboForm
{
    public class WorkerCmpWaitTransf : QueueingConsumer
    {
        readonly HandlerCmpWaitTransf _handlerMss = new HandlerCmpWaitTransf();
        private readonly ILog _log = log4net.LogManager.GetLogger(typeof (WorkerCmpWaitTransf));
        private int _countCmp = 0;

        public WorkerCmpWaitTransf() : base(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), ConfigImbo.QueueCompanyWaitPushProductTransferImage, false)
        {
        }

        public override void Init()
        {
        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            JobCmpWaitTransf jobCmpWaitTransf = JobCmpWaitTransf.FromJson(Encoding.UTF8.GetString(message.Body));
            _countCmp = _handlerMss.PushDownloadImageByCompany(jobCmpWaitTransf.CompanyId);
            _log.Info(string.Format("Pushed for {1} company: {0}", jobCmpWaitTransf.CompanyId, _countCmp));
            GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
