using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Service.Report.ProductOnClick.Error.Object;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;

namespace WSS.Service.Report.ProductOnClick.Error.Class
{
    public class CompanyProcess
    {
        public static Company GetCompanyId(long ProductId)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                return db.Query<Company>("Select b.Id, b.Domain from Product a inner join Company b on a.Company = b.Id where aId = @ProductId", new { ProductId = ProductId }).FirstOrDefault();
            }
        }
    }
}
