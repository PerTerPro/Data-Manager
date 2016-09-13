using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.IndividualCategoryWebsites
{
    public static class ConfigRabbitMqIndividualCategoryWebsites
    {
        public static string RabbitMqServerName = "rabbitMQ177";
        public static string ExchangeIndividual = "ExchangeIndividual";
        //Đưa product lên service a quang
        public static string QueueProduct = "IndividualWebsites.Product";
        public static string RoutingKeyProduct = "IndividualWebsites.Product";
        //Nhận product từ service của a quang để xử lý
        public static string QueueRootProductAnalyzed = "IndividualWebsites.RootProductAnalyzed";
        public static string RoutingKeyRootProductAnalyzed = "IndividualWebsites.RootProductAnalyzed";
    }
}
