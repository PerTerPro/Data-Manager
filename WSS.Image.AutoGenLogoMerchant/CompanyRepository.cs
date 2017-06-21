using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Image.AutoGenLogoMerchant
{
    public class CompanyRepository
    {
        private SqlConnection _sqlConnection = null;
        public CompanyRepository(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
        }
        public IEnumerable<Company> GetListCompanyNotLogoId()
        {
            string query = @"select ID, Domain,LogoImageId from Company 
                where (Status = 1 or Status = 18 or Status = 19) 
                and (TotalValid > 0 or TotalProduct > 0) and (LogoImageId is null or LogoImageId = '')";
            return _sqlConnection.Query<Company>(query).ToList();
        }
        public IEnumerable<CompanyAutoGenLogo> GetListCompanyNotLogoIdFromTableAutoGen()
        {
            string query = @"select CA.CompanyId,C.Domain from Company_AutoGenerateLogo as CA inner join Company as C on C.ID = CA.CompanyId";
            return _sqlConnection.Query<CompanyAutoGenLogo>(query).ToList();
        }
    }
}
