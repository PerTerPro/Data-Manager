using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.CrawlerProductConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            QT.Moduls.CrawlerProduct.CrawlerProductReload crawlerProductReload = new QT.Moduls.CrawlerProduct.CrawlerProductReload();
            crawlerProductReload.Start();
        }
    }
}
