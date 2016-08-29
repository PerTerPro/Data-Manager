using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QT.Entities;
using System.Data.SqlClient;

namespace QT.Users
{
    public partial class frmPhanCongNhapDuLieuSanPhamGoc : QT.Entities.frmBase
    {
        #region Private
        private bool expand = false;
        #endregion
        #region Constructor
        public frmPhanCongNhapDuLieuSanPhamGoc()
        {
            InitializeComponent();
        }
        private void frmPhanCongNhapDuLieuSanPhamGoc_Load(object sender, EventArgs e)
        {
            this.productJobUserTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.job_SPGocNhapLieuTempTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.job_SPGocNhapLieuLogTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.job_SPGocNhapLieuTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.job_NhapLieuStatusTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.tblUserTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.listClassificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            RefreshData();
        }
        #endregion
        #region Event Button
        private void btLoadCat_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void btExpanCat_Click(object sender, EventArgs e)
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
        private void btPhanTichLai_Click(object sender, EventArgs e)
        {
            PhanTichLai();
        }
        private void btReLoadAllProduct_Click(object sender, EventArgs e)
        {
            PhanTichLaiGetALL();
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            int idClassification = QT.Entities.Common.Obj2Int(this.iDClassificationTextBox.Text);
            string idclass = String.Format(@"""c{0}""", idClassification.ToString("D3"));
            int viewcount = QT.Entities.Common.Obj2Int(txtViewCount.Text.Trim());
            if (viewcount == 0)
            {
                this.productTableAdapter.FillBy_CategoryLikeName(dBPhanSP.Product, idclass, "%" + this.txtNameSearch.Text.Trim() + "%");
            }
            else
            {
                this.productTableAdapter.FillBy_CategoryLikeName_ViewCount(dBPhanSP.Product, idclass, "%" + this.txtNameSearch.Text.Trim() + "%", viewcount);
            }
        }
        private void btDay_Click(object sender, EventArgs e)
        {
            //int idClassification = QT.Entities.Common.Obj2Int(this.iDClassificationTextBox.Text);
            int idUser = Common.Obj2Int(this.iDUserSelectTextBox.Text);
            Wait.Show("Đẩy dữ liệu");
            for (int x = gridView1.GetSelectedRows().Length - 1; x>=0 ; x--)
            {
                try
                {
                    int i = gridView1.GetSelectedRows()[x];
                    long idProduct = Common.Obj2Int64(gridView1.GetDataRow(i)["ID"].ToString());
                    if (idProduct!=0)
                    {
                        int idClassification = Common.Obj2Int(gridView1.GetDataRow(i)["CategoryID"].ToString());
                        string keysearch = GetFilterCategory(idClassification);
                        this.job_SPGocNhapLieuTableAdapter.InsertQuery(
                            idProduct,
                            idUser,
                            idClassification,
                            QT.Entities.Common.JobNhapLieuStatus.Job_TaoMoi,
                            DateTime.Now, keysearch);
                        //Wait.Show(String.Format("Đẩy dữ liệu {0}/{1}", i + 1, dBPhanSP.Product.Count));
                        DataRow[] drr = dBPhanSP.Product.Select("ID=' " + idProduct + " ' ");
                        foreach (var row in drr)
                            row.Delete();
                    }
                }
                catch (Exception)
                {     
                }
            }
            Wait.Close();
            //PhanTichLai();
            dBPhanSP.Product.AcceptChanges();
        }
        private void btTaiJobUser_Click(object sender, EventArgs e)
        {
            int idUser = Common.Obj2Int(this.iDUserSelectTextBox.Text);
            dBPhanSP.EnforceConstraints = false;
            this.productJobUserTableAdapter.FillBy_UserID(dBPhanSP.ProductJobUser, idUser);
            this.gridView2.ExpandAllGroups();
        }
        private void btXoaCongViecUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Bạn có muốn xóa sản phẩm đã chọn khỏi user: " + this.userNameSelectTextBox.Text, "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idUser = Common.Obj2Int(this.iDUserSelectTextBox.Text);
                for (int x = gridView2.GetSelectedRows().Length - 1; x >= 0; x--)
                {
                    try
                    {
                        int i = gridView2.GetSelectedRows()[x];
                        long idProduct = Common.Obj2Int64(gridView2.GetDataRow(i)["ID"].ToString());
                        if (idProduct!= 0)
                        {
                            this.job_SPGocNhapLieuTableAdapter.DeleteByIDProduct(idProduct);
                        }
                    }
                    catch (Exception)
                    {    
                    }
                }                                 
                //this.job_SPGocNhapLieuTableAdapter.DeleteQuery_IDUser_MoiTao(idUser);
            }
            this.dBPhanSP.ProductJobUser.AcceptChanges();
            btTaiJobUser_Click(null,null);
        }
        private void ViewInfoAssignButton_Click(object sender, EventArgs e)
        {
            Wait.Show("Vui lòng đợi!Khoảng 3-5p");
            //listClassificationTableAdapter.FillByCountAssign(dBPhanSP.ListClassification);
            for (int i = 0; i < dBPhanSP.ListClassification.Rows.Count; i++)
            {
                int idclass = 0;
                int.TryParse(dBPhanSP.ListClassification.Rows[i]["ID"].ToString(), out idclass);
                string key = string.Format(@"c{0}", idclass.ToString("D3"));
                listClassificationTableAdapter.UpdateInfoAssignment(key,idclass);
            }
            this.listClassificationTableAdapter.Fill(this.dBPhanSP.ListClassification);
            Wait.Close();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang tải dữ liệu!");
            int id = 0;
            int.TryParse(treeList1.FocusedNode[treeList1.KeyFieldName].ToString(), out id);
            string abc = String.Format(@"""c{0}""", id.ToString("D3"));
            this.productTableAdapter.FillByCategoryNotAssigned(dBPhanSP.Product, abc);
            Wait.Close();
            gridView1.ClearSelection();
            gridView1.ExpandAllGroups();
        }
        private void Select500Button_Click(object sender, EventArgs e)
        {
            int count = gridView1.RowCount;
            if (count >= 500)
            {
                count = 500;
            }
            for (int i = 0; i < count; i++)
                gridView1.SelectRow(i);
        }

        private void Select1000Button_Click(object sender, EventArgs e)
        {
            int count = gridView1.RowCount;
            if (count >= 1000)
            {
                count = 1000;
            }
            for (int i = 0; i < 1000; i++)
                gridView1.SelectRow(i);
        }
        #endregion
        #region Method
        public override bool RefreshData()
        {
            Wait.Show("Đang load dữ liệu. Đợi chờ trong ít phút");
            this.job_NhapLieuStatusTableAdapter.Fill(dBPhanSP.Job_NhapLieuStatus);
            this.tblUserTableAdapter.FillBy_Active(this.dB.tblUser);
            this.listClassificationTableAdapter.Fill(this.dBPhanSP.ListClassification);
            if (tblUserBindingSource.Count > 0)
            {
                this.cboListUser.SelectedIndex = 0;
            }
            Wait.Close();
            return true;
        }

        /// <summary>
        ///  tải lại toàn bộ dữ liệu đã được phân công
        /// </summary>
        /// <returns></returns>
        public bool RefreshDataRe()
        {
            this.job_NhapLieuStatusTableAdapter.Fill(dBPhanSP.Job_NhapLieuStatus);
            this.tblUserTableAdapter.FillBy_Active(this.dB.tblUser);
            this.listClassificationTableAdapter.Fill(this.dBPhanSP.ListClassification);
            if (tblUserBindingSource.Count > 0)
            {
                this.cboListUser.SelectedIndex = 0;
            }
            return true;
        }
        private void PhanTichLaiGetALL()
        {
            /// xóa toàn bộ bảng temp đi
            this.job_SPGocNhapLieuTempTableAdapter.DeleteQueryALL();
            /// 
            /// tìm tất cả các sản phẩm trong chuyên mục insert vào
            int idClassification = QT.Entities.Common.Obj2Int(this.iDClassificationTextBox.Text);
            DBPhanSP.ProductDataTable dtFullSP = new DBPhanSP.ProductDataTable();
            this.productTableAdapter.FillBy_Category(dtFullSP, idClassification);
            /// Tìm tất cả các sản phẩm đã được phân công
            DBPhanSP.Job_SPGocNhapLieuDataTable dtSPDaPhan = new DBPhanSP.Job_SPGocNhapLieuDataTable();
            job_SPGocNhapLieuTableAdapter.FillBy_IDClassification(dtSPDaPhan, idClassification);
            List<long> lsIDDaPhan = new List<long>();
            int index = 0;
            foreach (DBPhanSP.Job_SPGocNhapLieuRow dr in dtSPDaPhan)
            {
                index = lsIDDaPhan.BinarySearch(dr.IDProduct);
                if (index < 0)
                {
                    lsIDDaPhan.Insert(~index, dr.IDProduct);
                }
            }

            /// 
            /// check xem sản phẩm nào chưa được phân bổ insert vào
            DBPhanSP.Job_SPGocNhapLieuTempDataTable dbBulkCopy = new DBPhanSP.Job_SPGocNhapLieuTempDataTable();
            int a = 1;
            foreach (DBPhanSP.ProductRow dr in dtFullSP)
            {
                //index = lsIDDaPhan.BinarySearch(dr.ID);
                //if (index < 0)
                //{
                //insert temp
                dbBulkCopy.Rows.Add(-a, dr.ID, idClassification);
                //this.job_SPGocNhapLieuTempTableAdapter.Insert(dr.ID, idClassification);
                Wait.Show(string.Format("{0}/{1}", a, dtFullSP.Rows.Count));
                a++;
                //}
            }
            dbBulkCopy.AcceptChanges();
            Wait.Show("Insert to database temp");
            SqlConnection sqlConn = new SqlConnection(QT.Entities.Server.ConnectionString);
            sqlConn.Open();
            var bulkCopyVisited = new SqlBulkCopy(sqlConn);
            bulkCopyVisited.DestinationTableName = "job_SPGocNhapLieuTemp";
            bulkCopyVisited.WriteToServer(dbBulkCopy);
            if (sqlConn.State != ConnectionState.Closed) sqlConn.Close();
            Wait.Close();
            //this.productTableAdapter.FillBy_Temp_CategoryLikeName(dBPhanSP.Product, idClassification, "%" + this.txtNameSearch.Text.Trim() + "%");
        }
        private void PhanTichLai()
        {
            /// xóa toàn bộ bảng temp đi
            this.job_SPGocNhapLieuTempTableAdapter.DeleteQueryALL();
            /// 
            /// tìm tất cả các sản phẩm trong chuyên mục insert vào
            int idClassification = QT.Entities.Common.Obj2Int(this.iDClassificationTextBox.Text);
            DBPhanSP.ProductDataTable dtFullSP = new DBPhanSP.ProductDataTable();
            this.productTableAdapter.FillBy_Category(dtFullSP, idClassification);
            /// Tìm tất cả các sản phẩm đã được phân công
            DBPhanSP.Job_SPGocNhapLieuDataTable dtSPDaPhan = new DBPhanSP.Job_SPGocNhapLieuDataTable();
            job_SPGocNhapLieuTableAdapter.FillBy_IDClassification(dtSPDaPhan, idClassification);
            List<long> lsIDDaPhan = new List<long>();
            int index = 0;
            foreach (DBPhanSP.Job_SPGocNhapLieuRow dr in dtSPDaPhan)
            {
                index = lsIDDaPhan.BinarySearch(dr.IDProduct);
                if (index < 0)
                {
                    lsIDDaPhan.Insert(~index, dr.IDProduct);
                }
            }

            /// 
            /// check xem sản phẩm nào chưa được phân bổ insert vào
            DBPhanSP.Job_SPGocNhapLieuTempDataTable dbBulkCopy = new DBPhanSP.Job_SPGocNhapLieuTempDataTable();
            int a = 1;
            foreach (DBPhanSP.ProductRow dr in dtFullSP)
            {
                index = lsIDDaPhan.BinarySearch(dr.ID);
                if (index < 0)
                {
                    //insert temp
                    dbBulkCopy.Rows.Add(-a, dr.ID, idClassification);
                    //this.job_SPGocNhapLieuTempTableAdapter.Insert(dr.ID, idClassification);
                    Wait.Show(string.Format("{0}/{1}", a, dtFullSP.Rows.Count));
                    a++;
                }
            }
            dbBulkCopy.AcceptChanges();
            Wait.Show("Insert to database temp");
            SqlConnection sqlConn = new SqlConnection(QT.Entities.Server.ConnectionString);
            sqlConn.Open();
            var bulkCopyVisited = new SqlBulkCopy(sqlConn);
            bulkCopyVisited.DestinationTableName = "job_SPGocNhapLieuTemp";
            bulkCopyVisited.WriteToServer(dbBulkCopy);
            if (sqlConn.State != ConnectionState.Closed) sqlConn.Close();
            Wait.Close();
            //this.productTableAdapter.FillBy_Temp_CategoryLikeName(dBPhanSP.Product, idClassification, "%" + this.txtNameSearch.Text.Trim() + "%");
        }
        #endregion
        #region Event
        private void txtNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSearch_Click(null, null);
            }
        }
        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang cập nhật!");
            for (int i = 0; i < dBPhanSP.ListClassification.Rows.Count; i++)
            {
                int idclass = 0;
                int.TryParse(dBPhanSP.ListClassification.Rows[i]["ID"].ToString(), out idclass);
                string key = GetFilterCategory(idclass);
                listClassificationTableAdapter.UpdateListIDSearch(key, idclass);
            }
            dBPhanSP.ListClassification.AcceptChanges();
            Wait.Close();
        }
        Dictionary<int, String> dicCateFilter = new Dictionary<int, string>();
        private string GetFilterCategory(int categoryID)
        {
            if (dicCateFilter.ContainsKey(categoryID))
            {
                return dicCateFilter[categoryID];
            }
            else
            {
                //codeContains = String.Format(@"""c{0}""", objCat.ID.ToString("D3"));
                String r = String.Format("c{0}", categoryID.ToString("D3"));
                DBPhanSP.ListClassificationDataTable dt = new DBPhanSP.ListClassificationDataTable();
                DBPhanSPTableAdapters.ListClassificationTableAdapter adt = new DBPhanSPTableAdapters.ListClassificationTableAdapter();
                adt.Connection.ConnectionString = Server.ConnectionString;
                adt.FillBy_SelectOne(dt, categoryID);
                if (dt.Rows.Count > 0)
                {
                    int idParent = Common.Obj2Int(dt.Rows[0]["ParentID"]);
                    if (idParent != 0)
                        r += " " + GetFilterCategory(idParent);
                }
                dt.Dispose();
                adt.Dispose();
                dicCateFilter[categoryID] = r;
                return r;
            }

        }

        private bool checkexpan = false;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (!checkexpan)
            {
                gridView1.ExpandAllGroups();
                checkexpan = true;
            }
            else
                {
                gridView1.CollapseAllGroups();
                checkexpan = false;
            }
            
        }
    }
   
}
