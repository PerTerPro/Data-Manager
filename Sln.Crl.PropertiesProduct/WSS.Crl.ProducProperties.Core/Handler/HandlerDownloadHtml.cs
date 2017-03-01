using System;
using System.Net;
using System.Threading;
using System.Web.UI.WebControls;
using log4net;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.Crl.ProducProperties.Core.Storage;
using WSS.LibExtra;
using System.IO;
using ProtoBuf;
using System.Text;
using System.IO.Compression;

namespace WSS.Crl.ProducProperties.Core.Handler
{
    public interface IHandlerDownloadHtml
    {
        void ProcessJob(JobCrlProperties jobDownloadHtml);
    }

    public class HandlerDownloadHtml : IHandlerDownloadHtml
    {
        public interface ISetting
        {
            string Domain { get; set; }
        }

        private readonly ILog _logger;
        private readonly IStorageHtml _storageHtml;
        private readonly IDownloadHtml _downloadHtml;
        private readonly IStorageConfigCrl _storageConfigCrl;
        private string _domain;
        private ProducerBasic _producerBasic;
        private ConfigProperty _config;


        public void Init(string domain)
        {
            this._domain = domain;
            this._producerBasic = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigStatic.KeyRabbitMqCrlProductProperties), ConfigStatic.GetQueueParse(this._domain));
            this._config = _storageConfigCrl.GetConfig(this._domain);
        }


        public HandlerDownloadHtml(IDownloadHtml downloader, IStorageHtml storageHtml, IStorageConfigCrl configCrl)
        {
            this._downloadHtml = downloader;
            this._storageHtml = storageHtml;
            this._storageConfigCrl = configCrl;
            this._logger = LogManager.GetLogger(typeof(HandlerDownloadHtml));

        }



        public void ProcessJob(JobCrlProperties jobDownloadHtml)
        {
            DateTime dtFrom = DateTime.Now;
            var html = DownloadHtml(jobDownloadHtml);
            if (!string.IsNullOrEmpty(html))
            {
                //SaveToStorage(jobDownloadHtml, html);

                jobDownloadHtml.Html = html;

                byte[] mss = Compress(UTF8Encoding.UTF8.GetBytes(jobDownloadHtml.GetJson()));
                this._producerBasic.Publish(mss, true);
                Thread.Sleep(this._config.TimeDelay);
            }
            else
            {
                _logger.Info("Can't download html");
            }
            _logger.Info(string.Format("Processed job {0} in {1}", jobDownloadHtml.ProductId, (DateTime.Now - dtFrom).Milliseconds));
        }
        public static byte[] Compress(byte[] raw)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(memory,
                    CompressionMode.Compress, true))
                {
                    gzip.Write(raw, 0, raw.Length);
                }
                return memory.ToArray();
            }
        }
        private void SaveToStorage(JobCrlProperties jobDownloadHtml, string html)
        {
            _storageHtml.SaveHtml(new HtmlProduct()
            {
                ProductId = jobDownloadHtml.ProductId,
                Html = html,
                Domain = jobDownloadHtml.Domain,
                Classification = jobDownloadHtml.Classification
            });
        }



        private string DownloadHtml(JobCrlProperties jobDownloadHtml)
        {
            WebExceptionStatus w = WebExceptionStatus.ConnectFailure;
            var html = this._downloadHtml.GetHtml(jobDownloadHtml.DetailUrl, 45, 2, out w);
            html = CommonConvert.RemoveScripTag(html);
            html = CommonConvert.RemoveCommentXML(html);



            return html;
        }

        public ISetting _setting { get; set; }
    }
}
