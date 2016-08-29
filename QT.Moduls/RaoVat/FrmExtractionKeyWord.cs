using MongoDB.Bson;
using MongoDB.Driver;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlSale
{
    public partial class FrmExtractionKeyWord : Form
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmExtractionKeyWord));
        private bool IsStop;

        public FrmExtractionKeyWord()
        {
            InitializeComponent();
        }

        Thread thread = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = this.txtQuery.Text;
                string update = this.txtUpdate.Text;
                int limit = Convert.ToInt32(spinEdit2.Value);
                int iDB = cboDB.SelectedIndex;
                string field = txtField.Text;
                string fieldIncreate = txtIncreateMent.Text;
                int iCreateMent = Convert.ToInt32(spinIncr.Value);

                thread = new Thread(() => MethodExtractKeyWordToMongo(query, update, field
                    , limit, iDB, fieldIncreate, iCreateMent ));
                    thread.Start();

                this.btnStart.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Phân tích từ khóa.
        /// </summary>
        /// <param name="queryFind"></param>
        /// <param name="queryUpdate"></param>
        /// <param name="field"></param>
        /// <param name="limit"></param>
        /// <param name="iDB"></param>
        private void MethodExtractKeyWord(string queryFind, string queryUpdate
            , string field, int limit
            , int iDB, string increateField)
        {
            while (true)
            {
                try
                {
                    SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
                    MongoDbRaoVat mongoDb = new MongoDbRaoVat();
                    foreach (var item in mongoDb.GetListExtractKeyWord(queryFind, limit, iDB).Result)
                    {
                        if (item.Contains(field))
                        {
                            string content = item[field].AsString;
                            content = QT.Entities.Common.RemoveSpecialCharacter(content).ToLower();

                            IEnumerable<string> ieKeyWord3 = GABIZ.Base.Tools.NGramDocument(3, content);
                            IEnumerable<string> iekeyword2 = GABIZ.Base.Tools.NGramDocument(2, content);
                            IEnumerable<string> ieKeyWord1 = GABIZ.Base.Tools.NGramDocument(1, content);

                            List<string> ieKeyWord = new List<string>();
                            ieKeyWord.AddRange(ieKeyWord1);
                            ieKeyWord.AddRange(iekeyword2);
                            ieKeyWord.AddRange(ieKeyWord3);

                            foreach (var itemKeyWord1 in ieKeyWord)
                            {
                                string itemKeywords = itemKeyWord1.ToString();
                                long crc = Math.Abs(GABIZ.Base.Tools.getCRC64(itemKeywords));
                                if (sqldb.GetTblData("SElECT ID FROM AnalysicKeyWord WHERE id = @id"
                                    , CommandType.Text, new SqlParameter[]{
                            sqldb.CreateParamteter("@id",crc,SqlDbType.BigInt)
                            }).Rows.Count == 0)
                                {
                                    sqldb.RunQuery("Insert into AnalysicKeyWord (id, keyword, count, pushtomongo) values (@id, @keyword, @count, 0)",
                                        CommandType.Text,
                                        new SqlParameter[]{
                                    sqldb.CreateParamteter("id",crc,SqlDbType.BigInt),
                                    sqldb.CreateParamteter("keyword",itemKeywords,SqlDbType.NVarChar),
                                    sqldb.CreateParamteter("count",0,SqlDbType.Int)
                                });
                                }
                                else
                                {
                                    sqldb.RunQuery("update  AnalysicKeyWord set keyword=@keyword, count=count+1 where id = @id",
                                      CommandType.Text,
                                      new SqlParameter[]{
                                    sqldb.CreateParamteter("id",crc,SqlDbType.BigInt),
                                    sqldb.CreateParamteter("keyword",itemKeywords,SqlDbType.NVarChar),
                                    sqldb.CreateParamteter("count",0,SqlDbType.Int)
                                });
                                }

                                mongoDb.UpdateLoadKeyWord(item["_id"].AsObjectId, queryUpdate, iDB);
                                WriteLog(string.Format("Extract {0} keyword from item: {1}", itemKeywords, item["id"].AsInt64.ToString()));
                            }
                        }
                    }
                }
                catch (ThreadAbortException ex)
                {
                    break;
                    //Dung luong tu ngoai.
                }
                catch (Exception ex1)
                {
                    log.ErrorFormat(ex1.Message);
                }
            }
        }


        private void MethodExtractKeyWordToMongo(string queryFind, string queryUpdate
            , string field
            , int limit
            , int iDB
            , string increateField
            , int iIncr)
        {
            while (true)
            {
                try
                {
                    SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
                    MongoDbRaoVat mongoDb = new MongoDbRaoVat();
                    foreach (var item in mongoDb.GetListExtractKeyWord(queryFind, limit, iDB).Result)
                    {
                        if (item.Contains(field))
                        {
                            string content = item[field].AsString;
                            content = QT.Entities.Common.RemoveSpecialCharacter(content).ToLower();

                            IEnumerable<string> ieKeyWord3 = GABIZ.Base.Tools.NGramDocument(3, content);
                            IEnumerable<string> iekeyword2 = GABIZ.Base.Tools.NGramDocument(2, content);
                            IEnumerable<string> ieKeyWord1 = GABIZ.Base.Tools.NGramDocument(1, content);

                            List<string> ieKeyWord = new List<string>();
                            ieKeyWord.AddRange(ieKeyWord1);
                            ieKeyWord.AddRange(iekeyword2);
                            ieKeyWord.AddRange(ieKeyWord3);

                            foreach (var itemKeyWord1 in ieKeyWord)
                            {
                                string itemKeywords = itemKeyWord1.ToString();
                                long crc = Math.Abs(GABIZ.Base.Tools.getCRC64(itemKeywords));
                                mongoDb.UpdateKeyWord(""
                                    , crc
                                    , itemKeyWord1
                                    , QT.Entities.Common.GetSplug(itemKeyWord1)
                                    , ""
                                    , item["category_ids"].AsBsonArray
                                    , increateField
                                    , iIncr, false);
                                WriteLog(string.Format("Extract {0} keyword from item: {1}", itemKeywords, item["id"].AsInt64.ToString()));
                            }

                             mongoDb.UpdateLoadKeyWord(item["_id"].AsObjectId, queryUpdate, iDB);

                        }

                        Thread.Sleep(1000);
                    }
                }
                catch (ThreadAbortException ex)
                {
                    break;
                    //Dung luong tu ngoai.
                }
                catch (Exception ex1)
                {
                    log.ErrorFormat(ex1.Message);
                }
            }
        }

        private void KeyWordFromContent(object obj)
        {

            //while (true)
            //{
            //    try
            //    {
            //        SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
            //        MongoDbAdapter mongoDb = new MongoDbAdapter();
            //        foreach (var item in mongoDb.GetListExtractKeyWord().Result)
            //        {
            //            string content = item["content"].AsString;
            //            content = QT.Entities.Common.RemoveSpecialCharacter(content).ToLower();

            //            IEnumerable<string> ieKeyWord3 = GABIZ.Base.Tools.NGramDocument(3, content);
            //            IEnumerable<string> iekeyword2 = GABIZ.Base.Tools.NGramDocument(2, content);
            //            List<string> ieKeyWord = new List<string>();
            //            ieKeyWord.AddRange(iekeyword2);
            //            ieKeyWord.AddRange(ieKeyWord3);

            //            foreach (var itemKeyWord1 in ieKeyWord)
            //            {
            //                string itemKeywords = itemKeyWord1.ToString();
            //                long crc = Math.Abs(GABIZ.Base.Tools.getCRC64(itemKeywords));
            //                if (sqldb.GetTblData("SElECT ID FROM AnalysicKeyWord WHERE id = @id"
            //                    , CommandType.Text, new SqlParameter[]{
            //                sqldb.CreateParamteter("@id",crc,SqlDbType.BigInt)
            //                }).Rows.Count == 0)
            //                {
            //                    sqldb.RunQuery("Insert into AnalysicKeyWord (id, keyword, count) values (@id, @keyword, @count)",
            //                        CommandType.Text,
            //                        new SqlParameter[]{
            //                        sqldb.CreateParamteter("id",crc,SqlDbType.BigInt),
            //                        sqldb.CreateParamteter("keyword",itemKeywords,SqlDbType.NVarChar),
            //                        sqldb.CreateParamteter("count",0,SqlDbType.Int)
            //                    });
            //                }
            //                else
            //                {
            //                    sqldb.RunQuery("update  AnalysicKeyWord set keyword=@keyword, count=count+1 where id = @id",
            //                      CommandType.Text,
            //                      new SqlParameter[]{
            //                        sqldb.CreateParamteter("id",crc,SqlDbType.BigInt),
            //                        sqldb.CreateParamteter("keyword",itemKeywords,SqlDbType.NVarChar),
            //                        sqldb.CreateParamteter("count",0,SqlDbType.Int)
            //                    });
            //                }
            //                mongoDb.UpdateLoadKeyWord(item["_id"].AsObjectId);
            //                WriteLog(string.Format("Extract {0} keyword from item: {1}", itemKeywords, item["id"].AsInt64.ToString()));
            //            }
            //        }
            //    }
            //    catch (ThreadAbortException ex)
            //    {
            //        break;
            //        //Dung luong tu ngoai.
            //    }
            //    catch (Exception ex1)
            //    {
            //        log.ErrorFormat(ex1.Message);
            //    }
            //}


        }

        private void KeyWordFromTieuDe(object obj)
        {
            while (true)
            {
                try
                {
                    SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
                    MongoDbRaoVat mongoDb = new MongoDbRaoVat();
                    foreach (var item in mongoDb.GetListExtractKeyWordFromTitle().Result)
                    {
                        string content = item["name"].AsString;
                        content = QT.Entities.Common.RemoveSpecialCharacter(content).ToLower();

                        IEnumerable<string> ieKeyWord4 = GABIZ.Base.Tools.NGramDocument(4, content);
                        IEnumerable<string> ieKeyWord3 = GABIZ.Base.Tools.NGramDocument(3, content);
                        IEnumerable<string> iekeyword2 = GABIZ.Base.Tools.NGramDocument(2, content);
                        IEnumerable<string> ieKeyWord1 = GABIZ.Base.Tools.NGramDocument(1, content);

                        List<string> ieKeyWord = new List<string>();
                        ieKeyWord.AddRange(iekeyword2);
                        ieKeyWord.AddRange(ieKeyWord3);
                        ieKeyWord.AddRange(ieKeyWord4);
                        ieKeyWord.AddRange(ieKeyWord1);

                        foreach (var itemKeyWord1 in ieKeyWord)
                        {
                            string itemKeywords = itemKeyWord1.ToString();
                            long crc = Math.Abs(GABIZ.Base.Tools.getCRC64(itemKeywords));
                            if (sqldb.GetTblData("SElECT ID FROM AnalysicKeyWord WHERE id = @id"
                                , CommandType.Text, new SqlParameter[]{
                            sqldb.CreateParamteter("@id",crc,SqlDbType.BigInt)
                            }).Rows.Count == 0)
                            {
                                sqldb.RunQuery("Insert into AnalysicKeyWord (id, keyword, count, PushToMongo) values (@id, @keyword, @count, 0)",
                                    CommandType.Text,
                                    new SqlParameter[]{
                                    sqldb.CreateParamteter("id",crc,SqlDbType.BigInt),
                                    sqldb.CreateParamteter("keyword",itemKeywords,SqlDbType.NVarChar),
                                    sqldb.CreateParamteter("count",0,SqlDbType.Int)
                                });
                            }
                            else
                            {
                                sqldb.RunQuery("update  AnalysicKeyWord set keyword=@keyword, count=count+1 where id = @id",
                                  CommandType.Text,
                                  new SqlParameter[]{
                                    sqldb.CreateParamteter("id",crc,SqlDbType.BigInt),
                                    sqldb.CreateParamteter("keyword",itemKeywords,SqlDbType.NVarChar),
                                    sqldb.CreateParamteter("count",0,SqlDbType.Int)
                                });
                            }
                            mongoDb.UpdateLoadKeyWordOfProduct(item["_id"].AsObjectId);
                            WriteLog(string.Format("Extract {0} keyword from item: {1}", itemKeywords, item["id"].AsInt64.ToString()));
                        }
                    }
                }
                catch (ThreadAbortException ex)
                {
                    break;
                }
                catch (Exception ex1)
                {
                    log.ErrorFormat(ex1.Message);
                    WriteLog("Exception:" + ex1.Message);
                    Thread.Sleep(10000);
                }
            }
        }


        private void WriteLog(string p)
        {
            this.Invoke(new Action(() =>
                {
                    if (this.richTextBox1.TextLength > 100000) this.richTextBox1.Clear();
                    this.richTextBox1.AppendText("\n" + p);
                }));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có thật sự muốn xóa dữ liệu?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                MongoDbRaoVat mongoDb = new MongoDbRaoVat();
                mongoDb.SetAllhtmlToNoExtractkeyWord();
                mongoDb.SetAllProductNoExtractKeyWord();
                SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
                sqlDb.RunQuery("DEleTE FRoM AnalysicKeyWord", CommandType.Text, null);
                MessageBox.Show("OK");
            }
        }

        private void btnSqlToMongo_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => StartPushToMongo());
            thread.Start();
        }

        private void StartPushToMongo()
        {
            while (true)
            {
                SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
                MongoDbRaoVat mongoDb = new MongoDbRaoVat();

                //[count]>2 and [count]<30 and

                DataTable tbl = sqldb.GetTblData(@"SELECT TOP 10000 [Id]
      ,[KeyWord]
      ,[count]
      ,[PushToMongo]
  FROM [SaleNews].[dbo].[AnalysicKeyWord]
  where  PushToMongo=0", CommandType.Text,
                    new SqlParameter[] { });
                foreach (DataRow item in tbl.Rows)
                {
                    string keyword = item["keyword"].ToString();
                    long crc = Math.Abs(GABIZ.Base.Tools.getCRC64(keyword));
                    mongoDb.UpdateKeyWord("", crc, keyword, keyword, "", "");

                    sqldb.RunQuery("update AnalysicKeyWord set PushToMongo = 1 where id= @id", CommandType.Text, new SqlParameter[]{
                    sqldb.CreateParamteter("id",crc,SqlDbType.BigInt)
                });
                    WriteLog(string.Format("Pushed success:{0}", keyword));
                }
                Thread.Sleep(1000);
            }
        }

        private void FrmExtractionKeyWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.thread != null && this.thread.IsAlive == true)
            {
                this.thread.Abort();
            }
        }

        private void FrmExtractionKeyWord_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 1;
            this.cboDB.SelectedIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==1)
            {
                txtQuery.Text = @"{$or:[{'is_extract_keyword':{$exists:false}},{'is_extract_keyword':false}]}";
                txtUpdate.Text = @"{$set:{'is_extract_keyword':true}}";
                txtField.Text = "name";
                cboDB.SelectedIndex = 1;
            }
            else if (comboBox1.SelectedIndex==0)
            {
                txtQuery.Text = @"{$or:[{'is_extract_keyword':{$exists:false}},{'is_extract_keyword':false}]}";
                txtUpdate.Text = @"{$set:{'is_extract_keyword':true}}";
                txtField.Text = "content";
                cboDB.SelectedIndex = 0;
            }
        }

        private void cboDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

   
    }
}
