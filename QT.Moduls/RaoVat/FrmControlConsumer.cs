
//using QT.Entities;
//using QT.Entities.AnaylysicData;
//using QT.Entities.RaoVat;
//using QT.Entities.Data;
//using QT.Entities.Data.SolrDb.SaleNews;
//using QT.Entities.Model.SaleNews;
//using QT.Moduls.Crawler;
//using QT.Moduls.CrawlSale;
//using RabbitMQ.Client;
//using StackExchange.Redis;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Diagnostics;
//using System.Drawing;
//using System.Drawing.Imaging;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using wssCommon = QT.Entities.Common;

//namespace WSS.CrawlerSale.Manager
//{
//    public partial class FrmControlConsumer : Form
//    {

//        int iMaxLengText = 1000000;

//        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmControlConsumer));

//        public bool IsNew;

//        List<Thread> listTrackThread = new List<Thread>();





//        private void FrmConfigXPath_Load(object sender, EventArgs e)
//        {
//            this.Text = QT.Entities.Server.ConnectionStringCrawler;
//            int iRunning = 0;
//            Process[] processes = Process.GetProcesses();
//            foreach (var proc in processes)
//            {
//                string strName = proc.ProcessName;
//                if (strName.Contains("WSS.CrawlerProduct.CrawlerConsumer"))
//                {
//                    iRunning++;
//                }
//            }
//            if (iRunning >= 2)
//            {
//                log.Info("Stop app because over instance running!");
//                this.Close();
//                return;
//            }

//            if (FrmQuestionAuto.GetQuestionRun(""))
//            {
//                this.btnStart.PerformClick();
//            }
//        }
//        private static ImageCodecInfo GetEncoderInfo(String mimeType)
//        {
//            int j;
//            ImageCodecInfo[] encoders;
//            encoders = ImageCodecInfo.GetImageEncoders();
//            for (j = 0; j < encoders.Length; ++j)
//            {
//                if (encoders[j].MimeType == mimeType)
//                    return encoders[j];
//            }
//            return null;
//        }
//        private string StringFromUrl(string url)
//        {
//            return "";
//            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
//            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
//            //Bitmap thumbBitmap = new Bitmap(response.GetResponseStream());
//            //thumbBitmap = new Bitmap(thumbBitmap, 160, 32);
//            //thumbBitmap.Save("trang.png");
//            //for (int i = 0; i < thumbBitmap.Width; i++)
//            //    for (int j = 0; j < thumbBitmap.Height; j++)
//            //    {
//            //        Color cell = thumbBitmap.GetPixel(i, j);
//            //        if (cell == Color.Transparent || (cell.A == 0 && cell.B == 0 && cell.G == 0 && cell.R == 0))
//            //        {
//            //            thumbBitmap.SetPixel(i, j, Color.Violet);
//            //        }
//            //    }
//            //thumbBitmap.Save(@"trang1.png");
//            //thumbBitmap = new Bitmap(@"trang1.png");

//            //ocr.SetVariable("tessedit_char_whitelist", "0123456789"); // If digit only
//            ////@"C:\OCRTest\tessdata" contains the language package, without this the method crash and app breaks
//            //ocr.Init(@"C:\Program Files (x86)\Tesseract-OCR", "eng", true);
//            //var result = ocr.DoOCR(thumbBitmap, Rectangle.Empty);
//            //string str = "";
//            //foreach (Word word in result)
//            //    str = str + word.Text;
//            //return str;
//        }














//        private void btnRemoveSolr_Click(object sender, EventArgs e)
//        {
//            string Webdomain = "raovat";
//            string URLSolrConnect = "http://118.70.205.94:9104/solr/raovat";
//            SolrRaoVatDriver.Init(new Dictionary<string, string> { { Webdomain, URLSolrConnect } });
//            var slr = SolrRaoVatDriver.GetDriver(SolrRaoVatDriver.GetInstance(Webdomain));
//            bool bOK = slr.RunQuery("is_crawled:true");
//            slr.Commit();
//            MessageBox.Show("Sucsses!");
//        }

