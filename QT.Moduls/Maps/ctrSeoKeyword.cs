using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace QT.Moduls.Maps
{
    public partial class ctrSeoKeyword : UserControl
    {
        public ctrSeoKeyword()
        {
            InitializeComponent();
        }
        public void Init()
        {
            this.keywordsSeoTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
        }
        private void btLoad_Click(object sender, EventArgs e)
        {
            int click = 20;
            click = QT.Entities.Common.Obj2Int(this.txtClick.Text);
            if (click <= 0) click = 20;
            this.keywordsSeoTableAdapter.FillBy_KeyClick(kW.KeywordsSeo, click);

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.keywordsSeoBindingSource.EndEdit();
            this.keywordsSeoTableAdapter.Update(this.kW.KeywordsSeo);

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (titleTextBox.Text.Trim().Length > 0)
            {
                this.sEOUpdateDateTimePicker.Value = DateTime.Now;
            }
            this.latitle.Text = titleTextBox.Text.Trim().Length.ToString();
            //if (titleTextBox.Text.Trim().Length > 75)
            //{
            //    MessageBox.Show("Title không nhập quá 75 ký tự");
            //}
        }

        private void sapoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sapoTextBox.Text.Trim().Length > 0)
            {
                this.sEOUpdateDateTimePicker.Value = DateTime.Now;
            }
            this.lasapo.Text = sapoTextBox.Text.Trim().Length.ToString();
            //if (sapoTextBox.Text.Trim().Length > 160)
            //{
            //    MessageBox.Show("Sapo không nhập quá 160 ký tự");
            //}
        }

        private void btXemNoiDung_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://websosanh.vn/s/" + this.keyNameTextBox.Text.Trim().ToLower().Replace("  "," ").Replace(" ","+") + ".htm");
            Process.Start(sInfo);
        }

        private void gridKe_DoubleClick(object sender, EventArgs e)
        {
            frmSeoKeyWord frm = new frmSeoKeyWord(QT.Entities.Common.Obj2Int(this.keyHashTextBox.Text));
            frm.ShowDialog();
            frm.Dispose();
        }

        private void keyLienQuanTextBox_TextChanged(object sender, EventArgs e)
        {
            string[] ls = this.keyNameTextBox.Text.Trim().Split(',');
            this.lakey.Text = ls.Length.ToString();
        }
    }
}
