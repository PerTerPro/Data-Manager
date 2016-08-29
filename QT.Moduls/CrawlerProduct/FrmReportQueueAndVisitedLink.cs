using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmReportQueueAndVisitedLink : Form
    {
        SqlDb sqlQT2 = new SqlDb(QT.Entities.Server.ConnectionString);
        SqlDb sqlQTCrawler = new SqlDb("Data Source=172.22.30.82,1452;Initial Catalog=QTCrawler;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200");
        DataTable tblCountQueue = null;
        DataTable tblCompany = null;

        

        public FrmReportQueueAndVisitedLink()
        {
            InitializeComponent();
        }

        private void FrmReportQueueAndVisitedLink_Load(object sender, EventArgs e)
        {
            DataTable tblNeed = new DataTable();
            DataColumn dc1 = new DataColumn("CompanyID", typeof(long));
            DataColumn dc2 = new DataColumn("VisitedCount", typeof(int));
            DataColumn dc3 = new DataColumn("Domain", typeof(string));
            tblNeed.Columns.Add(dc1);
            tblNeed.Columns.Add(dc2);
            tblNeed.Columns.Add(dc3);

            tblCountQueue = sqlQTCrawler.GetTblData(@"select top 1000 count(*) AS CountVisited, Company AS CompanyID
	                                                  from VisitedLinks
                                                      group by [Company]
	                                                  order by count(*) desc");
            foreach (DataRow RowInfo in tblCountQueue.Rows)
            {
                int CountQueue = QT.Entities.Common.Obj2Int(RowInfo["CountVisited"]);
                long CompanyID = QT.Entities.Common.Obj2Int64(RowInfo["CompanyID"]);
                tblCompany = sqlQT2.GetTblData("select * from Company where ID = @CompanyID",CommandType.Text,new System.Data.SqlClient.SqlParameter[]{
                    sqlQT2.CreateParamteter("@CompanyID",CompanyID,SqlDbType.BigInt)
                });
                DataRow dr = tblNeed.NewRow();
                dr["CompanyID"] = CompanyID;
                dr["VisitedCount"] = CountQueue;
                dr["Domain"] = tblCompany.Rows[0]["Domain"].ToString();

                tblNeed.Rows.Add(dr);
            }
            gridControl1.DataSource = tblNeed;
            gridControl1.ExportToXlsx(@"C:\Users\Manh\Desktop\TopVisited.xlsx");
        }
    }
}
