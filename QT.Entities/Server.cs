using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Net;
using log4net;

namespace QT.Entities
{
    public static class Server
    {

        public static ILog log = LogManager.GetLogger(typeof (Server));
        public const String ConnectionStringVatGia = "Data Source=118.70.205.94,8888;Initial Catalog=PriceComparision;User ID=sa;Password=Qtsa2008R2;connection timeout=300000";
        //public const String ConnectionStringCrawler = "Data Source=118.70.205.94,8888;Initial Catalog=QTCrawler;User ID=sa;Password=Qtsa2008R2;connection timeout=300000";

        private static string _connection = "";
        //private static string _userConnection = "Data Source=183.91.14.82;Initial Catalog=QT_User;Persist Security Info=True;User ID=qt_user;Password=@F4sJ=l9/ryJt9M34T;connection timeout=50000000";
        private static string _userConnection = "Data Source=118.70.205.94,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=50000000";
        private static string _connectionCrawler = "";
        private static string _logConnection = "";
        public static string RabbitMQ_Host = "192.168.100.135";
        public static int RabbitMQ_Port = 5672;
        public static string RabbitMQ_User = "manhdx";
        public static string RabbitMQ_Pass = "123456a@";
        public static string NodeID;


        public static string MachineCode 
        {
            get
            {
                return (_MachineCode == "")
                    ? _MachineCode = Common.CrcProductID(Guid.NewGuid().ToString()).ToString()
                    : _MachineCode;
            }
        }

        private static string _MachineCode = Common.CrcProductID(Guid.NewGuid().ToString()).ToString();

        public static string GetMachineCode ()
        {
            return _MachineCode;
        }

        public static int MaxThreadCrawler
        {
            get
            {
                try
                {
                    return Convert.ToInt32(ConfigurationManager.AppSettings["MaxThreadCrawler"]);
                }
                catch (Exception ex)
                {
                    return 30;
                }
            }
        }
        
        public static String ConnectionStringCrawler
        {
            set { _connectionCrawler = value; }
            get {
                return _connectionCrawler;
                //string r = "Data Source=42.112.17.185;Initial Catalog=QTCrawler;Persist Security Info=True;User ID=qt_vn;Password=37xCByyYbO6bmN6LA0nr;connection timeout=500000";
                //try
                //{
                //    r = ConfigurationManager.AppSettings["conCrawler"].ToString();
                //}
                //catch (Exception)
                //{
                //}
                //return r;
            }
        }
        public static String LogConnectionString
        {
            set { _logConnection = value; }
            get {
                return _logConnection;
            }
        }
        
