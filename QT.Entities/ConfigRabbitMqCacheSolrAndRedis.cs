using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities
{
    public class ConfigRabbitMqCacheSolrAndRedis
    {
        public static string ExchangeProduct = "UpdateProduct";
        public static string ExchangeProductRedis = "UpdateProduct.InsertProductToRedis";
        public static string RoutingKeyUpdateSolrAndRedis = "UpdateProduct.ToWeb.#";
        public static string RoutingKeyUpdateRedis = "UpdateProduct.InsertProductToRedis";
        public static string QueueUpdateRedis = "UpdateProduct.InsertProductToRedis";
    }
}
