

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using log4net;
using log4net.Util;
using QT.Entities;
using QT.Entities.Data;
using QT.Entities.Images;
using QT.Moduls;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlerReviewFacebook;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.Core.Crawler
{
    public class ConsumerProductChangeToSql : QueueingConsumer
    {
        private ILog _log = LogManager.GetLogger(typeof (ConsumerProductChangeToSql));
        private JobClient _jobClient = null;

        private ProductAdapter _productAdapter = null;

        public ConsumerProductChangeToSql(RabbitMQServer rabbitMqServer, string queueName) : base(rabbitMqServer, queueName, false)
        {
            InitData();
        }

        public ConsumerProductChangeToSql() : base(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler), ConfigCrawler.QueueProductChangeToSql, false)
        {
            this.InitData();
        }

        private void InitData()
        {
            _productAdapter = new ProductAdapter(new SqlDb(ConfigCrawler.ConnectProduct));
            _jobClient = new JobClient(ConfigImages.ExchangeImages, GroupType.Topic, ConfigImages.RoutingKeyChangeImageProduct, true, RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName));
        }

        public override void Init()
        {
        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            try
            {
                var pt = ProductEntity.GetFromJson(message.Body);
                if (pt.StatusChange.IsDelete)
                {
                    if (_productAdapter.DeleteProduct(pt.ID))
                    {
                        _log.Info("Deleted unSuccess product: " + pt.ID + pt.DetailUrl);
                        RabbitMQAdapter.Instance.PushProductToQueueChangeMainInfo(new List<long>() {pt.ID});
                    }

                }
                else if (pt.StatusChange.IsDuplicate)
                {
                    if (_productAdapter.DeleteProduct(pt.ID))
                    {
                        _log.Info("Deleted  duplicate: " + pt.ID + pt.DetailUrl);
                        RabbitMQAdapter.Instance.PushProductToQueueChangeMainInfo(new List<long>() {pt.ID});
                    }
                }
                else if (pt.StatusChange.IsNew)
                {
                    if (_productAdapter.InsertProduct(pt))
                    {

                        _jobClient.PublishJob(new Websosanh.Core.JobServer.Job() {Data = ImageProductInfo.GetMessage(new ImageProductInfo(pt.ID, pt.Name, pt.DetailUrl, pt.ImageUrl, true))});
                        _log.Info(string.Format("Company: {0} Insert product: {1}", pt.CompanyId, pt.ID));
                    }
                }
                else
                {
                    if (_productAdapter.UpdateProduct(pt))
                    {
                        _log.Info(string.Format("Company: {0} Updated product: {1}", pt.CompanyId, pt.ID));
                        if (pt.StatusChange.IsChangeImage)
                        {
                            _jobClient.PublishJob(new Websosanh.Core.JobServer.Job() {Data = ImageProductInfo.GetMessage(new ImageProductInfo(pt.ID, pt.Name, pt.DetailUrl, pt.ImageUrl, false))});
                        }
                        RabbitMQAdapter.Instance.PushProductToQueueChangeMainInfo(new List<long>() {pt.ID});
                    }
                }
            }

            catch (Exception ex)
            {
                _log.Error(ex.Message);
            }

            GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
