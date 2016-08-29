using QT.Entities;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlerProduct.BLO
{
    public class BLOCacheDumplicateProduct
    {
        ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
        QT.Moduls.CrawlerProduct.Cache.RedisCheckDuplicateAdapter rediscacheCheckDuplicate = QT.Moduls.CrawlerProduct.Cache.RedisCheckDuplicateAdapter.Instace();

        /// <summary>
        /// Refresh cache dumplicate Product Valid = 1 of company.
        /// </summary>
        /// <param name="companyID"></param>
        /// <param name="Domain"></param>
        public void PushCacheValidProductOfCompany(long companyID, string Domain)
        {
            DataTable proTable = productAdapter.GetSqlDb().GetTblData(@"Select ID, Instock, Valid, Price, Name, IsNews, ImageUrls, IsDeal, ClassificationID
From Product Where Company = @CompanyID and Valid = 1", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
SqlDb.CreateParamteterSQL("CompanyID",companyID,SqlDbType.BigInt)});

            if (proTable != null && proTable.Rows.Count > 0)
            {
                for (int j = 0; j < proTable.Rows.Count; j++)
                {
                    long ProductID = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["ID"].ToString());
                    int InStock = QT.Entities.Common.Obj2Int(proTable.Rows[j]["InStock"].ToString());
                    bool Valid = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["Valid"].ToString());
                    long Price = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["Price"].ToString());
                    string Name = QT.Entities.Common.Obj2String(proTable.Rows[j]["Name"].ToString());
                    bool IsNew = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["IsNews"]);
                    string ImageUrl = QT.Entities.Common.Obj2String(proTable.Rows[j]["ImageUrls"]);
                    bool IsDeal = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["IsDeal"].ToString());
                    long CategoryID = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["ClassificationID"].ToString());
                    if (this.rediscacheCheckDuplicate.GetProductIDOfHash(companyID, Product.GetHashDuplicate(Domain, Price, Name, ImageUrl)) == 0)
                    {
                        this.rediscacheCheckDuplicate.SetCheckDuplicate(companyID, ProductID, Domain, Price, Name, ImageUrl, Valid);
                    }
                }
            }
        }
    }
}
