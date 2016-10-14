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
using WSS.Financial.Bank;
using WSS.Financial.BankLending;

namespace WSS.Financial
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
            ctrBank1.InitControl();
        }

        private void barButtonItemBankBlending_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmBankManager)
                {
                    var f = (FrmBankManager)child;
                    if (f.Text == (@"Quản lý ngân hàng"))
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
                    var frm = new FrmBankManager()
                    {
                        MdiParent = this,
                        Text = @"Quản lý ngân hàng"
                    };
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonItemFrmBankLending_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmBankLendingManager)
                {
                    var f = (FrmBankLendingManager)child;
                    if (f.Text == (@"Quản lý các gói vay tiêu dùng của tất cả các ngân hàng"))
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
                    var frm = new FrmBankLendingManager()
                    {
                        MdiParent = this,
                        Text = @"Quản lý các gói vay tiêu dùng của tất cả các ngân hàng"
                    };
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonItemPaymentMethod_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmPaymentMethod)
                {
                    var f = (FrmPaymentMethod)child;
                    if (f.Text == (@"Hình thức trả khoản vay"))
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
                    var frm = new FrmPaymentMethod(){
                        MdiParent = this,
                        Text = @"Hình thức trả khoản vay"
                    };
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void ctrBank1_ExcuteCommand(WssCommon.ListBankCommand command, EventArgs e)
        {
            switch (command)
            {
                case WssCommon.ListBankCommand.ViewInfo:
                    ViewInfo(ctrBank1.GetIdCurrent(),ctrBank1.GetBankCurrent());
                    break;
                case WssCommon.ListBankCommand.ViewBankLending:
                    ViewBankLending(ctrBank1.GetIdCurrent(), ctrBank1.GetBankCurrent());
                    break;
            }
        }

        private void ViewBankLending(int bankId,string bankName)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmBankLendingManager)
                {
                    var f = (FrmBankLendingManager)child;
                    if (f.Text == (@"Quản lý các gói vay tiêu dùng của "+ bankName))
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
                    var frm = new FrmBankLendingManager()
                    {
                        MdiParent = this,
                        Text = @"Quản lý các gói vay tiêu dùng của " + bankName
                    };
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void ViewInfo(int bankId, string bankName)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is FrmBankInfo)
                {
                    var f = (FrmBankInfo)child;
                    if (f.Text == (@"Thông tin của ngân hàng "+bankName))
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
                    var frm = new FrmBankInfo(bankId)
                    {
                        MdiParent = this,
                        Text = @"Thông tin của ngân hàng "+bankName};
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
