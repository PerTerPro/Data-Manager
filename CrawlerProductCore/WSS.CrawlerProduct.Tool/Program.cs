using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.Crawler;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.QT_2ReportTableAdapters;
using WSS.Core.Crawler;
using WorkerReload = WSS.Core.Crawler.WorkerReload;

namespace WSS.CrawlerProduct.Tool
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler;
            Server.LogConnectionString = ConfigCrawler.ConnectLog;
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(ConfigCrawler.ConnectProduct));

            string strParaInput = (args.Length == 0) ? Console.ReadLine() : string.Join(" ", args);
            strParaInput = @"-c svptccache -u http://maxmobile.vn/dien-thoai/lg-g5-cu.html";

            ParameterManager p = ParameterManager.Parse(strParaInput);
            //p.SubCmd = "svptccache";
            if (p.SubCmd == "crlrl")
            {
                string domain = p.Parameters["dm"][0];
                long idCOmpany = productAdapter.GetCompanyIDFromDomain(domain);
                using (var worker = new WorkerReload(idCOmpany, new CancellationToken(), "", true))
                {
                    worker.StartCrawler();
                }
            }
            else if (p.SubCmd == "crlfn")
            {

            }
            else if (p.SubCmd == "svcudclss")
            {
                var c = new ConsumerClassificationToSql();
                c.StartConsume();
            }
            else if (p.SubCmd == "svptccache")
            {
                var c = new ConsumerProductChangeToCache();
                c.StartConsume();
            }
            else if (p.SubCmd == "svudprsql")
            {
                var c = new ConsumerProductChangeToSql();
                c.StartConsume();
            }
            else if (p.SubCmd == "prpt")
            {
                ProductAdapter pta = new ProductAdapter(new SqlDb(Server.ConnectionString));
                string url = p.Parameters["u"][0].ToString();
                url = "http://maxmobile.vn/dien-thoai/lg-g5-cu.html";
                Uri uri = new Uri(url);
                string domain = Common.GetDomainFromUrl(uri);
                long idCompanyId = pta.GetCompanyIdByDomain(domain);
                IDownloadHtml downloader = new DownloadHtmlCrawler();
                Configuration config = new Configuration();
                HtmlDocument htmlDocument = new HtmlDocument();
                var ext = new WebExceptionStatus();
                string html = downloader.GetHTML(url, 45, 2, out ext);
                htmlDocument.LoadHtml(html);
                ProductEntity pte = new ProductEntity();
                ProductParse ppr = new ProductParse();
                ppr.Analytics(pte, htmlDocument, url, config, domain);
            }
            //ConsumerSaveEndSession consumerSaveEndSession = new ConsumerSaveEndSession();
            //consumerSaveEndSession.StartConsume();


        }

    }
}
