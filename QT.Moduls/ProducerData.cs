using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using log4net;
using RabbitMQ.Client;
using RabbitMQ.Client.Framing;
using Websosanh.Core.Drivers.RabbitMQ;

namespace QT.Moduls
{

   

    public class ProducerData
    {
        static readonly Dictionary<string, ProducerData> DicRabbitMq = new Dictionary<string, ProducerData>();
        private readonly RabbitMQServer _rabbitMqServer = null;
        private IModel _model;
        private ILog _log = LogManager.GetLogger(typeof(ProducerData));

        private ProducerData(RabbitMQServer getRabbitMqServer)
        {
            _rabbitMqServer = getRabbitMqServer;
        }

        readonly object _objPushMss = new object();

        public void PushMss(string exchange, string routingKey, IBasicProperties basicProperties, byte[] body)
        {
            lock (_objPushMss)
            {
                while (true)
                {
                    try
                    {
                        InitChanel();
                        _model.BasicPublish(exchange, routingKey, basicProperties, body);
                        return;
                    }
                    catch (Exception ex)
                    {
                        _log.Error(ex);
                        Thread.Sleep(10000);
                    }
                }
            }
        }

        public void PushMss(string exchange, string routingKey, IBasicProperties basicProperties, string message)
        {

            lock (_objPushMss)
            {
                while (true)
                {
                    try
                    {
                        InitChanel();
                        _model.BasicPublish(exchange, routingKey, basicProperties, Encoding.UTF8.GetBytes(message));
                        return;
                    }
                    catch (Exception ex)
                    {
                        _log.Error(ex);
                        Thread.Sleep(10000);
                    }
                }
            }
        }

        public void PushMss(string exchange, string routingKey, bool persistence, byte[] body)
        {
            lock (_objPushMss)
            {
                while (true)
                {
                    try
                    {
                        InitChanel();
                        IBasicProperties properties = new BasicProperties();
                        properties.Persistent = persistence;
                        _model.BasicPublish(exchange, routingKey, properties, body);
                        return;
                    }
                    catch (Exception ex)
                    {
                        _log.Error(ex);
                        Thread.Sleep(10000);
                    }
                }
            }
        }


        public void PushMss(string exchange, string routingKey, bool persistence, string message)
        {
            lock (_objPushMss)
            {
                while (true)
                {
                    try
                    {
                        InitChanel();
                        IBasicProperties properties = new BasicProperties();
                        properties.Persistent = persistence;
                        _model.BasicPublish(exchange, routingKey, properties, Encoding.UTF8.GetBytes(message));
                        return;
                    }
                    catch (Exception ex)
                    {
                        _log.Error(ex);
                        Thread.Sleep(10000);
                    }
                }
               
            }
        }


        public void InitChanel()
        {
            while (true)
            {
                if (_model == null || _model.IsClosed)
                {
                    _model = _rabbitMqServer.CreateChannel();
                    if (_model == null)
                    {
                        _log.Info("Sleep and try again create model RabbitMQ");
                        Thread.Sleep(3000);
                    }
                }
                break;
            }
        }

        public static ProducerData Instance(string rabbitMq){
            lock (DicRabbitMq)
            {
                if (!DicRabbitMq.ContainsKey(rabbitMq))
                {

                    DicRabbitMq.Add(rabbitMq, new ProducerData(RabbitMQManager.GetRabbitMQServer(rabbitMq)));
                }
                return DicRabbitMq[rabbitMq];
            }
        }

        public BasicGetResult BasicGet(string queue, bool noAck)
        {
            lock (_objPushMss)
            {
                InitChanel();
                return _model.BasicGet(queue, noAck);
            }
        }
    }
}
