using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using QT.Entities.Data;
using System.Data.SqlClient;
using System.Data;
using ProtoBuf;
using Newtonsoft.Json;
using System.IO;

namespace WSS.GetKeywordFromRabbitMQ
{
    class Program
    {
        
        Worker worker = null;
        
        SqlDb sqldb = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        int KeywordID = 0;
        string Keyword = "";
        int count = 1;
        
        static void Main(string[] args)
        {
            Consumer consumer = null;
            RabbitMQServer rabbitMQServer = null;
            string jobNameKeyword = "product_an_item_result";
            string rabbitMQServerName = "rabbitMQ109";
            rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
            consumer = new GetMessageFromRabbit(rabbitMQServer, jobNameKeyword, false);
            consumer.StartConsume();
        }

    }
}
