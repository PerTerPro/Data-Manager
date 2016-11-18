using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using log4net;

namespace WSS.Core.Crawler
{
    public  class  JobNodeCrawler
    {
        public  string Url {get;set;}
        public  int Deep {get;set;}
        public JobNodeCrawler()
        {
            Url = "";
            Deep = 0;
        }
    }


    public abstract class CrawlerBasic
    {
        protected ILog _log = log4net.LogManager.GetLogger(typeof(CrawlerBasic));

        private HashSet<long> _crcVisited;
        private Queue<JobNodeCrawler> _queueCrawler; 

        public abstract string GetHtml(string url);
        public abstract bool CheckIsProduct(string url);
        public abstract bool CheckAllowVisit(string url);

        public  virtual  void ProcessProductLink (string url)
        {
            
        }

        public void Start()
        {
            while (_queueCrawler.Count > 0)
            {
                JobNodeCrawler jobNodeCrawler = _queueCrawler.Dequeue();
                string html = GetHtml(jobNodeCrawler.Url);
                if (!string.IsNullOrEmpty(html))
                {
                    HtmlDocument htmlDocument = new HtmlDocument();
                    htmlDocument.LoadHtml(html);
                    Extraction(htmlDocument, jobNodeCrawler);
                    AnalysicProduct(htmlDocument, jobNodeCrawler);
                }

            }
        }

        private void AnalysicProduct(HtmlDocument htmlDocument, JobNodeCrawler jobNodeCrawler)
        {
            if (CheckIsProduct(jobNodeCrawler.Url))
            {
                ProcessProductLink(jobNodeCrawler.Url);
            }
        }

        private void Extraction(HtmlDocument htmlDocument, JobNodeCrawler jobNodeCrawler)
        {
            var nodesUrl = htmlDocument.DocumentNode.SelectNodes("//a");
            if (nodesUrl != null)
            {
                foreach (var VARIABLE in nodesUrl)
                {
                    string urlNew = VARIABLE.GetAttributeValue("href", "");
                    if (!string.IsNullOrEmpty(urlNew))
                    {
                        if (CheckAllowVisit(urlNew))
                        {
                            _queueCrawler.Enqueue(new JobNodeCrawler()
                            {
                                Deep = jobNodeCrawler.Deep + 1,
                                Url = jobNodeCrawler.Url
                            });
                        }
                    }
                }
            }
        }
    }
}
