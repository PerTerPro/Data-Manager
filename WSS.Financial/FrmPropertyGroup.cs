using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Financial
{
    public partial class FrmPropertyGroup : Form
    {
        public FrmPropertyGroup()
        {
            InitializeComponent();
        }

        private void propertyGroupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.propertyGroupBindingSource.EndEdit();
            this.propertyGroupTableAdapter.Update(this.dBFinancial.PropertyGroup);

        }

        private void FrmPropertyGroup_Load(object sender, EventArgs e)
        {
            categoryTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            this.categoryTableAdapter.Fill(this.dBFinancial.Category);
            propertyGroupTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            this.propertyGroupTableAdapter.Fill(this.dBFinancial.PropertyGroup);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var groupid = Convert.ToInt32(idTextEdit.Text);
            var frm = new FrmProperty(groupid);
            frm.Show();
        }
    }
}
