using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using QT.Entities;
using Websosanh.Core.Drivers.Solr;
using WSS.IndividualCategoryWebsites.SolrRootProduct;

namespace WSS.IndividualCategoryWebsites
{
    public partial class frmAddTagsWebsites : Form
    {
        private string _domainCurrent;
        private int _idWebsite;
        private static readonly ILog Log = LogManager.GetLogger(typeof(frmAddTagsWebsites));
        private SolrRootProductClient _solrRootProductClient;
        public frmAddTagsWebsites()
        {
            InitializeComponent();
        }
        public frmAddTagsWebsites(int getIdCurrent, string getDomainCurrent)
        {
            InitializeComponent();
            _idWebsite = getIdCurrent;
            _domainCurrent = getDomainCurrent;
        }
        private void frmAddTagsWebsites_Load(object sender, EventArgs e)
        {
            this.tagsTableAdapter.Connection.ConnectionString = WssConnection.ConnectionIndividual;
            _solrRootProductClient =
                SolrRootProductClient.GetClient(SolrClientManager.GetSolrClient("solrRootProducts"));
        }

        private void InitDataSql(string tag)
        {
            try
            {
                tagsTableAdapter.FillByTag(dBIndi.Tags, tag);
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("Tag: {0} . {1}",tag,exception));
            }
        }
        private void InitDataSolr(string tag)
        {
            try
            {
                var results =_solrRootProductClient.GetListRootProductsByTag(tag, _idWebsite, 0, 100000);
                grdRootProduct.DataSource = results;
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("Tag: {0} . {1}", tag, exception));
            }
        }
        private void btnViewTag_Click(object sender, EventArgs e)
        {
            InitDataSql(txtTag.Text.Trim().ToLower());
            InitDataSolr(txtTag.Text.Trim().ToLower());
        }

        private void SelectedRootProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var arrIndexRowSelected = gvRootProduct.GetSelectedRows();
            if (arrIndexRowSelected.Length > 0)
            {
                var listIdRootProduct = new List<long>();
                foreach (var rowHande in arrIndexRowSelected)
                {
                    listIdRootProduct.Add(Common.Obj2Int64(gvRootProduct.GetRowCellValue(rowHande,"Id")));
                }
                txtListRootIdNew.Text = string.Join(",",listIdRootProduct);
            }
            else
                MessageBox.Show(@"Chọn sản phẩm rồi push message lên hệ thống");
        }

        private void gvRootProduct_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.grdRootProduct, new Point(e.X, e.Y));
            }
        }
    }
}
