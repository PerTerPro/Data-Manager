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
using WSS.Product.SetPromotionAndPriceManual.Promotion;

namespace WSS.Product.SetPromotionAndPriceManual
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            ConnectionCommon.ConnectionProduct = ConfigurationSettings.AppSettings["ConnectionString"];
            ConnectionCommon.ConnectionLogProduct = ConfigurationSettings.AppSettings["LogConnectionString"];
        }

        private void barButtonItemPromotionSingleProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmPromotionSingleProduct)
                {
                    var f = (FrmPromotionSingleProduct)child;
                    if (f.Text == @"Promotion Single Product")
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
                    var frm = new FrmPromotionSingleProduct() { MdiParent = this, Text = @"Promotion Single Product" };
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonItemPromotionListProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmPromotionListProduct)
                {
                    var f = (FrmPromotionListProduct)child;
                    if (f.Text == @"Promotion List Product")
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
                    var frm = new FrmPromotionListProduct() { MdiParent = this, Text = @"Promotion List Product" };
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
