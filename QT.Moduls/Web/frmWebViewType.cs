using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QT.Entities;

namespace QT.Moduls.Web
{
    public partial class frmWebViewType : QT.Entities.frmBase
    {
        public frmWebViewType()
        {
            InitializeComponent();
        }

        private void frmWebViewType_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.listClassificationTableAdapter.Connection.ConnectionString = Server.ConnectionString;

            this.listClassificationTableAdapter.FillBy_AllName(this.dBWeb.ListClassification);
        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.productTableAdapter.FillBy_Company_Category(this.dBWeb.Product, Common.GetIDCompany("quangtrung.vn"), Common.Obj2Int(this.iDTextBox.Text));
            this.gridView2.ExpandAllGroups();
        }

        public override bool Save()
        {
            try
            {
                this.productBindingSource.EndEdit();
                this.productTableAdapter.Update(dBWeb.Product);
                this.listClassificationBindingSource.EndEdit();
                this.listClassificationTableAdapter.Update(dBWeb.ListClassification);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
        public override bool RefreshData()
        {
            return base.RefreshData();
        }

    }
}
