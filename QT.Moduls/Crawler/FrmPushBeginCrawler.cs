using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.CrawlerSale.Manager
{
    public partial class FrmPushBeginCrawler : Form
    {
        public delegate bool EventSuccessJob(FrmPushBeginCrawler frm);
        public EventSuccessJob eventSuccessJob;

        public FrmPushBeginCrawler()
        {
            InitializeComponent();
        }

        private void FrmPushBeginCrawler_Load(object sender, EventArgs e)
        {
            this.cboTypeCrawl.SelectedIndex = 1;
            this.cboTypeCrawl.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.eventSuccessJob == null)
            {
                this.Close();
            }
            else
            {
                if (eventSuccessJob(this))
                {
                    this.Close();
                }
            }
        }
    }
}
