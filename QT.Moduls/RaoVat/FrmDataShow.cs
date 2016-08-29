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
    public partial class FrmDataShow : Form
    {
        public FrmDataShow()
        {
            InitializeComponent();
        }

        public FrmDataShow(string strData)
        {
            InitializeComponent();
            this.richTextBox1.Text = strData;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
