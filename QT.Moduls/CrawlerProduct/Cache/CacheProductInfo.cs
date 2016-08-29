using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlerProduct.Cache
{
    public class CacheProductInfo
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(CacheProductInfo));
        RedisCacheProductInfo redisProduct = RedisCacheProductInfo.Instance();

        private SqlDb sqlDb;
        public CacheProductInfo(SqlDb sqlDb)
        {
            this.sqlDb = sqlDb;
        }

        public int ReloadChaceForAllCompany(CancellationToken CancellationToken = new  CancellationToken())
        {
            log.Info(string.Format("Started Push For AllCompany"));
            DataTable tblCompany = sqlDb.GetTblData("Select ID,Domain From Company Where Status = 1 And DatafeedType=0");
            int iCount = 0;
            foreach (DataRow rowInfo in tblCompany.Rows)
            {
                iCount++;
                long Company = QT.Entities.Common.Obj2Int64(rowInfo["ID"]);
                string Domain = QT.Entities.Common.Obj2String(rowInfo["Domain"]);
                RedisCacheProductInfo rediscacheProductForCompany = RedisCacheProductInfo.Instance();
                int iProductPush = this.RefreshAllCacheAllProduct(Company);
                log.Info(string.Format("Pushed C {0} {3}/{2} : {1}", Company, iProductPush, tblCompany.Rows.Count, iCount));
                CancellationToken.ThrowIfCancellationRequested();
            }
            log.Info(string.Format("End Push For All {0}", tblCompany.Rows.Count));
            return tblCompany.Rows.Count;
        }

        public int RefreshAllCacheAllProduct(long CompanyID)
        {
            DataTable tblProduct = sqlDb.GetTblData("select Id from Product where company = @CompanyID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)});
            RedisProductIDOfCompany redisProductIDOFCompany = RedisProductIDOfCompany.Instance();
            List<long> lstProduct = new List<long>();
            foreach(DataRow rowProduct in tblProduct.Rows) lstProduct.Add(Convert.ToInt64(rowProduct["Id"]));
            redisProductIDOFCompany.RemoveCompanyCache(CompanyID);
            redisProductIDOFCompany.SetForCompany(CompanyID, lstProduct);
            log.Info(string.Format("Updated redis cache {0} productID of company {1} ", lstProduct.Count, CompanyID));


            DataTable products = sqlDb.GetTblData(@"SELECT  InStock,  ID, ClassificationID, Status, Valid, Price, Name, ImageUrls, IsDeal, IsNews, DetailUrl
                                                    FROM            Product
                                                    WHERE        (Company = @CompanyID)  AND IsNews = 0
                                                    ORDER BY ID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                                                    SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)});

            if (products != null)
            {
                for (int j = 0; j < products.Rows.Count; j++)
                {
                    try
                    {
                        long ProductID = QT.Entities.Common.Obj2Int64(products.Rows[j]["ID"].ToString());
                        int InStock = QT.Entities.Common.Obj2Int(products.Rows[j]["InStock"].ToString());
                        bool Valid = QT.Entities.Common.Obj2Bool(products.Rows[j]["Valid"].ToString());
                        long Price = QT.Entities.Common.Obj2Int64(products.Rows[j]["Price"].ToString());
                        string Name = QT.Entities.Common.Obj2String(products.Rows[j]["Name"].ToString());
                        bool IsNew = QT.Entities.Common.Obj2Bool(products.Rows[j]["IsNews"]);
                        string ImageUrl = products.Rows[j]["ImageUrls"].ToString();
                        bool IsDeal = QT.Entities.Common.Obj2Bool(products.Rows[j]["IsDeal"].ToString());
                        long CategoryID = QT.Entities.Common.Obj2Int64(products.Rows[j]["ClassificationID"].ToString());
                        string url = QT.Entities.Common.Obj2String(products.Rows[j]["DetailUrl"]);
                        
                        
                        if (j % 1000 == 0) log.Info(string.Format("Updated {0} product in redis for company {1}", j, CompanyID));
                    }
                    catch (Exception ex01)
                    {
                        log.Error(ex01);
                    }
                }
            }
            return products == null ? -1 : products.Rows.Count;
        }

        public int ResetForCompany (long CompanyID)
        {
            DataTable products = sqlDb.GetTblData(@"SELECT  InStock,  ID, ClassificationID, Status, Valid, Price, Name, ImageUrls, IsDeal, IsNews, DetailUrl
                                                    FROM            Product
                                                    WHERE        (Company = @CompanyID)
                                                    ORDER BY ID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                                                    SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)});
            if (products != null)
            {
                for (int j = 0; j < products.Rows.Count; j++)
                {
                    try
                    {
                        long ProductID = QT.Entities.Common.Obj2Int64(products.Rows[j]["ID"].ToString());
                        int InStock = QT.Entities.Common.Obj2Int(products.Rows[j]["InStock"].ToString());
                        bool Valid = QT.Entities.Common.Obj2Bool(products.Rows[j]["Valid"].ToString());
                        long Price = QT.Entities.Common.Obj2Int64(products.Rows[j]["Price"].ToString());
                        string Name = QT.Entities.Common.Obj2String(products.Rows[j]["Name"].ToString());
                        bool IsNew = QT.Entities.Common.Obj2Bool(products.Rows[j]["IsNews"]);
                        string ImageUrl = products.Rows[j]["ImageUrls"].ToString();
                        bool IsDeal = QT.Entities.Common.Obj2Bool(products.Rows[j]["IsDeal"].ToString());
                        long CategoryID = QT.Entities.Common.Obj2Int64(products.Rows[j]["ClassificationID"].ToString());
                        string url = QT.Entities.Common.Obj2String(products.Rows[j]["DetailUrl"]);
                       
                    }
                    catch (Exception ex01)
                    {
                        log.Error(ex01);
                    }
                }
            }
            return products == null ? -1 : products.Rows.Count;
        }

        public int ResetAllCacheProductInfo (long CompanyID)
        {
            DataTable products = sqlDb.GetTblData(@"SELECT  InStock,  ID, ClassificationID, Status, Valid, Price, Name, ImageUrls, IsDeal, IsNews, DetailUrl
                                                    FROM            Product
                                                    WHERE        (Company = @CompanyID)  AND IsNews = 0
                                                    ORDER BY ID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                                                    SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)});
            if (products != null)
            {
                for (int j = 0; j < products.Rows.Count; j++)
                {
                    try
                    {
                        long ProductID = QT.Entities.Common.Obj2Int64(products.Rows[j]["ID"].ToString());
                        int InStock = QT.Entities.Common.Obj2Int(products.Rows[j]["InStock"].ToString());
                        bool Valid = QT.Entities.Common.Obj2Bool(products.Rows[j]["Valid"].ToString());
                        long Price = QT.Entities.Common.Obj2Int64(products.Rows[j]["Price"].ToString());
                        string Name = QT.Entities.Common.Obj2String(products.Rows[j]["Name"].ToString());
                        bool IsNew = QT.Entities.Common.Obj2Bool(products.Rows[j]["IsNews"]);
                        string ImageUrl = products.Rows[j]["ImageUrls"].ToString();
                        bool IsDeal = QT.Entities.Common.Obj2Bool(products.Rows[j]["IsDeal"].ToString());
                        long CategoryID = QT.Entities.Common.Obj2Int64(products.Rows[j]["ClassificationID"].ToString());
                        string url = QT.Entities.Common.Obj2String(products.Rows[j]["DetailUrl"]);
                     
                        if (j % 1000 == 0) log.Info(string.Format("Updated {0} product in redis for company {1}", j, CompanyID));
                    }
                    catch (Exception ex01)
                    {
                        log.Error(ex01);
                    }
                }
            }
            return products == null ? -1 : products.Rows.Count;
        }
    }
}
