using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities;


namespace WSS.Crl.ProducProperties.Manager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {this.Validate();this.companyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productQT);

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productQT.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.productQT.Company);

        }

        private void companyGridControl_Click(object sender, EventArgs e)
        {
            long companyId = Common.Obj2Int64(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "ID"));
            string domain = Common.Obj2String(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Domain"));

            if (companyId > 0)
            {
                FrmCompanyConfigProperty frm = new FrmCompanyConfigProperty(companyId);
                frm.MdiParent = this;
                frm.Text = domain;
                frm.Name = domain;
                frm.Show();
            }

        }
    }
}
