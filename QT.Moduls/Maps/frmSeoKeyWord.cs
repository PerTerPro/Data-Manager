using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace QT.Moduls.Maps
{
    public partial class frmSeoKeyWord : Form
    {
        public frmSeoKeyWord()
        {
            InitializeComponent();

        }
        private int _keyHash = 0;

        public frmSeoKeyWord(int keyHash)
        {
            InitializeComponent();
            _keyHash = keyHash;
        }

        private void frmSeoKeyWord_Load(object sender, EventArgs e)
        {
            this.keywords_SeoTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.keywordsSeoTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;

            this.keywordsSeoTableAdapter.FillBy_SelectOne(this.kW.KeywordsSeo, _keyHash);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btView_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://websosanh.vn/s/" + this.keyNameLabel1.Text.Trim().ToLower().Replace("  ", " ").Replace(" ", "+") + ".htm");
            Process.Start(sInfo);
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            this.latitle.Text = titleTextBox.Text.Trim().Length.ToString();
            if (titleTextBox.Text.Trim().Length > 75)
            {
                this.latitle.Text = this.latitle.Text + "Title không nhập quá 75 ký tự";
            }
        }

        private void sapoTextBox_TextChanged(object sender, EventArgs e)
        {
            this.lasapo.Text = sapoTextBox.Text.Trim().Length.ToString();
            if (sapoTextBox.Text.Trim().Length > 160)
            {
                sapoTextBox.Text = sapoTextBox.Text + "Sapo không nhập quá 160 ký tự";
            }
        }

        private void keyLienQuanTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btSaveClose_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        public void Save()
        {
            try
            {
                this.sEOUpdateDateTimePicker.Value = DateTime.Now;
                this.keywordsSeoBindingSource.EndEdit();
                this.keywordsSeoTableAdapter.Update(kW.KeywordsSeo);

                this.keywords_SeoTableAdapter.Insert(
                    _keyHash,
                    this.keyNameLabel1.Text,
                    QT.Entities.Common.Obj2Int(this.keyFreqTextBox.Text),
                    QT.Entities.Common.Obj2Int(this.keyClickTextBox.Text),
                    this.sEOUpdateDateTimePicker.Value,
                    this.titleTextBox.Text,
                    this.sapoTextBox.Text,
                    this.keyLienQuanTextBox.Text,
                    QT.Users.User.UserID);
            }
            catch (Exception)
            {
            }
        }
    }
}