//        private void btnLoadKeyWord_Click(object sender, EventArgs e)
//        {
//            DataTable tblKeyWord = this.productAdapter.GetTableKeyWord();
//            foreach (DataRow row in tblKeyWord.Rows)
//            {
//                int keyHash = Convert.ToInt32(row["KeyHash"]);
//                string keyWord = row["KeyName"].ToString();
//                int i = slr.CountOfKeyWord(keyWord);
//                this.productAdapter.SaveNumberKeyWordInProduct(keyHash, keyWord, i);
//            }
//            MessageBox.Show("OK");
//        }

//        private void button4_Click_2(object sender, EventArgs e)
//        {
//            DataTable tblKeyWord = this.productAdapter.GetTableKeyWordCategories();
//            foreach (DataRow row in tblKeyWord.Rows)
//            {
//                int keyHash = Convert.ToInt32(row["KeyHash"]);
//                string keyWord = row["KeyName"].ToString();
//                int i = slr.CountOfKeyWord(keyWord);
//                this.productAdapter.SaveNumberKeyWordInProduct(keyHash, keyWord, i);
//            }
//            MessageBox.Show("OK");
//        }


//        private void btnStartConsumer_Click(object sender, EventArgs e)
//        {
//            if (this.btnStart.Text == "Start")
//            {
//                txtProcessLink.Text = ""; ;
//                string nameQueueRun = queueNameTextBox.Text;
//                string nameQueueLog = txtQueueLog.Text;
//                this.connectMQ = RabbitMQCreator.CreateConnection();
//                int iCount = 0;
//                for (int i = 0; i < Convert.ToInt32(this.txtThreads.Value); i++)
//                {
//                    thread = new Thread(() => StartConsumer((iCount++).ToString(), nameQueueRun, nameQueueLog, connectMQ.CreateModel()));
//                    listTrackThread.Add(thread);
//                    thread.Start();
//                }
//                btnStart.Text = "Stop";
//            }
//            else
//            {

//                for (int i = lst.Count - 1; i >= 0; i--)
//                {
//                    if (lst[i] != null && !lst[i].IsDispose) lst[i].Dispose();
//                }
//                if (this.connectMQ != null && this.connectMQ.IsOpen) this.connectMQ.Close();
//                btnStart.Text = "Start";
//                MessageBox.Show("OK");
//            }
//        }



//        ConnectionFactory factoryMQ = null;






//        SqlDb sqlDb;
//        RaoVatSQLAdapter configXPathAdapter;
//        ProductSaleNewDataAdapter productAdapter;
//        //CassandraDb cassandraDb;

//        private SolrRaoVatDriver slr = null;
//        ManagerNameNameCrawler managerName = new ManagerNameNameCrawler();

//        public FrmControlConsumer()
//        {
//            InitializeComponent();

//            //cassandraDb = CassandraDb.Instance;
//            sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
//            configXPathAdapter = new RaoVatSQLAdapter(sqlDb);
//            productAdapter = new ProductSaleNewDataAdapter(sqlDb);
//        }


//        Thread thread = null;


//        public void StartConsumer(string nameOfConsumer, string queuName, string queueLog, IModel mode)
//        {
//            while (true)
//            {
//                try
//                {

//                    mode.BasicQos(0, 1, false);
//                    mode.QueueDeclare(queueLog, true, false, false, null);
//                    mode.QueueDeclare(queuName, true, false, false, null);

//                    var consumer = new ConsumerSaleNew(nameOfConsumer, mode, queuName);

//                    lst.Add(consumer); //Đẩy vào list để hủy khi dừng chạy.

//                    this.Invoke(new Action(() =>
//                    {
//                        this.txtProcessLink.AppendText(string.Format("\n Add consumer to list {0} ...", consumer.name));
//                    }));

