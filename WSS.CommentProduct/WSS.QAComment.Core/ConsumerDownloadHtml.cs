using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DevExpress.XtraPrinting.Native;
using log4net;
using QT.Entities;
using QT.Moduls;
using QT.Moduls.CrawlerProduct.Comment;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.QAComment.Core
{
    public  class ConsumerDownloadHtml:Websosanh.Core.Drivers.RabbitMQ.QueueingConsumer
    {
        private readonly NoSqlCommentSystem _noSqlHtml = null;
        private readonly ILog _log = LogManager.GetLogger(typeof(ConsumerDownlaodHtml));
        private readonly ProducerBasic _producerAfterDownload = null;
        private string _queueAS;

        public ConsumerDownloadHtml(RabbitMQServer rabbitmqServer, string domain) : base(rabbitmqServer, Config.QueueWaitDownloadHtml + "." + domain, false)
        {
            _noSqlHtml = NoSqlCommentSystem.Instance();
            _queueAS = Config.QueueWaitAsComment + "." + domain;


            _producerAfterDownload = new ProducerBasic(rabbitmqServer, Config.QueueWaitAsComment + "." + domain);

        }

        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            var jobDownloadHtml = JobDownloadHtml.FromArByte(message.Body);
            if (jobDownloadHtml != null)
            {
                var url = jobDownloadHtml.Url;
                var html = HttpUtility.HtmlDecode(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(jobDownloadHtml.Url, 45, 2));
                if (!string.IsNullOrEmpty(html)){
                    _noSqlHtml.SaveHtm(jobDownloadHtml.Id, jobDownloadHtml.CompanyId, html, jobDownloadHtml.Url);
                    _producerAfterDownload.PublishString(new JobWaitAS() { Id = jobDownloadHtml.Id, CompanyId = jobDownloadHtml.CompanyId, Url = url}.ToJson());
                    _log.Info(string.Format("Download html for job:{0}", jobDownloadHtml.ToJSON()));
                }
                else
                {
                    _log.Info(string.Format("Can't download html of job:{0}", jobDownloadHtml.ToJSON()));
                }
            }
            else
            {
                _log.Info("JobErrorParse");
            }
            GetChannel().BasicAck(message.DeliveryTag, true);
        }

        public override void Init()
        {
            
        }
    }
}
