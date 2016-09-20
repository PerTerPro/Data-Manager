using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlerProduct.Cache;
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

namespace WSS.Crawler.Product.Report
{
    public partial class FrmCacheCompany : Form
    {
        CancellationTokenSource cancellationTokenSourceRefreshFromCache = new CancellationTokenSource();
        CancellationTokenSource cancellationTokenSourceRefreshFromSQL = new CancellationTokenSource();

        ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
        QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler redisCacheWait = QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler.Instance();
        QT.Moduls.CrawlerProduct.Cache.RedisCacheCompanyCrawler redisCompany = QT.Moduls.CrawlerProduct.Cache.RedisCacheCompanyCrawler.Instance();

        public FrmCacheCompany()
        {
            InitializeComponent();
        }

        private void btnRefreshCache_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                this.Invoke(new Action(() =>
                {
                    this.btnDuyetTuSQL.Visible = false;
                }));
                RefreshCacheCompany();
                this.Invoke(new Action(() =>
                {
                    this.btnDuyetTuSQL.Visible = true;
                }));
            });
        }

        private void RefreshCacheCompany()
        {
            //            int Count = 0;
            //            QT.Moduls.CrawlerProduct.Cache.RedisCacheCompanyCrawler cacheCompany = QT.Moduls.CrawlerProduct.Cache.RedisCacheCompanyCrawler.Instance();
            //            QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler cacheWait = QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler.Instance();
            //            SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);
            //            DataTable tbl = sqlDb.GetTblData(@"select a.id
            //	, a.domain 
            //	, isnull(b.MinHourReload,12) as MinHourReload
            //	, isnull(b.MinHourFindNew,8) as MinHourFindNew
            //    , a.AllowFindnew
            //    , a.AllowReload
            //    , a.DataFeedType
            //    , a.Status
            //from Company a inner join Configuration b on a.id = b.companyID
            //where 1=1
            //and a.DataFeedType=0
            //and a.Status=1
            //where datediff(day, lastupdate, getdate())<5", CommandType.Text, null);
            //            foreach (DataRow companyRow in tbl.Rows)
            //            {
            //                Count++;
            //                long companyID = QT.Entities.Common.Obj2Int64(companyRow["ID"]);
            //                DateTime dtLastCache = redisCompany.GetLastCache();
            //                DateTime lastChange = QT.Entities.Common.Obj2Date(companyRow["LastUpdate"], DateTime.MinValue);
            //                if (lastChange < dtLastCache)
            //                {
            //                    string domain = QT.Entities.Common.Obj2String(companyRow["Domain"]);
            //                    int minHourReload = QT.Entities.Common.Obj2Int(companyRow["MinHourReload"]);
            //                    int minHourFindNew = QT.Entities.Common.Obj2Int(companyRow["MinHourFindNew"]);
            //                    cacheCompany.SetCompanyInfo(companyID, domain, minHourReload, minHourFindNew);
            //                    bool AllowFindnew = QT.Entities.Common.Obj2Bool(companyRow["AllowFindnew"]);
            //                    bool AllowReload = QT.Entities.Common.Obj2Bool(companyRow["AllowReload"]);
            //                    int DataFeedType = QT.Entities.Common.Obj2Int(companyRow["DataFeedType"]);
            //                    int Status = QT.Entities.Common.Obj2Int(companyRow["Status"]);
            //                    if (!cacheWait.CheckHaveItemReload(companyID)) cacheWait.SetWaitNextReload(companyID, minHourReload);
            //                    if (!cacheWait.CheckHaveItemFindNew(companyID)) cacheWait.SetWaitNextFindNew(companyID, minHourFindNew);
            //                    if (Count % 1000 == 0)
            //                    {
            //                        this.Invoke(new Action(() =>
            //                        {
            //                            richTextBox1.AppendText(string.Format("CacheCompany {0}\n", Count));
            //                        }));
            //                    }
            //                }
            //            }
            //            this.Invoke(new Action(() =>
            //                {
            //                    richTextBox1.AppendText("Delete company cache not crawler");
            //                }));
            //            DataTable tblNotCrawler = sqlDb.GetTblData(@"select a.id
            //from Company a inner join Configuration b on a.id = b.companyID
            //where 1=1
            //and (a.DataFeedType!=0
            //or a.Status=1)", CommandType.Text, null);
            //            for (int i=0;i<tblNotCrawler.Rows.Count;i++)
            //            {
            //                redisCacheWait.DeleteCompany(QT.Entities.Common.Obj2Int64(tblNotCrawler.Rows[i]["Id"]));
            //                if (i%1000==0)
            //                {
            //                    this.Invoke(new Action(() =>
            //                    {
            //                        richTextBox1.AppendText(string.Format("Delete {0} company wait!", i));
            //                    }));
            //                }
            //            }
        }

        private void btnCheckFromCache_Click(object sender, EventArgs e)
        {
            
        }

        private void DuyetCache(CancellationToken token)
        {
            token.ThrowIfCancellationRequested();

            long CountCompany = 0;
            QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler redisWaitCrawler = QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler.Instance();
            List<long> lstCompany = redisCacheWait.GetAllCompany();
            foreach (long companyID in lstCompany)
            {
                token.ThrowIfCancellationRequested();
                CountCompany++;

                if (!this.productAdapter.AllowCrawlReload(companyID))
                {
                    redisCacheWait.RemoveCompanyReload(companyID);
                    AddNote(string.Format("\r\n Remove reload"));
                }

                if (!this.productAdapter.AllowCrawlFindNew(companyID))
                {
                    redisCacheWait.RemoveCompanyFindNew(companyID);
                    AddNote( string.Format("\r\n Remove findnew"));
                }

                if (CountCompany % 100 == 0)
                {
                    AddNote(string.Format("\r\n {0}/{1}", CountCompany, lstCompany.Count));
                }
            }
        }

        private void AddNote (string note)
        {
            this.Invoke(new Action(() =>
            {
                this.richTextBox1.AppendText(note);
            }));
        }

        private void btnDuyetCache_Click(object sender, EventArgs e)
        {
            var token = cancellationTokenSourceRefreshFromCache.Token;
            Task.Factory.StartNew(() =>
            {
                try
                {
                    this.Invoke(new Action(() =>
                    {
                        this.btnDuyetCache.Visible = false;
                    }));
                    DuyetCache(token);
                    this.Invoke(new Action(() =>
                    {
                        this.btnDuyetCache.Visible = true;
                    }));
                }
                catch (OperationCanceledException)
                {
                }
                catch (Exception ex)
                {
                }
            }, token);
        }

        private void FrmCacheCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.cancellationTokenSourceRefreshFromCache.Cancel();
            this.cancellationTokenSourceRefreshFromSQL.Cancel();

            QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler.CloseConnect();
        }

        private void btnDuyetTuSQL_Click(object sender, EventArgs e)
        {
           
        }

        private void btnViewCacheCompany_Click(object sender, EventArgs e)
        {
            FrmViewCacheCompany frm = new FrmViewCacheCompany();
            frm.ShowDialog();
        }

        private void FrmCacheCompany_Load(object sender, EventArgs e)
        {

        }
    }
}
