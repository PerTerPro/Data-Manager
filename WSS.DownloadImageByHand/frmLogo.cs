using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.DownloadImageByHand
{
    public partial class frmLogo : Form
    {
        private string connectionString = "";
        public frmLogo()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Thread tr = new Thread(new ThreadStart(Run));
            tr.Start();
        }
        private void Run()
        {
            DataTable dtfinal = new DataTable();
            dtfinal = new DataTable();
            dtfinal.Columns.Add("ID", typeof(string));
            dtfinal.Columns.Add("Domain", typeof(string));
            dtfinal.Columns.Add("Detail", typeof(string));

            WSS.DownloadImageByHand.DBTableAdapters.CompanyTableAdapter companyAdapter = new DBTableAdapters.CompanyTableAdapter();
            companyAdapter.Connection.ConnectionString = connectionString;
            WSS.DownloadImageByHand.DB.CompanyDataTable companyTable = new DB.CompanyDataTable();
            var fileStream = new FileStream(txtFolder.Text, FileMode.Open, FileAccess.Read);
            int i = 0;
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    this.Invoke(new Action(() =>
                    {
                        richTextBox1.AppendText(i + ". " +line+ System.Environment.NewLine);
                    }));
                    i++;
                    companyTable.Clear();
                    long idcompany = QT.Entities.Common.GetIDCompany(line);
                    companyAdapter.FillBy_ID(companyTable, idcompany);
                    if (companyTable.Rows.Count == 0)
                    {
                        DataRow dr = dtfinal.NewRow();
                        dr["ID"] = idcompany;
                        dr["Domain"] = line;
                        dr["Detail"] = "Not in Database";
                        dtfinal.Rows.Add(dr);
                    }
                    else
                    {
                        int totalvalid = QT.Entities.Common.Obj2Int(companyTable.Rows[0]["TotalValid"].ToString());
                        if (totalvalid == 0)
                        {
                            DataRow dr = dtfinal.NewRow();
                            dr["ID"] = idcompany;
                            dr["Domain"] = line;
                            dr["Detail"] = "Total Valid = 0";
                            dtfinal.Rows.Add(dr);
                        }
                    }
                }
                this.Invoke(new Action(() =>
                {
                    gridControl1.DataSource = dtfinal;
                }));
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
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
            MessageBox.Show("Export Excel to Documents");
        }
    }
}
