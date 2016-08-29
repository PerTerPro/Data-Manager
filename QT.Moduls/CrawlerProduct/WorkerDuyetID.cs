
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlerProduct
{
    public class WorkerDuyetID
    {
        private long CompanyID;
        public WorkerDuyetID (long CompanyID)
        {
            this.CompanyID = CompanyID;
        }

        public void Start ()
        {
           
        }

        public void Run()
        {
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            Queue<long> queueCompany = new Queue<long>();
            DataTable tblCompany = productAdapter.GetCompanyCrawler();
            foreach (DataRow rowCom in tblCompany.Rows) queueCompany.Enqueue(Convert.ToInt64(rowCom["ID"]));
            for (int i = 0; i < 30; i++)
            {
               
            }
        }
    }
}
