using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmExportProduct : Form
    {
        SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
        DataTable tblProduct = null;
        private long _companyID;

        public FrmExportProduct()
        {
            InitializeComponent();
        }

        public FrmExportProduct(long CompanyID)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            _companyID = CompanyID;
        }
        private void FrmExportProduct_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void RefreshData()
        {
            tblProduct = sqldb.GetTblData(@"select p.ID, p.Name as ProductName, p.Price,p.InStock,p.DetailUrl,p.ImageUrls, c.Name as CategoryName
                                            from Product p 
                                            inner join ListClassification c
                                            on p.CategoryID = c.ID
                                            where p.Company = @Company", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                                                                            SqlDb.CreateParamteterSQL("@Company",_companyID,SqlDbType.BigInt)
                                                                       });
            this.gridControlProduct.DataSource = tblProduct;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "CSV(.csv)|*.csv|Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;
                    switch (fileExtenstion)
                    {
                        case ".csv":
                            gridControlProduct.ExportToCsv(exportFilePath);
                            break;
                        case ".xls":
                            gridControlProduct.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControlProduct.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControlProduct.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControlProduct.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControlProduct.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControlProduct.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                    MessageBox.Show("Export success!");
                }
            }
        }

       

        
    }
}
