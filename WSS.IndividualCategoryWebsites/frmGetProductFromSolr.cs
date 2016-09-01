using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Websosanh.Core.Drivers.Solr;
using WSS.IndividualCategoryWebsites.SolrProduct;

namespace WSS.IndividualCategoryWebsites
{
    public partial class frmGetProductFromSolr : Form
    {
        private SolrProductClient solrProductClient;
        public frmGetProductFromSolr()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            solrProductClient = SolrProductClient.GetClient(SolrClientManager.GetSolrClient("solrProducts"));
        }
        private void btnGetListProductFromSolr_Click(object sender, EventArgs e)
        {
            var limitResult = Convert.ToInt32(txtLimitResult.Text);
            var listKeywords = rbKeywords.Text.Split(SolrProductConstants.IGNORE_CHARS.ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries).ToList();
            int numberFound = 0;
            var result = solrProductClient.GetListProducts(listKeywords, 0, limitResult, out numberFound);
            var jsonobject = JsonConvert.SerializeObject(result);
            rbKeywords.Text = jsonobject;gridControl1.DataSource = result;
            txtNumberFound.Text = numberFound.ToString();}
    }
}
