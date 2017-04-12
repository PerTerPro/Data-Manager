using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using WSS.Service.Report.ProductOnClick.Error.Object;

namespace WSS.Service.Report.ProductOnClick.Error.Worker
{
    public class WorkerCheckErrorNew
    {
        public void Process()
        {
            var _rabbitMqServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            var worker = new Websosanh.Core.JobServer.Worker("CMS.CommentNotify", false, _rabbitMqServer);
            
            worker.JobHandler = (downloadImageJob) =>
            {
                var product = MsProduct.GetDataFromMessage(downloadImageJob.Data);
                var a = product;
                return true;
            };
            worker.Start();
        }
    }
}
