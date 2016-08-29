using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QT.Moduls.News
{
    public partial class frmManagerNews : QT.Entities.frmBase
    {
        public frmManagerNews()
        {
            InitializeComponent();
        }

        private void frmManagerNews_Load(object sender, EventArgs e)
        {
            this.newsItemTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionStringFromNews;
            this.keywordMapTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionStringFromNews;
            this.dtfrom.Value = DateTime.Now.AddDays(-1);
            this.dtTo.Value = DateTime.Now;
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            this.newsItemTableAdapter.FillBy_DataRange(this.dBNew.NewsItem, this.dtfrom.Value, this.dtTo.Value);

        }

        private void btLoadKeyword_Click(object sender, EventArgs e)
        {
            this.keywordMapTableAdapter.Fill(this.dBNew.KeywordMap);
        }

        private void btSaveKeyword_Click(object sender, EventArgs e)
        {
            this.keywordMapBindingSource.EndEdit();
            this.keywordMapTableAdapter.Update(dBNew.KeywordMap);
        }

        private void btLoadAnanytic_Click(object sender, EventArgs e)
        {
            this.keywordMapTableAdapter.Fill(this.dBNew.KeywordMap);
            string contains = "";
            for (int i = 0; i < dBNew.KeywordMap.Rows.Count; i++)
            {
                contains += dBNew.KeywordMap[i]["Keyword"].ToString() + " ";
            }
            this.newsItemTableAdapter.FillBy_RangeStatus(this.dBNew.NewsItem, this.dtfrom.Value, this.dtTo.Value, contains);
        }

        private void contentsTextBox_TextChanged(object sender, EventArgs e)
        {
            this.webBrowser1.DocumentText = this.contentsTextBox.Text;
        }

        private void btNotReview_Click(object sender, EventArgs e)
        {
            this.insertReviewCheckBox.Checked = false;
        }
        private long getNewsID(DateTime datepublic, long newsidOld)
        {
            long r = 0;
            string t = datepublic.ToString("yyMMddhhmmssffff");
            r = QT.Entities.Common.Obj2Int64(t);
            if (r == newsidOld)
            {
                r = r + 1;
            }
            return r;
        }
        private void btInsertAll_Click(object sender, EventArgs e)
        {
            DBNewTableAdapters.ActionTableAdapter adtAction = new DBNewTableAdapters.ActionTableAdapter();
            DBNewTableAdapters.NewsReviewTableAdapter adtReview = new DBNewTableAdapters.NewsReviewTableAdapter();
            adtAction.Connection.ConnectionString = QT.Entities.Server.ConnectionStringNews;
            adtReview.Connection.ConnectionString = QT.Entities.Server.ConnectionStringNews;

            this.newsItemBindingSource.EndEdit();
            this.newsItemBindingSource.MoveFirst();
            long newsidOld = 0;
            for (int i = 0; i < newsItemBindingSource.Count; i++)
            {
                if (this.insertReviewCheckBox.CheckState == CheckState.Checked)
                {
                    try
                    {
                        Uri root = new Uri(this.uRLTextBox.Text);
                        long newsid = getNewsID(publishedDateDateTimePicker.Value, newsidOld);
                        newsidOld = newsid;
                        adtReview.Insert(
                            newsid,
                            1,
                            this.titleLabel1.Text,//title,
                            "",//subtitle,
                            this.avatarTextBox.Text,//image,
                            "",//imagenote,
                            root.DnsSafeHost.ToString(),//news_source tên domain
                            this.sapoLabel1.Text,//initcontent,
                            this.contentsTextBox.Text,//content,
                            "admin",//author,
                            "",//currediter,
                            "admin",//approver,
                            1,//newsstatus,
                            null,//swithchtime,
                            publishedDateDateTimePicker.Value,//publishdate,
                            false,//isfocus
                            0, //news mode
                            0, //viewnumber
                            DateTime.Now, //create date
                            DateTime.Now, // modified date
                            this.relatedNewsTextBox.Text, //
                            0, //news rate
                            "",// other cat
                            true,//iscomment
                            true,//user rate
                            0,
                            "",//icon
                            0,//wordcount
                            0,//viewcount
                            this.cRC64TextBox.Text,//ex1
                            "",//ex2
                            this.uRLTextBox.Text,//ex3  link gốc
                            0,//ex4
                            "",//news_source
                            "",//ex5
                            ""//ex6
                            );
                        this.newsItemTableAdapter.UpdateQuery_InsertReview(true, QT.Entities.Common.Obj2Int(this.iDTextBox.Text));
                        //adtAction.Insert(newsid, "admin", "Copy bài viết", DateTime.Now, null, 0, null);
                        adtAction.Insert(newsid, "admin", "Gửi bài chờ duyệt", DateTime.Now, null, 1, null);
                    }
                    catch (Exception)
                    {
                    }
                }
                else
                {
                    this.newsItemTableAdapter.UpdateQuery_InsertReview(false, QT.Entities.Common.Obj2Int(this.iDTextBox.Text));
                }
                this.newsItemBindingSource.MoveNext();
            }
            this.newsItemTableAdapter.Update(dBNew.NewsItem);
        }

        private void btCheckAll_Click(object sender, EventArgs e)
        {
            this.newsItemBindingSource.MoveFirst();
            for (int i = 0; i < newsItemBindingSource.Count; i++)
            {
                this.insertReviewCheckBox.CheckState = CheckState.Checked;
                this.newsItemBindingSource.MoveNext();
            }
            this.newsItemBindingSource.EndEdit();
        }

        private void insertReviewCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
