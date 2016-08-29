using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.AutoFindWebsiteFromGoogle
{
    public class Runner
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Runner));
        SqlDb sqldb = new SqlDb(ConfigurationManager.AppSettings["connectionStringSql"]);
        DataTable tblKeywordSearch = null;
        long KeywordID = 0;
        long CompanyID = 0;
        string Domain;
        string Website;
        private int MAX_HOUR_LOOP = 24;
        private int HOUR_RUN = 1;
        DateTime NextRun = new DateTime();
        public Runner()
        {

        }

        public void Run(System.Threading.CancellationToken token)
        {
            log.InfoFormat("start: {0}", DateTime.Now.ToString());
            Dictionary<string, string> dicWebsite = new Dictionary<string, string>();
            Google g = new Google();
            tblKeywordSearch = sqldb.GetTblData("select top 5 * from KeywordFindNewWebsite order by LastUseToFindWebsite asc");
            foreach (DataRow RowInfo in tblKeywordSearch.Rows)
            {
                KeywordID = QT.Entities.Common.Obj2Int64(RowInfo["ID"]);
                dicWebsite = g.GetWebsiteFromGoogle(QT.Entities.Common.Obj2String(RowInfo["Keyword"]), 5, 10000);
                foreach (var item in dicWebsite)
                {
                    Domain = item.Key;
                    CompanyID = Math.Abs(GABIZ.Base.Tools.getCRC64(Domain));
                    Website = QT.Entities.Common.GetWebsiteFromUrl(item.Value);
                    SaveCompany(CompanyID, KeywordID, Domain, Website);
                }
                SaveProduct(KeywordID);
            }
            NextRun = DateTime.Now.AddHours(MAX_HOUR_LOOP);
            log.InfoFormat("End: {0}", DateTime.Now.ToString());
        }

        public void SaveCompany(long companyID, long keywordID, string domain, string website)
        {
            sqldb.RunQuery(@"if (not exists (select ID from Company where ID = @ID) 
                                and not exists(select ID from FindWebSite where ID = @ID)) 
                                begin 
                                    insert into FindWebSite (ID, KeywordID, Domain, Website) Values (@ID, @KeywordID, @Domain, @Website) 
                                end", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { 
                                                                SqlDb.CreateParamteterSQL("@ID",companyID,SqlDbType.BigInt),
                                                                SqlDb.CreateParamteterSQL("@KeywordID",keywordID,SqlDbType.BigInt),
                                                                SqlDb.CreateParamteterSQL("@Domain",domain,SqlDbType.NVarChar),
                                                                SqlDb.CreateParamteterSQL("@Website",website,SqlDbType.NVarChar)
                                                            });
            log.InfoFormat("save company: {0}, {1}", companyID, domain);
        }
        public void SaveProduct(long keywordID)
        {
            sqldb.RunQuery("update KeywordFindNewWebsite set LastUseToFindWebsite = GETDATE() where ID = @ID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                    SqlDb.CreateParamteterSQL("ID",keywordID,SqlDbType.BigInt)
                    });
        }


        internal void Start(System.Threading.CancellationToken token)
        {
            while (true)
            {
                token.ThrowIfCancellationRequested();
                if (DateTime.Now.Hour == this.HOUR_RUN && NextRun < DateTime.Now)
                {
                    Run(token);
                }
                else
                {
                    log.InfoFormat("Running at {0} h. App run last {1} Minute", HOUR_RUN, (int)(DateTime.Now - NextRun).TotalMinutes);
                    token.WaitHandle.WaitOne(60000 * 5);
                }
            }
        }
    }
}
