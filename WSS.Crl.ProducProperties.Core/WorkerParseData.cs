using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Crl.ProducProperties.Core
{
    public class WorkerParseData : QueueingConsumer
    {
        private readonly NoSqlAdapter _noSqlAdapter = NoSqlAdapter.GetInstance();
        private readonly IHandlerData _handerData = null;
        private readonly ProductPropertiesAdapter _productPropertiesAdapter = new ProductPropertiesAdapter();

        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            JobParse jobParse = JobParse.FromJson(UTF8Encoding.UTF8.GetString(message.Body));
            long productId = jobParse.Id;
            string html = _noSqlAdapter.GetHtml(productId).Item2;
            if (!string.IsNullOrEmpty(html))
            {
                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(html);
                Product pt = this._handerData.ParseProduct(htmlDocument);
                if (pt != null)
                {
                    pt.ProductId = productId;
                    _productPropertiesAdapter.UpsertProduct(pt);
                    Logger.Info(string.Format("NumberProperty {0} for : {1}", pt.dicValue.Count, productId));
                }
                else
                {
                    Logger.Info(string.Format("NO product for {0}", productId));
                }
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }

        public override void Init()
        {
            
        }

        public WorkerParseData(string domain) : base(RabbitMQManager.GetRabbitMQServer(ConfigStatic.KeyRabbitMqCrlProductProperties), 
            ConfigStatic.GetQueueParse(domain), false)
        {
            if (domain == "adayroi.com")
            {
                this._handerData=new HandlerAdayroi();
            }
            else if (domain == "lazada.vn")
            {
                this._handerData=new HandlerLazada();
            }
            else if (domain == "tiki.vn")
            {
                this._handerData=new HandlerTiki();
            }
        }
    }
}
