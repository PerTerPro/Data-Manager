using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.UpdateCountView
{
    public class Runner
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Runner));
        DateTime NextRun = new DateTime(1990, 1, 1);
        private int MAX_HOUR_LOOP = 24;
        private int HOUR_RUN = 14;


        public Runner()
        {
            MAX_HOUR_LOOP = Convert.ToInt32(ConfigurationManager.AppSettings["MAX_HOUR_LOOP"]);
            HOUR_RUN = Convert.ToInt32(ConfigurationManager.AppSettings["HOUR_RUN"]);
        }

        public void Run(System.Threading.CancellationToken token)
        {
            log.InfoFormat("Start run at {0}", DateTime.Now.ToString());
            int COunt = 0;
            List<string> querys = new List<string>();
            SqlDb sqlDbSource = new SqlDb(ConfigurationManager.AppSettings["SourceViewCountConntion"]);
            SqlDb sqlDbDestination = new SqlDb(@"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
            DataTable tblCOmpany = sqlDbDestination.GetTblData(@"select Id
                                                                    from Company
                                                                    where TotalProduct>0", CommandType.Text, null);
            foreach (DataRow rowInfo in tblCOmpany.Rows)
            {
                token.ThrowIfCancellationRequested();

                long CompanyID = Convert.ToInt64(rowInfo["Id"]);
                DataTable tblProduct = sqlDbSource.GetTblData(string.Format(@"SELECT ProductId, SUM(a.Count) AS Count 
                    FROM MerchantClick a
                    WHERE a.MerchantId = {0}
                    GROUP BY ProductId", CompanyID), CommandType.Text, null);

                if (tblProduct != null && tblProduct.Rows.Count > 0)
                {
                    token.ThrowIfCancellationRequested();

                    COunt++;

                    foreach (DataRow productRow in tblProduct.Rows)
                    {
                        querys.Add(string.Format("update product set viewcount = {0} where id = {1}", Convert.ToInt64(productRow["Count"]).ToString(), Convert.ToInt64(productRow["ProductId"]).ToString()));
                        if (querys.Count > 200)
                        {
                            string queryAll = QT.Entities.Common.ConvertToString(querys);
                            bool bOK = sqlDbDestination.RunQuery(queryAll, CommandType.Text, null, true, 10000);
                            querys.Clear();
                            if (bOK)
                            {
                                log.InfoFormat("Run 200 products");
                            }
                            else
                            {
                                log.ErrorFormat("Error when update product");
                            }
                        }
                    }
                    log.InfoFormat("updated for company {0} {1}/{2} CountProduct:{3}", CompanyID, COunt, tblCOmpany.Rows.Count, tblProduct.Rows.Count);
                }
                else
                {
                    log.Error("ProductTable is null");
                }
            }

            SaveData(sqlDbDestination, querys);
            NextRun = DateTime.Now.AddHours(MAX_HOUR_LOOP);
            log.InfoFormat("End at {0}", DateTime.Now.ToString());
        }

        private void SaveData(SqlDb sqlDbDestination, List<string> querys)
        {
            string queryAll = QT.Entities.Common.ConvertToString(querys);
            bool bOK = sqlDbDestination.RunQuery(queryAll, CommandType.Text, null, true, 10000);
            querys.Clear();
            if (bOK)
            {
                log.InfoFormat("Run 200 products");
            }
            else
            {
                log.ErrorFormat("Error when update product");
            }
        }

        internal void Start(System.Threading.CancellationToken token)
        {
            while (true)
            {
                token.ThrowIfCancellationRequested();
                if (DateTime.Now.Hour == this.HOUR_RUN && NextRun < DateTime.Now)
                {
                    Run(token);
                }
                else
                {
                    log.InfoFormat("Running at {0} h. So, app wait last {1} Minute", HOUR_RUN, (int)(DateTime.Now - NextRun).TotalMinutes);
                    token.WaitHandle.WaitOne(60000 * 5);
                }
            }
        }
    }
}
