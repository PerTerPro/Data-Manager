using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using QT.Entities;
using QT.Entities.RaoVat;
using QT.Entities.Model.SaleNews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlSale
{


    public partial class FrmExtractKeyWordSQL : Form
    {

        MongoDbRaoVat mongoDb = new MongoDbRaoVat();
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmExtractKeyWordSQL));

        public FrmExtractKeyWordSQL()
        {
            InitializeComponent();

            this.gridControlGoodKey.DataSource = new List<KeywordSaleNew>();
            this.gridControlKey.DataSource = new List<KeywordSaleNew>();
        }

        private void btnLoadAnalysictData_Click(object sender, EventArgs e)
        {
            string query = richTextBox1.Text;
            Thread a = new Thread(() => RunLoadData(query));
            a.Start();
        }

        private void RunLoadData(string querySelectData)
        {
            try
            {
                List<ProductSaleNew> lstExtract = new List<ProductSaleNew>();
                var listExtraction = mongoDb.GetListExtractKeyWord(querySelectData, 100, 1).Result;

                foreach (var item in listExtraction)
                {
                    ProductSaleNew productSaleNew = new ProductSaleNew();
                    productSaleNew.id = item["id"].AsInt64;
                    productSaleNew._id = item["_id"].AsObjectId.ToString();
                    productSaleNew.name = item["name"].AsString;
                    productSaleNew.updated_at = item["updated_at"].ToUniversalTime().AddHours(7);
                    productSaleNew.source_updated_at = item["source_updated_at"].ToUniversalTime().AddHours(7);
                    lstExtract.Add(productSaleNew);

                }

                this.Invoke(new Action(() =>
                    {
                        try
                        {
                            this.gridControl2.DataSource = lstExtract;
                        }
                        catch (Exception ex)
                        {
                            log.ErrorFormat(ex.Message);
                        }
                    }));
            }
            catch (Exception ex)
            {
                log.ErrorFormat(ex.Message);
            }
        }

        private void btnAnalysic_Click(object sender, EventArgs e)
        {
            bool bUseRegex =  ckRegexKeyword.Checked;
            List<int> lstNumberWord = new List<int>();
            var arNumberWords = txtNumberWord.Text.Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach(var numberWord in arNumberWords)
            {
                lstNumberWord.Add(Convert.ToInt32(numberWord));
            }
            Thread threadAnalysicData = new Thread(() => AnalysicData(lstNumberWord.ToArray(),bUseRegex));
            threadAnalysicData.Start();
        }

        private void AnalysicData(int[] arNumberWord, bool UserRegex)
        {
            Dictionary<long, KeywordSaleNew> lstResultKeyWord = new Dictionary<long, KeywordSaleNew>();
            Dictionary<long, KeywordSaleNew> lstBlackLink = new Dictionary<long, KeywordSaleNew>();
            for (int iRow = 0; iRow < this.gridView2.DataRowCount; iRow++)
            {
                ProductSaleNew productSaleNew = this.gridView2.GetRow(iRow) as ProductSaleNew;
                string titleData = productSaleNew.name.ToLower();
                List<string> lstTitle = Common.ExtractBySentence(titleData);
                foreach (var title in lstTitle)
                {
                    List<string> lstWordNGram = new List<string>();
                    
                    foreach (var item in arNumberWord)
                    {
                        lstWordNGram.AddRange(GABIZ.Base.Tools.NGramDocument(item, title));
                    }

                    for (int i = lstWordNGram.Count - 1; i >= 0; i--)
                    {
                        if (Common.ValidKeyword(lstWordNGram[i])
                            && (UserRegex == false || Common.ValidKeyWordGrammar(lstWordNGram[i])))
                            lstWordNGram.RemoveAt(i);
                    }

                    foreach (var itemCanKeyword in lstWordNGram)
                    {
                        long idKeyword = Math.Abs(Common.GetID_Keywords64(itemCanKeyword));
                        if (!CheckInBlackLink(idKeyword))
                        {
                            if (!lstResultKeyWord.ContainsKey(idKeyword))
                            {
                                lstResultKeyWord.Add(idKeyword, new KeywordSaleNew()
                                {
                                    crc = idKeyword,
                                    category_ids = productSaleNew.category_ids,
                                    name = itemCanKeyword,
                                    is_selected = false
                                });
                            }
                        }
                    }
                }
            }

            this.Invoke(new Action(() =>
                {
                    this.gridControlGoodKey.DataSource = lstResultKeyWord.Values.ToList();
                    this.gridControlKey.DataSource = lstBlackLink.Values.ToList();
                }));

        }

        private bool CheckInBlackLink(long idKeyword)
        {
            return this.mongoDb.CheckBlackLink(idKeyword);
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                KeywordSaleNew keyWord = this.gridView1.GetRow(i) as KeywordSaleNew;
                keyWord.is_selected = true;
            }
            this.gridView1.RefreshData();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            List<KeywordSaleNew> lstBlackey = this.gridControlKey.DataSource as List<KeywordSaleNew>;
            List<KeywordSaleNew> lstGoodkey = this.gridControlGoodKey.DataSource as List<KeywordSaleNew>;
            for (int i = lstGoodkey.Count-1; i >= 0; i--)
            {
                KeywordSaleNew key = lstGoodkey[i];
                if (key.is_selected)
                {
                    lstGoodkey.RemoveAt(i);
                    lstBlackey.Add(key);
                    key.is_selected = false;
                }
            }
            this.gridView3.RefreshData();
            this.gridView1.RefreshData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                KeywordSaleNew keyWord = this.gridView3.GetRow(i) as KeywordSaleNew;
                keyWord.is_selected = true;
            }
            this.gridView3.RefreshData();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            List<KeywordSaleNew> lstBlackey = this.gridControlKey.DataSource as List<KeywordSaleNew>;
            List<KeywordSaleNew> lstGoodkey = this.gridControlGoodKey.DataSource as List<KeywordSaleNew>;
            for (int i = lstBlackey.Count - 1; i >= 0; i--)
            {
                KeywordSaleNew key = lstBlackey[i];
                if (key.is_selected)
                {
                    lstBlackey.RemoveAt(i);
                    lstGoodkey.Add(key);
                    key.is_selected = false;
                }
            }
            this.gridView3.RefreshData();
            this.gridView1.RefreshData();
        }

        private void btnSaveKeyWord_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có lưu keyword vào db?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                List<KeywordSaleNew> lst1 = this.gridControlGoodKey.DataSource as List<KeywordSaleNew>;
                foreach(var item in lst1)
                {
                    mongoDb.UpdateKeyWord("", item.crc, item.name
                        , Common.GetSplug(item.name), ""
                        , new BsonArray(item.category_ids), "score_gram", 0, false);
                }
                MessageBox.Show("Saved");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có lưu keyword vào db?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                List<KeywordSaleNew> lst1 = this.gridControlKey.DataSource as List<KeywordSaleNew>;
                foreach (var item in lst1)
                {
                    mongoDb.UpdateKeyWord("", item.crc, item.name
                        , Common.GetSplug(item.name), ""
                        , new BsonArray(item.category_ids), "score_gram", 0, true);
                }
                MessageBox.Show("Saved");
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmExtractKeyWordSQL_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QT.Entities.Common.ReloadRegexKeyWord();
            MessageBox.Show("Successed!");
        }
    }
}
