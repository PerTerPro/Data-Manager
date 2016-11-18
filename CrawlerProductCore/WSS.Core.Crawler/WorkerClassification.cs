using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Util;
using QT.Entities;
using QT.Entities.Data;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Core.Crawler
{
    public class ConsumerAddClassification : QueueingConsumer
    {
        private ILog _log = LogManager.GetLogger(typeof(ConsumerAddClassification));
        readonly SqlDb _sqlDb = new SqlDb(ConfigCrawler.ConnectProduct);
        readonly HashSet<long> hID = new HashSet<long>();



        public ConsumerAddClassification()
            : base(
                RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler),
                ConfigCrawler.QueueAddClassification, false)
        {
            Inthash();
        }

        public ConsumerAddClassification(string queueu)
            : base(
                RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler),
                queueu, false)
        {
            Inthash();
        }

        private void Inthash()
        {
            int page = 0;
            string query = "SELECT Id FROM Classification ORDER BY id OFFSET @Page ROWS FETCH NEXT 100000 ROWS ONLY;";
            DataTable tbl = null;
            do
            {
                tbl = _sqlDb.GetTblData(query, CommandType.Text, new SqlParameter[]
                {
                    SqlDb.CreateParamteterSQL("Page", page*100000, SqlDbType.Int)
                });
                foreach (DataRow var in tbl.Rows)
                {
                    hID.Add(Convert.ToInt64(var["Id"]));
                }
                _log.InfoFormat("Page: {0}", page);
                page++;
            } while (tbl.Rows.Count > 0);
        }

        public override void Init()
        {
            
        }

        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            var pt = ProductEntity.GetFromJson(message.Body);
            if (!hID.Contains(Common.GetIDClassification(pt.GetCategoryString()))){bool bOK = _sqlDb.RunQuery(
                    "insert into Classification (Id, Name, IdCompany) values (@Id, @Name, @IdCompany)",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        SqlDb.CreateParamteterSQL("@Id", pt.IdCategories, SqlDbType.BigInt),
                        SqlDb.CreateParamteterSQL("@Name", pt.IdCategories, SqlDbType.NVarChar),
                        SqlDb.CreateParamteterSQL("@IdCompany", pt.CompanyId, SqlDbType.BigInt),
                    });
                if (bOK) hID.Add(pt.IdCategories);
                _log.InfoFormat("Saved for categor: {0}", Common.ConvertToString(pt.Categories, "->"));
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
