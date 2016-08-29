using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlSale
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            MySqlAdapterRaoVat mySqlDb = new MySqlAdapterRaoVat();
            this.gridControl1.DataSource = mySqlDb.GetTableCategories();
        }
    }
}
