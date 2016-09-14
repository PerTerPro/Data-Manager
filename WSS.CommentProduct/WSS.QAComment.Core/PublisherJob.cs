using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.QAComment.Core
{
     public  class PublisherJob:Websosanh.Core.Drivers.RabbitMQ.Producer

     {
         private readonly ILog _log = LogManager.GetLogger(typeof(PublisherJob));
         public PublisherJob(RabbitMQServer rabbitmqServer, string exchangeName, string routingKey, string queueName) : base(rabbitmqServer, exchangeName, routingKey, queueName)
         {
             while ( true)
             {
                 try
                 {
                     IModel model = rabbitmqServer.CreateChannel();
                  break;
                 }
                 catch(Exception ex)
                 {
                     _log.Error(ex.Message + ex.StackTrace);
                     Thread.Sleep(1000);

                 }
             }
         }

         public override bool Init()
         {
             return true;
         }

         protected override void MessageReturn(object sender, BasicReturnEventArgs args)
         {
             
         }
    }
}
