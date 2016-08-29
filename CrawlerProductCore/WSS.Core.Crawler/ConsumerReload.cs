using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using log4net.Core;
using log4net.Util;
using QT.Entities.Data;
using QT.Moduls;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlerProduct.Cache;
using RabbitMQ.Client;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Core.Crawler
{
    public class ConsumerReload
    {
        private log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ConsumerReload));
        private readonly RedisCompanyWaitCrawler _redisWaitCrawler = RedisCompanyWaitCrawler.Instance();
        private readonly string _queueName;
        private readonly RabbitMQServer _rabbitmqServer;
        private CancellationToken _cancellationToken;
        private string _nameThread;

        private readonly SqlMutilThread _productAdapter= SqlMutilThread.Instance();

        public  ConsumerReload(RabbitMQServer rabbitmqServer, string queueName, CancellationToken token, string nameThread="")
        {
            _rabbitmqServer = rabbitmqServer;
            _cancellationToken = token;
            _queueName = queueName;
            _nameThread = nameThread;
        }

        public ConsumerReload(CancellationToken token, string nameThread)
        {
            _rabbitmqServer = RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler);
            _cancellationToken = token;
            _queueName = ConfigCrawler.QueueCompanyReload;
            _nameThread = nameThread;
        }

        public void Start()
        {
            _log.InfoFormat("Start consumer: {0} at queue {1}", "", _queueName);
            while (true)
            {
                try
                {
                    _cancellationToken.ThrowIfCancellationRequested();
                    JobCompanyCrawler jobCompany = GetJob();
                    if (jobCompany != null)
                    {
                        if (jobCompany.CheckRunning && CheckOtherRunning(jobCompany.CompanyId))
                        {_log.Info(string.Format("Other running company: {0}", jobCompany));
                        }
                        else if (!_productAdapter.AllowCrawlReload(jobCompany.CompanyId))
                        {
                            _log.Info("Not allow crawler");
                            _redisWaitCrawler.DeleteWaitReload(new List<long> {jobCompany.CompanyId});
                        }
                        else
                        {
                            using (var worker = new WorkerReload(jobCompany.CompanyId, _cancellationToken, _nameThread))
                            {
                                worker.StartCrawler();
                            }
                        }
                    }
                    else
                    {
                        _log.Info("No company to crawler");
                        Thread.Sleep(60000);
                    }
                }
                catch (OperationCanceledException task)
                {
                    break;
                }
                catch (Exception ex1)
                {
                    _log.Error(ex1);
                    Thread.Sleep(10000);
                }
            }

        }

        private  static object objLog = new object();

        private JobCompanyCrawler GetJob()
        {
            lock (objLog)
            {
                try
                {
                    using (var model = _rabbitmqServer.CreateChannel())
                    {
                        var data = model.BasicGet(ConfigCrawler.QueueCompanyReload, true);
                        return (data == null) ? null : JobCompanyCrawler.ParseFromJson((UTF8Encoding.UTF8.GetString(data.Body)));
                    }
                }
                catch (Exception ex)
                {
                    _log.Error(ex);
                    return null;
                }
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
