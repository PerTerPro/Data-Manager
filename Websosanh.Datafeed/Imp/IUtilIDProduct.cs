using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using QT.Entities;
using Websosanh.Datafeed.Model;

namespace Websosanh.Datafeed.Imp
{
    public class UtilIdProduct 
    {
        public static long GenerateId(string detailUrl, string regex = "")
        {
            var urlDecode = HttpUtility.UrlDecode(HttpUtility.UrlDecode(detailUrl));
            if (urlDecode != null)
            {
                var decodedUrl = urlDecode.Trim().ToLower();
                if (string.IsNullOrEmpty(regex))
                {
                    return Common.GetIDProduct(detailUrl);
                }
                else
                {
                    var originalUrlRegexPattern = new Regex(regex);
                    string originUrl = originalUrlRegexPattern.Match(decodedUrl).Value;
                    if (!string.IsNullOrEmpty(originUrl))
                    {
                        return Common.GetIDProduct(originUrl);
                    }
                    else
                    {
                        return Common.GetIDProduct(detailUrl);
                    }
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
