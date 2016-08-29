using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace WSS.GetKeywordFromRabbitMQ
{
    public class GetMessageFromRabbit : QueueingConsumer
    {
        SqlDb sqldb = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        int KeywordID = 0;
        string Keyword = "";
        int count = 1;
        public GetMessageFromRabbit(RabbitMQServer rabbitmqServer, string queueName, bool autoAck) : base (rabbitmqServer,queueName,autoAck)
        {

        }
        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            MsProduct ms = JsonConvert.DeserializeObject<MsProduct>(message.Body.ToString());
            Keyword = ms.ProductName;
            KeywordID = QT.Entities.Common.GetID_Keywords(Keyword);
            sqldb.RunQuery("if not exists (select ID from KeywordFindNewWebsite where ID = @ID) begin insert into KeywordFindNewWebsite (ID,Keyword) Values (@ID,@Keyword) end", CommandType.Text, new SqlParameter[]{
                                    SqlDb.CreateParamteterSQL("@ID",KeywordID,SqlDbType.Int),
                                    SqlDb.CreateParamteterSQL("@Keyword",Keyword,SqlDbType.NVarChar)
                                });
            Console.WriteLine(string.Format("Inserted: {0}", count));
            count++;
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }

        public override void Init()
        {

        }
    }
}
