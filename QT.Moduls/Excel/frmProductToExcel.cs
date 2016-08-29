using QT.Entities;
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

namespace QT.Moduls.Excel
{
    public partial class frmProductToExcel : Form
    {
        public frmProductToExcel()
        {
            InitializeComponent();
        }

        private void frmProductToExcel_Load(object sender, EventArgs e)
        {
            this.productNotMapRootTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                //saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                saveDialog.Filter = "Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;
                    //NImageExporter imageExporter = chartControl.ImageExporter;
                    switch (fileExtenstion)
                    {
                        case ".xls":
                            productNotMapRootGridControl.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            productNotMapRootGridControl.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            productNotMapRootGridControl.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            productNotMapRootGridControl.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            productNotMapRootGridControl.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            productNotMapRootGridControl.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                }
            }
            MessageBox.Show("Export Excel to Documents");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang load dữ liệu");
            try
            {
                SqlDb db = new SqlDb(QT.Entities.Server.ConnectionString);
                this.productNotMapRootGridControl.DataSource =
                    db.GetTblData(@"SELECT a.[ID]
      ,[IDNotRoot]
      ,[IDCompany]
      ,[DateAdd]
      ,b.[Name]
   ,b.NameFT
      ,[Length]
      ,[CountFail]
  FROM [dbo].[ProductNotMapRoot] a
  inner join Product b on a.IDNotRoot = b.ID
  order by a.Length DESC", CommandType.Text, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
            Wait.Close();
        }
    }
}
