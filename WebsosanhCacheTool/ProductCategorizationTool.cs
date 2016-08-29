using log4net;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.Redis;
using WebsosanhCacheTool.CompanyDataSetTableAdapters;
using WebsosanhCacheTool.ProductDataSetTableAdapters;

namespace WebsosanhCacheTool
{
    public class ProductCategorizationTool
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(ProductCategorizationTool));
        private static string productCategoryKeyFormat = "PRODUCT_CATID:{0}";
        public static void BuildCategory(string connProductString)
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
                    var companyRow = companyDataTable[companyRowIndex];
                    try
                    {
                        var startTime = DateTime.Now;                        
                        var companyID = companyRow.ID;
                        var productDataTable = productTableAdapter.GetAllProductName(companyID);
                        List<KeyValuePair<long, int>> productCategoryMap = new List<KeyValuePair<long, int>>();
                        for (int productRowIndex = 0; productRowIndex < productDataTable.Rows.Count; productRowIndex++)
                        {
                            var productRow = productDataTable[productRowIndex];
                            if (productRow["Name"] == DBNull.Value)
                                continue;
                            int categoryID = GetCategory(productRow.Name);
                            if(categoryID >= 0)
                                productCategoryMap.Add(new KeyValuePair<long, int>(productRow.ID, categoryID));
                            if (productCategoryMap.Count >= 1000)
                            {
                                var database = RedisManager.GetRedisServer("redisProductCategory").GetDatabase(0);
                                database.StringSet(productCategoryMap.Select(x => new KeyValuePair<RedisKey, RedisValue>(string.Format(productCategoryKeyFormat, x.Key), x.Value)).ToArray());
                                productCategoryMap.Clear();
                            }
                            //Thread.Sleep(10);
                        }
                        if (productCategoryMap.Count > 0)
                        {
                            var database = RedisManager.GetRedisServer("redisProductCategory").GetDatabase(0);
                            database.StringSet(productCategoryMap.Select(x => new KeyValuePair<RedisKey, RedisValue>(string.Format(productCategoryKeyFormat, x.Key), x.Value)).ToArray());
                        }
                        Log.InfoFormat("Insert MerchantProductCategory - Company [{0}/{1}]. {2} products", companyRowIndex, companyDataTable.Rows.Count, productDataTable.Rows.Count);
                        var totalTime = (DateTime.Now - startTime).TotalSeconds;
                        Log.InfoFormat("Time: {0} s", totalTime);
                    }
                    catch(Exception innerException)
                    {
                        Log.Error("Insert MerchantProductCategory. Company: " + companyRow.ID, innerException);
                    }
                }
            }
            catch (Exception exception)
            {
                Log.Error("Insert MerchantProductCategory", exception);
            }

        }
        public static int GetCategory(string keyword, double minProbabilityThreadhold = 0.3)
        {
            using (MyWebClient client = new MyWebClient())
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        client.Headers.Add("Accept-Language", " en-US");
                        client.Headers.Add("Accept-Encoding", "gzip, deflate");
                        client.Headers.Add("Accept", " text/html, application/xhtml+xml, */*");
                        client.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)");
                        client.Encoding = Encoding.UTF8;
                        string url = "http://172.22.1.108/api/MLAPI/suggest.htm?restoreResults=2&original=true&keyword=" + Uri.EscapeDataString(keyword);
                        string s = client.DownloadString(url);
                        var result = JsonConvert.DeserializeObject<ProductCategorizationResult>(s);
                        if (result == null || result.results.Length == 0 || result.results[0].prob < minProbabilityThreadhold)
                            return 0;
                        return result.results[0].categoryId;
                    }
                    catch (Exception)
                    {
                    }
                }
                return -1;
            }
        }

        private class MyWebClient : WebClient
        {
            protected override WebRequest GetWebRequest(Uri uri)
            {
                WebRequest w = base.GetWebRequest(uri);
                w.Timeout = 150;
                return w;
            }
        }

        public static int[] GetCategories(IEnumerable<long> productIDs)
        {
            var database = RedisManager.GetRedisServer("redisProductCategory").GetDatabase(0);
            var redisResult = database.StringGet(productIDs.Select(x => (RedisKey)string.Format(productCategoryKeyFormat, x)).ToArray());
            var result = new int[redisResult.Length];
            for(int i = 0; i < redisResult.Length; i ++)
            {
                if(redisResult[i] == RedisValue.Null)
                    result[i] = 0;
                else
                    result[i] = (int)redisResult[i];
            }
            return result;
        }
    }

    public class ProductCategorizationResult
    {
        public string keyword;
        public CategoryResult[] results;
    }

    public class CategoryResult
    {
        public double prob;
        public string categoryName;
        public int categoryId;
    }
}
