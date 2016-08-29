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

namespace QT.Moduls.CrawlerCompanyInfo
{


    public class ConsumerUpdateAlexaCompany : QueueingConsumer
    {
        private string _productConnectionString;
        private ILog _log = LogManager.GetLogger(typeof(ConsumerUpdateAlexaCompany));
        private readonly ProductAdapter _productAdapter = null;
        private ProducerBasic _producerNoValidTotalProduct = null;
        private SqlDb _sqlDbProduct = null;

        public ConsumerUpdateAlexaCompany(RabbitMQServer rabbitMQServer, string queueName) : base(rabbitMQServer, queueName, false)
        {
            _productConnectionString = ConfigurationManager.ConnectionStrings["ProductConnectionString"].ToString();

        }


        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            MssUpdateAlexaCompany mss = Newtonsoft.Json.JsonConvert.DeserializeObject<MssUpdateAlexaCompany>(UTF8Encoding.UTF8.GetString(message.Body));

            var alexa = Common.GetRankAlexa(mss.Domain);
            string strQuery = @"update company 
set  AlexaRank= 1
where id =1";

            this._sqlDbProduct.RunQuery(strQuery, CommandType.Text,
                new SqlParameter[] {SqlDb.CreateParamteterSQL("@Id", mss.CompanyId, SqlDbType.BigInt), SqlDb.CreateParamteterSQL("@AlexaRank", alexa.AlexaRank, SqlDbType.Int),});
            Logger.Info(string.Format("{0} {1} \r\n", mss.Domain, alexa.AlexaRank, alexa.AlexaRankContries));
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }

    public class ConsumerUpdateAlexaCompanySeo : QueueingConsumer
    {
        private string _productConnectionString;
        private ILog _log = LogManager.GetLogger(typeof(ConsumerUpdateAlexaCompany));
        private readonly ProductAdapter _productAdapter = null;
        private ProducerBasic _producerNoValidTotalProduct = null;
        private SqlDb _sqlDbProduct = null;

        public ConsumerUpdateAlexaCompanySeo(RabbitMQServer rabbitMQServer, string queueName, string connection)
            : base(rabbitMQServer, queueName, false)
        {
            _productConnectionString = connection;
            _sqlDbProduct = new SqlDb(connection);
        }


        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            Thread.Sleep(2000);
            MssUpdateAlexaCompany mss = Newtonsoft.Json.JsonConvert.DeserializeObject<MssUpdateAlexaCompany>(UTF8Encoding.UTF8.GetString(message.Body));
            var alexa = Common.GetRankAlexa(mss.Domain);
            if (alexa.AlexaRankContries > 0)
            {
                string strQuery = @"
                                    update Web 
                                    set  AlexaRank = @AlexaRank
                                    where id =@Id";
                bool bOK = this._sqlDbProduct.RunQuery(strQuery, CommandType.Text,
                    new SqlParameter[] {SqlDb.CreateParamteterSQL("@Id", mss.CompanyId, SqlDbType.BigInt), SqlDb.CreateParamteterSQL("@AlexaRank", alexa.AlexaRankContries, SqlDbType.Int),});
                Logger.Info(string.Format("{0} {1} {2} => {3} \r\n", mss.Domain, alexa.AlexaRank, alexa.AlexaRankContries, bOK));
               
            }
            else
            {
                _log.InfoFormat("Fail alexa for {0}", mss.Domain);
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}