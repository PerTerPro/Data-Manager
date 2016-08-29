using log4net;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrawlerConsumer
{
    public class ConsumerWithEvent
    {
        protected IModel Model;
        protected IConnection Connection;
        public string QueueName;

        public bool isConsuming;
        private static readonly ILog Log = LogManager.GetLogger(typeof(ConsumerWithEvent));

        // used to pass messages back to UI for processing
        public delegate bool onReceiveMessage(byte[] message);
        public event onReceiveMessage onMessageReceived;

        public ConsumerWithEvent()
        {
            int Port = QT.Entities.Server.RabbitMQ_Port;
            string userName = QT.Entities.Server.RabbitMQ_User;
            string password = QT.Entities.Server.RabbitMQ_Pass;
            Log.Info(string.Format("Init consumer process RabbitMQ at {0} {1} {2} {3}", hostName, Port, userName, ""));
            InitValue(hostName, "", userName, password, Port);
        }

            string hostName = QT.Entities.Server.RabbitMQ_Host;

        public void StopConsumer ()
        {
            try
            {
                this.Model.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public ConsumerWithEvent(string hostName, string queueName, string userName, string password, int port=5672)
        {
            InitValue(hostName, queueName, userName, password, port);
        }

        public ConsumerWithEvent(string hostName, string queueName, string userName, string password)
        {
            InitValue(hostName, queueName, userName, password, 5672);
        }

        private void InitValue(string hostName, string queueName, string userName, string password, int port)
        {
            QueueName = queueName;
            ConnectionFactory connectionFactory = new ConnectionFactory();
            connectionFactory.UserName = userName;
            connectionFactory.Password = password;
            //connectionFactory.VirtualHost = "locahost";
            connectionFactory.Protocol = Protocols.DefaultProtocol;
            connectionFactory.HostName = hostName;
            connectionFactory.Port = port;
            Connection = connectionFactory.CreateConnection();
            Model = Connection.CreateModel();
            Model.BasicQos(0, 1, false);
            bool durable = true;
            Model.QueueDeclare(QueueName, durable, false, false, null);
        }

        //internal delegate to run the consuming queue on a seperate thread
        private delegate void ConsumeDelegate();

        public void StartConsuming()
        {
            isConsuming = true;
            ConsumeDelegate c = new ConsumeDelegate(Consume);
            c.BeginInvoke(null, null);
        }

        public void Consume()
        {
            QueueingBasicConsumer consumer = new QueueingBasicConsumer(Model);
            bool autoAck = false;
            String consumerTag = Model.BasicConsume(QueueName, autoAck, consumer);
            while (isConsuming)
            {
                try
                {
                    RabbitMQ.Client.Events.BasicDeliverEventArgs e = (RabbitMQ.Client.Events.BasicDeliverEventArgs)consumer.Queue.Dequeue();
                    if (e != null)
                    {
                        IBasicProperties props = e.BasicProperties;
                        byte[] body = e.Body;
                        // ... process the message
                        bool bProcessed = onMessageReceived(body);
                        if (bProcessed) Model.BasicAck(e.DeliveryTag, false);
                      
                    }
                }
                catch (Exception ex)
                {
                    Log.Error("Consum Error", ex);
                    break;
                }
            }
        }

        public void Dispose()
        {
            isConsuming = false;
            if (Connection != null)
                Connection.Close();
            if (Model != null)
                Model.Abort();
        }
    }
}
