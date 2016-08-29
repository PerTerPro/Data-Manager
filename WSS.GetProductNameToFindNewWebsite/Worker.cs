using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Newtonsoft.Json;
using QT.Entities.Data;
using System.Data;
using System.Data.SqlClient;

namespace WSS.GetProductNameToFindNewWebsite
{
    public class Worker : QueueingConsumer
    {
        SqlDb sqldb = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        string ProductName;
        long productID;
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Worker));
        public Worker(RabbitMQServer rabbitmqServer, string queueName, bool autoAck)
            : base(rabbitmqServer, queueName, autoAck)
        {

        }
        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            try
            {
                MsProduct ms = JsonConvert.DeserializeObject<MsProduct>(System.Text.Encoding.UTF8.GetString(message.Body));
                ProductName = ms.ProductItemName;
                productID = ms.ProductItemId;
                sqldb.RunQuery("if not exists (select ID from KeywordFindNewWebsite where ID = @ID) begin insert into KeywordFindNewWebsite (ID,Keyword) Values (@ID,@Keyword) end", CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@ID",productID,SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("@Keyword",ProductName,SqlDbType.NVarChar)
                });
                log.InfoFormat("Inserted {0}: {1}",productID,ProductName);
                this.GetChannel().BasicAck(message.DeliveryTag, true);
            }
            catch (Exception ex01)
            {
                log.Error(ex01);
            }
            
        }

        public override void Init()
        {

        }
    }
}
