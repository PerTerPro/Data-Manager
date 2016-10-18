using log4net;
using System;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Product.BAL;
using Websosanh.Core.Product.BO;

namespace WebsosanhCacheTool
{
    public class WebRootProductCacheTool
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WebRootProductCacheTool));
        public static void InsertAllWebRootProductIntoCache(string productConnectionString, string userConnectionString, string searchEnginesServiceUrl)
        {
                var startTime = DateTime.Now;
                var products = WebRootProductBAL.GetAllWebRootProducts(productConnectionString, userConnectionString);
                var parts = products.Partition(100);
                foreach (var productPart in parts)
                {
                    foreach(var product in productPart)
                    {
                        var rootProductMapping = RootProductMappingBAL.GetRootProductMappingFromCache(product.ID, 0, RootProductMappingSortType.PriceWithVAT,false);
                        if(rootProductMapping == null)
                        {
                            RootProductMappingCacheTool.InsertRootProductMappingCache(product.ID, searchEnginesServiceUrl);
                            rootProductMapping = RootProductMappingBAL.GetRootProductMappingFromCache(product.ID, 0, RootProductMappingSortType.PriceWithVAT,false);
                        }
                        if (rootProductMapping == null || rootProductMapping.NumMerchant == 0)
                        {
                            product.Price = 0;
                            product.NumProduct = 0;
                        }
                        else
                        {
                            product.Price = rootProductMapping.MinPrice;
                            product.NumProduct = rootProductMapping.NumMerchant;
                        }
                    }
                    WebRootProductBAL.InsertWebRootProductsIntoCache(productPart);
                }
                var insertAllWebRootProductDuration = (DateTime.Now - startTime).TotalSeconds;
                Logger.InfoFormat("InsertAllWebRootProductIntoCache: {0} products. Duration: {1} s", products.Count, insertAllWebRootProductDuration);
        }

        public static bool InsertWebRootProductIntoCache(long productID, string productConnectionString, string userConnectionString, string searchEnginesServiceUrl)
        {
            var product = WebRootProductBAL.GetWebRootProduct(productID, productConnectionString, userConnectionString);
            if (product == null)
                return false;
            var rootProductMapping = RootProductMappingBAL.GetRootProductMappingFromCache(product.ID, 0, RootProductMappingSortType.PriceWithVAT,false);
            if (rootProductMapping == null)
            {
                RootProductMappingCacheTool.InsertRootProductMappingCache(product.ID, searchEnginesServiceUrl);
                rootProductMapping = RootProductMappingBAL.GetRootProductMappingFromCache(product.ID, 0, RootProductMappingSortType.PriceWithVAT,false);
                if (rootProductMapping == null)
                    return false;
            }
            product.Price = rootProductMapping.MinPrice;
            product.NumProduct = rootProductMapping.NumMerchant;
            return WebRootProductBAL.InsertWebRootProductsIntoCache(new[] { product });
        }
    }
}
