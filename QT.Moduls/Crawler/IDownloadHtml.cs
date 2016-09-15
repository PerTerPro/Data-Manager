using GABIZ.Base.HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QT.Moduls.Crawler
{
    public interface IDownloadHtml
    {
        //Test
        string GetHTML(string url, int secondsTimeOut, int numTry, out WebExceptionStatus status);
    }

    public class DownloadHtmlCrawler : IDownloadHtml
    {
        public string GetHTML(string url, int secondsTimeOut, int loopTry, out WebExceptionStatus status)
        {

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                   | SecurityProtocolType.Tls11
                                                   | SecurityProtocolType.Tls12
                                                   | SecurityProtocolType.Ssl3;

            status = WebExceptionStatus.Success;
            string html = "";
            string charset = "";
            int tryLoop = 0;
            bool success = false;
            while (html == "" && !success && tryLoop < loopTry)
            {
                html = GetResponseString("", url, secondsTimeOut, out success, out charset, out status);
                tryLoop++;
            }
            if (success == false)
            {
                html = "";
            }
            return html;
        }

     


        public  string GetResponseString(string charSetInput, string url
       , int TimeOutSeconds
       , out bool success
       , out string charSet
       , out WebExceptionStatus status)
        {
            status = WebExceptionStatus.Success;
            success = false;
            charSet = charSetInput;

            if (string.IsNullOrEmpty(url)) { success = true; return ""; }

            string html = "";
            try
            {
                Uri requestURI = new Uri(url);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = TimeOutSeconds * 1000;  // 10 secs
                request.Proxy = null;
                //request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.15) Gecko/20110303 Firefox/3.6.15";
                //request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:9.0.1) Gecko/20100101 Firefox/9.0.1";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20130406 Firefox/23.0";

                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                request.KeepAlive = true;
                //request.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.Reload);
                request.Referer = url;
                CookieContainer cc = new CookieContainer();
                request.CookieContainer = cc;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (NormalHost(response.ResponseUri.Host) != NormalHost(requestURI.Host)) { success = true; return ""; }
                    if (response.ResponseUri.AbsoluteUri != requestURI.AbsoluteUri && response.ContentLength < 5000 & response.ResponseUri.AbsoluteUri.Contains("503") && !requestURI.AbsoluteUri.Contains("503")) { success = true; return "-1"; }
                    if (response.ResponseUri.AbsoluteUri != requestURI.AbsoluteUri && response.ContentLength < 5000 & response.ResponseUri.AbsoluteUri.Contains("404") && !requestURI.AbsoluteUri.Contains("404")) { success = true; return "-2"; }
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string contentType = response.ContentType.ToString().ToLower();
                        if (contentType.Contains("text/html"))
                        {
                            Encoding x = null;
                            bool charsetFound = false;

                            try
                            {
                                int index = response.ContentType.LastIndexOf("charset", StringComparison.Ordinal);
                                if (index != -1)
                                {
                                    charSet = response.ContentType.Substring(index + 7).Trim(new char[] { ' ', '=' }).ToLower();
                                    if (charSet != "")
                                    {
                                        x = Encoding.GetEncoding(charSet);
                                        charsetFound = true;
                                    }
                                }
                                if (!charsetFound)
                                {
                                    if (charSet != "")
                                        try
                                        {
                                            x = Encoding.GetEncoding(charSet);
                                        }
                                        catch { }
                                }
                            }
                            catch { }

                            using (Stream responseStream = GetStreamForResponse(response, TimeOutSeconds * 1000))
                            {
                                StreamReader reader;
                                if (x == null)
                                    reader = new StreamReader(responseStream);
                                else
                                    reader = new StreamReader(responseStream, x);

                                reader.CurrentEncoding.ToString();
                                html = reader.ReadToEnd();
                                //Crypto.DecompressString(
                                reader.Dispose();
                                responseStream.Dispose();
                            }
                        }
                        success = true;
                    }
                    request.Abort();
                    response.Close();
                    request = null;
                }
            }
            catch (WebException ex1)
            {
                status = ex1.Status;
                html = "";
                success = false;
            }
            catch (Exception ex3)
            {
                html = "";
                success = false;
            }

            return html;
        }

        private static Stream GetStreamForResponse(HttpWebResponse webResponse, int readTimeOut)
        {
            Stream stream;
            switch (webResponse.ContentEncoding.ToUpperInvariant())
            {
                case "GZIP":
                    stream = new GZipStream(webResponse.GetResponseStream(), CompressionMode.Decompress);
                    break;
                case "DEFLATE":
                    stream = new DeflateStream(webResponse.GetResponseStream(), CompressionMode.Decompress);
                    break;

                default:
                    stream = webResponse.GetResponseStream();
                    stream.ReadTimeout = readTimeOut;
                    break;
            }
            return stream;
        }

        public static string NormalHost(string s)
        {
            return Regex.Replace(s, @"^www\w*\.", "");
        }

    }
}
