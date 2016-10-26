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
using WSS.Financial.Backend.Brand;

namespace WSS.Financial.Backend
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            WssConnectionFinancial.ConnectionFinancial = ConfigurationSettings.AppSettings["ConnectionFinancial"];
            ctrBrand1.InitControl();
        }

        private void barButtonItemPaymentMethod_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmPropertyGroup)
                {
                    var f = (FrmPropertyGroup)child;
                    if (f.Text == (@"Nhập thuộc tính chung (PropertyGroup)"))
                    {
                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
            }
            if (!valForm){
                try
                {
                    var frm = new FrmPropertyGroup()
                    {
                        MdiParent = this,
                        Text = @"Nhập thuộc tính chung (PropertyGroup)"
                    };
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonItemCategoryManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmCategory)
                {
                    var f = (FrmCategory)child;
                    if (f.Text == (@"Quản lý Category"))
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
                    var frm = new FrmCategory()
                    {
                        MdiParent = this,
                        Text = @"Quản lý Category"
                    };
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonItemPropertyByCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmPropertyByCategory)
                {
                    var f = (FrmPropertyByCategory)child;
                    if (f.Text == (@"Quản lý các thuộc tính theo category"))
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
                    var frm = new FrmPropertyByCategory()
                    {
                        MdiParent = this,
                        Text = @"Quản lý các thuộc tính theo category"
                    };
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonItemPropertyValue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmPropertyValue)
                {
                    var f = (FrmPropertyValue)child;
                    if (f.Text == (@"Nhập giá trị thuộc tính"))
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
                    var frm = new FrmPropertyValue()
                    {
                        MdiParent = this,
                        Text = @"Nhập giá trị thuộc tính"};
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void ctrBrand1_ExcuteCommand(WssCommon.ListBrandCommand command, EventArgs e)
        {
            switch (command)
            {
                case WssCommon.ListBrandCommand.ViewInfo:
                    //ViewInfo(ctrBank1.GetIdCurrent(), ctrBank1.GetBankCurrent());
                    break;
                case WssCommon.ListBrandCommand.ViewItemManager:
                    ViewItemOfBrand(ctrBrand1.GetIdCurrent(), ctrBrand1.GetBrandCurrent());
                    break;
            }
        }

        private void ViewItemOfBrand(int brandIdCurrent, string brandCurrent)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmItemInBrand)
                {
                    var f = (FrmItemInBrand)child;
                    if (f.Text == (@"Item of Brand " + brandCurrent))
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
                    var frm = new FrmItemInBrand(brandIdCurrent)
                    {
                        MdiParent = this,
                        Text = @"Item of Brand " + brandCurrent
                    };
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonItemBrandManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmBrandManager)
                {
                    var f = (FrmBrandManager)child;
                    if (f.Text == (@"Quản lý Brand"))
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
                    var frm = new FrmBrandManager()
                    {
                        MdiParent = this,
                        Text = @"Quản lý Brand"
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
