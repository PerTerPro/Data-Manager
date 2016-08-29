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
    public partial class frmTagByCompany : QT.Entities.frmBase
    {
        #region Constructor
        public frmTagByCompany()
        {
            InitializeComponent();
        }
        #endregion
        #region Data
        private void frmTagByCompany_Load(object sender, EventArgs e)
        {
            this.company_StatusTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.companyTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.tag_ProductTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productStatusTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            InitData();
        }

        private void InitData()
        {
            this.company_StatusTableAdapter.Fill(dBTag.Company_Status);
            this.productStatusTableAdapter.Fill(this.dBTag.ProductStatus);
        }
        #endregion
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textEditDomain.Text))
            {
                string domainsearch = "%" + textEditDomain.Text + "%";
                this.companyTableAdapter.FillBy_LikeDomain(dBTag.Company,domainsearch);
            }
        }

        private void textEditDomain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchButton_Click(null, null);
        }

        private void iDTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            long idproduct = QT.Entities.Common.Obj2Int64(iDTextEditProduct.Text);
            if (idproduct > 0)
            {
                this.tag_ProductTableAdapter.FillBy_ProductID(dBTag.Tag_Product, idproduct);
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

        private void companyGridControl_DoubleClick(object sender, EventArgs e)
        {
            long idcompany = QT.Entities.Common.Obj2Int64(iDTextEditCompany.Text);
            if (idcompany >0)
            {
                this.productTableAdapter.FillBy_CompanyID(dBTag.Product, idcompany);
            }
        }

        private void lookUpEditCompanyStatus_EditValueChanged(object sender, EventArgs e)
        {
            byte status = QT.Entities.Common.Obj2Byte(lookUpEditCompanyStatus.EditValue);
            try
            {
                this.companyTableAdapter.FillBy_Status(dBTag.Company, status);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
           
        }

        private void gridViewCompany_DoubleClick(object sender, EventArgs e)
        {
            long idcompany = QT.Entities.Common.Obj2Int64(iDTextEditCompany.Text);
            if (idcompany > 0)
            {
                this.productTableAdapter.FillBy_CompanyID(dBTag.Product, idcompany);
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        public override bool Save()
        {
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
            return true;
        }
    }
}
