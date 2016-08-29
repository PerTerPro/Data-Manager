using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Data
{
    public class CompanyAdapter
    {
        private SqlDb sqlDb;
        public CompanyAdapter (SqlDb sqlDb)
        {
            this.sqlDb = sqlDb;
        }

        public System.Data.DataTable GetTblCanPushCrawler(int typeCrawler)
        {
            string sql = @"prc_company_PushAutoCrawl";
            DataTable tblCompany = this.sqlDb.GetTblData(sql, CommandType.StoredProcedure, new SqlParameter[]{
                new SqlParameter("@iTypeCrawler",typeCrawler)
            });
            return tblCompany;
        }
    }
}
