using GABIZ.Base.Keyword;
using log4net;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.RankKeyword
{
    public partial class frmRankKeyword : Form
    {
        private Worker worker;
        private JobClient jobClient;
        RabbitMQServer rabbitMQServer;
        string rabbitMQServerName = "";
        string rankKeywordGroupName = "";
        string checkRankKeywordJobName = "";
        string updateRankKeywordJobName = "";
        private static readonly ILog Log = LogManager.GetLogger(typeof(frmRankKeyword));
        private int checkRestartProgram = 0;
        private int limitRestartProgram = 0;
        public frmRankKeyword()
        {
            InitializeComponent();
            rabbitMQServerName = ConfigurationSettings.AppSettings["rabbitMQServerName"];
            rankKeywordGroupName = ConfigurationSettings.AppSettings["rankKeywordGroupName"];
            checkRankKeywordJobName = ConfigurationSettings.AppSettings["checkRankKeywordJobName"];
            updateRankKeywordJobName = ConfigurationSettings.AppSettings["updateRankKeywordJobName"];
            Random rd= new Random();
            limitRestartProgram = rd.Next(4, 8);
            //btnStart_Click(null, null);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnStop.Visible = true;
            try
            {
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                worker = new Worker(checkRankKeywordJobName, false, rabbitMQServer);
                jobClient = new JobClient(rankKeywordGroupName, GroupType.Topic, updateRankKeywordJobName, true, rabbitMQServer);
                Task workerTask = new Task(() =>
                    {
                        worker.JobHandler = (keywordJob) =>
                        {
                            string keyword = Encoding.UTF8.GetString(keywordJob.Data);
                            this.Invoke(new Action(() =>
                            {
                                txtKeyword.Text = keyword;
                            }));
                            try
                            {
                                // Do something here!
                                //if (!Run(keyword))
                                //{
                                //    Log.InfoFormat("Restart Program...");
                                //    #region
                                //    btnStop.Visible = false;
                                //    worker.Stop();
                                //    rabbitMQServer.Stop();
                                //    #endregion
                                //    Application.Restart();
                                //}
                            }
                            catch (Exception ex)
                            {
                                Log.Error("Execute Job Error. Keyword:" + keyword, ex);
                            }
                            return true;
                        };
                        worker.Start();
                    });
                workerTask.Start();

                Log.InfoFormat("Worker started");
            }
            catch (Exception ex)
            {
                Log.Error("ERROR ", ex);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Visible = false;
            worker.Stop();
            rabbitMQServer.Stop();
            Log.InfoFormat("Worker ended");
            this.Close();
        }

        private void frmRankKeyword_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }
        private void Run(string keyword)
        {
            this.Invoke(new Action(() =>
            {
                lbCheckRestartProgram.Text = (checkRestartProgram+1).ToString();
            }));
            Job job = new Job();
            RankKeywordInfo keywordInfo = new RankKeywordInfo()
            {
                KeywordID = GABIZ.Base.Tools.getCRC32(keyword),
                Keyword = keyword,
                RankKeyword = MyXpath.CheckRankKeyword("websosanh.vn", keyword, @"//div[@class='rc']/div[@class='s']/div/div[@class='f kv _SWb']"),
                DateCheck = DateTime.Now
            };
            this.Invoke(new Action(() =>
            {
                lbRank.Text = keywordInfo.RankKeyword.ToString();
            }));
            //if (keywordInfo.RankKeyword == 9999)
            //{
            //    this.Invoke(new Action(() =>
            //    {
            //        lbCheckRestartProgram.Text = "503 cmnr T_T";
            //    }));
            //    Thread.Sleep(10000);
            //    return false;
            //}
            //else
            //{
            //    job.Data = RankKeywordInfo.GetMess(keywordInfo);
            //    jobClient.PublishJob(job);
            //    checkRestartProgram++;
            //    this.Invoke(new Action(() =>
            //    {
            //        lbCheckRestartProgram.Text = checkRestartProgram.ToString();
            //    }));
            //    Log.InfoFormat("{0}.Check success with: {1}", checkRestartProgram,keywordInfo.Keyword);
            //    if (checkRestartProgram == limitRestartProgram)
            //    {
            //        return false;
            //    }
            //    else
            //        return true;
            //}
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void btnCheckRank_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKeywordCheck.Text) && !string.IsNullOrEmpty(txtDomainCheck.Text))
            {
                Thread tr = new Thread(()=>Run(txtKeywordCheck.Text));
                tr.Start();
            }
        }

        private void btnGetlistUrl_Click(object sender, EventArgs e)
        {
            var a = txtDirectory.Text.Split(new char[]{'\n','\r'},StringSplitOptions.RemoveEmptyEntries);
            Thread tr = new Thread(() => RunUrl(a));
            tr.Start();
        }
        //geturl from goolge 
        private void RunUrl(string[] listwebsitemerchant)
        {
            List<string> listurlfinal = new List<string>();
            string formatsearch = "site:webtretho.com mua hàng ở {0}";

            string xpath = @"//div[@class='rc']/h3[@class='r']/a/@href";
            Random r = new Random();
            foreach (var item in listwebsitemerchant)
            {
                this.Invoke(new Action(() =>
                {
                    rbInfo.AppendText("Get link with website " + item+System.Environment.NewLine);
                }));
                string keyword = string.Format(formatsearch, item);
                listurlfinal.AddRange(GetListUrlFromGoogle(keyword, xpath, 1));
                Thread.Sleep(r.Next(3000, 5000));
            }
            
        }


        public List<string> GetListUrlFromGoogle(string keywordsearch, string xpath, int page)
        {
            List<string> listkeywords = new List<string>();
            for (int i = 0; i < page; i++)
            {
                string url = "";
                if (i == 0)
                {
                    url = "https://www.google.com.vn/search?q=" + System.Web.HttpUtility.UrlEncode(keywordsearch);
                }
                else
                    url = string.Format("https://www.google.com.vn/search?q={0}&btnG=T%C3%ACm+v%E1%BB%9Bi+Google&start={1}", System.Web.HttpUtility.UrlEncode(keywordsearch), (i * 10));
                try
                {
                    Uri urlRoot = new Uri(url, UriKind.RelativeOrAbsolute);
                    HttpWebRequest oReq = (HttpWebRequest)WebRequest.Create(urlRoot);
                    oReq.AllowAutoRedirect = true; //Nếu gặp response code 300 hoặc 309 nó sẽ tự chuyển theo response.header['location']
                    oReq.UserAgent = @"Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.87 Safari/537.36";
                    oReq.Timeout = 3000;
                    HttpWebResponse resp = (HttpWebResponse)oReq.GetResponse();
                    //HttpWebResponse resp = (HttpWebResponse)GetResponseNoCache(urlRoot);
                    var encoding = Encoding.GetEncoding(resp.CharacterSet);
                    if (resp.ContentType.StartsWith("text/html", StringComparison.InvariantCultureIgnoreCase))
                    {
                        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                        var resultStream = resp.GetResponseStream();
                        doc.Load(resultStream, encoding);
                        #region Get Value
                        HtmlAgilityPack.HtmlNodeCollection node = doc.DocumentNode.SelectNodes(xpath);
                        if (node != null)
                        {
                            foreach (HtmlAgilityPack.HtmlNode item in node)
                            {
                                string link = item.GetAttributeValue("href","");
                                listkeywords.Add(link);
                                this.Invoke(new Action(() => {
                                    rblink.AppendText(link + System.Environment.NewLine);
                                }));
                            }
                        }
                        this.Invoke(new Action(() => { 
                            
                        }));
                        #endregion
                        resultStream.Close();
                    }
                    resp.Close();
                }
                catch (Exception ex)
                {
                    Log.Error("Error: ", ex);
                    this.Invoke(new Action(() => {
                        rbError.AppendText("Error " + ex.Message + System.Environment.NewLine + "Sleep..." + System.Environment.NewLine);
                    }));
                    Thread.Sleep(1200000);
                    return null;
                }
            }
            return listkeywords;
        }
    }
}
