using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QT.Entities;
using UpdateSolrTools.CompanyDataSetTableAdapters;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Common.BO;
using Websosanh.Core.Product.DAL;
using Websosanh.Core.Product.BO;
using Websosanh.Core.SearchEngines.DAL;

namespace UpdateSolrTools
{
    class IndexProductTools
    {
        public SolrProductDriver SolrDriver { get; set; }
        public String ConnectionStringProducts { get; set; }
        private const long IDWebsosanh = 6619858476258121218;

        public int UpdateProductOfCompany(long companyId, string companyName, Tree<int,Region> regionTree = null)
        {
            if (regionTree == null)
                regionTree = RegionBAL.GetRegionTree(ConnectionStringProducts);

            // Get Company Address
            var companyAddressTableAdapter = new Company_AddressTableAdapter
            {
                Connection = {ConnectionString = ConnectionStringProducts}
            };

            var companyAddressDataTable = companyAddressTableAdapter.GetData(companyId);
            //var companyRegions = new List<int>();
            var companyProvins = new List<int>();
            var companyDistricts = new List<int>();
            for (var rowIndex = 0; rowIndex < companyAddressDataTable.Rows.Count; rowIndex ++)
            {
                var branchDistrict = companyAddressDataTable.Rows[rowIndex]["RegionID"] == DBNull.Value ? -1 : (int)companyAddressDataTable.Rows[rowIndex]["RegionID"];
                if (branchDistrict == -1 || companyDistricts.Contains(branchDistrict)) continue;
                companyDistricts.Add(branchDistrict);
                var branchProvinNode = regionTree.GetParentNode(branchDistrict);
                if (branchProvinNode != null && !companyProvins.Contains(branchProvinNode.ID))
                    companyProvins.Add(branchProvinNode.ID);
            }
            //var dtCompanyRegion = 
            var dtProduct = new DBTool2.Product_SolrDataTable();
            var adtProduct = new DBTool2TableAdapters.Product_SolrTableAdapter
            {
                Connection = { ConnectionString = ConnectionStringProducts }
            };
            //this.Invoke((MethodInvoker)(() =>
            //    WriteLog(String.Format("Start download list products of company {0}", companyName))));
            try
            {
                adtProduct.FillBy_Company(dtProduct, companyId);
                SolrDriver.DeleteByCompanyId(companyId);
            }
            catch (Exception ex)
            {
                return -1;
                //this.Invoke((MethodInvoker)(() =>
                //WriteLog(string.Format("Update Products Of Company {0}", companyId), ex)));
            }
            var solrProductItems = new List<SolrProductItem>();
            var numProduct = dtProduct.Rows.Count;
            for (var index = 0; index < numProduct; index++)
            {
                var productRow = dtProduct.Rows[index];
                try
                {
                    var item = new SolrProductItem
                    {
                        Id = QT.Entities.Common.Obj2Int64(productRow["ID"]),
                        Price = QT.Entities.Common.Obj2Int(productRow["Price"]),
                        Warranty = QT.Entities.Common.Obj2Int(productRow["Warranty"]),
                        Status = QT.Entities.Common.Obj2Int(productRow["Status"]),
                        Company = QT.Entities.Common.Obj2Int64(productRow["Company"]),
                        CompanyProvins = companyProvins,
                        CompanyDistricts = companyDistricts,
                        LastUpdate = QT.Entities.Common.ObjectToDataTime(productRow["LastUpdate"]),
                        Summary = productRow["Summary"].ToString(),
                        Description = "",
                        ProductId = QT.Entities.Common.Obj2Int(productRow["ProductID"]),
                        ProductType = 2,
                        Name = productRow["Name"].ToString(),
                        NameFT = productRow["NameFT"].ToString(),
                        DetailUrl = productRow["DetailUrl"].ToString(),
                        ImagePath = productRow["ImagePath"].ToString(),
                        CategoryId = QT.Entities.Common.Obj2Int(productRow["CategoryID"]),
                        ContentFT =
                            productRow["ContentFT"] != DBNull.Value ? productRow["ContentFT"].ToString() : "c000",
                        ViewCount = QT.Entities.Common.Obj2Int(productRow["ViewCount"]),
                        AddPosition = QT.Entities.Common.Obj2Int(productRow["AddPosition"]),
                        StringFilterFields = new Dictionary<string, object>(),
                        DoubleFilterFields = new Dictionary<string, object>(),
                        DateTimeFilterFields = new Dictionary<string, object>(),
                        IntFilterFields = new Dictionary<string, object>()
                    };
                    for (int exIndex = 1; exIndex <= 10; exIndex++)
                    {
                        string filterPropertyId = QT.Entities.Common.Obj2String(productRow["EX" + exIndex]);
                        string filterPropertyValue = QT.Entities.Common.Obj2String(productRow["EXVALUE" + exIndex]);
                        if (string.IsNullOrEmpty(filterPropertyId) || filterPropertyId.Equals("0") ||
                            string.IsNullOrEmpty(filterPropertyValue))
                            continue;
                        try
                        {
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
                        catch (Exception ex)
                        {
                            throw;
                        }
                    }
                    solrProductItems.Add(item);
                }
                catch (Exception oex)
                {
                    return -2;
                    //Invoke((MethodInvoker)(() => WriteLog(string.Format("Update Products Of Company {0}", companyId), oex)));
                }
                if (index % 1000 == 0 || index == numProduct - 1)
                {
                    try
                    {
                        SolrDriver.IndexItems(solrProductItems);
                        solrProductItems.Clear();
                        var numUpdatedProducts = index;
                        //Invoke((MethodInvoker)(() => WriteLog(String.Format("Updated solr {0}/{1} products", numUpdatedProducts, numProduct))));
                    }
                    catch (Exception solrEx)
                    {
                        return - 3;
                        //Invoke((MethodInvoker)(() => WriteLog(string.Format("Update Products Of Company {0}", companyId), solrEx)));
                    }
                }
            }
            try
            {

                SolrDriver.IndexItems(solrProductItems);
                var adtCom = new DBToolTableAdapters.CompanyTableAdapter
                {
                    Connection = { ConnectionString = ConnectionStringProducts }
                };
                adtCom.UpdateQuery_LastUpdateSolr(DateTime.Now, companyId);
                adtCom.Dispose();
                //this.Invoke((MethodInvoker)(() =>
                //    this.richTextBoxInfo.AppendText(String.Format("Update Finish Company {0} - {1} products",
                //        companyName, numProduct))));

            }
            catch (Exception ex)
            {
                return - 4;
            }
            dtProduct.Dispose();
            adtProduct.Dispose();
            return dtProduct.Rows.Count;
        }

        void DoUpdateSolrRootProduct()
        {
            var startTime = DateTime.Now;
            //Invoke((MethodInvoker)(() =>
            //    WriteLog(String.Format("Start download List Product ID"))));
            var dtProduct = new DBTool2.Product_SolrDataTable();
            var adtProduct = new DBTool2TableAdapters.Product_SolrTableAdapter();
            adtProduct.Connection.ConnectionString = Server.ConnectionString;

            var dataTableVotes = new DB.UserCommentDataTable();
            var tableAdapterVote = new DBTableAdapters.UserCommentTableAdapter();
            tableAdapterVote.Connection.ConnectionString = Server.UserConnectionString;
            //Invoke((MethodInvoker)(() =>
            //        WriteLog(string.Format("User Conection String: {0}", Server.UserConnectionString))));
            var startGetDb = DateTime.Now;
            try
            {
                tableAdapterVote.FillAllVote(dataTableVotes);
                adtProduct.FillBy_ProductSanPhamGoc(dtProduct, DateTime.Now.AddDays(-100));
            }
            catch (Exception ex)
            {
                //Invoke((MethodInvoker)(() =>
                //    WriteLog("Get ProductSanPhamGoc Error", ex)));
            }
            var getDbTime = (DateTime.Now - startGetDb).TotalSeconds;

            //calculate avgVote
            //Invoke((MethodInvoker)(() =>
            //        WriteLog(string.Format("Num Votes: {0}", dataTableVotes.Rows.Count))));
            Dictionary<long, double> avgVoteDict;
            Dictionary<long, int> numVoteDict;
            IndexProductTools.CalculateAvgVotes(
                    dataTableVotes.AsEnumerable().Select(x => new KeyValuePair<long, int>(x.IDObject, x.Vote)).ToList(), out avgVoteDict, out numVoteDict);
            double getObjectTime = 0;
            double indexSolrTime = 0;

            var listProducts = new List<SolrProductItem>();
            try
            {
                SolrDriver.DeleteByCompanyId(IDWebsosanh);
            }
            catch (Exception ex)
            {
                //Invoke((MethodInvoker)(() =>
                //    WriteLog("Delete root Product Error", ex)));
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
                        Id = Common.Obj2Int64(productRow["ID"]),
                        Price = Common.Obj2Int(productRow["GiaNhoNhat"]),
                        Warranty = Common.Obj2Int(productRow["Warranty"]),
                        Status = Common.Obj2Int(productRow["Status"]),
                        Company = Common.Obj2Int64(productRow["Company"]),
                        LastUpdate = Common.ObjectToDataTime(productRow["LastUpdate"]),
                        Summary = productRow["Summary"].ToString(),
                        Description = "",
                        ProductId = Common.Obj2Int(productRow["ProductID"]),
                        ProductType = 1,
                        Name = productRow["Name"].ToString(),
                        NameFT = productRow["NameFT"].ToString(),
                        DetailUrl = productRow["DetailUrl"].ToString(),
                        ImagePath = productRow["ImagePath"].ToString(),
                        CategoryId = Common.Obj2Int(productRow["CategoryID"]),
                        ContentFT = productRow["ContentFT"] != DBNull.Value ? productRow["ContentFT"].ToString() : "c000",
                        ViewCount = Common.Obj2Int(productRow["ViewCount"]),
                        ViewCountLastWeek = Common.Obj2Int(productRow["PriceChangeWeek"]),
                        AvgRate = 0,

                        AddPosition = Common.Obj2Int(productRow["AddPosition"]),
                        StringFilterFields = new Dictionary<string, object>(),
                        DoubleFilterFields = new Dictionary<string, object>(),
                        DateTimeFilterFields = new Dictionary<string, object>(),
                        IntFilterFields = new Dictionary<string, object>()
                    };
                    //Thuoc tinh san pham
                    for (var exIndex = 1; exIndex <= 10; exIndex++)
                    {
                        string filterPropertyId = Common.Obj2String(productRow["EX" + exIndex]);
                        string filterPropertyValue = Common.Obj2String(productRow["EXVALUE" + exIndex]);
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
                    Product_KeyComparison productKeyComparison = new Product_KeyComparison();
                    Product_KeyComparisonEntyties objKey = new Product_KeyComparisonEntyties();
                    objKey = productKeyComparison.SelectByProductID(item.Id);

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
                    //Invoke((MethodInvoker)(() =>
                    //    WriteLog("Update Root Products", ex)));
                }

                if (rowIndex % 1000 == 0 || rowIndex == numProduct - 1)
                {
                    var startIndexSolr = DateTime.Now;
                    try
                    {
                        SolrDriver.IndexItems(listProducts);
                        listProducts.Clear();
                        var index = rowIndex;
                        //Invoke((MethodInvoker)(() =>
                        //    WriteLog(String.Format("Update solr {0}/{1} San Pham goc", index,
                        //        numProduct))));
                    }
                    catch (Exception ex)
                    {
                        //Invoke((MethodInvoker)(() =>
                        //   WriteLog("Update Solr Error", ex)));

                    }
                    indexSolrTime += (DateTime.Now - startIndexSolr).TotalSeconds;
                }
            }
            var startIndexRemainSolr = DateTime.Now;

            try
            {
                if (listProducts.Count > 0)
                    SolrDriver.IndexItems(listProducts);
                SolrDriver.Commit();
                //Invoke((MethodInvoker)(() =>
                //    WriteLog(String.Format("Update Finish Company san pham goc"))));
            }
            catch (Exception ex)
            {
                //Invoke((MethodInvoker)(() =>
                //    WriteLog("Update Solr Error", ex)));
            }
            indexSolrTime += (DateTime.Now - startIndexRemainSolr).TotalSeconds;
            var totalTime = (DateTime.Now - startTime).TotalSeconds;
            //Invoke((MethodInvoker)(() =>
            //    WriteLog(
            //        String.Format(
            //            "Update Complete!\nTotalTime: {0}\nGetDbTime: {1}\nGetObjectTime:{2}\nIndexSolrTime:{3}",
            //            totalTime, getDbTime, getObjectTime, indexSolrTime))));
            dtProduct.Dispose();
            adtProduct.Dispose();
        }
        public void Commit()
        {
            SolrDriver.Commit();
        }

        public void Init(Dictionary<string, string> solrNodes)
        {
            SolrDriver<SolrProductItem>.Init(solrNodes);
        }

        public void SetActiveNodeID(string nodeID)
        {
            SolrDriver.ActiveNodeID = nodeID;
        }

        public static void CalculateAvgVotes(List<KeyValuePair<long, int>> votes, out Dictionary<long, double> avgVoteDictionary, out Dictionary<long, int> voteCountDictionary)
        {
            var voteSumDict = new Dictionary<long, int>();
            var voteCountDict = new Dictionary<long, int>();
            foreach (var vote in votes)
            {
                if (voteSumDict.ContainsKey(vote.Key))
                {
                    voteSumDict[vote.Key] += vote.Value;
                    voteCountDict[vote.Key] ++;
                }
                else
                {
                    voteSumDict[vote.Key] = vote.Value;
                    voteCountDict[vote.Key] = 1;
                }
            }
            avgVoteDictionary = voteSumDict.ToDictionary(x => x.Key, x => (Double) x.Value/voteCountDict[x.Key]);
            voteCountDictionary = voteCountDict;

        }
        public void Optimize()
        {
            SolrDriver.Optimize();
        }
    }

}
