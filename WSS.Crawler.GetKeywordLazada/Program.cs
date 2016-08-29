using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crawler.GetKeywordLazada
{
    class Program
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
        List<string> lstRegexOK = new List<string>();
        List<string> lstRegexIgone = new List<string>();
        List<string> lstRegexProduct = new List<string>();
        SqlDb sqlDb = new SqlDb(@"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");

        Dictionary<long, bool> addedQueue = new Dictionary<long, bool>();

        public Program()
        {
            log.Info("Test");
            lstRegexOK.AddRange(new List<string> { @"http://www.lazada.vn/.*sort=.*", @"^http://www.lazada.vn/.*/$" });
            lstRegexIgone.AddRange(new List<string> { @".*\.html" });
            lstRegexProduct.AddRange(new List<string> { @"http://www.lazada.vn/.*sort=.*" });
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            //p.StartCrawler();

            //p.StartLoadData();
            p.AddCategoryName();
        }
        private void AddCategoryName()
        {
            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            DataTable tblCategory = sqlDb.GetTblData("select * from Category_Lazada");

            foreach (DataRow RowInfo in tblCategory.Rows)
            {

                long ID = QT.Entities.Common.Obj2Int64(RowInfo["ID"]);
                string url = QT.Entities.Common.Obj2String(RowInfo["Url"]);

                string xpathName = "//li[@class='last-child']//span[@class='header-breadcrumb__element']";
                doc.LoadHtml(this.GetHtml(url));
                var nodes = doc.DocumentNode.SelectNodes(xpathName);

                if (nodes!=null)
                {
                    foreach (var node in nodes)
                    {
                        int count = nodes.Count;
                        string name = node.InnerText.ToString();
                        sqlDb.RunQuery("Update Category_Lazada set CategoryName = @CategoryName where ID = @ID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                        sqlDb.CreateParamteter("@CategoryName",name,SqlDbType.NVarChar),
                        sqlDb.CreateParamteter("@ID",ID,SqlDbType.BigInt)
                    });
                    }
                }
                
                Console.WriteLine("Success: " + ID);
            }
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
        private void StartLoadData()
        {
            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            string XpathKeywords = @"//meta[@name='keywords']/@content";
            string XpathDescription = @"//meta[@name = 'description']/@content";
            string XpathTitle = @"//title/text()";
            DataTable tblCategoryLazada = null;
            tblCategoryLazada = sqlDb.GetTblData("Select * from Category_Lazada where Title is null");
            foreach (DataRow RowInfo in tblCategoryLazada.Rows)
            {
                long ID = QT.Entities.Common.Obj2Int64(RowInfo["ID"]);
                string url = RowInfo["Url"].ToString().Trim();
                doc.LoadHtml(this.GetHtml(url));


                string keyword = "";
                string description = "";
                string title = "";

                var keyNodes = doc.DocumentNode.SelectNodes(XpathKeywords);
                if (keyNodes != null)
                    foreach (var key in keyNodes)
                    {
                        keyword = key.Attributes["content"].Value.ToString();
                    }
                var desNodes = doc.DocumentNode.SelectNodes(XpathDescription);
                if (desNodes != null)
                    foreach (var des in desNodes)
                    {
                        description = des.Attributes["content"].Value.ToString();
                    }
                var titNodes = doc.DocumentNode.SelectNodes(XpathTitle);
                if (titNodes != null)
                    foreach (var tit in titNodes)
                    {
                        title = tit.InnerText.ToString();
                    }
                sqlDb.RunQuery("Update Category_Lazada set Title = @Title,Keyword = @Keyword,Description = @Description where ID = @ID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                    sqlDb.CreateParamteter("@Title",title,SqlDbType.NVarChar),
                    sqlDb.CreateParamteter("@Keyword",keyword,SqlDbType.NVarChar),
                    sqlDb.CreateParamteter("@Description",description,SqlDbType.NVarChar),
                    sqlDb.CreateParamteter("ID",ID,SqlDbType.BigInt)
                });
                Console.WriteLine("Success: " + ID);
            }
            Console.WriteLine("Done!");
            Console.ReadLine();
            //Queue<QT.Moduls.Crawler.Job> queueWait = new Queue<QT.Moduls.Crawler.Job>();
            //LoadJob(queueWait);
            //do
            //{
            //    QT.Moduls.Crawler.Job jobData = queueWait.Dequeue();
            //    GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            //    doc.LoadHtml(this.GetHtml(jobData.url));
            //    var a_nodes = doc.DocumentNode.SelectNodes("//a[@href]");

            //    string xpathBreackcum = @"//div[@class='header__breadcrumb__wrapper']//li";
            //    foreach (var item in a_nodes)
            //    {

            //    }
            //}
            //while (queueWait.Count > 0);
        }

        private void LoadJob(Queue<QT.Moduls.Crawler.Job> queueWait)
        {
            throw new NotImplementedException();
        }

        private void StartCrawler()
        {
            Queue<QT.Moduls.Crawler.Job> queueWait = new Queue<QT.Moduls.Crawler.Job>();
            queueWait.Enqueue(new QT.Moduls.Crawler.Job()
                {
                    url = "http://www.lazada.vn",
                    ProductId = QT.Entities.Common.CrcProductID("http://www.lazada.vn")
                });
            Dictionary<long, string> dicVited = new Dictionary<long, string>();
            do
            {
                QT.Moduls.Crawler.Job jobData = queueWait.Dequeue();
                GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(this.GetHtml(jobData.url));
                //Extraction
                var a_nodes = doc.DocumentNode.SelectNodes("//a[@href]");
                if (a_nodes != null)
                {
                    List<string> lstLink = new List<string>();
                    foreach (var itemNode in a_nodes) lstLink.Add(itemNode.Attributes["href"].Value.ToString());
                    foreach (string aUrl in lstLink)
                    {
                        if (QT.Entities.Common.CheckRegex(aUrl, this.lstRegexOK, this.lstRegexIgone, false))
                        {
                            long LinkID = QT.Entities.Common.CrcProductID(aUrl);
                            bool bAdded = false;
                            addedQueue.TryGetValue(LinkID, out bAdded);
                            if (!bAdded)
                            {
                                this.addedQueue.Add(LinkID, true);
                                queueWait.Enqueue(new QT.Moduls.Crawler.Job()
                                    {
                                        ConfigID = 0,
                                        deep = jobData.deep + 1,
                                        ProductId = LinkID,
                                        url = aUrl
                                    });


                            }
                        }
                    }
                    //ProductAnalysic
                    if (QT.Entities.Common.CheckRegex(jobData.url, this.lstRegexProduct, null, true))
                    {
                        this.sqlDb.RunQuery("Insert into Category_Lazada (ID, Url) Values (@ID, @Url)", System.Data.CommandType.Text,
                            new System.Data.SqlClient.SqlParameter[]{
                                            SqlDb.CreateParamteterSQL("@ID",jobData.ProductId,System.Data.SqlDbType.BigInt),
                                            SqlDb.CreateParamteterSQL("@Url",jobData.url,System.Data.SqlDbType.NVarChar)
                                      }, true, 10);
                    }
                }
            }
            while (queueWait.Count > 0);
        }

        private string GetHtml(string urlCurrent)
        {
            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(urlCurrent, 45, 2);
            html = html.Replace("<form", "<div");
            html = html.Replace("</form", "</div");
            return html;
        }
    }
}
