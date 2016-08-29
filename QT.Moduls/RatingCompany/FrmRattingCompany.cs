using DevExpress.XtraGrid.Columns;
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

namespace QT.Moduls.RatingCompany
{
    public partial class FrmRattingCompany : Form
    {
        ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
        private long CompanyID;

        public FrmRattingCompany()
        {
            InitializeComponent();
        }

        public FrmRattingCompany(long CompanyID)
        {
            InitializeComponent();
            this.CompanyID = CompanyID;
        }

        private void FrmRattingCompany_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            this.gridControl1.DataSource = productAdapter.GetCompanyForSetRatting();
            this.BindinaData(this.repositoryItemLookUpEdit_Reputation, EnumRatting_BigStore.Instance().Reputation);
            this.BindinaData(this.repositoryItemLookUpEdit_Attitude, EnumRatting_BigStore.Instance().Attitude);
            this.BindinaData(this.repositoryItemLookUpEdit_BigStore, EnumRatting_BigStore.Instance().BigStore);
            this.BindinaData(this.repositoryItemLookUpEdit_Delivery, EnumRatting_BigStore.Instance().Delivery);
            this.BindinaData(this.repositoryItemLookUpEdit_Geneuine, EnumRatting_BigStore.Instance().Genuine);
            this.BindinaData(this.repositoryItemLookUpEdit_OldCustomer, EnumRatting_BigStore.Instance().OldCustomer);
            this.BindinaData(this.repositoryItemLookUpEdit_Guarantee, EnumRatting_BigStore.Instance().Guarantee);
            this.BindinaData(this.repositoryItemLookUpEdit_Price, EnumRatting_BigStore.Instance().Price);
            this.BindinaData(this.repositoryItemLookUpEdit_Quantity, EnumRatting_BigStore.Instance().Quantity);
            this.BindinaData(this.repositoryItemLookUpEdit_Scandal, EnumRatting_BigStore.Instance().Scandal);
            this.BindinaData(this.repositoryItemLookUpEdit_Swap, EnumRatting_BigStore.Instance().Swap);
           
        }

        private void BindinaData(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit, DataTable dataTable)
        {
            repositoryItemLookUpEdit.DataSource = EnumRatting_BigStore.Instance().BigStore;
            repositoryItemLookUpEdit.ValueMember = "Value";
            repositoryItemLookUpEdit.DisplayMember = "Text";
            repositoryItemLookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value",20,"Value"));
            repositoryItemLookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", 20, "Chọn"));
            repositoryItemLookUpEdit.Columns["Value"].Visible = false;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SaveData();
        }

        private void SaveData()
        {
            DataTable tbl = this.gridControl1.DataSource as DataTable;
            DataTable tblChanged = tbl.GetChanges();
            if (tblChanged != null)
            {
                foreach (DataRow rowInfo in tblChanged.Rows)
                {
                    long CompanyID = QT.Entities.Common.Obj2Int64(rowInfo["CompanyID"]);

                    productAdapter.InsertRatting(CompanyID);

                    productAdapter.UpdateRattingProduct(
                        QT.Entities.Common.Obj2Int64(rowInfo["CompanyID"]),
                        QT.Entities.Common.Obj2Int(rowInfo["Reputation"]),
                        QT.Entities.Common.Obj2Int(rowInfo["BigStore"]),
                        QT.Entities.Common.Obj2Int(rowInfo["Scandal"]),
                        QT.Entities.Common.Obj2Int(rowInfo["Genuine"]),
                        QT.Entities.Common.Obj2Int(rowInfo["Quanlity"]),
                        QT.Entities.Common.Obj2Int(rowInfo["Attitude"]),
                        QT.Entities.Common.Obj2Int(rowInfo["Delivery"]),
                        QT.Entities.Common.Obj2Int(rowInfo["Guarantee"]),
                        QT.Entities.Common.Obj2Int(rowInfo["Swap"]),
                        QT.Entities.Common.Obj2Int(rowInfo["Price"]),
                        QT.Entities.Common.Obj2Int(rowInfo["OldCustomer"]));
              
                    LogJobAdapter.SaveLog(JobName.FrmRankingCompany_SaveRanking, "Sửa ratting", CompanyID, (int)JobTypeData.Company);
                }
            }
            tbl.AcceptChanges();
            MessageBox.Show("Đã lưu");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void txtDomain_KeyDown(object sender, KeyEventArgs e)
        {
            if  (e.KeyCode==Keys.Enter)
            {
                this.gridView1.Columns["Domain"].FilterInfo = new ColumnFilterInfo(string.Format("[Domain] LIKE '%{0}%'", txtDomain.Text));
            }
            else if (e.KeyCode == Keys.F2)
            {
                this.txtDomain.Focus();
                this.txtDomain.SelectAll();
            }
        }

        private void FrmRattingCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F2)
            {
                this.txtDomain.Focus();
                this.txtDomain.SelectAll();
            }
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F2)
            {
                this.txtDomain.Focus();
                this.txtDomain.SelectAll();
            }
        }
    }
}
