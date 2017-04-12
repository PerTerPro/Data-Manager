using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WSS.Service.Report.ProductOnClick.Error.Object;
using System.Web;

namespace WSS.Service.Report.ProductOnClick.Error.Class
{
    public class ProductProcess
    {
        public static bool IsAdsScore(long ProductId)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                var productAds = (ProductAds)db.Query<ProductAds>("Select * from Product_AdsScore where ProductId = @ProductID", new { ProductId = ProductId });
                if (productAds != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static void UpdateError(ProductError errProduct)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                if (IsExist(errProduct.ProductId))
                {
                    db.Execute("Update Product_Error_Link set CompanyId = @CompanyId, DetailUrl = @DetailUrl, Keyword = @Keyword, Type = @Type, DateLog = @DateLog where ProductId = @ProductId",
                        new
                        {
                            CompanyId = errProduct.CompanyId,
                            DetailUrl = errProduct.DetailUrl,
                            Keyword = errProduct.Keyword,
                            Type = errProduct.Type,
                            DateLog = errProduct.DateLog
                        });
                }
                else
                {
                    db.Execute("Insert into Product_Error_Link (ProductId, CompanyId, DetailUrl, DateLog, Keyword, Type) values (@ProductId, @CompanyId, @DetailUrl, @DateLog, @Keyword, @Type)",
                        new
                        {
                            ProductId = errProduct.ProductId,
                            CompanyId = errProduct.CompanyId,
                            DetailUrl = errProduct.DetailUrl,
                            DateLog = errProduct.DateLog,
                            Keyword = errProduct.Keyword,
                            Type = errProduct.Type
                        });
                }
            }
        }
        public static bool IsUrlEncoded(string text)
        {
            return (HttpUtility.UrlDecode(text) != text);
        }
        public static bool IsExist(long ProductId)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                var productError = (ProductError)db.Query<ProductError>("Select * from Product_Error_Link where ProductId = @ProductId", new { ProductId = ProductId });
                if (productError != null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }


        public static string GetKeywordAds(long ProductId)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                return db.Query<ProductAds>("Select Keyword from Product_AdsScore where ProductId = @ProductId", new { ProductId = ProductId }).FirstOrDefault().Keyword;
            }
        }
    }
}
