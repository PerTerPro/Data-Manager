using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls;
using QT.Moduls.Crawler;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.QT_2ReportTableAdapters;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Core.Crawler;
using WorkerReload = WSS.Core.Crawler.WorkerReload;

namespace WSS.CrawlerProduct.Tool
{
    public class Program
    {
        private static void Main(string[] args)
        {

            WSS.Core.Crawler.RecoverProductLost.Service s = new Core.Crawler.RecoverProductLost.Service();
            Console.WriteLine("1. Push. 2.Transfer");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                Console.WriteLine("Input start ID");
                int startId = Convert.ToInt32(Console.ReadLine());
                s.PushToRedis(startId);
            }
            else if (i == 2)
                s.TransferData(0);
            return;

            //   return;
            //   Server.ConnectionString = ConfigCrawler.ConnectProduct;
            //   Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler;
            //   Server.LogConnectionString = ConfigCrawler.ConnectLog;
            //   ProductAdapter productAdapter = new ProductAdapter(new SqlDb(ConfigCrawler.ConnectProduct));

            //   string strParaInput = (args.Length == 0) ? Console.ReadLine() : string.Join(" ", args);
            ////  strParaInput = @"-c svptccache -u http://maxmobile.vn/dien-thoai/lg-g5-cu.html";

            //   ParameterManager p = ParameterManager.Parse(strParaInput);
            //   //p.SubCmd = "svptccache";
            //   if (p.SubCmd == "crlrl")
            //   {
            //       string domain = p.Parameters["dm"][0];
            //       long idCOmpany = productAdapter.GetCompanyIDFromDomain(domain);
            //       using (var worker = new WSS.Core.Crawler.WorkerReload(idCOmpany, new CancellationToken(), ""))
            //       {
            //           worker.StartCrawler();
            //       }
            //   }
            //   else if (p.SubCmd == "crlfn")
            //   {

            //   }
            //   else if (p.SubCmd == "fn")
            //   {
            //       long companyId = 7627466712688617332;
            //       WSS.Core.Crawler.WorkerFindNew w = new WSS.Core.Crawler.WorkerFindNew(companyId, new CancellationToken(false), "Test");
            //       w.StartCrawler();
            //   }
            //   else if (p.SubCmd == "svcudclss")
            //   {
            //       //var c = new ConsumerClassificationToSql();
            //       //c.StartConsume();
            //   }
            //   else if (p.SubCmd == "svptccache")
            //   {
            //       var c = new ConsumerProductChangeToCache();
            //       c.StartConsume();
            //   }
            //   else if (p.SubCmd == "svudprsql")
            //   {
            //       var c = new ConsumerProductChangeToSql();
            //       c.StartConsume();
            //   }
            //   else if (p.SubCmd == "prpt")
            //   {
            //       ProductAdapter pta = new ProductAdapter(new SqlDb(Server.ConnectionString));
            //       string url = p.Parameters["u"][0].ToString();
            //       url = "http://maxmobile.vn/dien-thoai/lg-g5-cu.html";
            //       Uri uri = new Uri(url);
            //       string domain = Common.GetDomainFromUrl(uri);
            //       long idCompanyId = pta.GetCompanyIdByDomain(domain);
            //       IDownloadHtml downloader = new DownloadHtmlCrawler();
            //       Configuration config = new Configuration();
            //       HtmlDocument htmlDocument = new HtmlDocument();
            //       var ext = new WebExceptionStatus();
            //       string html = downloader.GetHTML(url, 45, 2, out ext);
            //       htmlDocument.LoadHtml(html);
            //       ProductEntity pte = new ProductEntity();
            //       ProductParse ppr = new ProductParse();
            //       ppr.Analytics(pte, htmlDocument, url, config, domain);
            //   }
            //   //ConsumerSaveEndSession consumerSaveEndSession = new ConsumerSaveEndSession();
            //   //consumerSaveEndSession.StartConsume();






        }

    public void TransferProductIdToRedis()
        {

        }

        public void TransferProductToLogAddProduct()
        {
            ProducerBasic producerBasicLogAddProductg = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler), "CrawlerProduct.LogAddProduct.ToSql");

            string connectionDest = "";
            string connectionsource = "Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";

            HashSet<long> productCurrent = new HashSet<long>();
            SqlDb sqlDbDestion = new SqlDb(connectionDest);
            SqlDb sqlDbSource = new SqlDb(connectionsource);

            string queryGetProduct = @"select p.ID
From Product p
Inner Join Company c on p.Company = c.ID
Where c.Status =1
and c.DataFeedType = 0 
Order By p.ID";
            string queryGetProductInfo = "Select Company, ID, Name, DetailUrl From Product Where ID = {0}";
            string queryInsertData = "";

            sqlDbSource.ProcessDataTableLarge(queryGetProduct, 1000,
                (row) =>
                {
                    long ID = Common.Obj2Int64(row["ID"]);
                    string str = string.Format("select top 1 ID from Product_LogsAddProduct pl where pl.ID = {0}", ID);
                    if (sqlDbDestion.GetTblData(str, CommandType.Text, null).Rows.Count == 0)
                    {
                        DataTable tbl01 = sqlDbSource.GetTblData(string.Format(queryGetProductInfo, ID), CommandType.Text, null);
                        var row1 = tbl01.Rows[0];
                        sqlDbDestion.RunQuery(queryInsertData, CommandType.Text, new[]
                        {
                            SqlDb.CreateParamteterSQL("IDCompany", Common.Obj2Int64(row1["Company"]), SqlDbType.BigInt),
                            SqlDb.CreateParamteterSQL("IDProduct", Common.Obj2Int64(row1["ID"]), SqlDbType.BigInt),
                            SqlDb.CreateParamteterSQL("Name", Common.Obj2String(row1["Name"]), SqlDbType.NVarChar),
                            SqlDb.CreateParamteterSQL("URL", Common.Obj2String(row1["DetailUrl"]), SqlDbType.NVarChar)
                        });
                    }
                });
        }
    }



    internal class ParameterManager
    {
        public string SubCmd { get; set; }
        public Dictionary<string, string[]> Parameters { get; set; }
        internal static ParameterManager Parse(string strParaInput)
        {
            ParameterManager p = new ParameterManager();
            string[] arCmd = strParaInput.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var VARIABLE in arCmd)
            {
                string[] arPara = VARIABLE.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (arPara[0] == "c") p.SubCmd = arPara[1];
                else p.Parameters.Add(arPara[0], arPara.SubArray(1, arPara.Length - 1));

            }
            return p;
        }
    }
}
