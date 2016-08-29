using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace Websosanh.NotificationSystem.Common
{
    public class NotificationPublisher:Producer
    {
        public NotificationPublisher(RabbitMQServer rabbitMQServer, string exchangeName, string routingKey, string queueName)
            : base(rabbitMQServer, exchangeName, routingKey, queueName)
        {
            this.rabbitMQServer = rabbitMQServer;
            this._exchangeName = exchangeName;
            this._routingKey = routingKey;
            this._queueName = queueName;
        }

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(NotificationPublisher));
        RabbitMQServer rabbitMQServer = null;
        JobClient updateProductJobClient_PushCompany = null;

        //public NotificationPublisher(string rabbitMQ, string exchange,string routingKey, bool JobPersisten)
        //{

        //    this.Exchange = exchange;
        //    this.RoutingKey = routingKey;

        //    rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ1771");
        //    updateProductJobClient_PushCompany = new JobClient(exchange, GroupType.Topic, routingKey, true, rabbitMQServer);
        //}


        

        public bool PublishMessage(string mss, int iTry = 3)
        {
            log.Info("Push");
            int iCountFail = 0;
            while (true)
            {
                try
                {
                    base.Publish(true, null, System.Text.Encoding.UTF8.GetBytes(mss));
                    //updateProductJobClient_PushCompany.PublishJob(new Job()
                    //    {
                    //        Type = 0,
                    //        Data = System.Text.Encoding.UTF8.GetBytes(mss)
                    //    }, 1000000);
                    return true;
                }
                catch (Exception ex01)
                {
                    iCountFail++;
                    if (iCountFail > iTry)
                    {
                        (new MessageDAL()).InsertMessage(mss, this.RoutingKey, this.RoutingKey);
                        return false;
                    }
                    else
                    {
                        Thread.Sleep(10000);
                    }
                }
            }
        }

        private string Exchange = "";
        private string RoutingKey = "";

        public override bool Init()
        {
            return true;
        }

        protected override void MessageReturn(object sender, RabbitMQ.Client.Events.BasicReturnEventArgs args)
        {
           
        }
    }
}
