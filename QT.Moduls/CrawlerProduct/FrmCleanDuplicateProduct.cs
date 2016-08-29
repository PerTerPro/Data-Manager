using QT.Entities;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmCleanDuplicateProduct : Form
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmCleanDuplicateProduct));

        private long companyID = 0;
        private string Domain = string.Empty;
        private SqlDb sql = new SqlDb(QT.Entities.Server.ConnectionString);
        private DataTable tblProduct = null;
        private DataTable tblCompany = null;
        private enum Cleantype
        {
            CleanOne = 1,
            CleanAll = 2
        }
        private int Type;

        public FrmCleanDuplicateProduct()
        {
            InitializeComponent();
        }
        private void FrmCleanDuplicateProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnCleanOne_Click(object sender, EventArgs e)
        {
            Type = (int)Cleantype.CleanOne;
            if (!string.IsNullOrEmpty(txtDomain.Text))
            {
                Domain = txtDomain.Text;
                tblCompany = sql.GetTblData("Select ID,Domain from Company where (Domain = @Domain) and Status = 1 and DataFeedType = 0", CommandType.Text, new SqlParameter[]{
                    sql.CreateParamteter("Domain",Domain,SqlDbType.NVarChar)
                });
                if (tblCompany != null)
                {
                    companyID = QT.Entities.Common.Obj2Int64(tblCompany.Rows[0]["ID"]);
                    Thread Clean = new Thread(() => CleanDuplicate(companyID, Domain));
                    Clean.Start();
                }
                else
                {
                    MessageBox.Show("Domain sai hoặc chưa có trong hệ thống!");
                }

            }
            else
            {
                MessageBox.Show("Phải nhập Domain");
            }
            lblDone.Text = "Done!";
        }

        private void btnCleanAll_Click(object sender, EventArgs e)
        {
            Type = (int)Cleantype.CleanAll;
            tblCompany = sql.GetTblData("Select * from Company where Status = 1 and DatafeedType = 0");
            for (int i = 0; i < tblCompany.Rows.Count; i++)
            {
                companyID = QT.Entities.Common.Obj2Int64(tblCompany.Rows[i]["ID"]);
                Domain = tblCompany.Rows[i]["Domain"].ToString();
                CleanDuplicate(companyID, Domain);
            }
            
        }

        public void UpdateDataToSql (List<string> lstProduct, ProductAdapter productAdapter, bool bRun = false)
        {
            if (lstProduct.Count > 200 || bRun == true)
            {
                string query = QT.Entities.Common.ConvertToString(lstProduct, ";");
                if (query != "")
                {
                    productAdapter.GetSqlDb().RunQuery(query, CommandType.Text, null, true);
                    log.Info(string.Format("Saved {0} data", lstProduct.Count.ToString()));
                    lstProduct.Clear();
                }
            }
        }

        public void CleanDuplicate(long companyID, string Domain)
        {
            List<string> lstQuery = new List<string>();
            string parternUpdate = "Update Product Set ProductDuplicate = {0} WHERE ID = {1}";
            Dictionary<long, long> dicHash = new Dictionary<long, long>();
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            tblProduct = sql.GetTblData("Select ID, Name, Price, ImageUrls from Product where Company = @CompanyID and Valid = 1", CommandType.Text, new SqlParameter[] { SqlDb.CreateParamteterSQL("@CompanyID", companyID, SqlDbType.BigInt) });
            if (tblProduct != null)
            {
                foreach (DataRow RowInfo in tblProduct.Rows)
                {
                    long Price = QT.Entities.Common.Obj2Int64(RowInfo["Price"]);
                    string Name = RowInfo["Name"].ToString();
                    string ImageUrl = RowInfo["ImageUrls"].ToString();
                    long ProductID = QT.Entities.Common.Obj2Int64(RowInfo["ID"]);
                    long HashDuplicate = QT.Entities.Product.GetHashDuplicate(Domain, Price, Name, ImageUrl);

                    if (!dicHash.ContainsKey(HashDuplicate))
                    {
                        dicHash.Add(HashDuplicate, ProductID);
                        QT.Moduls.CrawlerProduct.Cache.RedisCheckDuplicateAdapter.Instace().SetCheckDuplicate(companyID, ProductID, Domain, Price, Name, ImageUrl, true);
                        if (Type == (int)Cleantype.CleanOne)
                        {
                            DataTable tblProductCount = sql.GetTblData("Select Count(*) as ProductCount from Product where Company = @CompanyID", CommandType.Text, new SqlParameter[] { 
                            sql.CreateParamteter("CompanyID",companyID,SqlDbType.BigInt)
                            });
                            int ProductCount = QT.Entities.Common.Obj2Int(tblProductCount.Rows[0]["ProductCount"]);
                            this.Invoke(new Action(() =>
                            {
                                try
                                {
                                    richTextBox1.AppendText(string.Format("{0} : {1}, {2} \n", ProductID, Name, Price));
                                    lblSpThucTe.Text = dicHash.Count.ToString();
                                    lblTongSanPham.Text = ProductCount.ToString();
                                }
                                catch (Exception ex01)
                                {
                                }
                            }));
                        }
                        if (Type == (int)Cleantype.CleanAll)
                        {
                            DataTable tblCompanyCount = sql.GetTblData("Select Count(*) as CompanyCount from Company where Status = 1 and DatafeedType = 0");
                            int CompanyCount = QT.Entities.Common.Obj2Int(tblCompanyCount.Rows[0]["CompanyCount"]);
                            this.Invoke(new Action(() =>
                            {
                                try
                                {
                                    richTextBox1.AppendText(string.Format("{0} : Complete\n",companyID));
                                    lblTongSanPham.Text = CompanyCount.ToString();
                                }
                                catch (Exception ex01)
                                {
                                }
                            }));
                        }
                        
                    }
                    else
                    {
                        sql.RunQuery("Update Product Set Valid = 0, LastUpdate = GetDate() where ID = @ProductID", CommandType.Text, new SqlParameter[] { 
                                sql.CreateParamteter("@ProductID",ProductID,SqlDbType.BigInt)});
                    }
                }
            }

            if (MessageBox.Show("Do you want to push job?", Domain.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                productAdapter.PushQueueIndexCompany(companyID);
                MessageBox.Show("Success!");
            }
            
        }

        private void btnSetDataDumplicate(object sender, EventArgs e)
        {
            Type = (int)Cleantype.CleanOne;
            Domain = txtDomain.Text;
            if (!string.IsNullOrEmpty(txtDomain.Text))
            {
                tblCompany = sql.GetTblData("Select ID,Domain from Company where (Domain = @Domain) and Status = 1 and DataFeedType = 0", CommandType.Text, new SqlParameter[]{
                    sql.CreateParamteter("Domain",Domain,SqlDbType.NVarChar)
                });
                companyID = QT.Entities.Common.Obj2Int64(tblCompany.Rows[0]["ID"]);
                Domain = QT.Entities.Common.Obj2String(tblCompany.Rows[0]["Domain"]);
            }

            Task.Factory.StartNew(() =>
                {
                    if (companyID > 0)
                    {
                        SetDuplicateData(companyID, Domain);
                    }
                    else
                    {
                        tblCompany = sql.GetTblData("Select * from Company where Status = 1 and DatafeedType = 0 And TotalProduct>0 Order By ID ASC");
                        for (int i = 0; i < tblCompany.Rows.Count; i++)
                        {
                            companyID = QT.Entities.Common.Obj2Int64(tblCompany.Rows[i]["ID"]);
                            Domain = tblCompany.Rows[i]["Domain"].ToString();
                            SetDuplicateData(companyID, Domain);
                        }
                    }
                    this.ReportData("Run Success!");
                });
        }

        private void SetDuplicateData(long CompanyID, string Domain)
        {
            List<string> lstQuery = new List<string>();
            string parternUpdate = "Update Product Set ProductDuplicate = {0}, IsBlackList =  1, Valid = 0, LastUpdate = GETDATE()  WHERE ID = {1}";
            Dictionary<long, long> dicHash = new Dictionary<long, long>();
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            int iPage = 1;
            do
            {
                tblProduct = sql.GetTblData("prc_Product_GetProductByPageSetDupData", CommandType.StoredProcedure
                    , new SqlParameter[] { SqlDb.CreateParamteterSQL("@CompanyID", companyID, SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("@Page",iPage++,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("@NumberRowInPage",50000,SqlDbType.Int)}, null, true, 30);
                if (tblProduct != null)
                {
                    foreach (DataRow RowInfo in tblProduct.Rows)
                    {
                        long Price = QT.Entities.Common.Obj2Int64(RowInfo["Price"]);
                        string Name = RowInfo["Name"].ToString();
                        string ImageUrl = RowInfo["ImageUrls"].ToString();
                        long ProductID = QT.Entities.Common.Obj2Int64(RowInfo["ID"]);
                        long HashDuplicate = QT.Entities.Product.GetHashDuplicate(Domain, Price, Name, ImageUrl);
                        bool Valid = QT.Entities.Common.Obj2Bool(RowInfo["Valid"]);
                        long IDCurrent = QT.Moduls.CrawlerProduct.Cache.RedisCheckDuplicateAdapter.Instace().GetProductIDOfHash(CompanyID, HashDuplicate);
                        if (Price > 1000 && Name != "" && ImageUrl != "")
                        {
                            if (IDCurrent == 0 && Valid == true)
                            {
                                QT.Moduls.CrawlerProduct.Cache.RedisCheckDuplicateAdapter.Instace().SetCheckDuplicate(companyID, ProductID, Domain, Price, Name, ImageUrl, Valid);
                            }
                            else if (IDCurrent != ProductID)
                            {
                                lstQuery.Add(string.Format(parternUpdate, IDCurrent, ProductID));
                                UpdateDataToSql(lstQuery, productAdapter);
                            }
                        }
                    }
                }
            } while (tblProduct.Rows.Count > 0);
            UpdateDataToSql(lstQuery, productAdapter, true);
            this.ReportData("\r\nSuccess company:" + companyID.ToString());
        }

        private void ReportData(string report)
        {
            log.Info(report);
            this.Invoke(new Action(() =>
              {
                  this.richTextBox1.AppendText(report);
              }));
        }
        private DataTable tblDuplicateErrors = null;
        private void btnSetDuplicateErrors_Click(object sender, EventArgs e)
        {
            tblCompany = sql.GetTblData("select * from Company where Status = 1 and DatafeedType = 0", CommandType.Text, new SqlParameter[] { });
            foreach (DataRow RowInfo in tblCompany.Rows)
            {
                companyID = QT.Entities.Common.Obj2Int64(RowInfo["ID"]);
                Domain = QT.Entities.Common.Obj2String(RowInfo["Domain"]);
                tblDuplicateErrors = sql.GetTblData("prc_Report_DuplicateProductForCompany", CommandType.StoredProcedure, new SqlParameter[] { 
                sql.CreateParamteter("@CompanyID",companyID,SqlDbType.BigInt)
            });

                if (tblDuplicateErrors.Rows.Count > 0)
                {
                    foreach (DataRow DuplicateErrorsDRowInfo in tblDuplicateErrors.Rows)
                    {
                        SetDuplicateData(companyID, Domain);
                    }
                }
            }
            
        }
    }
}
