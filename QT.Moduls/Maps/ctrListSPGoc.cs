using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QT.Entities;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using QT.Entities.Data;

namespace QT.Moduls.Maps
{
    public partial class ctrListSPGoc : UserControl
    {
        public delegate void ProductIDChangedEventHandler(long IDProduct);
        public event ProductIDChangedEventHandler ProductIDChange;
        public ctrListSPGoc()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.UserSkins.OfficeSkins.Register();
            gridControl1.LookAndFeel.SetSkinStyle("Office 2007 Silver");
            comboBox1.SelectedIndex = 0;
        }
        public void InitForm()
        {
            this.productStatusTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.listClassificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productStatusTableAdapter.FillByMapID(this.dBPMan.ProductStatus);
            this.gridView1.ExpandAllGroups();
            this.listClassificationTableAdapter.Fill(this.dBPMan.ListClassification);
            this.treeList1.ExpandAll();
        }

        public void Save()
        {

        }

        public void LoadAllData()
        {

        }

        private void toolTaiLai_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang tải dữ liệu!");
            try
            {
                this.productTableAdapter.FillBy_AllProductID(this.dBPMan.Product);
                this.gridView1.ExpandAllGroups();
                this.xtraTabControl1.SelectedTabPageIndex = 1;
                LogJobAdapter.SaveLog(JobName.FrmManagerProduct_Load_All, "Click nút Load All nên ko có ID...", 0, (int)JobTypeData.KhongXacDinh);
            }
            catch (Exception)
            {

                throw;
            }
            Wait.Close();
        }

        private void toolTaiCat_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang tải dữ liệu!");
            try
            {
                //this.productTableAdapter.FillBy_CategoryID(this.dBPMan.Product, Common.Obj2Int(this.iDCategoryTextBox.Text.Trim()));
                this.dBPMan.Product.Rows.Clear();
                string cat = string.Format("c{0}_", Common.Obj2Int(this.iDCategoryTextBox.Text.Trim()).ToString("D3"));
                if (checkLoadConfig.Checked)
                {
                    this.productTableAdapter.FillBy_SPGoc_LikeContentFTGetByStatusConfig(this.dBPMan.Product, cat);
                }
                else
                {
                    this.productTableAdapter.FillBy_SPGoc_LikeContentFT(this.dBPMan.Product, cat);
                }
                this.gridView1.ExpandAllGroups();
                this.xtraTabControl1.SelectedTabPageIndex = 1;
                LogJobAdapter.SaveLog(JobName.FrmManagerProduct_Load_Cat, "Click load Cat nên ko có ID...", 0, (int)JobTypeData.KhongXacDinh);
            }
            catch (Exception)
            {

            }
            Wait.Close();
        }

        private void txtIDProduct_TextChanged(object sender, EventArgs e)
        {
            ProductIDChange(Common.Obj2Int64(txtIDProduct.Text));
        }

        private void toolLoadCheck_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.FillBy_GiaChenh(this.dBPMan.Product);
                this.gridView1.ExpandAllGroups();
                this.xtraTabControl1.SelectedTabPageIndex = 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btSaveProduct_Click(object sender, EventArgs e)
        {
            this.productBindingSource.EndEdit();
            this.productTableAdapter.Update(dBPMan.Product);
        }

        private void btMyJob_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.FillBy_JobUserID(this.dBPMan.Product, QT.Users.User.UserID);
                this.gridView1.ExpandAllGroups();
                this.xtraTabControl1.SelectedTabPageIndex = 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void ExportExcelButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;
                    //NImageExporter imageExporter = chartControl.ImageExporter;
                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControl3.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControl3.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl3.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControl3.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl3.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl3.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                }
            }
            MessageBox.Show("Export Excel to Documents");
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void LoadViewCount30Button_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang tải dữ liệu!");
            try
            {
                //this.productTableAdapter.FillBy_CategoryID(this.dBPMan.Product, Common.Obj2Int(this.iDCategoryTextBox.Text.Trim()));
                this.dBPMan.Product.Rows.Clear();
                this.productTableAdapter.FillByViewCount30(this.dBPMan.Product);
                this.gridView1.ExpandAllGroups();
                this.xtraTabControl1.SelectedTabPageIndex = 1;
            }
            catch (Exception)
            {

            }
            Wait.Close();
        }

        private void LoadAllSPGocButton_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang tải dữ liệu!");
            try
            {
                //this.productTableAdapter.FillBy_CategoryID(this.dBPMan.Product, Common.Obj2Int(this.iDCategoryTextBox.Text.Trim()));
                this.dBPMan.Product.Rows.Clear();
                this.productTableAdapter.FillBy_SPGoc_TrungTen(this.dBPMan.Product);
                this.gridView1.ExpandAllGroups();
                this.xtraTabControl1.SelectedTabPageIndex = 1;
            }
            catch (Exception)
            {

            }
            Wait.Close();
        }
        DataTable dt;
        private void LoadCompany_Click(object sender, EventArgs e)
        {
            dt = classificationTableAdapter.GetDataCompanyCountProductByClassification();
            int countrow = dt.Rows.Count;
            int biencheck = 0;
            long idcompany = 0;
            int temp = 0;
            while (biencheck < countrow)
            {
                if (biencheck == 0)
                {
                    temp = 1;
                    idcompany = long.Parse(dt.Rows[0]["IDCompany"].ToString());
                    biencheck = 1;
                }
                else
                {
                    long idcompanytemp = long.Parse(dt.Rows[biencheck]["IDCompany"].ToString());
                    if (idcompanytemp == idcompany)
                    {
                        if (temp == 10)
                        {
                            dt.Rows.RemoveAt(biencheck);
                            countrow--;
                        }
                        else
                        {
                            temp++;
                            biencheck++;
                        }
                    }
                    else
                    {
                        idcompany = idcompanytemp;
                        temp = 1;
                        biencheck++;
                    }
                }
            }
            gridControl2.DataSource = dt;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;
                    //NImageExporter imageExporter = chartControl.ImageExporter;
                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControl3.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControl3.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl3.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControl3.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl3.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl3.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                }
            }
            MessageBox.Show("Export Excel to Documents");
        }

        DataTable dataCompany;
        private void ExportExcelButton2_Click(object sender, EventArgs e)
        {
            int page = int.Parse(comboBox1.Text);
            if (page > 0)
            {
                dataCompany = new DataTable();
                dataCompany = companyTableAdapter.GetDataByTotalViewMonthPaging((page - 1) * 2000, 2000);
                dataCompany.Columns.Add("LienHe", typeof(string));
                dataCompany.Columns.Add("GhiChu", typeof(string));
                for (int i = 0; i < dataCompany.Rows.Count; i++)
                {
                    string lienhe = dataCompany.Rows[i]["Address"].ToString();
                    long IDCompany = long.Parse(dataCompany.Rows[i]["ID"].ToString());
                    //Update lại thông tin liên hệ nếu Address là trống cập nhật vào trường liên hệ
                    if (lienhe == "")
                    {
                        DataTable addresstemp = new DataTable();
                        addresstemp = company_AddressTableAdapter.GetDataByIDCompany(IDCompany);
                        if (addresstemp.Rows.Count > 0)
                        {
                            for (int j = 0; j < addresstemp.Rows.Count; j++)
                            {
                                lienhe += addresstemp.Rows[j]["Name"].ToString() + ", " + addresstemp.Rows[j]["SoNha"].ToString() + ", " + addresstemp.Rows[j]["Duong"].ToString() + ", " + addresstemp.Rows[j]["Pho"].ToString() + ", " + addresstemp.Rows[j]["QuanHuyen"].ToString() + ", " + addresstemp.Rows[j]["ThanhPho"].ToString() + ",(*" + addresstemp.Rows[j]["Phone"].ToString() + "," + addresstemp.Rows[j]["Fax"].ToString() + "*)";
                            }
                        }
                        dataCompany.Rows[i]["LienHe"] = lienhe;
                    }
                    else
                    {
                        dataCompany.Rows[i]["LienHe"] = dataCompany.Rows[i]["Address"].ToString() + ",(*" + dataCompany.Rows[i]["Phone"].ToString() + ", " + dataCompany.Rows[i]["Fax"].ToString() + "*)";
                    }
                    //Lấy danh sách top 2 Classification có số Product nhiều nhất
                    string ghichu = string.Empty;
                    DataTable classtemp = new DataTable();
                    try
                    {
                        classtemp = classificationTableAdapter.GetDataByTop2Classification(IDCompany);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    if (classtemp.Rows.Count > 0)
                    {
                        for (int k = 0; k < classtemp.Rows.Count; k++)
                        {
                            string tempx = classtemp.Rows[k]["Name"].ToString() + ",";
                            ghichu += tempx;
                        }
                    }
                    dataCompany.Rows[i]["GhiChu"] = ghichu;
                }
                MessageBox.Show("Xong!");
            }
        }
        /// <summary>
        /// Export ra Excel với trường hợp máy có cài Excel
        /// Hay bị lỗi phiên bản excel
        /// </summary>
        /// <param name="dt"></param>
        private void ExportToExcel(DataTable dt)
        {
            //Excel.Application xlApp;
            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;
            //xlApp = new Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Add(misValue);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //string data = null;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dt.Columns.Count; j++)
            //    {
            //        data = dt.Rows[i].ItemArray[j].ToString();
            //        xlWorkSheet.Cells[i + 1, j + 1] = data;
            //    }
            //}
            //string namefile = "Product" + DateTime.Now.ToString("dd.MM.yyyy") + ".xls";

            //xlWorkBook.SaveAs(namefile, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            //releaseObject(xlApp);
        }

        private void DeleteSPGocTrungTenButton_Click(object sender, EventArgs e)
        {
            try
            {
                productTableAdapter.DeleteSPGocTrungTen();
                LogJobAdapter.SaveLog(JobName.FrmManagerProduct_Xoa_trung_ten, "Xóa các sản phẩm gốc bị trùng tên, nên k có ID", 0, (int)JobTypeData.KhongXacDinh);
                MessageBox.Show("Xoá thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error {0}", ex.Message);
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;
                    //NImageExporter imageExporter = chartControl.ImageExporter;
                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControl4.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControl4.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl4.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControl4.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl4.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl4.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                }
            }
            MessageBox.Show("Export Excel to Documents");
        }

        private void LoadProductCompanyButton_Click(object sender, EventArgs e)
        {
            long idcompany = Common.Obj2Int64(IdCompanytextEdit.Text);
            DBMapTableAdapters.ProductTableAdapter productAdapter = new DBMapTableAdapters.ProductTableAdapter();
            productAdapter.Connection.ConnectionString = Server.ConnectionString;
            DBMap.ProductDataTable producttable = new DBMap.ProductDataTable();
            productAdapter.FillBy_Company(producttable, idcompany);
            gridControl4.DataSource = producttable;
        }

        private void btnGetNumberAddNewProduct_Click(object sender, EventArgs e)
        {
            Wait.Show("Get data from SQL...");
            //IDJob = 22
            var formatquerry = @"SELECT L.IDData, P.Name,L.LastUpdate,L.ContentJob FROM LogJob as L inner join Product as P ON L.IDData = P.ID  where IDJob = {0} and IDUser = {1} and Status = 11 and Valid = 0 and L.LastUpdate > '{2}' and L.LastUpdate < '{3}'";
            if (checkEditLoadAllNew.Checked)
            {
                formatquerry = @"SELECT L.IDData, P.Name,L.LastUpdate,L.ContentJob FROM LogJob as L inner join Product as P ON L.IDData = P.ID  where IDJob = {0} and IDUser = {1} and L.LastUpdate > '{2}' and L.LastUpdate < '{3}'";
            }

            var querry = "";
            if (rdbHomNay.Checked)
            {
                var start = DateTime.Now.ToString("yyyy-MM-dd") + " 0:00:00";
                var end = DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59";
                querry = string.Format(formatquerry, JobName.FrmEditeProductByCat_Them_moi_san_pham_goc, QT.Users.User.UserID, start, end);
            }
            else
            {
                var start = DateTime.Now.AddDays(-6).ToString("yyyy-MM-dd") + " 0:00:00";
                var end = DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59";
                querry = string.Format(formatquerry, JobName.FrmEditeProductByCat_Them_moi_san_pham_goc, QT.Users.User.UserID, start, end);
            }

            var sqldb = new SqlDb(Server.ConnectionString);
            var productTable = new DataTable();
            try
            {
                productTable = sqldb.GetTblData(querry, CommandType.Text, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gridControl5.DataSource = productTable;
            Wait.Close();
        }

        private void gridView5_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                txtIDDataNew.Text = gridView5.GetRowCellValue(e.RowHandle, "IDData").ToString();
            }
        }

        private void txtIDDataNew_EditValueChanged(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPageNew && !string.IsNullOrEmpty(txtIDDataNew.Text))
            {
                txtIDProduct.Text = txtIDDataNew.Text;
            }
        }
    }
}
