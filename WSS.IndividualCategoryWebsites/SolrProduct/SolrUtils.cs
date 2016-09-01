using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using WSS.IndividualCategoryWebsites.SolrProduct;

namespace WSS.IndividualCategoryWebsites
{
    public class SolrUtils
    {
        public static String NormalizeQuery(String searchString)
        {
            var tokens = searchString.Split(SolrProductConstants.IGNORE_CHARS.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            return String.Join("+", tokens).Trim('+').ToLower();
        }

        public static String NormalizeToExactQuery(String searchString)
        {
            var tokens = searchString.Split(SolrProductConstants.IGNORE_CHARS.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            return String.Join(" ", tokens).Trim('+').ToLower();
        }
        public static string ConvertToJson(object item)
        {
            return JsonConvert.SerializeObject(item);
        }
    }
}
