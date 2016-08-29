using log4net;
using Newtonsoft.Json;
using ProductHtmlLogCassandra;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;


namespace WSS.SaveHtmlCrawler
{
    class Program
    {

        ProductHtmlLogCassandraAdapter cassandraHtml = ProductHtmlLogCassandraAdapter.Instance;
        ILog log = log4net.LogManager.GetLogger(typeof(Program));
        string connection = ConfigurationManager.AppSettings["SqlConnection"].ToString();
        int MaxThread = Convert.ToInt32(ConfigurationManager.AppSettings["NumberThread"]);
        Random rand = new Random();


        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.RunProduct();
            Console.ReadLine();
        }

        private void RunProduct()
        {
            for (int i = 0; i < MaxThread; i++)
            {
                int j = i+1;
                Thread.Sleep(10000);
                Task workerTask = new Task(() => RunWOrd(j));
                workerTask.Start();
            }
        }

        private void RunWOrd(int iWork)
        {
            try
            {
                SqlDb slDb = new SqlDb(connection);
                log.Info("Start job:" + iWork.ToString());
                DataTable tblCompany = null;

                do
                {
                    DataTable tblUrlProduct = null;
                    Thread.Sleep(rand.Next(1, 20000));
                    tblCompany = slDb.GetTblData(@"sp_GetNextPage", CommandType.StoredProcedure, new System.Data.SqlClient.SqlParameter[] { });
                    if (tblCompany != null && tblCompany.Rows.Count > 0)
                    {
                        long CompanyID = Convert.ToInt64(tblCompany.Rows[0]["PageIndex"]);
                        int TimeDelay = Convert.ToInt32(tblCompany.Rows[0]["TimeDelay"]);
                        int TotalValid = Convert.ToInt32(tblCompany.Rows[0]["TotalValid"]);
                        int iPage = 1;

                        do
                        {
                            do
                            {
                                tblUrlProduct = slDb.GetTblData("prc_Product_GetProductOfCompanyByPage", CommandType.StoredProcedure
                                     , new System.Data.SqlClient.SqlParameter[]{
                        	SqlDb.CreateParamteterSQL("@page",iPage,SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@numberRowInPage",1000,SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@valid",1,SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@company",CompanyID,SqlDbType.BigInt)});
                                if (tblUrlProduct == null) Thread.Sleep(10000);
                                else
                                {
                                    iPage++;
                                    break;
                                }
                            } while (tblUrlProduct == null);

                            if (tblUrlProduct != null && tblUrlProduct.Rows.Count > 0)
                            {
                                for (int iRowInfo = 0; iRowInfo < tblUrlProduct.Rows.Count; iRowInfo++)
                                {
                                    DataRow rowInfo = tblUrlProduct.Rows[iRowInfo];
                                    long ProductID = Convert.ToInt64(rowInfo["ID"]);
                                    Thread.Sleep(TimeDelay);
                                    string ProductDetailUrl = QT.Entities.Common.Obj2String(rowInfo["DetailUrl"]);
                                    string Html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(ProductDetailUrl, 45, 2);
                                    if (Html != "")
                                    {
                                        int iRow = cassandraHtml.UpdateHtmlLog(ProductID, CompanyID, DateTime.Now, Html, ProductDetailUrl);
                                        string strLog = string.Format("W:{3}. C:{0}. PA:{1}. PT:{2}. R:{4}/{5}"
                                            , QT.Entities.Common.FixLengStrng(CompanyID.ToString(), 25)
                                            , QT.Entities.Common.FixLengStrng(iPage.ToString(), 4)
                                            , QT.Entities.Common.FixLengStrng(ProductID.ToString(), 25)
                                            , QT.Entities.Common.FixLengStrng(iWork.ToString(), 4)
                                            , ((iPage - 2) * 1000 + iRowInfo + 1).ToString()
                                            , TotalValid.ToString()
                                            );
                                        log.Info(strLog);
                                    }
                                }
                            }
                        } while (tblUrlProduct.Rows.Count > 1);

                        slDb.RunQuery("update PagePushSaveHtml set [status] = 1 where PageIndex =  @CompanyID", CommandType.Text, new SqlParameter[]{
                       slDb.CreateParamteter("CompanyID",CompanyID,SqlDbType.BigInt) });
                        Console.WriteLine(string.Format("{2}:Saved to page: {0}-{1}", CompanyID, tblUrlProduct.Rows.Count, CompanyID));
                    }

                }
                while (tblCompany != null && tblCompany.Rows.Count > 0);
            }
            catch (Exception ex01)
            {
                log.Error(ex01);
            }
        }

        private void Run()
        {
            for (int i = 0; i < MaxThread; i++)
            {
                RunAWork();
            }
        }

        private void RunAWork()
        {
            Task workerTask = new Task(() =>
            {
                int iRamdom = (new Random()).Next(0, 100);
                SqlDb slDb = new SqlDb(connection);
                log.Info("Start consumer!");
                DataTable tblCompany = null;
                do
                {
                    long compnayID = 0;
                    DataTable tblUrlProduct = null;
                    int pageCurrent = 1;

                    tblCompany = slDb.GetTblData(@"Select top 1 a.ID, Domain, Website, b.TimeDelay  from Company a 
                                                        inner join Configuration b on a.ID = b.CompanyID where Isnull(a.Process,0)=0 
                                                        and a.status = 1 and a.DataFeedType=0 and a.ID>0", CommandType.Text, new System.Data.SqlClient.SqlParameter[]
                        {
                            
                        });
                    if (tblCompany != null && tblCompany.Rows.Count > 0)
                    {
                        int TimeDelay = QT.Entities.Common.Obj2Int(tblCompany.Rows[0]["TimeDelay"]);
                        do
                        {
                            if (tblUrlProduct != null && tblUrlProduct.Rows.Count > 0)
                            {
                                Thread.Sleep(TimeDelay);
                                foreach (DataRow rowInfo in tblUrlProduct.Rows)
                                {
                                    long ProductID = Convert.ToInt64(rowInfo["ID"]);
                                    string ProductDetailUrl = QT.Entities.Common.Obj2String(rowInfo["DetailUrl"]);
                                    string Html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(ProductDetailUrl, 45, 2);
                                    if (Html != "")
                                    {
                                        int iRow = cassandraHtml.UpdateHtmlLog(ProductID, compnayID, DateTime.Now, Html, ProductDetailUrl);
                                        Console.WriteLine(string.Format("{2}:Saved to product:{0}-{1}-{3}", ProductID, ProductDetailUrl, iRamdom, iRow));
                                    }
                                }
                            }


                            tblUrlProduct = slDb.GetTblData("prc_Product_GetProductOfCompanyByPage", CommandType.StoredProcedure
                                , new System.Data.SqlClient.SqlParameter[]{
                        	SqlDb.CreateParamteterSQL("@page",pageCurrent++,SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@numberRowInPage",10000,SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@valid",1,SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@company",compnayID,SqlDbType.BigInt)});
                        }
                        while (tblUrlProduct.Rows.Count > 0);

                    }
                    slDb.RunQuery("Update Company set Process = 1 where ID = @CompanyID", CommandType.Text, new System.Data.SqlClient.SqlParameter[] {
                                    //SqlDb.CreateParamteterSQL("@Process",true,SqlDbType.Bit),
                                    SqlDb.CreateParamteterSQL("@ID",compnayID,SqlDbType.BigInt)
                                });

                    Console.WriteLine(string.Format("{2}:Saved to company: {0}-{1}", compnayID, "", iRamdom));
                }
                while (tblCompany != null && tblCompany.Rows.Count > 0);

            });
            workerTask.Start();
        }
    }
}
