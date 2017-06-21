using QT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace QT.Moduls
{
    public class RabbitMQAdapter
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(RabbitMQAdapter));

        private JobClient jobClient_PushCompany;
        private JobClient jobClient_ProductChangeImage;
        private JobClient jobClient_ProductChangePrice;
        private JobClient jobClient_AddProduct;
        private JobClient jobclient_ProductChangeData;
        private JobClient jobclint_ChangeDescription; 

        private static RabbitMQAdapter _Instance=null;
        private int updateProductJobExpirationMS;
        public static RabbitMQAdapter Instance
        {
            get
            {
                if (_Instance == null) _Instance = new RabbitMQAdapter();
                return _Instance;
            }
        }

        public RabbitMQAdapter ()
        {
            while (true)
            {
                try
                {
                    string updateProductGroupName_ChangeMainInfo = System.Configuration.ConfigurationManager.AppSettings["updateProductGroupName"].ToString();
                    string updateProductJobName_ChangeMainInfo = System.Configuration.ConfigurationManager.AppSettings["updateProductToWebJobName"].ToString();

                    string updateProductJobName_ChangeDescription = System.Configuration.ConfigurationManager.AppSettings["updateProductToWebJobName"].ToString();

                    string updateProductGroupName_ChangeImage = System.Configuration.ConfigurationManager.AppSettings["updateProductImageGroupName"].ToString();
                    string updateProductJobName_ChangeImage = System.Configuration.ConfigurationManager.AppSettings["updateProductImageProductJobName"].ToString();

                    string updateProductGroupName_ChangePrice = System.Configuration.ConfigurationManager.AppSettings["updateProductGroupName_ChangePrice"].ToString();
                    string updateProductJobName_ChangePrice = System.Configuration.ConfigurationManager.AppSettings["updateProductJobName_ChangePrice"].ToString();

                    string updateProductGroupName_AddProduct = System.Configuration.ConfigurationManager.AppSettings["updateProductGroupName_AddProduct"].ToString();
                    string updateProductJobName_AddProduct = System.Configuration.ConfigurationManager.AppSettings["updateProductJobName_AddProduct"].ToString();

                    string updateProductGroupName_ChangeData = System.Configuration.ConfigurationManager.AppSettings["updateProductGroupNameSingle"].ToString();
                    string updateProductJobName_ChangeData = System.Configuration.ConfigurationManager.AppSettings["updateProductToWebJobNameSingle"].ToString();

                    var rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");

                    this.updateProductJobExpirationMS = QT.Entities.Common.Obj2Int(System.Configuration.ConfigurationManager.AppSettings["updateProductJobExpirationMS"]);
                    this.updateProductJobExpirationMS = (updateProductJobExpirationMS == 0) ? 3500000 : updateProductJobExpirationMS;

                    this.jobClient_PushCompany = new JobClient(updateProductGroupName_ChangeMainInfo, GroupType.Topic, updateProductJobName_ChangeMainInfo, true, rabbitMQServer);
                    this.jobClient_ProductChangeImage = new JobClient(updateProductGroupName_ChangeImage, GroupType.Topic, updateProductJobName_ChangeImage, true, rabbitMQServer);
                    this.jobClient_ProductChangePrice = new JobClient(updateProductGroupName_ChangePrice, GroupType.Topic, updateProductJobName_ChangePrice, true, rabbitMQServer);
                    this.jobClient_AddProduct = new JobClient(updateProductGroupName_AddProduct, GroupType.Topic, updateProductJobName_AddProduct, true, rabbitMQServer);
                    this.jobclient_ProductChangeData = new JobClient(updateProductGroupName_ChangeData, GroupType.Topic, updateProductJobName_ChangeData, true, rabbitMQServer);
                    //this.jobclint_ChangeDescription = new JobClient("", GroupType.Direct, updateProductJobName_ChangeDescription, true,rabbitMQServer);

                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void PushProductToQueueChangeImage(long ProductID)
        {
            while (true)
            {
                try
                {
                    var jobMQ = new Websosanh.Core.JobServer.Job();
                    jobMQ.Data = BitConverter.GetBytes(ProductID);
                    jobMQ.Type = (int)TypeJobWithRabbitMQ.Product;
                    jobClient_ProductChangeImage.PublishJob(jobMQ, updateProductJobExpirationMS);
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(string.Format("Error push job ChangeMainInfo to MQ:{0}.{1}", ex01.Message, ex01.StackTrace));
                    Thread.Sleep(10000);
                }
            }
        }


        public void PushProductToQueueChangeMainInfo(long ProductID)
        {
            while (true)
            {
                try
                {
                    var jobMQ = new Websosanh.Core.JobServer.Job();
                    jobMQ.Data = BitConverter.GetBytes(ProductID);
                    jobMQ.Type = 2;
                    jobclient_ProductChangeData.PublishJob(jobMQ, updateProductJobExpirationMS);
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(string.Format("Error push job ChangeMainInfo to MQ:{0}.{1}", ex01.Message, ex01.StackTrace));
                    Thread.Sleep(10000);
                }
            }
        }

        public void PushToQueueChangeRootProductToWeb(long rootProductId)
        {
            try
            {
                var jobMQ = new Job
                {
                    Data = BitConverter.GetBytes(rootProductId),
                    Type = 1
                };
                jobclient_ProductChangeData.PublishJob(jobMQ, updateProductJobExpirationMS);
            }
            catch (Exception ex)
            {
                log.Error(string.Format("Error PushToQueneChangeRootProductToWeb:{0}.{1}", ex.Message, ex.StackTrace));
            }
        }

        public void PushProductToQueueChangeMainInfo(List<long> ProductID)
        {
            foreach (var item in ProductID) PushProductToQueueChangeMainInfo(item);
        }

        public void PushQueueProcessAfterChangeProduct(List<Product> lstProductChangeNeedUpdate)
        {
            foreach (var itemProductChanged in lstProductChangeNeedUpdate)
            {
                while (true)
                {
                    try
                    {
                        var updateProductJob = new Websosanh.Core.JobServer.Job();
                        updateProductJob.Data = BitConverter.GetBytes(itemProductChanged.ID);
                        jobclient_ProductChangeData.PublishJob(updateProductJob, updateProductJobExpirationMS);
                        break;
                    }
                    catch (Exception ex01)
                    {
                        log.Error(string.Format("Error push job ChangeMainInfo to MQ:{0}.{1}", ex01.Message, ex01.StackTrace));
                        Thread.Sleep(10000);
                    }
                }
            }
        }

        public void PushChangeDesciption(List<Product> productIdWaitChangeDesc)
        {
            foreach(var  item in productIdWaitChangeDesc)
            {
            this.jobclint_ChangeDescription.PublishJob(new Job()
                {
                    Data=null
                }, 0);
            }
        }
    }
}
