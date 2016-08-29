using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WSS.RankKeyword
{
    public class MyXpath
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(MyXpath));
        /// <summary>
        /// Get list string from google.com by 1 xpath(regex)
        /// </summary>
        /// <param name="keywordsearch">từ khóa</param>
        /// <param name="xpath"></param>
        /// <param name="page">trang</param>
        /// <returns></returns>
        public static List<string> GetListStringFromGoogle(string keywordsearch, string xpath, int page)
        {
            //Random r = new Random();
            //Thread.Sleep(r.Next(15000, 20000));
            string url = "";
            if (page == 0)
            {
                url = "https://www.google.com.vn/search?q=";
            }
            else
                url = string.Format("https://www.google.com.vn/search?q={0}&btnG=T%C3%ACm+v%E1%BB%9Bi+Google&start={1}", System.Web.HttpUtility.UrlEncode(keywordsearch), (page * 10));
            //url += System.Web.HttpUtility.UrlEncode(keywordsearch)+"&start=" + (page * 10);
            //StringBuilder sb = new StringBuilder();
            List<string> listkeywords = new List<string>();
            try
            {
                Uri urlRoot = new Uri(url, UriKind.RelativeOrAbsolute);
                HttpWebRequest oReq = (HttpWebRequest)WebRequest.Create(urlRoot);
                oReq.AllowAutoRedirect = true; //Nếu gặp response code 300 hoặc 309 nó sẽ tự chuyển theo response.header['location']
                oReq.UserAgent = @"Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.87 Safari/537.36";
                oReq.Timeout = 3000;
                HttpWebResponse resp = (HttpWebResponse)oReq.GetResponse();
                //HttpWebResponse resp = (HttpWebResponse)GetResponseNoCache(urlRoot);
                var encoding = Encoding.GetEncoding(resp.CharacterSet);
                if (resp.ContentType.StartsWith("text/html", StringComparison.InvariantCultureIgnoreCase))
                {
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    var resultStream = resp.GetResponseStream();
                    doc.Load(resultStream, encoding);
                    #region Get Value
                    HtmlAgilityPack.HtmlNodeCollection node = doc.DocumentNode.SelectNodes(xpath);
                    if (node != null)
                    {
                        foreach (HtmlAgilityPack.HtmlNode item in node)
                        {
                            listkeywords.Add(item.InnerText);
                        }
                    }
                    #endregion
                    resultStream.Close();
                }
                resp.Close();
            }
            catch (Exception ex) {
                Log.Error("Error: ", ex);
                Thread.Sleep(1200000);
                return null;
            }
            return listkeywords;
        }
        public static WebResponse GetResponseNoCache(Uri uri)
        {
            // Set a default policy level for the "http:" and "https" schemes.
            HttpRequestCachePolicy policy = new HttpRequestCachePolicy(HttpRequestCacheLevel.Default);
            HttpWebRequest.DefaultCachePolicy = policy;
            // Create the request.
            WebRequest request = WebRequest.Create(uri);
            // Define a cache policy for this request only. 
            HttpRequestCachePolicy noCachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
            request.CachePolicy = noCachePolicy;
            WebResponse response = request.GetResponse();
            return response;
        }
        public static int CheckRankKeyword(string domain,string keyword,string xpath)
        {
            int result = 0;
            try
            {
                bool stop = false;
                int i = 0;
                while(!stop)
                {
                    var listdomain = GetListStringFromGoogle(keyword, xpath, i);
                    if (listdomain == null)
                    {
                        //return để restart Form
                        result = 9999;
                    }
                    for (int j = 0; j < listdomain.Count; j++)
                    {
                        if (listdomain[j].Contains(domain))
                        {
                            result = i * 10 + j;
                            stop = true;
                        }
                    }
                    if (i == 9) stop = true;
                    else i++;
                }
            }
            catch (Exception ex)
            {
                Log.Error("Check rank error...", ex);
            }
            return result;
        }


        public List<string> GetListUrlFromGoogle(string keywordsearch, string xpath, int page)
        {
            List<string> listkeywords = new List<string>();
            for (int i = 0; i < page; i++)
            {
                string url = "";
                if (page == 0)
                {
                    url = "https://www.google.com.vn/search?q=";
                }
                else
                    url = string.Format("https://www.google.com.vn/search?q={0}&btnG=T%C3%ACm+v%E1%BB%9Bi+Google&start={1}", System.Web.HttpUtility.UrlEncode(keywordsearch), (page * 10));
                try
                {
                    Uri urlRoot = new Uri(url, UriKind.RelativeOrAbsolute);
                    HttpWebRequest oReq = (HttpWebRequest)WebRequest.Create(urlRoot);
                    oReq.AllowAutoRedirect = true; //Nếu gặp response code 300 hoặc 309 nó sẽ tự chuyển theo response.header['location']
                    oReq.UserAgent = @"Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.87 Safari/537.36";
                    oReq.Timeout = 3000;
                    HttpWebResponse resp = (HttpWebResponse)oReq.GetResponse();
                    //HttpWebResponse resp = (HttpWebResponse)GetResponseNoCache(urlRoot);
                    var encoding = Encoding.GetEncoding(resp.CharacterSet);
                    if (resp.ContentType.StartsWith("text/html", StringComparison.InvariantCultureIgnoreCase))
                    {
                        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                        var resultStream = resp.GetResponseStream();
                        doc.Load(resultStream, encoding);
                        #region Get Value
                        HtmlAgilityPack.HtmlNodeCollection node = doc.DocumentNode.SelectNodes(xpath);
                        if (node != null)
                        {
                            foreach (HtmlAgilityPack.HtmlNode item in node)
                            {
                                listkeywords.Add(item.InnerText);
                            }
                        }
                        #endregion
                        resultStream.Close();
                    }
                    resp.Close();
                }
                catch (Exception ex)
                {
                    Log.Error("Error: ", ex);
                    Thread.Sleep(1200000);
                    return null;
                }
            }
            return listkeywords;
        }
    }
}
