using Bussiness;
using GABIZ.Base.HtmlUrl;
using Newtonsoft.Json;
using QT.Moduls.Crawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QT.Moduls.Crawler
{
    public abstract class AbstractionCrawler
    {
        

        public bool IsStoped
        {
            get
            {
                return this.IsStopOutSide;
            }
        }


        log4net.ILog log = log4net.LogManager.GetLogger(typeof(AbstractionCrawler));

        public AbstractionCrawler()
        {
            idCrawler = Guid.NewGuid().ToString();
            Domain = "";
        }

        public delegate void EventReportRun(object sender, string mss);
        public delegate bool EventCheckEndOutSide(object sender);

        public EventCheckEndOutSide eventCheckOutSide;
        public EventReportRun eventWhenGetJob;
        public EventReportRun eventWhenPushJob;
        public EventReportRun eventWhenStart;
        public EventReportRun eventWhenEnd;
        public EventReportRun eventWhenSuccessProduct;

        protected string strSession = "";
        protected IQueueWait queueWaitRun = null;
        protected ISetAddedVisited setAddedQueue = null;
        public bool IsEnded = false;
        public string idCrawler = "";
        public bool ExtractionLink = true;
private  bool IsStopOutSide=false;

        public void PushQueue(Job job)
        {
            try
            {
                this.queueWaitRun.PushJob(job);
                if (this.eventWhenPushJob != null) this.eventWhenPushJob(this, string.Format("Pushed job: {0}", job.ToString()));
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Exception push job:{0}", ex.Message);
            }
        }

        public void StartCrawler()
        {
            log.InfoFormat("START CRALWER:{0}", this.idCrawler);
            if (this.eventWhenStart != null) this.eventWhenStart(this, "Started");
            Job task = null;
            while (!this.IsEnded && !(this.eventCheckOutSide != null && this.eventCheckOutSide(this)))
            {
                task = queueWaitRun.GetJob();
                if (task == null)
                {
                    if (AddJobToQueue()) continue;
                    else break;
                }
                else if (task != null)
                {
                    if (this.eventWhenGetJob != null) this.eventWhenGetJob(this, task.ToString());
                    if (!CheckStopCrawler(task))
                    {
                        string html = GetHtmlOfWeb(task.url);
                        if (html != "")
                        {
                            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                            doc.LoadHtml(html);

                            //Extraction=
                            if (CheckExtractionLink(task))
                            {
                                var a_nodes = doc.DocumentNode.SelectNodes("//a[@href]");
                                if (a_nodes != null)
                                {
                                    #region add link to process
                                    for (int i = 0; i < a_nodes.Count; i++)
                                    {
                                        string s = QT.Entities.Common.GetAbsoluteUrl(a_nodes[i].Attributes["href"].Value, this.Domain);
                                        string compactLink = QT.Entities.Common.CompactUrl(s);
                                        int s_crc = Math.Abs(GABIZ.Base.Tools.getCRC32(QT.Entities.Common.CompactUrl(s)));
                                        if (CheckRegexVisit(s) && !setAddedQueue.Exists(s_crc))
                                        {
                                            try
                                            {
                                                //Thêm vào danh sách đã duyệt.
                                                this.setAddedQueue.Add(s_crc, s);

                                                //Đẩy thêm việc vào queue.
                                                this.PushQueue(new Job()
                                                    {
                                                        deep = task.deep + 1,
                                                        url = s
                                                    });
                                            }
                                            catch (Exception ex2)
                                            {
                                                log.ErrorFormat(ex2.Message);
                                            }
                                        }
                                    }
                                    #endregion
                                }
                            }

                            //AnalysicProduct.
                            if (CheckRegexProduct(QT.Entities.Common.CompactUrl(task.url)))
                            {
                                ProcessProductData(task, doc);
                            }
                        }
                        this.UpdateProcessedJob(task);
                    }
                }
            }
            if (this.eventWhenEnd != null) this.eventWhenEnd(this, "End");

            UpdateWhenEnd();

            CleanDataAfterCrawler();
        }

        public abstract bool CheckExtractionLink(Job task);

        public abstract void CleanDataAfterCrawler();

        public virtual void UpdateProcessedJob(Job task)
        {
           
        }
     

        public void StopCrawler ()
        {
            this.IsStopOutSide = true;
            this.IsEnded = true;
            log.InfoFormat("STOP CRALWER OUTSIDE:{0}", this.idCrawler);
        }

        public abstract void UpdateWhenEnd();

        public abstract bool AddJobToQueue();

        /// <summary>
        /// Xử lí sản phẩm
        /// </summary>
        /// <param name="job"></param>
        /// <param name="document"></param>
        public abstract void ProcessProductData(Job job, GABIZ.Base.HtmlAgilityPack.HtmlDocument document);

        public abstract bool CheckRegexVisit(string url);
        public abstract bool CheckRegexProduct(string url);
        public abstract bool CheckStopCrawler(Job job);
        public abstract string GetHtmlOfWeb(string url);

        public string Domain { get; set; }
    }
}
