using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmShowDataTable : Form
    {
        public FrmShowDataTable()
        {
            InitializeComponent();
        }

        public static void ShowData(DataTable tbl)
        {
            FrmShowDataTable frm = new FrmShowDataTable();
            frm.LoadData(tbl);
            frm.ShowDialog();
        }

        private void LoadData(DataTable tbl)
        {
            this.gridControl1.DataSource = tbl;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
