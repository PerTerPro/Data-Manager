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
using Websosanh.Core.Drivers.Solr;
using WSS.IndividualCategoryWebsites.SolrRootProduct;

namespace WSS.IndividualCategoryWebsites
{
    public partial class frmRootProductManager : Form
    {
        private int _websiteId;
        private string _domain;
        private SolrRootProductClient _solrRootProductClient;
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

        private void InitSolr()
        {
            _solrRootProductClient =
                SolrRootProductClient.GetClient(SolrClientManager.GetSolrClient("solrRootProducts"));
        }
        private void frmRootProductManager_Load(object sender, EventArgs e)
        {
            InitSolr();
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

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            var listId = new List<long>();
            foreach (var item in dBIndi.RootProducts)
            {
                listId.Add(item.Id);
            }
            try
            {
                _solrRootProductClient.DeleteByWebsiteId(_websiteId);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
