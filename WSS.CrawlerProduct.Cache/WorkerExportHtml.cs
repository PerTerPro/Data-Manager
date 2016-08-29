using GABIZ.Base;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WSS.CrawlerProduct.Cache
{
    public class WorkerExportHtml
    {
        int countCompany = 0;

        public  WorkerExportHtml(int iThread)
        {
            this.iThread = iThread;
        }

        public delegate long GetCompanyId();
        public GetCompanyId eventGetCompanyID;
        public delegate void DelegateProcessHtml(long companyID, long productID, string html, string name, string detailUrl);
        public DelegateProcessHtml eventProcessHtml;
        public delegate void DelegateWhenFinish();
        public DelegateWhenFinish eventWhenFinish;

        ProductAdapter productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
        public void Start()
        {
            long CompanyID = eventGetCompanyID();
            while (CompanyID > 0)
            {
                countCompany++;
                DownloadDescriptionHtml(CompanyID);
                CompanyID = eventGetCompanyID();
            }
            log.Info(string.Format("End Thread {0}", iThread));
        }

        private void DownloadDescriptionHtml(long CompanyID)
        {
            try
            {
                productAdapter.sqlDb.RunQuery("insert into Company_DownloadedHTML (CompanyID) values (@CompanyID)", CommandType.Text,
                   new System.Data.SqlClient.SqlParameter[]{
                        SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt)
                    });
                log.Info(string.Format("Download for company:{0}", CompanyID));

                Configuration config = new Configuration(CompanyID);
                DataTable tbl = productAdapter.sqlDb.GetTblData(
                @"select ID, DetailUrl , Name
                From Product Where Company = @CompanyID 
                and Valid = 1", CommandType.Text,
                    new System.Data.SqlClient.SqlParameter[]{
                    SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)
                 });

                

                if (tbl != null)
                {
                    int countProduct = 0;
                    foreach (DataRow row in tbl.Rows)
                    {
                        Thread.Sleep(config.TimeDelay * 2);
                        countProduct++;
                        string detailUrl = row["DetailUrl"].ToString();
                        string name = row["Name"].ToString();
                        long ProductID = Convert.ToInt64(row["ID"]);
                        WebExceptionStatus web = WebExceptionStatus.Success;
                        string html = GetHtmlCode(detailUrl, config.UseClearHtml, out web);
                        if (!string.IsNullOrEmpty(html))
                        {
                            eventProcessHtml(CompanyID, ProductID, html, name, detailUrl);
                            log.Info(string.Format("Thread: {0} cC: {1} cmp: {2} product: {3}/{4}", this.iThread.ToString(), countCompany.ToString(), CompanyID, countProduct, tbl.Rows.Count));
                        }

                    }
                }
               
            }
            catch (Exception ex)
            {
                log.Error(ex);
                Thread.Sleep(10000);
            }
        }

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(WorkerExportHtml));
        private int iThread;
        private string GetDescription(string html, Configuration configXPath)
        {
            List<string> lstDescripotionHtml = new List<string>();
            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            if (configXPath.ShortDescriptionXPath != null && configXPath.ShortDescriptionXPath.Count > 0)
            {
                for (int i = 0; i < configXPath.ShortDescriptionXPath.Count; i++)
                {
                    if (configXPath.ShortDescriptionXPath[i].Trim() != "")
                    {
                        var node_ShortDescription = doc.DocumentNode.SelectSingleNode(configXPath.ShortDescriptionXPath[i]);
                        if (node_ShortDescription != null)
                        {
                            lstDescripotionHtml.Add(node_ShortDescription.OuterHtml);
                        }
                    }
                }
            }
            return string.Join("||||", lstDescripotionHtml);
        }
        private string GetHtmlCode(string urlCurrent, bool UseClearHtml, out WebExceptionStatus expo)
        {
            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(urlCurrent, 45, 2, out expo);
            html = html.Replace("<form", "<div");
            html = html.Replace("</form", "</div");
            if (UseClearHtml)
            {
                html = Common.TidyCleanR(html);
            }
            return html;
        }
    }
}
