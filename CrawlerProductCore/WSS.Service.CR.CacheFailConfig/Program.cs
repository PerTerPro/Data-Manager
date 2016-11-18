using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using WSS.Core.Crawler;

namespace WSS.Service.CR.CacheFailConfig{
    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker();
            w.Start();
        }
    }
}
