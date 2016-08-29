using MongoDB.Bson;
using QT.Moduls.CrawlSale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.RaoVat
{
    public partial class FrmImportKeyword : Form
    {

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmImportKeyword));
        public FrmImportKeyword()
        {
            InitializeComponent();
        }

        public void LoadText(string strText)
        {
            this.txtImportKeyword.Text = strText;
        }

        private void btnSaveKeywrod_Click(object sender, EventArgs e)
        {
            string strText = txtImportKeyword.Text;
            int Priority = Convert.ToInt32(spinPriority.Value);
            bool bRemoveSpecialKeyword = ckChangeSpecialCharacter.Checked;

            Task.Factory.StartNew(() =>
                {
                    string[] ieKeyWord = strText.Split(new char[] { '\n', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    MongoDbRaoVat mongoDb = new MongoDbRaoVat();
                    Dictionary<string, int> dicKeyWordAndStore = new Dictionary<string, int>();

                    foreach (var keywordItem1 in ieKeyWord)
                    {
                        string keywordItem = (bRemoveSpecialKeyword) ? QT.Entities.Common.RemoveSpecialCharacter(keywordItem1.Trim().ToLower()).ToLower() : keywordItem1.Trim().ToLower();
                        long crcKeyword = Math.Abs(GABIZ.Base.Tools.getCRC64(keywordItem));
                        string objectID = mongoDb.GetObjectIDOfKeyword(crcKeyword);
                        if (objectID == "")
                        {
                            mongoDb.InsertKeyword(new Entities.RaoVat.KeywordSaleNew()
                                {
                                    category_ids = new List<int> { },
                                    crc = crcKeyword,
                                    crc_text = Math.Abs(GABIZ.Base.Tools.getCRC64(keywordItem)).ToString(),
                                    is_selected = false,
                                    name = keywordItem,
                                    name_suggest = QT.Entities.Common.GetSplug(keywordItem, false).Replace("-", " "),
                                    priority = Priority,
                                    Regex_Novalid = "",
                                    score_gram = 1,
                                    slug = QT.Entities.Common.GetSplug(keywordItem, false),
                                    solr_updated_at = DateTime.Now,
                                    status = 1,
                                    term_ids = new List<int>() { },
                                    updated_at = DateTime.Now,
                                    view_count = 0
                                });
                        }
                        else
                        {
                            var item = mongoDb.SetPriority(objectID, Priority).Result;
                        }

                        long iModify = mongoDb.IncrementScoreGramKeyWord(crcKeyword).Result;
                        if (iModify > 0)
                        {
                            log.Info(string.Format("Changed keyword:{0}", keywordItem));
                        }
                    }
                });
        }

        private void btnDelKeyword_Click(object sender, EventArgs e)
        {
            string strText = txtImportKeyword.Text;
            int Priority = Convert.ToInt32(spinPriority.Value);
            bool bRemoveSpecialKeyword = ckChangeSpecialCharacter.Checked;
            Task.Factory.StartNew(() =>
            {
                string[] ieKeyWord = strText.Split(new char[] { '\n', ';' }, StringSplitOptions.RemoveEmptyEntries);
                MongoDbRaoVat mongoDb = new MongoDbRaoVat();
                Dictionary<string, int> dicKeyWordAndStore = new Dictionary<string, int>();
                foreach (var keywordItem1 in ieKeyWord)
                {
                    long crcKeyword = Math.Abs(GABIZ.Base.Tools.getCRC64(QT.Entities.Common.RemoveSpecialCharacter(keywordItem1.Trim().ToLower()).ToLower()));
                    long crcKeywordOld = Math.Abs(GABIZ.Base.Tools.getCRC64(keywordItem1.Trim().ToLower()));
                    string objectID = mongoDb.GetObjectIDOfKeyword(crcKeywordOld);
                    if (crcKeyword!=crcKeywordOld)
                    {
                        var a = mongoDb.SetStatus(objectID, 0).Result;
                        long x =  a.ModifiedCount;
                    }                
                }
            });
        }
    }
}
