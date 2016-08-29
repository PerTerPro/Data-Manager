using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using Websosanh.NotificationSystem.Common.DAL;

namespace Websosanh.NotificationSystem.Common
{
    public class NotificationConsumerMss
    {
        public delegate void EventProcessMessage(string mss);
        public EventProcessMessage _eventProcessMessage = null;
        private string updateDatafeedName;
        private RabbitMQServer rabbitMQServer = null;
        private  Worker worker;
        private string _password;

        public NotificationConsumerMss(string rabbitServer, string QueueName, string Password, EventProcessMessage _eventProcessMessage)
        {
            this._password = Password;
            this._eventProcessMessage = _eventProcessMessage;
            this.updateDatafeedName = QueueName;
            this.rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitServer);
            if (!(new ClientDAL()).IsClientValid(QueueName, Password))
            {
                throw new Exception("Fail pass word");
            }
            this.worker = new Worker(this.updateDatafeedName, false, rabbitMQServer);
            this.worker.JobHandler = (updateDatafeedJob) =>
            {
                string mss = System.Text.Encoding.UTF8.GetString(updateDatafeedJob.Data);
                this._eventProcessMessage(mss);
                return true;
            };
        }

      

     

        public void Start ( )
        {
            this.worker.Start();
        }

        public void Stop ()
        {
            this.worker.Stop();
        }
    }
}
