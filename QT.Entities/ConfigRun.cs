using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities
{
    public class ConfigRun
    {
        public static string KeyRabbitMqProduct = "rabbitMQ177";

        public static string KeyRabbitMqCrawler = "RabbitMqCrawlerProduct";
        public static string ExchangeChangePrice = "UpdatedProduct";
        public static string RottingChangePrice = "UpdatedProduct.ChangePrice.#";
        public static string QueueChangeDescription = "UpdateProduct.ChangeDesciption";
        public static string KeyRedisCrawlerProduct = "redisCacheCompany";
        public static string QueueUpdateCompanyInfoToWeb  = "UpdateCompany.ToWeb";
        public static string SolrHistoryCrwaler = @"http://192.168.100.48:8983/solr/history_product";
        public static string SolrLinkFindNew = @"http://192.168.100.48:8983/solr/link_find_new";

        public static int IndexRedisDbHashDesciption = 3;
        public static int IndexRedisDbProductHash = 15;
        public static int IndexRedisDbTrackDeleteProduct = 1;
        public static string KeySqlProduct = "ProductConnectionString";
        public static string QueueUpdateAlexa = "UpdateAlexaCompany";
        public static string QueueUpdateAlexaFullInfo;
    }
}
