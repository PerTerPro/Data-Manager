using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crl.ProducProperties.Core
{
    public class ConfigStatic
    {
        public static string ProductPropertyConnection = "Data Source=192.168.100.178;Initial Catalog=CrlProductPropertiesWss;Persist Security Info=True;User ID=sa;Password=123456a@;connection timeout=200";
        public static string ProductConnection = "Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";

        public static string KeyRabbitMqCrlProductProperties = "RabbitMqCrawlerProduct";

        public static string GetQueueWaitDownloadHtml(string domain)
        {
            return string.Format("Crl.ProductProperties.WaitDownloadHtml.{0}", domain);
        }

        public static string KeyNoSqlHtml = "NoSqlHtml";

        public static string GetQueueParse(string domain)
        {
            return string.Format("Crl.ProductProperties.WaitParseProduct.{0}", domain);
        }
    }
}
