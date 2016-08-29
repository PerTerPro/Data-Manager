using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QT.Entities;

namespace QT.Users
{
    public partial class frmUserManager : QT.Entities.frmBase
    {
        public frmUserManager()
        {
            InitializeComponent();
        }

        public override bool RefreshData()
        {
            try
            {
                this.tblUserTableAdapter.Fill(this.dB.tblUser);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public override bool Save()
        {
            try
            {
                this.tblUserBindingSource.EndEdit();
                this.tblUserTableAdapter.Update(dB.tblUser);

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        private void frmUserManager_Load(object sender, EventArgs e)
        {
            this.permissionTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.user_PermisionTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.managerTypeTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.managerTypeRUserTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.tblUserTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.tblUserTableAdapter.Fill(this.dB.tblUser);
            this.managerTypeTableAdapter.Fill(this.dB.ManagerType);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            frmResetPass frm = new frmResetPass();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.passwordTextBox.Text = Bussiness.CryptoWSS.Encrypt(frm.Pass.ToString().Trim());
            }
            frm.Dispose();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void iDUserTextBox_TextChanged(object sender, EventArgs e)
        {
            this.managerTypeRUserTableAdapter.FillBy_UserID(dB.ManagerTypeRUser, Common.Obj2Int(this.iDUserTextBox.Text));
            this.ctrUserCategory1.InitForm(Common.Obj2Int(this.iDUserTextBox.Text));

            this.user_PermisionTableAdapter.FillBy_IDUser(dB.User_Permision, Common.Obj2Int(this.iDUserTextBox.Text));
            this.permissionTableAdapter.FillBy_ChuaDuocPhanQuyen(dB.Permission, Common.Obj2Int(this.iDUserTextBox.Text));
        }

        private void btSavePermitsion_Click(object sender, EventArgs e)
        {
            try
            {
                this.managerTypeRUserBindingSource.EndEdit();
                this.managerTypeRUserTableAdapter.Update(dB.ManagerTypeRUser);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btDeletePermision_Click(object sender, EventArgs e)
        {
            this.managerTypeRUserBindingSource.RemoveCurrent();
            this.managerTypeRUserBindingSource.EndEdit();
        }

        private void btAddPermision_Click(object sender, EventArgs e)
        {
            this.managerTypeRUserBindingSource.AddNew();
            this.iDUserRTextBox.Text = this.iDUserTextBox.Text;
            this.iDTypeRTextBox.Text = this.iDTypeAddTextBox.Text;
            this.nameTypeRTextBox.Text = this.nameTypeAddTextBox.Text;
            this.sTTRTextBox.Text = this.sTTAddTextBox.Text;
            this.managerTypeRUserBindingSource.EndEdit();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            //loại những thằng trùng đi
            this.managerTypeTableAdapter.Fill(this.dB.ManagerType);
            this.managerTypeRUserBindingSource.MoveFirst();
            for (int j = 0; j < this.managerTypeRUserBindingSource.Count; j++)
            {
                this.managerTypeBindingSource.MoveFirst();
                for (int i = 0; i < this.managerTypeBindingSource.Count; i++)
                {
                    if (this.iDTypeRTextBox.Text == this.iDTypeAddTextBox.Text)
                    {
                        this.managerTypeBindingSource.RemoveCurrent();
                        break;
                    }
                    this.managerTypeBindingSource.MoveNext();
                }
                this.managerTypeRUserBindingSource.MoveNext();
            }
        }


        private void btXoaQuyen_Click(object sender, EventArgs e)
        {
            if (this.userPermisionBindingSource.Count > 0)
            {
                this.user_PermisionTableAdapter.DeleteQuery(Common.Obj2Int(this.iDUser_PermistionTextBox.Text));
                this.userPermisionBindingSource.RemoveCurrent();
                this.permissionTableAdapter.FillBy_ChuaDuocPhanQuyen(dB.Permission, Common.Obj2Int(this.iDUserTextBox.Text));
            }
        }

        private void btGanQuyen_Click(object sender, EventArgs e)
        {
            if (this.permissionBindingSource.Count > 0)
            {
                this.user_PermisionTableAdapter.Insert(
                    Common.Obj2Int(this.iDUserTextBox.Text),
                    Common.Obj2Int(this.iDPermitsionTextBox.Text));
                this.permissionBindingSource.RemoveCurrent();
                this.user_PermisionTableAdapter.FillBy_IDUser(dB.User_Permision, Common.Obj2Int(this.iDUserTextBox.Text));
            }
        }

        private void btTaiLaiPhanQuyen_Click(object sender, EventArgs e)
        {
            this.user_PermisionTableAdapter.FillBy_IDUser(dB.User_Permision, Common.Obj2Int(this.iDUserTextBox.Text));
            this.permissionTableAdapter.FillBy_ChuaDuocPhanQuyen(dB.Permission, Common.Obj2Int(this.iDUserTextBox.Text));
        }
    }
}