//                    consumer.eventWhenAddQueue += new ConsumerSaleNew.EventWhenVisitedLink(delegate(object sender, string mss)
//                    {
//                        ConsumerSaleNew consumerSender = sender as ConsumerSaleNew;
//                        LogToMQ.WriteLog("eventWhenAddQueue", mode, consumerSender.IdUnique, queueLog, mss, "");
//                    });
//                    consumer.eventWhenGetExtractionLink += new ConsumerSaleNew.EventProcessLink(delegate(object sender, string mss)
//                    {
//                        ConsumerSaleNew consumerSender = sender as ConsumerSaleNew;
//                        LogToMQ.WriteLog("eventWhenGetExtractionLink", mode, consumerSender.IdUnique, queueLog, mss, "");
//                    });
//                    consumer.eventWhenGetProductLink += new ConsumerSaleNew.EventProcessLink(delegate(object sender, string mss)
//                    {
//                        ConsumerSaleNew consumerSender = sender as ConsumerSaleNew;
//                        LogToMQ.WriteLog("eventWhenGetProductLink", mode, consumerSender.IdUnique, queueLog, mss, "");
//                    });
//                    consumer.eventWhenStartConsumer += new ConsumerSaleNew.EventProcessLink(delegate(object sender, string mss)
//                    {
//                        ConsumerSaleNew consumerSender = sender as ConsumerSaleNew;
//                        LogToMQ.WriteLog("eventWhenStartConsumer", mode, consumerSender.IdUnique, queueLog, mss, "");
//                    });
//                    consumer.eventWhenAnalysisOK += new ConsumerSaleNew.EventWhenAnalysicedLink(delegate(object sender, string mss)
//                    {
//                        ConsumerSaleNew consumerSender = sender as ConsumerSaleNew;
//                        LogToMQ.WriteLog("eventWhenAnalysisOK", mode, consumerSender.IdUnique, queueLog, mss, "");
//                    });
//                    consumer.eventWhenDispose += new ConsumerSaleNew.EventProcessLink(delegate(object sender, string mss)
//                    {
//                        ConsumerSaleNew consumerSender = sender as ConsumerSaleNew;
//                        LogToMQ.WriteLog("eventWhenDispose", mode, consumerSender.IdUnique, queueLog, mss, "");
//                    });
//                    string exceptionError = consumer.StartConsumer();

//                    if (exceptionError == "")
//                    {
//                        break;
//                    }
//                }
//                catch (Exception ex)
//                {
//                    log.ErrorFormat(ex.Message);
//                    break;
//                }
//            }
//        }


//        public void StartConsumerStandrad(string nameOfConsumer, IConnection connection)
//        {
//        }

        
//        IConnection connectMQ;

//        private void FrmControlConsumer_FormClosing(object sender, FormClosingEventArgs e)
//        {
//            if (!this.btnStart.Enabled)
//            {
//                MessageBox.Show("Stop crawl before this form!");
//                e.Cancel = true;
//            }
//            else
//            {
//                if (this.connectMQ != null && this.connectMQ.IsOpen) this.connectMQ.Close();

//                foreach (var item in listTrackThread)
//                {
//                    if (item != null && item.IsAlive)
//                    {
//                        if (MessageBox.Show("Abort thread is alive?", "Question?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Cancel)
//                        {
//                            e.Cancel = true;
//                            break;
//                        }
//                        else
//                        {
//                            try
//                            {
//                                item.Abort();
//                            }
//                            catch (Exception ex)
//                            {
//                                MessageBox.Show(ex.Message);
//                            }
//                        }
//                    }
//                }

//            }
//        }


//        private void btnStopConsumer_Click(object sender, EventArgs e)
//        {

//        }




//        int iNumberProduct = 0;
//        private QT.Entities.Model.SaleNews.RedisDb redisDB;

//        public void FindStandardProduct(int iThread, IConnection connect)
//        {
//            //var redisMultiplexer = ConnectionMultiplexer.Connect(QT.Entities.Server.RedisDB_Host + ":" + QT.Entities.Server.RedisDB_Port);
//            //this.redisDB = new RedisDb(redisMultiplexer.GetDatabase());

//            //ConfigXPaths config = configXPathAdapter.GetConfigByID(10000);
//            //GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
//            //string str = @"http://www.edmunds.com/car-reviews/car-reviews-road-tests.html?page={0}&sort=date_desc&itemsPerPage=10";
//            //for (int i = 0; i < 1000; i++)
//            //{
//            //    string pageLink = string.Format(str, i);
//            //    long crcPageLink = Math.Abs(GABIZ.Base.Tools.getCRC64(pageLink));
//            //    this.Invoke(new Action(() =>
//            //    {
//            //        this.txtGetExtractionLink.AppendText(string.Format("\nThread {0}:Page:{1}", iThread, pageLink));
//            //    }));
//            //    if (redisDB.SetContains(RedisDb.Prefix_Set_VisitedLink + "10000", crcPageLink)) continue;

//            //    string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(pageLink, 45, 2, true);
//            //    doc.LoadHtml(html);

