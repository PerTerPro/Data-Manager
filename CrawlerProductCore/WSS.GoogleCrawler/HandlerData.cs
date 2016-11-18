using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using Microsoft.SqlServer.Server;
using QT.Entities;

namespace WSS.GoogleCrawler
{
    internal class HandlerData
    {
        private string patternUrl = "https://www.google.com.vn/search?q={2}&num={0}&start={1}";
        private int page = 5;
        private int numInPage = 50;

        public HashSet<string> GetListSite(IEnumerable<string> keywords)
        {
            HashSet<string> hsDomains = new HashSet<string>();
            foreach (var keyword in keywords)
            {
                Thread.Sleep(5000);
                HashSet<string> lstDomain = this.GetDomain(keyword);
                foreach (var VARIABLE in lstDomain)
                {
                  
                    if (!hsDomains.Contains(VARIABLE))
                        hsDomains.Add(VARIABLE);}
            }
            string fullDomains = string.Join("\n", hsDomains.ToList());
            Console.Write(fullDomains);
            return hsDomains;
        }

        private HashSet<string> GetDomain(string keywords)
        {
            HashSet<string> lst = new HashSet<string>();
            for (int i = 0; i < page; i++)
            {
                string url = string.Format(patternUrl, numInPage, i*numInPage, keywords.Replace(" ", "+"));
                //url = System.Web.HttpUtility.UrlEncode(url);
                string html =
                    System.Web.HttpUtility.HtmlDecode(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2));

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(html);

                string xpath = "//div[@class='srg']//div[@class='g']//a[@href]";
                var nodesSite = htmlDocument.DocumentNode.SelectNodes(xpath);

                if (nodesSite != null)
                {
                    foreach (var VARIABLE in nodesSite)
                    {
                        string directLink = System.Web.HttpUtility.UrlDecode(VARIABLE.GetAttributeValue("href", ""));
                        directLink = Common.GetAbsoluteUrl(directLink, new Uri("http://google.com"));
                        Uri uri = new Uri(directLink);
                        string siteUrl = Common.GetDomainFromUrl(uri.Host);
                        if (!lst.Contains(siteUrl)) lst.Add(uri.Scheme + "://" + uri.Host);
                    }
                }}

            return lst;
        }
    }
}
