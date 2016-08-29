using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
   public  class PriceLogAdapter
    {
       private Data.SqlDb sqlDb;

       public PriceLogAdapter(Data.SqlDb sqlDb)
       {
           // TODO: Complete member initialization
           this.sqlDb = sqlDb;
       }
        public void Insert(long productID, DateTime datePublic, int newsPrice, int oldPrice)
        {
            throw new NotImplementedException();
        }
    }
}
