using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QT.Moduls.ProductID
{
    public partial class frmAddNewClassification : Form
    {
        private long _companyid;
        private long _idclass;
        private bool check = false;
        public frmAddNewClassification(long idcompany)
        {
            InitializeComponent();
            _companyid = idcompany;
            iDCompanyTextEdit.Text = idcompany.ToString();
        }
        private void frmAddNewClassification_Load(object sender, EventArgs e)
        {
            this.listClassificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.classificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            // TODO: This line of code loads data into the 'dBProperties.ListClassification' table. You can move, or remove it, as needed.
            this.listClassificationTableAdapter.Fill(this.dBProperties.ListClassification);
        }

        private void nameTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            _idclass = QT.Entities.Common.GetIDClassification(nameTextEdit.Text);
            iDTextEdit.Text = _idclass.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.classificationBindingSource.EndEdit();
            int categoryid = 0;
            try
            {
                int.TryParse(iDCategoryTreeListLookUpEdit.EditValue.ToString(), out categoryid);
            }
            catch (Exception)
            {
            }
            if (categoryid!=0)
            {
                int i = this.classificationTableAdapter.Insert(_idclass, nameTextEdit.Text, categoryid, _companyid);
                if (i> 0)
                {
                MessageBox.Show("Thêm mới thành công!");
                check = true;
                }
                else
                {
                MessageBox.Show("Xảy ra lỗi!");
                check = false;
                }
            }
            else
            {
                MessageBox.Show("Chọn Category!");
                iDCategoryTreeListLookUpEdit.Focus();
            }   
            
            
        }
        #region delegate
        public delegate void F5(long id);
        public F5 f5;
        #endregion

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if (check)
            {
                long id = QT.Entities.Common.Obj2Int64(iDTextEdit.Text);
                if (f5 != null)
                    f5(id);
                this.Close();
            }
            else
            {
                var result = MessageBox.Show("Chưa thêm mới Classification, Bạn có muốn thoát không?", "Cảnh báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
                else
                    return;
            }
        }
    }
}
