using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using QT.Entities;
using UpdateSolrTools.CompanyDataSetTableAdapters;
using UTF_Converter;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Common.BO;
using Websosanh.Core.Product.DAL;
using Websosanh.Core.Product.BO;
using UpdateSolrTools.ProductDatasetTableAdapters;
using Websosanh.Core.Product.BAL;
using System.Data;
using Websosanh.Core.Merchant.BAL;
using WebsosanhCacheTool;
using SolrNet;

namespace UpdateSolrTools
{
    public class SolrIndexer
    {
        public SolrProductClient SolrClient { get; set; }
        public String ConnectionStringProducts { get; set; }
        public const long IDWebsosanh = 6619858476258121218;
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SolrIndexer));
        public Tree<int, Region> RegionTree;
        public Tree<int, ProductCategory> CategoryTree;
        public Dictionary<int, string[]> CategoryTags;
        public Dictionary<int, string> PropertyUnitDictionary;
        public Dictionary<int, string> PropertyValueDictionary;
        public HashSet<long> ListMerchantUseDatafeedID;
        public HashSet<long> ListSpecialMerchantID;
        public HashSet<long> ListBadMerchantID;
        public Dictionary<long, int> ListPriorMerchants;
        public Dictionary<int, string> ListPrefixCategory;

        public int UpdateAllProductOfMerchant(long companyId, string companyName)
        {
            var startTime = DateTime.Now;
            var dtProduct = new ProductDataset.ProductDataTable();
            var numProductInserted = 0;
            var productTableAdapter = new ProductTableAdapter
            {
                Connection = { ConnectionString = ConnectionStringProducts, }                
            };
            IndexProductTools.SetAllCommandTimeouts(productTableAdapter, 300);
            try
            {
                dtProduct = productTableAdapter.GetAllProductOfCompany(companyId);
            }
            catch (Exception ex)
            {
                Logger.Error("Idex Solr Error, code : -1. Company: " + companyId, ex);
                return -1;
            }
            var totalProduct = dtProduct.Rows.Count;
            int merchantPriorityScore = ListPriorMerchants.ContainsKey(companyId) ? ListPriorMerchants[companyId] : 0;
            bool isBadMerchant = ListBadMerchantID.Contains(companyId);
            var merchantShortInfo = MerchantBAL.GetMerchantShortInfoFromCache(companyId);
            if (merchantShortInfo == null)
                return 0;
            try
            {
                int productIndex = -1;
                var productParts = CollectionUtilities.Partition(dtProduct, 100);
                foreach (var productPart in productParts)
                {
                    var rootIDs = productPart.Where(x => x["ProductID"] != DBNull.Value && x.ProductID > 0).Select(x => (long)x.ProductID).Distinct().ToList();
                    var productProperties = WebProductPropertyBAL.GetFilterPropertiesOfProductsFromCache(rootIDs);
                    var productIDs = productPart.Select(x => x.ID).ToList();
                    var productCategories = ProductCategorizationTool.GetCategories(productIDs);
                    var merchantRegions = MerchantRegionBAL.GetMerchantRegionsFromCache(companyId);
                    int rowIndex = -1;
                    var listProducts = new List<SolrProductItem>();
                    foreach (var productRow in productPart)
                    {
                        rowIndex++;
                        productIndex++;
                        var item = new SolrProductItem();
                        item.Id = productRow.ID;
                        if (productRow["Price"] != DBNull.Value)
                            item.Price = productRow.Price;
                        else
                            continue;
                        bool isPriceIncludeVat;
                        if (productRow.IsVATStatusNull() || productRow.VATStatus == 2)
                            isPriceIncludeVat = merchantShortInfo.VATStatus == 1;
                        else
                            isPriceIncludeVat = productRow.VATStatus == 1;

                        item.PriceWithVAT = isPriceIncludeVat ? item.Price : (item.Price * 11) / 10;
                        item.MerchantID = companyId;
                        item.ProductType = 2;
                        item.RootId = productRow["ProductID"] != DBNull.Value ? productRow.ProductID : 0;
                        string productName = AutoCorrector.Correct(productRow.Name);
                        if (string.IsNullOrEmpty(productName))
                            continue;
                        item.Name = productName;
                        item.NameIdentity = productName;
                        if (productRow["NameFT"] != DBNull.Value)
                            item.NameAscii = productRow.NameFT;
                        item.NameLength = IndexProductTools.GetNameLength(productName);
                        if (productRow["InStock"] != DBNull.Value)
                            item.InstockStatus = productRow.InStock;
                        int categoryID = 0;
                        if (productRow["CategoryID"] != DBNull.Value)
                            categoryID = productRow.CategoryID;
                        if (categoryID == 0)
                            categoryID = productCategories[rowIndex];
                        if (categoryID == 0)
                            item.CategoryIds = new List<int>() { 0 };
                        else
                        {
                            var categories = new List<int>() { categoryID };
                            var parrentNode = CategoryTree.GetParentNode(categoryID);
                            while (parrentNode != null && parrentNode.Depth > 0)
                            {
                                categories.Add(parrentNode.ID);
                                parrentNode = CategoryTree.GetParentNode(parrentNode.ID);
                            }
                            item.CategoryIds = categories;
                        }
                        var categoryPrefix = "";
                        foreach (var category in item.CategoryIds)
                        {
                            if (ListPrefixCategory.ContainsKey(category))
                            {
                                categoryPrefix = categoryPrefix + ListPrefixCategory[category] + " ";
                            }
                        }
                        var otherNames = UnitNormalization.GetUnitNormalizedName(productName);
                        otherNames.AddRange(ProductCodeNormalization.GetOtherNames(productName));
                        if (otherNames.Count > 0)
                            item.NameOther = otherNames;
                        if (!string.IsNullOrEmpty(categoryPrefix))
                        {
                            if (item.NameOther == null)
                                item.NameOther = new List<string>();
                            for (int otherNameIndex = 0; otherNameIndex < item.NameOther.Count; otherNameIndex++)
                            {
                                item.NameOther[otherNameIndex] = categoryPrefix + item.NameOther[otherNameIndex];
                            }
                            item.NameOther.Add(categoryPrefix + item.Name);
                        }
                        item.CategoryLevel2Id = item.CategoryIds.Count >= 2 ? item.CategoryIds[item.CategoryIds.Count - 2] : 0;
                        item.Tags = new List<string>();
                        if (productRow["Tag"] != DBNull.Value && productRow["StartDate"] != DBNull.Value &&
                            productRow["EndDate"] != DBNull.Value && productRow.StartDate < DateTime.Now &&
                            productRow.EndDate > DateTime.Now)
                        {
                            var tags = productRow["Tag"].ToString().ToLower().Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                            if (tags.Length > 0)
                                item.Tags.AddRange(tags);
                        }
                        item.Tags = item.Tags.Count == 0 ? null : item.Tags.Select(x => StringUtilities.GetUCRC32(x, true, true).ToString()).Distinct().ToList();
                        if (merchantRegions != null)
                        {
                            if (merchantRegions.AllMerchantProvins != null)
                            {
                                item.MerchantProvins = merchantRegions.AllMerchantProvins;
                                if (item.MerchantProvins.Contains(100000))
                                    item.MerchantProvins = new List<int> { 100000 };
                            }
                            if (merchantRegions.AllMerchantDistrict != null)
                            {
                                item.MerchantDistricts = merchantRegions.AllMerchantDistrict;
                                if (item.MerchantDistricts.Contains(1000000))
                                    item.MerchantDistricts = new List<int> { 1000000 };
                            }
                        }
                        if (productRow["ProductID"] != DBNull.Value)
                        {
                            if (productProperties.ContainsKey(productRow.ProductID))
                                BuildProductProperty(item, productProperties[productRow.ProductID]);
                        }

                        item.Priority = Common.Obj2Int(productRow["AddPosition"]);

                        //Set PriorityScore
                        var priorityScore = GetProductPriorityScore(merchantPriorityScore, productIndex, totalProduct);
                        if (priorityScore > item.Priority || priorityScore < 0)
                            item.Priority = priorityScore;

                        //AdsScore
                        if (productRow["OrderAdsScore"] != DBNull.Value && productRow["StartDate"] != DBNull.Value &&
                            productRow["EndDate"] != DBNull.Value && productRow.StartDate < DateTime.Now &&
                            productRow.EndDate > DateTime.Now)
                            item.AdsScore = productRow.OrderAdsScore;

                        //MerchantScore
                        item.MerchantScore = isBadMerchant ? 0 : 1;

                        var clickCountMultipliers = 1;
                        if (ListMerchantUseDatafeedID.Contains(companyId))
                            clickCountMultipliers = 3;
                        if (ListSpecialMerchantID.Contains(companyId))
                            clickCountMultipliers = 3;
                        item.ViewCount = Common.Obj2Int(productRow["ViewCount"]) * clickCountMultipliers;
                        if (clickCountMultipliers == 3)
                        {
                            if (item.ViewCount < 5)
                                item.ViewCount = 5;
                        }
                        else
                            if (clickCountMultipliers == 4)
                            {
                                if (item.ViewCount < 8)
                                    item.ViewCount = 8;
                            }
                        item.IndexedTime = DateTime.Now;
                        listProducts.Add(item);
                    }
                    if (listProducts.Count > 0)
                    {
                        SolrClient.IndexItems(listProducts);                        
                        numProductInserted += listProducts.Count;
                    }
                }
                DeleteExpiredProduct(companyId,startTime, false);
                Logger.InfoFormat("Updated company {0} - ID: {1}. Indexed {2}/{3} products. Time: {4} s", companyName, companyId, numProductInserted, totalProduct, (DateTime.Now - startTime).TotalSeconds);
                var adtCom = new CompanyTableAdapter
                {
                    Connection = { ConnectionString = ConnectionStringProducts }
                };
                adtCom.UpdateQuery_LastUpdateSolr(DateTime.Now, companyId);
                dtProduct.Dispose();
                productTableAdapter.Dispose();
                return numProductInserted;
            }
            catch (Exception ex)
            {
                Logger.Error("IndexSolr Error. Company: " + companyName + ". ID: " + companyId, ex);
                return -2;
            }
        }

        public int GetProductPriorityScore(int merchantPriorityScore, int productIndex, int totalProduct)
        {
            if (merchantPriorityScore == 1)
            {
                if (productIndex < totalProduct / 3 && productIndex < 20000)
                    return merchantPriorityScore;
                return 0;
            }
            if (merchantPriorityScore == 2)
            {
                if (productIndex < 2 * totalProduct / 3 && productIndex < 50000)
                    return merchantPriorityScore;
                return 0;
            }
            if (merchantPriorityScore >= 3)
            {
                if (productIndex < 80000)
                    return merchantPriorityScore;
                return 0;
            }
            if (merchantPriorityScore < 0)
                return merchantPriorityScore;
            return 0;
        }
        public void UpdateMerchantProducts(List<long> productIDs)
        {
            var productsToIndex = new List<SolrProductItem>();
            var productIDsToDelete = new List<long>();
            var productTableAdapter = new ProductTableAdapter
            {
                Connection = { ConnectionString = ConnectionStringProducts }
            };
            foreach (var productID in productIDs)
            {
                var isProductIndexed = false;
                var dtProduct = productTableAdapter.GetMerchantProduct(productID);
                if (dtProduct.Count == 0)
                {
                    productIDsToDelete.Add(productID);
                    Logger.DebugFormat("Product {0} rejected", productID);
                    continue;
                }
                foreach (var productRow in dtProduct)
                {
                    var item = new SolrProductItem();
                    item.Id = productRow.ID;
                    if (productRow["Price"] != DBNull.Value)
                        item.Price = productRow.Price;
                    else
                    {
                        Logger.DebugFormat("Product {0} rejected", productID);
                        continue;
                    }

                    if (productRow["Company"] != DBNull.Value && productRow.Company > 0)
                        item.MerchantID = productRow.Company;
                    else
                    {
                        Logger.DebugFormat("Product {0} rejected", productID);
                        continue;
                    }
                    var merchantShortInfo = MerchantBAL.GetMerchantShortInfoFromCache(productRow.Company);
                    if (merchantShortInfo == null)
                        continue;
                    bool isPriceIncludeVat;
                    if (productRow.IsVATStatusNull() || productRow.VATStatus == 2)
                        isPriceIncludeVat = merchantShortInfo.VATStatus == 1;
                    else
                        isPriceIncludeVat = productRow.VATStatus == 1;
                    item.PriceWithVAT = isPriceIncludeVat ? item.Price : (item.Price * 11) / 10;
                    item.ProductType = 2;
                    item.RootId = productRow["ProductID"] != DBNull.Value ? productRow.ProductID : 0;
                    string productName = AutoCorrector.Correct(productRow.Name);
                    if (string.IsNullOrEmpty(productName))
                    {
                        Logger.DebugFormat("Product {0} rejected", productID);
                        continue;
                    }
                    item.Name = productName;
                    item.NameIdentity = productName;
                    if (productRow["NameFT"] != DBNull.Value)
                        item.NameAscii = productRow.NameFT;
                    item.NameLength = IndexProductTools.GetNameLength(productName);
                    if (productRow["InStock"] != DBNull.Value)
                        item.InstockStatus = productRow.InStock;
                    int categoryID = 0;
                    if (productRow["CategoryID"] != DBNull.Value)
                        categoryID = productRow.CategoryID;
                    if (categoryID == 0)
                    {
                        var productCategory = ProductCategorizationTool.GetCategories(new[] { productID });
                        categoryID = productCategory[0];
                    }
                    if (categoryID == 0)
                        item.CategoryIds = new List<int>() { 0 };
                    else
                    {
                        var categories = new List<int>() { categoryID };
                        var parrentNode = CategoryTree.GetParentNode(categoryID);
                        while (parrentNode != null && parrentNode.Depth > 0)
                        {
                            categories.Add(parrentNode.ID);
                            parrentNode = CategoryTree.GetParentNode(parrentNode.ID);
                        }
                        item.CategoryIds = categories;
                    }
                    item.CategoryLevel2Id = item.CategoryIds.Count >= 2 ? item.CategoryIds[item.CategoryIds.Count - 2] : 0;
                    var otherNames = UnitNormalization.GetUnitNormalizedName(productName);
                    otherNames.AddRange(ProductCodeNormalization.GetOtherNames(productName));
                    if (otherNames.Count > 0)
                        item.NameOther = otherNames;
                    var categoryPrefix = item.CategoryIds.Where(category => ListPrefixCategory.ContainsKey(category)).Aggregate("", (current, category) => current + ListPrefixCategory[category] + " ");
                    if (!string.IsNullOrEmpty(categoryPrefix))
                    {
                        if (item.NameOther == null)
                            item.NameOther = new List<string>();
                        for (int otherNameIndex = 0; otherNameIndex < item.NameOther.Count; otherNameIndex++)
                        {
                            item.NameOther[otherNameIndex] = categoryPrefix + item.NameOther[otherNameIndex];
                        }
                        item.NameOther.Add(categoryPrefix + item.Name);
                    }
                    item.Tags = new List<string>();
                    if (productRow["Tag"] != DBNull.Value && productRow["StartDate"] != DBNull.Value &&
                            productRow["EndDate"] != DBNull.Value && productRow.StartDate < DateTime.Now &&
                            productRow.EndDate > DateTime.Now)
                    {
                        var tags = productRow["Tag"].ToString().ToLower().Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        if (tags.Length > 0)
                            item.Tags.AddRange(tags);
                    }
                    if (item.Tags.Count == 0)
                        item.Tags = null;
                    else
                        item.Tags = item.Tags.Select(x => StringUtilities.GetUCRC32(x,true,true).ToString()).Distinct().ToList();
                    var merchantRegions = MerchantRegionBAL.GetMerchantRegionsFromCache(item.MerchantID);
                    if (merchantRegions != null)
                    {
                        if (merchantRegions.AllMerchantProvins != null)
                        {
                            item.MerchantProvins = merchantRegions.AllMerchantProvins;
                            if (item.MerchantProvins.Contains(100000))
                                item.MerchantProvins = new List<int> { 100000 };
                        }
                        if (merchantRegions.AllMerchantDistrict != null)
                        {
                            item.MerchantDistricts = merchantRegions.AllMerchantDistrict;
                            if (item.MerchantDistricts.Contains(1000000))
                                item.MerchantDistricts = new List<int> { 1000000 };
                        }
                    }
                    if (productRow["ProductID"] != DBNull.Value && productRow.ProductID > 0)
                    {
                        var productProperties = WebProductPropertyBAL.GetFilterPropertiesOfProductsFromCache(new List<long> { (long)productRow.ProductID });
                        if (productProperties.ContainsKey(productRow.ProductID))
                            BuildProductProperty(item, productProperties[productRow.ProductID]);
                    }

                    item.Priority = Common.Obj2Int(productRow["AddPosition"]);
                    int merchantPriorityScore = ListPriorMerchants.ContainsKey(item.MerchantID) ? ListPriorMerchants[item.MerchantID] : 0;
                    if (merchantPriorityScore < 0 || merchantPriorityScore > item.Priority)
                        item.Priority = merchantPriorityScore;

                    //AdsScore
                    if (productRow["OrderAdsScore"] != DBNull.Value && productRow["StartDate"] != DBNull.Value &&
                        productRow["EndDate"] != DBNull.Value && productRow.StartDate < DateTime.Now &&
                        productRow.EndDate > DateTime.Now)
                        item.AdsScore = productRow.OrderAdsScore;

                    //MerchantScore
                    item.MerchantScore = ListBadMerchantID.Contains(item.MerchantID) ? 0 : 1;

                    var clickCountMultipliers = 1;
                    if (ListMerchantUseDatafeedID.Contains(item.MerchantID))
                        clickCountMultipliers = 3;
                    if (ListSpecialMerchantID.Contains(item.MerchantID))
                        clickCountMultipliers = 4;
                    item.ViewCount = Common.Obj2Int(productRow["ViewCount"]) * clickCountMultipliers;
                    if (clickCountMultipliers == 3)
                    {
                        if (item.ViewCount < 5)
                            item.ViewCount = 5;
                    }
                    else
                        if (clickCountMultipliers == 4)
                        {
                            if (item.ViewCount < 8)
                                item.ViewCount = 8;
                        }
                    item.IndexedTime = DateTime.Now;
                    isProductIndexed = true;
                    productsToIndex.Add(item);
                }
                if (!isProductIndexed)
                    productIDsToDelete.Add(productID);
            }
            if (productsToIndex.Count > 0)
                SolrClient.IndexItems(productsToIndex);
            if (productIDsToDelete.Count > 0)
                DeleteProducts(productIDsToDelete, false);
            Logger.DebugFormat("UpdateMerchantProducts - Index {0} products, Deleted {1} products.", productsToIndex.Count, productIDsToDelete.Count);
        }

        public int UpdateAllRootProducts(out string message, string productConnectionString, string userConnectionString, string searchEnginesServiceUrl)
        {
            int returnValue;
            StringBuilder messageBuilder = new StringBuilder();
            var startTime = DateTime.Now;
            double indexTime = 0;
            Logger.InfoFormat("Start download List Product ID");
            var numProductInserted = 0;
            int totalProduct = 0;
            var productTableAdapter = new ProductTableAdapter() { Connection = { ConnectionString = productConnectionString } };
            try
            {
                var dtProduct = productTableAdapter.GetAllRootProducts();
                totalProduct = dtProduct.Rows.Count;
                var productParts = dtProduct.Partition(1000);
                int partIndex = 0;
                foreach (var productPart in productParts)
                {
                    var listProducts = new List<SolrProductItem>();
                    var productIDs = productPart.Select(x => x.ID).ToList();
                    var productProperties = WebProductPropertyBAL.GetFilterPropertiesOfProductsFromCache(productIDs);
                    var rootProductMappingList = RootProductMappingBAL.GetListRootProductMappingFromCache(productIDs, RootProductMappingSortType.PriceWithVAT,false).Where(x => x != null).ToDictionary(x => x.ID, x => x);
                    var productCategories = ProductCategorizationTool.GetCategories(productIDs);
                    int rowIndex = -1;
                    foreach (var productRow in productPart)
                    {
                        rowIndex++;
                        var item = new SolrProductItem();
                        item.Id = productRow.ID;
                        item.MerchantID = IDWebsosanh;
                        item.ProductType = 1;
                        item.RootId = 0;
                        string productName = AutoCorrector.Correct(productRow.Name);
                        if (string.IsNullOrEmpty(productName))
                        {
                            Logger.WarnFormat("UpdateRootProduct: ProductName empty. ProductID: {0}", item.Id);
                            continue;
                        }
                        item.Name = productName;
                        item.NameIdentity = productName;

                        if (productRow["NameFT"] != DBNull.Value)
                            item.NameAscii = productRow["NameFT"].ToString();
                        item.NameLength = IndexProductTools.GetNameLength(productName);
                        int categoryID = 0;
                        if (productRow["CategoryID"] != DBNull.Value)
                            categoryID = productRow.CategoryID;
                        if (categoryID == 0)
                            categoryID = productCategories[rowIndex];
                        if (categoryID == 0)
                            item.CategoryIds = new List<int>() { 0 };
                        else
                        {
                            var categories = new List<int>() { categoryID };
                            var parrentNode = CategoryTree.GetParentNode(categoryID);
                            while (parrentNode != null && parrentNode.Depth > 0)
                            {
                                categories.Add(parrentNode.ID);
                                parrentNode = CategoryTree.GetParentNode(parrentNode.ID);
                            }
                            item.CategoryIds = categories;
                        }
                        item.CategoryLevel2Id = item.CategoryIds.Count >= 2 ? item.CategoryIds[item.CategoryIds.Count - 2] : 0;
                        var otherNames = UnitNormalization.GetUnitNormalizedName(productName);
                        otherNames.AddRange(ProductCodeNormalization.GetOtherNames(productName));
                        var rootProductMappingWithBlackList = RootProductMappingBAL.GetRootProductMappingFromCache(item.Id, 0, RootProductMappingSortType.PriceWithVAT, false);
                        if (rootProductMappingWithBlackList.ListMerchantProducts != null)
                        {
                            var listMerchantProductId =
                                rootProductMappingWithBlackList.ListMerchantProducts.SelectMany(x => x.Value).ToList();
                            var listMerchantProduct =
                                WebMerchantProductBAL.GetWebMerchantProductsFromCache(listMerchantProductId);
                            otherNames.AddRange(listMerchantProduct.Values.Select(p => p.Name));
                        }
                        if (otherNames.Count > 0)
                            item.NameOther = otherNames;
                        var categoryPrefix = "";
                        foreach (var category in item.CategoryIds)
                        {
                            if (ListPrefixCategory.ContainsKey(category))
                            {
                                categoryPrefix = categoryPrefix + ListPrefixCategory[category] + " ";
                            }
                        }
                        if (!string.IsNullOrEmpty(categoryPrefix))
                        {
                            if (item.NameOther == null)
                                item.NameOther = new List<string>();
                            for (int otherNameIndex = 0; otherNameIndex < item.NameOther.Count; otherNameIndex++)
                            {
                                item.NameOther[otherNameIndex] = categoryPrefix + item.NameOther[otherNameIndex];
                            }
                            item.NameOther.Add(categoryPrefix + item.Name);
                        }
                        item.ViewCount = Common.Obj2Int(productRow["ViewCount"]);
                        item.Priority = Common.Obj2Int(productRow["AddPosition"]);
                        item.Tags = new List<string>();
                        if (productRow["Tag"] != DBNull.Value && productRow["StartDate"] != DBNull.Value &&
                            productRow["EndDate"] != DBNull.Value && productRow.StartDate < DateTime.Now &&
                            productRow.EndDate > DateTime.Now)
                        {
                            var tags = productRow["Tag"].ToString().ToLower().Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                            if (tags.Length > 0)
                                item.Tags.AddRange(tags);
                        }
                        if (item.Tags.Count == 0)
                            item.Tags = null;
                        else
                            item.Tags = item.Tags.Select(tag => tag.Trim(" \r\n\t".ToCharArray()).ToLower()).Distinct().ToList();
                        RootProductMapping rootProductMapping;
                        if (rootProductMappingList.ContainsKey(item.Id))
                        {
                            rootProductMapping = rootProductMappingList[item.Id];
                        }
                        else
                        {
                            RootProductMappingCacheTool.InsertRootProductMappingCache(item.Id, searchEnginesServiceUrl);
                            rootProductMapping = RootProductMappingBAL.GetRootProductMappingFromCache(item.Id, 0, RootProductMappingSortType.PriceWithVAT,false);
                            if (rootProductMapping == null)
                            {
                                Logger.WarnFormat("UpdateRootProduct: Cannot get RootProductMapping. Product ID: {0}", item.Id);
                                messageBuilder.Append(BuildLog("UpdateRootProduct: Cannot get RootProductMapping. Product ID: {0}", item.Id));
                                continue;
                            }
                        }
                        if (rootProductMapping.NumMerchant == 0)
                        {
                            continue;
                        }
                        item.Price = rootProductMapping.MinPrice;
                        item.MerchantProvins = rootProductMapping.ListProvin != null
                            ? rootProductMapping.ListProvin.Select(x => x.Key).Distinct().ToList()
                            : null;
                        if (item.MerchantProvins != null && item.MerchantProvins.Contains(100000))
                            item.MerchantProvins = new List<int> { 100000 };
                        item.MerchantDistricts = rootProductMapping.ListDistrict != null
                            ? rootProductMapping.ListDistrict.Select(x => x.Key).Distinct().ToList()
                            : null;
                        if (item.MerchantDistricts != null && item.MerchantDistricts.Contains(1000000))
                            item.MerchantDistricts = new List<int> { 1000000 };
                        if (productProperties.ContainsKey(item.Id))
                        {
                            var properties = productProperties[item.Id];
                            BuildProductProperty(item, properties);
                        }
                        item.MerchantScore = 1;
                        item.IndexedTime = DateTime.Now;
                        listProducts.Add(item);
                    }
                    if (listProducts.Count > 0)
                    {
                        var startIndex = DateTime.Now;
                        SolrClient.IndexItems(listProducts);
                        indexTime += (DateTime.Now - startIndex).TotalSeconds;
                        numProductInserted += listProducts.Count;
                    }
                    if (partIndex % 10 == 0)
                        Logger.InfoFormat("UpdateAllRootProducts. Inserted part {0}/{1}", partIndex, productParts.Count());
                    partIndex++;
                }
                DeleteExpiredProduct(IDWebsosanh, startTime, false);
                Logger.InfoFormat("Update Finish RootProducts");
                messageBuilder.Append("Update Finish RootProducts");
                returnValue = numProductInserted;
            }
            catch (Exception ex)
            {
                Logger.Error("Update Solr Error", ex);
                messageBuilder.Append(BuildLog("Update Solr Error.", ex));
                returnValue = -1;
            }
            var totalTime = (DateTime.Now - startTime).TotalSeconds;
            Logger.InfoFormat(
                        "Update Complete!TotalTime: {0}. IndexSolrTime:{1}. Num products inserted:{2} / {3}",
                        totalTime, indexTime, numProductInserted, totalProduct);
            messageBuilder.Append(BuildLog(
                        "Update Complete!\nTotalTime: {0}.\nIndexSolrTime:{1}.\nNum products inserted:{2} / {3}",
                        totalTime, indexTime, numProductInserted, totalProduct));
            productTableAdapter.Dispose();
            message = messageBuilder.ToString();
            return returnValue;
        }

        public void UpdateRootProducts(List<long> productIDs, string productConnectionString, string userConnectionString, string searchEnginesServiceUrl)
        {
            var productsToIndex = new List<SolrProductItem>();
            var productIDsToDelete = new List<long>();
            var productTableAdapter = new ProductTableAdapter() { Connection = { ConnectionString = productConnectionString } };
            foreach (var productID in productIDs)
            {
                var isProductIndexed = false;
                var dtProduct = productTableAdapter.GetRootProduct(productID);
                for (int i = 0; i < dtProduct.Count; i++)
                {
                    var productRow = dtProduct[i];
                    var rootProductMapping = RootProductMappingBAL.GetRootProductMappingFromCache(productID, 0, RootProductMappingSortType.PriceWithVAT,false);
                    if (rootProductMapping == null)
                    {
                        RootProductMappingCacheTool.InsertRootProductMappingCache(productID, searchEnginesServiceUrl);
                        rootProductMapping = RootProductMappingBAL.GetRootProductMappingFromCache(productID, 0, RootProductMappingSortType.PriceWithVAT,false);
                        if (rootProductMapping == null)
                        {
                            Logger.ErrorFormat("UpdateRootProduct: Cannot get RootProductMapping. Product ID: {0}", productID);
                            continue;
                        }
                    }
                    var productProperties = WebProductPropertyBAL.GetFilterPropertiesOfProductFromCache(productID);
                    var productCategory = ProductCategorizationTool.GetCategories(new[] { productID });
                    var item = new SolrProductItem();
                    item.Id = productRow.ID;
                    item.MerchantID = IDWebsosanh;
                    item.ProductType = 1;
                    item.RootId = 0;
                    string productName = AutoCorrector.Correct(productRow.Name);
                    if (string.IsNullOrEmpty(productName))
                        continue;
                    item.Name = productName;
                    item.NameIdentity = productName;
                    if (productRow["NameFT"] != DBNull.Value)
                        item.NameAscii = productRow["NameFT"].ToString();
                    item.NameLength = IndexProductTools.GetNameLength(productName);
                    int categoryID = 0;
                    if (productRow["CategoryID"] != DBNull.Value)
                        categoryID = productRow.CategoryID;
                    if (categoryID == 0)
                        categoryID = productCategory[0];
                    if (categoryID == 0)
                        item.CategoryIds = new List<int>() { 0 };
                    else
                    {
                        var categories = new List<int>() { categoryID };
                        var parrentNode = CategoryTree.GetParentNode(categoryID);
                        while (parrentNode != null && parrentNode.Depth > 0)
                        {
                            categories.Add(parrentNode.ID);
                            parrentNode = CategoryTree.GetParentNode(parrentNode.ID);
                        }
                        item.CategoryIds = categories;
                    }
                    item.CategoryLevel2Id = item.CategoryIds.Count >= 2 ? item.CategoryIds[item.CategoryIds.Count - 2] : 0;
                    var otherNames = UnitNormalization.GetUnitNormalizedName(productName);
                    otherNames.AddRange(ProductCodeNormalization.GetOtherNames(productName));
                    var rootProductMappingWithBlackList = RootProductMappingBAL.GetRootProductMappingFromCache(productID, 0, RootProductMappingSortType.PriceWithVAT, false);
                    if (rootProductMappingWithBlackList.ListMerchantProducts != null)
                    {
                        var listMerchantProductId =
                            rootProductMappingWithBlackList.ListMerchantProducts.SelectMany(x => x.Value).ToList();
                        var listMerchantProduct =
                            WebMerchantProductBAL.GetWebMerchantProductsFromCache(listMerchantProductId);
                        otherNames.AddRange(listMerchantProduct.Values.Select(p => p.Name));
                    }
                    if (otherNames.Count > 0)
                        item.NameOther = otherNames;
                    var categoryPrefix = "";
                    foreach (var category in item.CategoryIds)
                    {
                        if (ListPrefixCategory.ContainsKey(category))
                        {
                            categoryPrefix = categoryPrefix + ListPrefixCategory[category] + " ";
                        }
                    }
                    if (!string.IsNullOrEmpty(categoryPrefix))
                    {
                        if (item.NameOther == null)
                            item.NameOther = new List<string>();
                        for (int otherNameIndex = 0; otherNameIndex < item.NameOther.Count; otherNameIndex++)
                        {
                            item.NameOther[otherNameIndex] = categoryPrefix + item.NameOther[otherNameIndex];
                        }
                        item.NameOther.Add(categoryPrefix + item.Name);
                    }
                    item.ViewCount = Common.Obj2Int(productRow["ViewCount"]);
                    item.Priority = Common.Obj2Int(productRow["AddPosition"]);
                    item.Tags = new List<string>();
                    if (productRow["Tag"] != DBNull.Value && productRow["StartDate"] != DBNull.Value &&
                            productRow["EndDate"] != DBNull.Value && productRow.StartDate < DateTime.Now &&
                            productRow.EndDate > DateTime.Now)
                    {
                        var tags = productRow["Tag"].ToString().ToLower().Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        if (tags.Length > 0)
                            item.Tags.AddRange(tags);
                        
                    }
                    if (item.Tags.Count == 0)
                        item.Tags = null;
                    else
                        item.Tags = item.Tags.Select(tag => tag.Trim(" \r\n\t".ToCharArray()).ToLower()).Distinct().ToList();

                    if (productProperties != null)
                    {
                        BuildProductProperty(item, productProperties);
                    }
                    if (rootProductMapping.NumMerchant == 0)
                        continue;
                    item.Price = rootProductMapping.MinPrice;
                    item.MerchantProvins = rootProductMapping.ListProvin != null
                                ? rootProductMapping.ListProvin.Select(x => x.Key).Distinct().ToList()
                                : null;
                    if (item.MerchantProvins != null && item.MerchantProvins.Contains(100000))
                        item.MerchantProvins = new List<int> { 100000 };
                    item.MerchantDistricts = rootProductMapping.ListDistrict != null
                        ? rootProductMapping.ListDistrict.Select(x => x.Key).Distinct().ToList()
                        : null;
                    if (item.MerchantDistricts != null && item.MerchantDistricts.Contains(1000000))
                        item.MerchantProvins = new List<int> { 1000000 };
                    item.MerchantScore = 1;
                    item.IndexedTime = DateTime.Now;
                    isProductIndexed = true;
                    productsToIndex.Add(item);
                }
                if (!isProductIndexed)
                    productIDsToDelete.Add(productID);
            }
            if (productsToIndex.Count > 0)
                SolrClient.IndexItems(productsToIndex);
            if (productIDsToDelete.Count > 0)
                DeleteProducts(productIDsToDelete, false);
            Logger.DebugFormat("UpdateRootProducts - Index {0} products, Deleted {1} products.", productsToIndex.Count, productIDsToDelete.Count);
        }

        public void BuildProductProperty(SolrProductItem item, List<ProductPropertyEntry> properties)
        {
            item.StringFilterFields = new Dictionary<string, object>();
            item.DoubleFilterFields = new Dictionary<string, object>();
            item.DateTimeFilterFields = new Dictionary<string, object>();
            item.IntFilterFields = new Dictionary<string, object>();
            foreach (var propertyEntry in properties)
            {
                var filterIDKey = SolrProductUtilities.GetFilterIdKey(propertyEntry.PropertyID);
                if (!item.IntFilterFields.ContainsKey(filterIDKey))
                    item.IntFilterFields.Add(filterIDKey, propertyEntry.PropertyValueID);
                if (PropertyValueDictionary.ContainsKey(propertyEntry.PropertyValueID))
                {
                    if (PropertyUnitDictionary.ContainsKey(propertyEntry.PropertyID)) //number
                    {
                        double propertyValue;
                        if (Double.TryParse(PropertyValueDictionary[propertyEntry.PropertyValueID], out propertyValue) && !item.DoubleFilterFields.ContainsKey(propertyEntry.PropertyID.ToString()))
                            item.DoubleFilterFields.Add(propertyEntry.PropertyID.ToString(), propertyValue);
                    }
                    else
                        if (!item.StringFilterFields.ContainsKey(propertyEntry.PropertyID.ToString()) && !string.IsNullOrEmpty(PropertyValueDictionary[propertyEntry.PropertyValueID]))
                            item.StringFilterFields.Add(propertyEntry.PropertyID.ToString(), PropertyValueDictionary[propertyEntry.PropertyValueID]);
                }
            }
        }

        public void DeleteProducts(IEnumerable<long> productIDs, bool commit)
        {
            var productChunks = productIDs.Partition(1000);
            foreach (var productChunk in productChunks)
                SolrClient.Delete(productChunk.Select(x => x.ToString()).ToList());
            if (commit)
                SolrClient.Commit();
        }

        public void DeleteExpiredProduct(long merchantId, DateTime time, bool commit)
        {
            SolrClient.DeleteByQuery(new SolrQueryByRange<DateTime>(SolrProductConstants.SOLR_FIELD_INDEXED_TIME, DateTime.Now.AddYears(-20), time) && new SolrQueryByField(SolrProductConstants.SOLR_FIELD_MERCHANT_ID,merchantId.ToString()));
            if (commit)
                SolrClient.Commit();
        }

        public void Commit()
        {
            SolrClient.Commit();
        }

        public void SetActiveNodeID(string nodeID)
        {
        }


        public void Optimize()
        {
            SolrClient.Optimize();
        }

        private string BuildLog(string context, Exception ex)
        {
            return BuildLog(context + "\n" + ex.Message + "\n" + ex.StackTrace);
        }

        private string BuildLog(string format, params object[] messages)
        {
            return BuildLog(string.Format(format, messages));
        }
        private string BuildLog(string log)
        {
            return string.Format("[{0:u}] - {1}\n", DateTime.Now, log);
        }
    }

}
