using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QT.Entities;
using System.Threading;

namespace QT.Moduls.Maps
{
    public partial class ctrEditeKeyword : UserControl
    {
        public ctrEditeKeyword()
        {
            InitializeComponent();
        }

        private void btLoadData_Click(object sender, EventArgs e)
        {
            keywordsTableAdapter.FillBy_OrderByFe(this.kW.Keywords, Common.Obj2Int(txtSoLanXuatHien.Text));
            keywordsTempTableAdapter.Fill(this.kW.KeywordsTemp);
        }
        public void Init()
        {
            this.keywordsTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.keywordsTempTableAdapter.Connection.ConnectionString = Server.ConnectionString;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            this.keywordsBindingSource.EndEdit();
            this.keywordsTempBindingSource.EndEdit();
            keywordsTableAdapter.Update(this.kW.Keywords);
            keywordsTempTableAdapter.Update(this.kW.KeywordsTemp);
        }

        private void gridKe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.kW.KeywordsTemp.Rows.Add(
              this.keyHashTextBox.Text.Trim(),
              this.keyNameTextBox.Text.Trim());
            if (this.keywordsBindingSource.Count > 0)
            {
                this.keywordsBindingSource.RemoveCurrent();
            }
            this.keywordsTempBindingSource.EndEdit();
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.kW.Keywords.Rows.Add(
              this.keyHashTextBox1.Text.Trim(),
              this.keyNameTextBox1.Text.Trim(),
              "",
              0,
              0,
              DateTime.Now);
            if (this.keywordsTempBindingSource.Count > 0)
            {
                this.keywordsTempBindingSource.RemoveCurrent();
            }
            this.keywordsBindingSource.EndEdit();
        }

        private void btAuto_Click(object sender, EventArgs e)
        {
            this.keywordsBindingSource.MoveLast();
            for (int i = kW.Keywords.Rows.Count - 1; i >= 0; i--)
            {
                this.lames.Text = String.Format("{0}/{1} - {2}", i, kW.Keywords.Rows.Count, kW.Keywords.Rows[i]["KeyName"].ToString());
                if (!QT.Entities.Common.ValidKeyword(this.keyNameTextBox.Text.Trim()))
                {
                    this.kW.WordExtraxTemp.Rows.Add(
                          this.keyNameTextBox.Text.Trim(),
                          this.keyHashTextBox.Text.Trim());
                    if (this.keywordsBindingSource.Count > 0)
                    {
                        this.keywordsBindingSource.RemoveCurrent();
                    }
                }
                this.keywordsBindingSource.MovePrevious();

            }
            this.keywordsBindingSource.EndEdit();
            this.keywordsTempBindingSource.EndEdit();
        }



        void doUpdateKeyword()
        {
            Moduls.Data.KW.View_KeywordLogDataTable dtview = new Data.KW.View_KeywordLogDataTable();
            Moduls.Data.KWTableAdapters.View_KeywordLogTableAdapter adtView = new Data.KWTableAdapters.View_KeywordLogTableAdapter();
            adtView.Connection.ConnectionString = QT.Entities.Server.LogConnectionString;
            DateTime dtime = DateTime.Now.AddMonths(-2);
            this.Invoke((MethodInvoker)delegate
            {
                this.lames.Text = "Start download";
            });
            adtView.FillBy_FromDate(dtview, dtime.Year, dtime.Month);
            int i = 0;
            Data.KW.KeywordsDataTable dtkw = new Data.KW.KeywordsDataTable();
            foreach (Moduls.Data.KW.View_KeywordLogRow dr in dtview)
            {
                keywordsTableAdapter.FillBy_SelectOne(dtkw, dr.IDHash);
                if (dtkw.Rows.Count > 0)
                {
                    keywordsTableAdapter.UpdateQuery_KeyClickByIDHash(dr.Count, DateTime.Now, dr.IDHash);
                }
                else
                {
                    keywordsTableAdapter.Insert(
                        dr.IDHash,
                        dr.Name,
                        "", 0, 0, DateTime.Now,
                        dr.IDHash,
                        dr.Count);
                }
                this.Invoke((MethodInvoker)delegate
                {
                    this.lames.Text = String.Format("{0}/{1} - {2}\n{3}", i++, dtview.Rows.Count, dr.Name, dr.Count);
                });
                Thread.Sleep(100);
            }
            adtView.Dispose();
            dtview.Dispose();
            if (updateKeywordThread != null)
            {
                if (updateKeywordThread.IsAlive)
                {
                    updateKeywordThread.Abort();
                    updateKeywordThread.Join();
                    updateKeywordThread = null;
                }
            }
        }

        private Thread updateKeywordThread;

        private void btCRC64_Click(object sender, EventArgs e)
        {
            updateKeywordThread = new Thread(doUpdateKeyword);
            updateKeywordThread.Start();
        }
    }
}
