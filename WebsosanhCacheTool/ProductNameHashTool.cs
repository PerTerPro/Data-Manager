using GABIZ.Base;
using log4net;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTF_Converter;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Drivers.Redis;
using Websosanh.Core.Product.BAL;
using WebsosanhCacheTool.CompanyDataSetTableAdapters;
using WebsosanhCacheTool.ProductDataSetTableAdapters;

namespace WebsosanhCacheTool
{
    public class ProductNameHashTool
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(ProductNameHashTool));
        public static void BuildNameHash(string connProductString)
        {
            try
            {                
                var productTableAdapter = new ProductTableAdapter
                {
                    Connection = { ConnectionString = connProductString }
                };
                var companyTableAdapter = new CompanyTableAdapter()
                {
                    Connection = { ConnectionString = connProductString }
                };
                var companyDataTable = companyTableAdapter.GetAllCompanies();

                for (int companyRowIndex = 0; companyRowIndex < companyDataTable.Rows.Count; companyRowIndex++)
                {
                    var startTime = DateTime.Now;
                    var companyRow = companyDataTable[companyRowIndex];
                    var companyID = companyRow.ID;
                    try
                    {
                        //Calculate Hash
                        HashSet<ProductSign> insertedProducts = new HashSet<ProductSign>(new ProductSignComparer());
                        var productDataTable = productTableAdapter.GetAllProductName(companyID);
                        for (int productRowIndex = 0; productRowIndex < productDataTable.Rows.Count; productRowIndex++)
                        {
                            var productSign = new ProductSign();
                            var productRow = productDataTable[productRowIndex];
                            if (productRow["Name"] == DBNull.Value)
                                continue;
                            productSign.Name = productRow.Name;
                            if (productRow["Price"] == DBNull.Value)
                                productSign.Price = productRow.Price;
                            if (productRow["ImageUrls"] == DBNull.Value)
                                productSign.ImageUrl = productRow.ImageUrls;
                            if (insertedProducts.Contains(productSign))
                                continue;
                            int rootID = 0;
                            if (productRow["ProductID"] != DBNull.Value)
                                rootID = productRow.ProductID;
                            ProductNameHashBAL.InsertProductNameHash(productRow.ID, productRow.Name, companyID, rootID, productRow.Price);
                            insertedProducts.Add(productSign);
                        }
                        Log.InfoFormat("Insert MerchantProductHash - Company [{0}/{1}]. {2} products", companyRowIndex, companyDataTable.Rows.Count, productDataTable.Rows.Count);
                        var totalTime = (DateTime.Now - startTime).TotalSeconds;
                        Log.InfoFormat("Time: {0} s", totalTime);

                    }
                    catch(Exception innerException)
                    {
                        Log.Error("BuildNameHash. CompanyID: " + companyID, innerException);
                    }
                }
            }
            catch (Exception exception)
            {
                Log.Error("BuildNameHash", exception);
            }

        }

        public class ProductSign
        {
            public int Price;
            public string Name;
            public string ImageUrl;

            public override int GetHashCode()
            {
                return GABIZ.Base.Tools.getCRC32(Name + ImageUrl + Price);
            }
        }

        public static Dictionary<int, List<WebProductIdentity>> productIdentitiesDict;

        public static void BuildProductIdentitiesDict(string connProductString)
        {
            var startTime = DateTime.Now;
            productIdentitiesDict = new Dictionary<int, List<WebProductIdentity>>();
            var listProductIdentities = ProductIdentityBAL.GetListCompletedProductIdentity(connProductString);
            var getDBDuration = (DateTime.Now - startTime).TotalSeconds;
            startTime = DateTime.Now;
            foreach (var productIdentity in listProductIdentities)
            {
                var webProductIdentity = new WebProductIdentity() { SynonymsKeywordSet = new List<List<int>>(), KeywordBlackList = new List<int>(), ProductID = productIdentity.ProductID, MinPrice = productIdentity.MinPrice, MaxPrice = productIdentity.MaxPrice };
                foreach(var synonymsKeywords in productIdentity.KeywordSets)
                {
                    var listHash = new List<int>();
                    foreach(var keyword in synonymsKeywords.SynonymKeywords)
                        listHash.Add(Tools.getCRC32(AutoCorrector.Correct(keyword).ToLower()));
                    webProductIdentity.SynonymsKeywordSet.Add(listHash);
                }
                foreach(var keyword in productIdentity.ExcludeKeywords)
                {
                    webProductIdentity.KeywordBlackList.Add(Tools.getCRC32(AutoCorrector.Correct(keyword).ToLower()));
                }
                foreach(var synonymsKeywords in webProductIdentity.SynonymsKeywordSet)
                {
                    foreach(var hash in synonymsKeywords)
                    {
                        if (productIdentitiesDict.ContainsKey(hash))
                            productIdentitiesDict[hash].Add(webProductIdentity);
                        else
                            productIdentitiesDict.Add(hash, new List<WebProductIdentity> { webProductIdentity });
                    }
                }
            }
            var buidDuration = (DateTime.Now - startTime).TotalSeconds;
            Log.InfoFormat("Build ProductIdentities Dict. GetDB Time: {0}, Build Time: {1} s", getDBDuration, buidDuration);

        }
        public static long IdentifyProduct(string name, long price)
        {
            long result = 0;
            if (string.IsNullOrEmpty(name))
                result = 0;
            else
            {
                name = name.Replace('-', ' ');
                var ngrams = new List<string>();
                for (int i = 1; i <= name.Length; i++)
                    ngrams.AddRange(Tools.NGram(i, AutoCorrector.Correct(name).ToLower()));
                var hashSet = new HashSet<int>();
                for (int i = 0; i < ngrams.Count; i++)
                {
                    var stringHash = Tools.getCRC32(ngrams[i]);
                    if (!hashSet.Contains(stringHash))
                        hashSet.Add(stringHash);
                }
                var productIdentitySet = new Dictionary<long, WebProductIdentity>();
                foreach (var hash in hashSet)
                {
                    if (productIdentitiesDict.ContainsKey(hash))
                        foreach (var webProductIdentity in productIdentitiesDict[hash])
                            if (!productIdentitySet.ContainsKey(webProductIdentity.ProductID))
                                productIdentitySet.Add(webProductIdentity.ProductID, webProductIdentity);
                }
                foreach (var webProductIdentity in productIdentitySet)
                    if (webProductIdentity.Value.Identify(hashSet, price))
                    {
                        result = webProductIdentity.Value.ProductID;
                        break;
                    }
            }
            return result;
        }
        public class ProductSignComparer : IEqualityComparer<ProductSign>
        {
            public bool Equals(ProductSign x, ProductSign y)
            {
                return Equals(x.GetHashCode(), y.GetHashCode());
            }

            public int GetHashCode(ProductSign obj)
            {
                unchecked
                {
                    return obj.GetHashCode();
                }
            }
        }

        //public Dictionary <int,List<>>
        public class WebProductIdentity
        {
            public long ProductID;
            public List<List<int>> SynonymsKeywordSet;
            public List<int> KeywordBlackList;
            public long MinPrice;
            public long MaxPrice;

            public bool Identify(HashSet<int> nameHashSet, long price)
            {
                if (MinPrice > price)
                    return false;
                if (MaxPrice > 0 && MaxPrice < price)
                    return false;
                
                for(int i = 0; i < SynonymsKeywordSet.Count; i++)
                {
                    bool contain = false;
                    for(int j = 0; j < SynonymsKeywordSet[i].Count; j ++)
                    {
                        if(nameHashSet.Contains(SynonymsKeywordSet[i][j]))
                        {
                            contain = true;
                            break;
                        }
                    }
                    if (!contain)
                        return false;
                }
                for(int i = 0; i < KeywordBlackList.Count; i ++)
                {
                    if (nameHashSet.Contains(KeywordBlackList[i]))
                        return false;
                }
                return true;
            }
        }

    }
}
