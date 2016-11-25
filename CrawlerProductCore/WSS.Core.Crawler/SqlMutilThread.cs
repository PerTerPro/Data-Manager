using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;
using QT.Entities.Data;

namespace WSS.Core.Crawler
{
    public class SqlMutilThread
    {
        private static SqlMutilThread _sqlMutilThread;
        private readonly SqlDb _sqlDb = new SqlDb(ConfigCrawler.ConnectProduct);
        private readonly object _objLockThread = new object();

        public bool AllowCrawlReload(long companyId)
        {
            lock (_objLockThread)
            {
                return Common.Obj2Bool(_sqlDb.GetTblData("select a= dbo.func_b_Company_AllowCrawlerReload(@CompanyID)",
                CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@CompanyID",companyId,SqlDbType.BigInt)
                }, null, true).Rows[0][0]);
            }
        }

        public bool AllowCrawlFindNew(long companyId)
        {
            lock (_objLockThread)
            {
                return
                    Common.Obj2Bool(_sqlDb.GetTblData("select a= dbo.func_b_Company_AllowCrawlerFindNew(@CompanyID)",
                            CommandType.Text, new SqlParameter[]
                            {
                                SqlDb.CreateParamteterSQL("@CompanyID", companyId, SqlDbType.BigInt)
                            }, null, true).Rows[0][0]);
            }
        }

        public static SqlMutilThread Instance()
        {
            return _sqlMutilThread ?? (_sqlMutilThread = new SqlMutilThread());
        }

        private SqlMutilThread()
        {
            
        }
    }
}
