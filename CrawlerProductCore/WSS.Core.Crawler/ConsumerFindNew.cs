using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using log4net.Core;
using log4net.Util;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlerProduct.Cache;
using RabbitMQ.Client;
using RabbitMQ.Client.Framing;
using RabbitMQ.Client.Impl;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Core.Crawler
{
    public class ConsumerFindNew 
    {
        private log4net.ILog _log = log4net.LogManager.GetLogger(typeof(WorkerFindNew));
        private readonly RedisCompanyWaitCrawler _redisWaitCrawler = RedisCompanyWaitCrawler.Instance();
        private readonly string _queueName;
        private readonly RabbitMQServer _rabbitmqServer;
        private CancellationToken _token;
        private readonly SqlMutilThread _productAdapter = SqlMutilThread.Instance();
        private readonly string _nameThread;

        public ConsumerFindNew(RabbitMQServer rabbitmqServer, string queueName, CancellationToken token)
        {
            _rabbitmqServer = rabbitmqServer;
            _token = token;
            _queueName = queueName;
        }

        public ConsumerFindNew(CancellationToken token, string nameThread)
        {
            _rabbitmqServer = RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler);
            _token = token;
            _queueName = ConfigCrawler.QueueCompanyFindnew;
            _nameThread = nameThread;
        }

        public void Start()
        {
            _log.InfoFormat("Start consumer FindNew");
            while (true)
            {
                try
                {
                    _token.ThrowIfCancellationRequested();
                    JobCompanyCrawler jobCompanyCrawler = GetJob();
                    if (jobCompanyCrawler != null)
                    {
                        if (jobCompanyCrawler.CheckRunning && CheckOtherRunning(jobCompanyCrawler.CompanyId))
                        {
                            _log.Info(string.Format("Other running company: {0}", jobCompanyCrawler));
                        }
                        else if (!_productAdapter.AllowCrawlFindNew(jobCompanyCrawler.CompanyId))
                        {
                            _log.Info("Not allow crawler");
                            _redisWaitCrawler.DeleteWaitFindNew(new List<long> {jobCompanyCrawler.CompanyId});
                        }
                        else
                        {
                            using (var worker = new WorkerFindNew(jobCompanyCrawler.CompanyId, _token, _nameThread))
                            {
                                worker.StartCrawler();
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(60000);
                        _log.Info("No company to crawler");
                    }
                }
                catch (OperationCanceledException  task)
                {
                    break;
                }
                catch (Exception ex1)
                {
                    _log.Error(ex1);
                }
            }
        }

        private JobCompanyCrawler GetJob()
        {
            try
            {
                using (var model = _rabbitmqServer.CreateChannel())
                {
                    var data = model.BasicGet(ConfigCrawler.QueueCompanyFindnew, true);
                    return (data == null) ? null : JobCompanyCrawler.ParseFromJson(UTF8Encoding.UTF8.GetString(data.Body));
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return null;
            }
        }

        private bool CheckOtherRunning(long companyId)
        {
            if (_redisWaitCrawler.CheckRunningCrawler(companyId))
            {
                _redisWaitCrawler.SetNexReload(companyId, 1);
                return true;
            }
            else return false;
        }


        public void Stop()
        {
            
        }
    }
}
