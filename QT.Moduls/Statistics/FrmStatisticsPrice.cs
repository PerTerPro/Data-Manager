using QT.Entities.Data;
using QT.Moduls.Statistics.Object;
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

namespace QT.Moduls.Statistics
{
    public partial class FrmStatisticsPrice : Form
    {
        SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
        private long _CompanyId;
        private string _Domain;
        private int CatId = 0;
        public FrmStatisticsPrice()
        {
            InitializeComponent();
        }
        public FrmStatisticsPrice(long companyId)
        {
            InitializeComponent();
            this._CompanyId = companyId;
        }

        public DataTable GetAllProduct(long company)
        {
            DataTable tblProduct = new DataTable();
            tblProduct = sqldb.GetTblData("Select * from Product where Company = @Company and Valid = 1");
            return tblProduct;
        }

        private void FrmStatisticsPrice_Load(object sender, EventArgs e)
        {
            DataTable tblCategory = new DataTable();
            tblCategory = sqldb.GetTblData("Select ID,Name from ListClassification where ParentID = 0");
            lookUpEditCategory.Properties.DataSource = tblCategory;
            lookUpEditCategory.Properties.DisplayMember = "Name";
            lookUpEditCategory.Properties.ValueMember = "ID";
        }

        private void lookUpEditCategory_EditValueChanged(object sender, EventArgs e)
        {
            CatId = QT.Entities.Common.Obj2Int(lookUpEditCategory.EditValue);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            gridControlProductStatistics.DataSource = null;
            gridView1.Columns.Clear();
            var lstMerchantCompare = rtxtCompete.Text.Replace('\n', ',').Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            DataTable tbl = GetTblStatisticsProductPrice(_CompanyId, lstMerchantCompare);
            gridControlProductStatistics.DataSource = tbl;
        }
        public DataTable GetTblStatisticsProductPrice(long company, List<string> lstMerchant)
        {
            int Sort = 0;
            int TotalCompare = 0;
            DataTable tblShow = new DataTable();

            DataColumn dcProduct = new DataColumn("San_Pham", typeof(string));
            DataColumn dcDetailUrl = new DataColumn("Link", typeof(string));
            DataColumn dcMinPrice = new DataColumn("Gia_Thap_Nhat_TT", typeof(string));
            DataColumn dcPrice = new DataColumn("Gia_Website", typeof(string));
            DataColumn dcMaxPrice = new DataColumn("Gia_Cao_Nhat_TT", typeof(string));
            tblShow.Columns.Add(dcProduct); tblShow.Columns.Add(dcDetailUrl); tblShow.Columns.Add(dcMinPrice); tblShow.Columns.Add(dcPrice); tblShow.Columns.Add(dcMaxPrice);

            DataTable tblProduct = sqldb.GetTblData(@"select a.ID,a.Name,b.ID as RootId,b.Name as RootName,a.DetailUrl,a.ImageUrls, a.Price from Product a
                                                            left join Product b
                                                            on a.ProductID = b.ID
                                                            where a.Company = @Company and b.ID >0 and b.ID is not null and a.Name like N'%tivi%'", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                                                                                                            SqlDb.CreateParamteterSQL("@Company",company,SqlDbType.BigInt)
                                                                                                          });
            if (lstMerchant != null && lstMerchant.Count > 0)
            {
                for (int i = 0; i < lstMerchant.Count; i++)
                {
                    tblShow.Columns.Add(lstMerchant[i], typeof(string));
                }
            }
            foreach (DataRow row in tblProduct.Rows)
            {
                int ProductID = row["RootId"] != DBNull.Value ? int.Parse(row["RootId"].ToString()) : 0;
                long ID = row["ID"] != DBNull.Value ? long.Parse(row["ID"].ToString()) : 0;
                DataTable tblPrice = sqldb.GetTblData(@"select a.ID, a.Name,a.Price,b.ID as companyId, b.Domain from Product a
                                                                inner join Company b
                                                                on a.Company = b.ID
                                                                where ProductID = @ProductID
                                                                order by Price asc", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { 
                                                                                        SqlDb.CreateParamteterSQL("@ProductID",ProductID,SqlDbType.Int)
                                                                                   });
                
                DataRow dr = tblShow.NewRow();
                if (tblPrice != null && tblPrice.Rows.Count > 0)
                {
                    for (int i = 0; i < tblPrice.Rows.Count; i++)
                    {
                        if (ID.ToString() == tblPrice.Rows[i]["ID"].ToString())
                        {
                            Sort = i + 1;
                        }
                        for (int j = 0; j < lstMerchant.Count; j++)
                        {
                            string currentDomain = tblPrice.Rows[i]["Domain"].ToString();
                            string currentPrice = tblPrice.Rows[i]["Price"].ToString();
                            string domainCompare = lstMerchant[j];
                            if (currentDomain.Trim() == domainCompare.Trim())
                            {
                                dr[string.Format("{0}", lstMerchant[j])] = currentPrice;
                            }
                            //else
                            //{
                            //    dr[string.Format("{0}", lstMerchant[j])] = "";
                            //}
                        }
                    }
                    TotalCompare = tblPrice.Rows.Count;
                    dr["Gia_Thap_Nhat_TT"] = (tblPrice.Rows[0]["Price"] != DBNull.Value ? tblPrice.Rows[0]["Price"].ToString() : "") + Environment.NewLine + (tblPrice.Rows[0]["Domain"] != DBNull.Value ? tblPrice.Rows[0]["Domain"].ToString() : "");
                    dr["Gia_Cao_Nhat_TT"] = (tblPrice.Rows[tblPrice.Rows.Count - 1]["Price"] != DBNull.Value ? tblPrice.Rows[tblPrice.Rows.Count - 1]["Price"].ToString() : "") + Environment.NewLine + (tblPrice.Rows[tblPrice.Rows.Count - 1]["Domain"] != DBNull.Value ? tblPrice.Rows[tblPrice.Rows.Count - 1]["Domain"].ToString() : "");
                }
                else
                {
                    TotalCompare = 1;
                    dr["Gia_Thap_Nhat_TT"] = dr["Gia_Cao_Nhat_TT"] = 0;
                }
                dr["San_Pham"] = row["Name"] != DBNull.Value ? row["Name"].ToString() : "";
                dr["Link"] = row["DetailUrl"] != DBNull.Value ? row["DetailUrl"].ToString() : "";
                dr["Gia_Website"] = (row["Price"] != DBNull.Value ? row["Price"].ToString() : "") + Environment.NewLine + "Xếp hạng:" + string.Format("{0}/{1}", Sort, TotalCompare);
                tblShow.Rows.Add(dr);
            }
            return tblShow;
        }

        private void btnExport_Click(object sender, EventArgs e)
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
                            gridControlProductStatistics.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControlProductStatistics.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControlProductStatistics.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControlProductStatistics.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControlProductStatistics.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControlProductStatistics.ExportToMht(exportFilePath);
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
