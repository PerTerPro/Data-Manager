using QT.Entities;
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

namespace QT.Moduls.Company
{
    public partial class frmCheckDataFeedUrl : Form
    {
        public frmCheckDataFeedUrl()
        {
            InitializeComponent();
        }

        private void frmCheckDataFeedUrl_Load(object sender, EventArgs e)
        {
            this.companyTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.companyTableAdapter.FillBy_IsDataFeed(this.dBCom.Company);

            #region DataFeedType
            DataTable dtTypeDataFeed= new DataTable();
            dtTypeDataFeed.Columns.Add("Name",typeof(string));
            dtTypeDataFeed.Columns.Add("Value",typeof(int));
            DataRow dr0 = dtTypeDataFeed.NewRow();
            dr0["Name"] = "None";
            dr0["Value"]= 0;
            dtTypeDataFeed.Rows.Add(dr0);

            DataRow dr1 = dtTypeDataFeed.NewRow();
            dr1["Name"] = "AllProductsFromFile";
            dr1["Value"]= 1;
            dtTypeDataFeed.Rows.Add(dr1);

            DataRow dr2 = dtTypeDataFeed.NewRow();
            dr2["Name"] = "AllProductsFromURL";
            dr2["Value"]= 2;
            dtTypeDataFeed.Rows.Add(dr2);

            DataRow dr3 = dtTypeDataFeed.NewRow();
            dr3["Name"] = "SpecialProductsFromFile";
            dr3["Value"]= 3;
            dtTypeDataFeed.Rows.Add(dr3);

            DataRow dr4 = dtTypeDataFeed.NewRow();
            dr4["Name"] = "SpecialProductsFromUrl";
            dr4["Value"]= 4;
            dtTypeDataFeed.Rows.Add(dr4);
            #endregion
            repositoryItemLookUpEdit1.DataSource = dtTypeDataFeed;

        }

        private void simpleButtonExport_Click(object sender, EventArgs e)
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
                            companyGridControl.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            companyGridControl.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            companyGridControl.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            companyGridControl.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            companyGridControl.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            companyGridControl.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                    MessageBox.Show("Export Excel to Documents");
                }
            }
        }
    }
}
