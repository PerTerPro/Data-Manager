using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Moduls.CrawlerProduct.Cache;
using NUnit.Framework;
using QT.Entities;
using QT.Entities.Data;

namespace QT.Moduls.CrawlerProduct.Cache.Tests
{
    [TestFixture()]
    public class CacheProductHashTests
    {
        [Test()]
        public void GetAllProductHashTest()
        {
            CacheProductHash cacheProductHash = CacheProductHash.Instance();
            var products = cacheProductHash.GetAllProductHash(2365377961928198678);
        }

        [Test()]
        public void GetAllProductHashTest1()
        {
            Server.ConnectionString = @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
            ProductAdapter pa = new ProductAdapter(new SqlDb(Server.ConnectionString));
            CacheProductHash cacheProductHash = CacheProductHash.Instance();
            List<long> lst = new List<long>();
            List<long> x = pa.GetAllProductIDsByCompany(3722972174058063651).ToList();
            var products = cacheProductHash.GetAllProductHash(3722972174058063651, x);
            Assert.Greater(products.Count, 0);
        }

        [Test()]
        public void GetAllProductHashTest2()
        {
            CacheProductHash.Instance().GetAllProductHash(4811496168179482404);
        }
    }
}
