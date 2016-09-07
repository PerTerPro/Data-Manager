using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.IndividualCategoryWebsites
{
    public class ConfigRabbitMqIndividualCategoryWebsites
    {
        public static string RabbitMqServerName = "rabbitMQ177";
        public static string ExchangeIndividual = "ExchangeIndividual";
        public static string QueueIndividual = "IndividualWebsites.RootProduct";
        public static string RoutingKeyIndividual = "IndividualWebsites.RootProduct";
    }
}
