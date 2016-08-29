using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QT.Entities;
using QT.Users;
using QT.Entities.Data;
/// 
namespace QT.Moduls.ProductID
{
    public partial class frmEditeProductByCat : QT.Entities.frmBase
    {
        public frmEditeProductByCat()
        {
            InitializeComponent();
        }

        public override bool Save()
        {
            // gán idvalue
            this.dateLastUpdate.DateTime = DateTime.Now;
            productPropertiesBindingSource.MoveFirst();
            for (int i = 0; i < productPropertiesBindingSource.Count; i++)
            {
                bool checkInsert = false;
                this.propertiesValueIDTextBox.Text = GetIDValue(Common.Obj2Int(this.hasNameTextBox.Text), out checkInsert).ToString();
                try
                {
                    if (checkInsert)
                    {
                        this.propertiesValueTableAdapter.Insert(Common.Obj2Int(this.propertiesValueIDTextBox.Text),
                           this.valueNameTextBox.Text,
                           Common.Obj2Int(this.propertiesIDTextBox.Text),
                           true,
                           Common.Obj2Int(this.propertiesValueIDTextBox.Text),
                           Common.Obj2Int(this.hasNameTextBox.Text), 0);
                    }
                }
                catch (Exception)
                {
                }
                productPropertiesBindingSource.MoveNext();
            }

            this.productPropertiesBindingSource.EndEdit();
            this.product_PropertiesTableAdapter.Update(dBProperties.Product_Properties);
            this.productDetailBindingSource.EndEdit();
            this.productDetailTableAdapter.Update(dBProperties.ProductDetail);
            long idproduct = Common.Obj2Int64(productIDTextBox.Text);
            LogJobAdapter.SaveLog(JobName.FrmEditeProductByCat_Save_gia_tri_thuoc_tinh, "Lưu lại giá trị thuộc tính của sản phẩm gốc", idproduct, (int)JobTypeData.Product);
            return true;

        }
        /// <summary>
        ///  Lưu nội dung sử dụng properties định nghĩa
        /// </summary>
        /// <returns></returns>
        //public bool SaveVer2()
        //{
        //    // gán idvalue
        //    this.dateLastUpdate.DateTime = DateTime.Now;
        //    productPropertiesBindingSource.MoveFirst();
        //    for (int i = 0; i < productPropertiesBindingSource.Count; i++)
        //    {
        //        bool checkInsert = false;
        //        this.propertiesValueIDTextBox.Text = GetIDValue(Common.Obj2Int(this.hasNameTextBox.Text), out checkInsert).ToString();
        //        try
        //        {
        //            if (checkInsert)
        //            {
        //                this.propertiesValueTableAdapter.Insert(Common.Obj2Int(this.propertiesValueIDTextBox.Text),
        //                   this.valueNameTextBox.Text,
        //                   Common.Obj2Int(this.propertiesIDTextBox.Text),
        //                   true,
        //                   Common.Obj2Int(this.propertiesValueIDTextBox.Text),
        //                   Common.Obj2Int(this.hasNameTextBox.Text), 0);
        //            }
        //        }
        //        catch (Exception)
        //        {
        //        }
        //        productPropertiesBindingSource.MoveNext();
        //    }

        //    this.productPropertiesBindingSource.EndEdit();
        //    this.product_PropertiesTableAdapter.Update(dBProperties.Product_Properties);
        //    this.productBindingSource.EndEdit();
        //    this.productTableAdapter.Update(dBProperties.Product);
        //    return true;

        //}
        public override bool RefreshData()
        {
            int catid = Common.Obj2Int(iDCategoryTextBox.Text);
            this.productTableAdapter.FillBy_CatID_ComID(this.dBProperties.Product, Common.GetIDCompany("quangtrung.vn"), catid);
            //listClassification_PropertiesTableAdapter.FillBy_IDListClassification(dBProperties.ListClassification_Properties, catid);
            this.propertiesConfig_PropertiesTableAdapter.FillBy_IDClassification(dBProperties.PropertiesConfig_Properties, catid);
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            return true;
        }

