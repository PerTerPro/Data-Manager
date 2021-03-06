﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;
using WSS.Crl.ProducProperties.Core;
using NUnit.Framework;
using QT.Moduls.CrawlerProduct;

namespace WSS.Crl.ProducProperties.Core.Tests
{
    [TestFixture()]
    public class MongoAdapterTests
    {
        [Test()]
        public void SavePropertiesTest()
        {
            
            PropertyData pd = new PropertyData();
            pd.Category = "TestCategory";
            pd.ProductId = 0;
            pd.Properties.Add("name", "Test");
            MongoAdapter mongoAdapter = MongoAdapter.Instance();
            mongoAdapter.SaveProperties(pd);
            mongoAdapter.DelPropertyData(pd.ProductId);


        }

        [Test()]
        public void SaveHtmlProduct()
        {
            HtmlProduct doc1 = new HtmlProduct()
            {
                Domain = "test.data",
                Html = "testHtm",
                ProductId = 123,
                _id = new ObjectId(MD5.CalculateMD5Hash1("123"))
            };

            MongoAdapter mongoAdapter = MongoAdapter.Instance();
            mongoAdapter.InsertDocument(doc1);
        }

        [Test()]
        public void UpdateCategoryIdTest()
        {
            MongoAdapter mongoAdapter = MongoAdapter.Instance();
            mongoAdapter.UpdateCategoryId();
            Thread.Sleep(100000);
        }

        [Test()]
        public void PardataToSql()
        {
            MongoAdapter mongoAdapter = MongoAdapter.Instance();
            mongoAdapter.UpdateCategoryId();
            Thread.Sleep(100000);
        }
    }
}
