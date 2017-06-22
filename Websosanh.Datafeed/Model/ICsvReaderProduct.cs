using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;
using QT.Moduls.Company;

namespace Websosanh.Datafeed.Model
{
    public interface ICsvReaderProduct
    {
        void ReadDataFeedProductsFromCsvFile(string csvPath, long companyId, string domain, EventHandler<Product> eventHandler);
    }
}
