using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GABIZ.Base.Statistics.Kernels;
using log4net;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.CrawlerProduct.Cache;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlerProduct.Cache;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;
using QT.Moduls;
using QT.Moduls.CrawlerProduct.RabbitMQ;
using RabbitMQ.Client;
using RabbitMQ.Client.Framing;
using Websosanh.Core.JobServer;

namespace WSS.Core.Crawler
{


    public class ConsumerSessionRunningUpdate : QueueingConsumer
    {
        private ILog _log = LogManager.GetLogger(typeof (ConsumerSessionRunningUpdate));
        private readonly RedisCompanyWaitCrawler _redisWaitCrawler = RedisCompanyWaitCrawler.Instance();

        private void ReportToRedis(ReportSessionRunning re)
        {
            _redisWaitCrawler.SetRunningCrawler(re.CompanyId);
            if (re.Type == "Reload")
                _redisWaitCrawler.SetNexReload(re.CompanyId, 1);
            else if (re.Type == "FindNew")
                _redisWaitCrawler.SetNexFindNew(re.CompanyId, 1);
        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            var re = ReportSessionRunning.GetFromJson(message.Body);
            ReportToRedis(re);
            this.GetChannel().BasicAck(message.DeliveryTag, true);
            _log.Info("Saved sesionrunning");
        }

        public override void Init()
        {

        }

        public ConsumerSessionRunningUpdate() : base(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.QueueUpdateSessionRunning, false)
        {
        }
    }



    public class ConsumerProductChangeToCache : QueueingConsumer
    {
        private ILog _log = LogManager.GetLogger(typeof (ConsumerProductChangeToCache));
        private readonly RedisLastUpdateProduct _chLastProduct = RedisLastUpdateProduct.Instance();
        private readonly CacheProductHash _chProductHash = CacheProductHash.Instance();

        private readonly ProducerBasic _producerDescriptionQuang = null;
        private readonly ProducerBasic _producerClassification = null;
        private readonly ProducerBasic _producerChangeDesc = null;

        private readonly CacheProductDesciptioHash _chProductDesciptioHash = CacheProductDesciptioHash.Instance();
        private readonly MqLogChangePrice _jobPushChangePrice = new MqLogChangePrice();

        private readonly ProductAdapter _productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));

        public ConsumerProductChangeToCache(RabbitMQServer rabbitmQServer, string nameQueue)
            : base(rabbitmQServer, nameQueue, false)
        {
            _producerDescriptionQuang = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqProduct), ConfigRun.QueueChangeDescription);
            _producerChangeDesc = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.ExchangeChangeDesc, ConfigCrawler.RoutingkeyChangeDesc);
            _producerClassification = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.QueueAddClassification);
        }


        public override void Init()
        {
        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            try
            {
                var pt = ProductEntity.GetFromJson(message.Body);
                _producerClassification.Publish(new Classification() {CompanyId = pt.CompanyId, Id = pt.ID, Category = pt.GetCategoryString()}.GetArbyteJson());
                if (pt.StatusChange.IsNew)
                {
                    _chLastProduct.UpdateBathLastUpdateProduct(pt.CompanyId, new List<long> {pt.ID}, DateTime.Now);
                    _chProductHash.SetCacheProductHash(pt.CompanyId,
                        new ProductHash() {url = pt.DetailUrl, Id = pt.ID, Price = pt.Price, HashImage = pt.GetHashImage(), HashChange = pt.GetHashChange(), HashDuplicate = pt.GetHashDuplicate()});
                }
                else if (pt.StatusChange.IsDelete)
                {
                    _chLastProduct.RemoveProduct(pt.CompanyId, pt.ID);
                    _chProductHash.RemoveProduct(pt.CompanyId, pt.ID);
                }
                else if (pt.StatusChange.IsDuplicate)
                {
                    _chLastProduct.RemoveProduct(pt.CompanyId, pt.ID);
                    _chProductHash.RemoveProduct(pt.CompanyId, pt.CompanyId);
                }
                else if (pt.StatusChange.IsChangeBasic)
                {
                    _chLastProduct.UpdateBathLastUpdateProduct(pt.CompanyId, new List<long> {pt.ID}, DateTime.Now);
                    _chProductHash.SetCacheProductHash(pt.CompanyId,
                        new ProductHash() {url = pt.DetailUrl, Id = pt.ID, Price = pt.Price, HashImage = pt.GetHashImage(), HashChange = pt.GetHashChange(), HashDuplicate = pt.GetHashDuplicate()});
                }

                if (pt.StatusChange.IsChangeDesc)
                {
                    var jobDescription = new JobMqChangeDesc() {Id = pt.ID, FullDesc = pt.FullDescHtml, ShortDesc = pt.ShortDescHtml, SpecDesc = pt.SpecsDescHtml, VideoDesc = pt.VideoDescHtml};

                    _producerDescriptionQuang.Publish(UtilZipFile.Zip(jobDescription.GetJSON()));
                    _producerChangeDesc.Publish(UtilZipFile.Zip(jobDescription.GetJSON()));
                    _chProductDesciptioHash.SetHashDesc(pt.CompanyId, new Tuple<long, long>(pt.ID, pt.GetHashDesc()));
                }

                if (pt.StatusChange.IsChangePrice)
                {
                    _jobPushChangePrice.PushQueueChangePriceLog(new JobRabbitChangePrice() {Name = pt.Name, ProductID = pt.ID, CompanyID = pt.CompanyId, NewPrice = pt.Price, OldPrice = pt.OldPrice});
                }
                _log.Info(string.Format("Saved for pt: {0}", pt.ID));
            }
            catch (Exception ex01)
            {
                _log.Error(ex01);
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
