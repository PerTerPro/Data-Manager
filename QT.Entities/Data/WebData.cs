
using log4net;
using QT.Entities.MyConverter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
namespace QT.Entities.Data
{
    public class WebDataH
    {
        public static string GetHtmlFromUrl(string url, bool UseClearHtml, int timeOut = 15, int loopTry = 2)
        {
            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, timeOut, loopTry);
            if (html != "")
            {
                if (UseClearHtml)
                {
                    html = QT.Entities.Common.TidyCleanR(html);
                }
                GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                html = html.Replace("<form", "<div");
                html = html.Replace("</form", "</div");
            }
            return html;
        }
    }
}