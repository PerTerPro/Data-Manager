using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Datafeed
{
    public class ConfigRabbitMqDatafeed
    {
        public static string RabbitMqServerName = "rabbitMQ177";
        public static string ExchangeProductDatafeed = "UpdateProductBatch";

        public static string RoutingKeyUpdateMerchantDatafeed = "updateDatafeed";
        public static string QueueUpdateMerchantDatafeed = "UpdateMerchantDatafeed";

        public static string RoutingKeyWebPartnerBizweb = "UpdateProduct.Bizweb";
        public static string QueueUpdateWebPartnerBizweb = "UpdateProductWebPartner.Bizweb";

        public static string RoutingKeyUpdateWebPartnerHaravan = "UpdateProduct.Haravan.#";
        public static string QueueUpdateWebPartnerHaravan = "UpdateProductWebPartner.Haravan";

        public static string RoutingKeyUpdateSingleProduct = "UpdateProduct.UpdateSingleProduct.#";
        public static string QueueUpdateSingleProduct = "UpdateProduct.UpdateSingleProduct";

        //Redis error image Database(1)
        public static string KeyRedisCacheProductDatafeed = "redisFPT201";
    }
}
