using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using RabbitMQ.Client;
using RabbitMQ.Client.Framing;
using Websosanh.Core.Drivers.RabbitMQ;
using RabbitMQ.Client.Events;

namespace QT.Moduls
{
    public class ProducerBasic : Producer
    {
        private log4net.ILog _log = LogManager.GetLogger(typeof (ProducerBasic));

        public ProducerBasic(RabbitMQServer rabbitmqServer, string exchangeName, string routingKey) : base(rabbitmqServer, exchangeName, routingKey, "")
        {
            InitQueue(rabbitmqServer);
        }

        public ProducerBasic(RabbitMQServer rabbitmqServer, string queueName)
            : base(rabbitmqServer, "", queueName, queueName)
        {
            InitQueue(rabbitmqServer);

        }

        private void InitQueue(RabbitMQServer rabbitmqServer)
        {
            if (!string.IsNullOrEmpty(this.QueueName))
            {
                while (true)
                {
                    try
                    {
                        var imodel = rabbitmqServer.CreateChannel();
                        if (imodel != null)
                        {
                            imodel.QueueDeclare(this.QueueName, true, false, false, null);
                            return;
                        }
                        else Thread.Sleep(1000);
                    }
                    catch (Exception ex)
                    {
                        _log.Error(ex);
                        Thread.Sleep(1000);
                    }
                }
            }
        }

      


        public override bool Init()
        {
            return true;
        }

        protected override void MessageReturn(object sender, BasicReturnEventArgs args)
        {
        }

        public void Publish(byte[] mss, bool persistence = true, int timeLiveBySecond = 0)
        {
            while (true)
            {
                try
                {
                    IBasicProperties properties = new BasicProperties();
                    if (timeLiveBySecond > 0) properties.Expiration = Convert.ToString(timeLiveBySecond * 1000);
                    properties.Persistent = persistence;
                    Publish(true, properties, mss);
                    break;
                }
                catch (Exception exception)
                {
                    _log.Error(exception);
                    Thread.Sleep(5000);
                }
            }
        }

        public void PublishString(string mss, bool persistence = true, int timeLiveBySecond = 0)
        {
            while (true)
            {
                try
                {
                    IBasicProperties properties = new BasicProperties();
                    if (timeLiveBySecond > 0) properties.Expiration = Convert.ToString(timeLiveBySecond * 1000);
                    properties.Persistent = persistence;
                    Publish(true, properties, UTF8Encoding.UTF8.GetBytes(mss));
                    break;
                }
                catch(Exception exception)
                {
                    _log.Error(exception);
                    Thread.Sleep(5000);
                }
            }

        }
    }
}
