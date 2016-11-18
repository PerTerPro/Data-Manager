using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using log4net.Util;
using QT.Entities;
using QT.Entities.CrawlerProduct.Comment;
using QT.Moduls;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlerProduct.Cache;
using RabbitMQ.Client;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Core.Crawler
{
    public class RunnerPushCompanyCrawler
    {
        private ILog _log = LogManager.GetLogger(typeof(RunnerPushCompanyCrawler));
        public void Start()
        {
            var redisCompanyWaitCrawler = RedisCompanyWaitCrawler.Instance();
            var rabbitMq =RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler);
            var producerFindNew = new ProducerBasic(rabbitMq, ConfigCrawler.ExchangeCompanyFindNew, ConfigCrawler.RoutingkeyCompanyFindNew);
            var producerReload = new ProducerBasic(rabbitMq, ConfigCrawler.ExchangeCompanyReload, ConfigCrawler.RoutingkeyCompanyReload);
           
            while (true)
            {
                try
                {
                    var channel = rabbitMq.CreateChannel();
                    QueueDeclareOk reDeclareOkFn = channel.QueueDeclare(ConfigCrawler.QueueCompanyFindnew, true, false,
                        false, null);
                    QueueDeclareOk reDeclareOkRl = channel.QueueDeclare(ConfigCrawler.QueueCompanyReload, true, false,
                        false, null);

                    if (reDeclareOkFn.MessageCount < 10)
                    {
                        var companyWaitFindNews = redisCompanyWaitCrawler.GetWaitingCrawlerFindNew(true, 500);
                        foreach (var comp in companyWaitFindNews)
                        {
                            producerFindNew.PublishString(new JobCompanyCrawler() {CompanyId = comp.CompanyID, CheckRunning = true}.GetJSon());
                        }
                        _log.Info(string.Format("Pushed {0} company reload", companyWaitFindNews.Count));
                    }
                    else
                    {
                        _log.Info("Skip findNew because full job");
                    }

                    if (reDeclareOkRl.MessageCount < 10)
                    {var companyWaitReloads = redisCompanyWaitCrawler.GetWaitingCrawlerReload(true, 500);
                        foreach (var comp in companyWaitReloads)
                        {
                            producerReload.PublishString(new JobCompanyCrawler() {CheckRunning = true, CompanyId = comp.CompanyID}.GetJSon());
                        }
                        _log.Info(string.Format("Pushed {0} company reload", companyWaitReloads.Count));
                    }
                    else
                    {
                        _log.Info("Skip reload because full job");
                    }

                    rabbitMq.CloseChannel(channel);
                }
                catch (Exception ex)
                {
                    _log.Error(ex);
                }
                Thread.Sleep(10000);
            }
        }
    }
}
