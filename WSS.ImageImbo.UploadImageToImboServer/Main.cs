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
using WSS.ImageImbo.UploadImageToImboServer.Websosanh;

namespace WSS.ImageImbo.UploadImageToImboServer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            ConnectionCommon.ConnectionWebsosanh = ConfigurationSettings.AppSettings["ConnectionWebsosanh"];
        }

        private void barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmUploadLogoWebsosanh)
                {
                    var f = (FrmUploadLogoWebsosanh)child;
                    if (f.Text == @"Upload Logo")
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
                    var frm = new FrmUploadLogoWebsosanh() { MdiParent = this, Text = @"Upload Logo" };
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
