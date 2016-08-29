using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace QT.Moduls
{
    public class JobPushChangeImage:JobClient
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(JobPushChangeImage));
        public void PushQueueChangeChangeImage(MqChangeImage mss)
        {
            while (true)
            {
                try
                {
                    var jobMq = new Websosanh.Core.JobServer.Job
                    {
                        Data = MqChangeImage.GetMess(mss),
                        Type = (int) TypeJobWithRabbitMQ.Product
                    };
                    base.PublishJob(jobMq, 0);
                    return;
                }
                catch (Exception ex01)
                {
                    _log.Error(string.Format("Error push job ChangeMainInfo to MQ:{0}.{1}", ex01.Message, ex01.StackTrace));
                    Thread.Sleep(10000);
                }
            }
        }

        public JobPushChangeImage(string groupName, GroupType groupType, string jobName, bool jobPersistent, RabbitMQServer rabbitMqServer) : 
            base(groupName, groupType, jobName, jobPersistent, rabbitMqServer)
        {
        }
    }
}
