using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Crl.ProducProperties.Core
{
    public class WorkerParseData : QueueingConsumer
    {
        private readonly NoSqlAdapter _noSqlAdapter = NoSqlAdapter.GetInstance();
        private readonly IHandlerData _handerData = null;
        private readonly ProductPropertiesAdapter _productPropertiesAdapter = new ProductPropertiesAdapter();
        private ProductPropertiesAdapter ppa = new ProductPropertiesAdapter();
        private ProductAdapter _productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
        private string domain = "";

        private HashSet<long> categories = null; 
        private ParseNormal parseNormal = null;
        private ConfigPropertySql config = null;
        private MongoAdapter mongoAdapter = MongoAdapter.Instance();
        private long companyId = 0;

        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            try
            {
                JobParse jobParse = JobParse.FromJson(UTF8Encoding.UTF8.GetString(message.Body));
                long productId = jobParse.Id;
                var objObject = _noSqlAdapter.GetHtml(productId);
                if (objObject != null)
                {
                    string html = objObject.Item2;
                    html = UtilZipFile.UnzipWithEndcode(html);
                    var htmlDocument = new HtmlDocument();
                    htmlDocument.LoadHtml(html);
                    var propertyData = this.parseNormal.ParseData(htmlDocument);
                    if (propertyData != null && propertyData.Properties.Count>0)
                    {
                        propertyData.ProductId = productId;
                        propertyData.Url = objObject.Item1;
                        this.mongoAdapter.SaveProperties(propertyData);
                        if (!this.categories.Contains(propertyData.CategoryId))
                        {
                            this.categories.Add(propertyData.CategoryId);
                            this._productPropertiesAdapter.InsertCategory(propertyData.CategoryId, propertyData.Category, this.companyId);
                        }
                        Logger.Info(string.Format("Saved for url: {0} {1}", propertyData.Url, propertyData.ProductId));
                    }
                }
                else
                {
                    Logger.Info("No html");
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }


        public override void Init()
        {
          
        }

        public WorkerParseData(string domain) : base(RabbitMQManager.GetRabbitMQServer(ConfigStatic.KeyRabbitMqCrlProductProperties), 
            ConfigStatic.GetQueueParse(domain), false)
        {
            this.domain = domain;
            this.companyId = this._productAdapter.GetCompanyIDFromDomain(domain);
            this.config = ppa.GetConfig(this._productAdapter.GetCompanyIdByDomain(this.domain));
            this.parseNormal = new ParseNormal(this.config);
            this.categories = new HashSet<long>();
            this._productAdapter.GetSqlDb().ProcessDataTableLarge(string.Format("Select ID From Product_PropertyCategory pc where pc.CompanyId = {0} Order by Id",this.companyId),
                10000, (row, iRow) =>
                {
                    this.categories.Add(Common.Obj2Int(row["ID"]));
                });
        }
    }
}