        private void frmEditeProductByCat_Load(object sender, EventArgs e)
        {
            this.btLoadJobSP.Text += QT.Users.User.UserName;
            this.btLoadCatMyJob.Text += QT.Users.User.UserName;

            this.productDetailTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.job_SPGocNhapLieuLogTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.job_NhapLieuStatusConstTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.job_SPGocNhapLieuTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesConfig_PropertiesTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.job_NhapLieuStatusTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productStatusTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.propertiesValueTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.listClassification_PropertiesTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.product_PropertiesTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.listClassificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productStatusTableAdapter.Fill(this.dBProperties.ProductStatus);
            this.listClassificationTableAdapter.FillBy_DaMapConfig(this.dBProperties.ListClassification);
            this.job_NhapLieuStatusTableAdapter.Fill(this.dBJob.Job_NhapLieuStatus);
            this.job_NhapLieuStatusConstTableAdapter.Fill(this.dBProperties.Job_NhapLieuStatusConst);

            var per = new User_Permission();
            if (per.CheckPermission(QT.Users.User.UserID, Permission.ADMIN)
                || per.CheckPermission(QT.Users.User.UserID, Permission.PhanCongNhapDuLieu))
            {
                this.cboJobStatus.Enabled = true;
                this.btCheck.Enabled = true;
                this.btLoad.Visible = true;
            }
            else
            {
                this.cboJobStatus.Enabled = false;
                this.btCheck.Enabled = false;
                this.btLoad.Visible = false;
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewProduct frm = new frmAddNewProduct(Common.Obj2Int(iDCategoryTextBox.Text));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int catid = Common.Obj2Int(iDCategoryTextBox.Text);
                this.productTableAdapter.FillBy_CatID_ComID(this.dBProperties.Product, Common.GetIDCompany("quangtrung.vn"), catid);
            }
        }

