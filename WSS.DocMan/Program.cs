using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using QT.Entities;

namespace WSS.DocMan
{
    class Program
    {
        private static void Main(string[] args)
        {
            //string str = "1. PushLinkParse. 2. RunWorkerProcess";
            //Console.WriteLine(str);
            //int a = Convert.ToInt32(Console.ReadLine());
            //switch (a)
            //{
            //    case 1:
            //        Test t = new Test();
            //        t.PushQueueAs();
            //        break;
            //    case 2:
            //        var v = new WorkerCrawler();
            //        v.StartConsume();
            //        break;
            //}
            //return;

            //    //var v = new WorkerCrawler();
            //    //v.StartConsume();
            //    //return;



            ////    Test t = new Test();
            ////    t.PushQueueAs();
            DocManAdapter docManAdapter = new DocManAdapter();
            string url = @"http://moj.gov.vn/vbpq/Lists/Vn%20bn%20php%20lut/View_Detail.aspx?ItemID=30517";
            url = @"http://moj.gov.vn/vbpq/Lists/Vn%20bn%20php%20lut/View_Detail.aspx?ItemID=6527";
            //url = @"http://moj.gov.vn/vbpq/Lists/Vn%20bn%20php%20lut/View_Detail.aspx?ItemID=20516#Chuong_I";

            url = @"http://moj.gov.vn/vbpq/Pages/View_Propertes.aspx?ItemID=8070";

            string html = System.Web.HttpUtility.HtmlDecode(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 42, 2));
            HtmlDocument htmlDocument = new HtmlDocument();
            html = Common.ChuanHoaTextOfHtml(html);
            htmlDocument.LoadHtml(html);

            htmlDocument.DocumentNode.Descendants()
                 .Where(n => n.Name == "script" || n.Name == "style")
                 .ToList()
                 .ForEach(n => n.Remove());

            Documet document = new Documet();

            //string urlInfo = @"http://moj.gov.vn/vbpq/Pages/View_Propertes.aspx?ItemID=3001";
            //HtmlDocument htmlDocumentInfo = new HtmlDocument();
            //htmlDocumentInfo.LoadHtml(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 42, 2));

            ParserData p = new ParserData();
            DocInfo docInfo = new DocInfo();
            //p.Parse(ref document, htmlDocument, url);
            DocInfo di = p.ParseInfoDoc(htmlDocument, url);
            Console.Write(di);
            if (document.IsValidData())
            {
                docManAdapter.InsertData(document);
            }
        }
    }
}
