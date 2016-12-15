using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Core.Crawler
{
    public static class UtilCrawlerProduct
    {
        public static IEnumerable<string> NoCrawlerRegexDefault = new string[]
        {
           
            @"(http(s?):).*(?:jpg|gif|png)$",@".*#.*",
            @".*twitter.com.*",
            @".*facebook.com.*",
            @".*add.to.cart\=.*",
            @".*tin.tuc.*",
            @".*lien.he.*",
            @".*gioi-thieu.*",
            @".*don-hang",@".*filter.*",
            @".+dispatch.+",
            @".*product_compare.*",
            @".*login.*",
            @".*search.*",
            @".*rao-vat.*",@".*sort.*",
            //@".+view=.+",
            @".+=.+=.+=.+",
            @".*javascript.*",
            @".*report.*",
            @".*direct.*",
            @".*google.com.*",
            @".*http.*http.*",
            @".*html.*html.*",@".*respond.*",
            @".*/tag/.*"
        };
    }
}
