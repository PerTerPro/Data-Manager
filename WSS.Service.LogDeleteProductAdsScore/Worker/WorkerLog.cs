using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Service.LogDeleteProductAdsScore.Entity;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WSS.Service.LogDeleteProductAdsScore.Worker
{
    public class WorkerLog : QueueingConsumer
    {
        private string _connectionString;
        public WorkerLog()
            : base(RabbitMQManager.GetRabbitMQServer("rabbitMqCrlProperties"), "Product.AdsScore.Deleted", false)
        {
            _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            var ProductAds = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductAdsScore>(Encoding.UTF8.GetString(message.Body));
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute("Insert into Product_AdsScore_Deleted (ProductId, CompanyId, Keyword) values (@ProductId, @CompanyId, @Keyword)",
                    new
                    {
                        ProductId = ProductAds.ProductId,
                        CompanyId = ProductAds.CompanyId,
                        Keyword = ProductAds.Keyword
                    });
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }

        public override void Init()
        {

        }
    }
}
