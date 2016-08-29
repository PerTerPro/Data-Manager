using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bussiness;

namespace QT.Users
{
    public partial class frmResetPass : Form
    {
        public frmResetPass()
        {
            InitializeComponent();
        }
        private bool _changePass = false;
        public frmResetPass(bool changepass)
        {
            InitializeComponent();
            _changePass = changepass;
        }
        public string Pass
        {
            get { return this.txtPassNewsRe.Text.Trim(); }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (_changePass)
            {
                DB.tblUserDataTable dt = new DB.tblUserDataTable();
                DBTableAdapters.tblUserTableAdapter adt = new DBTableAdapters.tblUserTableAdapter();
                adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
                adt.FillBy_UserPass(dt, User.UserName, CryptoWSS.Encrypt(txtPassOld.Text.Trim()));
                if (dt.Rows.Count > 0)
                {
                    if (txtPassNewsRe.Text.Trim() == this.txtPassNews.Text.Trim())
                    {
                        adt.UpdateQuery_Pass(CryptoWSS.Encrypt(txtPassNewsRe.Text.Trim()), QT.Entities.Common.Obj2Int(dt.Rows[0]["ID"].ToString()));
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không đúng, nhập lại");
                        txtPassNewsRe.Text = "";
                        txtPassNews.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng");
                    txtPassOld.Focus();
                }
                adt.Dispose();
                dt.Dispose();
            }
            else
            {
                if (txtPassNewsRe.Text.Trim() == this.txtPassNews.Text.Trim())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng, nhập lại");
                    txtPassNewsRe.Text = "";
                    txtPassNews.Text = "";
                }
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmResetPass_Load(object sender, EventArgs e)
        {
            if (_changePass)
            {
                this.laPassOld.Visible = true;
                this.txtPassOld.Visible = true;
                //this.label1.Text = "Mật khẩu mới:";
                laUser.Visible = true;
                laUser.Text = "User name: " + User.UserName;
            }
        }
    }
}
