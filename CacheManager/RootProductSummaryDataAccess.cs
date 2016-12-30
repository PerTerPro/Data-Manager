using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace CacheManager
{
    public class RootProductSummaryDataAccess
    {
        private string _connectionString;
        public RootProductSummaryDataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<RootProductSummary> GetProductsWhichSummaryNotEqualName()
        {
            using (var connection = new SqlConnection {ConnectionString = _connectionString})
            {
                connection.Open();
                return connection.Query<RootProductSummary>("SELECT ID,Summary FROM Product WHERE Company = 6619858476258121218 AND Name != CONVERT(NVARCHAR(MAX),Summary) AND Valid = 1").ToList();
            }
        }

        public void UpdateProductSummaryByName(long productId)
        {
            using (var connection = new SqlConnection { ConnectionString = _connectionString })
            {
                connection.Open();
                connection.Execute("Update [Product] SET [Summary] = [Name] WHERE ID = @Id", new {Id = productId});
            }
        }
    }
}
