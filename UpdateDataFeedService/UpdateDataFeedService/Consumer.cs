using log4net;
using RabbitMQ.Client;
using RabbitMQ.Client.Exceptions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.UpdateDataFeedService
{
    public class Consumer
    {
        protected IModel Model;
        protected IConnection Connection;
        protected string QueueName;

        protected bool isConsuming;
        private static readonly ILog Log = LogManager.GetLogger(typeof(Consumer));

        // used to pass messages back to UI for processing
        public delegate void onReceiveMessage(byte[] message);
        public event onReceiveMessage onMessageReceived;

        public Consumer(string hostName, string queueName)
        {
            QueueName = queueName;
            ConnectionFactory connectionFactory = new ConnectionFactory();
            connectionFactory.UserName = ConfigurationSettings.AppSettings["UserName"];
            connectionFactory.Password = ConfigurationSettings.AppSettings["Password"];
            connectionFactory.VirtualHost = ConfigurationSettings.AppSettings["VirtualHost"];
            connectionFactory.Protocol = Protocols.DefaultProtocol;
            connectionFactory.HostName = hostName;
            connectionFactory.Port = 5672;
            try
            {
                    Connection = connectionFactory.CreateConnection();
            }
            catch (Exception ex)
            {
                Log.Error("Connection Error", ex);
            }
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
                    IBasicProperties props = e.BasicProperties;
                    byte[] body = e.Body;
                    // ... process the message
                    onMessageReceived(body);
                    Model.BasicAck(e.DeliveryTag, false);
                }
                catch (OperationInterruptedException ex)
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
