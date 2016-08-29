using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cassandra;
using QT.Entities;
using Configuration = QT.Entities.Configuration;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmShowDetailProduct : Form
    {
        private static FrmShowDetailProduct frmShow = new FrmShowDetailProduct();

        public void ShowData(string strData)
        {
            richTextBox1.Text = strData;
        }

        public FrmShowDetailProduct()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FrmShowDetailProduct_Load(object sender, EventArgs e)
        {

        }

       

        public static void ShowProduct(long CompanyId)
        {
            Entities.Company company = new Entities.Company(CompanyId);
            Configuration config = new Configuration(CompanyId);
            ProductParse pp = new ProductParse();
            ProductEntity product = new ProductEntity();
            string detailUrl = config.LinkTest;
            GABIZ.Base.HtmlAgilityPack.HtmlDocument document = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            pp.Analytics(product, document, config.LinkTest, config, config.Domain);
            string strDataShow = "";
            strDataShow += string.Format("\r\n Name: {0}", product.Name);
            frmShow.Visible = true;
            frmShow.Show();
        }
    }
}
