using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.NotificationSystem.Common;

namespace Websosanh.NotificationSystem.WriteMssToSQL
{
    public class Worker
    {
        public Worker ()
        {
            QT.Entities.Server.ConnectionString = @"Data Source=192.168.100.178;Initial Catalog=Notification;Persist Security Info=True;User ID=sa;Password=123456a@;connection timeout=200";
        }

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Worker));
        CancellationTokenSource cancellationTokenSource = null;
        public void Start ()
        {
        }

        public void Run()
        {
            cancellationTokenSource = new CancellationTokenSource();
            List<string> lstQueue = new List<string>();
            lstQueue.Add("DataQueue.AllEmployee");
            var _rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ_Notification");
            for (int i = 0; i < lstQueue.Count; i++)
            {
                string queueName = lstQueue[i];
                Task.Factory.StartNew(() =>
                    {
                        string queueNameData = queueName;
                            QT.Moduls.Notifycation.NotifycationAdapter adapter = new QT.Moduls.Notifycation.NotifycationAdapter();
                            log.Info("Start a consumer");
                            Websosanh.NotificationSystem.Common.NotificationConsumer basicConsumer = new NotificationConsumer(_rabbitMQServer, queueName, true, "123456");
                            while (true)
                            {
                                try
                                {
                                    BasicGetResult result = basicConsumer.GetMessage();
                                    if (result != null && result.Body != null)
                                    {
                                        string strMessage = System.Text.Encoding.UTF8.GetString(result.Body, 0, result.Body.Length);
                                        adapter.InsertMessage(queueNameData, strMessage, 0);
                                        log.Info(string.Format("MSS:{0}. Queue:{1}", strMessage, queueNameData));
                                    }
                                    else
                                    {
                                        log.Info("Not item");
                                    }
                                    Thread.Sleep(1000);
                                }
                                catch (OperationCanceledException operationCanceled)
                                {
                                    return;
                                }
                                catch (Exception ex01)
                                {
                                    log.Error(ex01);
                                    Thread.Sleep(10000);
                                }
                            }
                    });
            }
        }
    }
}
