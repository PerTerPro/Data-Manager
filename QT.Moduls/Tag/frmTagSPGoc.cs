using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.Tag
{
    public partial class frmTagSPGoc : QT.Entities.frmBase
    {
        public frmTagSPGoc()
        {
            InitializeComponent();
        }

        private void frmTagSPGoc_Load(object sender, EventArgs e)
        {
            this.listClassificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.tag_CategoryTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.tag_ProductTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productStatusTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            InitData();
        }
        private void InitData()
        {
            this.listClassificationTableAdapter.Fill(this.dBTag.ListClassification);
            // TODO: This line of code loads data into the 'dBTag.ProductStatus' table. You can move, or remove it, as needed.
            this.productStatusTableAdapter.Fill(this.dBTag.ProductStatus);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        public override bool Save()
        {
            try
            {
                if (!string.IsNullOrEmpty(tagRichTextBoxCategory.Text))
                {
                    #region Save Tag Category
                    int categoryid = QT.Entities.Common.Obj2Int(categoryIDTextEdit.Text);
                    string tagcategory = string.Empty;
                    tagcategory = tagRichTextBoxCategory.Text.Replace("\n","|").Trim();
                    if (checkEditCategory.Checked)
                    {
                        try
                        {
                            this.tag_CategoryTableAdapter.UpdateByCategoryID(tagcategory, DateTime.Now, categoryid);
                            tagRichTextBoxCategory.Text = tagcategory;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR " + ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            this.tag_CategoryTableAdapter.Insert(categoryid, tagcategory, DateTime.Now);
                            tagRichTextBoxCategory.Text = tagcategory;
                            checkEditCategory.Checked = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR " + ex.Message);
                        }
                    }
                    #endregion
                }

                if (!string.IsNullOrEmpty(tagRichTextBoxProduct.Text))
                {
                    #region Save Tag Product
                    long productid = QT.Entities.Common.Obj2Int64(productIDTextEdit.Text);
                    string tagproduct = tagRichTextBoxProduct.Text.Replace("\n", "|").Trim();
                    if (checkEditProduct.Checked)
                    {
                        try
                        {
                            this.tag_ProductTableAdapter.UpdateByProductID(tagproduct, DateTime.Now, productid);
                            tagRichTextBoxProduct.Text = tagproduct;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR " + ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            this.tag_ProductTableAdapter.Insert(productid, tagproduct, DateTime.Now);
                            tagRichTextBoxProduct.Text = tagproduct;
                            checkEditProduct.Checked = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR " + ex.Message);
                        }
                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
            return true;
        }

        private void iDTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            int categoryID = QT.Entities.Common.Obj2Int(iDTextEdit.Text);
            if (categoryID > 0)
            {
                this.tag_CategoryTableAdapter.FillBy_CategoryID(dBTag.Tag_Category, categoryID);
                if (dBTag.Tag_Category.Rows.Count > 0)
                {
                    checkEditCategory.Checked = true;
                }
                else
                {
                    categoryIDTextEdit.Text = iDTextEdit.Text;
                    checkEditCategory.Checked = false;
                }
                //this.dBTag.Tag_Category.Columns["CategoryID"].DefaultValue = categoryID;
                //this.dBTag.Tag_Category.Columns["LastUpdate"].DefaultValue = DateTime.Now;
            }
        }

        private void toolStripButtonLoadCat_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = ProductTab;

            int categoryID = QT.Entities.Common.Obj2Int(iDTextEdit.Text);
            if (categoryID > 0)
	        {

		        string categorysearch =string.Format("c{0}_", categoryID.ToString("D3"));
                try
                {
                    this.productTableAdapter.FillBy_SPGocByCategory(dBTag.Product, categorysearch);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR "+ex.Message);
                }
	        }
            
        }

        private void toolStripButtonLoadAllSPGoc_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = ProductTab;
            try
            {
                this.productTableAdapter.FillBy_AllSPGoc(dBTag.Product);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
        }

        private void iDTextEditProduct_EditValueChanged(object sender, EventArgs e)
        {
            long productID = QT.Entities.Common.Obj2Int64(iDTextEditProduct.Text);
            if (productID > 0)
	        {
                this.tag_ProductTableAdapter.FillBy_ProductID(dBTag.Tag_Product, productID);
                if (dBTag.Tag_Product.Rows.Count > 0)
                {
                    checkEditProduct.Checked = true;
                }
                else
                {
                    checkEditProduct.Checked = false;
                    productIDTextEdit.Text = iDTextEditProduct.Text;
                }
	        }
        }
    }
}
