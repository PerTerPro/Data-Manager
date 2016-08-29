using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.RaoVat
{
    public partial class FrmMapClassficationAndCategory : Form
    {
        SqlDb sqlDb = null;
        QT.Entities.RaoVat.RaoVatSQLAdapter sqlRaoVat = null;
        private int website_id;

        public FrmMapClassficationAndCategory()
        {
            InitializeComponent();
        }

        public FrmMapClassficationAndCategory(int website_id)
        {
            InitializeComponent();
            this.website_id = website_id;
            InitData();
        }

        private void FrmMapClassficationAndCategory_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void InitData()
        {
            this.sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
            this.sqlRaoVat = new Entities.RaoVat.RaoVatSQLAdapter(this.sqlDb);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            try
            {
                DataTable tbl = this.gridControl1.DataSource as DataTable;
                foreach (DataRow row in tbl.GetChanges().Rows)
                {
                    this.sqlRaoVat.SaveMapClassificationAndCategori(Convert.ToInt64(row["id"]), Convert.ToInt32(row["category_id"]));
                }
                MessageBox.Show("Saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshData()
        {
            DataTable tbl = this.sqlRaoVat.GetTableClassification(Convert.ToInt32(website_id));

            this.gridControl1.DataSource = tbl;
            this.repositoryItemGridLookUpEdit1.DataSource = this.sqlRaoVat.GetTableCategories();
            this.repositoryItemGridLookUpEdit1.DisplayMember = "name";
            this.repositoryItemGridLookUpEdit1.ValueMember = "id";

            this.repositoryItemGridLookUpEdit1View.ShowFindPanel();
            this.repositoryItemGridLookUpEdit1View.OptionsFilter.AllowFilterEditor = true;
            this.repositoryItemGridLookUpEdit1View.OptionsFilter.AllowMRUFilterList = true;
            this.repositoryItemGridLookUpEdit1View.OptionsFilter.AllowFilterIncrementalSearch = true;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemGridLookUpEdit1View.Columns.AddField("name");
            this.repositoryItemGridLookUpEdit1View.PopulateColumns();

            (this.gridControl1.DataSource as DataTable).AcceptChanges();
            this.gridView1.RefreshData();

            this.gluCategories.Properties.DataSource = this.sqlRaoVat.GetTableCategories();
            this.gluCategories.Properties.DisplayMember = "name";
            this.gluCategories.Properties.ValueMember = "id";
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.Columns.AddField("name");
            this.gridLookUpEdit1View.Columns["name"].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridLookUpEdit1View.PopulateColumns();


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arSelected = this.gridView1.GetSelectedRows();
                foreach (int iIndexRow in arSelected)
                {
                    DataRowView row = this.gridView1.GetRow(iIndexRow) as DataRowView;
                    row["category_id"] = Convert.ToInt32(gluCategories.EditValue);
                }
                this.gridView1.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
