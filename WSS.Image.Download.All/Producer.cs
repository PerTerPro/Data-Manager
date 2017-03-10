using QT.Entities.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WSS.Image.Download.All
{
    public class Producer
    { 
        string QueryDefault = @"Select ID, DetailUrl, ImageUrls, ImageId from Product where Company = @CompanyID and Valid = 1";
        string QueryPagging = @"SELECT ID, DetailUrl, ImageUrls, ImageId
                                        FROM Product where Company = @CompanyID and Valid = 1
                                        ORDER BY ID 
                                        OFFSET ((@PageIndex - 1) * @PageSize) ROWS
                                        FETCH NEXT @PageSize ROWS ONLY;";
        public List<ImageProductInfo> GetListProductDownloadImg(long Company)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"])) 
            {
                return db.Query<ImageProductInfo>(QueryDefault, new { CompanyID = Company }).ToList();
            }
        }
        public List<ImageProductInfo> GetListProductDownloadImgPagging(long Company, int PageIndex)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                return db.Query<ImageProductInfo>(QueryPagging, new { CompanyID = Company, PageIndex = PageIndex, PageSize = 10000 }).ToList();
            }
        }
    }
}
