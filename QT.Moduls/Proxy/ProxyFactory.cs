using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.Proxy
{
    public class ProxyFactory
    {
        public List<string> GetProxy()
        {
            List<string> lstProxy = new List<string>();
            foreach (ConfigWebsite configItem in FactoryConfigWebsite.Instance().GetListConfigWebsite())
            {
                foreach (string url in configItem.RootLinks)
                {
                    GABIZ.Base.HtmlAgilityPack.HtmlDocument document = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                    document.LoadHtml(GetHtmlCode(url));
                    var nodes = document.DocumentNode.SelectNodes(configItem.XPath);
                    if (nodes != null && nodes.Count > 0)
                    {
                        foreach (var aNode in nodes)
                        {
                            lstProxy.Add(aNode.Attributes["href"].Value.ToString());
                        }
                    }
                }
            }
            return lstProxy;
        }

        private string GetHtmlCode(string urlCurrent)
        {
            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(urlCurrent, 45, 2);
            html = html.Replace("<form", "<div");
            html = html.Replace("</form", "</div");
            return html;
        }
    }
}
