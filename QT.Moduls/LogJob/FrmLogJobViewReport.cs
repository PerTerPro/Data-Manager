using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.LogJob
{
    public partial class FrmLogJobViewReport : Form
    {
        public FrmLogJobViewReport()
        {
            InitializeComponent();
            ctrDateRanger1.FromDate = DateTime.Now;
            ctrDateRanger1.ToDate = DateTime.Now;
        }

        private void FrmLogJobViewReport_Load(object sender, EventArgs e)
        {
            this.jobTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.logJobTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.tblUserTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.tblUserTableAdapter.Fill(this.dBLogJob.tblUser);
            //searchLookUpEditUser.EditValue = dBLogJob.tblUser.Rows[0]["ID"];
            this.jobTableAdapter.Fill(this.dBLogJob.Job);
            #region
            DataTable dtTypeData = new DataTable();
            dtTypeData.Columns.Add("TypeData", typeof(string));
            dtTypeData.Columns.Add("IDTypeData", typeof(int));
            DataRow dr = dtTypeData.NewRow();
            dr["TypeData"] = "Không xác định";
            dr["IDTypeData"] = JobTypeData.KhongXacDinh;
            dtTypeData.Rows.Add(dr);
            DataRow dr1 = dtTypeData.NewRow();
            dr1["TypeData"] = "Company";
            dr1["IDTypeData"] = JobTypeData.Company;
            dtTypeData.Rows.Add(dr1);
            DataRow dr2 = dtTypeData.NewRow();
            dr2["TypeData"] = "Product";
            dr2["IDTypeData"] = JobTypeData.Product;
            dtTypeData.Rows.Add(dr2);
            repositoryItemLookUpEditTypeData.DataSource = dtTypeData;
            #endregion
        }
        private void simpleButtonLoadData_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang tải dữ liệu...");
            DateTime fromDate = ctrDateRanger1.FromDate;
            DateTime toDate = ctrDateRanger1.ToDate;
            if (checkEditAll.Checked)
            {
                try
                {
                    if (checkEditData.Checked)
                        logJobTableAdapter.FillBy_DateTimeAllAndData(dBLogJob.LogJob, fromDate, toDate);
                    else
                        logJobTableAdapter.FillBy_DateTimeAll(dBLogJob.LogJob, fromDate, toDate);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR " + ex);
                }
            }
            else
            {
                if (searchLookUpEditUser.EditValue != null)
                {
                    int iduser = 0;
                    int.TryParse(searchLookUpEditUser.EditValue.ToString(), out iduser);
                    if (iduser == 0)
                    {
                        MessageBox.Show("Chọn user!");
                        searchLookUpEditUser.Focus();
                    }
                    else
                    {
                        LoadLogUser(iduser, fromDate, toDate);
                    }
                }
                else
                {
                    MessageBox.Show("Chọn user!");
                    searchLookUpEditUser.Focus();
                }
            }
            Wait.Close();
        }
        private void LoadLogUser(int iduser, DateTime fromDate, DateTime toDate)
        {
            dBLogJob.LogJob.Clear();
            try
            {
                if (checkEditData.Checked)
                    logJobTableAdapter.FillBy_DateTimeUserAndData(dBLogJob.LogJob, iduser, fromDate, toDate);
                else
                    logJobTableAdapter.FillBy_DateTimeUser(dBLogJob.LogJob, iduser, fromDate, toDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex);
            }
        }

        private void searchLookUpEditUser_EditValueChanged(object sender, EventArgs e)
        {
            Wait.Show("Đang tải dữ liệu...");
            if (searchLookUpEditUser.EditValue != null)
            {
                DateTime fromDate = ctrDateRanger1.FromDate;
                DateTime toDate = ctrDateRanger1.ToDate;
                int iduser = 0;
                int.TryParse(searchLookUpEditUser.EditValue.ToString(), out iduser);
                if (iduser != 0)
                {
                    iDTextEdit.Text = iduser.ToString();
                    string expression;
                    expression = "ID = " + iduser;
                    var x = dBLogJob.tblUser.Select(expression).FirstOrDefault();
                    departmentTextEdit.Text = x["Department"].ToString();
                    //LoadLogUser(iduser, fromDate, toDate);
                }
            }
            Wait.Close();
        }

        private void viewLogTheoDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long idData = Common.Obj2Int64(iDDataTextEdit.Text);
            FrmLogJobData frm = new FrmLogJobData();
            frm.LoadData(idData);
            frm.Show();
        }

        private void logJobGridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.logJobGridControl, new Point(e.X, e.Y));
            }
        }

        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            string caption = info.Column.Caption;
            if (info.Column.Caption == string.Empty)
                caption = info.Column.ToString();
            info.GroupText = string.Format("{0} : {1} (count= {2})", caption, info.GroupValueText, view.GetChildRowCount(e.RowHandle));
        }

        private bool expandgroup = true;
        private void simpleButtonExpandGroup_Click(object sender, EventArgs e)
        {
            if (expandgroup)
            {
                gridView1.CollapseAllGroups();
                expandgroup = false;
            }
            else
            {
                gridView1.ExpandAllGroups();
                expandgroup = true;
            }
        }

        private void simpleButtonExportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    //saveDialog.FileName = string.Format("{0}_click_date_{1}-{2}.xls", _domain, ctrBaseDateRange1.FromDate.ToString("dd_MM_yyyy"), ctrBaseDateRange1.ToDate.ToString("dd_MM_yyyy"));
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;
                    //NImageExporter imageExporter = chartControl.ImageExporter;
                    switch (fileExtenstion)
                    {
                        case ".xls":
                            logJobGridControl.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            logJobGridControl.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            logJobGridControl.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            logJobGridControl.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            logJobGridControl.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            logJobGridControl.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                }
            }
            MessageBox.Show("Export success!");
        }

        private void simpleButtonDetailsJob_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageDetails;
            DataTable dt = new DataTable();
            dt.Columns.Add("UserID", typeof(int));
            dt.Columns.Add("DayLog", typeof(DateTime));
            dt.Columns.Add("Morning", typeof(DateTime));
            dt.Columns.Add("CountMorning", typeof(int));
            dt.Columns.Add("Afternoon", typeof(DateTime));
            dt.Columns.Add("CountAfternoon", typeof(int));
            dt.Columns.Add("EndDate", typeof(DateTime));
            dt.Columns.Add("CountData", typeof(int));
            dt.Columns.Add("TotalCountData", typeof(int));
            try
            {
                int iduser = 0;
                int.TryParse(searchLookUpEditUser.EditValue.ToString(), out iduser);
                if (iduser != 0)
                {
                    DateTime fromDate = ctrDateRanger1.FromDate;
                    DateTime toDate = ctrDateRanger1.ToDate;
                    DateTime day = fromDate.Date;

                    while (day.Date <= toDate.Date)
                    {
                        DBLogJob.LogJobDataTable logjobtable = new DBLogJob.LogJobDataTable();
                        DBLogJob.LogJobDataTable logjobtablemorning = new DBLogJob.LogJobDataTable();
                        DBLogJob.LogJobDataTable logjobtableafternoon = new DBLogJob.LogJobDataTable();
                        try
                        {
                            logJobTableAdapter.FillBy_DateTimeUser(logjobtablemorning, iduser, day, day.AddHours(13).AddMilliseconds(-1));
                            logJobTableAdapter.FillBy_DateTimeUser(logjobtableafternoon, iduser, day.AddHours(13), day.AddDays(1).AddMilliseconds(-1));
                            logjobtable.Merge(logjobtablemorning);
                            logjobtable.Merge(logjobtableafternoon);
                        }
                        catch (Exception)
                        {
                        }
                        DataRow dr = dt.NewRow();
                        dr["UserID"] = iduser;
                        dr["DayLog"] = day.ToShortDateString();
                        if (logjobtablemorning.Rows.Count > 0)
                        {

                            dr["Morning"] = logjobtablemorning.Rows[0]["LastUpdate"];

                            var distinctIds = logjobtablemorning.AsEnumerable()
                                            .Select(s => new
                                            {
                                                id = s.Field<Int64>("IDData"),
                                            })
                                            .Distinct().ToList();
                            dr["CountMorning"] = distinctIds.Count;
                        }
                        else
                            dr["CountMorning"] = 0;

                        if (logjobtableafternoon.Rows.Count > 0)
                        {

                            dr["Afternoon"] = logjobtableafternoon.Rows[0]["LastUpdate"];

                            var distinctIds = logjobtableafternoon.AsEnumerable()
                                            .Select(s => new
                                            {
                                                id = s.Field<Int64>("IDData"),
                                            })
                                            .Distinct().ToList();
                            dr["CountAfternoon"] = distinctIds.Count;
                            dr["EndDate"] = logjobtableafternoon.Rows[logjobtableafternoon.Rows.Count - 1]["LastUpdate"];
                        }
                        else
                            dr["CountAfternoon"] = 0;
                        dr["TotalCountData"] = logjobtable.Rows.Count;
                        if (logjobtable.Rows.Count > 0)
                        {
                            var distinctIds = logjobtable.AsEnumerable()
                                            .Select(s => new
                                            {
                                                id = s.Field<Int64>("IDData"),
                                            })
                                            .Distinct().ToList();
                            dr["CountData"] = distinctIds.Count;
                        }
                        dt.Rows.Add(dr);
                        day = day.AddDays(1);
                    }
                    gridControlDetails.DataSource = dt;
                }
                else
                    MessageBox.Show("Chọn User!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void simpleButtonExportExcelDetails_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    //saveDialog.FileName = string.Format("{0}_click_date_{1}-{2}.xls", _domain, ctrBaseDateRange1.FromDate.ToString("dd_MM_yyyy"), ctrBaseDateRange1.ToDate.ToString("dd_MM_yyyy"));
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;
                    //NImageExporter imageExporter = chartControl.ImageExporter;
                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControlDetails.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControlDetails.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControlDetails.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControlDetails.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControlDetails.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControlDetails.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                    MessageBox.Show("Export success!");
                }
            }

        }

        private void simpleButtonViewReport2_Click(object sender, EventArgs e)
        {
            if (searchLookUpEditUser.EditValue != null)
            {
                int iduser = 0;
                int.TryParse(searchLookUpEditUser.EditValue.ToString(), out iduser);
                if (iduser == 0)
                {
                    MessageBox.Show("Chọn user!");
                    searchLookUpEditUser.Focus();
                }
                else
                {
                    int department = 0;
                    department = Common.Obj2Int(departmentTextEdit.Text);
                    switch (department)
                    {
                        case (int)UserDepartment.Code:
                            MessageBox.Show("Không có report cho bộ phận này!");
                            break;
                        case (int)UserDepartment.Config:
                            xtraTabControl1.SelectedTabPage = xtraTabPageReport;
                            gridControlReportConfig.DataSource = GetReport("prc_LogJob_ReportConfig", iduser);
                            break;
                        case (int)UserDepartment.Data:
                            xtraTabControl1.SelectedTabPage = xtraTabPageReportData;
                            gridControlReportData.DataSource = GetReport("prc_LogJob_ReportData", iduser);
                            break;
                        default:
                            MessageBox.Show("Không có report cho bộ phận này!");
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn user!");
                searchLookUpEditUser.Focus();
            }
        }
        public DataTable GetReport(string storerprocedure, int iduser)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(Server.ConnectionString);
                SqlCommand cmd = new SqlCommand(storerprocedure, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDUser", iduser);
                cmd.Parameters.AddWithValue("@FromDate", ctrDateRanger1.FromDate);
                cmd.Parameters.AddWithValue("@ToDate", ctrDateRanger1.ToDate);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
            return dt;
        }
        private void simpleButtonExcel2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    //saveDialog.FileName = string.Format("{0}_click_date_{1}-{2}.xls", _domain, ctrBaseDateRange1.FromDate.ToString("dd_MM_yyyy"), ctrBaseDateRange1.ToDate.ToString("dd_MM_yyyy"));
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;
                    //NImageExporter imageExporter = chartControl.ImageExporter;
                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControlDetails.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControlDetails.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControlDetails.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControlDetails.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControlDetails.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControlDetails.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                    MessageBox.Show("Export success!");
                }
            }

        }

        private void simpleButtonDepartment_Click(object sender, EventArgs e)
        {
            frmDepartment frm = new frmDepartment();
            frm.Show();
        }

        private void simpleButtonViewJobName_Click(object sender, EventArgs e)
        {
            frmJob frm = new frmJob();
            frm.Show();
        }

        private void btnReportDataAll_Click(object sender, EventArgs e)
        {
            DateTime fromDate = ctrDateRanger1.FromDate;
            DateTime toDate = ctrDateRanger1.ToDate;
            gridControl1.DataSource = GetReportDataConfigAll("prc_LogJob_ReportDataAll");
        }
        public DataTable GetReportDataConfigAll(string storerprocedure)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(Server.ConnectionString);
                SqlCommand cmd = new SqlCommand(storerprocedure, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FromDate", ctrDateRanger1.FromDate);
                cmd.Parameters.AddWithValue("@ToDate", ctrDateRanger1.ToDate);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
            return dt;
        }



        private SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
        #region View Original Product Count and Original Product Not Config
        private Dictionary<string, string> DicProductName = new Dictionary<string, string>();
        private void btnLoadEx_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                DicProductName = LoadFileToDic(openFileDialog1.FileName);
                txtPath.Text = openFileDialog1.FileName;
                txtPath.Enabled = false;
                lblTong.Text = DicProductName.Count.ToString();
            }
        }
        private Dictionary<string, string> LoadFileToDic(string path)
        {
            Dictionary<string, string> ProductName = new Dictionary<string, string>();

            foreach (var worksheet in Workbook.Worksheets(path))
                foreach (var row in worksheet.Rows)
                    foreach (var cell in row.Cells)
                    {
                        var a = cell;
                        if (cell != null && !ProductName.ContainsKey(cell.Text.Trim()))
                        {
                            ProductName.Add(cell.Text.Trim(), "");
                        }
                    }
            return ProductName;
        }
        private string Name = "";
        private string NameFT = "";
        private string NameSearch = "";
        private int Count = 0;
        private int Status = 0;
        private DataTable tblGetOrginalProductID = null;
        private DataTable tblTemp = new DataTable();
        private DataTable tblNeed = new DataTable();
        DataColumn dcName = new DataColumn("Name", typeof(string));
        DataColumn dcStatus = new DataColumn("Status", typeof(int));
        DataColumn dcCount = new DataColumn("Count", typeof(int));
        private long OriginalProductID = 0;

        private void btnAnalysic_Click(object sender, EventArgs e)
        {
            Thread Run = new Thread(() => AnalysicOriginalProductCount());
            Run.Start();
        }
        private void AnalysicOriginalProductCount()
        {
            tblNeed.Columns.Add(dcName);
            tblNeed.Columns.Add(dcStatus);
            tblNeed.Columns.Add(dcCount);
            int CountDone = 0;
            //tblNeed.Columns.Add(dcDetailUrl);
            foreach (var item in DicProductName)
            {
                Name = item.Key;
                NameFT = QT.Entities.Common.UnicodeToKoDauFulltext(Name);
                NameSearch = NameFT.Replace(" ", "*").Replace("(", "").Replace(")", "");
                tblGetOrginalProductID = sqldb.GetTblData("select ID, Status from Product where contains(NameFT,@NameSearch) and Company = 6619858476258121218", CommandType.Text, new SqlParameter[] { 
                    SqlDb.CreateParamteterSQL("@NameSearch",NameSearch,SqlDbType.NVarChar)
                });
                try
                {
                    OriginalProductID = QT.Entities.Common.Obj2Int64(tblGetOrginalProductID.Rows[0]["ID"]);
                    Status = QT.Entities.Common.Obj2Int(tblGetOrginalProductID.Rows[0]["Status"]);
                    tblTemp = sqldb.GetTblData("select Count(*) as Count from Product where ProductID = @OriginalProductID", CommandType.Text, new SqlParameter[]{
                            SqlDb.CreateParamteterSQL("@OriginalProductID",OriginalProductID,SqlDbType.BigInt)
                        });
                    Count = QT.Entities.Common.Obj2Int(tblTemp.Rows[0]["Count"]);
                    DataRow dr = tblNeed.NewRow();
                    dr["Name"] = Name;
                    dr["Status"] = Status;
                    dr["Count"] = Count;
                    tblNeed.Rows.Add(dr);
                    CountDone++;
                    this.Invoke(new Action(() =>
                    {
                        lblDone.Text = CountDone.ToString();
                    }));
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            gridControlOriginalProductCount.DataSource = tblNeed;
        }
        private void btnExport1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog OriginalsaveDialog = new SaveFileDialog())
            {
                OriginalsaveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (OriginalsaveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = OriginalsaveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;
                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControlOriginalProductCount.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControlOriginalProductCount.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControlOriginalProductCount.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControlOriginalProductCount.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControlOriginalProductCount.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControlOriginalProductCount.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                    MessageBox.Show("Export success!");
                }
            }
        }
        #endregion

        #region View Last Change Product

        private Dictionary<string, string> DicProductID = new Dictionary<string, string>();
        private DataTable tblProductID = new DataTable();
        long ProductIdToViewLastChange = 0;
        private void btnLoadExProductID_Click(object sender, EventArgs e)
        {
            DicProductID.Clear();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tblProductID = ReadDataFromExcelFile(openFileDialog1.FileName);
                txtFileEx.Text = openFileDialog1.FileName;
                txtFileEx.Enabled = false;
                lblB.Text = tblProductID.Rows.Count.ToString();
            }
        }
        private void btnAnalysicData_Click(object sender, EventArgs e)
        {
            Thread Run = new Thread(()=>AnalysicData());
            Run.Start();
        }
        DataTable tblViewAndExport = new DataTable();
        private void AnalysicData()
        {
            int CountProduct = 0;
            DataTable tblLastChange = null;
            DataColumn dcProductID = new DataColumn("ProductID", typeof(long));
            DataColumn dcUser = new DataColumn("User", typeof(string));
            DataColumn dcLastUpdate = new DataColumn("LastUpdate", typeof(string));
            tblViewAndExport.Columns.Add(dcProductID);
            tblViewAndExport.Columns.Add(dcUser);
            tblViewAndExport.Columns.Add(dcLastUpdate);
            foreach (DataRow RowProductID  in tblProductID.Rows)
            {
                ProductIdToViewLastChange = QT.Entities.Common.Obj2Int64(RowProductID["ID"]);
                tblLastChange = ViewLastChangeProduct(ProductIdToViewLastChange);
                if (tblLastChange.Rows.Count > 0)
                {
                    DataRow dr = tblViewAndExport.NewRow();
                    dr["ProductID"] = tblLastChange.Rows[0]["IDData"];
                    dr["User"] = tblLastChange.Rows[0]["UserName"];
                    dr["LastUpdate"] = tblLastChange.Rows[0]["LastUpdate"];
                    tblViewAndExport.Rows.Add(dr);
                    CountProduct++;
                    this.Invoke(new Action(() =>
                    {
                        lblA.Text = CountProduct.ToString();
                    }));
                }
                else
                {
                    DataRow dr = tblViewAndExport.NewRow();
                    dr["ProductID"] = ProductIdToViewLastChange;
                    dr["User"] = "no Data";
                    dr["LastUpdate"] = "no Data";
                    tblViewAndExport.Rows.Add(dr);
                    CountProduct++;
                    this.Invoke(new Action(() =>
                    {
                        lblA.Text = CountProduct.ToString();
                    }));
                }
            }

        }
        private DataTable ViewLastChangeProduct(long ProductID)
        {
            DataTable tbl = null;
            tbl = sqldb.GetTblData(@"select top 1 a.IDData,b.UserName,a.LastUpdate from LogJob a
                                                  inner join tblUser b
                                                  on a.IDUser = b.ID
                                                  where a.IDData = @ProductID
                                                  order by LastUpdate desc", CommandType.Text, new SqlParameter[] { SqlDb.CreateParamteterSQL("ProductID", ProductID, SqlDbType.BigInt) });
            return tbl;
        }
        private void btnViewLastChange_Click(object sender, EventArgs e)
        {
            gridControlLastChangeProduct.RefreshDataSource();
            gridControlLastChangeProduct.DataSource = tblViewAndExport;
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;
                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControlLastChangeProduct.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControlLastChangeProduct.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControlLastChangeProduct.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControlLastChangeProduct.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControlLastChangeProduct.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControlLastChangeProduct.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                    MessageBox.Show("Export success!");
                }
            }
        }
        private DataTable ReadDataFromExcelFile(string path)
        {
            //string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path.Trim() + ";Extended Properties=Excel 8.0";
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path.Trim() + ";Extended Properties=Excel 12.0;";
            // Tạo đối tượng kết nối
            OleDbConnection oledbConn = new OleDbConnection(connectionString);
            DataTable data = null;
            try
            {
                // Mở kết nối
                oledbConn.Open();

                // Tạo đối tượng OleDBCommand và query data từ sheet có tên "Keywords"
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", oledbConn);

                // Tạo đối tượng OleDbDataAdapter để thực thi việc query lấy dữ liệu từ tập tin excel
                OleDbDataAdapter oleda = new OleDbDataAdapter();

                oleda.SelectCommand = cmd;

                // Tạo đối tượng DataSet để hứng dữ liệu từ tập tin excel
                DataSet ds = new DataSet();

                // Đổ đữ liệu từ tập excel vào DataSet
                oleda.Fill(ds);

                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Đóng chuỗi kết nối
                oledbConn.Close();
            }
            return data;
        }
        #endregion
    }
}
