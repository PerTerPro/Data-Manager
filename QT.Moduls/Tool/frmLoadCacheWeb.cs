using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace QT.Moduls.Tool
{
    public partial class frmLoadCacheWeb : QT.Entities.frmBase
    {
        public frmLoadCacheWeb()
        {
            InitializeComponent();
        }
        Thread _tAlexa;
        Boolean _pause = false;
        void doThreat()
        {
            Boolean check = false;
            this.Invoke((MethodInvoker)delegate
            {
                check = chkWebsosanh.Checked;
                this.laTong.Text = "Loading...";
            });

            DBTool3.Product_CacheDataTable dt = new DBTool3.Product_CacheDataTable();
            DBTool3TableAdapters.Product_CacheTableAdapter adt = new DBTool3TableAdapters.Product_CacheTableAdapter();
            adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            adt.FillBy_TopNapCache(dt);
            foreach (DBTool3.Product_CacheRow dr in dt)
            {
                string url = "";
                if (check)
                {
                    url = string.Format("http://cache.websosanh.vn/{0}/{1}/so-sanh.htm", dr.Summary.Replace(" ", "+"), dr.ID);
                }
                else
                {
                    url = string.Format("http://websosanh.vn/{0}/{1}/so-sanh.htm", dr.Summary.Replace(" ", "+"), dr.ID);
                }
                this.Invoke((MethodInvoker)delegate
                {
                    this.dBTool3.URLCache.AddURLCacheRow(url, dr.ID.ToString(), dr.ViewCount);
                });
            }
            this.Invoke((MethodInvoker)delegate
            {
                dBTool3.URLCache.AcceptChanges();
            });
            this.Invoke((MethodInvoker)delegate
            {
                this.laTong.Text = "start";
            });
            int i = 0;
            int delay = 100;
            while (!_pause)
            {
                foreach (DBTool3.URLCacheRow row in dBTool3.URLCache)
                {
                    string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(row.Url, 45, 2);
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.laTong.Text = string.Format("{0}/{1}\n{2}", i++, dBTool3.URLCache.Count, row.Url.ToString());
                        delay = QT.Entities.Common.Obj2Int(txtDelay.Text);
                    });
                    Thread.Sleep(delay);
                }
                Thread.Sleep(100000);
            }
        }
        void doThreatSearch()
        {
            Boolean check = false;
            this.Invoke((MethodInvoker)delegate
            {
                check = chkWebsosanh.Checked;
                this.laTong.Text = "Loading...";
            });

            DBTool3.KeywordsDataTable dt = new DBTool3.KeywordsDataTable();
            DBTool3TableAdapters.KeywordsTableAdapter adt = new DBTool3TableAdapters.KeywordsTableAdapter();
            adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            adt.FillBy_TopNapCache(dt);
            foreach (DBTool3.KeywordsRow dr in dt)
            {
                string url = "";
                if (check)
                {
                    url = string.Format("http://cache.websosanh.vn/s/{0}.htm", dr.KeyName.Replace(" ", "+"));
                }
                else
                {
                    url = string.Format("http://websosanh.vn/s/{0}.htm", dr.KeyName.Replace(" ", "+"));
                }
                this.Invoke((MethodInvoker)delegate
                {
                    this.dBTool3.URLCache.AddURLCacheRow(url, dr.KeyName.ToString(), dr.KeyClick);
                });
            }
            this.Invoke((MethodInvoker)delegate
            {
                dBTool3.URLCache.AcceptChanges();
            });
            this.Invoke((MethodInvoker)delegate
            {
                this.laTong.Text = "start";
            });
            int i = 0;
            int delay = 100;
            while (!_pause)
            {
                foreach (DBTool3.URLCacheRow row in dBTool3.URLCache)
                {
                    string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(row.Url, 45, 2);
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.laTong.Text = string.Format("{0}/{1}\n{2}", i++, dBTool3.URLCache.Count, row.Url.ToString());
                        delay = QT.Entities.Common.Obj2Int(txtDelay.Text);
                    });
                    Thread.Sleep(delay);
                }
                Thread.Sleep(100000);
            }
        }

        private void btLoadSoSanh_Click(object sender, EventArgs e)
        {
            _tAlexa = new Thread(new ThreadStart(doThreat));
            _tAlexa.Start();
        }

        private void frmLoadCacheWeb_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_tAlexa != null)
            {
                if (_tAlexa.IsAlive)
                {
                    _tAlexa.Abort();
                    _tAlexa.Join();
                    _tAlexa = null;
                }
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            _tAlexa = new Thread(new ThreadStart(doThreatSearch));
            _tAlexa.Start();
        }


    }
}
