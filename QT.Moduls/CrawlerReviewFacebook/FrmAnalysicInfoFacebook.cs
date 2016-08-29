using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.CrawlerReviewFacebook;
using QT.Moduls.UtilSelenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerReviewFacebook
{
    public partial class FrmAnalysicInfoFacebook : Form
    {

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmAnalysicInfoFacebook));
        SqlDb sqlDb = new SqlDb(@"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=5000");
        FirefoxDriver driver = null;
        public FrmAnalysicInfoFacebook()
        {
            InitializeComponent();
        }
        public int ProcessAFacebook(string domainCompany, string ulrFacebook
            , long company, string user
            , string pass
            , bool bSave)
        {

            int numberComment = 0;
            if (!ulrFacebook.Contains("message"))
            {
                IWebDriver driverLocal = this.driver;
                try
                {

                    this.Invoke(new Action(() =>
                        {
                            btnTest.Visible = true;
                        }));

                    WriteLog(string.Format("Process link: {0}", ulrFacebook));
                    string urlReview = "";
                    string link = ulrFacebook;

                    //Tìm chỗ để login
                    driverLocal.Url = ((link.Contains("http")) ? "" : @"https://") + link.Trim();


                    string data = driverLocal.PageSource;




                    var timeLinkeTab = UtilSeleiumCrawler.FindElement(driverLocal, By.Id("fbTimelineHeadline"));
                    if (timeLinkeTab != null)
                    {
                        var itemTabs = UtilSeleiumCrawler.FindElements(timeLinkeTab, By.TagName("a"));
                        if (itemTabs != null)
                        {
                            foreach (var itemTab in itemTabs)
                            {
                                if (itemTab.Text.ToLower() == "xem thêm")
                                {
                                    itemTab.Click();
                                    itemTab.Click();
                                }
                                else if (itemTab.Text.ToLower() == "đánh giá")
                                {
                                    urlReview = UtilSeleiumCrawler.GetAttribute(itemTab, "href");
                                    break;
                                }
                            }
                        }
                    }

                    if (urlReview == "")
                    {
                        var itemPre = UtilSeleiumCrawler.FindElements(driverLocal, By.CssSelector("[role='presentation']"));
                        foreach (var itemTab in itemPre)
                        {
                            var itemPreUrlL = UtilSeleiumCrawler.FindElement(itemTab, By.TagName("a"));
                            if (itemPreUrlL != null)
                            {
                                string a = UtilSeleiumCrawler.GetAttribute(itemPreUrlL, "href").ToString();
                                if (a.Contains("review")) urlReview = a;
                            }
                        }
                    }

                    if (urlReview == "") WriteLog("Not review tab");
                    else WriteLog(string.Format("Review tab:{0}", urlReview));


                    if (urlReview != "")
                    {
                        driverLocal.Url = urlReview;
                        //Giải phóng link Xem Thêm.
                        try
                        {
                            bool bEnd = false;
                            int i = 0;
                            while (!bEnd && (i++) < 5)
                            {
                                bool bHave = false;
                                var buttomExts = driverLocal.FindElements(By.CssSelector("[role='button']"));

                                //Mở rộng các comment cấp 1.
                                foreach (var itemButton in buttomExts)
                                {
                                    try
                                    {
                                        string linkTo = UtilSeleiumCrawler.GetAttribute(itemButton, "href");
                                        string textData = itemButton.Text.Trim().ToLower();

                                        if (!string.IsNullOrEmpty(linkTo)
                                            &&

                                            (
                                            linkTo.Contains("reviews?ref=page_internal#")
                                            || linkTo.Contains("reviews&ref=page_internal#")
                                            )

                                            && !string.IsNullOrEmpty(textData)
                                            &&

                                            (
                                            Regex.IsMatch(textData, @".*xem thêm.*")
                                            || textData == "xem phản hồi khác"
                                            || textData.Contains("nhiều trả lời hơn"))
                                            )
                                        {
                                            string strData = "";
                                            //Kiểm tra thuộc tính  => Bỏ qua tab Review.
                                            strData = UtilSeleiumCrawler.GetAttribute(itemButton, "data-reactid");
                                            if (!strData.Contains("dropdown"))
                                            {
                                                itemButton.Click();
                                                bHave = true;
                                                WriteLog(string.Format("Mở xem thêm level:{0}", i));
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        log.ErrorFormat(ex.Message);
                                    }
                                }
                                if (bHave == true) bEnd = false;
                                else bEnd = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            log.InfoFormat(ex.Message);
                        }

                        //các comment cấp 1.
                        var items = UtilSeleiumCrawler.FindElements(driverLocal, By.TagName("li"));
                        if (items != null)
                        {
                            //Comment cấp 1
                            foreach (var item in items)
                            {
                                string classTag = UtilSeleiumCrawler.GetAttribute(item, "class");
                                if (Regex.IsMatch(classTag, "uiUnifiedStory"))
                                {
                                    try
                                    {
                                        string author1 = "";
                                        string description = "";
                                        try
                                        {
                                            author1 = item.FindElement(By.CssSelector("[itemprop='author']")).FindElement(By.TagName("a")).GetAttribute("href").ToString();
                                            description = item.FindElement(By.CssSelector("[itemprop='description']")).Text;
                                        }
                                        catch (Exception ex)
                                        {
                                        }

                                        if (author1 == "" && description == "")
                                        {
                                            var a1 = UtilSeleiumCrawler.FindElement(item, By.ClassName("_4w5j"));
                                            if (a1 != null)
                                            {
                                                var a2 = UtilSeleiumCrawler.FindElement(UtilSeleiumCrawler.FindElement(a1, By.TagName("strong")), By.TagName("a"));
                                                if (UtilSeleiumCrawler.GetAttribute(a2, "data-reactid") == "")
                                                {
                                                    author1 = a2.GetAttribute("href").Trim();
                                                }

                                                if (author1 != "")
                                                {
                                                    var aCanDess = UtilSeleiumCrawler.FindElements(a1, By.TagName("span"));
                                                    foreach (var aCanDes in aCanDess)
                                                    {
                                                        if (UtilSeleiumCrawler.GetAttribute(aCanDes, "class") == "")
                                                        {
                                                            description = aCanDes.Text;
                                                            if (description != "") break;
                                                        }
                                                    }
                                                }
                                            }

                                        }

                                        if (author1 != "")
                                        {
                                            long iTimeStam = Convert.ToInt32(item.FindElement(By.ClassName("timestamp")).GetAttribute("data-utime").ToString());
                                            string strr = "";
                                            var soreItem = UtilSeleiumCrawler.FindElement(UtilSeleiumCrawler.FindElement(item, By.ClassName("_4w5k")), By.TagName("u"));
                                            if (soreItem != null) strr = soreItem.GetAttribute("innerHTML");
                                            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                                            origin = origin.AddSeconds(iTimeStam);

                                            int iRae = 0;
                                            if (strr == "5 sao") iRae = 5;
                                            else if (strr == "4 sao") iRae = 4;
                                            else if (strr == "3 sao") iRae = 3;
                                            else if (strr == "2 sao") iRae = 2;
                                            else if (strr == "1 sao") iRae = 1;
                                            else iRae = 0;


                                            //Danh sách các comment cấp 2 của comment này 
                                            List<FacebookSubcomment> lstSubCommentLevel2s = new List<FacebookSubcomment>();
                                            var subcomments = UtilSeleiumCrawler.FindElements(item, By.TagName("li"));
                                            foreach (var itemSubComment in subcomments)
                                            {
                                                try
                                                {
                                                    string data_reactid = UtilSeleiumCrawler.GetAttribute(itemSubComment, "data-reactid").ToString().ToLower().Trim();

                                                    if (data_reactid.Contains("comment"))
                                                    {
                                                        if (!data_reactid.Contains("replies"))
                                                        {

                                                            string staus = UtilSeleiumCrawler.FindElement(itemSubComment, By.ClassName("UFICommentBody")).Text;
                                                            //Tìm đc comment cấp 2.
                                                            FacebookSubcomment commentLevel2 = new FacebookSubcomment()
                                                            {
                                                                status = staus,
                                                                subSubComments = new List<string>()
                                                            };
                                                            lstSubCommentLevel2s.Add(commentLevel2);

                                                            //Lấy ra ul (chứa các comment cấp 3 của comment này)
                                                            var cmtUlAll = UtilSeleiumCrawler.FindElements(item, By.ClassName("UFIReplyList"));
                                                            foreach (var itemUl in cmtUlAll)
                                                            {
                                                                string dataUl = UtilSeleiumCrawler.GetAttribute(itemUl, "data-reactid").ToString();
                                                                if (dataUl.Replace("replies", "")
                                                                    == data_reactid.Replace("comment", ""))
                                                                {
                                                                    var commentLevel3s = UtilSeleiumCrawler.FindElements(itemUl, By.TagName("li"));
                                                                    if (commentLevel3s != null && commentLevel3s.Count > 0)
                                                                    {
                                                                        foreach (var commentLevel3 in commentLevel3s)
                                                                        {
                                                                            string textData = UtilSeleiumCrawler.FindElement(commentLevel3, By.ClassName("UFICommentBody")).Text.Trim();
                                                                            if (textData != "")
                                                                            {
                                                                                commentLevel2.subSubComments.Add(textData);
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    log.ErrorFormat(ex.Message);
                                                }
                                            }


                                            QT.Moduls.CrawlerReviewFacebook.LogFacebookReview reviewData
                                                = new Moduls.CrawlerReviewFacebook.LogFacebookReview()
                                            {
                                                userUri = author1,
                                                userStatus = description,
                                                userRate = iRae,
                                                datePost = iTimeStam,
                                                merchantName = company.ToString(),
                                                merchantUri = urlReview,
                                                subComments = lstSubCommentLevel2s
                                            };

                                            if (bSave) SaveData(reviewData);
                                            numberComment++;
                                            WriteLog(JsonConvert.SerializeObject(reviewData));
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        log.ErrorFormat(ex.Message);
                                    }
                                }
                            }
                        }
                    }

                    //Cập nhật dữ liệu

                }
                catch (Exception ex)
                {
                    log.ErrorFormat(ex.Message);
                    return 0;
                }
                return numberComment;
            }



            WriteLog(string.Format("Finish facebook:{0}", ulrFacebook));
            return 0;
        }

        private void SaveData(LogFacebookReview r)
        {
            //string postData = JsonConvert.SerializeObject(r);
            //byte[] data = Encoding.UTF8.GetBytes(postData);
            //// Prepare web request...

            //HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("http://log.websosanh.vn:8080/log/KafkaLogReceiver/facebook_review.htm");
            //myRequest.Method = "POST";

            //myRequest.ContentType = "text/xml";

            //myRequest.ContentLength = data.Length;

            //myRequest.SendChunked = true;

            //myRequest.TransferEncoding = "UTF8";
            //myRequest.Credentials = new NetworkCredential("CDX", "pwd");

            //Stream newStream = myRequest.GetRequestStream();

            //newStream.Write(data, 0, data.Length);

            //newStream.Close();


            string data = JsonConvert.SerializeObject(r);

            // Create a request using a URL that can receive a post. 
            WebRequest request = WebRequest.Create(@"http://log.websosanh.vn:8080/log/KafkaLogReceiver/facebook_review.htm");
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            string postData = data;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/json; charset=UTF-8";

            //request.tra = "UTF8";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.

            WriteLog(string.Format("==============> Send to server:{0}", data));

            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            WriteLog(string.Format("==============> Sended to server {0}", responseFromServer));
            // Cl
            reader.Close();
            dataStream.Close();
            response.Close();
        }

        private void WriteLog(string r)
        {


            this.Invoke(new Action(() =>
            {
                if (this.richTextBox1.TextLength > 100000) this.richTextBox1.Clear();
                this.richTextBox1.AppendText("\n" + r);
            }));
        }

        private void btnProcessData(object sender, EventArgs e)
        {
            while (true)
            {
                try
                {
                    txtUser.Text = "";
                    txtPass.Text = "";

                    string user = txtUser.Text;
                    string pass = txtPass.Text;

                    driver = new FirefoxDriver();
                    driver.Url = "https://www.facebook.com/";
                    driver.FindElement(By.Id("email")).SendKeys(user);
                    driver.FindElement(By.Id("pass")).SendKeys(pass);
                    driver.FindElement(By.Id("persist_box")).Click();
                    driver.FindElement(By.Id("loginbutton")).Submit();
                    break;
                }
                catch (Exception ex)
                {
                    Thread.Sleep(1000);
                }
            }
            bool Check = (txtUser.Text != "") && (txtPass.Text != "");
            if (Check)
            {
                txtUser.Text = "";
                txtPass.Text = "";

                string user = txtUser.Text;
                string pass = txtPass.Text;

                thread = new Thread(() => ProcessDataFacebook(user, pass));
                thread.Start();
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
        }

        private void ProcessDataFacebook(string user, string pass)
        {
            while (true)
            {
                try
                {
                    DataTable tblNeedProcessFacebook = this.sqlDb.GetTblData(@"
                    EXEC sp_GetDataProcessFacebook", CommandType.Text, new SqlParameter[] { });

                    string mss = string.Format("Readed {0} link need process in db", tblNeedProcessFacebook.Rows.Count);

                    foreach (DataRow rowIno in tblNeedProcessFacebook.Rows)
                    {
                        string facebook = rowIno["facebook"].ToString();
                        string domain = (rowIno["domain"] == DBNull.Value) ? "" : rowIno["domain"].ToString();

                        int numberComment = ProcessAFacebook(domain, facebook, Convert.ToInt64(rowIno["id"]), user, pass, true);
                        try
                        {
                            WriteLog(string.Format("Analysic to {0} review", numberComment));
                            sqlDb.RunQuery(@"Update AnalysicInfoFacbook Set NumberComment = @NumberComment
                                , LastAnalysic = GetDate(), [WaitingProcess] = 0 Where Id = @Id", CommandType.Text,
                               new SqlParameter[]{
                                    sqlDb.CreateParamteter("",Convert.ToInt64(rowIno["id"]),SqlDbType.BigInt),
                                    sqlDb.CreateParamteter("NumberComment",numberComment,SqlDbType.Int)
                                });
                        }
                        catch (Exception ex)
                        {
                        }
                    }

                    Thread.Sleep(1000);
                }
                catch (ThreadAbortException abortException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    WriteLog(string.Format("Exception need process:{0}", ex.Message));
                }
            }
        }

        private void FrmAnalysicInfoFacebook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.thread != null && this.thread.IsAlive == true) this.thread.Abort();
        }

        public Thread thread { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtUrl.Text;
                string user = txtUser.Text;
                string pass = txtPass.Text;

                Thread threadTest = new Thread(() =>
                {
                    ProcessAFacebook("", url, -1, user, pass, false);
                });
                threadTest.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmAnalysicInfoFacebook_Load(object sender, EventArgs e)
        {
            //while (true)
            //{
            //    try
            //    {
            //        txtUser.Text = "manh29793@gmail.com";
            //        txtPass.Text = "1dnaccehp";

            //        string user = txtUser.Text;
            //        string pass = txtPass.Text;

            //        driver = new FirefoxDriver();
            //        driver.Url = "https://www.facebook.com/";
            //        driver.FindElement(By.Id("email")).SendKeys(user);
            //        driver.FindElement(By.Id("pass")).SendKeys(pass);
            //        driver.FindElement(By.Id("persist_box")).Click();
            //        driver.FindElement(By.Id("loginbutton")).Submit();
            //        break;
            //    }
            //    catch (Exception ex)
            //    {
            //        Thread.Sleep(1000);
            //    }
            //}
            txtRegex.Enabled = false;
        }
        string conn = "Data Source=42.112.28.93;Initial Catalog=QT_2;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu";
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Thread insert = new Thread(new ThreadStart(run));
            insert.Start();
        }
        void run()
        {
            DBAnalysInfoTableAdapters.CompanyTableAdapter comAdapter = new DBAnalysInfoTableAdapters.CompanyTableAdapter();
            DBAnalysInfo.CompanyDataTable comTable = new DBAnalysInfo.CompanyDataTable();
            comAdapter.Connection.ConnectionString = conn;
            comAdapter.FillByTotal(comTable);

            DBAnalysInfoTableAdapters.AnalysicInfoFacbookTableAdapter faceAdapter = new DBAnalysInfoTableAdapters.AnalysicInfoFacbookTableAdapter();
            DBAnalysInfo.AnalysicInfoFacbookDataTable faceTable = new DBAnalysInfo.AnalysicInfoFacbookDataTable();
            faceAdapter.Connection.ConnectionString = conn;

            for (int i = 0; i < comTable.Rows.Count; i++)
            {
                long id = long.Parse(comTable.Rows[i]["ID"].ToString());
                //string domain = comTable.Rows[i]["Domain"].ToString();
                string urlFace = string.Empty;
                string html = ReadHTMLCode(comTable.Rows[i]["Website"].ToString());
                if (html != "error")
                {
                    string pattern = txtRegex.Text;
                    Regex myRegex = new Regex(pattern);
                    MatchCollection mc;
                    mc = myRegex.Matches(html);
                    if (mc.Count > 0)
                    {
                        urlFace = mc[0].ToString();
                        this.Invoke(new Action(() =>
                        {
                            faceAdapter.Fill(faceTable);
                            try
                            {
                                richTextBox1.AppendText(faceTable.Rows[i]["Facebook"] + "\n");
                            }
                            catch (Exception)
                            {
                                richTextBox1.AppendText(" " + "\n");
                            }
                        }));
                    }
                }
                try
                {
                    faceAdapter.InsertQuery_facebook(id, urlFace);

                }
                catch (Exception)
                {

                }

            }
        }
        public string ReadHTMLCode(string URL)
        {
            try
            {
                WebClient webClient = new WebClient();
                byte[] reqHTML = webClient.DownloadData(URL);
                UTF8Encoding objUTF8 = new UTF8Encoding();
                return objUTF8.GetString(reqHTML);
            }
            catch (Exception Ex)
            {
                //MessageBox.Show(Ex.Message, "Unable to open file from URL");
                return "error";
            }

        }
    }
}
