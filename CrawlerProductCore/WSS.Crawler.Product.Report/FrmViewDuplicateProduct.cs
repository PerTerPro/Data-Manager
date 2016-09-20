using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Moduls.CrawlerProduct.Cache;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmViewDuplicateProduct : Form
    {
        readonly CacheDuplicateProduct _cacheDuplicateProduct = CacheDuplicateProduct.Instance();
        public FrmViewDuplicateProduct()
        {
            InitializeComponent();
        }

        internal void LoadByCompany(long company)
        {
            this.gridControl1.DataSource = _cacheDuplicateProduct.GetAllDuplicateOfCompany(company);
        }
    }
}
