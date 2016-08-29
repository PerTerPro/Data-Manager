//using QT.Entities;
//using QT.Entities.Data;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace QT.Moduls.CrawlerProduct
//{
//    public class CrawlerProductReload
//    {
//        public delegate void ShowReport(string mss);
//        public ShowReport _eventLog;  

//        log4net.ILog log = log4net.LogManager.GetLogger(typeof(CrawlerProductReload));

//        ProductAdapter productAdapter = null;

//        private Entities.Company company = null;
//        private Entities.Configuration config = null;

//        List<Product> lstProductChange = new List<Product>();
//        List<long> lstPushChangeImageToMQ = new List<long>();
//        List<long> lstAddToBlackList = new List<long>();

//        Queue<QT.Moduls.Crawler.Job> crawlerLink = new Queue<QT.Moduls.Crawler.Job>();
//        List<long> visitedCRC = new List<long>();

//        DateTime dtStartCrawler = DateTime.Now;
//        DateTime dtStartRunInDb = DateTime.Now;
//        private CancellationTokenSource tokenSourceCrawler;

//        public void InitVariable ()
//        {
//            this.productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
//            this.tokenSourceCrawler = new CancellationTokenSource();
//        }
	
//        private void LoadProductNeedReload()
//        {
		
//            DataTable dtProduct = null;
//            do
//            {
//                dtProduct = productAdapter.GetNeedReloadProduct(company.ID, dtStartCrawler);
//                if (dtProduct == null) Thread.Sleep(1000);
//            } while (dtProduct == null);

//            for (int i = 0; i < dtProduct.Rows.Count; i++)
//            {
//                crawlerLink.Enqueue(new Crawler.Job()
//                {
//                    url = dtProduct.Rows[i]["DetailUrl"].ToString().Trim(),
//                    ProductId = Convert.ToInt64(dtProduct.Rows[i]["ID"].ToString())
//                });
//            }
//        }

//        public void Start()
//        {
//            int numberThread = 1;
//            InitVariable();
//            for (int i = 0; i < numberThread; i++)
//            {
//                int iCurrentThread = i;
//                var tokenCancell1 = this.tokenSourceCrawler.Token;
//                Task.Factory.StartNew(() =>
//                    {
//                        while (true)
//                        {
//                            log.Info(string.Format("Start run thread index:{0}", iCurrentThread));
//                            long CompanyID = this.productAdapter.GetCompanyIDNeedReload();
//                            TaskCrawlerReload task = new TaskCrawlerReload(CompanyID, tokenCancell1, iCurrentThread);
//                            task.StartCrawler();
//                        }
//                    }, tokenCancell1);
//            }
//        }

//        ~CrawlerProductReload()
//        {
//            if (!tokenSourceCrawler.IsCancellationRequested) tokenSourceCrawler.Cancel();
//        }


//        public void RunCrawler ()
//        {
            
//        }

//        private void SaveChangeProduct(List<Product> lstProductChange, ProductAdapter productAdapter, List<long> lstPushChangeImageToMQ)
//        {
//            productAdapter.UpdateListProductChangeToDb(lstProductChange);
//            productAdapter.PushProcessProductChangeImage(lstPushChangeImageToMQ, company.AllowAutoPushNewProduct);
//            foreach (var productChanged in lstProductChange)
//            {
//                if (!lstPushChangeImageToMQ.Contains(productChanged.ID))
//                {
//                    RabbitMQAdapter.Instance.PushProductToQueueChangeMainInfo(productChanged.ID);
//                }
//            }
//            lstProductChange.Clear();
//            lstPushChangeImageToMQ.Clear();
//        }


//        private string GetHtmlCode(string urlCurrent)
//        {
//            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(urlCurrent, 45, 2);
//            html = html.Replace("<form", "<div");
//            html = html.Replace("</form", "</div");
//            if (this.config.UseClearHtml)
//            {
//                html = Common.TidyCleanR(html);
//            }
//            return html;
//        }

//        public void Stop()
//        {
            
//        }
//    }
//}
