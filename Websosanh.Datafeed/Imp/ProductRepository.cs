using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace Websosanh.Datafeed.Imp
{
    public class ProductRepository:Websosanh.Datafeed.Model.IProductRepository
    {
        SqlConnection _sqlConnection = new SqlConnection(@"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        public HashSet<long> GetProductIds(long companyId)
        {
            HashSet<long> hashSet = new HashSet<long>();
            int page = 0;
            bool bStop = false;
            do
            {
                var productIds = _sqlConnection.Query<long>(
                    string.Format(@"Select Id From Product Where Company = @CompanyId order by Id asc Offset {0} Rows Fetch Next 10000 Rows Only", page*10000), new {@CompanyId = companyId});
                var enumerable = productIds as long[] ?? productIds.ToArray();
                if (enumerable.Any())
                {
                    foreach (var variable in enumerable)
                    {
                        hashSet.Add(variable);
                    }
                }
                else
                {
                    bStop = true;
                }
                page++;

            } while (!bStop)
                ;
            return hashSet;
        }
    }
}
