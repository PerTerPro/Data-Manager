using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.GetProductNameToFindNewWebsite
{
    public class Program
    {
        RabbitMQServer rabbitMQServer = null;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Process();
        }


        public void Process()
        {
            string rabbitMQServerName = "rabbitMQ109";
            rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
            Worker worker = new Worker(rabbitMQServer, "product_an_item_result", false);
            worker.StartConsume();
        }
    }
}
