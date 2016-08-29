using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QT.Users
{
    public partial class frmDanhSachQuyen : QT.Entities.frmBase
    {
        public frmDanhSachQuyen()
        {
            InitializeComponent();
        }

        private void frmDanhSachQuyen_Load(object sender, EventArgs e)
        {
            this.permissionTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            RefreshData();
        }
        public override bool Save()
        {
            this.permissionBindingSource.EndEdit();
            this.permissionTableAdapter.Update(dB.Permission);
            return true;
        }
        public override bool RefreshData()
        {
            this.permissionTableAdapter.Fill(this.dB.Permission);
            return true;
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
