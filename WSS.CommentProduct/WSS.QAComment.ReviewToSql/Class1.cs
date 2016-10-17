using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities.Data;
using WSS.QAComment.Core;
using Websosanh.Core.Drivers.RabbitMQ;
using log4net;
using QT.Entities;
using QT.Moduls;

namespace WSS.QAComment
{
    public class ConsumerReviewToSql : Websosanh.Core.Drivers.RabbitMQ.QueueingConsumer
    {
        int countMss = 0;
        private readonly SqlDb _sqlDb = null;
        private readonly ILog _log = LogManager.GetLogger(typeof(ConsumerReviewToSql));
        private readonly ProducerBasic _producerAfterDownload = null;
        private string _queueAS;public ConsumerReviewToSql(RabbitMQServer rabbitmqServer, string domain)
            : base(rabbitmqServer, "Comment.CommentUser.ToCassandra", false)
        {
            _sqlDb = new SqlDb(Config.ConnectionSQL);
        }

        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            string json = UTF8Encoding.UTF8.GetString(message.Body);
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Comment>>(json);foreach (var commentData in obj)
            {
                string author = commentData.Author ?? "";
                string title = commentData.Title ?? "";
                string conntent = commentData.Content ?? "";

                long hash = Common.CrcProductID(Newtonsoft.Json.JsonConvert.SerializeObject(commentData));
                bool bok = _sqlDb.RunQuery(@"
DELETE FROM Product_Comment Where Id = @ID;
INSERT INTO [dbo].[Product_Comment]
           ([Id]
           ,[Title]
           ,[Content]
           ,[ProductId]
           ,[CompanyId]
           , [Author]
           , DateComment
)
values (@Id, @Title, @Content, @ProductId, @CompanyId, @Author, @DateComment
)
", CommandType.Text,
                    new SqlParameter[]
                    {
                        SqlDb.CreateParamteterSQL("@Id", hash, SqlDbType.BigInt), SqlDb.CreateParamteterSQL("@Title", title, SqlDbType.NVarChar),
                        SqlDb.CreateParamteterSQL("@Content", conntent, SqlDbType.NVarChar), SqlDb.CreateParamteterSQL("@ProductId", commentData.ProductId, SqlDbType.BigInt),
                        SqlDb.CreateParamteterSQL("@CompanyId", commentData.CompanyId, SqlDbType.BigInt), SqlDb.CreateParamteterSQL("@Author", author, SqlDbType.NVarChar),
                         SqlDb.CreateParamteterSQL("@DateComment", commentData.DatePublish, SqlDbType.DateTime),
                    });

                if (!bok)
                {
                    Logger.Error("Can't insert:" + json);
                }
                else
                {
                    Logger.Info(string.Format("Saved mss {0}",countMss++));}
            }

            
            GetChannel().BasicAck(message.DeliveryTag, true);
        }

        public override void Init()
        {
           }
    }
}
