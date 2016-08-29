using QT.Entities.Data;
using QT.Moduls.Company;
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
    public partial class FrmCheckConfigError : Form
    {
        private DataTable tblReport = null;
        private SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
        private long CompanyID = 0;
        private bool valForm = false;
        public FrmCheckConfigError()
        {
            InitializeComponent();
            repositoryItemHyperLinkEditFix.Click += repositoryItemHyperLinkEditFix_Click;
        }

        void repositoryItemHyperLinkEditFix_Click(object sender, EventArgs e)
        {
            CompanyID = QT.Entities.Common.Obj2Int64((this.gridView1.GetRow(this.gridView1.FocusedRowHandle) as DataRowView)["ID"]);
            sqldb.RunQuery("update Company_Check_Config set LastRepairConfig = GETDATE() where CompanyID = @CompanyID", CommandType.Text, new SqlParameter[]{
                sqldb.CreateParamteter("@CompanyID",CompanyID,SqlDbType.BigInt)
            });
            FrmCheckConfigError_Load(null, null);
        }

        private void FrmCheckConfigError_Load(object sender, EventArgs e)
        {
            tblReport = sqldb.GetTblData("prc_Report_Company_Config_Error", CommandType.StoredProcedure, new SqlParameter[] { });
            grcListError.DataSource = tblReport;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FrmCheckConfigError_Load(null, null);
        }

        private void grcListError_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
