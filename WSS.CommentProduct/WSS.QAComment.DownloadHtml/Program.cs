using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.QAComment.Core;

namespace WSS.QAComment.DownloadHtml
{class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Input thread");
            int iThread = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input domain");string str = Console.ReadLine();
            
            var rabbitMqServer = RabbitMQManager.GetRabbitMQServer(Config.RabbitMQServerComment);
            for (int i = 0; i < iThread; i++)
            {
                Task.Factory.StartNew(() =>
                {
                    var consumer = new ConsumerDownloadHtml(rabbitMqServer, str);
                    consumer.StartConsume();
                });
            }

            while (true)
            {
                Thread.Sleep(100000);
            }
        }
    }
}