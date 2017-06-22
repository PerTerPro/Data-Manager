using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Product;
using Dapper;

namespace Websosanh.Product
{
    public class ProductRepositorySql:IProductRepository
    {
        private readonly SqlConnection _sqlConnection;

        public ProductRepositorySql(string sqlConnection)
        {
            _sqlConnection = new SqlConnection(sqlConnection);
        }

        public void SetStatus(long productId, EStatusProduct statusProduct)
        {
            if (statusProduct == EStatusProduct.NoValid)
                _sqlConnection.Execute("Update Product Set Valid = 0 Where Id = @Id", new {@Id = productId});
        }

        public Product GetProduct(long productId)
        {
            return null;
        }
    }
}
