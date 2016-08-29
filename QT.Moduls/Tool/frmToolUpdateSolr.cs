using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Bussiness;
using GABIZ.Base;

namespace QT.Moduls.Tool
{
    public partial class frmToolUpdateSolr : QT.Entities.frmBase
    {
        public frmToolUpdateSolr()
        {
            InitializeComponent();
            InitSolrUrls();
        }
        private Thread downloadThread;
        private Thread UpdateLogThread;
        private Thread UpdateSolrProductID;

        private void InitSolrUrls()
        {
            var solrUrlsString = ConfigurationManager.AppSettings["solrProducts"];
            var solrUrls = solrUrlsString.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var solrNodes = new Dictionary<string, string>();
            for (int index = 0; index < solrUrls.Length; index++)
            {
                solrNodes.Add("node" + index, solrUrls[index]);
            }
            SolrDriver.Init(solrNodes);
            foreach (var solrNode in solrNodes)
            {
                comboBoxSolrNodes.Items.Add(new SolrNodeItem() { NodeID = solrNode.Key, NodeUrl = solrNode.Value });
            }
            if (comboBoxSolrNodes.Items.Count > 0)
            {
                comboBoxSolrNodes.SelectedIndex = 0;
            }
        }

        void doUpdateLog()
        {

            int timeDelay = 0;
            //bool isMonth = true;
            this.Invoke((MethodInvoker)delegate
            {
                this.laMess1.Text = String.Format("Start download List Log");
                //if (rdMonth.Checked)
                //{ isMonth = true; }
                //else
                //{
                //    isMonth = false;
                //}
            });

            DBTool2.View_Product_Logs_IDDataTable dtLog = new DBTool2.View_Product_Logs_IDDataTable();
            DBTool2.View_Product_Logs_IDDataTable dtLogWeek = new DBTool2.View_Product_Logs_IDDataTable();
            DBTool2TableAdapters.View_Product_Logs_IDTableAdapter adtLog = new DBTool2TableAdapters.View_Product_Logs_IDTableAdapter();
            DBTool2TableAdapters.ProductTableAdapter adtProduct = new DBTool2TableAdapters.ProductTableAdapter();
            adtLog.Connection.ConnectionString = QT.Entities.Server.LogConnectionString;
            adtProduct.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            try
            {
                    adtLog.Fill_ListLogFromDate(dtLog, DateTime.Now.AddDays(-30));
                    adtLog.Fill_ListLogFromDate(dtLogWeek, DateTime.Now.AddDays(-7));
            }
            catch (Exception)
            {
            }
            int x = 0;
            ///UPDATE       Product
            //SET                ViewCount = @ViewCount
            //WHERE        (ID = @Original_ID)
            Boolean checkZencode = false;
            string f = "UPDATE Product SET ViewCount = {0} WHERE (ID = {1})\n";
            string sql = "";
            this.Invoke((MethodInvoker)delegate
            {
                checkZencode = chkEdite.Checked;
            });
            if (checkZencode)
            {
                foreach (DBTool2.View_Product_Logs_IDRow dr in dtLog)
                {
                    sql += string.Format(f, dr.Tong, dr.IDProduct);
                    x++;
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.laMess1.Text = String.Format("zencode {0}/{1} ViewCount= {2}  ", x, dtLog.Count, dr.Tong);
                    });
                }
                this.Invoke((MethodInvoker)delegate
                {
                    memoCode.Text = sql;
                });
            }
            else
            {
                
                foreach (DBTool2.View_Product_Logs_IDRow dr in dtLogWeek)
                {
                    try
                    {
                        adtProduct.UpdateQuery_ViewCountWeek(dr.Tong, dr.IDProduct);
                    }
                    catch (Exception)
                    {
                    }
                    x++;
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.laMess1.Text = String.Format("Update Week {0}/{1} ViewCount= {2}  ", x, dtLog.Count, dr.Tong);
                        timeDelay = QT.Entities.Common.Obj2Int(this.txtTimeDelay.Text.Trim());
                    });
                    Thread.Sleep(timeDelay);
                }
                foreach (DBTool2.View_Product_Logs_IDRow dr in dtLog)
                {
                    try
                    {
                        adtProduct.UpdateQuery_ViewCount(dr.Tong, dr.IDProduct);
                    }
                    catch (Exception)
                    {
                    }
                    x++;
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.laMess1.Text = String.Format("Update Month {0}/{1} ViewCount= {2}  ", x, dtLog.Count, dr.Tong);
                        timeDelay = QT.Entities.Common.Obj2Int(this.txtTimeDelay.Text.Trim());
                    });
                    Thread.Sleep(timeDelay);
                }

            }
            this.Invoke((MethodInvoker)delegate
            {
                this.laMess1.Text = "Finish";
            });
        }
        void doUpdate()
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.laMess1.Text = String.Format("Start download List company");
            });
            DBTool.CompanyDataTable dtCom = new DBTool.CompanyDataTable();
            DBToolTableAdapters.CompanyTableAdapter adtCom = new DBToolTableAdapters.CompanyTableAdapter();
            adtCom.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            DBTool2.Product_SolrDataTable dtProduct = new DBTool2.Product_SolrDataTable();
            DBTool2TableAdapters.Product_SolrTableAdapter adtProduct = new DBTool2TableAdapters.Product_SolrTableAdapter();
            adtProduct.Connection.ConnectionString = QT.Entities.Server.ConnectionString;

            adtCom.FillBy_WebsiteCoSanPham(dtCom);
            int x = 0;
            foreach (DBTool.CompanyRow drCom in dtCom)
            {
                x++;
                this.Invoke((MethodInvoker)delegate
                {
                    this.laMess1.Text = String.Format("Update {1}/{2} Company {0}  ", drCom.Domain.ToString(), x, dtCom.Count);
                });
                try
                {
                    adtProduct.FillBy_Company(dtProduct, drCom.ID);
                }
                catch (Exception)
                {
                }
                SolrDriver.DeleteByCompanyId(drCom.ID);
                int count = 0;
                List<SolrProductItem> ls = new List<SolrProductItem>();

                for (int i = 0; i < dtProduct.Rows.Count; i++)
                {
                    DataRow dr = dtProduct.Rows[i];
                    try
                    {
                        SolrProductItem item = new SolrProductItem
                        {
                            Id = QT.Entities.Common.Obj2Int64(dr["ID"]),
                            Price = QT.Entities.Common.Obj2Int(dr["Price"]),
                            Warranty = QT.Entities.Common.Obj2Int(dr["Warranty"]),
                            Status = QT.Entities.Common.Obj2Int(dr["Status"]),
                            Company = QT.Entities.Common.Obj2Int64(dr["Company"]),
                            LastUpdate = QT.Entities.Common.ObjectToDataTime(dr["LastUpdate"]),
                            Summary = dr["Summary"].ToString(),
                            Description = "",
                            ProductId = QT.Entities.Common.Obj2Int(dr["ProductID"]),
                            ProductType = 2,
                            Name = dr["Name"].ToString(),
                            NameFT = dr["NameFT"].ToString(),
                            DetailUrl = dr["DetailUrl"].ToString(),
                            ImagePath = dr["ImagePath"].ToString(),
                            CategoryId = QT.Entities.Common.Obj2Int(dr["CategoryID"]),
                            ContentFT = dr["ContentFT"].ToString() + " " + Tools.removeHTML(dr["ProductContent"].ToString()),
                            ViewCount = QT.Entities.Common.Obj2Int(dr["ViewCount"]),
                            AddPosition = QT.Entities.Common.Obj2Int(dr["AddPosition"])
                        };
                        ls.Add(item);
                        count++;
                    }
                    catch (Exception)
                    {
                    }
                    
                    if (count == 1000)
                    {
                        try
                        {
                            SolrDriver.IndexProducts(ls);
                            SolrDriver.Commit();
                            count = 0;
                            ls = new List<SolrProductItem>();

                            this.Invoke((MethodInvoker)delegate
                            {
                                this.laMess1.Text = String.Format("Update solr {0}/{1} Company {2}", i, dtProduct.Rows.Count, drCom.Domain.ToString());
                            });
                        }
                        catch (Exception)
                        {
                        }
                      
                    }
                }
                try
                {
                    SolrDriver.IndexProducts(ls);
                    SolrDriver.Commit();
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.laMess1.Text = String.Format("Update Finish Company {0} ", drCom.Domain.ToString());
                    });
                }
                catch (Exception)
                {
                }
                adtCom.UpdateQuery_LastUpdateSolr(DateTime.Now, drCom.ID);
            }

            //var products = SolrDriver.SearchProducts(SolrDriver.SortCategory.SortByPriceIncrease, 1, 20, 100000, 10000000, "may tinh",
            //    "c100,x430");
            dtProduct.Dispose();
            dtCom.Dispose();
            adtProduct.Dispose();
            adtCom.Dispose();
        }
        void doUpdateSolrProductID()
        {
           
            this.Invoke((MethodInvoker)delegate
            {
                this.laMess1.Text = String.Format("Start download List Product ID");
               
            });
            DBTool2.Product_SolrDataTable dtProduct = new DBTool2.Product_SolrDataTable();
            DBTool2TableAdapters.Product_SolrTableAdapter adtProduct = new DBTool2TableAdapters.Product_SolrTableAdapter();
            adtProduct.Connection.ConnectionString = QT.Entities.Server.ConnectionString;

                try
                {
                    adtProduct.FillBy_ProductSanPhamGoc(dtProduct, DateTime.Now.AddDays(-100));
                }
                catch (Exception)
                {
                }
                int count = 0;
                List<SolrProductItem> ls = new List<SolrProductItem>();
                SolrDriver.DeleteByCompanyId(Bussiness.Function.IDWebSoSanh);
                for (int i = 0; i < dtProduct.Rows.Count; i++)
                {
                    DataRow dr = dtProduct.Rows[i];
                    try
                    {
                        SolrProductItem item = new SolrProductItem
                        {
                            Id = QT.Entities.Common.Obj2Int64(dr["ID"]),
                            Price = QT.Entities.Common.Obj2Int(dr["GiaNhoNhat"]),
                            Warranty = QT.Entities.Common.Obj2Int(dr["Warranty"]),
                            Status = QT.Entities.Common.Obj2Int(dr["Status"]),
                            Company = QT.Entities.Common.Obj2Int64(dr["Company"]),
                            LastUpdate = QT.Entities.Common.ObjectToDataTime(dr["LastUpdate"]),
                            Summary = dr["Summary"].ToString(),
                            Description = "",
                            ProductId = QT.Entities.Common.Obj2Int(dr["ProductID"]),
                            ProductType = 1,
                            Name = dr["Name"].ToString(),
                            NameFT = dr["NameFT"].ToString(),
                            DetailUrl = dr["DetailUrl"].ToString(),
                            ImagePath = dr["ImagePath"].ToString(),
                            CategoryId = QT.Entities.Common.Obj2Int(dr["CategoryID"]),
                            ContentFT = dr["ContentFT"].ToString() + " " + Tools.removeHTML(dr["ProductContent"].ToString()),
                            ViewCount = QT.Entities.Common.Obj2Int(dr["ViewCount"]),
                            AddPosition = QT.Entities.Common.Obj2Int(dr["AddPosition"])
                        };
                        ls.Add(item);
                        count++;
                    }
                    catch (Exception)
                    {
                    }

                    if (count == 1000)
                    {
                        try
                        {
                            SolrDriver.IndexProducts(ls);
                            SolrDriver.Commit();
                            count = 0;
                            ls = new List<SolrProductItem>();

                            this.Invoke((MethodInvoker)delegate
                            {
                                this.laMess1.Text = String.Format("Update solr {0}/{1} San Pham goc", i, dtProduct.Rows.Count);
                            });
                        }
                        catch (Exception)
                        {
                        }

                    }
                }
                try
                {
                    SolrDriver.IndexProducts(ls);
                    SolrDriver.Commit();
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.laMess1.Text = String.Format("Update Finish Company san pham goc ");
                    });
                }
                catch (Exception)
                {
                }

            dtProduct.Dispose();
            adtProduct.Dispose();
        }

        private void btUpdateSolr_Click(object sender, EventArgs e)
        {
            downloadThread = new Thread(doUpdate);
            downloadThread.Start();
        }

        private void btUpdateViewCount_Click(object sender, EventArgs e)
        {
            UpdateLogThread = new Thread(doUpdateLog);
            UpdateLogThread.Start();
        }

        private void frmToolUpdateSolr_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UpdateLogThread != null)
            {
                if (UpdateLogThread.IsAlive)
                {
                    UpdateLogThread.Abort();
                    UpdateLogThread.Join();
                    UpdateLogThread = null;
                }
            }
            if (UpdateLogThread != null)
            {
                if (downloadThread.IsAlive)
                {
                    downloadThread.Abort();
                    downloadThread.Join();
                    downloadThread = null;
                }
            }
        }

        private void btUpdateSolrID_Click(object sender, EventArgs e)
        {
            downloadThread = new Thread(doUpdateSolrProductID);
            downloadThread.Start();
        }

        private void comboBoxSolrNodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SolrDriver.ActiveNodeID = (((SolrNodeItem)comboBoxSolrNodes.SelectedItem).NodeID);
        }

        class SolrNodeItem
        {
            public String NodeID { get; set; }
            public String NodeUrl { get; set; }

            public override string ToString()
            {
                return NodeUrl;
            }
        }
    }
}
