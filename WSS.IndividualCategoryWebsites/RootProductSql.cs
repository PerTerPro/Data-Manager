using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.IndividualCategoryWebsites
{
    public class RootProductSql
    {
        public long RootId { set; get; }
        public string Name { set; get; }
        public int WebsiteId { set; get; }
        public long MinPrice { set; get; }
        public int NumMerchant { set; get; }
        public List<long> ProductIdList { set; get; }
        public string ProductIdListString { set; get; }
        public string GetProductIdListString()
        {
            return string.Join(",", ProductIdList);
        }
        public string LocalPath { set; get; }
        public string Image { set; get; }
        public int CategoryId { set; get; }
    }
}
