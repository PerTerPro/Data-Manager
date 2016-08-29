using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace WSS.AutoFindNewWebsite
{
    class Program
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
        public static FirefoxDriver fireFoxDriver;
        List<string> lstProxy = null;

        public Program ()
        {
            this.lstProxy = (new QT.Moduls.Proxy.ProxyFactory()).GetProxy();
        }

        static void Main(string[] args)
        {
            
            Program pg = new Program();
            pg.FindWithDB();

        }
        public void FindWithDB()
        {
            log.Info("Start find....");
            Dictionary<long, string> DicOldWeb = new Dictionary<long, string>();
            SqlDb SqlDbQT2 = new SqlDb(@"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
            DataTable tblWebsite = SqlDbQT2.GetTblData("Select * from findwebsite", CommandType.Text, new SqlParameter[] { });
            foreach (DataRow RowInfo in tblWebsite.Rows) DicOldWeb.Add(QT.Entities.Common.Obj2Int64(RowInfo["ID"]), "");

            while (true)
            {
                DataTable tblKeywordFind = SqlDbQT2.GetTblData("Select top 10 * from KeywordFindNewWebsite order by LastUseToFindWebsite asc");
                if (tblKeywordFind.Rows.Count > 0)
                {
                    foreach (DataRow RowInfo in tblKeywordFind.Rows)
                    {
                        int KeyWordID = QT.Entities.Common.Obj2Int(RowInfo["ID"]);
                        string Keyword = RowInfo["Keyword"].ToString();
                        Dictionary<string, string> dicKeyword = GetKeywordGoogleRelated(DicOldWeb, Keyword, @"//cite");
                        if (dicKeyword != null)
                        {
                            log.Info("Number website: " + dicKeyword.Count.ToString());
                            for (int i = 0; i < dicKeyword.Count; i++)
                            {
                                long ID = Convert.ToInt64(Math.Abs(GABIZ.Base.Tools.getCRC64(dicKeyword.ElementAt(i).Key.ToString())));

                                SqlDbQT2.RunQuery(@"if (not exists (select ID from Company where ID = @ID) 
                                                        and not exists(select ID from FindWebSite where ID = @ID)) 
                                                        begin 
                                                            insert into FindWebSite (ID, Domain, Website) Values (@ID, @Domain, @Website) 
                                                        end", CommandType.Text, new SqlParameter[] { 
                                 SqlDbQT2.CreateParamteter("@ID",ID,SqlDbType.BigInt),
                                 SqlDbQT2.CreateParamteter("@Domain",dicKeyword.ElementAt(i).Key,SqlDbType.NVarChar),
                                 SqlDbQT2.CreateParamteter("@Website",dicKeyword.ElementAt(i).Value,SqlDbType.NVarChar),
                                });

                                SqlDbQT2.RunQuery("update KeywordFindNewWebsite set WebsiteNumber = @WebsiteNumber, LastUseToFindWebsite = GETDATE() where ID = @ID", CommandType.Text, new SqlParameter[] { 
                                    SqlDbQT2.CreateParamteter("@WebsiteNumber",dicKeyword.Count,SqlDbType.Int),
                                    SqlDbQT2.CreateParamteter("@ID",KeyWordID,SqlDbType.Int)
                                });
                            }
                        }
                        log.Info("Complete find from keyword: " + Keyword);
                    }
                }
            }
        }
        private  List<string> LoadFileToList(string path)
        {
            Dictionary<string, string> DetailUrl = new Dictionary<string, string>();
            List<string> lstKeyword = new List<string>();
            foreach (var worksheet in Workbook.Worksheets(path))
                foreach (var row in worksheet.Rows)
                    foreach (var cell in row.Cells)
                    {
                        var a = cell;
                        if (cell != null)
                        {
                            lstKeyword.Add(cell.Text.Trim());
                        }
                    }
            return lstKeyword;
        }
        private  Dictionary<string, string> GetKeywordGoogleRelated(Dictionary<long, string> dicOldWeb, string keword, string p)
        {
            Regex regex = new Regex(@"([0-9A-Za-z]{2,}\.[comnet]{3}\.[vn]{2}|[0-9A-Za-z]{2,}\.[comvnet]{2,3})$");
            Dictionary<string, string> lstWebsite = new Dictionary<string, string>();
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(10000);
                while (true)
                {
                    if (fireFoxDriver == null) fireFoxDriver = new FirefoxDriver();
                    string x = "https://www.google.com.vn/search?q=" + System.Web.HttpUtility.UrlEncode(keword) + "&safe=off&start=" + (i * 10).ToString();
                    fireFoxDriver.Url = x;
                    int iMinuteWait = 1;
                    while (fireFoxDriver.Url.Contains(@"https://ipv4.google.com/sorry/IndexRedirect"))
                    {
                        Console.WriteLine(string.Format("Write {0}' to Run next", iMinuteWait.ToString()));
                        fireFoxDriver.Close();
                        Thread.Sleep(60000);
                        fireFoxDriver = new FirefoxDriver();
                        fireFoxDriver.Url = x;
                        fireFoxDriver.Manage().Cookies.DeleteAllCookies();
                    }
                    
                    var elements = fireFoxDriver.FindElementsByTagName("cite");
                    foreach (var element in elements)
                    {
                        string strLink = element.Text;
                        string domain = GetDomain(strLink);
                        long ID = Math.Abs(GABIZ.Base.Tools.getCRC64(domain));
                        string webste = GetWebsite(strLink);

                        if (!dicOldWeb.ContainsKey(ID) && !lstWebsite.ContainsKey(domain) && regex.IsMatch(domain))
                        {
                            lstWebsite.Add(domain, webste);
                        }
                        else
                        {
                        }

                    }
                    break;
                }
            }
            return lstWebsite;
        }
        public static List<string> GetWebsiteInGoogle(string Keyword)
        {
            string xpath = @"//div[@class='ads-visurl']/cite";
            string url = "https://www.google.com.vn/search?q=";
            StringBuilder sb = new StringBuilder();
            List<string> listLinks = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                url = "https://www.google.com.vn/search?q=" + System.Web.HttpUtility.UrlEncode(Keyword) + "&safe=off&start=" + (i * 10).ToString();
                try
                {
                    Uri urlRoot = new Uri(url, UriKind.RelativeOrAbsolute);
                    HttpWebRequest oReq = (HttpWebRequest)WebRequest.Create(urlRoot);
                    oReq.AllowAutoRedirect = true;
                    oReq.UserAgent = @"Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.22 (KHTML, like Gecko) Chrome/25.0.1364.152 Safari/537.22";
                    oReq.Timeout = 3000;
                    HttpWebResponse resp = (HttpWebResponse)oReq.GetResponse();
                    var encoding = Encoding.GetEncoding(resp.CharacterSet);
                    if (resp.ContentType.StartsWith("text/html", StringComparison.InvariantCultureIgnoreCase))
                    {
                        GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                        var resultStream = resp.GetResponseStream();
                        doc.Load(resultStream, encoding);
                        #region Get Value
                        GABIZ.Base.HtmlAgilityPack.HtmlNodeCollection node = doc.DocumentNode.SelectNodes(xpath);
                        if (node != null)
                        {
                            foreach (GABIZ.Base.HtmlAgilityPack.HtmlNode item in node)
                            {
                                string strLink = item.InnerText;
                                string Domain = QT.Entities.Common.GetDomainFromUrl(strLink);
                                string Website = QT.Entities.Common.GetWebsiteFromUrl(strLink);
                                listLinks.Add(strLink);
                            }
                        }
                        #endregion
                        resultStream.Close();
                    }
                    resp.Close();
                }
                catch (Exception ex01)
                {
                }
            }
            return listLinks;
        }
        
        private  string GetWebsite(string url)
        {
            return QT.Entities.Common.GetWebsiteFromUrl(url);
        }

        private  string GetDomain(string url)
        {
            return QT.Entities.Common.GetDomainFromUrl(url);
        }
    }

}
