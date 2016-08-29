using MongoDB.Bson;
using MongoDB.Driver;
using QT.Entities.Data;
using QT.Moduls.CrawlSale;
using QT.Moduls.RaoVat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlProd
{
    public partial class FrmValidAllKeyword : Form
    {

        CancellationTokenSource tokenSource = new CancellationTokenSource();
        private DateTime dtFrom;
        private bool bCheckStatus = false;

        public FrmValidAllKeyword()
        {
            InitializeComponent();
        }

        private void btnStartRun_Click(object sender, EventArgs e)
        {
            var token = tokenSource.Token;
            int count = 0;
            Task.Factory.StartNew(() =>
            {
                this.Invoke(new Action(() =>
                {
                    this.richTextBox1.AppendText(string.Format("Start Run"));
                }));

                MongoDbRaoVat mongoDb = new MongoDbRaoVat();
                ProductSaleNewAdapter productSaleNewAdapter = new ProductSaleNewAdapter(new SqlDb(QT.Entities.Server.ConnectionStringCrawler));
                List<string> lstRegexoK = productSaleNewAdapter.GetListRegexKeyword();
                List<string> lstRegexBlack = productSaleNewAdapter.GetListBlackRegexKeyWord();
                Dictionary<ObjectId, bool> dicUpdate = new Dictionary<ObjectId, bool>();
                foreach (string str in lstRegexBlack)
                {
                    string strXuanTrang = "";
                    try
                    {
                        bool bok = (Regex.IsMatch(strXuanTrang, str));
                    }
                    catch (Exception ex01)
                    {
                        this.Invoke(new Action(() =>
                        {
                            this.richTextBox1.AppendText(string.Format("\r\nError in regex list at:{0}", str));
                        }));

                        return;
                    }
                }

                while (true)
                {
                    if (token.IsCancellationRequested)
                    {
                        throw new OperationCanceledException(token);
                    }
                    //Xử lí.
                    List<BsonDocument> lstDocument = mongoDb.GetListKeywordNeedCheck(this.dtFrom, this.bCheckStatus);
                    if (lstDocument.Count > 0)
                    {
                        foreach (var document in lstDocument)
                        {
                            if (!dicUpdate.ContainsKey(document["_id"].AsObjectId))
                            {
                                string nameKeyword = document["name"].AsString;

                                foreach (var strRegexBlack in lstRegexBlack)
                                {
                                    if (Regex.IsMatch(nameKeyword, strRegexBlack))
                                    {
                                        dicUpdate.Add(document["_id"].AsObjectId, false);
                                        break;
                                    }
                                }
                                if (!dicUpdate.ContainsKey(document["_id"].AsObjectId))
                                {
                                    dicUpdate.Add(document["_id"].AsObjectId, true);
                                }
                            }
                        }
                        foreach (var item in dicUpdate)
                        {
                            mongoDb.UpdateStatusOfKeyword(item.Key, (item.Value == true) ? 1 : 0);
                        }

                        count = count + dicUpdate.Count;
                        this.Invoke(new Action(() =>
                        {
                            this.richTextBox1.AppendText(string.Format("\r\nCount:{0}", count));
                        }));

                        dicUpdate.Clear();
                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            this.richTextBox1.AppendText(string.Format("\r\n End Run:{0}", count));
                        }));
                        break;
                    }
                }
            }, token);
        }

        private void FrmValidAllKeyword_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.tokenSource.Cancel();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dtFrom = dateTimePicker1.Value;
        }

        private void FrmValidAllKeyword_Load(object sender, EventArgs e)
        {
            this.dtFrom = this.dateTimePicker1.Value;
        }

        private void ckStutus_CheckedChanged(object sender, EventArgs e)
        {
            this.bCheckStatus = ckStutus.Checked;
        }
    }
}
