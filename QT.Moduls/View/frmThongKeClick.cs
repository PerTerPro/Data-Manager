using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace QT.Moduls.View
{
    public partial class frmThongKeClick : QT.Entities.frmBase
    {
        public frmThongKeClick()
        {
            InitializeComponent();
        }
        private long _idCompany = 0;
        private string _domain = "";
        public frmThongKeClick(long idCompany, string domain)
        {
            InitializeComponent();
            _idCompany = idCompany;
            this.laDomain.Text = domain;
            _domain = domain;
            ctrBaseDateRange1.ToDate = DateTime.Now;
            ctrBaseDateRange1.FromDate = DateTime.Now;
        }
        public void InitData()
        {
            this.viewProductLogTableAdapter.Connection.ConnectionString = QT.Entities.Server.LogConnectionString;
            this.companyTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.product_LogsAddProductTableAdapter.Connection.ConnectionString = QT.Entities.Server.LogConnectionString;
            this.prc_ProductLog_ThongKeClickTableAdapter.Connection.ConnectionString = QT.Entities.Server.LogConnectionString;
            //this.product_LogsAddProductTableAdapter.FillBy_DistinctCompany(this.dBView.Product_LogsAddProduct, _idCompany);
            this.cboDonVi.SelectedIndex = 0;
            //this.companyTableAdapter.FillBy_StatusPage(this.dBCom.Company, QT.Entities.Common.CompanyStatus.CONFIG, 1, 1000000);
        }
        public override bool RefreshData()
        {
            try
            {
                //this.colDateLog.Visible = false;
                //this.colYear.Visible = false;
                //this.colMonth.Visible = false;
                //this.colDay.Visible = false;
                //this.colHours.Visible = false;
                //this.colName.Visible = false;
                //this.colURL.Visible = false;
                //this.colCounts.Visible = false;
                //this.cboCompany.EditValue = _idCompany;
                //this.viewProductLogTableAdapter.FillBy_IDCompanyDateRange(this.dBView.ViewProductLog, ctrBaseDateRange1.FromDate, ctrBaseDateRange1.ToDate, _idCompany);
                QT.Entities.Wait.Show("Đang load dữ liệu!");
                //switch (cboDonVi.SelectedIndex)
                //{
                //    case 0: //giây
                //        this.colDateLog.Visible = true;
                //        //this.colCounts.Visible = false;
                //        //this.colName.Visible = true;
                //        //this.colURL.Visible = true;
                //        this.viewProductLogTableAdapter.FillBy_ThongKeNew(this.dBView.ViewProductLog, _idCompany, ctrBaseDateRange1.FromDate, ctrBaseDateRange1.ToDate);
                //        break;
                //    case 1: //giờ
                //        //this.colYear.Visible = true;
                //        //this.colYear.VisibleIndex = 0;
                //        //this.colMonth.Visible = true;
                //        //this.colMonth.VisibleIndex = 1;
                //        //this.colDay.Visible = true;
                //        //this.colDay.VisibleIndex = 2;
                //        //this.colHours.Visible = true;
                //        //this.colHours.VisibleIndex = 3;
                //        //this.colCounts.Visible = true;
                //        //this.colCounts.VisibleIndex = 4;
                //        this.colDateLog.Visible = false;
                //        //this.colName.Visible = false;
                //        //this.colURL.Visible = false;
                //        //this.viewProductLogTableAdapter.FillBy_Group_Gio(this.dBView.ViewProductLog, ctrBaseDateRange1.ToDate, _idCompany, ctrBaseDateRange1.FromDate);
                //        this.viewProductLogTableAdapter.FillBy_ThongKeNew(this.dBView.ViewProductLog, _idCompany, ctrBaseDateRange1.FromDate,  ctrBaseDateRange1.ToDate);
                //        break;
                //    case 2: //ngày
                //        this.colDateLog.Visible = false;
                //        //this.colName.Visible = false;
                //        //this.colURL.Visible = false;
                //        this.viewProductLogTableAdapter.FillBy_ThongKeNew(this.dBView.ViewProductLog, _idCompany, ctrBaseDateRange1.FromDate, ctrBaseDateRange1.ToDate);
                //        break;
                //    case 3: //tháng
                //        this.colDateLog.Visible = false;
                //        //this.colName.Visible = false;
                //        //this.colURL.Visible = false;
                //        this.viewProductLogTableAdapter.FillBy_ThongKeNew(this.dBView.ViewProductLog, _idCompany, ctrBaseDateRange1.FromDate, ctrBaseDateRange1.ToDate);
                //        break;
                //    case 4: //năm
                //        this.colDateLog.Visible = false;
                //        //this.colName.Visible = false;
                //        //this.colURL.Visible = false;
                //        this.viewProductLogTableAdapter.FillBy_ThongKeNew(this.dBView.ViewProductLog, _idCompany, ctrBaseDateRange1.FromDate, ctrBaseDateRange1.ToDate);
                //        break;
                //}
                this.prc_ProductLog_ThongKeClickTableAdapter.Fill(dBView.prc_ProductLog_ThongKeClick, _idCompany, ctrBaseDateRange1.FromDate, ctrBaseDateRange1.ToDate);

                int i = 1;
                while (i < dBView.prc_ProductLog_ThongKeClick.Rows.Count)
                {
                    //datetime dong i;
                    DateTime datelogi = QT.Entities.Common.ObjectToDataTime(dBView.prc_ProductLog_ThongKeClick.Rows[i]["DateLog"].ToString());
                    //Datetim dong  i-1;
                    DateTime datelog = QT.Entities.Common.ObjectToDataTime(dBView.prc_ProductLog_ThongKeClick.Rows[i - 1]["DateLog"].ToString());
                    var temptime = datelogi - datelog;
                    if (temptime.TotalSeconds > 5) i++;
                    else
                    {
                        // ID Product dòng i
                        long idProducti = QT.Entities.Common.Obj2Int64(dBView.prc_ProductLog_ThongKeClick.Rows[i]["IDProduct"].ToString());
                        // ID Product dòng i - 1
                        long idProduct = QT.Entities.Common.Obj2Int64(dBView.prc_ProductLog_ThongKeClick.Rows[i - 1]["IDProduct"].ToString());
                        if (idProduct == idProducti)
                        {
                            dBView.prc_ProductLog_ThongKeClick.Rows.RemoveAt(i);
                        }
                        else
                            i++;
                    }
                }
                QT.Entities.Wait.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


        private void frmThongKeClick_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBView.Product_LogsAddProduct' table. You can move, or remove it, as needed.
        }

        private void btView_Click(object sender, EventArgs e)
        {
            QT.Entities.Wait.Show("Đang tải dữ liệu");
            RefreshData();
            QT.Entities.Wait.Close();
        }
        #region Export OLD
        private void btExport_Click(object sender, EventArgs e)
        {
            
            
            this.saveFileDialog1.DefaultExt = "xls";
            this.saveFileDialog1.FileName = string.Format("{0}_click_date_{1}-{2}.xls", _domain, ctrBaseDateRange1.FromDate.ToString("dd_MM_yyyy"), ctrBaseDateRange1.ToDate.ToString("dd_MM_yyyy"));
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                QT.Entities.Wait.Show("Đang export");
                this.gridView1.ExportToExcelOld(saveFileDialog1.FileName);
                QT.Entities.Wait.Close();
            }
        }

        private void btExportPDF_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.DefaultExt = "pdf";
            this.saveFileDialog1.FileName = string.Format("{0}_click_date_{1}-{2}.pdf", _domain, ctrBaseDateRange1.FromDate.ToString("dd_MM_yyyy"), ctrBaseDateRange1.ToDate.ToString("dd_MM_yyyy"));
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                QT.Entities.Wait.Show("Đang export");
                this.gridView1.ExportToPdf(saveFileDialog1.FileName);
                QT.Entities.Wait.Close();
            }
        }

        private void btExportHTM_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.DefaultExt = "mht";
            this.saveFileDialog1.FileName = string.Format("{0}_click_date_{1}-{2}.mht", _domain, ctrBaseDateRange1.FromDate.ToString("dd_MM_yyyy"), ctrBaseDateRange1.ToDate.ToString("dd_MM_yyyy"));
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                QT.Entities.Wait.Show("Đang export");
                this.gridView1.ExportToMht(saveFileDialog1.FileName);
                QT.Entities.Wait.Close();
            }
        }
        #endregion
        private void toolStripButtonExportNew_Click(object sender, EventArgs e)
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
                            gridControl1.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControl1.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl1.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControl1.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl1.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl1.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                }
            }
            MessageBox.Show("Export success!");
        }

        private void ExportExcelButton_Click(object sender, EventArgs e)
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
                            prc_ProductLog_ThongKeClickGridControl.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            prc_ProductLog_ThongKeClickGridControl.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            prc_ProductLog_ThongKeClickGridControl.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            prc_ProductLog_ThongKeClickGridControl.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            prc_ProductLog_ThongKeClickGridControl.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            prc_ProductLog_ThongKeClickGridControl.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                }
            }
            MessageBox.Show("Export success!");
        }
    }
}
