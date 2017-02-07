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
    public partial class FrmHotProduct : Form
    {
        private long companyId;

        public FrmHotProduct()
        {
            InitializeComponent();
        }

        public FrmHotProduct(long p)
        {
            // TODO: Complete member initialization
            this.companyId = p;
            InitializeComponent();
            this.product_HotTableAdapter.FillByCompanyID(this.dB.Product_Hot, this.companyId);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.product_HotTableAdapter.Fill(this.dB.Product_Hot);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
