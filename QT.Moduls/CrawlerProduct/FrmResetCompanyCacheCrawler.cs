using QT.Entities.Data;
using QT.Moduls.RabbitMQ;
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
using QT.Entities;
using Websosanh.Core.Drivers.RabbitMQ;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmResetCompanyCacheCrawler : Form
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmResetCompanyCacheCrawler));
        SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
        ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
        int MinHourRecrawl = 0;
        int MinHourFindNew = 0;

        public FrmResetCompanyCacheCrawler()
        {
            InitializeComponent();
        }

        private void btnResetCompanyCacheCrawler_Click(object sender, EventArgs e)
        {
            Thread RunReset = new Thread(() => Reset());
            RunReset.Start();
        }

        private void btnPushReloadCacheProductInfoAllCompany_Click(object sender, EventArgs e)
        {
            Thread RunPushProductInfo = new Thread(() => PushCacheProductInfo());
            RunPushProductInfo.Start();
        }
        private void btnPushReloadCacheCheckDuplicateAllCompany_Click(object sender, EventArgs e)
        {
            Thread RunPushCheckDuplicate = new Thread(() => PushCheckDuplicate());
            RunPushCheckDuplicate.Start();
        }

        private void PushCheckDuplicate()
        {

            MQPushResetDuplicate mqPushResetDuplicate = new MQPushResetDuplicate(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler));
            string Domain = "";
            long CompanyID = 0;
            int Count = 0;
            DataTable tblCompany = sqldb.GetTblData("select * from company where status = 1 and datafeedtype = 0");
            foreach (DataRow CompanyInfo in tblCompany.Rows)
            {
                CompanyID = QT.Entities.Common.Obj2Int64(CompanyInfo["ID"]);
                Domain = QT.Entities.Common.Obj2String(CompanyInfo["Domain"]);
                mqPushResetDuplicate.PushQueueReloadCacheDuplicate(CompanyID, Domain);
                Count++;
                this.Invoke(new Action(() =>
                {
                    if (Count % 200 == 0)
                    {
                        try
                        {
                            report.AppendText(string.Format("CacheDuplicate {0}/ {1} : {2} \n", Count, tblCompany.Rows.Count, CompanyID));
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }));
            }
        }

        private void PushCacheProductInfo()
        {
            string Domain = "";
            long CompanyID = 0;
            int Count = 0;

           DataTable  tblCompany = sqldb.GetTblData("select * from company where status = 1 and datafeedtype = 0");
            foreach (DataRow CompanyInfo in tblCompany.Rows)
            {
                CompanyID = QT.Entities.Common.Obj2Int64(CompanyInfo["ID"]);
                Domain = QT.Entities.Common.Obj2String(CompanyInfo["Domain"]);
                productAdapter.PushQueueReloadCacheProductInfo(CompanyID, Domain);
                Count++;
                this.Invoke(new Action(() =>
                {
                    if (Count % 200 == 0)
                    {
                        try
                        {
                            report.AppendText(string.Format("CacheProductInfo {0}/ {1} : {2} \n", Count, tblCompany.Rows.Count, CompanyID));
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }));
            }
        }

        private void ResetCacheAllCompany()
        {
            CancellationTokenSource cancellation = new CancellationTokenSource();
            SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);
            QT.Moduls.CrawlerProduct.Cache.CacheProductInfo cache = new Cache.CacheProductInfo(sqlDb);
            cache.ReloadChaceForAllCompany(cancellation.Token);
            report.AppendText("\r=nView log");
        }

        private void Reset()
        {
            string Domain = "";
            long CompanyID = 0;
            int Count = 0;

            QT.Moduls.CrawlerProduct.Cache.RedisCacheCompanyCrawler redis = new Cache.RedisCacheCompanyCrawler();
            DataTable tblCompany = sqldb.GetTblData(@"select a.ID,a.Domain,b.MinHourReload,b.MinHourFindNew 
                                            from Company a 
                                            inner join Configuration b 
                                            on a.ID = b.CompanyID 
                                            where a.DataFeedType = 0 and a.Status = 1");
            foreach (DataRow CompanyInfo in tblCompany.Rows)
            {
                log.Info("Start Reset...");
                try
                {
                    CompanyID = QT.Entities.Common.Obj2Int64(CompanyInfo["ID"]);
                    Domain = QT.Entities.Common.Obj2String(CompanyInfo["Domain"]);
                    MinHourRecrawl = QT.Entities.Common.Obj2Int(CompanyInfo["MinHourRecrawl"]);
                    MinHourFindNew = QT.Entities.Common.Obj2Int(CompanyInfo["MinHourFindNew"]);

                    redis.SetCompanyInfo(CompanyID, Domain, MinHourRecrawl, MinHourFindNew);
                    Count++;
                    this.Invoke(new Action(() =>
                    {
                        try
                        {
                            report.AppendText(string.Format("CacheCompany {0}/ {1} : {2} \n", Count, tblCompany.Rows.Count, CompanyID));
                        }
                        catch (Exception ex)
                        {
                        }

                    }));
                    log.InfoFormat("Reset Company Cache Crawler: {0}", CompanyID);
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                }
                

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