//            //    string partToLink = @"//div[@class='article-card']//a/@href";
//            //    var nodeToReviews = doc.DocumentNode.SelectNodes(partToLink);
//            //    if (nodeToReviews != null)
//            //    {
//            //        foreach (GABIZ.Base.HtmlAgilityPack.HtmlNode nodeToView in nodeToReviews)
//            //        {
//            //            try
//            //            {
//            //                string reviewLink = nodeToView.Attributes["href"].Value.ToString();
//            //                long crcReviewLink = Math.Abs(GABIZ.Base.Tools.getCRC64(reviewLink));
//            //                this.Invoke(new Action(() =>
//            //                {
//            //                    this.txtGetExtractionLink.AppendText(string.Format("\nThread {0}:Page:{1}", iThread, reviewLink));
//            //                }));

//            //                if (redisDB.SetContains(RedisDb.Prefix_Set_VisitedLink + "10000", crcReviewLink)) continue;
//            //                redisDB.SetAdd(RedisDb.Prefix_Set_VisitedLink + "10000", crcReviewLink.ToString());
//            //                reviewLink = Common.GetAbsoluteUrl(reviewLink, new Uri(@"http://www.edmunds.com"));
//            //                if (reviewLink.Contains("road-test.html")) continue;
//            //                string orginLink = reviewLink;
//            //                reviewLink = reviewLink.Replace(@"review/", @"?tab-id=specs-tab&sub=sedan");
//            //                string htmlReview = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(reviewLink, 45, 2, true);
//            //                if (string.IsNullOrEmpty(htmlReview))
//            //                {
//            //                    string reviewLink1 = orginLink.Replace(@"review/", @"?tab-id=specs-tab&sub=");
//            //                    htmlReview = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(reviewLink1, 45, 2, true);
//            //                }
//            //                else if (string.IsNullOrEmpty(htmlReview))
//            //                {
//            //                    continue;
//            //                }

//            //                if (!string.IsNullOrEmpty(htmlReview))
//            //                {
//            //                    GABIZ.Base.HtmlAgilityPack.HtmlDocument docReview = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
//            //                    docReview.LoadHtml(htmlReview);

//            //                    ProductSaleNew p = new QT.Entities.Model.SaleNews.ProductSaleNew();

//            //                    p.ID = Math.Abs(GABIZ.Base.Tools.getCRC64(Common.GetUrlNotSchemar(reviewLink)));
//            //                    List<string> lst = Common.GetTextInNode(docReview, @"//div[@id='header-title']//h1");
//            //                    p.title = (lst == null || lst.Count == 0) ? "" : lst[0].Replace("Features & Specs", "").Trim();
//            //                    p.url = reviewLink;
//            //                    p.images = Common.GetTextInNode(docReview, @"//div[@class='photo-wrap']//img/@src");
//            //                    p.post_date = DateTime.Now;
//            //                    p.last_change = DateTime.Now;
//            //                    p.web_category = hanlerContentOfHtml.GetWebCategory("", docReview, config);
//            //                    p.is_crawled = true;
//            //                    p.is_standard = true;
//            //                    p.config_crawl_id = 10000;
//            //                    p.CategoryID = 9;
//            //                    p.wss_last_update = DateTime.Now;
//            //                    p.Slug = Common.GetSplug(reviewLink) + "-" + p.ID.ToString();

//            //                    try
//            //                    {
//            //                        string linkImage = "";
//            //                        List<string> lstImage = new List<string>();
//            //                        linkImage = nodeToView.ParentNode.ParentNode.ParentNode.ChildNodes[1].ChildNodes[1].Attributes["onclick"].Value.ToString();
//            //                        linkImage = Regex.Match(linkImage, @"('.*,true)").Captures[0].Value.ToString();
//            //                        linkImage = linkImage.Substring(linkImage.IndexOf("'") + 1, linkImage.LastIndexOf("'") - linkImage.IndexOf("'") - 1);
//            //                        linkImage = Common.GetAbsoluteUrl(linkImage, new Uri(@"http://www.edmunds.com"));

//            //                    }
//            //                    catch (Exception ex)
//            //                    {
//            //                        log.InfoFormat("Error load imgae:{0}", ex.Message);
//            //                    }

