using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.LogCassandra;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WSS.Service.Crawler.Consumer.ServiceReference1;


namespace WSS.Service.Crawler.Consumer.FindNew
{
    public class Runner
    {
        readonly int _typeRun = 0;
        log4net.ILog _log = log4net.LogManager.GetLogger(typeof(Runner));
        CancellationTokenSource _cancellTokenSource = new CancellationTokenSource();
        private readonly int _numberThread;

        public Runner(int numberThread, CancellationTokenSource cancell, int typeRun)
        {
            this._numberThread = numberThread;
            this._typeRun = typeRun;
            this._cancellTokenSource = cancell;
        }

        public void Start()
        {
            _log.InfoFormat("Run with {0} worker", _numberThread);
            if (_typeRun == 0)
            {
                for (var i = 0; i < _numberThread; i++)
                {
                    var indexThread = i;
                    Task.Factory.StartNew(() =>
                        {
                            WorkerFindNew worker = new WorkerFindNew(indexThread, _cancellTokenSource.Token, "", true);
                            worker._eventGetCompanyCrawler += GetCompanyId;
                            worker.Start();
                        });
                }
            }
            else
            {
                for (var i = 0; i < this._numberThread; i++)
                {
                    var indexThread = i;
                    Task.Factory.StartNew(() =>
                    {
                        WorkerReload worker = new WorkerReload(indexThread, _cancellTokenSource.Token, "", true);
                        worker.EventGetCompanyCrawler += GetCompanyId;
                        worker.Start();
                    });
                }
            }
        }

        private long GetCompanyId()
        {
            try
            {
                var ran = new Random();
                Thread.Sleep(ran.Next(0, 30) * 1000);
                var serviceControlCrawler = new ServiceControlClient();
                var companyJob = (_typeRun == 0) ? serviceControlCrawler.GetCompanyCrawlerFindNew() : serviceControlCrawler.GetCompanyCrawlerReload();

                return companyJob == null ? 0 : companyJob.CompanyID;
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return 0;
            }
        }

    }
}
