using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.FixProductID
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDb sqlDb = new SqlDb(@"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
            DataTable tblCompany = new DataTable();
            foreach(DataRow row in tblCompany.Rows)
            {
                long CompanyID = Convert.ToInt64(row["ID"]);
                DataTable tblProduct = null;
                while(tblProduct.Rows.Count==0)
                {
                    
                }
            }
        }
    }
}
