using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;
using QT.Moduls.CrawlerProduct;
using Websosanh.Core.JobServer;
using QT.Entities.Data;
using System.Data;

namespace PushQueueChangeImageForVip
{
    class Program
    {
        private SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
        private DataTable tblCompany = null;
        private DataTable tblProduct = null;
        private long CompanyID = 0;
        private long ProductID = 0;
        private string updateProductGroupName_ChangeImage = System.Configuration.ConfigurationManager.AppSettings["updateProductImageGroupName"].ToString();
        string updateProductJobName_ChangeImage = System.Configuration.ConfigurationManager.AppSettings["updateProductImageProductJobName"].ToString();
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.push();
            
        }
        public void push()
        {
            ProductAdapter pa = new ProductAdapter();

            tblCompany = sqldb.GetTblData(@"select a.ID
                                            from Company a
                                            inner join ManagerTypeRCompany b
                                            on a.ID = b.IDCompany 
                                            inner join ManagerType c
                                            on b.IDType = c.ID
                                            where c.ID = 228
                                            and a.TotalNewProduct > 5", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { });

            foreach (DataRow RowCom in tblCompany.Rows)
            {
                
                CompanyID = QT.Entities.Common.Obj2Int64(RowCom["ID"]);
                tblProduct = sqldb.GetTblData("select ID from Product where Company = @CompanyID", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { 
                    sqldb.CreateParamteter("@CompanyID",CompanyID,SqlDbType.BigInt)
                });
                foreach (DataRow RowPro in tblProduct.Rows)
                {
                    ProductID = QT.Entities.Common.Obj2Int64(RowPro["ID"]);
                    pa.PushQueueChangeChangeImage(new MQChangeImage()
                    {
                        ProductID = ProductID,
                        Type = 2
                    });
                }
            }
        }
    }
}
