using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlerProduct
{
    class CheckFailRegex
    {
        ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
        public void RunCheck(long CompanyID)
        {
            List<long> lstProductDelete = new List<long>();
            
        }
    }
}