
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WSS.CrawlerProduct.Cache
{
    class RunnerExportHtml
    {
        Queue<long> lst = new Queue<long>();
        public void Start()
        {
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
            List<long> lstCOmpanyDownloaded = productAdapter.GetCOmpanyDownloadedHTML();
            foreach (long companyID in productAdapter.GetAllCompanyIdCrawler())
            {
                if (!lstCOmpanyDownloaded.Contains(companyID))
                    lst.Enqueue(companyID);
            }
            int MaxThread = 100;
            for (int i = 0; i < MaxThread; i++)
            {
                int jThread = i;
                Task.Factory.StartNew(() =>
                {
                    WorkerExportHtml worker = new WorkerExportHtml(jThread);
                    worker.eventGetCompanyID += new WorkerExportHtml.GetCompanyId(GetCompanyCrawler);
                    worker.eventProcessHtml += new WorkerExportHtml.DelegateProcessHtml(SaveHtml);
                    worker.eventWhenFinish += new WorkerExportHtml.DelegateWhenFinish(EventWhenFinsih);
                    worker.Start();
                });
            }
        }

        private void EventWhenFinsih()
        {
            PushMSS(false);
        }

        public void Stop ( )
        {
            PushMSS(false);
        }

        private void SaveHtml(long companyID, long productID, string html, string name, string detailUrl)
        {
            int iCount = 0;
            try
            {
                lock (lstData)
                {
                    MssDescription mss = new MssDescription()
                    {
                        Html = html,
                        Name = name,
                        Product_item_id = productID,
                        Product_item_name = name,
                        Url = detailUrl
                    };
                    lstData.Add(mss);
                    PushMSS(true);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                iCount++;
                if (iCount++ > 2) return;
            }
        }

        List<MssDescription> lstData = new List<MssDescription>();
        public void PushMSS(bool CheckTotalMss = true)
        {

            if (!CheckTotalMss || lstData.Count > 1000)
            {
                var options = new Misakai.Kafka.KafkaOptions(new Uri("http://172.22.1.115:9092"), new Uri("http://172.22.1.111:9092"));
                var router = new Misakai.Kafka.BrokerRouter(options);
                var client = new Misakai.Kafka.Producer(router);
                foreach (var mss in lstData)
                {
                    client.SendMessageAsync("product_item_crawl", new Misakai.Kafka.Message[] {
                           new Misakai.Kafka.Message(  mss.GetJSON()) }, 1);
                }
                client.Dispose();
                router.Dispose();
                lstData.Clear();
            }
        }
        private long GetCompanyCrawler()
        {
            lock (lst)
            {
                log.Info("Queue:" + lst.Count);
                if (lst.Count > 0) return lst.Dequeue();
                else return 0;
            }
        }
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(RunnerExportHtml));
        private Misakai.Kafka.KafkaOptions options;
        private Misakai.Kafka.BrokerRouter router;
        private Misakai.Kafka.Producer client;
    }
}
