using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using QT.Entities.Data;
using QT.Moduls.CrawlerCompanyInfo;
using QT.Moduls.CrawlerProduct;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;
using QT.Entities;
using Wss.Lib.RabbitMq;

namespace QT.Moduls.CrawlerAlexa
{
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
            Thread.Sleep(4000);
            MssUpdateAlexaCompany mss = Newtonsoft.Json.JsonConvert.DeserializeObject<MssUpdateAlexaCompany>(UTF8Encoding.UTF8.GetString(message.Body));

            try
            {
                var alexa = Common.GetRankAlexa(mss.Domain);
                if (alexa != null)
                {
                    string strQuery = @"
                                    update Web 
                                    set  AlexaRank = @AlexaRank, LastUpdateAlexa = getdate()
                                    where id =@Id";
                    bool bOK = this._sqlDbProduct.RunQuery(strQuery, CommandType.Text,
                        new SqlParameter[] { SqlDb.CreateParamteterSQL("@Id", mss.CompanyId, SqlDbType.BigInt), SqlDb.CreateParamteterSQL("@AlexaRank", alexa.AlexaRankContries, SqlDbType.Int), });
                    Logger.Info(string.Format("AlexaSeo updated: {0} {1} {2} => {3}\r\n", mss.Domain, alexa.AlexaRank, alexa.AlexaRankContries, bOK));

                }
                else
                {
                    _log.InfoFormat("Fail alexa for {0}", mss.Domain);
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex + string.Format("Company: {0} {1}", mss.CompanyId, mss.Domain));
            }

            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
