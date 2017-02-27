using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using WSS.Image.GetSize.Object;
using System.Configuration;

namespace WSS.Image.GetSize
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetSize();
        }
        public void GetSize()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                var lstCompany = db.Query<Company>("Select ID from Company where totalproduct > 0 and (status = 1 or status = 18 or status = 19)").ToList();
                foreach (var item in lstCompany)
                {
                    List<Product> lstProduct = new List<Product>();
                    do
                    {
                        lstProduct = db.Query<Product>(@"Select ID,ImageUrls from Product where Company = @Company", new { Company = item.ID }).ToList();
                    } while (lstProduct != null && lstProduct.Count > 0);
                }
            }
        }
    }
}
