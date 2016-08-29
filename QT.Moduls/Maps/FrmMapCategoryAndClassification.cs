using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.Maps
{
    public partial class FrmMapCategoryAndClassification : Form
    {
        SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);

        public FrmMapCategoryAndClassification()
        {
            InitializeComponent();
        }

        private void FrmMapCategoryAndClassification_Load(object sender, EventArgs e)
        {
        
        }

        private void ClickCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.FieldName=="IDCategory")
            {
                long category_id = QT.Moduls.Maps.FrmSelectCategories.ShowDialogChoose();
                if (category_id >= 0)
                {
                    this.gridView1.SetRowCellValue(e.RowHandle, e.Column, category_id);
                }
            }
        }

        private void FrmMapCategoryAndClassification_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void FrmMapCategoryAndClassification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                ReloadData();
            }
        }

        private void ReloadData()
        {
            this.gridControl1.DataSource = sqlDb.GetTblData(@"SELECT * FROM Classification
                WHERE IDCompany = @IDCOmpany"
                 , CommandType.Text
                 , new SqlParameter[]
                    {
                        SqlDb.CreateParamteterSQL("IDCompany",this.spinEditCompanyID.Value,SqlDbType.BigInt) 
                    });

            DataTable tbl = sqlDb.GetTblData(@"SELECT a.Id
, a.Name+'>'+ isnull(b.name,'') +  '>' 
+ isnull(c.name, '') +'>'+ isnull(d.name, '') as Name, a.ParentID 
FROM ListClassification a
left join ListClassification b on a.ParentID = b.Id
left join ListClassification c on b.ParentID = c.id
left join ListClassification d on c.ParentID = d.id", CommandType.Text, new SqlParameter[] { });
            this.repositoryItemGridLookUpEdit1.DataSource = tbl;
            this.repositoryItemGridLookUpEdit1.ValueMember = "Id";
            this.repositoryItemGridLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemGridLookUpEdit1View.Columns.AddField("Name");
            this.repositoryItemGridLookUpEdit1View.Columns["Name"].MinWidth = 400;
            this.repositoryItemGridLookUpEdit1View.Columns["Name"].VisibleIndex = 0;
            this.repositoryItemGridLookUpEdit1View.RowHeight = 40;
            this.repositoryItemGridLookUpEdit1View.OptionsView.RowAutoHeight = true;
            this.repositoryItemGridLookUpEdit1View.ShowFindPanel();

            this.gridLookUpEdit1.Properties.DataSource = tbl;
            this.gridLookUpEdit1.Properties.DisplayMember = "Name";
            this.gridLookUpEdit1.Properties.ValueMember = "Id";
            this.gridLookUpEdit1View.OptionsFilter.AllowFilterEditor = true;
           
        }

        public void LoadCompany(long companyID)
        {
            this.spinEditCompanyID.Value = companyID;
            this.ReloadData();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tbl = (this.gridControl1.DataSource as DataTable);
                foreach (DataRow row in tbl.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        sqlDb.RunQuery("Update Classification Set IDCategory = @IDCategory Where Id = @Id", CommandType.Text,
                            new SqlParameter[] { 
                        SqlDb.CreateParamteterSQL("IDCategory",row["IDCategory"],SqlDbType.BigInt),
                        SqlDb.CreateParamteterSQL("Id",row["Id"],SqlDbType.BigInt)
                        });
                    }
                }
                tbl.AcceptChanges();
                MessageBox.Show("Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int[] arRowGridViewSelected = this.gridView1.GetSelectedRows();
            for (int i=0; i<arRowGridViewSelected.Length; i++)
            {
                DataRowView row = this.gridView1.GetRow(i) as DataRowView;
                row["IDCategory"] = Convert.ToInt32(this.gridLookUpEdit1.EditValue);
            }
            this.gridView1.RefreshData();
        }

        private void btnRemoveClassification_Click(object sender, EventArgs e)
        {
             
        }
    }
}
