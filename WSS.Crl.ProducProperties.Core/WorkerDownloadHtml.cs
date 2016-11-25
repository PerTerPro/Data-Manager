using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using QT.Moduls;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Crl.ProducProperties.Core
{
    public class WorkerDownloadHtml : QueueingConsumer
    {
        private int _iCount = 0;
        private readonly NoSqlAdapter noSqlAdapter = NoSqlAdapter.GetInstance();
        private string _domain = "";
        private ProducerBasic producerBasicWaitPs = null;

        public WorkerDownloadHtml(string domain) : base(
            RabbitMQManager.GetRabbitMQServer(ConfigStatic.KeyRabbitMqCrlProductProperties),
            ConfigStatic.GetQueueWaitDownloadHtml(domain), false)
        {
            this.producerBasicWaitPs = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigStatic.KeyRabbitMqCrlProductProperties), ConfigStatic.GetQueueParse(domain));
            _domain = domain;
        }

        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            _iCount++;
            Thread.Sleep(1000);
            JobDownloadHtml jobDownloadHtml = JobDownloadHtml.FromJson(Encoding.UTF8.GetString(message.Body));
            string url = this.GetUrl(jobDownloadHtml.DetailUrl);
            string html = System.Web.HttpUtility.HtmlDecode(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2));
            html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2);
            if (!string.IsNullOrEmpty(html))
            {
                noSqlAdapter.SaveHtml(jobDownloadHtml.ProductId, html, jobDownloadHtml.DetailUrl, _domain);
                Logger.Info(string.Format("Saved for {0} {1} ", _iCount, jobDownloadHtml.DetailUrl));
            }
            else
            {
                Logger.Info(string.Format("Can't download html for {0} {1} ", _iCount, jobDownloadHtml.DetailUrl));
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
            this.producerBasicWaitPs.PublishString(new JobParse()
            {
                Id = jobDownloadHtml.ProductId
            }.GetJson());
        }

        private string GetUrl(string urlDb)
        {
            if (this._domain == "lazada.vn")
            {
                //string urlData =
                //    @"http://ho.lazada.vn/SHFo4t?sku=NU914OTAHF13VNAMZ&redirect=http%3A%2F%2Fho.lazada.vn%2FSHDCvl%3Furl%3Dhttp%253A%252F%252Fwww.lazada.vn%252Fkem-xoa-vet-xuoc-xe-hoi-nu-finish-scratch-doctor-nfs-05-192ml-346071.html%253Foffer_id%253D%257Boffer_id%257D%2526affiliate_id%253D%257Baffiliate_id%257D%2526offer_name%253D%257Boffer_name%257D_%257Boffer_file_id%257D%2526affiliate_name%253D%257Baffiliate_name%257D%2526transaction_id%253D%257Btransaction_id%257D%26aff_sub%3D%26aff_sub2%3D%26aff_sub3%3D%26aff_sub4%3D%26aff_sub5%3D&aff_sub=&aff_sub2=&aff_sub3=&aff_sub4=&aff_sub5=";
                var urlData = urlDb;
                urlData = System.Web.HttpUtility.UrlDecode(urlData);
                urlData = System.Web.HttpUtility.UrlDecode(Regex.Match(urlData, @"(?<=url=)(.*)html").Captures[0].Value);
                return urlData;
            }
            return urlDb;
        }
    }
}
