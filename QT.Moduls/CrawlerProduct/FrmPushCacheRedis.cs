using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using StackExchange.Redis;
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
    public partial class FrmPushCacheRedis : Form
    {

        private Thread threadDoPushproduct = null;
        private Thread threadDoPushClassification = null;
        private ConnectionMultiplexer connectionMutilexer = null;
        private Thread threadDoPushproductHash;
        private List<long> lstCompany;

        public FrmPushCacheRedis()
        {
            InitializeComponent();
           
        }

        public FrmPushCacheRedis(List<long> lstCompany)
        {
        
            InitializeComponent();
            this.lstCompany = lstCompany;
        }

        private void btnPushCacheProduct_Click(object sender, EventArgs e)
        {
            this.btnPushCacheProduct.Visible = false;
            threadDoPushproduct = new Thread(() => PushProduct());
            threadDoPushproduct.Start();
        }

        private void PushProduct()
        {

            while (true)
            {
                try
                {
                    var productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                    DataTable tbl = productAdapter.GetListCompanyIDToPush();
                    foreach (DataRow row in tbl.Rows)
                    {
                        long companyID = Convert.ToInt64(row["ID"]);
                        string domain = Convert.ToString(row["Domain"]);
                        this.Invoke(new Action(() =>
                            {
                                lblCompany.Text = domain;
                            }));

                        int iPage = 0;
                        while (true)
                        {
                            DataTable tblProduct = productAdapter.GetTblProductPushRedisForCompany(companyID, iPage);
                            if (tblProduct.Rows.Count == 0) break;
                            iPage++;

                            this.Invoke(new Action(() =>
                                {

                                    lblPageIDProduct.Text = iPage.ToString();
                                }));

                            foreach (DataRow rowProduct in tblProduct.Rows)
                            {
                                long ProductID = Convert.ToInt64(rowProduct["ID"]);
                                long CompanyID = Convert.ToInt64(rowProduct["Company"]);
                                string ProductName = Common.Obj2String(rowProduct["Name"]);
                                int ProductPrice = Common.Obj2Int(rowProduct["Price"]);
                                bool Valid = Common.Obj2Bool(rowProduct["Valid"]);
                                string keyRedis = "product:" + ProductID.ToString();
                                int Status = Common.Obj2Int(rowProduct["Status"]);
                                string ImageUrl = Common.Obj2String(rowProduct["ImageUrls"]);
                                bool IsDea = Common.Obj2Bool(rowProduct["IsDeal"]);
                                long IDCategory = Common.Obj2Int64(rowProduct["ClassificationID"]);
                                if (!RedisCacheProductInfo.Instance().ExistsInCache(companyID, ProductID))
                                {
                                    int count = 0;
                                    while (true)
                                    {
                                        try
                                        {
                                     
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            count++;
                                            if (count > 5) break;
                                            else Thread.Sleep(1000);
                                        }
                                    }
                                }
                            }
                        }
                        productAdapter.UpdateLastSyncProductRedisForCompany(companyID);
                    }
                }
                catch (ThreadAbortException ex)
                {
                    return;
                }
                catch (Exception ex1)
                {
                    Thread.Sleep(1000);
                }
            }
        }

        private void btnPushClassification_Click(object sender, EventArgs e)
        {
            btnPushClassification.Visible = false;
            threadDoPushClassification = new Thread(()=>PuschClassification());
            threadDoPushClassification.Start();
        }

        public void PushClassificationForCompany(long companyID, ProductAdapter productAdapter, IDatabase redisDatabase)
        {
            DataTable tblClassification = productAdapter.GetTblClassificationPushRedisForCompany(companyID);
            foreach (DataRow rowClassification in tblClassification.Rows)
            {
                long ClassificationID = Convert.ToInt64(rowClassification["ID"]);
                int count = 0;
                while (true)
                {
                    try
                    {
                        redisDatabase.SetAdd("classification", ClassificationID.ToString());
                        break;
                    }
                    catch (Exception ex)
                    {
                        count++;
                        if (count > 5) break;
                        else Thread.Sleep(1000);
                    }
                }
            }
            productAdapter.UpdateLastSyncClassificationRedisForCompany(companyID);
        }

        private void PuschClassification()
        {

            while (true)
            {
                try
                {
                    IDatabase redisDatabase = this.connectionMutilexer.GetDatabase(8);
                    var productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                    DataTable tbl = productAdapter.GetListCompanySynClassification();
                    if (tbl.Rows.Count == 0) return;
                    foreach (DataRow row in tbl.Rows)
                    {
                        long companyID = Convert.ToInt64(row["ID"]);
                        string domain = Convert.ToString(row["Domain"]);
                        this.Invoke(new Action(() =>
                        {
                            lblCompanyClasification.Text = domain;
                        }));
                        PushClassificationForCompany(companyID,productAdapter, redisDatabase);
                    }
                }
                catch (ThreadAbortException ex)
                {
                    return;
                }
                catch (Exception ex1)
                {
                    Thread.Sleep(1000);
                }
            }
        }

        private void FrmPushCacheRedis_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.threadDoPushproduct != null && this.threadDoPushproduct.IsAlive) this.threadDoPushproduct.Abort();
            if (this.threadDoPushClassification != null && this.threadDoPushClassification.IsAlive) this.threadDoPushClassification.Abort();
            if (this.threadDoPushproductHash != null && this.threadDoPushproductHash.IsAlive) this.threadDoPushproductHash.Abort();
        }

        private void btnPushProductByHash_Click(object sender, EventArgs e)
        {
            this.btnPushProductByHash.Visible = false;
            threadDoPushproductHash = new Thread(() => PushProductHash());
            threadDoPushproductHash.Start();
        }

        private void PushProductHash()
        {
            while (true)
            {
                try
                {
                    if (this.lstCompany == null || lstCompany.Count == 0)
                    {
                        var redisDatabase = this.connectionMutilexer.GetDatabase(3);
                        var productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                        DataTable tbl = productAdapter.GetListHashCompanyID();
                        foreach (DataRow row in tbl.Rows)
                        {
                            this.Invoke(new Action(() =>
                            {
                                lblPageHash.Text = row["Domain"].ToString(); ;
                            }));
                            PushHashNameOfProduct(Convert.ToInt64(row["ID"]), Convert.ToString(row["Domain"]), productAdapter, redisDatabase);

                        }
                    }
                    else
                    {
                        var redisDatabase = this.connectionMutilexer.GetDatabase(3);
                        var productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                        foreach (var item in lstCompany)
                        {
                            PushHashNameOfProduct(item, "", productAdapter, redisDatabase);
                        }
                        this.Invoke(new Action(() =>
                            {
                                label1.Text = "Success";
                            }));
                        break;
                    }
                }
                catch (ThreadAbortException ex)
                {
                    return;
                }
                catch (Exception ex1)
                {
                    Thread.Sleep(1000);
                }
            }
        }

        public void PushHashNameOfProduct(long companyID, string domain, ProductAdapter productAdapter, IDatabase redisDatabase)
        {
            int iPage = 0;
            while (true)
            {
                DataTable tblProduct = productAdapter.GetTblProductHashPushRedisForCompany(companyID, iPage);
                if (tblProduct.Rows.Count == 0) break;
                iPage++;

                foreach (DataRow rowProduct in tblProduct.Rows)
                {
                    string Name = Common.Obj2String(rowProduct["Name"]);
                    int Price = Common.Obj2Int(rowProduct["Price"]);
                    string ImageUrl = Common.Obj2String(rowProduct["ImageUrls"]);
                    long ID = Common.Obj2Int64(rowProduct["ID"]);

                    string a = domain + "_" + Name + "_" + Price.ToString() + "_" + ImageUrl;
                    string key = "dumplicate_product:" + Math.Abs(
                        GABIZ.Base.Tools.getCRC64(Price.ToString() + Name + ImageUrl));
                    int count = 0;
                    while (true)
                    {
                        try
                        {
                            redisDatabase.SetAdd(key, ID.ToString());
                            break;
                        }
                        catch (Exception ex)
                        {
                            count++;
                            if (count > 5) break;
                            else Thread.Sleep(1000);
                        }
                    }
                }
            }
            productAdapter.UpdateLastSyncProductHashRedisForCompany(companyID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CountProduct = 0;
            Thread thread = new Thread(new ThreadStart(() =>
                {
                    while (true)
                    {
                        try
                        {
                            int numberRun = 0;

                            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                            DataTable tblCompany = productAdapter.GetSqlDb().GetTblData("select ID, Domain From Company Where [status] =1 And DataFeedType=0 And [LastSyncProductToRedis]<'2015-10-30 17:00:00'",
                                CommandType.Text, new System.Data.SqlClient.SqlParameter[]{});

                            foreach(DataRow row in tblCompany.Rows)
                            {
                                long CompanyID = Convert.ToInt64(row["ID"]);
                                string Domain = Convert.ToString(row["Domain"]);
                                string sql = string.Format(@"select top 1000 * 
                                                from Product
                                                where IsNews = 1
                                                and Company=0
                                                and DetailUrl like '%{1}%'
                                                order by LastUpdate asc", CompanyID.ToString(), Domain);
                                DataTable tblProduct = productAdapter.GetSqlDb().GetTblData(sql);
                                foreach(DataRow rowProduct in tblProduct.Rows)
                                {
                                    long ProductID = Convert.ToInt64(rowProduct["ID"]);
                                    productAdapter.GetSqlDb().RunQuery("update product set LastUpdate = GetDate(), Company = @Company where ID = @Id", CommandType.Text,
                                        new System.Data.SqlClient.SqlParameter[]{
                                            SqlDb.CreateParamteterSQL("ID",ProductID, SqlDbType.BigInt)
                                        });


                                }
                                productAdapter.GetSqlDb().RunQuery("Update Company Set LastSyncProductToRedis = GetDate() Where Id = @Id",CommandType.Text
                                    , new System.Data.SqlClient.SqlParameter[]{
                                        SqlDb.CreateParamteterSQL("Id",CompanyID,SqlDbType.BigInt)
                                    });
                                
                                CountProduct++;
                                this.Invoke(new Action(()=>
                                {
                                    btnDelProductError.Text = CountProduct.ToString();
                                }));
                               
                            }

                        }
                        catch (Exception ex)
                        {
                            Thread.Sleep(1000);
                        }
                    }
                }));
            thread.Start();
        }
    }
}
