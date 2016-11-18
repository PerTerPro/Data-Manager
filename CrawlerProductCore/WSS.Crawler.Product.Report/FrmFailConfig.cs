using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmFailConfig : Form{
        public FrmFailConfig()
        {InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();}
        private void RefreshData()
        {this.v_Company_FailConfigTableAdapter.Fill(this.dsQT2.V_Company_FailConfig);
        }
        private void FrmFailConfig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQT2.V_Company_FailConfig' table. You can move, or remove it, as needed.
            this.v_Company_FailConfigTableAdapter.Fill(this.dsQT2.V_Company_FailConfig);

        }
    }
}
