using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;
using QT.Entities;

namespace WSS.ReDownloadImage
{
    public partial class MainDownloadImage : Form
    {
        private string connectionString = "Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
        private string pathImage = "D:\\ImageTemp\\";
        private int maxthread = 20;
        public MainDownloadImage()
        {
            InitializeComponent();
            connectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
            ServerConnection.ConnectionString = connectionString;
            pathImage = ConfigurationSettings.AppSettings["FolderImage"].ToString();
            maxthread = Common.Obj2Int(ConfigurationSettings.AppSettings["MaxThread"].ToString());
            ServerConnection.FolderImage = pathImage;
        }

        private void barButtonItemSingle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool valForm = false;
                foreach (var child in MdiChildren)
                {
                    if (child is frmReDownloadImage)
                    {
                        var f = (frmReDownloadImage)child;

                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
                if (!valForm)
                {
                    try
                    {
                        frmReDownloadImage frm = new frmReDownloadImage();
                        frm.MdiParent = this;
                        frm.Show();
                        frm.RunDownload();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void barButtonItemProcessAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < maxthread; i++)
            {
                try
                {
                    frmReDownloadImage frm = new frmReDownloadImage();
                    frm.MdiParent = this;
                    frm.Show();
                    frm.RunDownload();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void barButtonItemUpdateImagePath_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < maxthread; i++)
            {
                try
                {
                    frmUpdateImagePathCompany frm = new frmUpdateImagePathCompany();
                    frm.MdiParent = this;
                    frm.Show();
                    frm.Run();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void barButtonItemUpdateImagePathSingle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmUpdateImagePathCompany frm = new frmUpdateImagePathCompany();
                frm.MdiParent = this;
                frm.Show();
                frm.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
