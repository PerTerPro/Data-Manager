using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void btnConvertProductToRoot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmGetProductFromSolr)
                {
                    var f = (frmGetProductFromSolr)child;
                    if (f.Text == "Get RootProduct")
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
                    var frm = new frmGetProductFromSolr();
                    frm.MdiParent = this;
                    frm.Text = "Get RootProduct";
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
