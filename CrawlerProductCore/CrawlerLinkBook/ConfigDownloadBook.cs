using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerLinkBook
{
    public static class ConfigDownloadBook{
        public static string QueueDownloadBook = "DownloadBookPdf";
        public static string RegexProduct = @"http://it-ebooks.info/book/\d+/";
        public static string RegexVisit = @"http://it-ebooks.info.*";
        public static string RegexNoVisit = @"http.*http";
        public static string KeyRedisManager = "redisVisitedCrcFN";
        public static string ConnectionSql = "Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;Connect Timeout=5000";
    }
}
