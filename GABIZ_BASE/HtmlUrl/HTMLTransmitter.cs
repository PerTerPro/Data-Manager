using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using System.IO.Compression;
using GABIZ.Base.HtmlAgilityPack;

namespace GABIZ.Base.HtmlUrl
{
    public class HTMLTransmitter
    {
        #region Private methods
        public static string NormalHost(string s)
        {
            return Regex.Replace(s, @"^www\w*\.", "");
        }

        /// <summary>
        /// Get response from url
        /// </summary>
        /// <param name="charSetInput"></param>
        /// <param name="url"></param>
        /// <param name="TimeOutSeconds"></param>
        /// <param name="success"></param>
        /// <param name="charSet"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        private static string GetResponseString(string charSetInput, string url, int TimeOutSeconds, out bool success, out string charSet, out long size)
        {
            success = false;
            charSet = charSetInput;
            size = 0;
            if (url == null || url.Length == 0) { success = true; return ""; }

            string html = "";
            try
            {
                Uri requestURI = new Uri(url);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = TimeOutSeconds * 1000;  // 10 secs
                request.Proxy = null;
                //request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.15) Gecko/20110303 Firefox/3.6.15";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:9.0.1) Gecko/20100101 Firefox/9.0.1";
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                request.KeepAlive = true;
                //request.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.Reload);
                request.Referer = url;
                CookieContainer cc = new CookieContainer();
                request.CookieContainer = cc;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (NormalHost(response.ResponseUri.Host) != NormalHost(requestURI.Host)) { success = true; return ""; }
                    if (response.ResponseUri.AbsoluteUri != requestURI.AbsoluteUri && response.ContentLength < 5000 & response.ResponseUri.AbsoluteUri.Contains("404") && !requestURI.AbsoluteUri.Contains("404")) { success = true; return ""; }
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string contentType = response.ContentType.ToString().ToLower();
                        if (response.ContentType.ToString().Contains("text/html"))
                        {
                            Encoding x = null;
                            bool CharsetFound = false;
                            size = response.ContentLength;
                            if (size > 10000000) size = -1;

                            try
                            {
                                int index = response.ContentType.LastIndexOf("charset");
                                if (index != -1)
                                {
                                    charSet = response.ContentType.Substring(index + 7).Trim(new char[] { ' ', '=' }).ToLower();
                                    if (charSet != "")
                                    {
                                        x = Encoding.GetEncoding(charSet);
                                        CharsetFound = true;
                                    }
                                }
                                if (!CharsetFound)
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

                if (html != "")
                {
                    string RealCharset = "";
                    // Check real charset meta-tag in HTML
                    int CharsetStart = html.IndexOf("charset=");
                    HtmlDocument doc = new HtmlDocument();
                    doc.LoadHtml(html);
                    var xNode = doc.DocumentNode.SelectNodes("//meta[@content]");
                    if (xNode != null)
                    {
                        for (int i = 0; i < xNode.Count; i++)
                        {
                            string temp = xNode[i].Attributes["content"].Value;

                            int index = temp.IndexOf("charset");
                            if (index >= 0)
                            {
                                RealCharset = temp.Substring(index + 7).Trim(new char[] { ' ', '=' }).ToLower();
                                break;
                            }
                        }
                    }

                    if (RealCharset == "")
                    {
                        if (RealCharset != charSet && !(RealCharset == "utf-8" && charSet == ""))
                        {
                            charSet = RealCharset;

                            // get correct encoding
                            Encoding CorrectEncoding = Encoding.GetEncoding(RealCharset);

                            // read the web page again, but with correct encoding this time
                            //   create request
                            HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create(url);
                            request2.Timeout = TimeOutSeconds * 1000;  // 10 secs
                            request2.Proxy = null;
                            //request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.15) Gecko/20110303 Firefox/3.6.15";
                            request2.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:9.0.1) Gecko/20100101 Firefox/9.0.1";
                            request2.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                            request2.KeepAlive = true;
                            request2.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.Reload);
                            request2.Referer = url;
                            request2.CookieContainer = cc;


                            using (HttpWebResponse response = (HttpWebResponse)request2.GetResponse())
                            {
                                if (NormalHost(response.ResponseUri.Host) != NormalHost(requestURI.Host)) { success = true; return ""; }
                                if (response.ResponseUri.AbsoluteUri != requestURI.AbsoluteUri && response.ContentLength < 5000 & response.ResponseUri.AbsoluteUri.Contains("404") && !requestURI.AbsoluteUri.Contains("404")) { success = true; return ""; }
                                if (response.StatusCode == HttpStatusCode.OK)
                                {
                                    string contentType = response.ContentType.ToString().ToLower();
                                    if (contentType.Contains("text/html"))
                                    {
                                        using (Stream responseStream = GetStreamForResponse(response, TimeOutSeconds * 1000))
                                        {
                                            StreamReader reader;
                                            reader = new StreamReader(responseStream, CorrectEncoding);

                                            reader.CurrentEncoding.ToString();
                                            html = reader.ReadToEnd();
                                            //Crypto.DecompressString(
                                            reader.Dispose();
                                            responseStream.Dispose();
                                        }
                                    }
                                    success = true;
                                }
                                request2.Abort();
                                response.Close();
                                request2 = null;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                html = "";
                success = false;
            }
            if (size == -1)
            {
                try
                {
                    UnicodeEncoding unicode = new UnicodeEncoding();
                    size = unicode.GetByteCount(html);
                }
                catch (Exception)
                {
                    
                }
            }
            return html;
        }

        /// <summary>
        /// Get response from url
        /// </summary>
        /// <param name="url">url</param>
        /// <param name="TimeOutSeconds">Timeout in seconds</param>
        /// <param name="success">True if success</param>
        /// <returns>Corresponse html string</returns>
        private static string GetResponseString(string charSetInput, string url, int TimeOutSeconds, out bool success, out string charSet)
        {
            success = false;
            charSet = charSetInput;

            if (url == null || url.Length == 0) { success = true; return ""; }

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
                request.MaximumAutomaticRedirections = 50;
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (NormalHost(response.ResponseUri.Host) != NormalHost(requestURI.Host)) { success = true; return ""; }
                    if (response.ResponseUri.AbsoluteUri != requestURI.AbsoluteUri && response.ContentLength < 5000 & response.ResponseUri.AbsoluteUri.Contains("404") && !requestURI.AbsoluteUri.Contains("404")) { success = true; return ""; }
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string contentType = response.ContentType.ToString().ToLower();
                        if (contentType.Contains("text/html"))
                        {
                            Encoding x = null;
                            bool CharsetFound = false;

                            try
                            {
                                int index = response.ContentType.LastIndexOf("charset");
                                if (index != -1)
                                {
                                    charSet = response.ContentType.Substring(index + 7).Trim(new char[] { ' ', '=' }).ToLower();
                                    if (charSet != "")
                                    {
                                        x = Encoding.GetEncoding(charSet);
                                        CharsetFound = true;
                                    }
                                }
                                if (!CharsetFound)
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
            catch (Exception)
            {
                html = "";
                success = false;
            }
            return html;
        }


        private static string GetResponseString(string charSetInput, string url, int TimeOutSeconds, out bool success, out string charSet, IWebProxy _proxy)
        {
            success = false;
            charSet = charSetInput;

            if (url == null || url.Length == 0) { success = true; return ""; }

            string html = "";
            try
            {
                Uri requestURI = new Uri(url);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = TimeOutSeconds * 1000;  // 10 secs
                request.Proxy = _proxy;
                //request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.15) Gecko/20110303 Firefox/3.6.15";
                //request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:9.0.1) Gecko/20100101 Firefox/9.0.1";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20130406 Firefox/23.0";

                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                request.KeepAlive = true;
                //request.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.Reload);
                request.Referer = url;
                CookieContainer cc = new CookieContainer();
                request.CookieContainer = cc;
                request.MaximumAutomaticRedirections = 50;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {

                    if (NormalHost(response.ResponseUri.Host) != NormalHost(requestURI.Host)) { success = true; return ""; }
                    if (response.ResponseUri.AbsoluteUri != requestURI.AbsoluteUri && response.ContentLength < 5000 & response.ResponseUri.AbsoluteUri.Contains("404") && !requestURI.AbsoluteUri.Contains("404")) { success = true; return ""; }
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string contentType = response.ContentType.ToString().ToLower();
                        if (contentType.Contains("text/html"))
                        {
                            Encoding x = null;
                            bool CharsetFound = false;

                            try
                            {
                                int index = response.ContentType.LastIndexOf("charset");
                                if (index != -1)
                                {
                                    charSet = response.ContentType.Substring(index + 7).Trim(new char[] { ' ', '=' }).ToLower();
                                    if (charSet != "")
                                    {
                                        x = Encoding.GetEncoding(charSet);
                                        CharsetFound = true;
                                    }
                                }
                                if (!CharsetFound)
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

                if (html != "")
                {
                    string RealCharset = "";
                    // Check real charset meta-tag in HTML
                    int CharsetStart = html.IndexOf("charset=");
                    HtmlDocument doc = new HtmlDocument();
                    doc.LoadHtml(html);
                    var xNode = doc.DocumentNode.SelectNodes("//meta[@content]");
                    if (xNode != null)
                    {
                        for (int i = 0; i < xNode.Count; i++)
                        {
                            string temp = xNode[i].Attributes["content"].Value;

                            int index = temp.IndexOf("charset");
                            if (index >= 0)
                            {
                                RealCharset = temp.Substring(index + 7).Trim(new char[] { ' ', '=' }).ToLower();
                                break;
                            }
                        }
                    }

                    if (RealCharset != "")
                    {
                        if (RealCharset != charSet && !(RealCharset == "utf-8" && charSet == ""))
                        {
                            charSet = RealCharset;

                            // get correct encoding
                            Encoding CorrectEncoding = Encoding.GetEncoding(RealCharset);

                            // read the web page again, but with correct encoding this time
                            //   create request
                            HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create(url);
                            request2.Timeout = TimeOutSeconds * 1000;  // 10 secs
                            request2.Proxy = null;
                            //request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.15) Gecko/20110303 Firefox/3.6.15";
                            request2.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:9.0.1) Gecko/20100101 Firefox/9.0.1";
                            request2.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                            request2.KeepAlive = true;
                            request2.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.Reload);
                            request2.Referer = url;
                            request2.CookieContainer = cc;


                            using (HttpWebResponse response = (HttpWebResponse)request2.GetResponse())
                            {
                                if (NormalHost(response.ResponseUri.Host) != NormalHost(requestURI.Host)) { success = true; return ""; }
                                if (response.ResponseUri.AbsoluteUri != requestURI.AbsoluteUri && response.ContentLength < 5000 & response.ResponseUri.AbsoluteUri.Contains("404") && !requestURI.AbsoluteUri.Contains("404")) { success = true; return ""; }
                                if (response.StatusCode == HttpStatusCode.OK)
                                {
                                    string contentType = response.ContentType.ToString().ToLower();
                                    if (response.ContentType.ToString().Contains("text/html"))
                                    {
                                        using (Stream responseStream = GetStreamForResponse(response, TimeOutSeconds * 1000))
                                        {
                                            StreamReader reader;
                                            reader = new StreamReader(responseStream, CorrectEncoding);

                                            reader.CurrentEncoding.ToString();
                                            html = reader.ReadToEnd();
                                            //Crypto.DecompressString(
                                            reader.Dispose();
                                            responseStream.Dispose();
                                        }
                                    }
                                    success = true;
                                }
                                request2.Abort();
                                response.Close();
                                request2 = null;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                html = "";
                success = false;
            }
            return html;
        }

        /// <summary>
        /// Get response from url
        /// </summary>
        /// <param name="url">url</param>
        /// <param name="TimeOutSeconds">Timeout in seconds</param>
        /// <param name="success">True if success</param>
        /// <returns>Corresponse html string</returns>
        public static string GetResponseString(string charSetInput, string url
            , int TimeOutSeconds
            , out bool success
            , out string charSet
            , out WebExceptionStatus status)
        {
            status = WebExceptionStatus.Success;
            success = false;
            charSet = charSetInput;

            if (url == null || url.Length == 0) { success = true; return ""; }

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
                            bool CharsetFound = false;

                            try
                            {
                                int index = response.ContentType.LastIndexOf("charset");
                                if (index != -1)
                                {
                                    charSet = response.ContentType.Substring(index + 7).Trim(new char[] { ' ', '=' }).ToLower();
                                    if (charSet != "")
                                    {
                                        x = Encoding.GetEncoding(charSet);
                                        CharsetFound = true;
                                    }
                                }
                                if (!CharsetFound)
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

                if (html != "")
                {
                    string RealCharset = "";
                    // Check real charset meta-tag in HTML
                    int CharsetStart = html.IndexOf("charset=");
                    HtmlDocument doc = new HtmlDocument();
                    doc.LoadHtml(html);
                    var xNode = doc.DocumentNode.SelectNodes("//meta[@content]");
                    if (xNode != null)
                    {
                        for (int i = 0; i < xNode.Count; i++)
                        {
                            string temp = xNode[i].Attributes["content"].Value;

                            int index = temp.IndexOf("charset");
                            if (index >= 0)
                            {
                                RealCharset = temp.Substring(index + 7).Trim(new char[] { ' ', '=' }).ToLower();
                                break;
                            }
                        }
                    }

                    if (RealCharset != "")
                    {
                        if (RealCharset != charSet && !(RealCharset == "utf-8" && charSet == ""))
                        {
                            charSet = RealCharset;

                            // get correct encoding
                            Encoding CorrectEncoding = Encoding.GetEncoding(RealCharset);

                            // read the web page again, but with correct encoding this time
                            //   create request
                            HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create(url);
                            request2.Timeout = TimeOutSeconds * 1000;  // 10 secs
                            request2.Proxy = null;
                            //request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.15) Gecko/20110303 Firefox/3.6.15";
                            request2.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:9.0.1) Gecko/20100101 Firefox/9.0.1";
                            request2.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                            request2.KeepAlive = true;
                            request2.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.Reload);
                            request2.Referer = url;
                            request2.CookieContainer = cc;


                            using (HttpWebResponse response = (HttpWebResponse)request2.GetResponse())
                            {
                                if (NormalHost(response.ResponseUri.Host) != NormalHost(requestURI.Host)) { success = true; return ""; }
                                if (response.ResponseUri.AbsoluteUri != requestURI.AbsoluteUri && response.ContentLength < 5000 & response.ResponseUri.AbsoluteUri.Contains("404") && !requestURI.AbsoluteUri.Contains("404")) { success = true; return ""; }
                                if (response.StatusCode == HttpStatusCode.OK)
                                {
                                    string contentType = response.ContentType.ToString().ToLower();
                                    if (response.ContentType.ToString().Contains("text/html"))
                                    {
                                        using (Stream responseStream = GetStreamForResponse(response, TimeOutSeconds * 1000))
                                        {
                                            StreamReader reader;
                                            reader = new StreamReader(responseStream, CorrectEncoding);

                                            reader.CurrentEncoding.ToString();
                                            html = reader.ReadToEnd();
                                            //Crypto.DecompressString(
                                            reader.Dispose();
                                            responseStream.Dispose();
                                        }
                                    }
                                    success = true;
                                }
                                request2.Abort();
                                response.Close();
                                request2 = null;
                            }
                        }
                    }
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

        /// <summary>
        /// Read compressed content
        /// </summary>
        /// <param name="webResponse">Web reponse</param>
        /// <param name="readTimeOut">Timeout</param>
        /// <returns>Corresponse stream</returns>
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
        #endregion Private methods

        #region Public methods
        /// <summary>
        /// Get html from url with number of try loop
        /// </summary>
        /// <param name="charsetInput">Input charset encoding</param>
        /// <param name="url">URL</param>
        /// <param name="TimeOutSeconds">Timeout in seconds</param>
        /// <param name="loopTry">Try loop</param>
        /// <param name="success">Connect success status</param>
        /// <param name="charset">Output charset</param>
        /// <param name="size">Download size</param>
        /// <returns>Corressponse html string</returns>
        public static string getHTML(string charsetInput, string url, int TimeOutSeconds, int loopTry, out bool tranferSuccess, out string charset, out long size)
        {
            string html = "";
            size = 0;
            charset = charsetInput;
            int tryLoop = 0;
            bool success = false;
            while (html == "" && !success && tryLoop < loopTry)
            {
                html = GetResponseString(charsetInput, url, TimeOutSeconds, out success, out charset, out size);
                tryLoop++;
            }
            tranferSuccess = success;
            return html;
        }

        public static string getHTML(string charsetInput, string url, int TimeOutSeconds, int loopTry, out bool tranferSuccess, out string charset)
        {
            string html = "";
            charset = charsetInput;
            int tryLoop = 0;
            bool success = false;
            while (html == "" && !success && tryLoop < loopTry)
            {
                html = GetResponseString(charsetInput, url, TimeOutSeconds, out success, out charset);
                tryLoop++;
            }
            tranferSuccess = success;
            return html;
        }

      

        public static string getHTML(string url, int TimeOutSeconds, int loopTry)
        {
            string html = "";
            string charset = "";
            int tryLoop = 0;
            bool success = false;
            while (html == "" && !success && tryLoop < loopTry)
            {
                html = GetResponseString("", url, TimeOutSeconds, out success, out charset);
                tryLoop++;
            }
            if (success == false)
            {
                html = "";
            }

            return html;
        }

        public static string getHTML(string url, int TimeOutSeconds, int loopTry, out WebExceptionStatus status)
        {
            status = WebExceptionStatus.Success;
            string html = "";
            string charset = "";
            int tryLoop = 0;
            bool success = false;
            while (html == "" && !success && tryLoop < loopTry)
            {
                html = GetResponseString("", url, TimeOutSeconds, out success, out charset, out status);
                tryLoop++;
            }
            if (success == false)
            {
                html = "";
            }
            return html;
        }

        /// <summary>
        /// Get size of content in bytes
        /// </summary>
        /// <param name="requestURI">Request URI</param>
        /// <param name="TimeOutSeconds">Timeout in Seconds</param>
        /// <returns>Content length in bytes</returns>
        public static long SizeExploration(Uri requestURI, int TimeOutSeconds)
        {
            long size = 0;
            if (requestURI == null) { return -1; }

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestURI.AbsoluteUri);
                request.Method = WebRequestMethods.Http.Head;
                request.Timeout = TimeOutSeconds * 1000;  // 10 secs
                request.Proxy = null;
                request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.15) Gecko/20110303 Firefox/3.6.15";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        size = response.ContentLength;
                    }
                    response.Close();
                }
                request.Abort();
                request = null;
            }
            catch (Exception)
            {
                return -1;
            }
            return size;
        }

        /// <summary>
        /// Get size of content in bytes
        /// </summary>
        /// <param name="requestURI">Request URI</param>
        /// <param name="TimeOutSeconds">Timeout in Seconds</param>
        /// <returns>Content length in bytes</returns>
        public static long ImageSizeExploration(Uri requestURI, int TimeOutSeconds)
        {
            long size = 0;
            if (requestURI == null) { return -1; }

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestURI.AbsoluteUri);
                request.Method = WebRequestMethods.Http.Head;
                request.Timeout = TimeOutSeconds * 1000;  // 10 secs
                request.Proxy = null;
                request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.15) Gecko/20110303 Firefox/3.6.15";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        if (response.ContentType.ToString().Contains("image"))
                        {
                            size = response.ContentLength;
                        }
                    }
                    
                    response.Close();
                }
                request.Abort();
                request = null;
            }
            catch (Exception)
            {
                return -1;
            }
            return size;
        }
        #endregion Public methods

        //Connects to a URL and attempts to download the file
        public static byte[] DownloadData(string url)
        {
            url = url.Trim();
            if (url == "")
                return null;

            byte[] downloadedData = new byte[0];
            try
            {
                //Get a data stream from the url
                WebRequest req = WebRequest.Create(url);
                WebResponse response = req.GetResponse();
                Stream stream = response.GetResponseStream();

                //Download in chuncks
                byte[] buffer = new byte[1024];

                //Get Total Size
                int dataLength = (int)response.ContentLength;

                //Download to memory
                //Note: adjust the streams here to download directly to the hard drive
                MemoryStream memStream = new MemoryStream();
                while (true)
                {
                    //Try to read the data
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                        break;
                    else
                        memStream.Write(buffer, 0, bytesRead);
                }

                //Convert the downloaded stream to a byte array
                downloadedData = memStream.ToArray();

                //Clean up
                stream.Close();
                memStream.Close();
            }
            catch (Exception)
            {
                return null;
            }
            return downloadedData;
        }

        public static string getHtmlNomarlTag (string html)
        {

                html = html.Replace("<form", "<div");
                html = html.Replace("</form", "</div");
                return html;

        }

        public static string getHTML(string url, int TimeOutSeconds, int loopTry, bool bDecode = false)
        {
            string html = "";
            string charset = "";
            int tryLoop = 0;
            bool success = false;
            while (html == "" && !success && tryLoop < loopTry)
            {
                html = GetResponseString("", url, TimeOutSeconds, out success, out charset);
                tryLoop++;
            }
            if (success == false)
            {
                html = "";
            }
            return (bDecode) ? html : System.Web.HttpUtility.HtmlDecode(html);
        }

        public static string getHTML(string url, int TimeOutSeconds, int loopTry, IWebProxy _proxy)
        {
            string html = "";
            string charset = "";
            int tryLoop = 0;
            bool success = false;
            while (html == "" && !success && tryLoop < loopTry)
            {
                html = GetResponseString("", url, TimeOutSeconds, out success, out charset, _proxy);
                tryLoop++;
            }
            if (success == false)
            {
                html = "";
            }

            return html;
        }
    }
}
