using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QT.Entities;
using QT.Moduls;
using QT.Entities.Data;
using System.Data;
using QT.Entities.CrawlerProduct;

namespace FixDuplicate
{
    class Program
    {
        SqlDb sqldb = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        DataTable tblCompany = null;
        DataTable tblProduct = null;
        string Domain = "";
        long CompanyID = 0;
        long ProductID = 0;
        long HashCheckDuplicate = 0;

        static void Main(string[] args)
        {

        }

        public void Test()
        {

        }
        public void Run()
        {
            tblCompany = sqldb.GetTblData("select * from Company where Status = 1 and DataFeedType =0");
            foreach (DataRow CompanyInfo in tblCompany.Rows)
            {
                CompanyID = QT.Entities.Common.Obj2Int64(CompanyInfo["ID"]);
                Domain = QT.Entities.Common.Obj2String(CompanyInfo["Domain"]);
                tblProduct = sqldb.GetTblData("select * from Product where Company = @Company and IsBlackList = 1",CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                    sqldb.CreateParamteter("@Company",CompanyID,SqlDbType.BigInt)
                });
                foreach (DataRow ProductInfo in tblProduct.Rows)
                {
                    int Price = QT.Entities.Common.Obj2Int(ProductInfo["Price"]);
                    string Name = QT.Entities.Common.Obj2String(ProductInfo["Name"]);
                    string ImageUrl = QT.Entities.Common.Obj2String(ProductInfo["ImageUrls"]);
                    if (CheckSuccess(Price, Name, ImageUrl) == true)
                    {
                        HashCheckDuplicate = Product.GetHashCheckDuplicate(Domain, Price, Name, ImageUrl);
                        
                    }
                }
            }
        }
        public bool CheckSuccess(int Price, string Name, string ImageUrl)
        {
            if ((Price >= 1000) && (Price % 100 == 0) && (Name.Trim().Length > 0) && !string.IsNullOrEmpty(ImageUrl))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
