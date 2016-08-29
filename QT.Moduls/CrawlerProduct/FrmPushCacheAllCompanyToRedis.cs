using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Moduls.Company;
using QT.Entities;
using QT.Entities.Data;
using QT.Entities.CrawlerProduct;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmPushCacheAllCompanyToRedis : Form
    {

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmPushCacheAllCompanyToRedis));

        public FrmPushCacheAllCompanyToRedis()
        {
            InitializeComponent();

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            long CompanyID = QT.Entities.Common.Obj2Int64(txtCompanyID.Text);
            Task.Factory.StartNew(new Action(() =>
            {
                this.Invoke(new Action(() =>
                {
                    try
                    {
                        richTextBox1.AppendText("\r\nStart push!");
                    }
                    catch (Exception ex01)
                    {

                    }
                }));

                SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
                DBCom.CompanyDataTable comTable = new DBCom.CompanyDataTable();
                DataTable proTable = new DataTable();
                if (CompanyID == 0)
                {
                    companyTableAdapter.SelectCompany_ByStatus(comTable);
                }
                else
                {
                    DataRow rowInfo = comTable.NewRow();
                    rowInfo["ID"] = CompanyID;
                    comTable.Rows.Add(rowInfo);
                }

                for (int i = 0; i < comTable.Rows.Count; i++)
                {
                    CompanyID = long.Parse(comTable.Rows[i]["ID"].ToString());
                    if (CompanyID == 0) continue;
                    
                    long lastProduct = 0;
                    do
                    {
                        proTable = sqldb.GetTblData(@"SELECT TOP 10000     InStock,  ID,ClassificationID, Status, Valid, Price, Name, ImageUrls, IsDeal, IsNews
                                                    FROM            Product
                                                    WHERE        (Company = @CompanyID) AND (ID > @IDBegin)
                                                    ORDER BY ID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("IDBegin",lastProduct,SqlDbType.BigInt)});

                        if (proTable.Rows.Count > 50) log.Info("cccccccccccccc:" + CompanyID.ToString() + " : " + proTable.Rows.Count);

                        for (int j = 0; j < proTable.Rows.Count; j++)
                        {
                            try
                            {
                                long ProductID = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["ID"].ToString());
                                lastProduct = ProductID;
                                int InStock = QT.Entities.Common.Obj2Int(proTable.Rows[j]["InStock"].ToString());
                                bool Valid = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["Valid"].ToString());
                                long Price = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["Price"].ToString());
                                string Name = QT.Entities.Common.Obj2String(proTable.Rows[j]["Name"].ToString());
                                bool IsNew = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["IsNews"]);
                                string ImageUrl = proTable.Rows[j]["ImageUrls"].ToString();
                                bool IsDeal = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["IsDeal"].ToString());
                                long CategoryID = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["ClassificationID"].ToString());

                            }
                            catch (Exception ex01)
                            {
                                log.Error(ex01);
                            }
                        }

                        this.Invoke(new Action(() =>
                        {
                            try
                            {
                                richTextBox1.AppendText("\r\nPushed 10000 item for company:" + CompanyID.ToString());
                            }
                            catch (Exception ex01)
                            {

                            }
                        }));
                    } while (proTable.Rows.Count > 0);

                    this.Invoke(new Action(() =>
                    {
                        try
                        {
                            richTextBox1.AppendText(string.Format("\r\n Success compnay:{0} {1}/{2}", CompanyID, i, comTable.Rows.Count));
                        }
                        catch (Exception ex01)
                        {

                        }
                    }));
                    log.Info(CompanyID);
                }
                MessageBox.Show("Done");
            }));


        }

        private void btnPushCheckDumplicate_Click(object sender, EventArgs e)
        {
            string strDomain = this.txtCompanyID.Text;
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            Task.Factory.StartNew(new Action(() =>
            {
                this.Invoke(new Action(() =>
                {
                    try
                    {
                        richTextBox1.AppendText("\r\nStart push!");
                    }
                    catch (Exception ex01)
                    {
                    }
                }));

                SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
                DataTable comTable = productAdapter.GetCompanyCrawler(strDomain);
                DataTable proTable = new DataTable();
                for (int i = 0; i < comTable.Rows.Count; i++)
                {
                    long CompanyID =QT.Entities.Common.Obj2Int64(comTable.Rows[i]["ID"].ToString());
                    string Domain = QT.Entities.Common.Obj2String(comTable.Rows[i]["Domain"]).ToString();
                    long lastProduct = 0;
                    do
                    {
                        for (int j = 0; j < proTable.Rows.Count; j++)
                        {
                            try
                            {
                                long ProductID = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["ID"].ToString());
                                lastProduct = ProductID;
                                int InStock = QT.Entities.Common.Obj2Int(proTable.Rows[j]["InStock"].ToString());
                                bool Valid = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["Valid"].ToString());
                                long Price = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["Price"].ToString());
                                string Name = QT.Entities.Common.Obj2String(proTable.Rows[j]["Name"].ToString());
                                bool IsNew = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["IsNews"]);
                                string ImageUrl = proTable.Rows[j]["ImageUrls"].ToString();
                                bool IsDeal = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["IsDeal"].ToString());
                                long CategoryID = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["ClassificationID"].ToString());
                                QT.Moduls.CrawlerProduct.Cache.RedisCheckDuplicateAdapter.Instace().SetCheckDuplicate(CompanyID, ProductID, Domain, Price, Name, ImageUrl, Valid);
                            }
                            catch (Exception ex01)
                            {
                                log.Error(ex01);
                            }
                        }

                        this.Invoke(new Action(() =>
                        {
                            try
                            {
                                richTextBox1.AppendText(string.Format("\r\nPushed {0} item for company {1} :", proTable.Rows.Count, CompanyID.ToString()));
                            }
                            catch (Exception ex01)
                            {

                            }
                        }));

                        proTable = sqldb.GetTblData(@"SELECT 50000 InStock,  ID, ClassificationID, Status, Valid, Price, Name, ImageUrls, IsDeal, IsNews
FROM            Product
WHERE        (Company = @CompanyID) AND (ID > @IDBegin) AND Valid = 1
ORDER BY ID"
                            , CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("IDBegin",lastProduct,SqlDbType.BigInt)}, null, true);

                    } while (proTable.Rows.Count > 0);

                    this.Invoke(new Action(() =>
                    {
                        try
                        {
                            richTextBox1.AppendText(string.Format("\r\n Success compnay:{0} {1}/{2}", CompanyID, i, comTable.Rows.Count));
                        }
                        catch (Exception ex01)
                        {

                        }
                    }));
                    log.Info(CompanyID);
                }
                MessageBox.Show("Done");
            }));
        }

        private void FrmPushCacheAllCompanyToRedis_Load(object sender, EventArgs e)
        {

        }

        private void btnDelFailRegexPath_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete product fail link?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                ProductAdapter productAdapter = new ProductAdapter(new Entities.Data.SqlDb(QT.Entities.Server.ConnectionString));
                int numberDelete = productAdapter.DeleteProductFailRegex(txtCompanyID.Text);
                this.richTextBox1.AppendText(string.Format("\r\n Deleleted {0} products!", numberDelete));
                if ( (numberDelete>0) &&MessageBox.Show("Do you want to refresh cache in solr?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==System.Windows.Forms.DialogResult.Yes)
                {
                    long CompanyID = productAdapter.GetCompanyIDFromDomain(txtCompanyID.Text);
                    productAdapter.PushQueueIndexCompany(CompanyID);
                    MessageBox.Show("Pushed message");
                }
            }
        }

        private void btnVisibleAllDumplicate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("NoValid All Dumplicate?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                ProductAdapter productAdapter = new ProductAdapter(new Entities.Data.SqlDb(QT.Entities.Server.ConnectionString));
                int numberDelete = productAdapter.NoValidProductDuplicate(txtCompanyID.Text);
                this.richTextBox1.AppendText(string.Format("\r\n Deleleted {0} products!", numberDelete));
                if (numberDelete > 0 && MessageBox.Show("Do you want to refresh cache in solr?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    long CompanyID = productAdapter.GetCompanyIDFromDomain(txtCompanyID.Text);
                    productAdapter.PushQueueIndexCompany(CompanyID);
                    MessageBox.Show("Pushed message");
                }
            }
        }

        //private void btnPush_Click(object sender, EventArgs e)
        //{
        //    long ProductID = QT.Entities.Common.Obj2Int64(txtProductID.Text);
        //    DBCom.ProductDataTable proTable = new DBCom.ProductDataTable();

        //    productTableAdapter.FillBy_ProductID(proTable, ProductID);

        //    long CompanyID = QT.Entities.Common.Obj2Int64(proTable.Rows[0]["Company"].ToString());

        //    int Status = QT.Entities.Common.Obj2Int(proTable.Rows[0]["Status"].ToString());
        //    bool Valid = QT.Entities.Common.Obj2Bool(proTable.Rows[0]["Valid"].ToString());
        //    long Price = QT.Entities.Common.Obj2Int64(proTable.Rows[0]["Price"].ToString());
        //    string Name = proTable.Rows[0]["Name"].ToString();
        //    string ImageUrl = proTable.Rows[0]["ImageUrls"].ToString();
        //    bool IsDeal = QT.Entities.Common.Obj2Bool(proTable.Rows[0]["IsDeal"].ToString());
        //    long CategoryID = QT.Entities.Common.Obj2Int64(proTable.Rows[0]["ClassificationID"].ToString());

        //    RedisProductInfoAdapter.SyncProductInfoToRedis(CompanyID, ProductID, Status, Valid, Price, Name, ImageUrl, IsDeal, CategoryID);
        //}

        //private void simpleButton1_Click(object sender, EventArgs e)
        //{
        //    long lastProduct = 0;
        //    long CompanyID = QT.Entities.Common.Obj2Int64(txtCompany.Text);
        //    DBCom.ProductDataTable proTable = new DBCom.ProductDataTable();
        //    productTableAdapter.SelectProduct_ByCompanyID(proTable, CompanyID, lastProduct);
        //    for (int i = 0; i < proTable.Rows.Count; i++)
        //    {
        //        long ProductID = QT.Entities.Common.Obj2Int64(proTable.Rows[i]["ID"].ToString());
        //        int Status = QT.Entities.Common.Obj2Int(proTable.Rows[i]["Status"].ToString());
        //        bool Valid = QT.Entities.Common.Obj2Bool(proTable.Rows[i]["Valid"].ToString());
        //        long Price = QT.Entities.Common.Obj2Int64(proTable.Rows[i]["Price"].ToString());
        //        string Name = proTable.Rows[i]["Name"].ToString();
        //        string ImageUrl = proTable.Rows[i]["ImageUrls"].ToString();
        //        bool IsDeal = QT.Entities.Common.Obj2Bool(proTable.Rows[i]["IsDeal"].ToString());
        //        long CategoryID = QT.Entities.Common.Obj2Int64(proTable.Rows[i]["ClassificationID"].ToString());

        //        RedisProductInfoAdapter.SyncProductInfoToRedis(CompanyID, ProductID, Status, Valid, Price, Name, ImageUrl, IsDeal, CategoryID);
        //    }
        //}
    }
}
