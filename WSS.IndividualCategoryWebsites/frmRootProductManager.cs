using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities;

namespace WSS.IndividualCategoryWebsites
{
    public partial class frmRootProductManager : Form
    {
        private int _websiteId;
        private string _domain;
        public frmRootProductManager()
        {
            InitializeComponent();
        }
        public frmRootProductManager(int websiteId, string domain)
        {
            InitializeComponent();
            _websiteId = websiteId;
            _domain = domain;
        }
        private void frmRootProductManager_Load(object sender, EventArgs e)
        {
            rootProductsTableAdapter.Connection.ConnectionString = WssConnection.ConnectionIndividual;
            try
            {
                rootProductsTableAdapter.FillByWebsiteId(dBIndi.RootProducts, _websiteId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Load RootProduct Error: " + ex.Message);
            }
        }
    }
}
