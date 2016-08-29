using QT.Entities.Data;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Drivers.RabbitMQ;

namespace QT.Moduls.KeywordSuggest
{


    public partial class FrmKeywordControl : Form
    {
        SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
        public FrmKeywordControl()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = sqldb.GetTblData(@"SELECT TOP 100000 [Id]
                              ,[Keyword]
                              ,[Volume]
                              ,[LastUpdateVolume]
                              ,[Success], KeywordSource
                          FROM [Keyword_Volume]", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                          });
        }

        private void btnImportKeyword_Click(object sender, EventArgs e)
        {
            FrmImportKeywordSuggest frm = new FrmImportKeywordSuggest();
            frm.ShowDialog();
        }

        private void btnNumberMss_Click(object sender, EventArgs e)
        {
            try
            {
                RabbitMQServer rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQKeywordSuggest");
                IModel model = rabbitMQServer.CreateChannel();
                QueueDeclareOk result = model.QueueDeclare("UpdateKeywordBatch.FindSuggest", true, false, false, null);
                uint count = result.MessageCount;
                rabbitMQServer.CloseChannel(model);
                MessageBox.Show(count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDeleteKeywordFinded_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa keyword đã tìm được?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                sqldb.RunQuery("  delete   FROM [Keyword_Volume]", CommandType.Text, null);
                MessageBox.Show("Deleted!");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmPushTopKeyword frm = new FrmPushTopKeyword();
            frm.ShowDialog();
        }
    }
}
