using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImboForm;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.ImageServer.Service
{
    public class ServiceImbo
    {
        public static void PushAllProductTransfer(IEnumerable<long> domains)
        {
            HandlerCmpWaitTransf handlerCmpWaitTransf = new HandlerCmpWaitTransf();
            foreach (var domain in domains)
            {
                handlerCmpWaitTransf.PushDownloadImageByCompany(domain);
            }
        }

        public static void PushCompanyUpdateImgImbo(List<string> domain)
        {
            int countPush = 0;
            ImageAdapterSql imageAdapterSql = new ImageAdapterSql();
            ProducerBasic producerCompanyImage = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), ConfigImbo.QueueCompanyWaitPushProductTransferImage);
            List<long> companyIds = imageAdapterSql.GetCompanyIdByDomain(domain);
            foreach (var companyId in companyIds)
            {
                countPush++;
                producerCompanyImage.PublishString(new JobCmpWaitTransf()
                {
                    CompanyId = companyId
                }.GetJson());
            }

        }

        public static void RunWorkerTransfer(int numThreads)
        {
            
        }

        public static void WorkerUpdateImageId (int numThreads)
        {
            
        }

        public static void WorkerWaitThumb(int numThreads)
        {
            
        }
    }
}
