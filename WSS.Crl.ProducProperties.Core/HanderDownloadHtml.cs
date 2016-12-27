using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Crl.ProducProperties.Core
{
    public  class HanderDownloadHtml
    {
        private ILog Logger = LogManager.GetLogger(typeof (HanderDownloadHtml));
        private readonly ProducerBasic _producerBasicWaitPs = null;
        private readonly NoSqlAdapter _noSqlAdapter = NoSqlAdapter.GetInstance();
        public HanderDownloadHtml (string domain)
        {
            _producerBasicWaitPs = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigStatic.KeyRabbitMqCrlProductProperties), ConfigStatic.GetQueueParse(domain));
        }
        public void ProcessJob(JobDownloadHtml jobDownloadHtml)
        {
      
            string url = UtilCrl.GetUrl(jobDownloadHtml.DetailUrl, jobDownloadHtml.Domain);
            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2);
            html = Common.RemoveScripTag(html);
            html = Common.RemoveCommentXML(html);

            if (!string.IsNullOrEmpty(html))
            {
                _noSqlAdapter.SaveHtml(jobDownloadHtml.ProductId, html, jobDownloadHtml.DetailUrl, jobDownloadHtml.Domain);
                Logger.Info(string.Format("Saved: {0} {1}", jobDownloadHtml.ProductId, jobDownloadHtml.DetailUrl));
            }
            else
            {
                Logger.Info(string.Format("Can't download: {0} {1}", jobDownloadHtml.ProductId, jobDownloadHtml.DetailUrl));
            }

            this._producerBasicWaitPs.PublishString(new JobParse()
            {
                Id = jobDownloadHtml.ProductId
            }.GetJson());
        }
    }
}
