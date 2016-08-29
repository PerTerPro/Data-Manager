using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using QT.Entities;
using GABIZ.Base;
using GABIZ.Base.HtmlUrl;
using System.Text.RegularExpressions;

namespace QT.Moduls.Crawler
{
    public partial class frmWebPerformance : QT.Entities.frmBase
    {
        public frmWebPerformance()
        {
            InitializeComponent();
        }

        private DateTime start;
        private Thread crawlerThread;
        private Queue<string> crawlerLink;
        private List<long> visitedCRC;
        private List<long> webCRC;
        private Uri rootUri;
        private bool finish = false;
        private bool pause = false;
        private int visitedCount = 0;
        private int ignoredCount = 0;
        private string currentUrl = "";
        private string rootUrl = "";
        private bool showLog = true;
        private DB.CompanyDataTable dtCom;
        private DBTableAdapters.CompanyTableAdapter adtCom;
        private int countWeb = 0;
        public override bool Start()
        {
            this.EnabledStart = false;
            this.EnabledStop = true;
            this.EnabledPause = true;
            this.EnabledRestart = true;
            this.timer1.Stop();
            rootUrl = txtURL.Text.Trim();
            try
            {
                rootUri = new Uri(rootUrl);
                pause = false;
                finish = false;
                start = DateTime.Now;
                visitedCount = 0;
                currentUrl = "";
                crawlerThread = new Thread(new ThreadStart(doCrawler));
                crawlerThread.Start();
            }
            catch (Exception)
            {
            }
            return true;
        }
        public override bool Stop()
        {
            finish = true;
            if (crawlerThread != null)
            {
                if (crawlerThread.IsAlive)
                {
                    crawlerThread.Abort();
                    crawlerThread.Join();
                    crawlerThread = null;
                }
            }
            this.EnabledStart = true;
            this.EnabledStop = false;
            this.EnabledPause = false;
            this.EnabledRestart = false;
            return true;
        }
        public override bool Restart()
        {
            finish = true;
            if (crawlerThread != null)
            {
                if (crawlerThread.IsAlive)
                {
                    crawlerThread.Abort();
                    crawlerThread.Join();
                    crawlerThread = null;
                }
            }
            Start();
            return true;
        }
        public override bool Pause()
        {
            pause = !pause;
            if (pause)
            {
                this.EnabledStart = true;
                this.EnabledStop = true;
                this.EnabledPause = false;
                this.EnabledRestart = true;
            }
            else
            {
                this.EnabledStart = false;
                this.EnabledStop = true;
                this.EnabledPause = true;
                this.EnabledRestart = true;
            }
            return true;
        }
        private bool IsRelevantUrl(string url)
        {

            Match m = Regex.Match(url, "^" + rootUrl.ToString().Trim().Substring(0, 12) + ".+");
            if (chkNapCache.Checked)
            {
                m = Regex.Match(url, "http://w*.*websosanh.vn/.+so-sanh.htm");
                if (m.Success)
                    return true;
                if ((url.IndexOf("/cat-") >= 0) && (url.IndexOf("trang") < 0) && (url.IndexOf("filter") < 0))
                {
                    return true;
                }
            }
            if (chkCacheSearch.Checked)
            {
                m = Regex.Match(url, "http://w*.*websosanh.vn/.+so-sanh.htm");
                if (m.Success)
                    return true;
                if ((url.IndexOf("/s/") >= 0) && (url.IndexOf("trang") < 0))
                {
                    return true;
                }
            }
            if (m.Success)
                return true;
            return false;
        }
        private bool IsNoVisitUrl(string url)
        {
            //url = url.ToLower();
            Match m0 = Regex.Match(url, ".+.jpg$");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+facebook.+");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+twitter.+");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+jpeg$");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+png$");
            if (m0.Success) { return true; }
            return false;
        }
        void doCrawler()
        {
            dtCom = new DB.CompanyDataTable();
            adtCom = new DBTableAdapters.CompanyTableAdapter();
            adtCom.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            if (adtCom.Connection.State == ConnectionState.Closed) adtCom.Connection.Open();
            if (chkFind.Checked == true)
            {
                webCRC = new List<long>();
                adtCom.Fill(dtCom);
                int i0 = 0;
                foreach (var dr in dtCom)
                {
                    i0 = webCRC.BinarySearch(dr.ID);
                    if (i0 < 0)
                        webCRC.Insert(~i0, dr.ID);
                }
                //adtCom.Connection.Close();
                //adtCom.Dispose();
                //dtCom.Dispose();
            }


            visitedCount = 0;
            crawlerLink = new Queue<string>();
            visitedCRC = new List<long>();
            rootUri = new Uri(rootUrl);
            crawlerLink.Enqueue(rootUrl);
            while (crawlerLink.Count > 0)
            {
                if (finish) { break; }
                if (!pause)
                {
                    string c_url = crawlerLink.Dequeue();
                    try
                    {
                        string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(c_url, 45, 2);

                        if (html != "")
                        {
                            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                            doc.LoadHtml(html);

                            var a_nodes = doc.DocumentNode.SelectNodes("//a[@href]");
                            if (a_nodes != null)
                            {
                                #region add link to process
                                for (int i = 0; i < a_nodes.Count; i++)
                                {
                                    string s = Common.GetAbsoluteUrl(a_nodes[i].Attributes["href"].Value, rootUri);
                                    if (!IsNoVisitUrl(s))
                                    {
                                        long s_crc = Tools.getCRC64(LinkCanonicalization.NormalizeLink(s));
                                        int index = visitedCRC.BinarySearch(s_crc);
                                        if (index < 0)
                                        {
                                            if (IsRelevantUrl(s))
                                                crawlerLink.Enqueue(s);
                                            visitedCRC.Insert(~index, s_crc);
                                            if (chkFind.Checked == true)
                                            {
                                                if (!IsRelevantUrl(s))
                                                {
                                                    Uri uri = new Uri(s);
                                                    TimeSpan timestartup = new TimeSpan(0, 1, 1, 0);
                                                    TimeSpan timeSleep = new TimeSpan(0, 1, 1, 0);
                                                    String domain = uri.Host.ToLower();
                                                    domain = domain.Replace("www.", "");
                                                   
                                                    long idcom = Common.GetIDCompany(domain);
                                                    int index1 = webCRC.BinarySearch(idcom);
                                                    if (index1 < 0)
                                                    {
                                                        Alexa a = new Alexa();
                                                        a = Common.GetRankAlexa(uri.Host);
                                                        Thread.Sleep(Common.Obj2Int(txtDelay.Text.Trim()));
                                                        countWeb++;
                                                        webCRC.Insert(~index1, idcom);
                                                        adtCom.Insert(
                                                            idcom,
                                                            "",
                                                            "Tìm thấy từ " + txtURL.Text,
                                                            domain,
                                                            domain,
                                                            DateTime.Now,
                                                            "",
                                                            "",
                                                            "",
                                                            "",
                                                            Common.CompanyStatus.WEB_ADDNEWS,
                                                            false,
                                                            "",
                                                            a.AlexaRankContries,
                                                            a.AlexaRank,
                                                            timestartup,
                                                            timeSleep,
                                                            500,
                                                            0,
                                                            DateTime.Now,
                                                            DateTime.Now,
                                                            30,
                                                            0,
                                                            0,
                                                            0, "", DateTime.Now, "", 0, DateTime.Now, 0, "", "", true, false, false, true, true, true,null,null,false,"",3);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                #endregion
                            }


                            if (showLog)
                            {
                                #region show log
                                this.Invoke((MethodInvoker)delegate
                                {
                                    lblVisited.Text = visitedCount.ToString();
                                    lblQueue.Text = crawlerLink.Count.ToString();
                                    lblProduct.Text = countWeb.ToString();
                                    txtUrlCurrent.Text = currentUrl;
                                    var xx = DateTime.Now - start;
                                    DateTime mydate = new DateTime(xx.Ticks);
                                    lblTime.Text = mydate.ToString("HH:mm:ss");
                                    lblIgnored.Text = ignoredCount.ToString();
                                });
                                #endregion
                            }
                        }
                        visitedCount++;
                        currentUrl = c_url;
                    }
                    catch (Exception ex)
                    {
                        FileLog.WriteAppendText(DateTime.Now.ToString("dd/MM HH:mm:ss") + "\t, " + c_url + "\r\n" + ex.ToString(), rootUri.Host + ".csv");
                    }

                }
            }
            finish = true;
            crawlerLink.Clear();
            crawlerLink = null;
            this.timer1.Start();
            if (crawlerThread != null)
            {
                if (crawlerThread.IsAlive)
                {
                    crawlerThread.Abort();
                    crawlerThread.Join();
                    crawlerThread = null;
                }
            }
        }



        private void frmWebPerformance_Load(object sender, EventArgs e)
        {

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void frmWebPerformance_FormClosing(object sender, FormClosingEventArgs e)
        {
            finish = true;
            crawlerLink.Clear();
            crawlerLink = null;
            if (crawlerThread != null)
            {
                if (crawlerThread.IsAlive)
                {
                    crawlerThread.Abort();
                    crawlerThread.Join();
                    crawlerThread = null;
                }
            }
        }

        private void txtURL_EditValueChanged(object sender, EventArgs e)
        {
            this.chkNapCache.Checked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Start();
        }
    }
}
