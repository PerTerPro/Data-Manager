using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using MongoDB.Bson;
using QT.Entities;
using QT.Entities.RaoVat;
using QT.Entities.Data;
using QT.Entities.Data.SolrDb.SaleNews;
using QT.Entities.Model.SaleNews;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Moduls.RaoVat;
using System.Text.RegularExpressions;
using System.IO;

namespace QT.Moduls.CrawlSale
{
    public partial class FrmManagerKeyword : Form
    {
        MongoDbRaoVat monoDbAdapter = new MongoDbRaoVat();
        KeywordSolrDriver solrKeyword = null;
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmManagerProductSale));
        List<RegexCheckKeyword> lstRegexCheckKeyword = null;

        public FrmManagerKeyword()
        {
            InitializeComponent();
        }

        string GetFileName(string color)
        {

            if (color == null || color == string.Empty)

                return string.Empty;

            return color + ".jpg";

        }

        string ImageDir = @"Images\";

        Hashtable Images = new Hashtable();
        private int NumberItem;



        private void btnLoadData_Click(object sender, EventArgs e)
        {
            int numberFound = 0;
            List<KeywordSaleNew> lstProductSaleNew =
                solrKeyword.GetListKeywordByQuery(txtQuery.Text, Convert.ToInt32(spinNumberItem.Value), 0, 10000
                , out numberFound
                , Convert.ToInt32(spinNumberWord.Value));

            this.gridControl1.DataSource = lstProductSaleNew;
            this.lblNumPage.Text = Convert.ToInt32((double)numberFound / 1000).ToString();
        }

        private void btnRequest1000_Click(object sender, EventArgs e)
        {
            try
            {
                List<KeywordSaleNew> lstProductSaleNew = solrKeyword.GetListProductLast(Convert.ToInt32(spinNumberItem.Value));
                this.gridControl1.DataSource = lstProductSaleNew;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            SaveToBlackKeyword();
        }

        private void SaveToBlackKeyword()
        {
            List<string> lstDelItem = new List<string>();
            int iRowCount = this.gridView1.DataRowCount;
            for (int iRow = 0; iRow < iRowCount; iRow++)
            {
                try
                {
                    KeywordSaleNew productSalenew = this.gridView1.GetRow(iRow) as KeywordSaleNew;
                    if (productSalenew.is_selected) lstDelItem.Add(productSalenew._id);
                }
                catch (Exception ex)
                {
                    log.ErrorFormat(ex.Message);
                }
            }

            if (MessageBox.Show("Bạn có muốn lưu không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                Thread threadHideData = new Thread(() => SaveBlackKeyWord(lstDelItem));
                threadHideData.Start();
            }
        }

        private void SaveBlackKeyWord(List<string> lstDelItem)
        {
            MongoDbRaoVat mongoDb = new MongoDbRaoVat();
            try
            {
                //Xóa dữ liệu trên solr.
                this.solrKeyword.DelKeywordById(lstDelItem);
                WriteLog("DelInMogo", "");
                //Thay đổi status của mongoDb.
                for (int item = 0; item < lstDelItem.Count; item++)
                {
                    mongoDb.UpdateStatusOfKeyword(lstDelItem[item], 2);
                    WriteLog("MongoDb", string.Format("Item: {0}/{1}, Change status keyword {2} to 0 in mongo", item, lstDelItem.Count, lstDelItem[item]));
                }

                this.Invoke(new Action(() =>
                {
                    MessageBox.Show(string.Format("Saved del {0} keyword!", lstDelItem.Count));
                }));
            }
            catch (ThreadAbortException abortEx)
            {
                return;
            }
            catch (Exception ex)
            {
                log.ErrorFormat(ex.Message);
            }
        }

        private void SavePriorityKeyword(int newPriority)
        {
            if (MessageBox.Show("Bạn có muốn lưu khôn=g?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Vui lòng đợi hoàn thành");
                Thread threadHideData = new Thread(() =>
                {
                    MongoDbRaoVat mongoDb = new MongoDbRaoVat();
                    try
                    {
                        int iRowCount = this.gridView1.DataRowCount;
                        for (int iRow = 0; iRow < iRowCount; iRow++)
                        {
                            KeywordSaleNew keyword = this.gridView1.GetRow(iRow) as KeywordSaleNew;
                            if (keyword.is_selected)
                            {
                                //SaveMongoDb.
                                bool bOK = this.monoDbAdapter.UpdatePriorityKeyword(keyword._id, newPriority);
                                if (bOK == false)
                                {
                                    WriteLog("MongoUpdate", string.Format("Fail keyword:{0}", keyword.name));
                                }
                                else
                                {
                                    WriteLog("MongoUpdate", string.Format("Success keyword:{0}", keyword.name));
                                    //Sync item in mongo and solr.
                                    string Webdomain = "raovat";
                                    string URLSolrConnect = "http://183.91.14.85:8983/solr/keywords";
                                    var slr = SolrRaoVatKeywordDriver.GetDriver(SolrRaoVatKeywordDriver.GetInstance());

                                    BsonDocument document = mongoDb.GetKeyWordID(keyword._id).Result;
                                    if (document != null)
                                    {
                                        KeywordSaleNew keyword1 = mongoDb.ParseKeyWord(document);
                                        bool bOKSolr = slr.UpdateData(keyword1);
                                        if (!bOKSolr)
                                        {
                                            WriteLog("SolrUpdate", string.Format("Fail keyword:{0}", keyword1.name));
                                        }
                                    }
                                }
                            }



                        }
                        this.Invoke(new Action(() =>
                        {
                            MessageBox.Show("Saved priority keyword!");
                        }));
                    }
                    catch (Exception ex)
                    {
                        log.ErrorFormat(ex.Message);
                    }
                });
                threadHideData.Start();
                this.btnLoadData.PerformClick();
            }
        }

        private void ShowDataProgressBar(double value)
        {
            this.Invoke(new Action(() =>
            {
                this.progressBar1.Value = Convert.ToInt32(value);
            }));
        }

        private void WriteLog(string job, string log)
        {
            string mss = string.Format("\nAt:{0}. Job:{1}. Mss:{2}",
                DateTime.Now.ToString("HH:mm:ss"), job, log);
            this.Invoke(new Action(() =>
            {
                if (txtLog.TextLength > 1000000) txtLog.Clear();
                else txtLog.AppendText(mss);
            }));
        }

        private void FrmManagerProduct_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
                this.solrKeyword = KeywordSolrDriver.GetInstance();
                DataTable tbl = sqlDb.GetTblData("SELECT * FROM RegexFindKeyWord", CommandType.Text,
                    new SqlParameter[] { }, null);
                lstRegexCheckKeyword = new List<RegexCheckKeyword>();
                foreach (DataRow row in tbl.Rows)
                {
                    this.lstRegexCheckKeyword.Add(new RegexCheckKeyword()
                    {
                        Regex = row["RegexKeyword"].ToString(),
                        Vaid = Convert.ToBoolean(row["IsValid"])
                    });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {

        }

        private void btnVisible_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFindByName_Click(object sender, EventArgs e)
        {
            LoadKeywordByName(0);
        }

        private void LoadKeywordByName(int StartPage)
        {
            try
            {
                if (StartPage >= 0)
                {
                    this.NumberItem = 0;

                    List<KeywordSaleNew> lstProductSaleNew = solrKeyword.GetListKeywordByQuery(
                        string.Format("name:*{0}*", txtNameItem.Text), Convert.ToInt32(spinNumberItem.Value), StartPage * 1000, 0, out this.NumberItem
                        , Convert.ToInt32(spinNumberWord.Value)
                        , Convert.ToInt32(spinPriority.Value)
                        , Convert.ToInt32(spinPriorityTo.Value));

                    this.gridControl1.DataSource = lstProductSaleNew;
                    this.lblNumPage.Text = @"/" + Convert.ToInt32(NumberItem / 1000).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int[] iRowCount = this.gridView1.GetSelectedRows();
            foreach (int iRow in iRowCount)
            {
                var itemKeyword = this.gridView1.GetRow(iRow) as KeywordSaleNew;
                itemKeyword.is_selected = true;
            }
            this.gridView1.RefreshData();
        }

        private void btnUncheck_Click(object sender, EventArgs e)
        {
            int[] iRowCount = this.gridView1.GetSelectedRows();
            foreach (int iRow in iRowCount)
            {
                var itemKeyword = this.gridView1.GetRow(iRow) as KeywordSaleNew;
                itemKeyword.is_selected = false;
            }
            this.gridView1.RefreshData();
        }

        private void txtNameItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadKeywordByName(0);
            }

        }

        private void FrmManagerKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                txtNameItem.Focus();
                txtNameItem.SelectAll();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                SaveToBlackKeyword();
            }
        }

        private void btnAutoFind_Click(object sender, EventArgs e)
        {
            int iRowCount = this.gridView1.DataRowCount;
            for (int iRow = 0; iRow < iRowCount; iRow++)
            {
                this.ShowDataProgressBar(((double)iRow / (double)iRowCount) * (double)100);

                KeywordSaleNew keywordsalenew = this.gridView1.GetRow(iRow) as KeywordSaleNew;
                long crc = Math.Abs(GABIZ.Base.Tools.getCRC64(keywordsalenew.name));
                if (keywordsalenew.is_selected == false)
                {
                    if (!Common.ValidKeyword(keywordsalenew.name))
                    {
                        keywordsalenew.is_selected = true;
                    }
                    else if (!Common.ValidKeyWordGrammar(keywordsalenew.name, this.lstRegexCheckKeyword, true))
                    {
                        keywordsalenew.is_selected = true;
                    }
                    else if (this.monoDbAdapter.CheckBlackLink(keywordsalenew._id))
                    {
                        keywordsalenew.is_selected = true;
                    }
                }
            }
            this.gridView1.RefreshData();
        }

        private void btnRegexKeyword_Click(object sender, EventArgs e)
        {
            FrmRegexKeyword frm = new FrmRegexKeyword();
            frm.ShowDialog();
        }

        private void FrmManagerKeyword_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void spinEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int iRowCount = this.gridView1.RowCount;
                for (int iRowSelected = 0; iRowSelected < iRowCount; iRowSelected++)
                {
                    KeywordSaleNew keyword = this.gridView1.GetRow(iRowSelected) as KeywordSaleNew;
                    if (keyword.is_selected)
                    {
                        keyword.priority = Convert.ToInt32(spinEditPriority.Value);
                    }
                }
                this.gridView1.RefreshData();
            }
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            int priority = Convert.ToInt32(spinEditPriority.Value);
            SavePriorityKeyword(priority);
        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void exportExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Del in solr?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                this.solrKeyword.DeleteByQuery(txtQueryInSolr.Text);
                MessageBox.Show("Saved!");
            }
        }

        private void btnSoftCommitSolr_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                try
                {
                    this.solrKeyword.SoftCommit();
                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show("SoftCommitOK!");
                    }));
                }
                catch (ThreadAbortException ex)
                {
                    return;
                }
                catch (Exception ex)
                {
                    WriteLog("Exception:", ex.Message);
                }
            });
            thread.Start();
        }

        private void txtNameItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int iCurrent = Convert.ToInt32(spinCurrentPage.Value);
            spinCurrentPage.Value = iCurrent + 1;
            LoadKeywordByName(iCurrent);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            int iCurrent = Convert.ToInt32(spinCurrentPage.Value);
            spinCurrentPage.Value = iCurrent - 1;
            LoadKeywordByName(iCurrent);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            LoadKeywordByName(0);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                try
                {
                    this.solrKeyword.SoftCommit();
                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show("HardCommit Success!");
                    }));
                }
                catch (ThreadAbortException ex)
                {
                    return;
                }
                catch (Exception ex)
                {
                    WriteLog("Exception:", ex.Message);
                }
            });
            thread.Start();
        }

        private void txtRegex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<KeywordSaleNew> lst = this.gridControl1.DataSource as List<KeywordSaleNew>;
                foreach (var item in lst)
                {
                    string nameKeyword = item.name;
                    if (Regex.IsMatch(nameKeyword, txtRegex.Text))
                    {
                        item.is_selected = true;
                    }
                }
            }
            this.gridView1.RefreshData();
        }

        private void txtRegex_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckByRegex_Click(object sender, EventArgs e)
        {
            ProductSaleNewAdapter productSaleNewAdapter = new ProductSaleNewAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            List<string> lstRegex = productSaleNewAdapter.GetListBlackRegexKeyWord();
            foreach (string regex in lstRegex)
            {
                List<KeywordSaleNew> lst = this.gridControl1.DataSource as List<KeywordSaleNew>;
                foreach (var item in lst)
                {
                    string nameKeyword = item.name;
                    if (Regex.IsMatch(nameKeyword, regex))
                    {
                        item.is_selected = true;
                        item.Regex_Novalid = regex;
                    }
                }
            }
            this.gridView1.RefreshData();
        }

        private void btnImportKeyword_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strFile = openFileDialog1.FileName;
                string strText = File.ReadAllText(strFile);
                if (strText != "")
                {
                    FrmImportKeyword frmImportKeyword = new FrmImportKeyword();
                    frmImportKeyword.LoadText(strText);
                    frmImportKeyword.ShowDialog();
                }
            }
        }
    }
}
