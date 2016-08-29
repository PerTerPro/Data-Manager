using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlProd
{
    public class RedisCrlProduct
    {
        public static string PrefixCrawl = "crl_prod";          //Tiền tố cả hệ thống.
        public static string FieldSession_StartAt = "start_at"; //Khởi động crawler.
        public static string FieldSession_NumberProduct = "number_product"; //Số SP.
        public static string FieldSession_NumberVited = "number_visited";   //Số link duyệt qua.
        public static string SetVisited = ":session";
        public static string PrefixSetVisited =  PrefixCrawl + ":set_visited_url";
        public static string PrefixQueueWait = PrefixCrawl+ ":queue_wait";

        internal void ClearDataRelSession(long company, int p)
        {
            
        }

        internal void InitDataSession(long company, int p)
        {
           
        }
    }
}
