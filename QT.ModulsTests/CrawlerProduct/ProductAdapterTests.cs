﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using QT.Moduls.CrawlerProduct;
using NUnit.Framework;
using QT.Entities.Data;

namespace QT.Moduls.CrawlerProduct.Tests
{
    [TestFixture()]
    public class ProductAdapterTests
    {
        [Test()]
        public void GetConfigurationHotProductByTest()
        {
            QT.Entities.Server.ConnectionString = "Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
            ProductAdapter pa = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            var conf = pa.GetConfigurationHotProductBy(8220568010056870095);
            Assert.IsNotNull(conf);
        }
    }
}