using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
    public class InstanceCrawler
    {
        static InstanceCrawler instance;
        public string UniqueInstance;

        public InstanceCrawler(string p)
        {
            // TODO: Complete member initialization
            this.UniqueInstance = p;
        }
        public static InstanceCrawler Instance
        {
            get
            {
                if (instance == null) instance = new InstanceCrawler(LocalIPAddress() + ":" + Guid.NewGuid().ToString().Substring(0, 4));
                return instance;
            }
        }

        public static string LocalIPAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }
    }
}
