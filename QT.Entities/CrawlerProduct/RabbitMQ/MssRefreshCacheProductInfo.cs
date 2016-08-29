using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct.RabbitMQ
{
    public class MssCacheCompany
    {
        public long CompanyID { get; set; }

        public object[] Domain { get; set; }
    }

    public class MssRefreshCacheProductInfo
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(MssRefreshCacheProductInfo));

        public static MssRefreshCacheProductInfo FromJSON(string str)
        {
            
            try
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<MssRefreshCacheProductInfo>(str);
            }
            catch (Exception ex01)
            {
                return null;
            }
        }

        public string GetMss ()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public long CompanyID { get; set; }

        public string Domain { get; set; }
    }
}
