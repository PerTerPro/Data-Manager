using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using WSS.Service.Report.ProductOnClick.Error.Entity;
using WSS.Service.Report.ProductOnClick.Error.Model;
using WSS.Service.Report.ProductOnClick.Error.Object;

namespace WSS.Service.Report.ProductOnClick.Error.ImplementCode
{
    public class ProductAdapter:IProductAdapter
    {
      
        private readonly SqlConnection _connection;

        public ProductAdapter(string sqlConnection)
        {
            _connection = new SqlConnection(sqlConnection);
        }

        public Company GetCompanyId(long productId)
        {
            return _connection.Query<Company>("Select b.Id, b.Domain from Product a inner join Company b on a.Company = b.Id where a.Id = @ProductId", new {ProductId = productId}).FirstOrDefault();
        }

        public Product GetProduct(long productId)
        {
            return _connection.Query<Product>(@"Select Top 1 Id, DetailUrl From Product Where Id = @Id",
                new {@Id = productId}).FirstOrDefault();
        }

        public void UpdateInvalidProduct(long productId)
        {
            throw new System.NotImplementedException();
        }
    }
}
