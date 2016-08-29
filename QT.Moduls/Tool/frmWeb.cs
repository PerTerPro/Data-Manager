using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QT.Moduls.Tool
{
    public partial class frmWeb : QT.Entities.frmBase
    {
        int time = 0;
        public frmWeb()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            timer1.Start();
        }
        public string URL
        {
            set {
                this.txtUrl.Text = value;
                try
                {
                    webBrowser1.Url = new System.Uri(this.txtUrl.Text, System.UriKind.Absolute);
                    webBrowser1.Refresh();
                }
                catch (Exception)
                {
                   
                }
                
            }
            get { return webBrowser1.Url.ToString(); }
        }
       
        private void btLoad_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            string s = e.Url.AbsoluteUri;
            if (CorrectAddress(s))
            {
                txtUrl.Text = webBrowser1.Url.ToString();
            }
        }
        bool CorrectAddress(string name)
        {
            string[] names = new string[] { "javascript:" };
            foreach (string s in names)
                if (name.IndexOf(s) == 0) return false;
            return true;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.GoBack();
            }
            catch { }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.GoForward();
            }
            catch { }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            progressBarControl1.Properties.Maximum = (int)(e.MaximumProgress + (e.MaximumProgress == progressBarControl1.Properties.Minimum ? 1 : 0));
            progressBarControl1.EditValue = e.CurrentProgress;
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Stop();
                this.txtUrl.Text = "http://" + this.txtUrl.Text.Replace("http://", "");
                webBrowser1.Url = new System.Uri(this.txtUrl.Text, System.UriKind.Absolute);
                webBrowser1.Refresh();
            }
        }
        public override bool RefreshData()
        {
            webBrowser1.Stop();
            this.txtUrl.Text = "http://" + this.txtUrl.Text.Replace("http://", "");
            webBrowser1.Url = new System.Uri(this.txtUrl.Text, System.UriKind.Absolute);
            webBrowser1.Refresh();
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (this.checkEdit1.Checked == true)
            {
                if (time >= 60)
                {
                    webBrowser1.Stop();
                    this.txtUrl.Text = "http://" + this.txtUrl.Text.Replace("http://", "");
                    webBrowser1.Url = new System.Uri(this.txtUrl.Text, System.UriKind.Absolute);
                    webBrowser1.Refresh();
                    time = 0;
                }
            }
        }

    }
}
