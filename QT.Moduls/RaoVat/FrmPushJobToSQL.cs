using QT.Entities;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.RaoVat
{
    public partial class FrmPushJobToSQL : Form
    {
        private Thread thread;
        public FrmPushJobToSQL()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            QT.Entities.RaoVat.ETypeCrawlRaoVat status = Entities.RaoVat.ETypeCrawlRaoVat.None;
            Enum.TryParse<QT.Entities.RaoVat.ETypeCrawlRaoVat>(cbStatus.SelectedValue.ToString(), out status);
            thread = new Thread(() =>
                {
                    while (true)
                    {
                        try
                        {
                            PushData(status);
                        }
                        catch (ThreadAbortException ex1)
                        {
                            break;
                        }
                        catch (Exception ex2)
                        {
                            WriteLog(string.Format("Exception when push:{0}", ex2.Message));
                        }
                        Thread.Sleep(10000);
                    }
                });
            thread.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopThreadRun();
        }

        private void StopThreadRun()
        {
            if (thread != null && thread.IsAlive) thread.Abort();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QT.Entities.RaoVat.ETypeCrawlRaoVat status = Entities.RaoVat.ETypeCrawlRaoVat.None;
            Enum.TryParse<QT.Entities.RaoVat.ETypeCrawlRaoVat>(cbStatus.SelectedValue.ToString(), out status);

            PushData(status);
        }

        private void PushData(QT.Entities.RaoVat.ETypeCrawlRaoVat typeCrawler)
        {
            var sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);
            DataTable tblConfigNeedPush = this.gridControl1.DataSource as DataTable;
            foreach (DataRow itemRow in tblConfigNeedPush.Rows)
            {
                int ConfigID = Convert.ToInt32(itemRow["Id"]);
                DataTable checkExistInQueueWait = sqlDb.GetTblData(
                        @"SELECT TOP 1 * FROM QueueWait 
                          WHERE ConfigID = @ConfigID And TypeCrawler = @TypeCrawler"
                        , CommandType.Text, new SqlParameter[]{
                            SqlDb.CreateParamteterSQL("ConfigID",ConfigID,SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("TypeCrawler",typeCrawler,SqlDbType.Int)
                        });
                if (checkExistInQueueWait.Rows.Count == 0)
                {

                    //Delelete all visited link
                    sqlDb.RunQuery("delete from VisitedPage where ConfigId = @ConfigID and TypeCrawler = @TypeCrawler",
                        CommandType.Text, new SqlParameter[]{
                                  SqlDb.CreateParamteterSQL("@ConfigID",ConfigID,SqlDbType.Int),
                                  SqlDb.CreateParamteterSQL("@TypeCrawler",1,SqlDbType.Int)
                            });

                    //PushJob.
                    string url = itemRow["rootLink"].ToString();
                    List<string> arUrl = Common.GetListXPathFromString(url);

                    foreach (var iUrl in arUrl)
                    {
                        try
                        {
                            List<string> lstUrl = new List<string>();
                            
                            //Phân tích Url con từ Url Mẫu.
                            if (iUrl.Contains(@"!!!!!"))
                            {
                                lstUrl.Add(iUrl.Replace("!!!!!", "1"));
                                lstUrl.Add(iUrl.Replace("!!!!!", "2"));
                                lstUrl.Add(iUrl.Replace("!!!!!", "3"));
                                lstUrl.Add(iUrl.Replace("!!!!!", "4"));
                            }
                            else
                            {
                                lstUrl.Add(iUrl);
                            }

                            foreach (string str in lstUrl)
                            {
                                sqlDb.RunQuery(@"Insert into QueueWait (ConfigID, TypeCrawler, CrcUrl, Url, Deep) values 
                                     (@ConfigID, @TypeCrawler, @CrcUrl, @Url, 0)", CommandType.Text, new SqlParameter[]
                                {
                                    SqlDb.CreateParamteterSQL("@ConfigID",ConfigID,SqlDbType.Int),
                                    SqlDb.CreateParamteterSQL("@TypeCrawler",Convert.ToInt32(typeCrawler),SqlDbType.Int),
                                    SqlDb.CreateParamteterSQL("@CrcUrl",Math.Abs(GABIZ.Base.Tools.getCRC32(Common.CompactUrl(str)))
                                                                       ,SqlDbType.Int),
                                    SqlDb.CreateParamteterSQL("@Url",str,SqlDbType.NVarChar)
                                });
                                WriteLog(string.Format("Pushed url:{0}", str));
                            }
                        }
                        catch (Exception ex)
                        {
                            WriteLog(ex.Message);
                        }
                    }
                }
                else
                {
                    WriteLog("Wait next");
                }
            }
        }

        private void WriteLog(string p)
        {
            this.Invoke(new Action(() =>
                {
                    if (logPushTextBox.TextLength > 10000000) this.logPushTextBox.Clear();
                    else logPushTextBox.AppendText(string.Format("\n At:{0}.{1}", DateTime.Now.ToString("HH-mm-ss"), p));
                }));
        }

        internal void LoadOutData(DataTable tbl)
        {
            this.gridControl1.DataSource = tbl;
            this.gridView1.RefreshData();
        }

        private void FrmPushJobToSQL_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopThreadRun();
        }

        private void FrmPushJobToSQL_Load(object sender, EventArgs e)
        {
            cbStatus.DataSource = Enum.GetValues(typeof(QT.Entities.RaoVat.ETypeCrawlRaoVat));
        }
    }
}