        public static String ConnectionStringUser
        {
            set { _userConnection = value; }
            get
            {
                try
                {
                    _userConnection = ConfigurationManager.AppSettings["conUser"].ToString();
                }
                catch (Exception)
                {
                }
                return _userConnection;
            }
        }
        public static String ConnectionString
        {
            set { _connection = value; }
            get
            {
                //return "Data Source=192.168.100.169;Initial Catalog=QT_2;Persist Security Info=True;User ID=sa;Password=12qwAS";
                return _connection;
                //string r = "Data Source=118.70.205.94,1452;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=37xCByyYbO6bmN6LA0nr;connection timeout=500000";
                //try
                //{
                //    r= ConfigurationManager.AppSettings["conQT"].ToString();
                //}
                //catch (Exception)
                //{
                //}
                //return r;
            }
        }
        public static String UserConnectionString
        {
            set { _userConnection = value; }
            get
            {
                try
                {
                    _userConnection = ConfigurationManager.AppSettings["conUser"].ToString();
                }
                catch (Exception)
                {
                }
                return _userConnection;
            }
        }
        public static String ConnectionStringNews
        {
            set { }
            get
            {
                string r = "Data Source=118.70.205.94,1455;Initial Catalog=ReviewsCMS;Persist Security Info=True;User ID=qt_new;Password=11qsQEF4sJ=l9/ryJt9MT;connection timeout=500000";
                try
                {
                    r = ConfigurationManager.AppSettings["conQTNews"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static String ConnectionStringFromNews
        {
            set { }
            get
            {
                string r = "Data Source=118.70.205.94,1452;Initial Catalog=NCWebCrawler;Persist Security Info=True;User ID=Gabiz;Password=trungchem!@21;connection timeout=500000";
                try
                {
                    r = ConfigurationManager.AppSettings["conNews"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        
        
        
        // = "Data Source=118.70.185.174,8888;Initial Catalog=QTCrawler;User ID=sa;Password=Qtsa2008R2;connection timeout=300000";
        //public const String ConnectionString = "Data Source=183.91.14.169,8888;Initial Catalog=QT_2;User ID=qt_vn;Password=Qtsa2008R2;connection timeout=3000000";
        //public const String ConnectionString = "Data Source=42.112.17.187;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=37xCByyYbO6bmN6LA0nr;connection timeout=500000";
        
        //public const String ConnectionStringCrawler = @"Data Source=172.16.2.73,3387;User ID=sa;Password=Qtsa2008R2;connection timeout=300000;Initial Catalog=QTCrawler";
        //public const String ConnectionString = "Data Source=172.16.2.73,3387;User ID=sa;Password=Qtsa2008R2;connection timeout=300000;Initial Catalog=QT_2";
        

        /// server ke toan
        /// public const String ConnectionStringCrawler = @"Data Source=172.16.2.22\R2;User ID=sa;Password=Qtsa2008R2;connection timeout=300000;Initial Catalog=QTCrawler";
         

        //nguyentrungdung@mof.gov.vn
        //public const String ConnectionString = "Data Source=118.70.205.94,8888;User ID=sa;Password=Qtsa2008R2;connection timeout=300000;Initial Catalog=QT_2";


        // Datacenter
        //public const String ConnectionString = "Data Source=183.91.14.169,8888;Initial Catalog=QT_2;User ID=qt_vn;Password=Qtsa2008R2;connection timeout=300000";

        //public const String ConnectionString = "Data Source=118.70.205.94,8888;Initial Catalog=QT;Persist Security Info=True;User ID=sa;Password=Qtsa2008R2;connection timeout=300000";
        //public const String ConnectionStringVatGia = "Data Source=118.70.205.94,8888;Initial Catalog=PriceComparision;Persist Security Info=True;User ID=qt;Password=Qtsa2008R2;connection timeout=300000";
        public static String ServerName {
            get {
                string s = "";
                int i = ConnectionString.IndexOf(";User");
                s = ConnectionString.Substring(12, i-12);
                return s;
            }
        }
        public static String ServerRun{
            get
            {
                string r = "local";
                try
                {
                    r = ConfigurationManager.AppSettings["server"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static int totalViewProductImage
        {
            set { }
            get
            {
                return Common.Obj2Int(ConfigurationManager.AppSettings["totalProductLoadImage"].ToString());
            }
        }

        public static string RedisDB_Host { get; set; }

        public static int RedisDB_Port { get; set; }

        public static string RedisConnect
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["redisCacheCrawlerProduct"].ToString();
                }
                catch (Exception)
                {
                    return "192.168.100.211:11312,connectTimeout=10000,syncTimeout=10000";
                }
            }
        }

        public static string QueueNameCrawler
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["QueueNameCrawler"].ToString();
                }
                catch (Exception)
                {
                    return "";
                }
            }
        }

        public static bool AllowAutoCrawler
        {
            get
            {
                try
                {
                    return Convert.ToBoolean( ConfigurationManager.AppSettings["AllowAutoCrawler"]);
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }



        public static bool ShowButtonNotVisibleProduct
        {
            get
            {
                try
                {
                    return Convert.ToBoolean(ConfigurationManager.AppSettings["ShowButtonNotVisibleProduct"]);
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static string _rabbitMQ_CrawlerProduct = "";

        static int _AllowSaveProductInfoInRedis = 0;
        public static int UserID { get; set; }
        public static bool AllowSaveProductInfoInRedis
        {
            get
            {
                if (_AllowSaveProductInfoInRedis == 0) _AllowSaveProductInfoInRedis = Convert.ToBoolean(ConfigurationManager.AppSettings["AllowSaveProductInfoInRedis"]) == true ? 1 : 2;
                return _AllowSaveProductInfoInRedis == 1;
            }
        }
        public static string RabbitMQ_CrawlerProduct
        {
            get
            {
                return "rabbitMQ177";
            }
        }

        public static string RabbitMQ_CacheProductCrawler
        {
            get
            {
                return "redisCacheCrawlerProduct";
            }
        }

        private  static string strIPHost = "";
        public static string IPHost
        {
            get
            {
                try
                {
                    return Dns.GetHostName();
                }
                catch (Exception ex)
                {
                    log.Warn(ex);
                    return "";
                }
                return strIPHost;
            }
        }
    }
}
