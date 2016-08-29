using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Product.BAL;
using Websosanh.Core.Product.BO;

namespace WebsosanhCacheTool
{
    public class WebProductPropertyCacheTool
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WebProductPropertyCacheTool));
        public static void InsertProductPropertiesToCache(string productConnectionString)
        {
                var startTime = DateTime.Now;
                var allProductProperties = WebProductPropertyBAL.GetAllProductProperties(productConnectionString);
                var getAllProductPropertiesDuration = (DateTime.Now - startTime).TotalSeconds;
                startTime = DateTime.Now;
                var productPropertiesParts = CollectionUtilities.Partition<KeyValuePair<long, List<ProductPropertyEntry>>>(allProductProperties, 1000);
                foreach (var part in productPropertiesParts)
                    WebProductPropertyBAL.InsertProductPropertiesToCache(part);
                var insertProductPropertiesDuration = (DateTime.Now - startTime).TotalSeconds;
                startTime = DateTime.Now;
                var allProductFilterProperties = WebProductPropertyBAL.GetAllProductFilterProperties(productConnectionString,allProductProperties);
                var getAllProductFilterPropertiesDuration = (DateTime.Now - startTime).TotalSeconds;
                startTime = DateTime.Now;
                var productFilterPropertiesParts = CollectionUtilities.Partition<KeyValuePair<long, List<ProductPropertyEntry>>>(allProductFilterProperties, 1000);
                foreach (var part in productFilterPropertiesParts)
                    WebProductPropertyBAL.InsertProductFilterPropertiesToCache(part);
                var insertProductFilterPropertiesDuration = (DateTime.Now - startTime).TotalSeconds;                
                Logger.InfoFormat("InsertProductPropertiesToCache: {0} products. GetAllProductProperties Time: {1} s. InsertProductProperties Time: {2} s", allProductProperties.Count, getAllProductPropertiesDuration, insertProductPropertiesDuration);
                Logger.InfoFormat("InsertProductFilterPropertiesToCache: {0} products. GetAllProductFilterProperties Time: {1} s. InsertProductFilterProperties Time: {2} s",allProductFilterProperties.Count, getAllProductPropertiesDuration, insertProductPropertiesDuration);
        }
    }
}
