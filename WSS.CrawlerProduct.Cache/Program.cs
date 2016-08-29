using QT.Entities;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlerProduct.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QT.Entities.CrawlerProduct.Cache;
using QT.Entities.Data;

namespace WSS.CrawlerProduct.Cache
{
    class Program
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            while (true)
            {
                RunApp();
            }
        }

        private static void RunApp()
        {
            Server.ConnectionString = @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
            Server.LogConnectionString = @"Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
            Server.ConnectionStringCrawler = @"Data Source=172.22.30.82,1452;Initial Catalog=QTCrawler;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
            Console.WriteLine("1- Cache last time crawler product");
            Console.WriteLine("2- Cache company info");
            Console.WriteLine("3- Reset cache product info");
            Console.WriteLine("4- Cache productID in Product");
            Console.WriteLine("5- Delete all product UnValid");
            Console.WriteLine("6- Sync company need crawler");
            Console.WriteLine("7- Reset cache duplicate");
            Console.WriteLine("8- Delete all unvalid product in db");
            Console.WriteLine("9- Reset all product cache of all company");
            Console.WriteLine("10- Reset all product cache of company by domain");
            Console.WriteLine("11- Reset colum Change and Duplicate");
            Console.WriteLine("12- Export description");
            Console.WriteLine("13- Check status web");
            Console.WriteLine("14- Export Html To Kafka Mr Quang");
            Console.WriteLine("15- Check bizweb source");
            Console.Write("Choose:");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        ManagerCacheLastTime();
                    } break;
                case 2:
                    {
                        ResetAllCopmanyInfo();
                    } break;
                case 3:
                    {
                        ResetCacheProductInfo();
                    } break;
                case 5:
                    {
                        DeleteUnvalidProductCrawler();
                    } break;
                case 6:
                    {
                        SyncCompanyCrawler();
                    } break;
                case 7:
                    {
                        ResetCacheDuplicate();
                    } break;
                case 8:
                    {
                        DeleteAllUnvalidProduct();
                    } break;
                case 9:
                    {
                        log.Info("Not support");
                        //ResetAllCacheProduct();
                    } break;
                case 10:
                    {
                        ResetCacheProduct();
                    } break;

                case 11:
                    {
                        ResesCacheProduct();
                    } break;

                case 12:
                    {
                        ExportDescription();
                    } break;
                case 13:
                    {
                        TestHtml();
                    } break;
                case 14:
                    {
                        ExportHtmlDescription();
                    } break;
                case 15:
                    {
                        CacheIsBizwebsource();
                    }break;
            }
        }

        private static void CacheIsBizwebsource()
        {
            List<long> lstCompanyBizweb = new List<long>();
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            List<long> lstCompanyCheckBizweb = productAdapter.GetCompanyIdsCheckBizweb();
            Queue<long> queueCompany = new Queue<long>();
            foreach(long companyID in lstCompanyCheckBizweb)
            {
                queueCompany.Enqueue(companyID);
            }
            int numberThread = 10;
            for (int i = 0; i < numberThread; i++)
            {
                Task.Factory.StartNew(() =>
                    {
                        int countCompany = 0;
                        int iThread = i;
                        while (true)
                        {
                            countCompany++;
                            long companyID = 0;
                            lock (queueCompany)
                            {
                                if (queueCompany.Count > 0) companyID = queueCompany.Dequeue();
                            }
                            if (companyID > 0)
                            {
                                string website = QT.Entities.Common.GetWebsiteFromUrl((new Company(companyID).Website)) + @"/admin";
                                string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(website, 45, 2);
                                html = html.Replace("<form", "<div");
                                html = html.Replace("</form", "</div");
                                string xpathTest = "//div[@class='login-logo text-center']//img";
                                GABIZ.Base.HtmlAgilityPack.HtmlDocument document = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                                document.LoadHtml(html);
                                var nodeCheck = document.DocumentNode.SelectSingleNode(xpathTest);
                                if (nodeCheck != null)
                                {
                                    if ((nodeCheck.Attributes.Contains("src") && nodeCheck.Attributes["src"].Value.Contains("bizweb")) ||
                                        (nodeCheck.Attributes.Contains("alt") && nodeCheck.Attributes["alt"].Value.Contains("bizweb")))
                                    {
                                        lstCompanyBizweb.Add(companyID);
                                        log.Info(string.Format("Bizweb companys:{0}", lstCompanyBizweb.Count));
                                    }
                                }
                                log.Info(string.Format("Thread {0} cCompany {1} Company {2}", iThread, countCompany, companyID));
                            }
                            else
                            {
                                log.Info("End check in thread");
                                productAdapter.UpdateSourceWebType(lstCompanyCheckBizweb, 1);
                                break;
                            }
                        }
                        return;
                    });
            }
            
            return;
        }

        private static void ExportHtmlDescription()
        {
            RunnerExportHtml run = new RunnerExportHtml();
            run.Start();
            while (Console.ReadLine().Trim() != "y") { };
            run.Stop();
        }

        private static void TestHtml()
        {
            for (int i = 0; i < 50; i++)
            {
                Task.Factory.StartNew(() => RunTestHtml());
            }
        }

        private static void RunTestHtml()
        {
            string g = Guid.NewGuid().ToString();
            string url = @"http://noithatnewlife.com/sofa-g-cp82.html";
            for (int i = 0; i < 1000; i++)
            {
                WebExceptionStatus webExp = new WebExceptionStatus();
                string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2, out webExp);
                log.Info(g + ":" + i.ToString() + webExp.ToString());
            }
        }

        private static void ExportDescription()
        {
            int countCompany = 0;
            StreamWriter outfile = new StreamWriter("ShortDescription.txt");
            List<string> lst = new List<string>();
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
            List<long> companyIds = productAdapter.GetAllCompanyIdSystem();
            foreach (long companyID in companyIds)
            {
                foreach (DataRow rowInfo in productAdapter.GetDescriptionData(companyID).Rows)
                {
                    if (rowInfo["ShortDescription"] != DBNull.Value)
                    {
                        string data = rowInfo["ShortDescription"].ToString().Trim();
                        if (!string.IsNullOrEmpty(data))
                            outfile.Write(data + "\n:::::\n");
                    }
                }
                log.Info(string.Format("Success compay {0}/{1}", countCompany++, companyIds.Count));
            }
            outfile.Close();
            log.Info("OK");
        }

        private static void ResesCacheProduct()
        {
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
            Console.WriteLine("1- Reset all Companies)");
            Console.WriteLine("2- Reset for Company");
            Console.Write("Input choose:");
            int i = Convert.ToInt32(Console.ReadLine());

            switch (i)
            {
                case 1:
                    {
                        int countProduct = 0;
                        var lstCompany = productAdapter.GetAllCompanyIdCrawler();
                        foreach (var companyID in lstCompany)
                        {
                            ResetCacheProduct(companyID);
                            log.Info(string.Format("Complete Company: {0} {1}/{2}", companyID, countProduct++,lstCompany.Count));
                        }
                        log.Info("Complete all company");
                    } break;
                case 2:
                    {
                        Console.Write("Input domain:");
                        string strDomain = Console.ReadLine().Trim();
                        long companyID = productAdapter.GetCompanyIdByDomain(strDomain);
                        ResetCacheProduct(companyID);
                        log.Info(string.Format("Complete Company: {0}", companyID));
                    } break;

            } 
        }

        private static void ResetCacheProduct(long companyID)
        {
            CacheProductHash cashProductHash = CacheProductHash.Instance();
            RedisLastUpdateProduct cacheLastUpdateProduct = RedisLastUpdateProduct.Instance();
            List<ProductHash> lst = new List<ProductHash>();
            List<long> lstLastUpdate = new List<long>();
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
            Company cmp = new Company(companyID);
            productAdapter.DeleteProductUnvalidOfCOmpany(companyID);
            DataTable tbl = productAdapter.GetProductResetColumnDuplicateAndChange(companyID);
            foreach (DataRow rowProduct in tbl.Rows)
            {
                long ProductID = Common.Obj2Int64(rowProduct["ID"]);
                string Name = rowProduct["Name"].ToString();
                long Price = Common.Obj2Int64(rowProduct["Price"]);
                string ImageUrl = Convert.ToString(rowProduct["ImageUrls"]);
                string DetailUrl = Convert.ToString(rowProduct["DetailUrl"]);
                int InStock = Common.Obj2Int(rowProduct["InStock"]);
                bool Valid = Common.Obj2Bool(rowProduct["Valid"]);
                string shortDescription = Common.CellToString(rowProduct["ShortDescription"], "");
                bool IsDeal = Common.Obj2Bool(rowProduct["IsDeal"]);
                long CategoryID = rowProduct["ClassificationID"] == DBNull.Value ? 0 : Common.Obj2Int64(rowProduct["ClassificationID"]);
                long HashChange = Product.GetHashChangeInfo(InStock, Valid, Price, Name, ImageUrl, CategoryID, shortDescription);
                long HashDuplicate = Product.GetHashCheckDuplicate(cmp.Domain, Price, Name, ImageUrl);
                long HashImage = Product.GetHashImageInfo(ImageUrl);
                lst.Add(new ProductHash()
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
            cashProductHash.SetCacheProductHash(companyID, lst, 100);
            cacheLastUpdateProduct.RemoveAllLstProduct(companyID);
            cacheLastUpdateProduct.UpdateBathLastUpdateProduct(companyID, lstLastUpdate, DateTime.Now.AddDays(-1));
            productAdapter.UpdateCountProductForCompany(companyID, lstLastUpdate.Count, lstLastUpdate.Count);
            lst.Clear();
            lstLastUpdate.Clear();
            
        }

        private static void ResetAllCacheProduct()
        {
            Console.Write("Input sleep:");
            int iSleep = Convert.ToInt32(Console.ReadLine());
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
            RedisCheckDuplicateAdapter redisCheckDuplicate = RedisCheckDuplicateAdapter.Instace();
            RedisLastUpdateProduct redisLastUpdate = RedisLastUpdateProduct.Instance();
            CacheProductInfo cacheProductInfo = new CacheProductInfo(productAdapter.sqlDb);
            int count = 0;
            var companyIDs = productAdapter.GetAllCompanyIdCrawler();
            foreach (long companyID in companyIDs)
            {
                Company cmp = new Company(companyID);
                redisCheckDuplicate.ResetForCompany(companyID, cmp.Domain, productAdapter.GetSqlDb());
                redisLastUpdate.ResetForCompany(companyID, productAdapter.sqlDb);
                cacheProductInfo.ResetForCompany(companyID);
                log.Info(string.Format("Reset cache company {0}/{1}-{2} {3} products", count++, companyIDs.Count, cmp.Domain, cmp.TotalProduct));
                Thread.Sleep(iSleep * 1000);
            }
            Console.WriteLine("Success reset data!");
        }

        private static void ResetCacheProduct()
        {
            Console.Write("Input domain:");
            string strDomain = Console.ReadLine().Trim();
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
            RedisCheckDuplicateAdapter redisCheckDuplicate = RedisCheckDuplicateAdapter.Instace();
            RedisLastUpdateProduct redisLastUpdate = RedisLastUpdateProduct.Instance();
            CacheProductInfo cacheProductInfo = new CacheProductInfo(productAdapter.sqlDb);
            int count = 0;
            var companyID = productAdapter.GetCompanyIDFromDomain(strDomain);
            Company cmp = new Company(companyID);
            redisCheckDuplicate.ResetForCompany(companyID, cmp.Domain, productAdapter.sqlDb);
            redisLastUpdate.ResetForCompany(companyID, productAdapter.sqlDb);
            cacheProductInfo.ResetForCompany(companyID);
            log.Info(string.Format("Reset cache company {0}/{1}-{2} {3} products", count++, companyID, cmp.Domain, cmp.TotalProduct));
            Console.WriteLine("Success reset data!");
        }

        private static void DeleteAllUnvalidProduct()
        {
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
            List<long> lstCompanyCrawler = productAdapter.GetAllCompanyIdCrawler();
            for (int i = 0; i < lstCompanyCrawler.Count; i++)
            {
                productAdapter.DeleteProductUnvalidOfCOmpany(lstCompanyCrawler[i]);
                log.Info(string.Format("Delete unvalid product for company {0}/{1}", i, lstCompanyCrawler.Count - 1));
            }
            log.Info("Delete unvalid product for company");
        }

        private static void ResetCacheDuplicate()
        {
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
            RedisCheckDuplicateAdapter redisCompanyInfo = RedisCheckDuplicateAdapter.Instace();
            List<long> lstCompanyCrawler = productAdapter.GetAllCompanyIdCrawler();
            for (int i = 0; i < lstCompanyCrawler.Count; i++)
            {
                Company comp = new Company(lstCompanyCrawler[i]);
                redisCompanyInfo.ResetForCompany(lstCompanyCrawler[i], comp.Domain, productAdapter.sqlDb);
                log.Info(string.Format("Pushed companyInfo {0}/{1}", i, lstCompanyCrawler.Count - 1));
            }
            log.Info("Success push companyInfo");
        }

        private static void ResetAllCopmanyInfo()
        {
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
            RedisCacheCompanyCrawler redisCompanyInfo = RedisCacheCompanyCrawler.Instance();
            List<long> lstCompanyCrawler = productAdapter.GetAllCompanyIdCrawler();
            for(int i=0;i<lstCompanyCrawler.Count;i++)
            {
                Company comp = new Company(lstCompanyCrawler[i]);
                redisCompanyInfo.SetCompanyInfo(comp.ID, comp.Domain, 12, 12);
                log.Info(string.Format("Pushed companyInfo {0}/{1}", i, lstCompanyCrawler.Count - 1));
            }
            log.Info("Success push companyInfo");
        }

        private static void SyncCompanyCrawler()
        {
            int count = 0;
            RedisCacheCompanyCrawler redisCompany = RedisCacheCompanyCrawler.Instance();
            RedisCompanyWaitCrawler redisCompanyWaitCrawler =RedisCompanyWaitCrawler.Instance();
            RedisLastUpdateProduct redisLstProduct = RedisLastUpdateProduct.Instance();
            CacheProductInfo cacheProductInfo = new CacheProductInfo(new SqlDb(Server.ConnectionString));

            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
            List<long> lstCrawler = productAdapter.GetAllCompanyIdCrawlerReload();

            for (int i = 0; i < lstCrawler.Count; i++)
            {
                redisCompanyWaitCrawler.SetNexReload(lstCrawler[i], -10);

                //long companyID = lstCrawler[i];
                //if (!redisCompanyWaitCrawler.CheckHaveItemReload(companyID))
                //{
                //    count++;
                //    redisCompanyWaitCrawler.SetNexReload(companyID, 1);
                //    Company cmp = new Company(companyID);
                //    redisCompany.SetCompanyInfo(companyID, cmp.Domain, 1, 1);
                //    cacheProductInfo.RefeshCacheProductInfo(companyID);
                //    redisLstProduct.ResetLastUpdateForCompany(companyID, productAdapter.GetListProductIdOfCompany(companyID));
                //}
                log.Info(string.Format("sync company {0} {1}/{2}", count, i, lstCrawler.Count));
            }

            List<long> lstCrawlerFindNew = productAdapter.GetAllCompanyIdCrawlerFindNew();
            for (int i = 0; i < lstCrawler.Count; i++)
            {
                redisCompanyWaitCrawler.SetNexFindNew(lstCrawler[i], -10);
                long companyID = lstCrawler[i];

                //if (!redisCompanyWaitCrawler.CheckHaveItemFindNew(companyID))
                //{
                //    count++;
                //    redisCompanyWaitCrawler.SetNexFindNew(companyID, 1);
                //    Company cmp = new Company(companyID);
                //    redisCompany.SetCompanyInfo(companyID, cmp.Domain, 1, 1);
                //    cacheProductInfo.RefeshCacheProductInfo(companyID);
                //    redisLstProduct.ResetLastUpdateForCompany(companyID, productAdapter.GetListProductIdOfCompany(companyID));
                   
                //}
                log.Info(string.Format("sync company {0} {1}/{2}", count, i, lstCrawler.Count));
            }
            Console.WriteLine("Success sync company crawl!");
        }

        private static void DeleteUnvalidProductCrawler()
        {
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
            int COunt = 0;
            List<long> lst =  productAdapter.GetAllCompanyIdCrawler();
            for (int i=0;i<lst.Count; i++)
            {
                COunt++;
                productAdapter.sqlDb.RunQuery("delete product where company = @company_id and valid = 0 and isnull(IsBlackList,0) = 0",
                    CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                        SqlDb.CreateParamteterSQL("@company_id",lst[i],SqlDbType.BigInt)
                    }, true, 1000);
                log.Info(string.Format("Delete unvalid product for {0}/{1}", i, lst.Count - 1));
            }
        }

        private static void ResetCacheProductInfo()
        {
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
            CacheProductInfo c = new CacheProductInfo(new SqlDb(Server.ConnectionString));
            Console.WriteLine("1- Reset all cache by company (domain)");
            Console.WriteLine("2- Reset all cache");
            Console.WriteLine("3- Reset only 'product_info' all company");
            Console.WriteLine("4- Reset cache ProductInfo by domain");
            Console.Write("Input choose:");
            int i = Convert.ToInt32(Console.ReadLine());

            switch (i)
            {
                case 1:
                    {
                        Console.Write("Input domain:");
                        string strDomain = Console.ReadLine().Trim();
                        c.RefreshAllCacheAllProduct(productAdapter.GetCompanyIDFromDomain(strDomain));
                    } break;
                case 2:
                    {
                        List<long> lstCompany = productAdapter.GetAllCompanyIdCrawler();
                        for (int j = 0; j < lstCompany.Count; j++)
                        {
                            c.RefreshAllCacheAllProduct(lstCompany[j]);
                            log.Info(string.Format("Update company {0}/{1}", j, lstCompany.Count - 1));
                        }
                    } break;
                case 3:
                    {
                        List<long> lstCompany = productAdapter.GetAllCompanyIdCrawler();
                        for (int j = 0; j < lstCompany.Count; j++)
                        {
                            c.ResetAllCacheProductInfo(lstCompany[j]);
                            log.Info(string.Format("Update company {0}/{1}", j, lstCompany.Count - 1));
                        }
                    } break;
                case 4:
                    {
                        Console.Write("Input domain:");
                        string strDomain = Console.ReadLine().Trim();
                        c.ResetForCompany(productAdapter.GetCompanyIDFromDomain(strDomain));
                    } break;
            }
        }
        

        private static void ManagerCacheLastTime()
        {

            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
            RedisLastUpdateProduct redisLastUpdate = RedisLastUpdateProduct.Instance();
            Console.WriteLine("1- Reset cache by company (domain)");
            Console.WriteLine("2- Cache for AllCompany");
            Console.Write("Input choose:");
            int i = Convert.ToInt32(Console.ReadLine());
            switch(i)
            {
                case 1:
                    {
                        
                        Console.Write("Input domain you need reset cache:");
                        string strDomain = Console.ReadLine().Trim();
                        long CompanyID = productAdapter.GetCompanyIDFromDomain(strDomain);
                        redisLastUpdate.RemoveAllLstProduct(CompanyID);
                        DataTable tbl = productAdapter.sqlDb.GetTblData("select id from product where company = @CompanyID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                            SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt) });
                        List<long> productIDs = new List<long>();
                        foreach(DataRow rowInfo in tbl.Rows) productIDs.Add(Convert.ToInt64(rowInfo["id"]));
                        redisLastUpdate.UpdateBathLastUpdateProduct(CompanyID, productIDs, new DateTime(1900, 1, 1, 0, 0, 0));
                        Console.WriteLine("Reseted all product LastUpdate in cache");
                    }break;
                case 2:
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
                            redisLastUpdate.UpdateBathLastUpdateProduct(CompanyID, productIDs, new DateTime(1990, 1, 1, 0, 0, 0));
                            log.Info(string.Format("Reseted all products for company {0}/{1} LastUpdate in cache", Count, companyCrawelrs.Count));
                        }
                    }break;
            }
        }
    }
}
