using QT.Moduls;
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
using WSS.QAComment.Core;
using WSS.QAComment.Core.DsConfigurationCommentTableAdapters;

namespace WSS.Comment.Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string strTextSearch = txtSearch.Text;
                using (
                    var db =new WSS.QAComment.Core.DsConfigurationCommentTableAdapters.Configuration_CommentTableAdapter())
                {
                    DsConfigurationComment.Configuration_CommentDataTable tblConfigurationCommentDataTable =
                        new DsConfigurationComment.Configuration_CommentDataTable();
                    db.FillSelectByDomain(tblConfigurationCommentDataTable, strTextSearch);
                    gridControl1.DataSource = tblConfigurationCommentDataTable;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {SaveData();
        }

        private void SaveData()
        {
            try
            {
                using (var db = new Configuration_CommentTableAdapter())
                {

                    var tblConfigurationCommentDataTable =
                        gridControl1.DataSource as DsConfigurationComment.Configuration_CommentDataTable;
                    var changeRow = tblConfigurationCommentDataTable.GetChanges();
                    if (changeRow != null)
                    {
                        foreach (DataRow VARIABLE in changeRow.Rows)
                        {
                            DsConfigurationComment.Configuration_CommentRow row =
                                VARIABLE as DsConfigurationComment.Configuration_CommentRow;
                            db.prc_Configuration_Commment_Upsert(row.CompanyId, row.CommentListXpath, row.AuthorXPath,
                                row.ContentXPath, row.ScoreXPath, row.DatePostXPath,"" );
                        }

                    }
                }
                MessageBox.Show("Saved!");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message+exp.StackTrace);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveData();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pushReAnalysicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long companyId = Convert.ToInt64(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CompanyId"));
            NoSqlCommentSystem noSqlCommentSystem = NoSqlCommentSystem.Instance();
            var lstJOb = noSqlCommentSystem.GetAllJobBySite(companyId);
            ProducerBasic producerBasicPushAS = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(Config.RabbitMQServerComment), Config.QueueWaitAsComment);
            foreach (var VARIABLE in lstJOb)
            {
                producerBasicPushAS.Publish(new JobWaitAS()
                {
                    CompanyId = companyId,
                    Id = VARIABLE.Item1,
                    Url = VARIABLE.Item2,
                }.ToObjMQ());
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.gridControl1,new Point(e.X,e.Y));
            }
        }

        private void pushSqlReAnalysicToolStripMenuItem_Click(object sender, EventArgs e)
         {
            long companyId = Convert.ToInt64(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CompanyId"));
            SqlCommentAdapter noSqlCommentSystem = SqlCommentAdapter.Instance();
            var lstJOb = noSqlCommentSystem.GetListUrlOfSite(companyId);
            ProducerBasic producerBasicPushAS = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(Config.RabbitMQServerComment), Config.QueueWaitAsComment);
            foreach (var VARIABLE in lstJOb)
            {
                producerBasicPushAS.Publish(new JobWaitAS()
                {
                    CompanyId = companyId,
                    Id = VARIABLE.Item1,
                    Url = VARIABLE.Item2,
                }.ToObjMQ());}
        }
    }
}