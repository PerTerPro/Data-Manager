using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities;
using WSS.DownloadImageByHand.DBTableAdapters;
using System.IO;
using QT.Entities.Data;

namespace WSS.DownloadImageByHand
{
    public partial class frmCompany : Form
    {
        private string _connectionString = "";
        public frmCompany()
        {
            InitializeComponent();
            _connectionString = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Thread tr = new Thread(Run);
            tr.Start();
        }

        private void Run()
        {
            DBTableAdapters.CompanyTableAdapter companyTableAdapter = new CompanyTableAdapter();
            companyTableAdapter.Connection.ConnectionString = _connectionString;
            DBTableAdapters.Company_AddressTableAdapter addressTableAdapter = new Company_AddressTableAdapter();
            addressTableAdapter.Connection.ConnectionString = _connectionString;
            DB.CompanyDataTable companyDataTable = new DB.CompanyDataTable();
            DataTable addressDataTable = new DataTable();
            DataTable dtCompany = new DataTable();
            dtCompany.Columns.Add("ID", typeof(string));
            dtCompany.Columns.Add("Domain", typeof(string));
            dtCompany.Columns.Add("Address", typeof(string));
            dtCompany.Columns.Add("ThanhPho", typeof(string));
            dtCompany.Columns.Add("Phone", typeof(string));
            var listDomain = memoEdit1.Text.Split(new char[]{'\r','\n'},StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            foreach (var item in listDomain)
            {
                i ++;
                this.Invoke(new Action(() =>
                {
                    rbError.AppendText(String.Format("{0}. {1}", i, item) + System.Environment.NewLine);
                }));
                companyDataTable.Clear();
                addressDataTable.Clear();
                long idCompany = Common.GetIDCompany(item);try
                {
                    companyTableAdapter.FillBy_ID(companyDataTable, idCompany);
                }
                catch (Exception exception)
                {
                    this.Invoke(new Action(() =>
                    {
                        rbError.AppendText(String.Format("{0}. {1} Fill By ID error: {2}",i,item,exception)+System.Environment.NewLine);
                    }));
                }
                if (companyDataTable.Rows.Count > 0)
                {
                    DataRow dataRow = dtCompany.NewRow();
                    dataRow["ID"] = idCompany;
                    dataRow["Domain"] = item;
                    dataRow["Address"] = companyDataTable.Rows[0]["Address"];
                    dataRow["Phone"] = companyDataTable.Rows[0]["Phone"];
                    //try
                    //{
                    //    string querry = @"SELECT Distinct ThanhPho FROM Company_Address WHERE CompanyID =" + idCompany;
                    //    SqlDb sqldb = new SqlDb(_connectionString);
                    //    try
                    //    {
                    //        addressDataTable = sqldb.GetTblData(querry, CommandType.Text, null);
                    //    }
                    //    catch (Exception)
                    //    {
                    //    }
                    //    string thanhpho = "";
                    //    for (int j = 0; j < addressDataTable.Rows.Count; j++)
                    //    {
                    //        if (addressDataTable.Rows[j]["ThanhPho"] != DBNull.Value)
                    //        {
                    //            thanhpho += addressDataTable.Rows[j]["ThanhPho"].ToString()+" , ";
                    //        }
                    //    }
                    //    dataRow["ThanhPho"] = thanhpho;
                    //}
                    //catch (Exception exception)
                    //{
                    //    this.Invoke(new Action(() =>
                    //    {
                    //        rbError.AppendText(String.Format("{0}. {1} Get address error: {2}", i, item, exception));
                    //    }));
                    //}
                    dtCompany.Rows.Add(dataRow);
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        rbError.AppendText(String.Format("{0}. {1} Khong ton tai trong SQL", i, item) + System.Environment.NewLine);
                    }));
                }
            }
            this.Invoke(new Action(() =>
            {
                gridControl1.DataSource = dtCompany;
            }));
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
