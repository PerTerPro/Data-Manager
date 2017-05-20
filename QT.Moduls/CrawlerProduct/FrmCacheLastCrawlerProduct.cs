using QT.Entities;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmCacheLastCrawlerProduct : Form
    {
        ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
        

        public FrmCacheLastCrawlerProduct()
        {
            InitializeComponent();
        }

        private void btnPushCache_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
                {
                    PushAllCompany();
                });
        }

        private void PushAllCompany()
        {
            DataTable tblCompany = productAdapter.GetCompanyCrawler();
            foreach (DataRow rowCompany in tblCompany.Rows)
            {
                long CompanyID = QT.Entities.Common.Obj2Int64(rowCompany["ID"]);
                string Domain = QT.Entities.Common.Obj2String(rowCompany["Domain"]);
                PushCacheForCompany(CompanyID, Domain);
            }
        }

        private void PushCacheForCompany(long CompanyID, string Domain)
        {
            DataTable tblProduct = productAdapter.GetSqlDb().GetTblData("select ID, Price, Name, ImageUrls From Product a Where a.Company = @CompanyID",
                CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                    SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)
                });

                foreach (DataRow rowInfo in tblProduct.Rows)
                {
                    long ProductID = QT.Entities.Common.Obj2Int64(rowInfo["ID"]);
                    long Price = QT.Entities.Common.Obj2Int(rowInfo["Price"]);
                    string Name = QT.Entities.Common.Obj2String(rowInfo["Name"]);
                    string ImageUrl = QT.Entities.Common.Obj2String(rowInfo["ImageUrls"]);
                    long HashDuplicate = QT.Entities.Product.GetHashDuplicate(Domain, Price, Name, ImageUrl);
                    //RedisCacheLastUpdateProduct.Instance().SetLastUpdateProduct(ProductID, CompanyID, HashDuplicate);
                }

            this.Invoke(new Action(() =>
                {
                    richTextBox1.AppendText(string.Format("\r\n Pushed company: {0} - {1}", CompanyID, Domain));
                }));
        }
    }
}
