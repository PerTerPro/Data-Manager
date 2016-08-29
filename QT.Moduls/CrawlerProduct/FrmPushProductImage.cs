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
    public partial class FrmPushProductImage : Form
    {
        List<long> lstProductID = new List<long>();
        ProductAdapter ProductAdapter = new ProductAdapter(new Entities.Data.SqlDb(QT.Entities.Server.ConnectionString));
        public FrmPushProductImage()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
           

            MessageBox.Show("Pushed:" + lstProductID.Count.ToString());
        }
    }
}
