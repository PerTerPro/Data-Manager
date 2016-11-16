using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;

namespace ImboForm
{
    public class HandlerDelImgImbo
    {


        ProducerBasic pb = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo),ConfigImbo.QueueDelImgImbo);
        public void ProcessJob(JobWaitDelImg deserializeObject)
        {
           //Del data
        }

        public void PushBack(string imgId)
        {
            pb.PublishString(new JobWaitDelImg()
            {
                ImageId = imgId
            }.GetJson());
        }
    }
}
