using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.Company
{
    public partial class FrmPublicProduct : Form
    {
        long _companyID = 0;
        int PageSize = 20;
        int PageIndex = 1;
        long ProductCount = 0;
        int PageCount = 0;
        public FrmPublicProduct(long CompanyID)
        {
            InitializeComponent();
            _companyID = CompanyID;
        }

        private void FrmPublicProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            int.TryParse(cboPageSize.Text, out PageSize);
            int.TryParse(txtPageIndex.Text, out PageIndex);
            this.productTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productTableAdapter.FillBy_BlackListPage(dBCom.Product, _companyID, PageIndex, PageSize);
            ProductCount = long.Parse((this.productTableAdapter.Count_Product(_companyID)).ToString());
            PageCount = (int)ProductCount / int.Parse(cboPageSize.Text) + 1;
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.Validate();
            this.productBindingSource.EndEdit();
            this.productTableAdapter.Update(dBCom.Product);
            //this.tableAdapterManager.UpdateAll(this.dBCom);
        }

        private void cboPageSize_EditValueChanged(object sender, EventArgs e)
        {
            cboPageSize.Text = cboPageSize.EditValue.ToString();
            LoadData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            PageIndex = 1;
            txtPageIndex.EditValue = PageIndex;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (PageIndex <= 1)
            {
                PageIndex = 1;
            }
            else
            {
                PageIndex--;
                txtPageIndex.EditValue = PageIndex;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if (PageIndex < PageCount)
            {
                PageIndex++;
                txtPageIndex.EditValue = PageIndex;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            PageIndex = PageCount;
            txtPageIndex.EditValue = PageIndex;
        }

        private void txtPageIndex_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
