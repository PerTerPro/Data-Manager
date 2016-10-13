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

namespace WSS.IndividualCategoryWebsites
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            WssConnection.ConnectionIndividual = ConfigurationSettings.AppSettings["ConnectionIndividual"];
            WssConnection.ConnectionProduct = ConfigurationSettings.AppSettings["ConnectionProduct"];
            ctrlWebsite1.InitControl();
        }
        private void ConvertProductToRoot(int idWebsite, string domain)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmGetProductFromSolr)
                {
                    var f = (frmGetProductFromSolr)child;
                    if (f.Text == (@"Tạo sản phẩm gốc cho website: " + domain))
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
                    var frm = new frmGetProductFromSolr(idWebsite, domain)
                    {
                        MdiParent = this,
                        Text = @"Tạo sản phẩm gốc cho website: " + domain
                    };
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void RootProductManager(int idWebsite, string domain)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmRootProductManager)
                {
                    var f = (frmRootProductManager)child;
                    if (f.Text == @"Quản lý RootProduct "+domain)
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
                    var frm = new frmRootProductManager(idWebsite,domain) {MdiParent = this, Text = @"Quản lý RootProduct "+domain};
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void ctrlWebsite1_ExcuteCommand(WssCommon.ListWebCommand command, EventArgs e)
        {
            bool valForm = false;
            switch (command)
            {
                case WssCommon.ListWebCommand.IndividualWebsitesProduct:
                    ConvertProductToRoot(ctrlWebsite1.GetIdCurrent(),ctrlWebsite1.GetDomainCurrent());
                    break;
                case WssCommon.ListWebCommand.IndividualWebsitesRootProductAnalyzed:
                    RootProductManager(ctrlWebsite1.GetIdCurrent(), ctrlWebsite1.GetDomainCurrent());
                    break;
                case WssCommon.ListWebCommand.ViewTagInWebsites:
                    ViewTagInWebsites(ctrlWebsite1.GetIdCurrent(), ctrlWebsite1.GetDomainCurrent());
                    break;
            }
        }

        private void ViewTagInWebsites(int getIdCurrent, string getDomainCurrent)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmAddTagsWebsites)
                {
                    var f = (frmAddTagsWebsites)child;
                    if (f.Text == @"Add Tag "+getDomainCurrent)
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
                    var frm = new frmAddTagsWebsites(getIdCurrent,getDomainCurrent) { MdiParent = this, Text = @"Add Tag " + getDomainCurrent };
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
