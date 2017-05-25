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
using QT.Entities;
using Websosanh.Core.Drivers.RabbitMQ;
using Wss.Lib.RabbitMq;



namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmTrustedFollow : Form
    {
        SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
        DataTable tblCompanyTrusted = new DataTable();
        long CompanyID = 0;
        public FrmTrustedFollow()
        {
            InitializeComponent();
            repositoryItemCheckEditTrusted.Click += repositoryItemCheckEditTrusted_Click;
            repositoryItemCheckEditTrusted.EditValueChanged += repositoryItemCheckEditTrusted_EditValueChanged;
        }

        void repositoryItemCheckEditTrusted_EditValueChanged(object sender, EventArgs e)
        {
            CompanyID = QT.Entities.Common.Obj2Int64((this.gridView1.GetRow(this.gridView1.FocusedRowHandle) as DataRowView)["ID"]);
            bool check = QT.Entities.Common.Obj2Bool((this.gridView1.GetRow(this.gridView1.FocusedRowHandle) as DataRowView)["Trusted"]);
            if (check == true)
            {
                check = false;
                sqldb.RunQuery("Update Company Set Trusted = @Trusted where ID = @ID", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { 
                    SqlDb.CreateParamteterSQL("@Trusted",check,SqlDbType.Bit),
                    SqlDb.CreateParamteterSQL("@ID",CompanyID,SqlDbType.BigInt) 
                });
            }
            else
            {
                check = true;
                sqldb.RunQuery("Update Company Set Trusted = @Trusted where ID = @ID", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { 
                    SqlDb.CreateParamteterSQL("@Trusted",check,SqlDbType.Bit),
                    SqlDb.CreateParamteterSQL("@ID",CompanyID,SqlDbType.BigInt)
                });
            }
        }

        void repositoryItemCheckEditTrusted_Click(object sender, EventArgs e)
        {

        }

        private void FrmTrustedFollow_Load(object sender, EventArgs e)
        {
            tblCompanyTrusted = sqldb.GetTblData("Company_Trusted", CommandType.StoredProcedure, new System.Data.SqlClient.SqlParameter[] { });
            gridControlCompanyTrusted.DataSource = tblCompanyTrusted;
        }

        private void btnPushCompanyInfo_Reset_Click(object sender, EventArgs e)
        {
            long companyInfo = QT.Entities.Common.Obj2Int64((this.gridView1.GetRow(this.gridView1.FocusedRowHandle) as DataRowView)["ID"]);
            string Domain = QT.Entities.Common.Obj2String((this.gridView1.GetRow(this.gridView1.FocusedRowHandle) as DataRowView)["Domain"]);
            ProducerBasic producerBasic = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct), ConfigRun.QueueUpdateCompanyInfoToWeb);
            producerBasic.PublishString(companyInfo.ToString());
            MessageBox.Show(string.Format("Pushed company: {0}", Domain));
        }
    }
}
