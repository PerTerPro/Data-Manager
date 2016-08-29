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

namespace QT.Moduls.CrawlSale
{
    public partial class FrmKeyWord : Form
    {
        SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
        MongoDbRaoVat mongoDbAdapter = new MongoDbRaoVat();
        MySqlAdapterRaoVat mySqlAdapter = null;
        Dictionary<int, string> dicTerm = null;

        public FrmKeyWord()
        {
            InitializeComponent();

            mySqlAdapter = new MySqlAdapterRaoVat();
            dicTerm = mySqlAdapter.GetDicTerms();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                string keyText = "TEST";

            }
        }

        private void btnLoadKeyword_Click(object sender, EventArgs e)
        {
            //QT.Entities.CrawlSaleNew.HandlerContentOfHtml handlerContentHtml = new Entities.CrawlSaleNew.HandlerContentOfHtml();
            //GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            //doc.LoadHtml(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2, true));
            //List<string> lstTag = QT.Entities.Common.GetTextInNode(doc, xpath);
            //MessageBox.Show(QT.Entities.Common.ConvertToString(lstTag, ","));
        }

        private void btnRunGetKeyword_Click(object sender, EventArgs e)
        {
            
        }

        public List<string> GetListTag (string url, string xpath)
        {
            QT.Entities.RaoVat.HandlerContentOfHtml handlerContentHtml = new Entities.RaoVat.HandlerContentOfHtml();
            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2, true));
            List<string> lstTag = QT.Entities.Common.GetTextInNode(doc, xpath);
            return lstTag;
        }

        private void RunSearchKeyword(string source_id, string url, string xpath, string TeramIDs, string TaxanomyIDs, string CategoryIDs)
        {
            foreach (var item in this.GetListTag(url, xpath))
            {
                string keyword = item.ToLower().Trim();
                long crcKeyWord = Math.Abs(GABIZ.Base.Tools.getCRC64(keyword));
                var ExitInDb = this.mongoDbAdapter.CheckExistsKeyWord(crcKeyWord);
                if (!ExitInDb)
                {
                    this.mongoDbAdapter.InsertKeyWord(source_id, crcKeyWord, keyword, keyword, 0, TeramIDs, CategoryIDs);
                }
                else
                {
                    this.mongoDbAdapter.UpdateKeyWord(source_id, crcKeyWord, keyword, keyword, TeramIDs, CategoryIDs);
                }
            }
        }

        private void FrmKeyWord_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmKeyWord_Load(object sender, EventArgs e)
        {
            DataTable tblConfig = this.sqlDb.GetTblData("proc_ConfigGetKeywordTerm_GetList", CommandType.StoredProcedure, null);
            this.gridControl1.DataSource = tblConfig;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var tblConfig = this.gridControl1.DataSource as DataTable;
            if (tblConfig != null)
            {
                foreach (int iRow in this.gridView1.GetSelectedRows())
                {
                    string id = (this.gridView1.GetRow(iRow) as DataRowView)["id"].ToString();
                    string url = (this.gridView1.GetRow(iRow) as DataRowView)["url"].ToString();
                    string xpath = (this.gridView1.GetRow(iRow) as DataRowView)["xpath"].ToString();
                    string TeramIDs = Convert.ToString((this.gridView1.GetRow(iRow) as DataRowView)["TermIDs"]);
                    string TaxanomyIDs = Convert.ToString((this.gridView1.GetRow(iRow) as DataRowView)["TaxonomyIDs"]);
                    string CategoryIDs = Convert.ToString((this.gridView1.GetRow(iRow) as DataRowView)["CategoryIDs"]);
                    this.RunSearchKeyword(id, url, xpath, TeramIDs, TaxanomyIDs, CategoryIDs);
                }
            }
            MessageBox.Show("Saved!");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int iRow = this.gridView1.FocusedRowHandle;
            if (iRow > 0)
            {
                string id = (this.gridView1.GetRow(iRow) as DataRowView)["id"].ToString();
                string url = (this.gridView1.GetRow(iRow) as DataRowView)["url"].ToString();
                string xpath = (this.gridView1.GetRow(iRow) as DataRowView)["xpath"].ToString();
                string TeramIDs = Convert.ToString((this.gridView1.GetRow(iRow) as DataRowView)["TermIDs"]);
                string TaxanomyIDs = Convert.ToString((this.gridView1.GetRow(iRow) as DataRowView)["TaxonomyIDs"]);
                string CategoryIDs = Convert.ToString((this.gridView1.GetRow(iRow) as DataRowView)["CategoryIDs"]);
                List<string> lstTag = this.GetListTag(url, xpath);
                MessageBox.Show(QT.Entities.Common.ConvertToString(lstTag, ","), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
