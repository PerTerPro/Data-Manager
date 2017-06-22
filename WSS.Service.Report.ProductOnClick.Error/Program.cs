using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Websosanh.Core.Drivers.RabbitMQ;
using Wss.Lib.RabbitMq;
using WSS.Service.Report.ProductOnClick.Error.Model;

namespace WSS.Service.Report.ProductOnClick.Error
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            var _kerner = new StandardKernel(new MappingNinject());
            for (int i = 0; i < 1; i++)
            {
                var workerTask = new Task(() =>
                {
                    IHandlerClick handler = _kerner.Get<IHandlerClick>();
                    ConsumerBasic<MsProduct> consumer = new ConsumerBasic<MsProduct>(RabbitMQManager.GetRabbitMQServer("rabbitMQ177_OnClick"), "Product.OnClick");
                    consumer._eventProcessJob += (job) =>
                    {
                        handler.Process(job);
                    };
                  
                    consumer.StartConsume();
                });
                workerTask.Start();
              
            }
            Console.ReadLine();

            //var servicesToRun = new ServiceBase[] 
            //{ 
            //    new ReportErrorProductOnClick() 
            //};
            //ServiceBase.Run(servicesToRun);
        }
    }
}
