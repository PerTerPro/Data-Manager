using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;

namespace ImboForm
{
    public class ImageAdapterSql
    {
        private ProductAdapter _productAdapter = null;


        public SqlDb GetSqlDb()
        {
            return this._productAdapter.GetSqlDb();
        }

        public ImageAdapterSql()
        {
            _productAdapter = new ProductAdapter(new SqlDb(ConfigImbo.ConnectionProduct));
        }
        public static ImageAdapterSql Instance()
        {
           return  new ImageAdapterSql();
        }

        public List<long> GetCompanyIdByDomain(List<string> domain)
        {
            DataTable tbl = this._productAdapter.GetSqlDb().GetTblData(
                @"
select a.ID
from Company a 
where a.Status = 1
order by a.TotalProduct asc
"
                , CommandType.Text, null);
            return (from DataRow variable in tbl.Rows select Convert.ToInt64(variable["ID"])).ToList();
        }
    }
}
