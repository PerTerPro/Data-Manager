using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bussiness;
using QT.Entities;

namespace QT.Moduls.ProductID
{
    public partial class frmAddNewProduct : Form
    {
        public frmAddNewProduct()
        {
            InitializeComponent();
        }
        private int _catID = 0;
        public frmAddNewProduct(int catID)
        {
            InitializeComponent();
            _catID = catID;
        }
        private void frmAddNewProduct_Load(object sender, EventArgs e)
        {
            this.keySearchTextEdit.EditValue = "";
            this.listClassificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.listClassificationTableAdapter.Fill(this.dBProperties.ListClassification);
            productBindingSource.AddNew();
            this.categoryIDComboBox.SelectedValue = _catID;
            this.companyTextBox.Text = QT.Entities.Common.GetIDCompany("quangtrung.vn").ToString();
            this.statusTextBox.Text = "11";
            this.validCheckBox.Checked = false;
            this.contentFTTextEdit.Text = this.keySearchTextEdit.Text;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.productBindingSource.EndEdit();
            this.productTableAdapter.Update(dBProperties.Product);
            DialogResult = DialogResult.OK;
            long idProduct = QT.Entities.Common.Obj2Int64(iDTextBox.Text);
            LogJobAdapter.SaveLog(JobName.FrmEditeProductByCat_Them_moi_san_pham_goc, "Thêm mới sản phẩm gốc bằng tay!", idProduct, (int)JobTypeData.Product);
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.iDTextBox.Text = QT.Entities.Common.GetID_ProductID(summaryTextBox.Text, _catID).ToString();
            this.summaryTextBox.Text = nameTextBox.Text;
            this.nameFTTextBox.Text = QT.Entities.Common.UnicodeToKoDauFulltext(nameTextBox.Text).ToString();
        }

        private void categoryIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void keySearchTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.contentFTTextEdit.Text = this.keySearchTextEdit.Text;
        }

        private void keySearchTextEdit_TextChanged(object sender, EventArgs e)
        {
            this.contentFTTextEdit.Text = this.keySearchTextEdit.Text;
        }
    }
}
