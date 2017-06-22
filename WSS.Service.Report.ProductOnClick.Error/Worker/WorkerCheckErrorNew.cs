using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Service.Report.ProductOnClick.Error.Model;
using WSS.Service.Report.ProductOnClick.Error.Object;

namespace WSS.Service.Report.ProductOnClick.Error.Worker
{
    public class WorkerCheckErrorNew
    {
        public void Process()
        {
            var rabbitMqServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            var worker = new Websosanh.Core.JobServer.Worker("CMS.CommentNotify", false, rabbitMqServer);
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
