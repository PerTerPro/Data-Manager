using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GABIZ.Base.Mathematic;
using QT.Entities;
using SolrNet.Exceptions;
using UpdateSolrTools.DBTableAdapters;
//using QT.Moduls.Tool;
using UpdateSolrTools.DBTool2TableAdapters;
using Websosanh.Core.Product.DAL;
using Websosanh.Core.SearchEngines.DAL;
using Tools = GABIZ.Base.Tools;
using Websosanh.Core.Product.BO;

namespace UpdateSolrTools
{
    public partial class FrmToolUpdateSolr : QT.Entities.frmBase
    {

        private string _activeSolrNodeId;
        private SolrProductDriver _solrDriver;
        public FrmToolUpdateSolr()
        {
            InitializeComponent();
        }

        public FrmToolUpdateSolr(int categoryId, string categoryName)
        {
            InitializeComponent();
            connProductString = QT.Entities.Server.ConnectionString;
            if (string.IsNullOrEmpty(connProductString))
            {
                connProductString =
                    ConfigurationManager.ConnectionStrings["UpdateSolrTools.Settings.QTConnectionString"]
                        .ToString();
                if (!string.IsNullOrEmpty(connProductString))
                Server.ConnectionString = connProductString;
            }
            if (string.IsNullOrEmpty(connUserString))
            {
                connUserString =
                    ConfigurationManager.ConnectionStrings["UpdateSolrTools.Settings.UserConnectionString"]
                        .ToString();
                if (!string.IsNullOrEmpty(connUserString))
                    Server.UserConnectionString = connUserString;
            }
            InitSolrUrls();
            this.categoryId = categoryId;
            this.categoryName = categoryName;
            this.Text = "Update Solr - " + categoryName;
        }

        private int categoryId;
        private string categoryName;
        private const long ID_WEBSOSANH = 6619858476258121218;
        private Task updateTask;
        private Thread UpdateLogThread;
        private Task updateRootProductTask;
        private Task UpdateProductPropertiesTask;
        private Task runAllTask;
        private string connProductString;
        private string connUserString;
        //private string solrUrl;

        private void InitSolrUrls()
        {
            var solrUrlsString = ConfigurationManager.AppSettings["solrProducts2"];
            var solrUrls = solrUrlsString.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var solrNodes = new Dictionary<string, string>();
            for (int index = 0; index < solrUrls.Length; index++)
            {
                solrNodes.Add("node" + index,solrUrls[index]);
            }
            SolrDriver<SolrProductItem>.Init(solrNodes);
            foreach (var solrNode in solrNodes)
            {
                comboBoxSolrNodes.Items.Add(new SolrNodeItem() { NodeID = solrNode.Key, NodeUrl = solrNode.Value });
            }
            if (comboBoxSolrNodes.Items.Count > 0)
            {
                comboBoxSolrNodes.SelectedIndex = 0;
            }
            _solrDriver = SolrProductDriver.GetDriver(SolrDriver<SolrProductItem>.GetInstance(_activeSolrNodeId));
        }

        private void btUpdateSolr_Click(object sender, EventArgs e)
        {
            if (categoryId < 0)
            {
                updateTask = new Task(DoUpdateSolrIndex);
                updateTask.Start();
                //DoUpdateSolrIndex();
            }
            else
            {
                updateTask = new Task(() => DoUpdateSolrIndex(categoryId));
                updateTask.Start();
            }
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
            if (updateTask != null)
            {
                if (updateTask.Status == TaskStatus.Running)
                {
                    updateTask.Dispose();
                    updateTask.Wait();
                    updateTask = null;
                }
            }
            if (updateRootProductTask != null)
            {
                if (updateRootProductTask.Status == TaskStatus.Running)
                {
                    updateRootProductTask.Dispose();
                    updateRootProductTask.Wait();
                    updateRootProductTask = null;
                }
            }
            if (UpdateProductPropertiesTask != null)
            {
                if (UpdateProductPropertiesTask.Status == TaskStatus.Running)
                {
                    UpdateProductPropertiesTask.Dispose();
                    UpdateProductPropertiesTask.Wait();
                    UpdateProductPropertiesTask = null;
                }
            }

        }

        private void btUpdateSolrID_Click(object sender, EventArgs e)
        {
            if (categoryId < 0)
            {
                updateRootProductTask = new Task(DoUpdateSolrRootProduct);
                updateRootProductTask.Start();
            }
            else
            {
                updateRootProductTask = new Task(() => DoUpdateSolrRootProductIndex(categoryId));
                updateRootProductTask.Start();
            }
        }


        /// <summary>
        ///  Update toàn bộ sản phẩm gốc các giá trị thuộc tính và value cần filter và sort vào bảng 116975105
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (UpdateProductPropertiesTask == null || UpdateProductPropertiesTask.Status != TaskStatus.Running)
            {
                if (categoryId < 0)
                {
                    UpdateProductPropertiesTask = new Task(DoInsertProductFilterProperties);
                    UpdateProductPropertiesTask.Start();
                }
                else
                {
                    UpdateProductPropertiesTask = new Task(() => DoInsertProductFilterProperties(categoryId));
                    UpdateProductPropertiesTask.Start();
                }
            }
        }



