using GABIZ.Base.HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WSS.FindWebInVatGia.FindNewWebSiteInChonGiaDung
{
    public class TaskFindNewWebSite
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(TaskFindNewWebSite));
        ChonGiaDungDbAdapter chonGiaDungDbAdapter = new ChonGiaDungDbAdapter();

        public void FindCatUrl()
        {
            string regexCat = @"^http://www.chongiadung.com/s\?c=[^\/]+$";
            Queue<String> queueCrawler = new Queue<string>();
            Dictionary<long, string> addedQueueCRC = new Dictionary<long, string>();
            string rootLink = "http://www.chongiadung.com";
            addedQueueCRC.Add(QT.Entities.Common.CrcProductID(rootLink), "");
            queueCrawler.Enqueue(rootLink);
            while (queueCrawler.Count > 0)
            {
                log.Info("QueueCount:" + queueCrawler.Count.ToString());
                string queue = queueCrawler.Dequeue();
                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(queue, 45, 2));
                var nodeLinks = htmlDocument.DocumentNode.SelectNodes("//a");
                if (nodeLinks != null)
                    foreach (var nodeLink in nodeLinks)
                    {
                        if (nodeLink.Attributes.Contains("href"))
                        {
                            string link = QT.Entities.Common.GetAbsoluteUrl(nodeLink.Attributes["href"].Value.ToString(), "http://www.chongiadung.com");
                            if (!addedQueueCRC.ContainsKey(QT.Entities.Common.CrcProductID(link)))
                            {
                                if (Regex.IsMatch(link, regexCat)
                                    && !link.Contains("&")
                                    && !link.Contains("page")
                                    && !link.Contains("sort=")
                                    && !link.Contains("order="))
                                {
                                    queueCrawler.Enqueue(link);
                                    addedQueueCRC.Add(QT.Entities.Common.CrcProductID(link), "");
                                    chonGiaDungDbAdapter.SaveLink(link, 0);
                                    log.Info("Cat link:" + link);
                                }
                            }
                        }
                    }
            }
        }

        public void FindWebSiteUrl()
        {
            string regexForCompany = @"^^http://www.chongiadung.com/s\?c=[^\/]+&source=[^\/]+$";
            DataTable tblCat = chonGiaDungDbAdapter.GetCatLink();
            foreach (DataRow rowCat in tblCat.Rows)
            {
                long ID = Convert.ToInt64(rowCat["ID"]);
                string url = Convert.ToString(rowCat["UrlDetail"]);
                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(GetHtmlCode(url));
                var nodeLinks = htmlDocument.DocumentNode.SelectNodes("//a");
                if (nodeLinks != null)
                {
                    foreach (var nodeLink in nodeLinks)
                    {
                        if (nodeLink.Attributes.Contains("href"))
                        {
                            string urlHtml = QT.Entities.Common.GetAbsoluteUrl(nodeLink.Attributes["href"].Value.ToString(), "http://www.chongiadung.com");
                            if (Regex.IsMatch(urlHtml, regexForCompany))
                            {
                                if (urlHtml.Contains(".com")
                                    || urlHtml.Contains(".vn"))
                                {
                                    chonGiaDungDbAdapter.SaveLink(urlHtml, 1);
                                    log.Info(urlHtml);
                                }
                            }
                        }
                    }
                }
            }
            log.Info("Success!");
        }

        public void FindKeywordUrl(string keyword)
        {
            Dictionary<string, string> dicDomain = new Dictionary<string, string>();
            DataTable tblUrlDetail = chonGiaDungDbAdapter.GetCompanyLink();
            foreach (DataRow  RowInfo in tblUrlDetail.Rows)
            {
                string UrlDetail = RowInfo["UrlDetail"].ToString();
                string[] UrlCut1 = UrlDetail.Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
                string[] UrlCut2 = UrlCut1[1].ToString().Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                string Domain = UrlCut2[1].ToString();

                if(!dicDomain.ContainsKey(Domain)) dicDomain.Add(Domain, "");

            }
            string regexForCompany = @"^^http://www.chongiadung.com/s\?q=[^\/]+&source=[^\/]+$";
            string keywordnew = keyword.Replace(" ", "+");
            string url = "http://www.chongiadung.com/s?q=" + keywordnew;
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(GetHtmlCode(url));
            var nodeLinks = htmlDocument.DocumentNode.SelectNodes("//a");
            if (nodeLinks != null)
            {
                foreach (var nodeLink in nodeLinks)
                {
                    if (nodeLink.Attributes.Contains("href"))
                    {
                        string urlHtml = QT.Entities.Common.GetAbsoluteUrl(nodeLink.Attributes["href"].Value.ToString(), "http://www.chongiadung.com");
                        if (Regex.IsMatch(urlHtml, regexForCompany))
                        {
                            if (urlHtml.Contains(".com")
                                || urlHtml.Contains(".vn"))
                            {
                                string[] urlHlmlCut1 = urlHtml.Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
                                string[] urlHtmlCut2 = urlHlmlCut1[1].ToString().Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                                string urlHtmlNew = urlHtmlCut2[1].ToString();
                                if (!dicDomain.ContainsKey(urlHtmlNew))
                                {
                                    chonGiaDungDbAdapter.SaveLink(urlHtml, 1);
                                    log.Info(urlHtml);
                                }
                                
                            }
                        }
                    }
                }
            }
        }

        public void FindWebSiteUrlByKeyword()
        {
           
        }

        private string GetHtmlCode(string urlCurrent)
        {
            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(urlCurrent, 45, 2);
            html = html.Replace("<form", "<div");
            html = html.Replace("</form", "</div");
            return html;
        }

        public void CheckDumpInWSSWebsite()
        {

        }
    }
}
