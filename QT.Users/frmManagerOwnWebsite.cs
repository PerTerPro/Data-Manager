using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QT.Users
{
    public partial class frmManagerOwnWebsite : QT.Entities.frmBase
    {
        public frmManagerOwnWebsite()
        {
            InitializeComponent();
        }

        private void frmManagerOwnWebsite_Load(object sender, EventArgs e)
        {
            this.companyTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.userPersonTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionStringUser;
            this.webUserTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionStringUser;
            
            this.companyTableAdapter.Fill(this.dB.Company);
            this.userPersonTableAdapter.FillBy_TaiKhoanDaDangKy(this.dBCustomer.UserPerson);
        }

        private void btViewAll_Click(object sender, EventArgs e)
        {
            this.userPersonTableAdapter.Fill(this.dBCustomer.UserPerson);

        }

        private void btViewDangKy_Click(object sender, EventArgs e)
        {
            this.userPersonTableAdapter.FillBy_TaiKhoanDaDangKy(this.dBCustomer.UserPerson);
        }

        private void iDUserTextBox_TextChanged(object sender, EventArgs e)
        {
            int iduser = QT.Entities.Common.Obj2Int(this.iDUserTextBox.Text);
            this.webUserTableAdapter.FillBy_User(this.dBCustomer.WebUser, iduser);
            this.dBCustomer.WebUser.IDUserColumn.DefaultValue = iduser;
        }

        private void gridControl3_DoubleClick(object sender, EventArgs e)
        {
            this.webUserBindingSource.AddNew();
            this.iDWebTextBox.Text = iDCompanyTextBox.Text;
            this.createDateDateTimePicker.Value = DateTime.Now;
            this.webUserBindingSource.EndEdit();
        }
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            //long id = QT.Entities.Common.Obj2Int64(this.iDWebTextBox.Text);
            this.webUserBindingSource.RemoveCurrent();
            this.webUserBindingSource.EndEdit();
        }
        public override bool Save()
        {
            try
            {
                this.webUserBindingSource.EndEdit();
                this.webUserTableAdapter.Update(dBCustomer.WebUser);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        
    }
}
