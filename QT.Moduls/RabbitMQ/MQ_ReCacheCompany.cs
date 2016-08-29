using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace QT.Moduls.RabbitMQ
{
    
    public class MQ_ReCacheCompany
    {
        static MQ_ReCacheCompany _MQ_ReCacheCompany = null;

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(MQ_ReCacheCompany));
        RabbitMQServer rabbitMQServer = null;
        JobClient updateProductJobClient_PushCompany = null;
        
        public MQ_ReCacheCompany Instance()
        {
            return (_MQ_ReCacheCompany == null) ? (_MQ_ReCacheCompany = new MQ_ReCacheCompany()) : _MQ_ReCacheCompany;
        }

        public MQ_ReCacheCompany ()
        {
            this.rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            string updateProductGroupName_ChangeMainInfo = System.Configuration.ConfigurationManager.AppSettings["updateProductGroupName"].ToString();
            string updateProductJobName_ChangeMainInfo = System.Configuration.ConfigurationManager.AppSettings["updateProductToWebJobName"].ToString();
            this.updateProductJobClient_PushCompany = new JobClient(updateProductGroupName_ChangeMainInfo, GroupType.Topic, updateProductJobName_ChangeMainInfo, true, rabbitMQServer);
        }

        public void PushQueueIndexCompany(long CompanyID)
        {
            try
            {
                var updateProductJob = new Websosanh.Core.JobServer.Job();
                updateProductJob.Data = BitConverter.GetBytes(CompanyID);
                int updateProductJobExpirationMS = 3600000;
                updateProductJobClient_PushCompany.PublishJob(updateProductJob, updateProductJobExpirationMS);
            }
            catch (Exception ex01)
            {
                log.Error(string.Format("Error push job ChangeMainInfo to MQ:{0}.{1}", ex01.Message, ex01.StackTrace));
                Thread.Sleep(10000);
            }
        }
    }
}
