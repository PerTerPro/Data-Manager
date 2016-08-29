using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities
{
    public static class FTPAccount
    {
    }
    //Ip, user, pass ftp image cửa hàng (ảnh gốc)
    public static class StoreImageFTP
    {
        public static string HostIP {
            
            get{
                string r = "ftp://183.91.14.84";
                try
                {
                    r = ConfigurationManager.AppSettings["StoreImageHostIP"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
                } 
        }
        public static string UserAccount
        {
           
            get
            {
                string r = "storeimage";
                try
                {
                    r = ConfigurationManager.AppSettings["StoreImageUserAcount"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static string Password
        {
            
            get
            {
                string r = "wssadmin2015";
                try
                {
                    r = ConfigurationManager.AppSettings["StoreImagePassword"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }

    }

    //Ip, user, pass ftp image cửa hàng (ảnh Thumb)
    public static class StoreImageThumbFTP
    {
        public static string HostIP
        {
            
            get
            {
                string r = "ftp://183.91.14.84";
                try
                {
                    r = ConfigurationManager.AppSettings["StoreImageThumbHostIP"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static string UserAccount
        {
            
            get
            {
                string r = "storeimagethumb";
                try
                {
                    r = ConfigurationManager.AppSettings["StoreImageThumbUserAcount"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static string Password
        {
            
            get
            {
                string r = "wssadmin2015";
                try
                {
                    r = ConfigurationManager.AppSettings["StoreImageThumbPassword"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static string SizeThumb
        {
            
            get
            {
                string r = "_140";
                try
                {
                    r = ConfigurationManager.AppSettings["StoreImageThumbSize"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }

    }

    //Ip, user, pass ftp image SP Goc (Ảnh gốc)
    public static class SPGocImageFTP
    {
        public static string HostIP
        {
            
            get
            {
                string r = "ftp://183.91.14.84";
                try
                {
                    r = ConfigurationManager.AppSettings["SPGocImageHostIP"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static string UserAccount
        {
            
            get
            {
                string r = "spgocimage";
                try
                {
                    r = ConfigurationManager.AppSettings["SPGocImageUserAcount"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static string Password
        {
            
            get
            {
                string r = "wssadmin2015";
                try
                {
                    r = ConfigurationManager.AppSettings["SPGocImagePassword"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }

    }

    //Ip, user, pass ftp image SP Goc (ảnh Thumb)
    public static class SPGocImageThumbFTP
    {
        public static string HostIP
        {
            
            get
            {
                string r = "ftp://183.91.14.84";
                try
                {
                    r = ConfigurationManager.AppSettings["SPGocImageThumbHostIP"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static string UserAccount
        {
            
            get
            {
                string r = "spgocimagethumb";
                try
                {
                    r = ConfigurationManager.AppSettings["SPGocImageThumbUserAcount"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static string Password
        {
            
            get
            {
                string r = "wssadmin2015";
                try
                {
                    r = ConfigurationManager.AppSettings["SPGocImageThumbPassword"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static string SizeThumb
        {
            
            get{
                string r = "_140";
                try
                {
                    r = ConfigurationManager.AppSettings["SPGocImageThumbSize"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }

    }

    //Ip, user, pass ftp ảnh sản phẩm của cửa hàng (Ảnh gốc)
    public static class ProductStoreImageFTP
    {
        public static string HostIP
        {

            get
            {
                string r = "ftp://183.91.14.84";
                try
                {
                    r = ConfigurationManager.AppSettings["ProductStoreImageHostIP"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static string UserAccount
        {

            get
            {
                string r = "productimage";
                try
                {
                    r = ConfigurationManager.AppSettings["ProductStoreImageUserAcount"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static string Password
        {

            get
            {
                string r = "wssadmin2015";
                try
                {
                    r = ConfigurationManager.AppSettings["ProductStoreImagePassword"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }

    }

    //Ip, user, pass ftp image sản phẩm cửa hàng (ảnh Thumb)
    public static class ProductStoreImageThumbFTP
    {
        public static string HostIP
        {

            get
            {
                string r = "ftp://183.91.14.84";
                try
                {
                    r = ConfigurationManager.AppSettings["ProductStoreImageThumbHostIP"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static string UserAccount
        {

            get
            {
                string r = "producstoreimagethumb";
                try
                {
                    r = ConfigurationManager.AppSettings["ProductStoreImageThumbUserAcount"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static string Password
        {

            get
            {
                string r = "wssadmin2015";
                try
                {
                    r = ConfigurationManager.AppSettings["ProductStoreImageThumbPassword"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }
        public static string SizeThumb
        {

            get
            {
                string r = "_140";
                try
                {
                    r = ConfigurationManager.AppSettings["ProductStoreImageThumbSize"].ToString();
                }
                catch (Exception)
                {
                }
                return r;
            }
        }

    }
}
