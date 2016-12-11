

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using log4net;
using log4net.Util;
using QT.Entities;
using QT.Entities.CrawlerProduct;
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
        private readonly ILog _log = LogManager.GetLogger(typeof (ConsumerProductChangeToSql));
        private JobClient _jobClient = null;

        private readonly ProducerBasic _producerLogAddProduct = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler), ConfigCrawler.QueueLogAddProduct);
        private readonly ProducerBasic _producerLogDelProduct = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler), "CrawlerProduct.LogDelProduct.ToSql");
        private readonly ProducerBasic _producerDelImgImbo = new ProducerBasic(RabbitMQManager.GetRabbitMQServer("ImboImg"), "Img.Imbo.Delete");
       
        private ProductAdapter _productAdapter = null;

  
        public ConsumerProductChangeToSql() : base(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler), ConfigCrawler.QueueProductChangeToSql, false)
        {
            this.InitData();
        }

        private void InitData()
        {
            _productAdapter = new ProductAdapter(new SqlDb(ConfigCrawler.ConnectProduct));
            _jobClient = new JobClient(ConfigImages.ImboExchangeImages, GroupType.Topic, ConfigImages.ImboRoutingKeyDownloadImageProduct, true, RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName));
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
                    string sql = string.Format(@"select top 1 p.DetailUrl, p.Name, p.Price, p.CategoryID, p.LastUpdate, p.ImagePath, p.ImageUrls, p.ImageId, p.ID
	from Product p
	where p.ID = {0} ", pt.ID);
                    DataTable tbl = _productAdapter.GetSqlDb().GetTblData(sql, CommandType.Text, null);
                    if (tbl.Rows.Count > 0 && _productAdapter.DeleteProduct(pt.ID))
                    {
                   

                        _log.Info("Deleted Success product: " + pt.ID + pt.DetailUrl);
                        var row1 = tbl.Rows[0];
                        string imgId = Common.Obj2String(row1["ImageId"]);
                        var objBackUp = new JobBackupProductToDel()
                        {

                            Id = Common.Obj2Int64(row1["ID"]),
                            Price = Common.Obj2Int64(row1["Price"]),
                            ImageId = imgId,
                            ImageUrl = Common.Obj2String(row1["ImageUrls"]),
                            Name = Common.Obj2String(row1["Name"]),
                            ProductUrl = Common.Obj2String("DetailUrl")
                        };
                        RabbitMQAdapter.Instance.PushProductToQueueChangeMainInfo(new List<long>() {pt.ID});
                        if (!string.IsNullOrEmpty(imgId))
                            _producerDelImgImbo.PublishString(imgId);
                        _producerLogDelProduct.PublishString(objBackUp.ToJson());
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
                        _jobClient.PublishJob(new Websosanh.Core.JobServer.Job() 
                        {Data = ImageProductInfo.GetMessage(new ImageProductInfo(pt.ID, pt.Name, pt.DetailUrl, pt.ImageUrl, true))});
                        _producerLogAddProduct.PublishString(Newtonsoft.Json.JsonConvert.SerializeObject(new JobRabbitAddProduct()
                        {
                            DateAdd = DateTime.Now,
                            DetailUrl = pt.DetailUrl,
                            IDCompnay = pt.CompanyId,
                            Name = pt.Name,
                            ProductID = pt.ID
                        }));
                        _log.Info(string.Format("Company: {0} Inserted product: {1}", pt.CompanyId, pt.ID));
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
