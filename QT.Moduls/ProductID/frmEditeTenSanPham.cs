using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QT.Entities;
using System.Diagnostics;
using DevExpress.XtraEditors;

namespace QT.Moduls.ProductID
{
    public partial class frmEditeTenSanPham : QT.Entities.frmBase
    {
        public frmEditeTenSanPham()
        {
            InitializeComponent();
        }
        bool check = true;
        private void frmEditeTenSanPham_Load(object sender, EventArgs e)
        {
            this.productStatusTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.listClassificationSelectTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.listClassificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productStatusTableAdapter.FillByMapID(this.dBPMan.ProductStatus);
            this.gridView1.ExpandAllGroups();
            this.listClassificationTableAdapter.Fill(this.dBPMan.ListClassification);
            this.listClassificationSelectTableAdapter.Fill(this.dBPMan.ListClassificationSelect);
            this.treeList1.ExpandAll();
        }

        private void toolTaiCat_Click(object sender, EventArgs e)
        {
            LogJobAdapter.SaveLog(JobName.FrmEditeTenSanPham_Load_Cat, "Ấn nút Load Cat nên ko có ID", 0, (int)JobTypeData.KhongXacDinh);
            check = chkTimChinhXac.Checked;
            RefreshData();
        }
        public override bool RefreshData()
        {
            try
            {
                if(check){
                    this.productTableAdapter.FillBy_CategoryID(this.dBPMan.Product, Common.Obj2Int(this.iDCategoryTextBox.Text.Trim()));
                }
                else
                {
                    string cat = string.Format("c{0}_", Common.Obj2Int(this.iDCategoryTextBox.Text.Trim()).ToString("D3"));
                    this.productTableAdapter.FillBy_SPGoc_LikeContentFT(this.dBPMan.Product, cat);
                }
                this.gridView1.ExpandAllGroups();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        private void toolTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                QT.Entities.Wait.Show("Đang tải dữ liệu");
                this.productTableAdapter.FillBy_AllProductID(this.dBPMan.Product);
                LogJobAdapter.SaveLog(JobName.FrmEditeTenSanPham_Load_All, "Ấn nút Load All nên ko có ID", 0, (int)JobTypeData.KhongXacDinh);
                this.gridView1.ExpandAllGroups();
                Wait.Close();
            }
            catch (Exception)
            {
                Wait.Close();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        public override bool Save()
        {
            try
            {
                this.productBindingSource.EndEdit();
                foreach (DataRow item in dBPMan.Product.GetChanges().Rows)
                {
                    long idProduct = Common.Obj2Int64(item["ID"].ToString());
                    LogJobAdapter.SaveLog(JobName.FrmEditeTenSanPham_Luu_du_lieu, "Dữ liệu thay đổi ấn lưu dữ liệu form Đổi tên sản phẩm", idProduct, (int)JobTypeData.Product);
                }
                this.productTableAdapter.Update(dBPMan.Product);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void btDienTen_Click(object sender, EventArgs e)
        {
            this.productBindingSource.MoveFirst();
            for (int i = 0; i < this.productBindingSource.Count; i++)
            {
                if (this.nameTextBox.Text.Trim().IndexOf(this.nameCategoryTextBox.Text.Trim()) < 0)
                {
                    this.nameTextBox.Text = this.nameCategoryTextBox.Text.Trim() + " " + this.nameTextBox.Text.Trim();
                }
                this.productBindingSource.MoveNext();
            }
        }

        private void btThayThe_Click(object sender, EventArgs e)
        {
            if (this.txtNoiDungMuonThay.Text.Trim().Length <= 0)
            {
                Wait.Show("Phải nhập nội dung");
                Wait.Close();
                this.txtNoiDungMuonThay.Focus();
            }
            else if (this.txtNoiDungThayBang.Text.Trim().Length <= 0)
            {
                Wait.Show("Phải nhập nội dung");
                Wait.Close();
                this.txtNoiDungThayBang.Focus();
            }
            else
            {
                this.productBindingSource.MoveFirst();
                for (int i = 0; i < this.productBindingSource.Count; i++)
                {
                    this.nameTextBox.Text = this.nameTextBox.Text.Trim().Replace(this.txtNoiDungMuonThay.Text.Trim().ToString(), this.txtNoiDungThayBang.Text.Trim());
                    this.productBindingSource.MoveNext();
                }
                LogJobAdapter.SaveLog(JobName.FrmEditeTenSanPham_Noi_dung_thay_the, "Click vào nút thay thế nội dung sản phẩm hàng loạt nên ko có ID", 0, (int)JobTypeData.KhongXacDinh);
            }
        }

      

        private void btViewWeb_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://websosanh.vn/" + this.nameCategoryTextBox.Text.Trim().Replace(" ", "-") + "/" + this.iDTextBox.Text.Trim() + "/so-sanh.htm");
            Process.Start(sInfo);
        }

        private void btDoiCategory_Click(object sender, EventArgs e)
        {
            int cat = Common.Obj2Int(txtCatDoi.Text.Trim());
            if (this.txtNoiDungCat.Text.Trim().Length <= 0)
            {
                Wait.Show("Phải nhập nội dung");
                Wait.Close();
                this.txtNoiDungCat.Focus();
            }
            else if (cat==0)
            {
                Wait.Show("Phải nhập nội dung");
                Wait.Close();
                this.txtCatDoi.Focus();
            }
            else
            {
                this.productBindingSource.MoveFirst();
                for (int i = 0; i < this.productBindingSource.Count; i++)
                {
                    if (nameTextBox.Text.IndexOf(txtNoiDungCat.Text.Trim()) >= 0)
                    {
                        this.categoryIDTextBox.Text = cat.ToString();
                    }
                    this.productBindingSource.MoveNext();
                }
                LogJobAdapter.SaveLog(JobName.FrmEditeTenSanPham_Doi_Category, "Click vào nút đổi category sản phẩm hàng loạt nên ko có ID", 0, (int)JobTypeData.KhongXacDinh);
            }
        }

        private void btUpdateMapCat_Click(object sender, EventArgs e)
        {
            try
            {
                //this.productTableAdapter.FillBy_CategoryID(this.dBPMan.Product, Common.Obj2Int(this.iDCategoryTextBox.Text.Trim()));
                string cat = string.Format("c{0}_", Common.Obj2Int(this.iDCategoryTextBox.Text.Trim()).ToString("D3"));
                this.productTableAdapter.FillBy_SPGoc_LikeContentFT(this.dBPMan.Product, cat);
                this.gridView1.ExpandAllGroups();
            }
            catch (Exception)
            {
            }
        }

        private void repositoryItemLookUpEditCategory_EditValueChanged(object sender, EventArgs e)
        {
            
            //editor.Properties.ValueMember
            //int index = editor.Properties.Get;
            //DataRow row = (editor.Properties.DataSource as DataTable).Rows[index];
            //var kq = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colCategoryID);
            //int id = 0;
            //int.TryParse(kq.ToString(), out id);
            //string expression = "ID = "+id.ToString();
            //DataRow[] dr = dBPMan.ListClassificationSelect.Select(expression);
            LookUpEdit editor = gridView1.ActiveEditor as LookUpEdit;
            DataRowView rowView = (DataRowView)editor.GetSelectedDataRow();
            DataRow dr = rowView.Row;
            contentFTTextEdit.Text = dr["ListIDSearch"].ToString();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Caption != "CategoryID")
            {
                return;
            }
            else
            {
                int cellValue = int.Parse(e.Value.ToString());
                string expression = "ID = "+cellValue.ToString();
                DataRow[] dr = dBPMan.ListClassificationSelect.Select(expression);
                if (dr.Length > 0)
                {
                    contentFTTextEdit.Text = dr[0]["ListIDSearch"].ToString();
                }
                else
                    MessageBox.Show("Lỗi! Không có mã Category "+ cellValue.ToString());
            }
        }
    }
}
