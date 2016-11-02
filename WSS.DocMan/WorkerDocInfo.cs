using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using log4net;
using log4net.Repository.Hierarchy;
using QT.Entities;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.DocMan
{
    public class WorkerDocInfo : QueueingConsumer
    {
        private readonly DocManAdapter _docManAdapter = new DocManAdapter();
        private ILog _log = log4net.LogManager.GetLogger(typeof (WorkerCrawler));

        public WorkerDocInfo()
            : base(
                RabbitMQManager.GetRabbitMQServer(ConfigDocMan.KeyRabbitMqWaitDl), ConfigDocMan.QueueDocInfo, false)
        {
        }

        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            JobResetDocInfo job =
                Newtonsoft.Json.JsonConvert.DeserializeObject<JobResetDocInfo>(UTF8Encoding.UTF8.GetString(message.Body));
            string url = job.Url;
            if (Regex.IsMatch(job.Url, @"http://moj.gov.vn/vbpq/Lists/Vn%20bn%20php%20lut/View_Detail.aspx\?ItemID=\d.*"))
            {
                string id = Regex.Match(job.Url, @"ItemID=\d+").Groups[0].Captures[0].Value.Replace("ItemID=", "");
                url = string.Format(@"http://moj.gov.vn/vbpq/Pages/View_Propertes.aspx?ItemID={0}", id);
                var html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 42, 2);
                if (!string.IsNullOrEmpty(html))
                {
                    html = System.Web.HttpUtility.HtmlDecode(html);
                    HtmlDocument htmlDocument = new HtmlDocument();
                    htmlDocument.LoadHtml(html);
                    Documet document = new Documet();

                    ParserData p = new ParserData();
                    var docInfo = p.ParseInfoDoc(htmlDocument, url);

                    if (docInfo!=null)
                    {
                        docInfo.Id = job.Id;
                        _docManAdapter.UpdateDocData(docInfo);
                    }
                }
                _log.Info(string.Format("{0} Success", url));

                Thread.Sleep(1000);

                //string urlInfo = @"http://moj.gov.vn/vbpq/Pages/View_Propertes.aspx?ItemID=3001";
                //HtmlDocument htmlDocumentInfo = new HtmlDocument();
                //htmlDocumentInfo.LoadHtml(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 42, 2));
            }
            else
            {
                Logger.Info(string.Format("Fail regex {0}", job.Url));
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
