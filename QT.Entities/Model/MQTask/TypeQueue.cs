using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Model.MQTask
{
    public static class TypeQueue
    {
        public static string prefixCrawlerSaleNew = "prefixCrawlerSaleNew";


        public static string prefixQueueCrawlerLink = "product_crawler_new_queueLink_";

        /// <summary>
        /// Danh sách companies chờ xử lí. Sử dụng queue này khi mỗi company chỉ 
        /// phải xử lí qua đúng 1 lần duy nhất.
        /// </summary>
        public static string CrawlerProduct_CompaniesWait = "CrawlerProduct_CompaniesWait";

        /// <summary>
        /// Crawler lại toàn bộ 1 company
        /// </summary>
        public static string product_crawler_new = "product_crawler_new";

        /// <summary>
        /// 1 sản phẩm cần Crawl lại price
        /// </summary>
        public static string CrawlerProduct_ReloadPrice = "CrawlerProduct_ReloadPrice";
        public static string CrawlerSaleNew_FullCrawler= "CrawlerSaleNew_FullCrawler";

        public static string QueueChangeMainInfo = "QueueChangeMainInfo";

        public static string QueueChangeImage = "QueueChangeImage";
    }
}
