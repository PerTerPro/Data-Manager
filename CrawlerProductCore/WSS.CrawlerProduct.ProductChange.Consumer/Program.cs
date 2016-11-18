using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlerProduct.Cache;
using RabbitMQ.Client;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Core.Crawler;

namespace WSS.CrawlerProduct.ProductChange.Consumer
{
    class Program
    {
        public static void Main(string[] args)
        {

            if (args == null || args.Length == 0)
            {
                Console.WriteLine(Parameter.Para);
                var readLine = Console.ReadLine();
                if (readLine != null) args = readLine.Split(' ');
            }

            var pt = new Parameter();
            pt.Parse(args);

            
            
            if (pt.IsPushCompany)
            {
                Task.Factory.StartNew(() =>
                {
                    var run = new RunnerPushCompanyCrawler();
                    run.Start();
                });
            }

            Thread.Sleep(1000);
            if (pt.IsUpdateProductToSql)
            {
                Task.Factory.StartNew(() =>
                {
                    var consumer = new ConsumerProductChangeToSql();
                    consumer.StartConsume();
                });
            }

            Thread.Sleep(1000);
            if (pt.IsSaveToCache)
            {
                Task.Factory.StartNew(() =>
                {
                    var consumer = new ConsumerProductChangeToCache(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler),"");
                    consumer.StartConsume();
                });
            }

            Thread.Sleep(1000);
            if (pt.IsSaveToCache)
            {
                Task.Factory.StartNew(() =>
                {
                    var consumer = new ConsumerProductChangeToCache(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), "");
                    consumer.StartConsume();
                });
            }

            Thread.Sleep(1000);
            if (pt.IsSaveClassification)
            {
                Task.Factory.StartNew(() =>
                {
                    var worker = new ConsumerAddClassification();
                    worker.StartConsume();
                });
            }

            Thread.Sleep(1000);
            if (pt.IsSaveToEndQueue)
            {
                Task.Factory.StartNew(() =>
                {
                    var c = new ConsumerSaveEndSession(ConfigCrawler.QueueEndSessionToSql);
                    c.StartConsume();
                });
            }

            Thread.Sleep(1000);
            if (pt.IsUpdateRunningCrawler)
            {
                Task.Factory.StartNew(() =>
                {
                    var c = new ConsumerSessionRunningUpdate();
                    c.StartConsume();
                });
            }

            while (true)
            {
                Thread.Sleep(1000);
            }
            return;



            //if (iInput == 1)
            //{
            //    var consumer = new ConsumerProductChangeToSql(ConfigCrawler.QueueProductChangetoSql);
            //    consumer.StartConsume();
            //}
            //else if (iInput==2)
            //{
            //    var consumer = new ConsumerProductChangeToCache();
            //    consumer.StartConsume();
            //}
           
            //else if (iInput == 4)
            //{
            //    WorkerClassification worker = new WorkerClassification();
            //    worker.StartConsume();
            //}
            //else if (iInput == 5)
            //{
            //    var c = new ConsumerSaveEndSession(ConfigCrawler.QueueLogEnd);
            //    c.StartConsume();
            //}
            //return;
        }
    }
}
