using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlerProduct
{
    class WorkerCheckPrice
    {
        public delegate long GetCompanyCheck();
        public GetCompanyCheck eventGetCompanyCheck = null;
        public void Start ()
        {
            ProductAdapter pa = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            long companyID = eventGetCompanyCheck();
            if (companyID > 0)
            {
                DataTable tblProduct = pa.GetTopLastChangeProduct(companyID, 3);
                foreach (DataRow rowProduct in tblProduct.Rows)
                {
                    string productName = rowProduct["Name"].ToString();
                    long productPrice = Convert.ToInt64(rowProduct["Price"]);

                }
            }
        }
    }
}
