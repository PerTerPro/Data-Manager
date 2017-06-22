using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using WSS.Service.Report.ProductOnClick.Error.Entity;
using WSS.Service.Report.ProductOnClick.Error.Model;
using WSS.Service.Report.ProductOnClick.Error.Object;

namespace WSS.Service.Report.ProductOnClick.Error.ImplementCode
{

    public class ProductProcess:IProductProcess
    {
        
        private readonly SqlConnection _sqlConnection;

        public ProductProcess(ISettingRepository settingRepository)
        {

            this._sqlConnection = new SqlConnection(settingRepository.ConnectionProduct);
        }

        public  bool 
            IsAdsScore(long productId)
        {
           
                var productAds = _sqlConnection.Query<ProductAds>
                    ("Select TOP 1 * from Product_AdsScore where ProductId = @ProductID", new { ProductId = productId }).SingleOrDefault();
                if (productAds != null)
                    return true;
                else
                    return false;

        }

        public void UpdateError(ProductError errProduct)
        {
            if (IsExist(errProduct.ProductId))
            {
                _sqlConnection.Execute(
                    "Update Product_Error_Link set CompanyId = @CompanyId, DetailUrl = @DetailUrl, Keyword = @Keyword, Type = @Type, DateLog = @DateLog where ProductId = @ProductId",
                    new
                    {
                        @CompanyId = errProduct.CompanyId,
                        @DetailUrl = errProduct.DetailUrl ?? "",
                        @Keyword = errProduct.Keyword ?? "",
                        @Type = errProduct.Type,
                        @DateLog = errProduct.DateLog,
                        @ProductId = errProduct.ProductId
                    });
            }
            else
            {
                _sqlConnection.Execute(
                    "Insert into Product_Error_Link (ProductId, CompanyId, DetailUrl, DateLog, Keyword, Type) values (@ProductId, @CompanyId, @DetailUrl, @DateLog, @Keyword, @Type)",
                    new
                    {
                        @ProductId = errProduct.ProductId,
                        @CompanyId = errProduct.CompanyId,
                        @DetailUrl = errProduct.DetailUrl ?? "",
                        @DateLog = errProduct.DateLog,
                        @Keyword = errProduct.Keyword ?? "",
                        @Type = errProduct.Type
                    });
            }
        }

        public  bool IsUrlEncoded(string text)
        {
            return (HttpUtility.UrlDecode(text) != text);
        }
        public  bool IsExist(long productId)
        {
         
                var productError = _sqlConnection.Query<ProductError>("Select TOP 1 * from Product_Error_Link where ProductId = @ProductId", new { ProductId = productId }).SingleOrDefault();
                if (productError != null)
                    return true;
                else
                    return false;
            
        }


        public  string GetKeywordAds(long productId)
        {
            var ads = _sqlConnection.Query<ProductAds>("Select Keyword from Product_AdsScore where ProductId = @ProductId", new { ProductId = productId }).FirstOrDefault();
            if (ads != null)
                return ads.Keyword;
            return null;
        }
    }
}
