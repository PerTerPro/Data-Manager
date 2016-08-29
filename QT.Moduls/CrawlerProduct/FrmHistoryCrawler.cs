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
    public partial class FrmHistoryCrawler : Form
    {
        SqlDb _sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);

        public FrmHistoryCrawler()
        {
            InitializeComponent();
        }

        public void LoadData (long CompanyID)
        {
            this.grdData.DataSource = _sqlDb.GetTblData("[sp_Report_HistoryCrawlerByCompany]", CommandType.StoredProcedure, new System.Data.SqlClient.SqlParameter[]{
                SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)
            });
        }
    }
}
