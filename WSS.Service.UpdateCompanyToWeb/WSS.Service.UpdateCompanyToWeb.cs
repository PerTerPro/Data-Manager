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
using WebsosanhCacheTool;
using System.Configuration;
using Wss.Lib.RabbitMq;

namespace WSS.Service.UpdateCompanyToWeb
{


    public class ConsumerUpdateCompanyToWeb : QueueingConsumer
    {
        private string _productConnectionString;
        private string _userConnectionString;
        private string _searchEnginesServiceUrl;
     

        private ILog _log = LogManager.GetLogger(typeof(ConsumerUpdateCompanyToWeb));
        private readonly ProductAdapter _productAdapter = null;
        private ProducerBasic _producerNoValidTotalProduct = null;

        public ConsumerUpdateCompanyToWeb(RabbitMQServer rabbitMQServer, string queueName) : base(rabbitMQServer, queueName, false)
        {
            _productConnectionString = ConfigurationManager.ConnectionStrings["ProductConnectionString"].ToString();
            _userConnectionString = ConfigurationManager.ConnectionStrings["UserConnectionString"].ToString();
            _searchEnginesServiceUrl = ConfigurationManager.AppSettings["searchEnginesServiceUrl"];
        }

        public ConsumerUpdateCompanyToWeb()
            : base(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct), "UpdateCompany.ToWeb", false)
        {
            _productConnectionString = ConfigurationManager.ConnectionStrings["ProductConnectionString"].ToString();
            _userConnectionString = ConfigurationManager.ConnectionStrings["UserConnectionString"].ToString();
            _searchEnginesServiceUrl = ConfigurationManager.AppSettings["searchEnginesServiceUrl"];
        }

        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            long companyID = Convert.ToInt64(UTF8Encoding.UTF8.GetString(message.Body));
            int result1 = WebMerchantCacheTool.InsertAllBranchesAndRegionsOfMerchant(companyID, _productConnectionString);
            bool result2 = WebMerchantCacheTool.InsertMerchantShortInfoToCache(companyID, _productConnectionString, _userConnectionString);
            Logger.Info(string.Format("{0} {1} \r\n", result1, result2));
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }

    }
}
