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

        private void barButtonItemUploadListLogo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmUpLoadListLogo)
                {
                    var f = (FrmUpLoadListLogo)child;
                    if (f.Text == @"Upload List Logo")
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
                    var frm = new FrmUpLoadListLogo() { MdiParent = this, Text = @"Upload List Logo" };
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonItemDownloadImageCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmDownloadImageWithCompany)
                {
                    var f = (FrmDownloadImageWithCompany)child;
                    if (f.Text == @"Download with Company")
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
                    var frm = new FrmDownloadImageWithCompany() { MdiParent = this, Text = @"Download with Company" };
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonItemDownloadProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmDownloadImageProduct)
                {
                    var f = (FrmDownloadImageWithCompany)child;
                    if (f.Text == @"Download image product")
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
                    var frm = new FrmDownloadImageProduct() { MdiParent = this, Text = @"Download image product" };
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonItemPushMessage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmPushMessageDownloadImageCompany)
                {
                    var f = (FrmPushMessageDownloadImageCompany)child;
                    if (f.Text == @"Push mesage Download image product")
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
                    var frm = new FrmPushMessageDownloadImageCompany() { MdiParent = this, Text = @"Push mesage Download image product" };
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
