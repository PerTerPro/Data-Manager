﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QT.Entities.CrawlerProduct;
using QT.Moduls.CrawlerProduct.Cache;
using StackExchange.Redis;
using Websosanh.Core.Drivers.Redis;

namespace ImboForm
{
    public class RedisImage
    {
        private static RedisImage _ins = null;
        public static RedisImage GetIns()
        {
            return (_ins == null) ? _ins = new RedisImage() : _ins;
        }

        private log4net.ILog log = log4net.LogManager.GetLogger(typeof(RedisLastUpdateProduct));
        private RedisServer redisServer;
        IDatabase database = null;
        static RedisLastUpdateProduct _objIns = null;
        private RedisImage()
        {
            Init();
        }

        public void SetUpdated(long productId)
        {
            this.database.SetAdd(this.KeyImbo, productId);
        }

     
        public RedisKey KeyImbo = "imbo_trans";
        private HashSet<long> hs;

        public void Init()
        {
            while (database == null)
            {
                try
                {
                    redisServer = RedisManager.GetRedisServer("RedisImbo");
                    database = redisServer.GetDatabase(0);

                 

                 

                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void Add(long productId)
        {
            this.database.SetAdd(this.KeyImbo, productId);
        }

       

        private bool CheckHave(long productId)
        {
            return hs.Contains(productId);
        }

        internal bool Contain(long productId)
        {
            return this.database.SetContains(this.KeyImbo, productId);
        }
    }
}