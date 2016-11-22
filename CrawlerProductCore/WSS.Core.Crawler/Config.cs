using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;

namespace WSS.Core.Crawler
{
    public class ConfigCrawler : ConfigRun
    {
        public static string ConnectProduct =
            @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
        public static string ConnectLog =
            @"Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
        public static string ConnectionCrawler =
            @"Data Source=172.22.30.82,1452;Initial Catalog=QTCrawler;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
        public static string RabbitMqChangeDesciption = "rabbitMQ177";
        public static string RabbitMqLogQueueChangeProduct = "rabbitMQ177";

     

        public static string QueueAddClassification = "CrawlerProduct.Classification";
      
        public static string ServerMqChangeProduct = "rabbitMQ177";
        
        public static string ExchangeErorrCrawler = "CrawlerProduct";
        public static string RoutingKeyErrorCrawler = "CrawlerProduct.Error.#";

        public static string ExchangeChangeProduct = "CrawlerProduct";
        public static string RoutingkeyChangeProduct = "CrawlerProduct.ChangeProduct.#";

        public static string ExchangeCompanyFindNew = "CrawlerProduct";
        public static string RoutingkeyCompanyFindNew = "CrawlerProduct.CompanyWaitFindNew.#";

        public static string ExchangeCompanyReload = "CrawlerProduct";
        public static string RoutingkeyCompanyReload = "CrawlerProduct.CompanyWaitReload.#";
        public static string ExchangeVisitedLinkFindNew = "CrawlerProduct";
        public static string RoutingKeyVisitedLinkFindNew = "CrawlerProduct.VisitedLinkFindNew.#";
        public static string QueueCompanyReload = "CrawlerProduct.CompanyWaitCrawlerReload";
        public static string QueueCompanyFindnew = "CrawlerProduct.CompanyWaitCrawlerFindNew";

        public static string QueueVisitedLinkFindNewToCassandra = "CrawlerProduct.VisitedLinkFindNew.ToCassandra";

        public static string QueueProductChangeToSql = "CrawlerProduct.ChangeProduct.ToSql";
        public static string QueueProductChangeToCache = "CrawlerProduct.ChangeProduct.ToCache";
        public static string QueueProductChangetoCassandra = "CrawlerProduct.ChangeProduct.ToCassandra";

        public static string QueueHistoryToSolr = "CrawlerProduct.HistoryToSolr";
        public static string QueueChangeImageGroup = "UpdateImageBatch";
        public static string QueueChangeImageRoutingKey = "UpdateProduct.ChangeImageProduct";
        public static string QueueEndSessionToSql = "CrawlerProduct.EndSession";
        public static string ConnectionCrawlerQueue =
            @"Data Source=192.168.100.178;Initial Catalog=QTCrawler;Persist Security Info=True;User ID=sa;Password=123456a@;connection timeout=200";
        public static string ExchangeSessionRunning = "SessionRunning";
        public static string RoutingkeySessionRunning = "SessionRunning.#";
        public static string QueueUpdateSessionRunning = "SessionRunning.UpdateRunning";

     

        public static string QueueResetDuplicate = "CrawlerProduct.Cache.ResetDuplicate";
        public static string ExchangeResetDuplicate = "CrawlerProduct";
        public static string RoutingkeyResetDuplicate = "CrawlerProduct.Cache.ResetDuplicate.#";

        public static string QueueDuplicateToCache = "CrawlerProduct.DuplicateProduct.ToCache";
        public static string ExchangeDuplicateProductToCache = "CrawlerProduct";
        public static string RoutingKeyDuplicateProductToCache = "CrawlerProduct.DuplicateProduct.#";

        public static string QueueVisitedLinkFindNewToSolr = "CrawlerProduct.VisitedLinkFindNew.ToSolr";

        public static string ExchangeEndSession = "CrawlerProduct";
        public static string RoutingEndSession = "CrawlerProduct.EndSession.#";
        public static string QueueErrorCrawler = "ErrorWhenCrawler";

        public static string RoutingkeyChangeDesc = "CrawlerProduct.ChangeDescription";
        public static string ExchangeChangeDesc = "CrawlerProduct";
        public static string QueueChangeDesc = "CrawlerProduct.ChangeDescription";
        public static string QueueTrackRunning = "SeesionRunning.TrackRunning";

        public static string QueueResetCacheProduct = "CrawlerProduct.CacheProduct.CompanyWaitReset";


        public static string ExchangeNoValidTotalProduct = "Notifycation";
        public static string RoutingKeyNoValidTotalProduct = "Notifycation.Warning.Company.NoValidTotalProduct";
        public static string QueueWaitCheckNotify = "Notifycation.WaitCheckNotify";

        public static string QueueLogAddProduct = "CrawlerProduct.LogAddProduct.ToSql";
    }
}
