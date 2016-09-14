using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using log4net;
using QT.Entities;
using QT.Entities.CrawlerProduct.Reload;
using QT.Moduls;
using QT.Moduls.CrawlerProduct.Comment;
using RabbitMQ.Client.Events;using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.QAComment.Core
{
    public class ConsumerAsComment:Websosanh.Core.Drivers.RabbitMQ.QueueingConsumer
    {private readonly NoSqlCommentSystem _noSqlHtml = null;
        private readonly ILog _log = LogManager.GetLogger(typeof(ConsumerDownlaodHtml));
        private readonly ProducerBasic _producerComment = null;
        private readonly  ParseComemnt _pareseComment = new ParseComemnt();private readonly DsConfigurationComment.Configuration_CommentRow _configuration;

        public ConsumerAsComment(RabbitMQServer rabbitmqServer)
            : base(rabbitmqServer,
                Config.QueueWaitAsComment, false)
        {
            string domain = "lazada.vn";
            _noSqlHtml = NoSqlCommentSystem.Instance();
            _producerComment = new ProducerBasic(rabbitmqServer, "Comment", "Comment.CommentUser.#");
            using (var db = new DsConfigurationCommentTableAdapters.Configuration_CommentTableAdapter())
            {
                DsConfigurationComment.Configuration_CommentDataTable tbl = new DsConfigurationComment.Configuration_CommentDataTable();
                db.FillByCompanyDomain(tbl, domain);
                _configuration = tbl.Rows[0] as DsConfigurationComment.Configuration_CommentRow;
            }
        }

        public override void Init(){
          
        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            var jobAs = JobWaitAS.FromObjMQ(message.Body);
            if (jobAs != null)
            {
                var html = _noSqlHtml.GetHtml(jobAs.Id, jobAs.CompanyId);
                if (!string.IsNullOrEmpty(html))
                {
                    var document = new HtmlDocument();
                    document.LoadHtml(html);
                    AnalysicHtmlForCompany(jobAs, document);
                }
                else
                {
                    _log.Info("Html can't select from db");
                }
            }
            _log.Info(string.Format("Processed for job {0}", jobAs.ToJson()));
            GetChannel().BasicAck(message.DeliveryTag, true);
        }

        private void AnalysicHtmlForCompany(JobWaitAS job, HtmlDocument document)
        {
            List<Comment> lstComment = _pareseComment.ParseComment(_configuration, document, job);
            if (lstComment.Count > 0)
            {
                _producerComment.PublishString(Newtonsoft.Json.JsonConvert.SerializeObject(lstComment));
                //_noSqlHtml.SaveComment(job.Id, job.CompanyId, lstComment);
                string url = (job.Url == null) ? "" : job.Url;
                _log.Info(string.Format("Extract {0} comment from id {1} {2}", lstComment.Count, job.Id, url));
            }

        }
    }
}
