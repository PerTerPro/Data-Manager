using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;
using System.Data;
using System.Data.SqlClient;
using QT.Moduls;
using System.Configuration;
using System.Threading;
using QT.Moduls.CrawlerAlexa;
using Wss.Lib.RabbitMq;

namespace QT.Moduls.CrawlerCompanyInfo
{


    public class ConsumerUpdateAlexaCompany : QueueingConsumer
    {
        private string _productConnectionString;
        private ILog _log = LogManager.GetLogger(typeof(ConsumerUpdateAlexaCompany));
        private readonly ProductAdapter _productAdapter = null;
        private ProducerBasic _producerNoValidTotalProduct = null;
        private SqlDb _sqlDbProduct = null;

        public ConsumerUpdateAlexaCompany(RabbitMQServer rabbitMQServer, string queueName, string connectionProduct)
            : base(rabbitMQServer, queueName, false)
        {
            _productConnectionString = connectionProduct;
            _sqlDbProduct = new SqlDb(_productConnectionString);
        }


        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            Thread.Sleep(4000);
            MssUpdateAlexaCompany mss = Newtonsoft.Json.JsonConvert.DeserializeObject<MssUpdateAlexaCompany>(UTF8Encoding.UTF8.GetString(message.Body));
            var alexa = Common.GetRankAlexa(mss.Domain);
            string strQuery = @"update company 
set  AlexaRank= @AlexaRank ,LastUpdateAlexa = getdate()
where id =@Id";
            bool bOK = this._sqlDbProduct.RunQuery(strQuery, CommandType.Text,
                 new SqlParameter[] {SqlDb.CreateParamteterSQL("@Id", mss.CompanyId, SqlDbType.BigInt)
                    , SqlDb.CreateParamteterSQL("@AlexaRank", alexa.AlexaRank, SqlDbType.Int),});
            _log.Info(string.Format("AlexaProduct {0} {1} {2} => {3} \r\n", mss.Domain, alexa.AlexaRank, alexa.AlexaRankContries, bOK));
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }

  
}