using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QT.Entities;

namespace QT.Moduls.Company
{
    public partial class frmChonNhomQuanLy : Form
    {
        public frmChonNhomQuanLy()
        {
            InitializeComponent();
        }

        private void frmChonNhomQuanLy_Load(object sender, EventArgs e)
        {
            this.managerTypeTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            if (QT.Users.User.UserName == "admin")
            {
                this.managerTypeTableAdapter.Fill(this.dBCom.ManagerType);
            }
            else
            {
                this.managerTypeTableAdapter.FillBy_UserID(this.dBCom.ManagerType, QT.Users.User.UserID);
            }

        }
        public int IDManager
        {
            set{}
            get
            {
                return Common.Obj2Int(this.iDTextBox.Text);
            }
        }
        public string NameTypeManager {
            set { }
            get { return this.nameLabel1.Text; }
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
