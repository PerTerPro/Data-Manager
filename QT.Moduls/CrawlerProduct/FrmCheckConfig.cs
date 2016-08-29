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
    public partial class FrmCheckConfig : Form
    {
        public FrmCheckConfig()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TaskRefreshCheckConfig task = new TaskRefreshCheckConfig();
            task.Start();
        }
    }
}
