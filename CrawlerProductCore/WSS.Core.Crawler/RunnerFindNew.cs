using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using log4net.Core;
using QT.Moduls.CrawlerProduct;

namespace WSS.Core.Crawler
{
    public class RunnerFindNew
    {
        public DelegateShowLog _eventShowLog = null;
        public DelegateGetCompanyCrawler _eventGetCompanyCrawler;

    


        public void Start()
        {
            while (true)
            {
                try
                {
                }
                catch (OperationCanceledException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    Thread.Sleep(10000);
                }
            }
        }

        private JobCrawler GetCompanyCrawler()
        {
            if (this._eventGetCompanyCrawler != null)
                return new JobCrawler()
                {
                    CompanyID = _eventGetCompanyCrawler()
                };
            return null;
        }
    }
}
