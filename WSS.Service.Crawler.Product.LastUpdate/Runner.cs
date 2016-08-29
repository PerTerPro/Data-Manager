using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.Crawler.Cache.Product.LastUpdate
{
    public class Runner
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Runner));
        DateTime NextRun = new DateTime(1990, 1, 1);
        private  int MAX_HOUR_LOOP = 24;
        private  int HOUR_RUN = 14;

        ProductAdapter productAdapter = new ProductAdapter(new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200"));
        QT.Moduls.CrawlerProduct.Cache.RedisLastUpdateProduct redisLastUpdate = QT.Moduls.CrawlerProduct.Cache.RedisLastUpdateProduct.Instance();
        public Runner ()
        {
            MAX_HOUR_LOOP = Convert.ToInt32(ConfigurationManager.AppSettings["MAX_HOUR_LOOP"]);
            HOUR_RUN = Convert.ToInt32(ConfigurationManager.AppSettings["HOUR_RUN"]);
        }

        public void Run(System.Threading.CancellationToken token)
        {
            List<long> companyCrawelrs = productAdapter.GetAllCompanyIdCrawler();
            int Count = 0;
            foreach (long CompanyID in companyCrawelrs)
            {
                Count++;
                DataTable tbl = productAdapter.sqlDb.GetTblData("select id from product where company = @CompanyID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                            SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt)
                            });

                List<long> productIDs = new List<long>();
                foreach (DataRow rowInfo in tbl.Rows) productIDs.Add(Convert.ToInt64(rowInfo["id"]));
                redisLastUpdate.RemoveAllLstProduct(CompanyID);
                redisLastUpdate.UpdateBathLastUpdateProduct(CompanyID, productIDs,DateTime.Now);
                log.Info(string.Format("Reseted all products for company {0}/{1} LastUpdate in cache", Count, companyCrawelrs.Count));
            }
        }

        internal void Start(System.Threading.CancellationToken token)
        {
            while(true)
            {
                token.ThrowIfCancellationRequested();
                if (DateTime.Now.Hour == this.HOUR_RUN && NextRun<DateTime.Now)
                {
                    Run(token);
                }
                else
                {
                    log.InfoFormat("Wait {0} h last {1} Minute", HOUR_RUN, (int)(DateTime.Now - NextRun).TotalMinutes);
                    token.WaitHandle.WaitOne(60000);
                }
            }
        }
    }
}
