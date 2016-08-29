using QT.Entities.Data;
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
    public partial class FrmViewIsNewNotShowInCompany : Form
    {
        ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));

        public FrmViewIsNewNotShowInCompany()
        {
            InitializeComponent();
        }

        private void btnReloadData_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void ReloadData()
        {
            
        }
    }
}
