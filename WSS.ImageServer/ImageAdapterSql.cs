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

        public bool CheckExitProduct(long productId)
        {
            return this.GetSqlDb().GetTblData("Select Id From Product Where Id = @Id", CommandType.Text, new[]
            {
                SqlDb.CreateParamteterSQL("Id", productId, SqlDbType.BigInt)
            }).Rows.Count > 0;
        }

        public string GetImageId(long p)
        {
            DataTable tbl = this.GetSqlDb().GetTblData(string.Format(@"Select ImageId From Product Where Id = {0}", p), CommandType.Text, null);
            if (tbl.Rows.Count == 0) return "";
            else return QT.Entities.Common.Obj2String(tbl.Rows[0]["ImageId"]);
        }

        internal void UpdateImboProcess(long p1, string p2)
        {
            bool bOK = this.GetSqlDb().RunQuery("Update Product Set ImageId = @ImageId where Id = @Id", CommandType.Text, new[]
            {
                SqlDb.CreateParamteterSQL("ImageId", p2, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("Id", p1, SqlDbType.BigInt)
            });
        }
    }
}
