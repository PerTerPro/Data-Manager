using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Product.BAL;

namespace CacheManager
{
    public class ProductNameAnalyser
    {
        public static IEnumerable<string> ToTokens(string name)
        {
            return name.ToLower().Split(SolrProductConstants.IGNORE_CHARS.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }
        public static double MeasureNameCoverRatioForSummary(string name, string summary)
        {
            var nameTokens = ToTokens(name).ToList();
            var summaryTokens = ToTokens(summary);
            int containCount = 0;
            foreach (var token in summaryTokens)
                if (nameTokens.Contains(token))
                    containCount++;
            return (double)containCount / summaryTokens.Count();
        }
    }
}