        private void DoInsertProductFilterProperties()
        {
            /// duyệt trong bảng config làm theo config một
            /// với mỗi một config buil riêng một table riêng rồi update
            /// 
            DBTool2.PropertiesConfigDataTable dtPropertiesConfig = new DBTool2.PropertiesConfigDataTable();
            DBTool2TableAdapters.PropertiesConfigTableAdapter adtPropertiesConfig = new DBTool2TableAdapters.PropertiesConfigTableAdapter();
            adtPropertiesConfig.Connection.ConnectionString = connProductString;
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.richTextBoxInfo.AppendText("Getting List Config");
                });
                adtPropertiesConfig.Fill(dtPropertiesConfig);
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.richTextBoxInfo.AppendText(String.Format("Getting List Config error: {0}\n", ex));
                });
                return;
            }
            

            //Truncate Table ProductFilterProperties;
            var conn = new SqlConnection(connProductString);
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.richTextBoxInfo.AppendText("Truncating ProductFilterProperties table");
                });
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM ProductFilterProperties", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.richTextBoxInfo.AppendText(String.Format("Truncate ProductFilterProperties table error: {0}\n", ex));
                });
                return;
            }

            int count = 0;
            foreach (DBTool2.PropertiesConfigRow dr in dtPropertiesConfig)
            {
                /// thao tác với từng config chuyên mục một
                /// Buil riêng đoạn mapping
                /// 
                DBTool2.PropertiesConfig_PropertiesDataTable dtp_p = new DBTool2.PropertiesConfig_PropertiesDataTable();
                DBTool2TableAdapters.PropertiesConfig_PropertiesTableAdapter adtp_p =
                    new DBTool2TableAdapters.PropertiesConfig_PropertiesTableAdapter();
                adtp_p.Connection.ConnectionString = connProductString;

                try
                {

                    adtp_p.FillBy_Top10_Filter(dtp_p, dr.ID);

                    Dictionary<int, String> dictProperitesUnit = new Dictionary<int, string>();
                    DBTool2TableAdapters.Properties_CheckUnitTableAdapter adtCheckUnit =
                        new DBTool2TableAdapters.Properties_CheckUnitTableAdapter();
                    DBTool2.Properties_CheckUnitDataTable dtCheckUnit = new DBTool2.Properties_CheckUnitDataTable();
                    adtCheckUnit.Connection.ConnectionString = connProductString;
                    adtCheckUnit.Fill(dtCheckUnit);
                    for (int i = 0; i < dtCheckUnit.Rows.Count; i++)
                    {
                        int id = QT.Entities.Common.Obj2Int(dtCheckUnit.Rows[i]["ID"].ToString());
                        string unit = dtCheckUnit.Rows[i]["Unit"].ToString();
                        if (!string.IsNullOrEmpty(unit) && !dictProperitesUnit.ContainsKey(id))
                        {
                            dictProperitesUnit.Add(id, unit);
                        }
                    }

                    if (dtp_p.Rows.Count > 0)
                    {
                        ////
                        string ex1 = "";
                        string ex2 = "";
                        string ex3 = "";
                        string ex4 = "";
                        string ex5 = "";
                        string ex6 = "";
                        string ex7 = "";
                        string ex8 = "";
                        string ex9 = "";
                        string ex10 = "";
                        string value1 = "";
                        string value2 = "";
                        string value3 = "";
                        string value4 = "";
                        string value5 = "";
                        string value6 = "";
                        string value7 = "";
                        string value8 = "";
                        string value9 = "";
                        string value10 = "";
                        var listPropertyIds = new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
                        var listPropertyValues = new string[]
                        {value1, value2, value3, value4, value5, value6, value7, value8, value9, value10};
                        for (int i = 0; i < dtp_p.Rows.Count && i < 10; i++)
                        {
                            int id = QT.Entities.Common.Obj2Int(dtp_p.Rows[i]["IDProperties"].ToString());
                            listPropertyIds[i] = id;
                            if (dictProperitesUnit.ContainsKey(id))
                            {
                                listPropertyValues[i] = "number:";
                            }

                        }
                        var listPropertyIdIndexDict = new Dictionary<int, int>();
                        for (var propertyIndex = 0; propertyIndex < listPropertyIds.Length; propertyIndex++)
                        {
                            if (listPropertyIds[propertyIndex] > 0)
                                listPropertyIdIndexDict.Add(listPropertyIds[propertyIndex],propertyIndex);
                        }

                        DBTool2.Product_ConfigDataTable dtPconfig = new DBTool2.Product_ConfigDataTable();
                        DBTool2TableAdapters.Product_ConfigTableAdapter adtPconfig =
                            new DBTool2TableAdapters.Product_ConfigTableAdapter();
                        adtPconfig.Connection.ConnectionString = connProductString;
                        adtPconfig.FillBy_SPGoc_ByConfigID(dtPconfig, dr.ID);
                        foreach (DBTool2.Product_ConfigRow drProductConfigRow in dtPconfig)
                        {
                            DBTool2.Product_PropertiesDataTable dtProperties = new DBTool2.Product_PropertiesDataTable();
                            DBTool2TableAdapters.Product_PropertiesTableAdapter adtProperties =
                                new DBTool2TableAdapters.Product_PropertiesTableAdapter();
                            adtProperties.FillBy_ByProductID(dtProperties, drProductConfigRow.ID);

                            var listValues = listPropertyValues.ToArray();
                            /// so sanh danh sach gia tri cua san pham co nam  tron danh sach hien thij filter

                            for (int propertyIndex = 0;
                                propertyIndex < dtProperties.Count;
                                propertyIndex++)
                            {
                                //if (listPropertyIds.Contains(dtProperties[propertyIndex].PropertiesID))
                                if (!listPropertyIdIndexDict.ContainsKey(dtProperties[propertyIndex].PropertiesID))
                                    continue;
                                var selectedPropertyIndex =
                                    listPropertyIdIndexDict[dtProperties[propertyIndex].PropertiesID];
                                listValues[selectedPropertyIndex] += dtProperties[propertyIndex].PropertiesValueID + ":" +
                                                             dtProperties[propertyIndex].Value;
                            }
                            DBTableAdapters.ProductFilterPropertiesTableAdapter adtTemProduct =
                                new ProductFilterPropertiesTableAdapter();
                            adtTemProduct.Connection.ConnectionString = connProductString;
                            adtTemProduct.InsertQuery(drProductConfigRow.ID, drProductConfigRow.CategoryID,
                                listPropertyIds[0].ToString(), listPropertyIds[1].ToString(),
                                listPropertyIds[2].ToString(), listPropertyIds[3].ToString(),
                                listPropertyIds[4].ToString(),
                                listPropertyIds[5].ToString(), listPropertyIds[6].ToString(),
                                listPropertyIds[7].ToString(), listPropertyIds[8].ToString(),
                                listPropertyIds[9].ToString(),
                                listValues[0], listValues[1], listValues[2], listValues[3], listValues[4], listValues[5],
                                listValues[6], listValues[7], listValues[8], listValues[9], DateTime.UtcNow);
                            count++;
                            this.Invoke((MethodInvoker)delegate
                            {
                                this.richTextBoxInfo.AppendText(String.Format("Inserted Product {0}\n", count));
                            });
                        }


                        /// duyệt từng sản phẩm một map thuộc tính vào config ex1-ex10 vừa làm xong ở trên
                    }
                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.richTextBoxInfo.AppendText(String.Format("Fill ProductFilterProperties table error: {0}\n", ex));
                    });
                    return;
                }
            }
           
        }

        
        void DoUpdateSolrIndex()
        {
            var indexSolrTools = new IndexProductTools()
            {
                SolrDriver = _solrDriver,
                ConnectionStringProducts = connProductString
            };
            this.Invoke((MethodInvoker)(() =>
                WriteLog(String.Format("Start download List company"))));
            var dtCom = new DBTool.CompanyDataTable();
            var adtCom = new DBToolTableAdapters.CompanyTableAdapter();
            adtCom.Connection.ConnectionString = connProductString;
            adtCom.FillBy_WebsiteCoSanPham(dtCom);
            var numCompany = dtCom.Count;
            this.Invoke((MethodInvoker)(() =>
                WriteLog(String.Format("Downloaded {0} company", numCompany))));
            var remainCompanyList =
                indexSolrTools.SolrDriver.GetAllCompany().Where(x => x.Value > 0).Select(x => x.Key).Select(long.Parse).ToList();
            
            int companyIndex = 0;
            foreach (var drCom in dtCom)
            {
                try
                {

                    companyIndex++;
                    DBTool.CompanyRow com = drCom;
                    int index = companyIndex;
                    Invoke((MethodInvoker) (() =>
                        WriteLog(String.Format("Start Update company {0} ({1}/{2})", com.Domain, index, numCompany))));
                    remainCompanyList.Remove(drCom.ID);
                    var numProducts = indexSolrTools.UpdateProductOfCompany(drCom.ID, drCom.Domain);
                    if (numProducts >= 0)
                    {
                        Invoke((MethodInvoker) (() =>
                            WriteLog(String.Format("Updated company {0} - {1} products -- {2}/{3}", drCom.Domain,
                                numProducts, companyIndex, numCompany))));
                    }
                    else
                    {
                        Invoke((MethodInvoker) (() =>
                            WriteLog(String.Format("ERROR!!!! Update Company {0} failed - Error code {1}", drCom.Domain,
                                numProducts))));
                    }
                    if (companyIndex%100 == 0) //Commit per 100 company
                        indexSolrTools.Commit();
                }
                catch (SqlException sqlex)
                {
                    WriteLog("Do update Solr Products", sqlex);
                }
                catch (SolrConnectionException solrConnEx)
                {
                    WriteLog("Do update Solr Products", solrConnEx);
                }
            }
            try
            {
                remainCompanyList.Remove(ID_WEBSOSANH);
                foreach (var companyId in remainCompanyList)
                {
                    indexSolrTools.SolrDriver.DeleteByCompanyId(companyId);
                }
                indexSolrTools.Commit();
                indexSolrTools.Optimize();
                this.Invoke((MethodInvoker)(() => WriteLog("Commit and optimize...")));
            }
            catch (Exception ex)
            {
                WriteLog("Do update Solr Products",ex);
            }
            dtCom.Dispose();
            adtCom.Dispose();
        }

        void DoUpdateSolrRootProduct()
        {
            var startTime = DateTime.Now;
            Invoke((MethodInvoker)(() =>
                WriteLog(String.Format("Start download List Product ID"))));
            var dtProduct = new DBTool2.Product_SolrDataTable();
            var adtProduct = new DBTool2TableAdapters.Product_SolrTableAdapter();
            adtProduct.Connection.ConnectionString = Server.ConnectionString;

            var dataTableVotes = new DB.UserCommentDataTable();
            var tableAdapterVote = new DBTableAdapters.UserCommentTableAdapter();
            tableAdapterVote.Connection.ConnectionString = Server.UserConnectionString;
            Invoke((MethodInvoker)(() =>
                    WriteLog(string.Format("User Conection String: {0}", Server.UserConnectionString))));
            var startGetDb = DateTime.Now;
            try
            {
                tableAdapterVote.FillAllVote(dataTableVotes);
                adtProduct.FillBy_ProductSanPhamGoc(dtProduct, DateTime.Now.AddDays(-100));
            }
            catch (Exception ex)
            {
                Invoke((MethodInvoker)(() =>
                    WriteLog("Get ProductSanPhamGoc Error", ex)));
            }
            var getDbTime = (DateTime.Now - startGetDb).TotalSeconds;

            //calculate avgVote
            Invoke((MethodInvoker)(() =>
                    WriteLog(string.Format("Num Votes: {0}",dataTableVotes.Rows.Count))));
            Dictionary<long, double> avgVoteDict;
            Dictionary<long, int> numVoteDict;
            IndexProductTools.CalculateAvgVotes(
                    dataTableVotes.AsEnumerable().Select(x => new KeyValuePair<long, int>(x.IDObject, x.Vote)).ToList(), out avgVoteDict, out numVoteDict);
            double getObjectTime = 0;
            double indexSolrTime = 0;

            var listProducts = new List<SolrProductItem>();
            try
            {
                _solrDriver.DeleteByCompanyId(ID_WEBSOSANH);
            }
            catch (Exception ex)
            {
                Invoke((MethodInvoker)(() =>
                    WriteLog("Delete root Product Error", ex)));
            }
            var numProduct = dtProduct.Rows.Count;
            for (var rowIndex = 0; rowIndex < numProduct; rowIndex++)
            {
                var startGetObjectTime = DateTime.Now;
                var productRow = dtProduct.Rows[rowIndex];
                try
                {
                    var item = new SolrProductItem
                    {
                        Id = QT.Entities.Common.Obj2Int64(productRow["ID"]),
                        Price = QT.Entities.Common.Obj2Int(productRow["GiaNhoNhat"]),
                        Warranty = QT.Entities.Common.Obj2Int(productRow["Warranty"]),
                        Status = QT.Entities.Common.Obj2Int(productRow["Status"]),
                        Company = QT.Entities.Common.Obj2Int64(productRow["Company"]),
                        LastUpdate = QT.Entities.Common.ObjectToDataTime(productRow["LastUpdate"]),
                        Summary = productRow["Summary"].ToString(),
                        Description = "",
                        ProductId = QT.Entities.Common.Obj2Int(productRow["ProductID"]),
                        ProductType = 1,
                        Name = productRow["Name"].ToString(),
                        NameFT = productRow["NameFT"].ToString(),
                        DetailUrl = productRow["DetailUrl"].ToString(),
                        ImagePath = productRow["ImagePath"].ToString(),
                        CategoryId = QT.Entities.Common.Obj2Int(productRow["CategoryID"]),
                        ContentFT = productRow["ContentFT"] != DBNull.Value ? productRow["ContentFT"].ToString() : "c000",
                        ViewCount = QT.Entities.Common.Obj2Int(productRow["ViewCount"]),
                        ViewCountLastWeek = QT.Entities.Common.Obj2Int(productRow["PriceChangeWeek"]),
                        AvgRate = 0,
                        
                        AddPosition = QT.Entities.Common.Obj2Int(productRow["AddPosition"]),
                        StringFilterFields = new Dictionary<string, object>(),
                        DoubleFilterFields = new Dictionary<string, object>(),
                        DateTimeFilterFields = new Dictionary<string, object>(),
                        IntFilterFields = new Dictionary<string, object>()
                    };
                    for (var exIndex = 1; exIndex <= 10; exIndex++)
                    {
                        string filterPropertyId = QT.Entities.Common.Obj2String(productRow["EX" + exIndex]);
                        string filterPropertyValue = QT.Entities.Common.Obj2String(productRow["EXVALUE" + exIndex]);
                        if (string.IsNullOrEmpty(filterPropertyId) || filterPropertyId.Equals("0") || string.IsNullOrEmpty(filterPropertyValue))
                            continue;
                        if (filterPropertyValue.StartsWith("number:"))
                        {
                            if (filterPropertyValue.Equals("number:"))
                                continue;
                            double filterDoubleValue;
                            string filterIDAndValue = filterPropertyValue.Substring(7);
                            string filterValueID = filterIDAndValue.Substring(0,
                                filterIDAndValue.IndexOf(":"));
                            string filterValue = filterIDAndValue.Length > filterValueID.Length + 1
                                ? filterIDAndValue.Substring(filterValueID.Length + 1)
                                : "";
                            var filterPropertyIdKey =
                                SolrProductUtils.GetFilterIdKey(Int32.Parse(filterPropertyId));
                            if (item.IntFilterFields.ContainsKey(filterPropertyIdKey))
                                continue;
                            int filterValueInt;
                            if (!int.TryParse(filterValueID, out filterValueInt))
                                continue;
                            item.IntFilterFields.Add(filterPropertyIdKey, filterValueID);
                            if (Double.TryParse(filterValue, out filterDoubleValue))
                                item.DoubleFilterFields.Add(filterPropertyId, filterDoubleValue);
                        }
                        else
                        {
                            string filterValueID = filterPropertyValue.Substring(0,
                                filterPropertyValue.IndexOf(":"));
                            string filterValue = filterPropertyValue.Length > filterValueID.Length + 1
                                ? filterPropertyValue.Substring(filterValueID.Length + 1)
                                : "";
                            var filterPropertyIdKey =
                                SolrProductUtils.GetFilterIdKey(Int32.Parse(filterPropertyId));
                            if (item.IntFilterFields.ContainsKey(filterPropertyIdKey))
                                continue;
                            int filterValueInt;
                            if (!int.TryParse(filterValueID, out filterValueInt))
                                continue;
                            item.IntFilterFields.Add(filterPropertyIdKey, filterValueID);
                            item.StringFilterFields.Add(filterPropertyId, filterValue);
                        }
                    }
                    //Get NumProduct And Price Min
                    //
                    //// Không được gọi phần phân tích ở đây
                    /// để phân tích hết sản phẩm nó chạy cả ngày không xong
                    Product_KeyComparison productKeyComparison = new Product_KeyComparison();
                    Product_KeyComparisonEntyties objKey = new Product_KeyComparisonEntyties();
                    objKey = productKeyComparison.SelectByProductID(item.Id);
                    int numProducts, minPrice;
                    item.NumProducts = objKey.TongSanPham;
                    item.PriceMin = objKey.GiaNhoNhat;

                    if (avgVoteDict.ContainsKey(item.Id))
                    {
                        item.AvgRate = avgVoteDict[item.Id];
                        item.NumVote = numVoteDict[item.Id];
                    }
                    //productKeyComparison.GetRootProductMinPriceAndNumProducts(item.Id, out minPrice, out numProducts);
                    //if (numProducts > 0)
                    //{
                    //    item.NumProducts = numProducts;
                    //    item.PriceMin = minPrice;
                    //}
                    listProducts.Add(item);
                    getObjectTime += (DateTime.Now - startGetObjectTime).TotalSeconds;
                }
                catch (Exception ex)
                {
                    Invoke((MethodInvoker)(() =>
                        WriteLog("Update Root Products", ex)));
                }

                if (rowIndex % 1000 == 0 || rowIndex == numProduct - 1)
                {
                    var startIndexSolr = DateTime.Now;
                    try
                    {
                        _solrDriver.IndexItems(listProducts);
                        listProducts.Clear();
                        var index = rowIndex;
                        Invoke((MethodInvoker)(() =>
                            WriteLog(String.Format("Update solr {0}/{1} San Pham goc", index,
                                numProduct))));
                    }
                    catch (Exception ex)
                    {
                        Invoke((MethodInvoker)(() =>
                           WriteLog("Update Solr Error", ex)));

                    }
                    indexSolrTime += (DateTime.Now - startIndexSolr).TotalSeconds;
                }
            }
            var startIndexRemainSolr = DateTime.Now;
            
            try
            {
                if (listProducts.Count > 0)
                    _solrDriver.IndexItems(listProducts);
                _solrDriver.Commit();
                Invoke((MethodInvoker)(() =>
                    WriteLog(String.Format("Update Finish Company san pham goc"))));
            }
            catch (Exception ex)
            {
                Invoke((MethodInvoker)(() =>
                    WriteLog("Update Solr Error", ex)));
            }
            indexSolrTime += (DateTime.Now - startIndexRemainSolr).TotalSeconds;
            var totalTime = (DateTime.Now - startTime).TotalSeconds;
            Invoke((MethodInvoker)(() =>
                WriteLog(
                    String.Format(
                        "Update Complete!\nTotalTime: {0}\nGetDbTime: {1}\nGetObjectTime:{2}\nIndexSolrTime:{3}",
                        totalTime, getDbTime, getObjectTime, indexSolrTime))));
            dtProduct.Dispose();
            adtProduct.Dispose();
        }

        #region Update per Category

        private void DoInsertProductFilterProperties(int categoryId)
        {
            //Get Product Id
            DBTool2.Product_SolrDataTable dtProductId = new DBTool2.Product_SolrDataTable();
            DBTool2TableAdapters.Product_SolrTableAdapter adtProduct = new DBTool2TableAdapters.Product_SolrTableAdapter();
            DBTableAdapters.ProductFilterPropertiesTableAdapter adtTemProduct = new ProductFilterPropertiesTableAdapter();
            adtProduct.Connection.ConnectionString = connProductString;
            adtTemProduct.Connection.ConnectionString = connProductString;
            try
            {
                adtProduct.FillBy_ProductSanPhamGocIdByCategory(dtProductId, DateTime.Now.AddDays(-100), categoryId);
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.richTextBoxInfo.AppendText(String.Format("Get Sanphamgoc Id Error: {0}\n", ex));
                });
                return;
            }

            //Truncate Table ProductFilterProperties;
            var conn = new SqlConnection(connProductString);
            try
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM ProductFilterProperties WHERE [GroupId] = @GroupId", conn);
                cmd.Parameters.AddWithValue("GroupId", categoryId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.richTextBoxInfo.AppendText(String.Format("Truncate ProductFilterProperties table error: {0}\n", ex));
                });
                return;
            }

            int count = 0;
            for (int i = 0; i < dtProductId.Rows.Count; i++)
            {

                var tmpProductId = QT.Entities.Common.Obj2Int64(dtProductId.Rows[i]["ID"]);

                DB.ViewValueDataTable dtProductProperties = new DB.ViewValueDataTable();
                var adtProductProperties = new DBTableAdapters.ViewValueTableAdapter();
                adtProductProperties.Connection.ConnectionString = connProductString;
                try
                {
                    adtProductProperties.FillBy_ThamSo(dtProductProperties, tmpProductId);
                    var propertiesString = "";
                    ProductProperties obj = new ProductProperties();
                    for (int propertyIndex = 0; propertyIndex < dtProductProperties.Rows.Count; propertyIndex++)
                    {
                        var propertyId = QT.Entities.Common.Obj2String(dtProductProperties.Rows[propertyIndex]["PropertyID"]);
                        var propertiesValueID =
                            QT.Entities.Common.Obj2String(dtProductProperties.Rows[propertyIndex]["PropertiesValueID"]);
                        var propertyValue = QT.Entities.Common.Obj2String(dtProductProperties.Rows[propertyIndex]["NameValue"]);
                        // => propertyValueID:PropertyValue
                        propertyValue = propertiesValueID + ":" + propertyValue;
                        var unit = QT.Entities.Common.Obj2String(dtProductProperties.Rows[propertyIndex]["Unit"]);
                        propertyValue = string.IsNullOrEmpty(unit) ? propertyValue : "number:" + propertyValue;
                        switch (propertyIndex + 1)
                        {
                            case 1:
                                obj.exname1 = propertyId;
                                obj.exValue1 = propertyValue;
                                break;
                            case 2:
                                obj.exname2 = propertyId;
                                obj.exValue2 = propertyValue;
                                break;
                            case 3:
                                obj.exname3 = propertyId;
                                obj.exValue3 = propertyValue;
                                break;
                            case 4:
                                obj.exname4 = propertyId;
                                obj.exValue4 = propertyValue;
                                break;
                            case 5:
                                obj.exname5 = propertyId;
                                obj.exValue5 = propertyValue;
                                break;
                            case 6:
                                obj.exname6 = propertyId;
                                obj.exValue6 = propertyValue;
                                break;
                            case 7:
                                obj.exname7 = propertyId;
                                obj.exValue7 = propertyValue;
                                break;
                            case 8:
                                obj.exname8 = propertyId;
                                obj.exValue8 = propertyValue;
                                break;
                            case 9:
                                obj.exname9 = propertyId;
                                obj.exValue9 = propertyValue;
                                break;
                            case 10:
                                obj.exname10 = propertyId;
                                obj.exValue10 = propertyValue;
                                break;
                        }

                    }
                    adtTemProduct.InsertQuery(tmpProductId, categoryId, obj.exname1, obj.exname2, obj.exname3, obj.exname4,
                        obj.exname5, obj.exname6, obj.exname7, obj.exname8, obj.exname9, obj.exname10,
                        obj.exValue1, obj.exValue2, obj.exValue3, obj.exValue4, obj.exValue5, obj.exValue6, obj.exValue7, obj.exValue8, obj.exValue9, obj.exValue10,
                        DateTime.UtcNow);

                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.richTextBoxInfo.AppendText(String.Format("Fill ProductFilterProperties table error: {0}\n", ex));
                    });
                    return;
                }
                count++;
                this.Invoke((MethodInvoker)delegate
                {
                    this.richTextBoxInfo.AppendText(String.Format("Insert Properties {0}/{1}\n", count, dtProductId.Rows.Count));
                });
            }
        }

        void DoUpdateSolrIndex(int categoryID)
        {
            var startTime = DateTime.Now;
            double totalGetDbTime = 0;
            double totalGetObjectTime = 0;
            double totalIndexTime = 0;
            this.Invoke((MethodInvoker)delegate
            {
                this.richTextBoxInfo.AppendText(String.Format("Start download List company\n"));
            });
            DBTool.CompanyDataTable dtCom = new DBTool.CompanyDataTable();
            DBToolTableAdapters.CompanyTableAdapter adtCom = new DBToolTableAdapters.CompanyTableAdapter();
            adtCom.Connection.ConnectionString = connProductString;
            DBTool2.Product_SolrDataTable dtProduct = new DBTool2.Product_SolrDataTable();
            DBTool2TableAdapters.Product_SolrTableAdapter adtProduct = new DBTool2TableAdapters.Product_SolrTableAdapter();
            adtProduct.Connection.ConnectionString = connProductString;

            adtCom.FillBy_WebsiteCoSanPham(dtCom);
            int companyIndex = 0;
            int numProductUpdated = 0;
            int numProductTotal = 0;
            foreach (DBTool.CompanyRow drCom in dtCom)
            {
                companyIndex++;
                if (dtProduct != null)
                    dtProduct.Rows.Clear();
                var startGetDbTime = DateTime.Now;
                try
                {
                    adtProduct.FillBy_CompanyAndCategory(dtProduct, drCom.ID, categoryID);
                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.richTextBoxInfo.AppendText(String.Format("Get Productlist of CompanyError. Company {1 - 2} Error: {0}\n", ex, drCom.ID, drCom.Name));
                    });
                    continue;
                }
                totalGetDbTime += (DateTime.Now - startGetDbTime).TotalSeconds;
                numProductTotal += dtProduct.Rows.Count;
                _solrDriver.DeleteByCompanyId(drCom.ID, categoryID);
                int count = 0;
                List<SolrProductItem> ls = new List<SolrProductItem>();

                for (int i = 0; i < dtProduct.Rows.Count; i++)
                {
                    DataRow dr = dtProduct.Rows[i];
                    var startGetObjectTime = DateTime.Now;
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
                            AddPosition = QT.Entities.Common.Obj2Int(dr["AddPosition"]),
                            StringFilterFields = new Dictionary<string, object>(),
                            DoubleFilterFields = new Dictionary<string, object>(),
                            DateTimeFilterFields = new Dictionary<string, object>(),
                            IntFilterFields = new Dictionary<string, object>()
                        };
                        for (int exIndex = 1; exIndex <= 10; exIndex++)
                        {
                            string filterPropertyId = QT.Entities.Common.Obj2String(dr["EX" + exIndex]);
                            string filterPropertyValue = QT.Entities.Common.Obj2String(dr["EXVALUE" + exIndex]);
                            if (!string.IsNullOrEmpty(filterPropertyId) && !string.IsNullOrEmpty(filterPropertyValue))
                            {
                                try
                                {
                                    if (filterPropertyValue.StartsWith("number:"))
                                    {
                                        double filterDoubleValue;
                                        string filterIDAndValue = filterPropertyValue.Substring(7);
                                        string filterValueID = filterIDAndValue.Substring(0,
                                            filterIDAndValue.IndexOf(":"));
                                        string filterValue = filterIDAndValue.Length > filterValueID.Length + 1
                                            ? filterIDAndValue.Substring(filterValueID.Length + 1)
                                            : "";
                                        var filterPropertyIdKey =
                                        SolrProductUtils.GetFilterIdKey(Int32.Parse(filterPropertyId));
                                        if (item.IntFilterFields.ContainsKey(filterPropertyIdKey))
                                            continue;
                                        item.IntFilterFields.Add(filterPropertyIdKey, filterValueID);
                                        if (Double.TryParse(filterValue, out filterDoubleValue))
                                            item.DoubleFilterFields.Add(filterPropertyId, filterDoubleValue);
                                    }
                                    else
                                    {
                                        string filterValueID = filterPropertyValue.Substring(0,
                                            filterPropertyValue.IndexOf(":"));
                                        string filterValue = filterPropertyValue.Length > filterValueID.Length + 1
                                            ? filterPropertyValue.Substring(filterValueID.Length + 1)
                                            : "";
                                        var filterPropertyIdKey =
                                        SolrProductUtils.GetFilterIdKey(Int32.Parse(filterPropertyId));
                                        if (item.IntFilterFields.ContainsKey(filterPropertyIdKey))
                                            continue;
                                        item.IntFilterFields.Add(filterPropertyIdKey, filterValueID);
                                        item.StringFilterFields.Add(filterPropertyId, filterValue);
                                    }
                                }
                                catch (Exception ex)
                                {

                                    throw ex;
                                }

                            }
                        }
                        ls.Add(item);
                        count++;
                    }
                    catch (Exception oex)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            this.richTextBoxInfo.AppendText(String.Format("Update Solr Error: {0}\n", oex));
                        });
                    }
                    totalGetObjectTime += (DateTime.Now - startGetObjectTime).TotalSeconds;
                    if (count == 1000)
                    {
                        var startIndexSolrTime = DateTime.Now;
                        try
                        {
                            _solrDriver.IndexItems(ls);
                            //SolrDriver.Commit();
                            numProductUpdated += ls.Count;
                            count = 0;
                            ls = new List<SolrProductItem>();

                            this.Invoke((MethodInvoker)delegate
                            {
                                this.richTextBoxInfo.AppendText(String.Format("Update solr {0}/{1} products - Company {2}\n", i, dtProduct.Rows.Count, drCom.Domain.ToString()));
                            });
                        }
                        catch (Exception)
                        {
                        }
                        totalIndexTime += (DateTime.Now - startIndexSolrTime).TotalSeconds;

                    }
                }

                var startIndexRemainSolrTime = DateTime.Now;
                try
                {
                    _solrDriver.IndexItems(ls);
                    numProductUpdated += ls.Count;
                    //SolrDriver.SoftCommit();
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.richTextBoxInfo.AppendText(String.Format("Update Finish Company {0} \n", drCom.Domain.ToString()));
                    });
                }
                catch (Exception)
                {
                }
                totalIndexTime += (DateTime.Now - startIndexRemainSolrTime).TotalSeconds;
                adtCom.UpdateQuery_LastUpdateSolr(DateTime.Now, drCom.ID);
                this.Invoke((MethodInvoker)delegate
                {
                    this.richTextBoxInfo.AppendText(String.Format("Updated {1}/{2} Company {0} - {3} products \n", drCom.Domain.ToString(), companyIndex, dtCom.Count, dtProduct.Count));
                });

            }
            this.Invoke((MethodInvoker)delegate
            {
                this.richTextBoxInfo.AppendText(String.Format("Updated {0}/{1} Product \n", numProductUpdated, numProductTotal));
            });
            var totalTime = (DateTime.Now - startTime).TotalSeconds;
            this.Invoke((MethodInvoker)delegate
            {
                this.richTextBoxInfo.AppendText(String.Format("Update Complete!\nTotalTime: {0}\nGetDbTime: {1}\nGetObjectTime:{2}\nIndexSolrTime:{3}\n", totalTime, totalGetDbTime, totalGetObjectTime, totalIndexTime));
            });
            dtProduct.Dispose();
            dtCom.Dispose();
            adtProduct.Dispose();
            adtCom.Dispose();
        }

        void DoUpdateSolrRootProductIndex(int categoryId)
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.richTextBoxInfo.AppendText(String.Format("Start download List Product ID \n"));
            });
            DBTool2.Product_SolrDataTable dtProduct = new DBTool2.Product_SolrDataTable();
            DBTool2TableAdapters.Product_SolrTableAdapter adtProduct = new DBTool2TableAdapters.Product_SolrTableAdapter();
            adtProduct.Connection.ConnectionString = connProductString;

            try
            {
                adtProduct.FillBy_ProductSanPhamGocByCategory(dtProduct, DateTime.Now.AddDays(-100),categoryId);
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.richTextBoxInfo.AppendText(String.Format("Get ProductSanPhamGoc Error: {0}\n", ex));
                });
            }

            _solrDriver.DeleteByCompanyId(ID_WEBSOSANH, categoryId);
            int count = 0;
            List<SolrProductItem> ls = new List<SolrProductItem>();
            //SolrDriver.DeleteByCompanyId(ID_WEBSOSANH);
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
                        AddPosition = QT.Entities.Common.Obj2Int(dr["AddPosition"]),
                        StringFilterFields = new Dictionary<string, object>(),
                        DoubleFilterFields = new Dictionary<string, object>(),
                        DateTimeFilterFields = new Dictionary<string, object>(),
                        IntFilterFields = new Dictionary<string, object>()
                    };
                    for (int exIndex = 1; exIndex <= 10; exIndex++)
                    {
                        string filterPropertyId = QT.Entities.Common.Obj2String(dr["EX" + exIndex]);
                        string filterPropertyValue = QT.Entities.Common.Obj2String(dr["EXVALUE" + exIndex]);
                        if (!string.IsNullOrEmpty(filterPropertyId) && !string.IsNullOrEmpty(filterPropertyValue))
                        {
                            try
                            {
                                if (filterPropertyValue.StartsWith("number:"))
                                {
                                    double filterDoubleValue;
                                    string filterIDAndValue = filterPropertyValue.Substring(7);
                                    string filterValueID = filterIDAndValue.Substring(0,
                                        filterIDAndValue.IndexOf(":"));
                                    string filterValue = filterIDAndValue.Length > filterValueID.Length + 1
                                        ? filterIDAndValue.Substring(filterValueID.Length + 1)
                                        : "";
                                    var filterPropertyIdKey =
                                        SolrProductUtils.GetFilterIdKey(Int32.Parse(filterPropertyId));
                                    if (item.IntFilterFields.ContainsKey(filterPropertyIdKey))
                                        continue;
                                    item.IntFilterFields.Add(filterPropertyIdKey, filterValueID);
                                    if (Double.TryParse(filterValue, out filterDoubleValue))
                                        item.DoubleFilterFields.Add(filterPropertyId, filterDoubleValue);
                                }
                                else
                                {
                                    string filterValueID = filterPropertyValue.Substring(0,
                                        filterPropertyValue.IndexOf(":"));
                                    string filterValue = filterPropertyValue.Length > filterValueID.Length + 1
                                        ? filterPropertyValue.Substring(filterValueID.Length + 1)
                                        : "";
                                    var filterPropertyIdKey =
                                        SolrProductUtils.GetFilterIdKey(Int32.Parse(filterPropertyId));
                                    if (item.IntFilterFields.ContainsKey(filterPropertyIdKey))
                                        continue;
                                    item.IntFilterFields.Add(filterPropertyIdKey, filterValueID);
                                    item.StringFilterFields.Add(filterPropertyId, filterValue);
                                }
                            }
                            catch (Exception ex)
                            {

                                throw ex;
                            }

                        }
                    }
                    ls.Add(item);
                    count++;
                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.richTextBoxInfo.AppendText(String.Format("Update Solr Error: {0}\n", ex));
                    });
                }

                if (count == 1000)
                {
                    try
                    {
                        _solrDriver.IndexItems(ls);
                        //SolrDriver.SoftCommit();
                        count = 0;
                        ls = new List<SolrProductItem>();

                        this.Invoke((MethodInvoker)delegate
                        {
                            this.richTextBoxInfo.AppendText(String.Format("Update solr {0}/{1} San Pham goc\n", i, dtProduct.Rows.Count));
                        });
                    }
                    catch (Exception ex)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            this.richTextBoxInfo.AppendText(String.Format("Update Solr Error: {0}\n", ex));
                        });

                    }

                }
            }
            try
            {
                _solrDriver.IndexItems(ls);
                _solrDriver.Commit();
                this.Invoke((MethodInvoker)delegate
                {
                    this.richTextBoxInfo.AppendText(String.Format("Update Finish Company san pham goc \n"));
                });
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.richTextBoxInfo.AppendText(String.Format("Update Solr Error: {0}\n", ex));
                });
            }

            dtProduct.Dispose();
            adtProduct.Dispose();
        }

        #endregion
        private void runAllPart(int delayTime)
        {
            while (true)
            {
                DoInsertProductFilterProperties();
                DoUpdateSolrRootProduct();
                DoUpdateSolrIndex();
                System.Threading.Thread.Sleep(delayTime);
                this.Invoke((MethodInvoker)delegate
                {
                    this.richTextBoxInfo.Clear();
                });
            }
            
        }

        private void runAllSolrPart(int delayTime)
        {
            while (true)
            {
                DoUpdateSolrRootProduct();
                DoUpdateSolrIndex();
                System.Threading.Thread.Sleep(delayTime);
                this.Invoke((MethodInvoker)delegate
                {
                    this.richTextBoxInfo.Clear();
                });
            }

        }
        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            this.richTextBoxInfo.Clear();
        }

        private void buttonRunAllAsService_Click(object sender, EventArgs e)
        {
            var delayTime = 120;
            if (!string.IsNullOrEmpty(txtRunAsServiceBreakTime.Text))
                int.TryParse(txtRunAsServiceBreakTime.Text, out delayTime);
            //to ms
            delayTime = delayTime*60000;
            if (runAllTask == null || runAllTask.Status != TaskStatus.Running)
            {
                buttonRunAllAsService.Enabled = false;
                buttonRunIndexAsService.Enabled = false;
                btnUpdateProductProperties.Enabled = false;
                buttonUpdateRootProduct.Enabled = false;
                btUpdateViewCount.Enabled = false;
                buttonUpdateProducts.Enabled = false;
                runAllTask = new Task(() => runAllPart(delayTime));
                runAllTask.Start();
            }


        }

        private void buttonRunIndexAsService_Click(object sender, EventArgs e)
        {
            var delayTime = 120;
            if (!string.IsNullOrEmpty(txtRunAsServiceBreakTime.Text))
                int.TryParse(txtRunAsServiceBreakTime.Text, out delayTime);
            //to ms
            delayTime = delayTime * 60000;
            if (runAllTask == null || runAllTask.Status != TaskStatus.Running)
            {
                buttonRunAllAsService.Enabled = false;
                buttonRunIndexAsService.Enabled = false;
                btnUpdateProductProperties.Enabled = false;
                buttonUpdateRootProduct.Enabled = false;
                btUpdateViewCount.Enabled = false;
                buttonUpdateProducts.Enabled = false;
                runAllTask = new Task(() => runAllSolrPart(delayTime));
                runAllTask.Start();
            }
        }

        private void buttonCommitSolr_Click(object sender, EventArgs e)
        {
            var commitTask = new Task(RunCommitSolr);
            commitTask.Start();
        }

        private void RunCommitSolr()
        {
            _solrDriver.Commit();
            this.Invoke((MethodInvoker)delegate
            {
                this.richTextBoxInfo.AppendText("Committed");
            });
        }

        private void FrmToolUpdateSolr_Load(object sender, EventArgs e)
        {
            connProductString = QT.Entities.Server.ConnectionString;
            if (string.IsNullOrEmpty(connProductString))
            {
                connProductString =
                    ConfigurationManager.ConnectionStrings["UpdateSolrTools.Settings.QTConnectionString"]
                        .ToString();
                Server.ConnectionString = connProductString;
            }
            if (string.IsNullOrEmpty(connUserString))
            {
                connUserString =
                    ConfigurationManager.ConnectionStrings["UpdateSolrTools.Settings.UserConnectionString"]
                        .ToString();
                if (!string.IsNullOrEmpty(connUserString))
                    Server.UserConnectionString = connUserString;
            }
            InitSolrUrls();
            categoryId = -1;
            this.Text = "Update Solr";
            this.Text = this.Text + connProductString.Substring(0, 20);
        }

       
        private void WriteLog(string context,Exception ex)
        {
            WriteLog(context +"\n" + ex.Message + "\n" + ex.StackTrace);
        }

        private void WriteLog(string log)
        {
            this.richTextBoxInfo.AppendText(string.Format("[{0:u}] - {1}\n",DateTime.Now,log));
        }

        private void comboBoxSolrNodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _activeSolrNodeId = (((SolrNodeItem)comboBoxSolrNodes.SelectedItem).NodeID);
            _solrDriver = SolrProductDriver.GetDriver(SolrDriver<SolrProductItem>.GetInstance(_activeSolrNodeId));
        }

    }

    class ProductProperties
    {
        public string exValue1 { set; get; }
        public string exValue2 { set; get; }
        public string exValue3 { set; get; }
        public string exValue4 { set; get; }
        public string exValue5 { set; get; }
        public string exValue6 { set; get; }
        public string exValue7 { set; get; }
        public string exValue8 { set; get; }
        public string exValue9 { set; get; }
        public string exValue10 { set; get; }

        public string exname1 { set; get; }
        public string exname2 { set; get; }
        public string exname3 { set; get; }
        public string exname4 { set; get; }
        public string exname5 { set; get; }
        public string exname6 { set; get; }
        public string exname7 { set; get; }
        public string exname8 { set; get; }
        public string exname9 { set; get; }
        public string exname10 { set; get; }
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

    internal enum PropertiesDataType
    {
        String = 0,
        Double = 1
    };
}
