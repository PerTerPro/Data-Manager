using QT.Entities.RaoVat;
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
    public partial class FrmRunnerCrawler : Form
    {
        ProductSaleNewAdapter adapterProduct = new ProductSaleNewAdapter(new Entities.Data.SqlDb(QT.Entities.Server.ConnectionStringCrawler));
        public delegate void DelegateRunnerCrawler(int runnerCrawler);
        public DelegateRunnerCrawler eventRunnerCrawler = null;

        public FrmRunnerCrawler()
        {
            InitializeComponent();
        }

        private void ReloadData ()
        {
            this.gridControl1.DataSource = adapterProduct.GetTblRunner();
            this.gridView1.RefreshData();
            this.cboWebSite.DataSource = adapterProduct.GetListWebSite();
            this.cboWebSite.ValueMember = "id";
            this.cboWebSite.DisplayMember = "domain";
        }

        private void FrmRunnerCrawler_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void FrmRunnerCrawler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                ReloadData();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                SaveData();
            }
        }

        private void SaveData()
        {
            try
            {
                RunnerCrawler runnerCrawler = new RunnerCrawler();
                if (Convert.ToInt32(spinId.Value) != 0)
                {
                    runnerCrawler = this.adapterProduct.GetRunnerCrawler(Convert.ToInt32(spinId.Value));
                }
                LoadFormToObject(runnerCrawler);
                if (this.adapterProduct.SaveRunner(runnerCrawler))
                {
                    MessageBox.Show("Saved!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadFormToObject(RunnerCrawler runnerCrawler)
        {
            runnerCrawler.description = txtDescription.Text;
            runnerCrawler.number_thread = Convert.ToInt32(spinNumberThread.Value);
            runnerCrawler.is_find_new = ckFindNewItem.Checked;
            runnerCrawler.is_reload_item = ckReloadData.Checked;
            runnerCrawler.max_deep = Convert.ToInt32(spinMaxDeep.Value);
            runnerCrawler.max_item = Convert.ToInt32(spinMaxItem.Value);
            runnerCrawler.max_time_run_crawler = Convert.ToInt32(spimMaxTime.Value);
            runnerCrawler.name = txtName.Text;
            runnerCrawler.root_link = QT.Entities.Common.GetListXPathFromString(txtRootLink.Text);
            runnerCrawler.website_id = Convert.ToInt32(cboWebSite.SelectedValue);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            int iHander = this.gridView1.FocusedRowHandle;
            if (iHander>=0)
            {
                int idSelected = Convert.ToInt32((gridView1.GetRow(iHander) as DataRowView)["id"]);
                LoadFormById(idSelected);
            }
        }

        private void LoadFormById(int idSelected)
        {
            QT.Entities.RaoVat.RunnerCrawler runnerCrawler = this.adapterProduct.GetRunnerCrawler(idSelected);
            LoadObjectToForm(runnerCrawler);
        }

        private void LoadObjectToForm(Entities.RaoVat.RunnerCrawler runnerCrawler)
        {
            spinId.Value = runnerCrawler.id;
            spinMaxDeep.Value = runnerCrawler.max_deep;
            spinMaxItem.Value = runnerCrawler.max_item;
            spinNumberThread.Value = runnerCrawler.number_thread;
            spinRecrawler.Value = runnerCrawler.second_sleep_recrawler;
            ckFindNewItem.Checked = runnerCrawler.is_find_new;
            ckReloadData.Checked = runnerCrawler.is_reload_item;
            txtDescription.Text = runnerCrawler.description;
            txtName.Text = runnerCrawler.name;
            txtRootLink.Text = QT.Entities.Common.ConvertToString(runnerCrawler.root_link);
            cboWebSite.SelectedValue = runnerCrawler.website_id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnRunCrawler_Click(object sender, EventArgs e)
        {
            if (this.eventRunnerCrawler != null)
            {
                int[] arRowSelected = gridView1.GetSelectedRows();
                foreach (int iRow in arRowSelected)
                {
                    int idRunner = Convert.ToInt32((this.gridView1.GetRow(iRow) as DataRowView)["id"]);
                    this.eventRunnerCrawler(idRunner);
                }
            }
            else
            {
                MessageBox.Show("Chưa có event trong code");
            }
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==System.Windows.Forms.MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.gridControl1, e.X, e.Y);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewItem();
            ReloadData();
        }

        private void AddNewItem()
        {
            this.adapterProduct.AddRunnerCrawler();
        }
    }
}
