using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QT.Users
{
    public partial class frmListUserOfTypeManager : Form
    {
        private int _managerTypeID = 0;
        public frmListUserOfTypeManager(int ManagerTypeID)
        {
            InitializeComponent();
            _managerTypeID = ManagerTypeID;
        }
        public int IDUser = 0;
        private void btLogin_Click(object sender, EventArgs e)
        {
            IDUser = QT.Entities.Common.Obj2Int(this.iDTextBox.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmListUserOfTypeManager_Load(object sender, EventArgs e)
        {
            this.tblUserTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.tblUserTableAdapter.FillBy_IDTypeManager(this.dB.tblUser,_managerTypeID);

        }
    }
}
