using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmUpdateCategory : Form
    {
        ProductAdapter pa = new ProductAdapter();
        SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
        private DataTable tblProduct = null;
        private long CompanyID = 0;
        private long ProductID = 0;
        public FrmUpdateCategory(long _CompanyID)
        {
            InitializeComponent();
            this.CompanyID = _CompanyID;
        }

        private void FrmUpdateCategory_Load(object sender, EventArgs e)
        {
            Thread Runner = new Thread(() => Update());
            Runner.Start();
        }
        private void Update()
        {
            tblProduct = sqldb.GetTblData("Select ID from Product where Company = @CompanyID", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { 
                SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt)
            });
            foreach (DataRow CompanyInfo in tblProduct.Rows)
            {
                ProductID = QT.Entities.Common.Obj2Int64(CompanyInfo["ID"]);
                sqldb.RunQuery("prc_Product_AutoFindCategoryID", CommandType.StoredProcedure, new System.Data.SqlClient.SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@ProductID",ProductID,SqlDbType.BigInt)
                });
                this.Invoke(new Action(() =>
                {
                    lblProduct.Text = ProductID.ToString();
                }));
            }
            this.Invoke(new Action(() =>
            {
                lblProduct.Text = "Done!";
            }));
        }
    }
}
