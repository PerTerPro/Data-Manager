using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Web;
using System.Web.Services;
using Websosanh.NotificationSystem.Common;
using Websosanh.NotificationSystem.Common.DAL;
using System.Collections.Specialized;
using System.Configuration;
using Websosanh.Core.Drivers.RabbitMQ.Configuration;
using Websosanh.Core.Drivers.RabbitMQ;

namespace Websosanh.Notification.Server
{
    /// <summary>
    /// Summary description for NotificationServer
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class NotificationServer : System.Web.Services.WebService
    {
        private static Dictionary<string, ClientState> ClientListening = new Dictionary<string, ClientState>();
        private static Dictionary<string, Queue<Message>> m_Message = new Dictionary<string, Queue<Message>>();
        private static Dictionary<string, List<Thread>> m_Threading = new Dictionary<string, List<Thread>>();
        private static ConnectionFactory factory = null;
        [WebMethod]
        public string PublishMessage(string channelName, string message, int timeToLive, bool messagePersistent)
        {
            NotificationProducer noti = new NotificationProducer("rabbitMQ177", channelName,"", messagePersistent);
            noti.PublishMessage(message, timeToLive);
            return "OK";
        }

        [WebMethod]
        public string SubcribeChannel(string registrationCode, string passWord, string channelName)
        {
            return "OK";
        }

        [WebMethod]
        public string Login(string registrationCode, string password)
        {
            bool clientValid = (new ClientDAL()).IsClientValid(registrationCode, password);
            if (clientValid)
            {
                lock (ClientListening)
                {
                    if (!ClientListening.ContainsKey(registrationCode))
                    {
                        ClientListening.Add(registrationCode, new ClientState(registrationCode));
                        #region Listent message queue
                        Thread th = new Thread(() =>
                        {
                            listentMessage(registrationCode);
                        });

                        Thread thCheckMesss = new Thread(() =>
                        {
                            while (true)
                            {

                                if (m_Message.ContainsKey(registrationCode) && m_Message[registrationCode].Count > 0)
                                {
                                    if(ClientListening.ContainsKey(registrationCode))
                                        ClientListening[registrationCode].ListentMessageCompleted.Set();
                                }
                            }
                        });
                        List<Thread> glstThread = new List<Thread>();
                        glstThread.Add(th);
                        glstThread.Add(thCheckMesss);

                        if (!m_Threading.ContainsKey(registrationCode))
                            m_Threading.Add(registrationCode, glstThread);
                        try
                        {
                            th.Start();
                        }
                        catch { }
                        try
                        {
                            thCheckMesss.Start();
                        }
                        catch { }
                        #endregion
                    }
                    else
                        return "Fail: Client đã login ở vị trí khác";
                }
                return "OK";
            }
            else
                return "Login fail";
        }

        private static void listentMessage(string registrationCode)
        {
            if (factory == null)
            {
                factory = new ConnectionFactory()
                {
                    HostName = "172.22.0.177",
                    Port = 5672,
                    UserName = "websosanh",
                    Password = "123456a@",
                    VirtualHost = "Test"
                };
            }

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var consumer = new QueueingBasicConsumer(channel);
                    channel.BasicConsume(registrationCode, false, consumer);
                    while (true)
                    {
                        var ea =
                            (BasicDeliverEventArgs)consumer.Queue.Dequeue();
                        var body = ea.Body;
                        var message = Websosanh.Core.Common.BAL.ProtobufTool.DeSerialize<string>(body);
                        Message mess = new Message()
                        {
                            MessageContent = message,
                            MessageValue = ea.DeliveryTag
                        };
                        if (!m_Message.ContainsKey(registrationCode))
                            m_Message.Add(registrationCode, new Queue<Message>());
                        Queue<Message> oldQueue = m_Message[registrationCode];
                        oldQueue.Enqueue(mess);
                        m_Message[registrationCode] = oldQueue;
                        channel.BasicAck(ea.DeliveryTag, false);

                    }
                }
            }
        }

        [WebMethod]
        public string Logout(string registrationCode, string password)
        {
            bool clientValid = (new ClientDAL()).IsClientValid(registrationCode, password);
            if (clientValid)
            {
                ClientListening.Remove(registrationCode);
                try
                {
                    List<Thread> glstThread = m_Threading[registrationCode];
                    glstThread.ForEach(t =>
                    {
                        try { t.Abort(); }
                        catch { }
                    });
                    m_Threading.Remove(registrationCode);
                }
                catch { }
                return "OK";
            }
            else
                return "Account not valid";
        }

        [WebMethod]
        public Message ListentNotification(string registrationCode)
        {
            if (ClientListening.ContainsKey(registrationCode))
            {
                bool signalled = ClientListening[registrationCode].ListentMessageCompleted.WaitOne();
                if (signalled)
                {
                    lock (ClientListening)
                    {
                        if(m_Message[registrationCode].Count > 0)
                            return m_Message[registrationCode].Dequeue();
                    }
                }
                else
                    return m_Message[registrationCode].Dequeue();
            }
            return null;
        }

        private class ClientState
        {
            public string RegistrationCode;
            public AutoResetEvent ListentMessageCompleted = new AutoResetEvent(false);
            public ClientState(string registrationCode)
            {
                RegistrationCode = registrationCode;
            }
        }
    }
}
