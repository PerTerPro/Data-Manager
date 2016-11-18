using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using WSS.IndividualCategoryWebsites.DBIndiTableAdapters;

namespace WSS.IndividualCategoryWebsites
{
    public class WssCommon
    {
        public enum ListWebCommand
        {
            IndividualWebsitesProduct = 1,
            IndividualWebsitesRootProductAnalyzed = 2,
            ViewTagInWebsites =3
        }

        public static string ConvertTextRichtextBoxToString(string textRichtextBox)
        {
            var result = "";
            var listKeywords = textRichtextBox.Replace('\n',',').ToList();
            //var normalizedKeyword =
            //    listKeywords.Select(SolrUtils.NormalizeToExactQuery).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            //result = string.Join(",", normalizedKeyword);
            return result;
        }
        public static string GetNameCategoryById(int id)
        {
            var categoriesTableAdapter = new CategoriesTableAdapter();
            categoriesTableAdapter.Connection.ConnectionString = WssConnection.ConnectionIndividual;
            var categoriesDataTable = new DBIndi.CategoriesDataTable();
            try
            {
                categoriesTableAdapter.FillById(categoriesDataTable,id);
                if (categoriesDataTable.Rows.Count > 0)
                    return categoriesDataTable.Rows[0]["Name"].ToString();
                else return "";
            }
            catch (Exception)
            {
                return "";
            }
        }
        public static void ExportExcel(GridControl gridControl1, string fileName)
        {
            fileName = fileName.Replace(".", "_");
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                saveDialog.FileName = fileName;
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension; switch (fileExtenstion)
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
        }
    }
}