//            //                    try
//            //                    {
//            //                        string price = @"//div[@data-selenium='estimated-pricing-no-pp-msrp']";
//            //                        List<string> lst1 = Common.GetTextInNode(docReview, price, null);
//            //                        string textPrice = (lst1 == null || lst1.Count == 0) ? "0" : lst1[0];
//            //                        decimal priceNomal = Common.ParsePrice(textPrice, false, true);
//            //                        string avangePrice = @"//div[@data-selenium='estimated-pricing-no-pp-average-price']";
//            //                        List<string> lst2 = Common.GetTextInNode(docReview, avangePrice, null);
//            //                        string textAvangePrice = (lst == null || lst.Count == 0) ? "0" : lst[0];
//            //                        decimal priceAgange = Common.ParsePrice(textAvangePrice, false, true);
//            //                        p.price = priceAgange;
//            //                        p.car_price_msrp = priceNomal.ToString();
//            //                    }
//            //                    catch (Exception ex)
//            //                    {
//            //                        log.InfoFormat("Error find price:{0}:{1}", ex.Message, p.url);
//            //                    }

//            //                    try
//            //                    {
//            //                        if (!orginLink.Contains(".html"))
//            //                        {
//            //                            string linkContent = orginLink + @"#leaderboard-reviews-3-anchor";
//            //                            string htmlContent = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(linkContent, 45, 2, true);
//            //                            if (!string.IsNullOrEmpty(htmlContent))
//            //                            {
//            //                                GABIZ.Base.HtmlAgilityPack.HtmlDocument docContent = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
//            //                                docContent.LoadHtml(htmlContent);
//            //                                p.content = (new HandlerContentOfHtml()).GetContent("", docContent, config);
//            //                                p.Excerpt = Common.ParseExcerpt(p.content);
//            //                            }
//            //                        }
//            //                    }
//            //                    catch (Exception ex)
//            //                    {
//            //                    }




//            //                    ConsumerStandardProduct consumer = new ConsumerStandardProduct("", factoryMQ.CreateConnection());
//            //                    bool bSave = consumer.SaveProduct(p);
//            //                    if (bSave)
//            //                    {
//            //                        this.Invoke(new Action(() =>
//            //                        {
//            //                            this.txtReportFindProduct.AppendText(string.Format("\n------------------->\nThread {0}:Saved:Product:{2}:{1}", iThread, p.ToString(), this.iNumberProduct++));
//            //                        }));
//            //                    }
//            //                    else
//            //                    {
//            //                        this.Invoke(new Action(() =>
//            //                        {
//            //                            this.richTextBoxError.AppendText(string.Format("\n------------------->\nThread {0}:NotSave:Product:{2}:{1}", iThread, p.ToString(), this.iNumberProduct++));
//            //                        }));
//            //                    }

//            //                }

//            //            }
//            //            catch (Exception ex)
//            //            {
//            //                MessageBox.Show(ex.Message);
//            //                log.InfoFormat("ERRROR PROUCT STANDARD:", ex.Message);
//            //            }
//            //        }

//            //    }

//            //    redisDB.SetAdd(RedisDb.Prefix_Set_VisitedLink + "10000", crcPageLink.ToString());
//            //}
//        }

//        private void btnLoadCategory_Click(object sender, EventArgs e)
//        {

//        }

//        private void button3_Click(object sender, EventArgs e)
//        {

//        }

//        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
//        {

//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            int iThread = 0;
//            for (int i = 0; i < 10; i++)
//            {
//                iThread++;
//                Thread th = new Thread(() => checkThread(iThread));
//                th.Start();
//            }
//        }

//        public void checkThread(int iThread)
//        {

//        }

//        private void xtraTabControl1_Click(object sender, EventArgs e)
//        {

//        }

//        private void btnShowLog_Click(object sender, EventArgs e)
//        {
//            FrmViewLogAllCompany frm = new FrmViewLogAllCompany();
//            frm.txtQueueLog.Text = txtQueueLog.Text;
//            frm.Show();
//        }

//        private void queueNameTextBox_KeyDown(object sender, KeyEventArgs e)
//        {
//            if (e.KeyCode==Keys.Enter)
//            {
//                txtQueueLog.Text = queueNameTextBox.Text + "_log";
//            }
//        }

//        private void panel1_Paint(object sender, PaintEventArgs e)
//        {

//        }
//    }
//}
