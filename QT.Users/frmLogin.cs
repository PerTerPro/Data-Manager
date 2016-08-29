using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QT.Entities;

namespace QT.Users
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        DBTableAdapters.tblUserTableAdapter adt = new DBTableAdapters.tblUserTableAdapter();
        DB.tblUserDataTable dt = new DB.tblUserDataTable();
        private void btLogin_Click(object sender, EventArgs e)
        {
           
            try
            {
                String connection = "Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
                //String connectionCrawler = "Data Source=192.168.100.183;Initial Catalog=QTCrawler;Integrated Security=False;User=sa;Password=123";
                //String connectionCrawler = @"Data Source=192.168.100.183;Initial Catalog=SaleNews;Integrated Security=False;User=sa;Password=123";
                String connectionCrawler = "Data Source=172.22.30.82,1452;Initial Catalog=QTCrawler;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
                String logConnection = "Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";

                switch (QT.Entities.Server.ServerRun)
                {
                    case "store":
                        connection = connection.Replace("42.112.28.93", ".");
                        break;
                    case "hvtcphc":
                        logConnection = logConnection.Replace("118.70.205.94", "172.16.34.86");
                        connectionCrawler = connectionCrawler.Replace("118.70.205.94", ".");
                        break;
                    case "hvtcdn":
                        logConnection = logConnection.Replace("118.70.205.94", "10.168.200.86");
                        connectionCrawler = connectionCrawler.Replace("118.70.205.94", "10.168.200.82");
                        break;
                    case "fpt":
                        connection = connection.Replace("42.112.28.93", "172.22.1.82");
                        break;
                    
                }
                QT.Entities.Server.ConnectionString = connection;
                QT.Entities.Server.ConnectionStringCrawler = connectionCrawler;
                QT.Entities.Server.LogConnectionString = logConnection;

                adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
                //adt.FillBy_UserPass(dt, txtUser.Text.Trim(), Common.GetPassWord(txtPass.Text.Trim()));
                adt.FillBy_UserPass(dt, txtUser.Text.Trim(), Bussiness.CryptoWSS.Encrypt(txtPass.Text.Trim()));

                if (dt.Rows.Count > 0)
                {
                    DialogResult = DialogResult.OK;
                    QT.Users.User.UserName = txtUser.Text.Trim();
                    QT.Users.User.UserID = Common.Obj2Int(dt.Rows[0]["ID"].ToString());
                    //Check Quyền
                    DBTableAdapters.User_PermisionTableAdapter userpermisionAdapter = new DBTableAdapters.User_PermisionTableAdapter();
                    userpermisionAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
                    DB.User_PermisionDataTable userpermissionTable = new DB.User_PermisionDataTable();
                    userpermisionAdapter.FillBy_IDUser(userpermissionTable, QT.Users.User.UserID);
                    if (userpermissionTable.Rows.Count > 0)
                    {
                        List<int> listper = new List<int>();
                        for (int i = 0; i < userpermissionTable.Rows.Count; i++)
                        {
                            listper.Add(Common.Obj2Int(userpermissionTable.Rows[i]["IDPermission"].ToString()));
                        }
                        QT.Users.User.PermisionID = listper;
                    }

                    QT.Entities.Server.UserID = QT.Users.User.UserID;
                    //Log đăng nhập
                    LogJobAdapter.SaveLog(JobName.Login, "Đăng nhập Manager", 0,(int)JobTypeData.KhongXacDinh);
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User hoặc mật khẩu không dúng, liên hệ với admin");
                    this.txtUser.Focus();
                    this.txtUser.SelectAll();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không kết nối được, bạn hãy thử kiểm tra lại mạng");
            }
        }


        //private void btLogin_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        ServiceCoreApplication.CoreApplicationClient core = new ServiceCoreApplication.CoreApplicationClient();
        //        UnicodeEncoding unicode = new UnicodeEncoding();
        //        byte[] userb = QT.Entities.Crypto.Encrypt(txtUser.Text.Trim());
        //        byte[] passb = QT.Entities.Crypto.Encrypt(Common.GetPassWord(txtPass.Text.Trim()));
        //        string user = unicode.GetString(userb);
        //        string pass = unicode.GetString(passb);
        //        //String r = core.GetConnection(user, pass);
        //        byte[] conb = core.GetConnection(user, pass);

        //        if (conb != null)
        //        {

        //            //if (QT.Entities.Server.ServerRun.IndexOf("huychu") >= 0)
        //            //{
        //            //    connection = connection.Replace("118.70.205.94", ".");
        //            //}
        //            //if (QT.Entities.Server.ServerRun.IndexOf("hvtc") >= 0)
        //            //{
        //            //    connectionCrawler = connectionCrawler.Replace("118.70.205.94", "10.168.200.82");
        //            //}
        //            //if (QT.Entities.Server.ServerRun.IndexOf("store") >= 0)
        //            //{
        //            //    connectionCrawler = connectionCrawler.Replace("118.70.205.94", "172.16.34.82");
        //            //}
        //            String connection = QT.Entities.Crypto.Decrypt(conb);
        //            byte[] concrawlerb = core.GetConnectionCrawler(user, pass);
        //            String connectionCrawler = QT.Entities.Crypto.Decrypt(concrawlerb);

        //            switch (QT.Entities.Server.ServerRun)
        //            {
        //                case "store":
        //                    connection = connection.Replace("118.70.205.94", ".");
        //                    connectionCrawler = connectionCrawler.Replace("118.70.205.94", "172.16.34.82");
        //                    break;
        //                case "hvtcphc":
        //                    connection = connection.Replace("118.70.205.94", "172.16.34.86");
        //                    connectionCrawler = connectionCrawler.Replace("118.70.205.94", ".");
        //                    break;
        //                case "hvtcdn":
        //                    connection = connection.Replace("118.70.205.94", "10.168.200.86");
        //                    connectionCrawler = connectionCrawler.Replace("118.70.205.94", "10.168.200.82");
        //                    break;
        //            }
        //            QT.Entities.Server.ConnectionString = connection;
        //            QT.Entities.Server.ConnectionStringCrawler = connectionCrawler;


        //            //QT.Entities.Server.ConnectionString = "Data Source=172.16.34.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT";
        //            //QT.Entities.Server.ConnectionStringCrawler = "Data Source=172.16.34.82,1452;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT";



        //            adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;

        //            adt.FillBy_UserPass(dt, txtUser.Text.Trim(), Common.GetPassWord(txtPass.Text.Trim()));
        //            if (dt.Rows.Count > 0)
        //            {
        //                DialogResult = DialogResult.OK;
        //                QT.Users.User.UserName = txtUser.Text.Trim();
        //                QT.Users.User.UserID = Common.Obj2Int(dt.Rows[0]["ID"].ToString());
        //                this.Close();
        //            }
        //            else
        //            {
        //                MessageBox.Show("User hoặc mật khẩu không dúng, liên hệ với admin");
        //                this.txtUser.Focus();
        //                this.txtUser.SelectAll();
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        QT.Entities.Server.ConnectionString = "Data Source=172.16.34.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT";
        //        QT.Entities.Server.ConnectionStringCrawler = "Data Source=172.16.34.82,1452;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT";
        //        MessageBox.Show("Không kết nối được, bạn hãy thử kiểm tra lại mạng");
        //    }
        //}

       /*
        private void btLogin_Click(object sender, EventArgs e)
        {

            try
            {
                QT.Entities.Server.ConnectionString = "Data Source=172.16.34.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT";
                QT.Entities.Server.ConnectionStringCrawler = "Data Source=172.16.34.82,1452;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT";

                adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;

                adt.FillBy_UserPass(dt, txtUser.Text.Trim(), Common.GetPassWord(txtPass.Text.Trim()));
                if (dt.Rows.Count > 0)
                {
                    DialogResult = DialogResult.OK;
                    QT.Users.User.UserName = txtUser.Text.Trim();
                    QT.Users.User.UserID = Common.Obj2Int(dt.Rows[0]["ID"].ToString());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User hoặc mật khẩu không dúng, liên hệ với admin");
                    this.txtUser.Focus();
                    this.txtUser.SelectAll();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không kết nối được, bạn hãy thử kiểm tra lại mạng");
            }
        }
         */
        private void btQuit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //this.txtUser.Text = "admin";
            //this.txtPass.Text = "admin2015";
            //this.btLogin_Click(sender, e);
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
                txtPass.SelectAll();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin.Focus();
                btLogin_Click(sender, e);
            }
        }
    }
}
