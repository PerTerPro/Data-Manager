using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QT.Entities;

namespace QT.Moduls.News
{
    public partial class frmGetContent : QT.Entities.frmBase
    {
        public frmGetContent()
        {
            InitializeComponent();
        }

        private void btGetByMonth_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= 31; i++)
            {
                try
                {
                    this.laMess1.Text = "Đang tải dữ liệu";
                    Application.DoEvents();
                    this.newsPublishedTableAdapter.FillByDay(this.dBNew.NewsPublished, dateTimeSelect.Value.Year, dateTimeSelect.Value.Month, i);
                    insert(i, dateTimeSelect.Value.Year, dateTimeSelect.Value.Month);
                }
                catch (Exception)
                {
                }
            }

        }

        private void frmGetContent_Load(object sender, EventArgs e)
        {
            this.newsTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionStringNews;
            this.newsPublishedTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionStringFromNews;

        }

        private void btGetByDay_Click(object sender, EventArgs e)
        {
            this.newsPublishedTableAdapter.FillByDay(this.dBNew.NewsPublished, dateTimeSelect.Value.Year, dateTimeSelect.Value.Month, dateTimeSelect.Value.Day);
        }
        private void insert(int day, int month, int year)
        {
            for (int i = 0; i < dBNew.NewsPublished.Rows.Count; i++)
            {
                string title = GABIZ.Base.Tools.removeHTML(dBNew.NewsPublished.Rows[i]["Title"].ToString());
                try
                {
                    string content = GABIZ.Base.Tools.removeHTML(dBNew.NewsPublished.Rows[i]["Contents"].ToString());
                    int newsid = Common.Obj2Int(dBNew.NewsPublished.Rows[i]["NewsID"]);
                    string sapo = GABIZ.Base.Tools.removeHTML(dBNew.NewsPublished.Rows[i]["Sapo"].ToString());
                    this.newsTableAdapter.Insert(
                        newsid,
                        title,
                        sapo,
                        content,
                        Common.Obj2Int(dBNew.NewsPublished.Rows[i]["SiteID"]),
                        dBNew.NewsPublished.Rows[i]["Url"].ToString(),
                        Common.ObjectToDataTime(dBNew.NewsPublished.Rows[i]["PublishDate"]),
                        dBNew.NewsPublished.Rows[i]["Avatar"].ToString(),
                        Common.Obj2Int(dBNew.NewsPublished.Rows[i]["CatID"]),
                        dBNew.NewsPublished.Rows[i]["RelatedNews"].ToString(),
                        Common.Obj2Int(dBNew.NewsPublished.Rows[i]["ReadCount"]),
                        0,
                        0,
                        0,
                        0);

                    this.laMess1.Text = String.Format("{3}/{4}/{5} - Insert {0}/{1} News: {2}\n ", i, dBNew.NewsPublished.Rows.Count, title, day, month, year);
                    Application.DoEvents();
                }
                catch (Exception)
                {
                    this.laMess1.Text = String.Format("{3}/{4}/{5} - dublicate {0}/{1} News: {2}\n ", i, dBNew.NewsPublished.Rows.Count, title, day, month, year);
                }
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dBNew.NewsPublished.Rows.Count; i++)
            {
                string title = GABIZ.Base.Tools.removeHTML(dBNew.NewsPublished.Rows[i]["Title"].ToString());
                try
                {
                    string content = GABIZ.Base.Tools.removeHTML(dBNew.NewsPublished.Rows[i]["Contents"].ToString());
                    int newsid = Common.Obj2Int(dBNew.NewsPublished.Rows[i]["NewsID"]);
                    string sapo = GABIZ.Base.Tools.removeHTML(dBNew.NewsPublished.Rows[i]["Sapo"].ToString());
                    this.newsTableAdapter.Insert(
                        newsid,
                        title,
                        sapo,
                        content,
                        Common.Obj2Int(dBNew.NewsPublished.Rows[i]["SiteID"]),
                        dBNew.NewsPublished.Rows[i]["Url"].ToString(),
                        Common.ObjectToDataTime(dBNew.NewsPublished.Rows[i]["PublishDate"]),
                        dBNew.NewsPublished.Rows[i]["Avatar"].ToString(),
                        Common.Obj2Int(dBNew.NewsPublished.Rows[i]["CatID"]),
                        dBNew.NewsPublished.Rows[i]["RelatedNews"].ToString(),
                        Common.Obj2Int(dBNew.NewsPublished.Rows[i]["ReadCount"]),
                        0,
                        0,
                        0,
                        0);

                    this.laMess1.Text = String.Format("Insert {0}/{1} News: {2}\n ", i, dBNew.NewsPublished.Rows.Count, title);
                    Application.DoEvents();
                }
                catch (Exception)
                {
                    this.laMess1.Text = String.Format("dublicate {0}/{1} News: {2}\n ", i, dBNew.NewsPublished.Rows.Count, title);
                }
            }
        }
    }
}
