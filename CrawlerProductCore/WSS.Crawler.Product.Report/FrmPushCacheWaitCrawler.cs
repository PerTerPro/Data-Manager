using QT.Entities.Data;
using QT.Moduls.CrawlerProduct.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmPushCacheWaitCrawler : Form
    {
        
        private SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
        private RedisCompanyWaitCrawler redisWaitCrawler = null;
        private DataTable tblCompany = null;
        long CompanyID = 0;
        private List<string> lstDomain = new List<string>();
        private List<long> lstCompanyID = new List<long>();
        public FrmPushCacheWaitCrawler()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            int hours = QT.Entities.Common.Obj2Int(txtHours.Text);
            redisWaitCrawler = QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler.Instance();
            lstDomain = QT.Entities.Common.GetListXPathFromString(richTextBox1.Text);
            foreach (string strDomain in lstDomain)
            {
                tblCompany = sqldb.GetTblData("Select ID from company where Domain = @Domain and Status = 1 and DataFeedType = 0", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { 
                    sqldb.CreateParamteter("@Domain",strDomain,SqlDbType.NVarChar)
                });
                if (tblCompany.Rows.Count > 0)
                {
                    CompanyID = QT.Entities.Common.Obj2Int64(tblCompany.Rows[0]["ID"]);
                    lstCompanyID.Add(CompanyID);
                }
            }
            if (rdbCkFN.Checked == true)
            {
                foreach (long CompanyID in lstCompanyID)
                {
                    redisWaitCrawler.SetNexFindNew(CompanyID, hours);
                }
                lstCompanyID.Clear();

            }
            else
            {
                foreach (long CompanyID in lstCompanyID)
                {
                    redisWaitCrawler.SetNexReload(CompanyID, hours);
                }
                lstCompanyID.Clear();
            }
            
            MessageBox.Show(string.Format("Pushed: {0} company", lstDomain.Count));
            lstDomain.Clear();
        }
    }
}
