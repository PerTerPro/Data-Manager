using DevExpress.XtraTreeList.Nodes;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls
{
    public partial class FrmCheckClassification : Form
    {
        ProductAdapter _productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));

        public FrmCheckClassification()
        {
            InitializeComponent();
        }

        private void listClassificationCheckBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        
            this.tableAdapterManager.UpdateAll(this.dB);

        }

        private void FrmCheckClassification_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void FrmCheckClassification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F5)
            {
                RefreshData();
            }
            else if (e.Control && e.KeyCode==Keys.S)
            {
                SaveData();
            }
        }

        private void RefreshData()
        {
           this.treeList1.DataSource=_productAdapter.GetListClassiicationToCheck();
           this.treeList1.KeyFieldName = "ID";
           this.treeList1.ParentFieldName = "ParentID";
        }

        private void SaveData()
        {
            DataTable tbl = this.treeList1.DataSource as DataTable;
            DataTable tblChange = tbl.GetChanges();

            foreach(DataRow rowInfo in tblChange.Rows)
            {
                long CompanyID = QT.Entities.Common.Obj2Int64(rowInfo["ID"]);
                bool CheckedData = QT.Entities.Common.Obj2Bool(rowInfo["CheckData"]);
                this._productAdapter.SaveListClassifcation(CompanyID, CheckedData);
             
            }

            tbl.AcceptChanges();
            MessageBox.Show("Saved!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void treeList1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.treeList1, new Point(e.X, e.Y));
            }
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeList1.Selection != null && this.treeList1.Selection.Count > 0)
            {
                foreach (TreeListNode nodeSelected in this.treeList1.Selection)
                {
                    foreach (TreeListNode nodeChild in nodeSelected.Nodes)
                    {
                        nodeChild.SetValue("CheckData", true);
                    }
                }
            }
        }

        private void unCheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeList1.Selection != null && this.treeList1.Selection.Count > 0)
            {
                foreach (TreeListNode nodeSelected in this.treeList1.Selection)
                {
                    foreach (TreeListNode nodeChild in nodeSelected.Nodes)
                    {
                        nodeChild.SetValue("CheckData", false);
                    }
                }
            }
        }
    }
}
