using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.FindProxy
{
    public class FactoryConfigWebsite
    {
        static FactoryConfigWebsite  _instance = null;
        public static FactoryConfigWebsite Instance()
        {
            return (_instance == null) ? _instance = new FactoryConfigWebsite() : _instance;
        }
        public List<ConfigWebsite> GetListConfigWebsite()
        {
            List<ConfigWebsite> lst = new List<ConfigWebsite>();
            lst.Add(new ConfigWebsite()
                {
                    RootLinks = new List<string>() { 
                        @"http://www.proxy4free.com/list/webproxy1.html",
                         @"http://www.proxy4free.com/list/webproxy2.html",
                          @"http://www.proxy4free.com/list/webproxy3.html",
                           @"http://www.proxy4free.com/list/webproxy4.html", 
                            @"http://www.proxy4free.com/list/webproxy5.html"},
                    XPath = @"//tbody//tr//a[@target='_blank']/@href"
                });
            return lst;
        }
    }

    public class ConfigWebsite
    {
        public string XPath { get; set; }

        public List<string> RootLinks { get; set; }
    }
}