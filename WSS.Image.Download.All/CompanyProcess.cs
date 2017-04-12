using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Image.Download.All.Object;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QT.Entities;
namespace WSS.Image.Download.All
{
    public class CompanyProcess
    {
        string Query = "Select a.ID,b.TimeDelay from Company a inner join Configuration b on a.ID = b.CompanyID where TotalValid > 0 and (status = 1 or status = 18 or status = 19) order by a.TotalValid asc";
        string QueryCount = "Select Count(ID) as Count from Product where Company = @CompanyID";
        public List<Object.Company> GetListCompany()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                return db.Query<Object.Company>(Query).ToList();
            }
        }
        public int CheckCount(long Company)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                return Common.Obj2Int(db.Query<int>(QueryCount, new { CompanyID = Company }).FirstOrDefault());
            }
        }
    }
}
