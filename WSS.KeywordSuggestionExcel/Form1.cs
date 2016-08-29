using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeywordSuggestionExcel
{
    public partial class Form1 : Form
    {
        SqlDb sqldb = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        SqlDb sqldbKey = new SqlDb("Data Source=183.91.14.82;Initial Catalog=News;Persist Security Info=True;User ID=wss_news;Password=@F4sJ=l9/ryJt9MT");
        DataTable tblKeywordSearch = null;
        OleDbConnection oledbConn;
        string Keyword = "";
        string keywordParent = "";
        long KeywordParenID = 0;
        int m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12,current_00;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread Start = new Thread(() => Analysic());
            Start.Start();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void Analysic()
        {
            try
            {
                string PathFolder = ConfigurationManager.AppSettings["File"];

                string[] Files = Directory.GetFiles(PathFolder, "*.xls");

                foreach (string file in Files)
                {
                    tblKeywordSearch = ReadDataFromExcelFile(file);
                    //gridControl1.DataSource = tblKeywordSearch;
                    foreach (DataRow KeywordInfo in tblKeywordSearch.Rows)
                    {
                        keywordParent = QT.Entities.Common.Obj2String(tblKeywordSearch.Rows[0]["Keywords"]);
                        KeywordParenID = GABIZ.Base.Tools.getCRC64(keywordParent);
                        if (!string.IsNullOrEmpty(KeywordInfo["Search Volume"].ToString()))
                        {
                            Keyword = KeywordInfo["Keywords"].ToString();
                            int Id = GABIZ.Base.Tools.getCRC32(Keyword);
                            current_00 = QT.Entities.Common.Obj2Int(KeywordInfo["Search Volume"]);
                            m1 = QT.Entities.Common.Obj2Int(KeywordInfo["Search Volume (m1)"]);
                            m2 = QT.Entities.Common.Obj2Int(KeywordInfo["Search Volume (m2)"]);
                            m3 = QT.Entities.Common.Obj2Int(KeywordInfo["Search Volume (m3)"]);
                            m4 = QT.Entities.Common.Obj2Int(KeywordInfo["Search Volume (m4)"]);
                            m5 = QT.Entities.Common.Obj2Int(KeywordInfo["Search Volume (m5)"]);
                            m6 = QT.Entities.Common.Obj2Int(KeywordInfo["Search Volume (m6)"]);
                            m7 = QT.Entities.Common.Obj2Int(KeywordInfo["Search Volume (m7)"]);
                            m8 = QT.Entities.Common.Obj2Int(KeywordInfo["Search Volume (m8)"]);
                            m9 = QT.Entities.Common.Obj2Int(KeywordInfo["Search Volume (m9)"]);
                            m10 = QT.Entities.Common.Obj2Int(KeywordInfo["Search Volume (m10)"]);
                            m11 = QT.Entities.Common.Obj2Int(KeywordInfo["Search Volume (m11)"]);
                            m12 = QT.Entities.Common.Obj2Int(KeywordInfo["Search Volume (m12)"]);
                            SaveKeywordInfo(Keyword, current_00, Id, m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12);
                            SaveTrackingKeywordCatExtra(Keyword, KeywordParenID, current_00);
                        }
                    }
                    File.Delete(file);
                    this.Invoke(new Action(() =>
                    {
                        try
                        {
                            richTextBox1.AppendText(string.Format("{0}\n", Keyword));
                        }
                        catch (Exception ex01)
                        {
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                  {
                      richTextBox1.AppendText(ex.Message);
                  }));
            }
        }

        private void SaveTrackingKeywordCatExtra(string Keyword, long KeywordParentId,int Volume)
        {
            try
            {
                sqldbKey.RunQuery("insert into Tracking_Keyword_Cat_Extra (Keyword,KeywordParentID,Volume) values (@Keyword,@KeywordParentID,@Volume)", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { 
                sqldbKey.CreateParamteter("@Keyword",Keyword,SqlDbType.NVarChar),
                sqldbKey.CreateParamteter("@KeywordParentID",KeywordParentId,SqlDbType.BigInt),
                sqldbKey.CreateParamteter("@Volume",Volume,SqlDbType.Int)
            });
            }
            catch(Exception ex)
            {
 
            }
        }

        private void SaveKeywordInfo(string Keyword,int current_00, int Id, int m1, int m2,int m3,int m4,int m5,int m6,int m7,int m8,int m9,int m10,int m11,int m12)
        {
            try
            {
                string monthCurrent = "current_" + DateTime.Now.Month.ToString("D2");
                sqldbKey.RunQuery(string.Format(@"insert into Keyword_VolumeHistory (Id,Keyword,{0},month_01,month_02,month_03,month_04,month_05,month_06,month_07,month_08,month_09,month_10,month_11,month_12) 
                                                                        values (@Id,@Keyword,@current_00,@m1,@m2,@m3,@m4,@m5,@m6,@m7,@m8,@m9,@m10,@m11,@m12)", monthCurrent)
                    , CommandType.Text, new System.Data.SqlClient.SqlParameter[] { 
                                                                                                                                                sqldbKey.CreateParamteter("@Id",Id,SqlDbType.Int),
                                                                                                                                                sqldbKey.CreateParamteter("@Keyword",Keyword,SqlDbType.NVarChar),
                                                                                                                                                sqldbKey.CreateParamteter("@current_00",current_00,SqlDbType.NVarChar),
                                                                                                                                                sqldbKey.CreateParamteter("@m1",m1,SqlDbType.Int),
                                                                                                                                                sqldbKey.CreateParamteter("@m2",m2,SqlDbType.Int),
                                                                                                                                                sqldbKey.CreateParamteter("@m3",m3,SqlDbType.Int),
                                                                                                                                                sqldbKey.CreateParamteter("@m4",m4,SqlDbType.Int),
                                                                                                                                                sqldbKey.CreateParamteter("@m5",m5,SqlDbType.Int),
                                                                                                                                                sqldbKey.CreateParamteter("@m6",m6,SqlDbType.Int),
                                                                                                                                                sqldbKey.CreateParamteter("@m7",m7,SqlDbType.Int),
                                                                                                                                                sqldbKey.CreateParamteter("@m8",m8,SqlDbType.Int),
                                                                                                                                                sqldbKey.CreateParamteter("@m9",m9,SqlDbType.Int),
                                                                                                                                                sqldbKey.CreateParamteter("@m10",m10,SqlDbType.Int),
                                                                                                                                                sqldbKey.CreateParamteter("@m11",m11,SqlDbType.Int),
                                                                                                                                                sqldbKey.CreateParamteter("@m12",m12,SqlDbType.Int)
                                                                                                                                             });
            }
            catch (Exception ex01)
            {

            }
            
        }




        private DataTable ReadDataFromExcelFile(string path)
        {
            //string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path.Trim() + ";Extended Properties=Excel 8.0";
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path.Trim();
            // Tạo đối tượng kết nối
            OleDbConnection oledbConn = new OleDbConnection(connectionString);
            DataTable data = null;
            try
            {
                // Mở kết nối
                oledbConn.Open();

                // Tạo đối tượng OleDBCommand và query data từ sheet có tên "Keywords"
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Keywords$]", oledbConn);

                // Tạo đối tượng OleDbDataAdapter để thực thi việc query lấy dữ liệu từ tập tin excel
                OleDbDataAdapter oleda = new OleDbDataAdapter();

                oleda.SelectCommand = cmd;

                // Tạo đối tượng DataSet để hứng dữ liệu từ tập tin excel
                DataSet ds = new DataSet();

                // Đổ đữ liệu từ tập excel vào DataSet
                oleda.Fill(ds);

                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Đóng chuỗi kết nối
                oledbConn.Close();
            }
            return data;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Thread Start = new Thread(() => Analysic());
            //Start.Start();
        }

        
    }
}
