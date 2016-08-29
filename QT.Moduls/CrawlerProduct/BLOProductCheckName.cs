using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;

namespace QT.Moduls.CrawlerProduct
{
    
    public class BLOProductCheckName
    {

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(BLOProductCheckName));
        Dictionary<string, int> dicCountDup = new Dictionary<string, int>();
        ProductAdapter _productAdapter = null;
        private SqlDb db;

        public BLOProductCheckName (string Connection)
        {
            this._productAdapter = new ProductAdapter(new SqlDb(Connection));
        }

        public BLOProductCheckName(SqlDb db)
        {
            this._productAdapter = new ProductAdapter(db);
        }

        public void ResetCalDupName()
        {
            int iCount = 1;
            DataTable tblCompCheckDupName = _productAdapter.GetCompanyCheckDupName();
            foreach (DataRow rowComp in tblCompCheckDupName.Rows)
            {
                iCount++;
                long CompanyID = QT.Entities.Common.Obj2Int64(rowComp["ID"]);
                this.RefreshCacheDuplProductByCompany(CompanyID);
                log.Info(string.Format("IndexCompany:{0}/{1}", iCount, tblCompCheckDupName.Rows.Count));

                Thread.Sleep(100);
            }
        }

        public void RefreshCacheDuplProductByCompany(long CompanyID)
        {
            Dictionary<string, int> dicCheckDup = new Dictionary<string, int>();
            DataTable tblProductName = _productAdapter.GetProductNameValidOfCompany(CompanyID);
            foreach (DataRow rowProduct in tblProductName.Rows)
            {
                string ProductName = rowProduct["Name"].ToString();
                if (!dicCheckDup.ContainsKey(ProductName)) dicCheckDup.Add(ProductName, 1);
                else dicCheckDup[ProductName] = dicCheckDup[ProductName] + 1;
            }

            string NameMax = "";
            int CountMax = 0;
            foreach(var item in dicCheckDup)
            {
                if (item.Value>CountMax)
                {
                    NameMax = item.Key;
                    CountMax = item.Value;
                }
            }


            _productAdapter.UpdateMaxDup(CompanyID, CountMax, NameMax);
            log.Info("Checked for company:" + CompanyID + ":" + CountMax);
        }
    }
}
