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

namespace WSS.Core.Crawler
{
    public class MssNoValidTotalCompany
    {
        public long CompanyId { get; set; }
        public string Domain { get; set; }
        public int TotalProduct { get; set; }
        public int MaxValidWarning { get; set; }
        public int MinValidWarning { get; set; }
        public int MaxValid { get; set; }
        public string MssNoValid { get; set; }
    }

    public class ConsumerPushNotifyCompany : QueueingConsumer
    {
        
        private ILog _log = LogManager.GetLogger(typeof(ConsumerProductChangeToSql));
        private readonly ProductAdapter _productAdapter = null;
        private ProducerBasic _producerNoValidTotalProduct = null;

        public ConsumerPushNotifyCompany(RabbitMQServer rabbitMQServer, string queueName)
            : base(rabbitMQServer, queueName, false)
        {
            _productAdapter = new ProductAdapter(new SqlDb(ConfigCrawler.ConnectProduct));
            _producerNoValidTotalProduct = new ProducerBasic(this._rabbitMQServer, ConfigCrawler.ExchangeNoValidTotalProduct, ConfigCrawler.RoutingKeyNoValidTotalProduct);
        }

     
        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            long companyID = Convert.ToInt64(UTF8Encoding.UTF8.GetString(message.Body));
            NotifyValidatedProduct(companyID);
            GetChannel().BasicAck(message.DeliveryTag, true);
        }

        private void NotifyValidatedProduct(long companyID)
        {

            string query = @"SELECT a.ID, a.Domain, a.TotalProduct, a.MaxValid, b.MinProductToWarning, b.MaxProductToWarning
	FROM Company a INNER JOIN Configuration b on a.ID = b.CompanyID
    WHERE a.ID = @CompanyID";

            DataTable tbl = _productAdapter.GetSqlDb().GetTblData(query, CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("CompanyID",companyID,SqlDbType.BigInt)
            });

            if (tbl!=null && tbl.Rows.Count>0)
            {

                DataRow row = tbl.Rows[0];
                int totalProduct = Common.CellToInt(row, "TotalProduct", 0);
                int maxValid = Common.CellToInt(row, "MaxValid", 0);
                string domain =  Common.CellToString(row, "Domain", "");
                int minProductToWarning = Common.CellToInt(row, "MinProductToWarning", 0);
                int maxProductToWarning = Common.CellToInt(row, "MaxProductToWarning", 0);
             
                
                var objData =  new MssNoValidTotalCompany()
                         {
                             CompanyId=companyID,
                             Domain=domain,
                             MaxValid=maxValid,
                             MaxValidWarning=maxProductToWarning,
                             MinValidWarning=minProductToWarning,
                             TotalProduct = totalProduct,
                             MssNoValid="Valid total"
                         };

                if (totalProduct == 0)
                {
                    objData.MssNoValid = "Total product = 0";
                     _producerNoValidTotalProduct.PublishString(Newtonsoft.Json.JsonConvert.SerializeObject(objData));
                }
                else if (maxValid > 0 && Math.Abs((maxValid - totalProduct)/maxValid) > 0.2)
                {
                    objData.MssNoValid = "Over 20%";
                    _producerNoValidTotalProduct.PublishString(Newtonsoft.Json.JsonConvert.SerializeObject(objData));
                }
                else if  (minProductToWarning > 0 && minProductToWarning > totalProduct)
                {
                     objData.MssNoValid="MinProduct Warning";
                     _producerNoValidTotalProduct.PublishString(Newtonsoft.Json.JsonConvert.SerializeObject(objData));
                }
                else if (maxProductToWarning > 0 && maxProductToWarning < totalProduct)
                { 
                     objData.MssNoValid="MaxProduct Warning";
                     _producerNoValidTotalProduct.PublishString(Newtonsoft.Json.JsonConvert.SerializeObject(objData));
                }

                _log.Info(string.Format("Company: {0} {1} TotalProduct: {2} MaxValid: {3} MaxProductToWarning: {4} MinProductToWarning: {5} Mss: {6}",
                  companyID, domain, totalProduct, maxValid, maxProductToWarning, minProductToWarning, objData.MssNoValid));


            }
        }
    }

    public class ConsumerNotifyCompanyToSql : QueueingConsumer
    {
        private ILog _log = LogManager.GetLogger(typeof(ConsumerProductChangeToSql));
        private readonly ProductAdapter _productAdapter = null;
        private ProducerBasic _producerNoValidTotalProduct = null;
        private SqlDb _sqlDbNtotification = new SqlDb(@"server=42.112.28.93;database=QT_User;uid=wss_user;pwd=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=50");

        public ConsumerNotifyCompanyToSql(RabbitMQServer rabbitMQServer, string queueName)
            : base(rabbitMQServer, queueName, false)
        {
            _productAdapter = new ProductAdapter(new SqlDb(ConfigCrawler.ConnectProduct));
            _producerNoValidTotalProduct = new ProducerBasic(this._rabbitMQServer, ConfigCrawler.ExchangeNoValidTotalProduct, ConfigCrawler.RoutingKeyNoValidTotalProduct);
        }


        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            MssNoValidTotalCompany companyID = Newtonsoft.Json.JsonConvert.DeserializeObject<MssNoValidTotalCompany>(UTF8Encoding.UTF8.GetString(message.Body));
            NotifyValidatedProduct(companyID);
            GetChannel().BasicAck(message.DeliveryTag, true);
        }

        private void NotifyValidatedProduct(MssNoValidTotalCompany mssNotiCompany)
        {
            string query = @"
DELETE CompanyNotificationTotal WHERE CompanyId = @CompanyId;    
INSERT INTO [dbo].[CompanyNotificationTotal]
           ([CompanyId]
           ,[Domain]
           ,[TotalProduct]
           ,[MaxValidWarning]
           ,[MinValidWarning]
           ,[MaxValid]
           ,[MssNoValid])
     VALUES
           (@CompanyId
           ,@Domain
           ,@TotalProduct
           ,@MaxValidWarning
           ,@MinValidWarning
           ,@MaxValid
           ,@MssNoValid
          
    );";
            bool bOK =  _sqlDbNtotification.RunQuery(query, CommandType.Text,
                new SqlParameter[]
                {
                    SqlDb.CreateParamteterSQL("CompanyID", mssNotiCompany.CompanyId, SqlDbType.BigInt), SqlDb.CreateParamteterSQL("Domain", mssNotiCompany.Domain, SqlDbType.NVarChar),
                    SqlDb.CreateParamteterSQL("TotalProduct", mssNotiCompany.TotalProduct, SqlDbType.Int), SqlDb.CreateParamteterSQL("MaxValidWarning", mssNotiCompany.MaxValidWarning, SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("MinValidWarning", mssNotiCompany.MinValidWarning, SqlDbType.Int), SqlDb.CreateParamteterSQL("MaxValid", mssNotiCompany.MaxValid, SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("MssNoValid", mssNotiCompany.MssNoValid, SqlDbType.NVarChar),
                });

            _log.Info(string.Format("Saved for company {0} {1}", mssNotiCompany.CompanyId, bOK));

        }
    }
}