        private void iDProductTextBox_TextChanged(object sender, EventArgs e)
        {
            this.product_PropertiesTableAdapter.FillBy_ProductID(dBProperties.Product_Properties, Common.Obj2Int64(this.iDProductTextBox.Text));
            this.productDetailTableAdapter.FillBy_ProductID(dBProperties.ProductDetail, Common.Obj2Int64(this.iDProductTextBox.Text));
            this.job_SPGocNhapLieuTableAdapter.FillBy_IDProduct(dBJob.Job_SPGocNhapLieu, Common.Obj2Int64(this.iDProductTextBox.Text));
            this.gridViewProductProperties.ExpandAllGroups();
            /// map với danh sách đã có
            for (int i = 0; i < dBProperties.PropertiesConfig_Properties.Rows.Count; i++)
            {
                int idProperties = 0, idPropertiesInProduct = 0, PropertiesGroupID = 0;
                idProperties = Common.Obj2Int(dBProperties.PropertiesConfig_Properties.Rows[i]["IDProperties"].ToString());
                PropertiesGroupID = Common.Obj2Int(dBProperties.PropertiesConfig_Properties.Rows[i]["PropertiesGroupID"].ToString());
                bool check = false;
                for (int j = 0; j < dBProperties.Product_Properties.Rows.Count; j++)
                {
                    idPropertiesInProduct = Common.Obj2Int(dBProperties.Product_Properties.Rows[j]["PropertiesID"].ToString());
                    if (idProperties == idPropertiesInProduct)
                    {
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    this.productPropertiesBindingSource.AddNew();
                    this.productIDTextBox.Text = this.iDProductTextBox.Text;
                    this.propertiesIDTextBox.Text = idProperties.ToString();
                    this.propertiesGroupIDTextBox.Text = PropertiesGroupID.ToString();
                    this.sTTTextBox.Text = dBProperties.PropertiesConfig_Properties.Rows[i]["STT"].ToString();
                }
            }
            this.productPropertiesBindingSource.EndEdit();
        }

        private void valueNameTextBox_TextChanged(object sender, EventArgs e)
        {
            //int catid = Common.Obj2Int(iDCategoryTextBox.Text);
            //this.hasNameTextBox.Text = Common.GetID_Properties(this.valueNameTextBox.Text.Trim(), catid).ToString();
            this.hasNameTextBox.Text = Common.GetID_Value(this.valueNameTextBox.Text).ToString();
        }

        private void btSaveValue_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Get id max <10000
        /// cộng thêm 1 vào idmax
        /// kiểm tra xem hasname đã có mã chưa
        /// nếu có rồi thì id = id of hasname
        /// </summary>
        /// <param name="hasName"></param>
        /// <param name="checkInsert"></param>
        /// <returns></returns>
        private int GetIDValue(int hasName, out bool checkInsert)
        {
            checkInsert = false;
            int idMax = 0;
            try
            {
                idMax = Common.Obj2Int(this.propertiesValueTableAdapter.ScalarQuery_GetMaxIDDienTay());
            }
            catch (Exception)
            {
            }
            int idValue = idMax + 1;
            DBProperties.PropertiesValueDataTable dt = new DBProperties.PropertiesValueDataTable();
            this.propertiesValueTableAdapter.FillBy_SelectOne(dt, idValue);
            if (dt.Rows.Count <= 0)
            {
                checkInsert = true;
                dt = new DBProperties.PropertiesValueDataTable();
                this.propertiesValueTableAdapter.FillBy_HasName(dt, hasName);
                if (dt.Rows.Count > 0)
                {
                    checkInsert = false;
                    idValue = Common.Obj2Int(dt.Rows[0]["ID"].ToString());
                }
                else
                {
                    /// duyet từ đầu tìm id
                    /// 
                    DBProperties.PropertiesValueDataTable dtValue = new DBProperties.PropertiesValueDataTable();
                    this.propertiesValueTableAdapter.FillBy_Top10000ID(dtValue);
                    for (int id = 0; id < dtValue.Count - 1; id++)
                    {
                        if (id != Common.Obj2Int(dtValue.Rows[id]["ID"].ToString()))
                        {
                            idValue = id;
                            break;
                        }
                    }
                }
            }
            return idValue;
        }

        private void btGetIDValue_Click(object sender, EventArgs e)
        {

        }

        private void btSaveDanhSach_Click(object sender, EventArgs e)
        {
            this.productBindingSource.EndEdit();
            if (dBProperties.Product.GetChanges() != null)
            {
                //DataTable dt = dBProperties.Product.GetChanges();
                //DataTable d2 = productBindingSource.Chan
                //int a = dt.Rows.Count;
                //foreach (DataRow item in dBProperties.Product.GetChanges())
                //{
                //    long idProduct = Common.Obj2Int64(item["ID"].ToString());
                LogJobAdapter.SaveLog(JobName.FrmEditeProductByCat_Luu_danh_sach, "Click vào nút lưu danh sách sản phẩm gốc được load by cat. Thay đổi cả bảng Product nên ko có ID Product", 0, (int)JobTypeData.KhongXacDinh);
                //}
            }
            this.productTableAdapter.Update(dBProperties.Product);
        }

        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void toolbtSaveValue_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btAutoSave_Click(object sender, EventArgs e)
        {
            LogJobAdapter.SaveLog(JobName.FrmEditeProductByCat_AutoSave, "Click vào nút AutoSave trên Form Nhập sản phẩm gốc. Các ID sản phẩm đc thay đổi sẽ lưu ở log tiếp theo...", 0, (int)JobTypeData.KhongXacDinh);
            this.productBindingSource.MoveFirst();
            if (this.productBindingSource.Count > 0)
            {
                for (int i = 0; i < this.productBindingSource.Count; i++)
                {
                    this.Save();
                    this.productBindingSource.MoveNext();
                    Application.DoEvents();
                }
            }
        }

        private void toolXoa_Click(object sender, EventArgs e)
        {
            if (this.validCheckBox.Checked != true)
            {
                LogJobAdapter.SaveLog(JobName.FrmEditeProductByCat_Xoa_San_pham_goc, "Click vào nút Xóa trên Form Nhập sản phẩm gốc.", Common.Obj2Int64(iDProductTextBox.Text), (int)JobTypeData.KhongXacDinh);
                this.productBindingSource.RemoveCurrent();
                this.productBindingSource.EndEdit();
                gridView2.FocusedRowHandle++;
            }
        }

        private bool expand = false;
        private void btExpan_Click(object sender, EventArgs e)
        {
            if (expand)
            {
                treeList1.CollapseAll();
                expand = false;
            }
            else
            {
                this.treeList1.ExpandAll();
                expand = true;
            }

        }

        private void btLoadCatMyJob_Click(object sender, EventArgs e)
        {
            this.listClassificationTableAdapter.FillBy_JobUserID(this.dBProperties.ListClassification, QT.Users.User.UserID);
        }

        private void btLoadJobSP_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang tải dữ liệu");
            int catid = Common.Obj2Int(iDCategoryTextBox.Text);
            this.propertiesConfig_PropertiesTableAdapter.FillBy_IDClassification(dBProperties.PropertiesConfig_Properties, catid);
            this.propertiesConfig_PropertiesTableAdapter.FillBy_IDClassification(dBProperties.PropertiesConfig_Properties, catid);
            this.productTableAdapter.FillBy_JobUserIDCatID(this.dBProperties.Product, QT.Users.User.UserID, catid);
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            Wait.Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {

            this.cboJobStatus.SelectedValue = JobNhapLieuStatus.DaNhapXong;
            this.job_SPGocNhapLieuTableAdapter.UpdateQuery_Status(JobNhapLieuStatus.DaNhapXong, DateTime.Now, Common.Obj2Int(iDJobTextBox.Text));
            this.job_SPGocNhapLieuLogTableAdapter.DeleteQuery_IDJob_IDStatus(Common.Obj2Int(iDJobTextBox.Text), JobNhapLieuStatus.DaNhapXong);
            this.job_SPGocNhapLieuLogTableAdapter.Insert(Common.Obj2Int(iDJobTextBox.Text), JobNhapLieuStatus.DaNhapXong, DateTime.Now);
            this.gridControl2.Focus();
            var statusjob = (int)cboJobStatus.SelectedItem;
            if (statusjob != JobNhapLieuStatus.DaNhapXong)
            {
                long idProduct = Common.Obj2Int64(iDProductTextBox.Text);
                LogJobAdapter.SaveLog(JobName.FrmEditeProductByCat_Chuyen_trang_thai_san_pham, "Chuyển trạng thái sản phẩm sang Đã nhập xong", idProduct, (int)JobTypeData.Product);
            }
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            this.cboJobStatus.SelectedValue = JobNhapLieuStatus.DaDuyet;
            this.job_SPGocNhapLieuTableAdapter.UpdateQuery_Status(JobNhapLieuStatus.DaDuyet, DateTime.Now, Common.Obj2Int(iDJobTextBox.Text));
            this.job_SPGocNhapLieuLogTableAdapter.DeleteQuery_IDJob_IDStatus(Common.Obj2Int(iDJobTextBox.Text), JobNhapLieuStatus.DaDuyet);
            this.job_SPGocNhapLieuLogTableAdapter.Insert(Common.Obj2Int(iDJobTextBox.Text), JobNhapLieuStatus.DaDuyet, DateTime.Now);
            this.gridControl2.Focus();
            var statusjob = (int)cboJobStatus.SelectedItem;
            if (statusjob != JobNhapLieuStatus.DaDuyet)
            {
                long idProduct = Common.Obj2Int64(iDProductTextBox.Text);
                LogJobAdapter.SaveLog(JobName.FrmEditeProductByCat_Chuyen_trang_thai_san_pham, "Chuyển trạng thái sản phẩm sang Đã duyệt", idProduct, (int)JobTypeData.Product);
            }
        }

        private void btBiThieu_Click(object sender, EventArgs e)
        {
            this.cboJobStatus.SelectedValue = JobNhapLieuStatus.BiThieu;
            this.job_SPGocNhapLieuTableAdapter.UpdateQuery_Status(JobNhapLieuStatus.BiThieu, DateTime.Now, Common.Obj2Int(iDJobTextBox.Text));
            this.job_SPGocNhapLieuLogTableAdapter.DeleteQuery_IDJob_IDStatus(Common.Obj2Int(iDJobTextBox.Text), JobNhapLieuStatus.BiThieu);
            this.job_SPGocNhapLieuLogTableAdapter.Insert(Common.Obj2Int(iDJobTextBox.Text), JobNhapLieuStatus.BiThieu, DateTime.Now);
            this.gridControl2.Focus();
            var statusjob = (int)cboJobStatus.SelectedItem;
            if (statusjob != JobNhapLieuStatus.BiThieu)
            {
                long idProduct = Common.Obj2Int64(iDProductTextBox.Text);
                LogJobAdapter.SaveLog(JobName.FrmEditeProductByCat_Chuyen_trang_thai_san_pham, "Chuyển trạng thái sản phẩm sang Bị Thiếu", idProduct, (int)JobTypeData.Product);
            }
        }

        private void btBiLoi_Click(object sender, EventArgs e)
        {
            this.cboJobStatus.SelectedValue = JobNhapLieuStatus.BiLoi;
            this.job_SPGocNhapLieuTableAdapter.UpdateQuery_Status(JobNhapLieuStatus.BiLoi, DateTime.Now, Common.Obj2Int(iDJobTextBox.Text));
            this.job_SPGocNhapLieuLogTableAdapter.DeleteQuery_IDJob_IDStatus(Common.Obj2Int(iDJobTextBox.Text), JobNhapLieuStatus.BiLoi);
            this.job_SPGocNhapLieuLogTableAdapter.Insert(Common.Obj2Int(iDJobTextBox.Text), JobNhapLieuStatus.BiLoi, DateTime.Now);
            this.gridControl2.Focus();
            var statusjob = (int)cboJobStatus.SelectedItem;
            if (statusjob != JobNhapLieuStatus.BiLoi)
            {
                long idProduct = Common.Obj2Int64(iDProductTextBox.Text);
                LogJobAdapter.SaveLog(JobName.FrmEditeProductByCat_Chuyen_trang_thai_san_pham, "Chuyển trạng thái sản phẩm sang Bị lỗi", idProduct, (int)JobTypeData.Product);
            }
        }

        private void toolStripButtonDeleteAllthuocTinh_Click(object sender, EventArgs e)
        {
            this.productPropertiesBindingSource.MoveFirst();
            if (this.productPropertiesBindingSource.Count > 0)
            {
                for (int i = 0; i < this.productPropertiesBindingSource.Count; i++)
                {
                    //if (this.productPropertiesBindingSource.Count > 0)
                    //{
                    this.productPropertiesBindingSource.RemoveCurrent();
                    this.productPropertiesBindingSource.EndEdit();
                    //    this.productPropertiesBindingSource.MoveNext();
                    //}
                }
                LogJobAdapter.SaveLog(JobName.FrmEditeProductByCat_Xoa_het_gia_tri_thuoc_tinh, string.Format("Xóa hết giá trị thuộc tính của sản phẩm. Count = {0}", this.productPropertiesBindingSource.Count), Common.Obj2Int64(iDProductTextBox.Text), (int)JobTypeData.Product);
            }
        }

        private void btnGetNumberAddNewProduct_Click(object sender, EventArgs e)
        {
            Wait.Show("Get data from SQL...");
            //IDJob = 22
            string formatquerry = @"SELECT L.IDData, P.Name,L.LastUpdate,L.ContentJob FROM LogJob as L inner join Product as P ON L.IDData = P.ID  where IDJob = {0} and IDUser = {1} and L.LastUpdate > '{2}' and L.LastUpdate < '{3}'";
            string querry = "";
            if (rdbHomNay.Checked)
            {
                string start = DateTime.Now.ToString("yyyy-MM-dd") + " 0:00:00";
                string end = DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59";
                querry = string.Format(formatquerry, JobName.FrmEditeProductByCat_Them_moi_san_pham_goc, QT.Users.User.UserID, start, end);
            }
            else
            {
                string start = DateTime.Now.AddDays(-6).ToString("yyyy-MM-dd") + " 0:00:00";
                string end = DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59";
                querry = string.Format(formatquerry, JobName.FrmEditeProductByCat_Them_moi_san_pham_goc, QT.Users.User.UserID, start, end);
            }

            SqlDb sqldb = new SqlDb(Server.ConnectionString);
            DataTable _productTable = new DataTable();
            try
            {
                _productTable = sqldb.GetTblData(querry, CommandType.Text, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
            gridControl1.DataSource = _productTable;
            Wait.Close();
        }

    }
}
