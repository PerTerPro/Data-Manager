using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace WSS.Service.CrawlerProduct.Control
{
    public class ServiceControl : IServiceControl
    {
        QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler redisWait = QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler.Instance();
    
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(ServiceControl));
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public static object objLockReload = new object();
        public QT.Moduls.CrawlerProduct.JobCrawler GetCompanyCrawlerReload()
        {
            lock (objLockReload)
            {
                while (true)
                {
                    log.Info(string.Format("{0} {1} {2}", DateTime.Now, lastCacllRL, (DateTime.Now - lastCacllRL).TotalMilliseconds));
                    if (((DateTime.Now - lastCacllRL).TotalMilliseconds) < 500)
                    {
                        log.Info("Sleep Reload");
                        Thread.Sleep(100);
                    }
                    else
                    {
                        lastCacllRL = DateTime.Now;
                        break;
                    }
                }
                iCountCallRL++;
                var company = new QT.Moduls.CrawlerProduct.JobCrawler()
                {
                    CompanyID = redisWait.GetCompanyCrawlerReload(),
                    GuidCheckFinish = "1"
                };
                log.Info(string.Format("{0} Reload:{1}", iCountCallRL, company.CompanyID));

                return company;
            }
        }

        public static object objLockFindNew = new object();
        public QT.Moduls.CrawlerProduct.JobCrawler GetCompanyCrawlerFindNew()
        {
            lock (objLockFindNew)
            {
                while (true)
                {
                    log.Info(string.Format("{0} {1} {2}", DateTime.Now, lastCallFN, (DateTime.Now - lastCacllRL).TotalMilliseconds));
                    if (((DateTime.Now - lastCallFN).TotalMilliseconds) < 500)
                    {
                        log.Info("Sleep FindNew");
                        Thread.Sleep(100);
                    }
                    else
                    {
                        lastCallFN = DateTime.Now;

                        break;
                    }
                }
                iCountCallFN++;
                var company = new QT.Moduls.CrawlerProduct.JobCrawler()
                {
                    CompanyID = redisWait.GetCompanyCrawlerFindNew(),
                    GuidCheckFinish = "1"
                };
                log.Info(string.Format("{0} FindNew:{1}", iCountCallFN, company.CompanyID));

                return company;
            }
        }

        static int iCountCallFN = 0;
        static int iCountCallRL = 0;
        static DateTime lastCallFN = DateTime.Now;
        static DateTime lastCacllRL = DateTime.Now;
       
        public void UpdateCrawlerReloadEnd(long CompanyID)
        {
           
        }

        public void UpdateCrawlerFindEnd(long CompanyID)
        {

        }


        public int CoutListWait()
        {
            return 0;
        }


        public bool SaveWaiting()
        {
          
            return true;
        }


        public void UpdateCrawlerReloadStopImediate(long CompanyID)
        {
        }
    }
}
