using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities.Data;
using Websosanh.Core.Drivers.RabbitMQ;
using QT.Entities;
using log4net;
using QT.Moduls;
using QT.Moduls.CrawlerProduct;
using System.Threading;
using QT.Moduls.CrawlerAlexa;

namespace WSS.UpdateAlexaData
{
    public class ConsumerUpdateAlexaCompanyInfo : QueueingConsumer
    {
        private ILog _log = LogManager.GetLogger(typeof(ConsumerUpdateAlexaCompanyInfo));
        private readonly ProductAdapter _productAdapter = null;
        private ProducerBasic _producerNoValidTotalProduct = null;
        private readonly SqlDb _sqlDbProduct = null;

        public ConsumerUpdateAlexaCompanyInfo(RabbitMQServer rabbitMQServer, string queueName, string connectionProduct)
            : base(rabbitMQServer, queueName, false)
        {
            _sqlDbProduct = new SqlDb(connectionProduct);
        }


        public override void Init()
        {
        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            Thread.Sleep(4000);

            MssUpdateAlexaCompany mss = Newtonsoft.Json.JsonConvert.DeserializeObject<MssUpdateAlexaCompany>(UTF8Encoding.UTF8.GetString(message.Body));
            var alexa = Common.GetRankAlexaFull(mss.Domain);
            string strQuery =
@"
DELETE FROM Company_Alexa WHERE Id = @Id;
INSERT INTO [dbo].[Company_Alexa]
           ([Id]
           ,[Domain]
           ,[BounceRate]
           ,[BounceRateChange]
           ,[BounceRateChangeTitle]
           ,[DailyPageView]
           ,[DailyPageViewChange]
           ,[DailyPageViewTitle]
           ,[DailyTimeOnSite]
           ,[DailyTimeOnSiteChange]
           ,[DailyTimeOnSiteTitle]
           ,[Contries]
           ,[AlexaRank]
           ,[AlexaRankContries])
     VALUES
           ( @Id
           , @Domain
           , @BounceRate
           , @BounceRateChange
           , @BounceRateChangeTitle
           , @DailyPageView
           , @DailyPageViewChange
           , @DailyPageViewTitle
           , @DailyTimeOnSite
           , @DailyTimeOnSiteChange
           , @DailyTimeOnSiteTitle
           , @Contries
           , @AlexaRank
           , @AlexaRankContries)
";
            bool bOK = this._sqlDbProduct.RunQuery(strQuery, CommandType.Text,
                 new SqlParameter[]
                 {
                     SqlDb.CreateParamteterSQL("@Id", mss.CompanyId, SqlDbType.BigInt ),
                     SqlDb.CreateParamteterSQL("@Domain", mss.Domain, SqlDbType.VarChar),
                     SqlDb.CreateParamteterSQL("@BounceRate", alexa.BounceRate, SqlDbType.VarChar),
                     SqlDb.CreateParamteterSQL("@BounceRateChange", alexa.BounceRateChange, SqlDbType.VarChar),
                     SqlDb.CreateParamteterSQL("@BounceRateChangeTitle", alexa.BounceRateChangeTitle, SqlDbType.VarChar),
                     SqlDb.CreateParamteterSQL("@DailyPageView", alexa.DailyPageView, SqlDbType.VarChar),
                     SqlDb.CreateParamteterSQL("@DailyPageViewChange", alexa.DailyPageViewChange, SqlDbType.VarChar),
                     SqlDb.CreateParamteterSQL("@DailyPageViewTitle", alexa.DailyPageViewTitle, SqlDbType.VarChar),
                     SqlDb.CreateParamteterSQL("@DailyTimeOnSite", alexa.DailyTimeOnSite, SqlDbType.VarChar),
                     SqlDb.CreateParamteterSQL("@DailyTimeOnSiteChange", alexa.DailyTimeOnSiteChange, SqlDbType.VarChar),
                     SqlDb.CreateParamteterSQL("@DailyTimeOnSiteTitle", alexa.DailyTimeOnSiteTitle, SqlDbType.VarChar),
                     SqlDb.CreateParamteterSQL("@Contries", alexa.Contries, SqlDbType.VarChar),
                     SqlDb.CreateParamteterSQL("@AlexaRank", alexa.AlexaRank, SqlDbType.Int),
                     SqlDb.CreateParamteterSQL("@AlexaRankContries", alexa.AlexaRankContries, SqlDbType.Int)
                 });
             _log.Info(string.Format("AlexaFull {0} {1} {2} => {3} \r\n", mss.Domain, alexa.AlexaRank, alexa.AlexaRankContries, bOK));
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
