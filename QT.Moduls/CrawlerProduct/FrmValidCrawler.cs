using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmValidCrawler : Form
    {
        SqlDb sqldb = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        DataTable tblCompany = null;
        DataTable tblProduct = null;
        DataTable tblValid = null;
        DataTable tblNotValid = null;
        public FrmValidCrawler()
        {
            InitializeComponent();
        }

        private void btnValidCount_Click(object sender, EventArgs e)
        {
            tblValid = sqldb.GetTblData("select count(*) as Count from Product where Company = @Company and Valid = 1", CommandType.Text, new SqlParameter[] { 
                sqldb.CreateParamteter("@Company",QT.Entities.Common.Obj2Int64(txtCompany.Text),SqlDbType.BigInt)
            });
            lblValid.Text = QT.Entities.Common.Obj2String(tblValid.Rows[0]["Count"]);
        }
        private void btnAllValidCount_Click(object sender, EventArgs e)
        {
            int ValidCount = 0;
            int NoValidCount = 0;
            tblCompany = sqldb.GetTblData(@"select a.ID
                                            from Company a
                                            inner join Configuration b on a.id = b.CompanyID
                                            where a.WaitCrawlerReload=1
                                            and Status=1
                                            and DataFeedType=0
                                            and a.ID <> 4911617055178498758", CommandType.Text, new SqlParameter[] { });

            foreach (DataRow rowInfo in tblCompany.Rows)
            {
                ValidCount += CrawlerValid(QT.Entities.Common.Obj2Int64(rowInfo["ID"]));
                NoValidCount += CrawlerNotValid(QT.Entities.Common.Obj2Int64(rowInfo["ID"]));
            }

            lblValid.Text = ValidCount.ToString();
            lblNotValid.Text = NoValidCount.ToString();
        }
        public int CrawlerValid(long Company)
        {
            int ValidCount = 0;
            tblValid = sqldb.GetTblData("select count(*) as Count from Product where Company = @Company and Valid = 1", CommandType.Text, new SqlParameter[] { 
                sqldb.CreateParamteter("@Company",Company,SqlDbType.BigInt)
            });
            ValidCount = QT.Entities.Common.Obj2Int(tblValid.Rows[0]["Count"]);
            return ValidCount;
        }
        public int CrawlerNotValid(long Company)
        {
            int NotValidCount = 0;
            tblValid = sqldb.GetTblData("select count(*) as Count from Product where Company = @Company and Valid = 0", CommandType.Text, new SqlParameter[] { 
                sqldb.CreateParamteter("@Company",Company,SqlDbType.BigInt)
            });
            NotValidCount = QT.Entities.Common.Obj2Int(tblValid.Rows[0]["Count"]);
            return NotValidCount;
        }

    }
}
