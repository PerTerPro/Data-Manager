using QT.Entities;
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
    public partial class FrmCurrentCrawlerProduct : Form
    {
        public FrmCurrentCrawlerProduct()
        {
            InitializeComponent();
        }

        private void btnReloadData_Click(object sender, EventArgs e)
        {
            var a =  RedisCacheCurrentCrawlerCompany.Instance().GetAllCurrentRunning();
            this.gridControl1.DataSource = a;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
