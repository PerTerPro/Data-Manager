using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QT.Users
{
    public partial class ctrUserCategory : UserControl
    {
        public ctrUserCategory()
        {
            InitializeComponent();
        }
        public void InitForm(int UserID)
        {
            _idUser = UserID;
            this.listClassificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.user_CategoryTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.listClassificationTableAdapter.Fill(dB.ListClassification);
            this.user_CategoryTableAdapter.FillBy_UserID(dB.User_Category, _idUser);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            this.treeList1.ExpandAll();
        }

        private void btCloseEx_Click(object sender, EventArgs e)
        {
            this.treeList1.CollapseAll();

        }
        private int _idUser=0;
        private void btAddPermision_Click(object sender, EventArgs e)
        {
            this.userCategoryBindingSource.AddNew();
            this.userIDTextBox.Text = _idUser.ToString();
            this.categoryIDTextBox.Text = this.iDListClassificationTextBox.Text;
            this.nameTextBox1.Text = this.nameListClassificationTextBox.Text;
            this.userCategoryBindingSource.EndEdit();
        }

        private void btDeletePermision_Click(object sender, EventArgs e)
        {
            if (this.userCategoryBindingSource.Count > 0)
            {
                this.userCategoryBindingSource.RemoveCurrent();
                this.userCategoryBindingSource.EndEdit();
            }
        }

        private void btSavePermitsion_Click(object sender, EventArgs e)
        {
            this.userCategoryBindingSource.EndEdit();
            this.user_CategoryTableAdapter.Update(dB.User_Category);
            //this.user_CategoryTableAdapter.DeleteQuery_UserID(_idUser);
            //foreach (DB.User_CategoryRow dr in dB.User_Category)
            //{
            //    this.user_CategoryTableAdapter.Insert(_idUser, dr.CategoryID);
            //}
        }

        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            this.userCategoryBindingSource.AddNew();
            this.userIDTextBox.Text = _idUser.ToString();
            this.categoryIDTextBox.Text = this.iDListClassificationTextBox.Text;
            this.nameTextBox1.Text = this.nameListClassificationTextBox.Text;
            this.userCategoryBindingSource.EndEdit();
        }
    }
}
