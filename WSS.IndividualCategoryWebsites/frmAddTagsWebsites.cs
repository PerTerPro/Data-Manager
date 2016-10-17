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
            try
            {
                tagsTableAdapter.FillBy_WebsiteId(dBIndi.Tags, _idWebsite);
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("Website: {0} . {1}", _domainCurrent, exception));
            }
        }


        private void InitDataSolr(string tags)
        {
            try
            {
                var results = _solrRootProductClient.GetListRootProductsByTag(tags, _idWebsite, 0, 100000);
                grdRootProduct.DataSource = results;
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("Tag: {0} . {1}", tags[0], exception));
            }
        }

        private void SelectedRootProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (radioButtonUpdate.Checked || radioButtonNew.Checked)
            {
                var arrIndexRowSelected = gvRootProduct.GetSelectedRows();
                if (arrIndexRowSelected.Length > 0)
                {
                    var listIdRootProduct = new List<long>();
                    foreach (var rowHande in arrIndexRowSelected)
                    {
                        listIdRootProduct.Add(Common.Obj2Int64(gvRootProduct.GetRowCellValue(rowHande, "Id")));
                    }
                    txtListRootIdNew.Text = string.Join(",", listIdRootProduct);
                }
                else
                    MessageBox.Show(@"Chọn sản phẩm rồi push message lên hệ thống");

                if (radioButtonUpdate.Checked)
                {
                    rootProductIdListInSqlTextEdit.Text += @"," + txtListRootIdNew.Text;
                }
                else if (radioButtonNew.Checked)
                {
                    rootProductIdListInSqlTextEdit.Text = txtListRootIdNew.Text;
                }
                txtListRootIdNew.Focus();
                tagsGridControl.Focus();
            }
            else
            {
                var dialogResult = MessageBox.Show(
                    @"Chọn Yes nếu như cập nhật thêm RootId vào list đã có, Chọn No nếu như cập nhật lại list RootId mới! Chỉ chọn lần đầu và mặc định lần sau sẽ không thay đổi.",
                    @"Chọn cách cập nhật list RootId", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    radioButtonUpdate.Checked = true;
                    radioButtonNew.Checked = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    radioButtonUpdate.Checked = false;
                    radioButtonNew.Checked = true;
                }
            }
        }

        private void gvRootProduct_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripProduct.Show(this.grdRootProduct, new Point(e.X, e.Y));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tagsBindingSource.EndEdit();
                this.tagsTableAdapter.Update(this.dBIndi.Tags);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Lưu lỗi r !! " + exception.Message);
            }
        }

        private void viewListProductByTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitDataSolr(tagTextEdit.Text.Trim().ToLower());
        }

        private void gvTags_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripTags.Show(this.tagsGridControl, new Point(e.X, e.Y));
            }
        }
    }
}
