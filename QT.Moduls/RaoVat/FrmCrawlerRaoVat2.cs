using QT.Entities;
using QT.Entities.Model.SaleNews;
using QT.Entities.RaoVat;
using QT.Moduls.CrawlSale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.RaoVat
{
    public partial class FrmCrawlerRaoVat2 : Form
    {
        public int RunnerCrawlerID = 0;
        private QT.Moduls.RaoVat.ProductSaleNewAdapter adapterProduct = null;
        private Entities.RaoVat.RunnerCrawler RunnerCrawler = null;
        private QT.Entities.RaoVat.ConfigXPaths configXPath = null;
        private QT.Entities.RaoVat.RaoVatSQLAdapter raovatSqlAdapter = null;
        private QT.Entities.RaoVat.WebsiteRaoVat websiteRaoVat = null;
        private MongoDbRaoVat mongoDbAdapter = null;
        private bool Pause = false;
        private Thread threadStart;
        private int ProductCount = 0;

        public FrmCrawlerRaoVat2()
        {
            InitializeComponent();
        }

        public FrmCrawlerRaoVat2 (int RunnerCrawlerID)
        {
            InitializeComponent();

            this.raovatSqlAdapter = new RaoVatSQLAdapter(new Entities.Data.SqlDb(QT.Entities.Server.ConnectionStringCrawler));
            this.RunnerCrawlerID = RunnerCrawlerID;
            this.adapterProduct = new ProductSaleNewAdapter(new Entities.Data.SqlDb(QT.Entities.Server.ConnectionStringCrawler));
            this.RunnerCrawler = adapterProduct.GetRunnerCrawler(this.RunnerCrawlerID);
            this.Text = this.RunnerCrawler.name;
            this.websiteRaoVat = adapterProduct.GetWebSiteRaoVat(this.RunnerCrawler.website_id);
            this.configXPath = raovatSqlAdapter.GetConfigByID(this.websiteRaoVat.config_id);
            this.mongoDbAdapter = new MongoDbRaoVat();
            if (configXPath == null) this.Close();
           
        }

        private void FrmCrawlerRaoVat2_Load(object sender, EventArgs e)
        {

        }

        private void ShowQueue (int queue)
        {
            try
            {
                this.Invoke(new Action(() =>
                    {
                        this.spinQueueCount.Value = queue;
                    }));
            }
            catch (Exception ex01)
            {

            }
        }

        public void Start()
        {
            threadStart = new Thread(() => DoCrawler());
            threadStart.Start();
        }

        private void DoCrawler()
        {

            Dictionary<long, int[]> dicMapClassAndCategori = this.raovatSqlAdapter.GetDicMapClassificationAndCategories(this.websiteRaoVat.id);
            Dictionary<int, string[]> dicMapCity =  this.raovatSqlAdapter.GetDicCityAndRegex();

            while (true)
            {
                try
                {
                    int igone = 0;

                    //Khởi tạo.
                    Queue<JobCrawlerSale> queueUrl = new Queue<JobCrawlerSale>();
                    Dictionary<long, string> dicVisited = new Dictionary<long, string>();
                    foreach (var item in this.RunnerCrawler.root_link)
                    {
                        queueUrl.Enqueue(new JobCrawlerSale()
                            {
                                deep=0,
                                url=item
                            });
                    }
                    this.ShowQueue(queueUrl.Count);

                    while (!this.Pause && queueUrl != null && queueUrl.Count > 0)
                    {
                        JobCrawlerSale job = queueUrl.Dequeue();

                            ShowUrlCurrent(job.url);
                            ShowQueue(queueUrl.Count);

                            if (configXPath.TimeDelay > 0) Thread.Sleep(configXPath.TimeDelay);
                            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(job.url, 45, 2);
                            if (!string.IsNullOrEmpty(html))
                            {
                                GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                                doc.LoadHtml(html);

                                //Extraction.
                                var a_nodes = doc.DocumentNode.SelectNodes("//a[@href]");
                                if (a_nodes != null)
                                {
                                    foreach (var a_node in a_nodes)
                                    {
                                        string url1 = QT.Entities.Common.GetAbsoluteUrl(a_node.Attributes["href"].Value, this.websiteRaoVat.base_link);
                                        string compacLink = QT.Entities.Common.CompactUrl(url1);
                                        long s_crc = Math.Abs(GABIZ.Base.Tools.getCRC64(compacLink));
                                        if (!dicVisited.ContainsKey(s_crc))
                                        {
                                            dicVisited.Add(s_crc, "");
                                            ShowVisited(dicVisited.Count);
                                            
                                            bool bRegexProduct = QT.Entities.Common.CheckRegex(compacLink, configXPath.ProductUrlsRegex, configXPath.NoProductUrlRegex, false);
                                            bool bRegexExtract = QT.Entities.Common.CheckRegex(compacLink, configXPath.VisitUrlsRegex, configXPath.NoVisitUrlRegex, false);
                                            if (bRegexExtract)
                                            {
                                                if (job.deep+1<this.RunnerCrawler.max_deep)
                                                {
                                                    queueUrl.Enqueue(new JobCrawlerSale()
                                                    {
                                                        url = url1,
                                                        deep = job.deep + 1
                                                    });
                                                    ShowQueue(queueUrl.Count);
                                                }
                                            }
                                            else 
                                            {
                                                if (bRegexProduct)
                                                {
                                                    queueUrl.Enqueue(new JobCrawlerSale()
                                                    {
                                                        url = url1,
                                                        deep = job.deep + 1
                                                    });
                                                    ShowQueue(queueUrl.Count);
                                                }
                                            }
                                        }
                                    }
                                }

                                //AnalysicData.
                                if (QT.Entities.Common.CheckRegex(
                                    QT.Entities.Common.CompactUrl(job.url), configXPath.ProductUrlsRegex, configXPath.NoProductUrlRegex, false))
                                {
                                    QT.Entities.RaoVat.HandlerContentOfHtml handlerContentHtml = new Entities.RaoVat.HandlerContentOfHtml();
                                    ProductSaleNew productSaleNew = new ProductSaleNew();
                                    handlerContentHtml.AnalyticsProductSaleNew(websiteRaoVat.domain, job.url, doc, configXPath
                                        , productSaleNew, dicMapClassAndCategori, dicMapCity);

                                    if (productSaleNew.IsDetailSucess)
                                    {
                                        //SaveClassification
                                        try
                                        {
                                            this.raovatSqlAdapter.SaveClassification(productSaleNew.website_id, productSaleNew.web_category);
                                        }
                                        catch (Exception ex01)
                                        {
                                        }

                                        if (!this.mongoDbAdapter.CheckExistsProductSalenew(productSaleNew.id))
                                        {
                                            this.mongoDbAdapter.InsertProduct(productSaleNew);
                                        }
                                        else
                                        {
                                            this.mongoDbAdapter.UpdateProduct(productSaleNew);
                                        }
                                        ShowProduct(productSaleNew);
                                    }
                                    else
                                    {
                                        ShowIgone(igone++);
                                    }
                                }
                        }
                    }

                    this.Invoke(new Action(() =>
                        {
                            richTextBox1.AppendText("\n\rWait to next run!");
                        }));

                    Thread.Sleep(10000);
                }
                catch (ThreadAbortException threadAbortException)
                {
                    return;
                }
            }
        }

        

        private void ShowProduct(ProductSaleNew productSaleNew)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    string s = string.Format("\n\r-----------------------\n\r   ID:{0} LastUpdate:{4} \n\r Name:{1}  \n\r  Price:{2}  \n\r Classification:{3}\n\r   Categories:{5}",
                        productSaleNew.id,
                        (productSaleNew.name.Length < 100) ? productSaleNew.name : productSaleNew.name.Substring(0, 100),
                        productSaleNew.price.ToString(),
                        (productSaleNew.web_category.Length < 100) ? productSaleNew.web_category : productSaleNew.web_category,
                        productSaleNew.source_updated_at.ToString("yyyy-MM-dd HH:mm:ss"),
                        Common.ConvertToString(productSaleNew.category_ids, "_")
                        );
                    this.richTextBox1.AppendText(s);

                    this.spinProduct.Value = this.ProductCount++;
                }));
            }
            catch (Exception ex02)
            {
            }
        }
        private void ShowUrlCurrent(string url)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    this.txtCurrentUrc.Text = url;
                }));
            }
            catch (Exception ex02)
            {
            }
        }

        private void ShowIgone(int p)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    this.spinIgone.Value = p;
                }));
            }
            catch (Exception ex02)
            {

            }
        }

        private void ShowAddes (int p)
        {
            try
            {
                this.Invoke(new Action(() =>
                    {
                        this.spinAdded.Value = p;
                    }));
            }
            catch (Exception ex01)
            {
            }
        }

        private void ShowVisited (int p)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    this.spinVisited.Value = p;
                }));
            }
            catch (Exception ex01)
            {
            }
        }
     

        private void ckPause_CheckedChanged(object sender, EventArgs e)
        {
            this.Pause = ckPause.Checked;
        }

        private void FrmCrawlerRaoVat2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadStart != null && threadStart.IsAlive) threadStart.Abort();
        }

      
    }
}
