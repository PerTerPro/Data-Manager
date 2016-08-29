using log4net;
using QT.Entities;
using StackExchange.Redis;
using System;
using System.Threading;
using Websosanh.Core.Drivers.Redis;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.Redis;
using System.Data;
using QT.Entities.Data;

namespace QT.Moduls.CrawlerProduct.Cache
{
    public class RedisCheckDuplicateAdapter
    {
        RedisServer redisServer = null;
        ILog log = log4net.LogManager.GetLogger(typeof(RedisCheckDuplicateAdapter));
        IDatabase database = null;

        private RedisCheckDuplicateAdapter()
        {
            redisServer = RedisManager.GetRedisServer("redisCacheCrawlerDuplicate");
            database = redisServer.GetDatabase(4);
        }

        public RedisCheckDuplicateAdapter(string server)
        {
            redisServer = RedisManager.GetRedisServer(server);
            database = redisServer.GetDatabase(4);
        }



        public void SetCheckDuplicate(Product product)
        {
            SetCheckDuplicate(product.IDCongTy, product.ID, product.Domain, product.Price, product.Name, product.DetailUrl, product.Valid);
        }

        public void SetCheckDuplicate(long IDCongTy, long productID, string Domain, long Price, string Name, string ImageUrl, bool Valid)
        {
            while (true)
            {
                try
                {
                    if (Valid)
                    {
                        database.HashSet("cmp_dump_prd:" + IDCongTy.ToString(), Product.GetHashDuplicate(Domain, Price, Name, ImageUrl), productID.ToString());
                    }
                    else
                    {
                        long p = Product.GetHashDuplicate(Domain, Price, Name, ImageUrl);
                        if (GetProductIDOfHash(IDCongTy, p) == productID)
                            database.HashSet("cmp_dump_prd:" + IDCongTy.ToString(), p, "0");
                    }
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void RemoveDuplicate(long companyID, List<long> hashDuplicate)
        {
            if (hashDuplicate.Count == 0) return;
            List<RedisValue> lstRedisValue = new List<StackExchange.Redis.RedisValue>();
            foreach (var item in hashDuplicate) lstRedisValue.Add(item);
            while (true)
            {
                try
                {
                    RedisValue redisValue = database.HashDelete("cmp_dump_prd:" + companyID, lstRedisValue.ToArray());
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public long GetProductIDOfHash(long CompanyID, long HashDumplicateProduct)
        {
            while (true)
            {
                try
                {
                    RedisValue redisValue = database.HashGet("cmp_dump_prd:" + CompanyID.ToString(), HashDumplicateProduct);
                    return redisValue.HasValue == false ? 0 : Convert.ToInt64(redisValue);
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public bool CheckExistKey(long companyID)
        {
            while (true)
            {
                try
                {
                    return database.KeyExists("cmp_dump_prd:" + companyID.ToString());
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        static RedisCheckDuplicateAdapter _redisCcheDuplicate = null;
        private string server;
        public static RedisCheckDuplicateAdapter Instace()
        {
            return (_redisCcheDuplicate == null) ? _redisCcheDuplicate = new RedisCheckDuplicateAdapter() : _redisCcheDuplicate;
        }

        public void ResetForCompany(long companyID, string Domain, Entities.Data.SqlDb sqlDb)
        {
            DataTable proTable = sqlDb.GetTblData(@"Select ID, Instock, Valid, Price, Name, IsNews, ImageUrls, IsDeal, ClassificationID
                                                    From Product Where Company = @CompanyID and Valid = 1", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                                                    SqlDb.CreateParamteterSQL("CompanyID",companyID,SqlDbType.BigInt)});
            this.RemoveDuplicate(companyID);
            if (proTable != null && proTable.Rows.Count > 0)
            {
                for (int j = 0; j < proTable.Rows.Count; j++)
                {
                    long ProductID = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["ID"].ToString());
                    int InStock = QT.Entities.Common.Obj2Int(proTable.Rows[j]["InStock"].ToString());
                    bool Valid = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["Valid"].ToString());
                    long Price = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["Price"].ToString());
                    string Name = QT.Entities.Common.Obj2String(proTable.Rows[j]["Name"].ToString());
                    bool IsNew = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["IsNews"]);
                    string ImageUrl = QT.Entities.Common.Obj2String(proTable.Rows[j]["ImageUrls"]);
                    bool IsDeal = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["IsDeal"].ToString());
                    long CategoryID = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["ClassificationID"].ToString());
                    SetCheckDuplicate(companyID, ProductID, Domain, Price, Name, ImageUrl, Valid);
                }
            }
        }

        private void RemoveDuplicate(long companyID)
        {
            try
            {
                this.database.KeyDelete("cmp_dump_prd:" + companyID.ToString());
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
        }

        public bool CheckHaveDuplicate()
        {
            throw new System.NotImplementedException();
        }

       
    }
}