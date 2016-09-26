using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmCrawlerPriority : Form
    {
        CancellationTokenSource _sourceToken = new CancellationTokenSource();

        public FrmCrawlerPriority()
        {
            InitializeComponent();
        }

        private void FrmCrawlerPriority_Load(object sender, EventArgs e)
        {

        }

        private void FrmCrawlerPriority_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void btnAddThreadRun_Click(object sender, EventArgs e)
        {

        }
    }
}
