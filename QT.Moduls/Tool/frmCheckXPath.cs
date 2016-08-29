using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QT.Entities;

namespace QT.Moduls.Tool
{
    public partial class frmCheckXPath : QT.Entities.frmBase
    {
        public frmCheckXPath()
        {
            InitializeComponent();
        }

        private void btCheckXPath_Click(object sender, EventArgs e)
        {
            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(this.txtURL.Text.Trim(), 60, 3);
            this.txtResult.Text = Common.GetInnerTextXPath(html, txtXPath.Text.Trim());
            FileLog.WriteText(this.txtURL.Text+"\r\n"+ txtXPath.Text,"testXPath.txt");
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> txt = FileLog.ReadAllLineText("testXPath.txt");
                this.txtURL.Text = txt[0];
                this.txtXPath.Text = txt[1];
            }
            catch (Exception)
            {
            }
           
        }
    }
}
