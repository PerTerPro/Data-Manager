using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlerProduct.Cache;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.ResetColumnChangeAndDuplicate
{
    public class Runner
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Runner));
        DateTime NextRun = new DateTime(1990, 1, 1);
        private  int MAX_HOUR_LOOP = 24;
        private  int HOUR_RUN = 14;


        public Runner ()
        {
            MAX_HOUR_LOOP = Convert.ToInt32(ConfigurationManager.AppSettings["MAX_HOUR_LOOP"]);
            HOUR_RUN = Convert.ToInt32(ConfigurationManager.AppSettings["HOUR_RUN"]);
            QT.Entities.Server.ConnectionString = @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
            QT.Entities.Server.LogConnectionString = @"Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
            QT.Entities.Server.ConnectionStringCrawler = @"Data Source=172.22.30.82,1452;Initial Catalog=QTCrawler;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
        }

        public void Run(System.Threading.CancellationToken token)
        {
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200"));
            
            log.InfoFormat("Start run at {0}", DateTime.Now.ToString());
            QT.Moduls.CrawlerProduct.Cache.CacheProductHash cashProductHash = QT.Moduls.CrawlerProduct.Cache.CacheProductHash.Instance();
            QT.Moduls.CrawlerProduct.Cache.RedisLastUpdateProduct cacheLastUpdateProduct = QT.Moduls.CrawlerProduct.Cache.RedisLastUpdateProduct.Instance();
             int countProduct = 0;

            try
            {
                List<long> lstFN = productAdapter.GetAllCompanyIdCrawlerFindNew();
                List<long> lstRL = productAdapter.GetAllCompanyIdCrawlerReload();
                RedisCompanyWaitCrawler redisCache = RedisCompanyWaitCrawler.Instance();
                redisCache.SyncCompanyFindNew(lstFN);
                redisCache.SyncCompanyReload(lstRL);
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }

            List<QT.Entities.CrawlerProduct.Cache.ProductHash> lst = new List<QT.Entities.CrawlerProduct.Cache.ProductHash>();
            List<long> lstLastUpdate = new List<long>();
            var lstCompany = productAdapter.GetAllCompanyIdCrawler();
            foreach (var companyID in lstCompany)
            {
                Company cmp = new Company(companyID);
                productAdapter.DeleteProductUnvalidOfCOmpany(companyID);
                DataTable tbl = productAdapter.GetProductResetColumnDuplicateAndChange(companyID);
                foreach (DataRow rowProduct in tbl.Rows)
                {
                    long ProductID = QT.Entities.Common.Obj2Int64(rowProduct["ID"]);
                    long OriginPrice = QT.Entities.Common.Obj2Int64(rowProduct["OriginPrice"]);
                    string Name = rowProduct["Name"].ToString();
                    long Price = QT.Entities.Common.Obj2Int64(rowProduct["Price"]);
                    string ImageUrl = Convert.ToString(rowProduct["ImageUrls"]);
                    string DetailUrl = Convert.ToString(rowProduct["DetailUrl"]);
                    int InStock = QT.Entities.Common.Obj2Int(rowProduct["InStock"]);
                    bool Valid = QT.Entities.Common.Obj2Bool(rowProduct["Valid"]);
                    string shortDescription = QT.Entities.Common.CellToString(rowProduct["ShortDescription"], "");
                    bool IsDeal = QT.Entities.Common.Obj2Bool(rowProduct["IsDeal"]);
                    long CategoryID = rowProduct["ClassificationID"] == DBNull.Value ? 0 : QT.Entities.Common.Obj2Int64(rowProduct["ClassificationID"]);
                    long HashChange = ProductEntity.GetHashChangeInfo(InStock, Valid, Price, Name, ImageUrl, CategoryID, shortDescription, OriginPrice );
                    long HashDuplicate = Product.GetHashDuplicate(cmp.Domain, Price, Name, ImageUrl);
                    long HashImage = Product.GetHashImageInfo(ImageUrl);
                    lst.Add(new QT.Entities.CrawlerProduct.Cache.ProductHash()
                    {
                        HashChange = HashChange,
                        HashDuplicate = HashDuplicate,
                        HashImage = HashImage,
                        Id = ProductID,
                        Price = Price,
                        url = DetailUrl
                    });
                    lstLastUpdate.Add(ProductID);
                }
                cashProductHash.SetCacheProductHash(companyID, lst, 100);cacheLastUpdateProduct.RemoveAllLstProduct(companyID);
                cacheLastUpdateProduct.UpdateBathLastUpdateProduct(companyID, lstLastUpdate, DateTime.Now.AddDays(-1));
                productAdapter.UpdateCountProductForCompany(companyID, lstLastUpdate.Count, lstLastUpdate.Count);
                lst.Clear();
                lstLastUpdate.Clear();
                log.Info(string.Format("Complete Company: {0} {1}/{2}", companyID, countProduct++, lstCompany.Count));
            }
            log.Info("Complete all company");
            NextRun = DateTime.Now.AddHours(MAX_HOUR_LOOP);
            log.InfoFormat("End at {0}", DateTime.Now.ToString());
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
                    token.WaitHandle.WaitOne(60000 * 5);
                }
            }
        }
    }
}
