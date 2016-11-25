using log4net;
using QT.Entities;
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
using Castle.Components.DictionaryAdapter;
using Websosanh.Core.Drivers.Solr;
using WSS.IndividualCategoryWebsites.SolrProduct;
using System.Text.RegularExpressions;

namespace WSS.IndividualCategoryWebsites.DataTeam
{
    public partial class FrmSuggestRootProduct : Form
    {
        public FrmSuggestRootProduct()
        {
            InitializeComponent();
        }
        private SolrProductClient solrProductClient;
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmSuggestRootProduct));

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(memoIdCompany.Text))
            {
                MessageBox.Show(@"Nhập IdCompany");
                memoIdCompany.Focus();
            }
            else
            {
                txtCategoryIdSelected.Text = "0";
                List<string> companyIdList = new List<string>();
                if (!string.IsNullOrEmpty(memoIdCompany.Text))
                {
                    companyIdList = Regex.Split(memoIdCompany.Text, "\r\n").Where(s => s != String.Empty).ToList();
                }
                int numberFound;
                grdCategory.DataSource = solrProductClient.GetListCategoryProductNotRootByCompanyAndKeyword(companyIdList, txtKeyword.Text, 1, 1, out numberFound);
                ctrPage1.SetTotalItem(numberFound);
            }
        }

        private void FrmSuggestRootProduct_Load(object sender, EventArgs e)
        {
            WssConnection.ConnectionIndividual = ConfigurationSettings.AppSettings["ConnectionIndividual"];
            WssConnection.ConnectionProduct = ConfigurationSettings.AppSettings["ConnectionProduct"];
            solrProductClient = SolrProductClient.GetClient(SolrClientManager.GetSolrClient("solrProducts"));
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataProduct();
        }

        private void gvCategory_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                txtCategoryIdSelected.Text = gvCategory.GetRowCellValue(e.RowHandle, "CategoryId").ToString();
                lbCategoryNameSelected.Text = gvCategory.GetRowCellValue(e.RowHandle, "CategoryName").ToString();
            }
        }
        
        private void ctrPage1_PageChanged(EventArgs e)
        {
            LoadDataProduct();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataProduct();
        }
        private void LoadDataProduct()
        {
            List<string> companyIdList = new List<string>();
            if (!string.IsNullOrEmpty(memoIdCompany.Text))
            {
                companyIdList = Regex.Split(memoIdCompany.Text, "\r\n").Where(s => s != String.Empty).ToList();
            }
             int categoryIdSelected = Common.Obj2Int(txtCategoryIdSelected.Text);
            int pageSize = ctrPage1.GetPageSize();
            int curentPage = ctrPage1.GetCurrentPage();
            int numFound = 0;
            grdProduct.DataSource = solrProductClient.GetListProductNotRootByCompanyAndKeyword(companyIdList,
                txtKeyword.Text, categoryIdSelected,(curentPage-1)*pageSize , pageSize, out numFound);
            if (numFound != ctrPage1.GetTotalItem())
            {
                ctrPage1.SetTotalItem(numFound);
            }
        }

        private void btnAddToBlackList_Click(object sender, EventArgs e)
        {
            var listSelected = gvProduct.GetSelectedRows();
            var blackListId = listSelected.Select(index => Common.Obj2Int64(gvProduct.GetRowCellValue(index, "Id"))).ToList();
            var blackListProductDataAccess = new BlackListProductDataAccess();
            blackListProductDataAccess.SetListProductToBlackList(blackListId);
            LoadDataProduct();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            WssCommon.ExportExcel(grdProduct,"goiy");
        }
    }
}
