using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
    public class SqlCrawlerProduct
    {
        SqlDb sqlDb; 
        public SqlCrawlerProduct ()
        {
            this.sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
        }

        public void UpdateLastFullCrawler(long companyID)
        {
            string sql = "update company set lastfullcrawler = getdate() where id = @id";
            this.sqlDb.RunQuery(sql, System.Data.CommandType.Text, new System.Data.SqlClient.SqlParameter[]
                {
                    this.sqlDb.CreateParamteter("id",companyID,System.Data.SqlDbType.BigInt)
                });
        }

        public void UpdateLastCrawler(long companyID)
        {
            string sql = "update company set lastcrawler = getdate() where id = @id";
            this.sqlDb.RunQuery(sql, System.Data.CommandType.Text, new System.Data.SqlClient.SqlParameter[]
                {
                    this.sqlDb.CreateParamteter("id",companyID,System.Data.SqlDbType.BigInt)
                });
        }
    }
}
