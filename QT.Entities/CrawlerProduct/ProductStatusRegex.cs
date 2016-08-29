using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
    public class ProductStatusRegex
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(ProductStatusRegex));
        private static ProductStatusRegex _objInstance;
        
        Dictionary<int, string> dicProductStatusRegex = new Dictionary<int, string>();
        public static ProductStatusRegex Instance ()
        {
            return (_objInstance == null) ? _objInstance = new ProductStatusRegex() : _objInstance;
        }

        private ProductStatusRegex ()
        {
            try
            {
                string strSetUpRegex = ConfigurationManager.AppSettings["RegexProductStatus"].ToString();
                foreach (string strStatus in strSetUpRegex.Split(';'))
                {
                    dicProductStatusRegex.Add(Convert.ToInt32(strStatus.Split(':')[1]), Convert.ToString(strStatus.Split(':')[0]));
                }
            }
            catch (Exception ex01)
            {
                log.Error(ex01);
                Thread.Sleep(10000);
            }
        }

        public QT.Entities.Common.ProductStatus GetStatusProduct (string input)
        {
            foreach(var item in dicProductStatusRegex)
            {
                if (Regex.IsMatch(input, item.Value))
                    return (Common.ProductStatus)item.Key;
            }
            return Common.ProductStatus.NotDefine;
        }
    }
}
