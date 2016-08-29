using log4net;
using QT.Entities.Data;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using Websosanh.Core.Drivers.Redis;
namespace QT.Entities.CrawlerProduct
{

    public class RedisCacheCheckDupNameProduct
    {
        public RedisCacheCheckDupNameProduct (string server)
        {
            database = RedisManager.GetRedisServer(server).GetDatabase(6);
        }

        public RedisCacheCheckDupNameProduct()
        {
          
        }

        public static RedisCacheCheckDupNameProduct Instace()
        {
            return _RedisCacheProductInfoAdapter == null ? _RedisCacheProductInfoAdapter = new RedisCacheCheckDupNameProduct() : _RedisCacheProductInfoAdapter;
        }

        void Connect()
        {
            while (database == null)
            {
                try
                {
                    database = RedisManager.GetRedisServer("redisCacheCrawlerProduct").GetDatabase(6);
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        ILog log = log4net.LogManager.GetLogger(typeof(RedisCacheProductInfo));
        IDatabase database = null;
        static RedisCacheCheckDupNameProduct _RedisCacheProductInfoAdapter;
    }

    public class RedisCacheProductInfo
    {
        ILog log = log4net.LogManager.GetLogger(typeof(RedisCacheProductInfo));
        IDatabase database = null;
        static RedisCacheProductInfo _RedisCacheProductInfoAdapter;
        public CancellationToken CancellationToken;
        private string p;

        public RedisCacheProductInfo()
        {
            Init();
        }



        public void Init()
        {
            database = RedisManager.GetRedisServer("redisCacheCrawlerProduct").GetDatabase(6);
        }



        public static RedisCacheProductInfo Instance()
        {
            return (_RedisCacheProductInfoAdapter == null) ? (_RedisCacheProductInfoAdapter = new RedisCacheProductInfo()) : _RedisCacheProductInfoAdapter;
        }

        void Connect()
        {
            while (database == null)
            {
                try
                {
                    database = RedisManager.GetRedisServer("redisCacheCrawlerProduct").GetDatabase(6);
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void SetProductCache(long ProductID, long CompanyID, long HashChange
            , long HashImage, long Price, string DetailUrl, bool Valid)
        {
            Connect();
            while (true)
            {
                try
                {
                    database.HashSet("product:" + CompanyID + ":" + ProductID
                        , new StackExchange.Redis.HashEntry[] 
                        { 
                            new HashEntry("hash_change", HashChange.ToString()),
                            new HashEntry("hash_image",HashImage.ToString()),
                            new HashEntry("price",Price.ToString()),
                            new HashEntry("detail_url",DetailUrl),
                            new HashEntry("valid",Valid?1:0)
                        });
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(1000);
                }
            }
        }

        public void SetHashCheckChange(long ProductID, long CompanyID, long checHash)
        {
            Connect();
            while (true)
            {
                try
                {
                    database.HashSet("product:" + CompanyID + ":" + ProductID, new StackExchange.Redis.HashEntry[] { new HashEntry("hash_change", checHash.ToString()) });
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public long GetHashImageOfProduct(long ProductID, long companyID)
        {
            Connect();
            while (true)
            {
                try
                {
                    RedisValue redisValue = database.HashGet("product:" + companyID.ToString() + ":" + ProductID.ToString(), "hash_image");
                    return redisValue.HasValue == false ? 0 : Convert.ToInt64(redisValue);
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void SetHashImageOfProduct(long ProductID, long imageHash, long companyID)
        {
            Connect();
            while (true)
            {
                try
                {
                    database.HashSet("product:" + companyID.ToString() + ProductID.ToString(), "hash_image", imageHash);
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void SyncProductInfoToRedis(Product product)
        {
            Connect();
            while (true)
            {
                try
                {
                    database.HashSet("product:" + product.IDCongTy.ToString() + ":" + product.ID.ToString(), new StackExchange.Redis.HashEntry[]{
                                                                            new HashEntry("price",product.Price.ToString()),
                                                                            new HashEntry("valid",(product.Valid)?1:0),
                                                                            new HashEntry("hash_change",product.GetHashChange()),
                                                                            new HashEntry("hash_image",product.GetHashImage())
                    });
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public long GetPriceOfProduct(long CompanyID, long ProductID)
        {
            Connect();
            while (true)
            {
                try
                {
                    RedisValue redisValue = database.HashGet("product:" + CompanyID.ToString() + ":" + ProductID.ToString(), "price");
                    return redisValue.HasValue == false ? 0 : Convert.ToInt64(redisValue);
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public long GetHashChangeOfProduct(long CompanyID, long ProductID)
        {
            Connect();
            while (true)
            {
                try
                {
                    RedisValue redisValue = database.HashGet("product:" + CompanyID.ToString() + ":" + ProductID.ToString(), "hash_change");
                    return redisValue.HasValue == false ? 0 : Convert.ToInt64(redisValue);
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }



        public bool ExistsInCache(long CompanyID, long ProductID)
        {
            Connect();
            while (true)
            {
                try
                {
                    return database.KeyExists("product:" + CompanyID.ToString() + ":" + ProductID.ToString());
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void SynProductInfoNotExit(Product product)
        {
            Connect();
            if (!ExistsInCache(product.IDCongTy, product.ID))
                SyncProductInfoToRedis(product);

        }

        public int GetCountFail(long ProductID, long CompanyID)
        {
            Connect();
            while (true)
            {
                try
                {
                    RedisValue value = database.HashGet("product:" + CompanyID.ToString() + ":" + ProductID.ToString(), "fail");
                    if (!value.HasValue) return 0;
                    else return Convert.ToInt32(value);
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void IncrementCountFail(long ProductID, long CompanyID)
        {
            Connect();
            while (true)
            {
                try
                {
                    long value = database.HashIncrement("product:" + CompanyID.ToString() + ":" + ProductID.ToString(), "fail");
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void ResetCountFail(long ProductID, long CompanyID)
        {
            Connect();
            while (true)
            {
                try
                {
                    database.HashSet("product:" + CompanyID.ToString() + ":" + ProductID.ToString(), "fail", 0);
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void SaveLastChangeProduct(Product _product)
        {
            Connect();
            while (true)
            {
                try
                {
                    database.HashSet("product:" + _product.IDCongTy.ToString() + ":" + _product.ID.ToString(), "last_change", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void DeleteProductCache(long CompanyID, long ProductID)
        {
            Connect();
            while (true)
            {
                try
                {
                    database.HashSet("product:" + CompanyID.ToString() + ":" + ProductID.ToString(), "last_change", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }




        public void IncreateCountIgoned(long ProductID, long CompanyID)
        {
            Connect();
            while (true)
            {
                try
                {
                    long value = database.HashIncrement("product:" + CompanyID.ToString() + ":" + ProductID.ToString(), "igone");
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public int GetIgoned(long ProductID, long CompanyID)
        {
            Connect();
            while (true)
            {
                try
                {
                    RedisValue value = database.HashGet("product:" + CompanyID.ToString() + ":" + ProductID.ToString(), "igone");
                    if (!value.HasValue) return 0;
                    else return Convert.ToInt32(value);
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void ResetCountIgone(long ProductID, long CompanyID)
        {
            Connect();
            while (true)
            {
                try
                {
                    bool ok = database.HashSet("product:" + CompanyID.ToString() + ":" + ProductID.ToString(), "igone", "0");
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void DecrementCountIgone(long ProductID, long CompanyID)
        {
            Connect();
            while (true)
            {
                try
                {
                    long value = database.HashDecrement("product:" + CompanyID.ToString() + ":" + ProductID.ToString(), "fail");
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public Cache.ProductCache GetCacheProduct()
        {
            throw new NotImplementedException();
        }

        

        public void SetUnvalidCache(long productID, long companyID)
        {
            database.HashSet("product:" + companyID.ToString() + ":" + productID.ToString(), new HashEntry[] { 
            new HashEntry("valid","0"),new HashEntry("hash_change","0")
            });
        }

        public void ResetHashChange(long CompanyID, long product)
        {
            database.HashSet("product:" + CompanyID.ToString() + ":" + product.ToString(), new HashEntry[]{
                new HashEntry("hash_change","0")
            });
        }

        public void RemoveProduct(long companyID, System.Collections.Generic.List<long> productIdWaitDeleteGroup)
        {
            List<RedisKey> lst = new List<RedisKey>();
            RedisKey[] arKeyProductDel = new RedisKey[productIdWaitDeleteGroup.Count];
            for (int i=0;i<arKeyProductDel.Length;i++)
            {
                arKeyProductDel[i]="product:" + companyID.ToString() + ":" + productIdWaitDeleteGroup[i].ToString();
            }
            database.KeyDelete(arKeyProductDel);
        }
    }
}