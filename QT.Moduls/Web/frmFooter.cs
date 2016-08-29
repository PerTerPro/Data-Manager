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
    public partial class frmFooter : QT.Entities.frmBase
    {
        public frmFooter()
        {
            InitializeComponent();
        }

        public override bool Save()
        {
            try
            {
                tableAdapterManager.UpdateAll(dBWeb);
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }
        public override bool RefreshData()
        {
            try
            {
                this.footerTypeTableAdapter.Fill(this.dBWeb.FooterType);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            return base.RefreshData();
        }
        private void frmFooter_Load(object sender, EventArgs e)
        {
            this.footerTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.footerTypeTableAdapter.Connection.ConnectionString = Server.ConnectionString;

            RefreshData();
            this.dBWeb.Footer.IsActiveColumn.DefaultValue = true;
            this.dBWeb.FooterType.IsActiveColumn.DefaultValue = true;
        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.iDTextBox.Text.Trim() != "")
            {
                this.dBWeb.Footer.TypeColumn.DefaultValue = this.iDTextBox.Text;
                try
                {
                    this.footerTableAdapter.FillBy_Type(this.dBWeb.Footer, Common.Obj2Int(this.iDTextBox.Text));
                }
                catch (Exception)
                {
                }
            }
        }

        private void btViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.footerTableAdapter.Fill(this.dBWeb.Footer);
            }
            catch (Exception)
            {
            }
        }
    }
}
