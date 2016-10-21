using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.WebMerchantSupport
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            WebMerchantConnection.WebMerchantConnectionString = ConfigurationManager.AppSettings["WebMerchantConnection"];
            WebMerchantConnection.WssConnectioString = ConfigurationManager.AppSettings["WssConnection"];
            ctrWebMerchant1.Init();
        }

        private void ctrWebMerchant1_ExcuteCommand(WebMerchantCommon.ListCommand command, EventArgs e)
        {
            switch (command)
            {
                case WebMerchantCommon.ListCommand.ChangeProduct:
                    ChangeProduct(ctrWebMerchant1.GetWebIdCurrent(), ctrWebMerchant1.GetDomainCurrent());
                    break;
            }
        }

        private void ChangeProduct(int WebId, string Domain)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmWebMerchantProduct)
                {
                    var f = (frmWebMerchantProduct)child;
                    if (f.Text == (@"Change product for website: " + Domain))
                    {
                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
            }
            if (!valForm)
            {
                try
                {
                    var frm = new frmWebMerchantProduct(WebId, Domain)
                    {
                        MdiParent = this,
                        Text = @"Change product for website: " + Domain
                    };
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
