using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities.Data;

namespace WSS.ImportKeywordsToSql
{

    public partial class FrmImportKeywordFindWebSite : Form
    {

        SqlDb sqlDb = new SqlDb(@"Data Source=192.168.100.183;Initial Catalog=FindNewWebSite;Persist Security Info=True;User ID=sa;Password=123;connection timeout=200");


        private List<String> lstImportKeyWord = new List<string>();
        public FrmImportKeywordFindWebSite()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                QT.Entities.Wait.Show("Đợi");
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK) // Test result.
                {
                    lstImportKeyWord = LoadFileToList(openFileDialog1.FileName);
                }
                this.grcNewKeyword.DataSource = lstImportKeyWord;
                QT.Entities.Wait.Close();
            }
            catch (Exception ex01)
            {
                MessageBox.Show(ex01.Message);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                QT.Entities.Wait.Show("Đợi");
                foreach (var item in lstImportKeyWord)
                {
                        sqlDb.RunQuery(@"IF NOT EXISTS (SELECT Keyword From Keyword WHERE keyword = @keyword) INSERT INTO keyword (keyword, processed) VALUES (@keyword,0)", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                               SqlDb.CreateParamteterSQL("@keyword",item,SqlDbType.NVarChar)});
                }
                RefreshDataKeyword();
                QT.Entities.Wait.Close();
            }
            catch (Exception ex01)
            {
                MessageBox.Show(ex01.Message);
            }
        }


        private List<string> LoadFileToList(string path)
        {
            List<string> keywords = new List<string>();

            foreach (var worksheet in Workbook.Worksheets(path))
                foreach (var row in worksheet.Rows)
                    foreach (var cell in row.Cells)
                    {
                        var a = cell;
                        if (cell != null)
                        {
                            string strKeyword = cell.Text.Trim();
                            if (!keywords.Contains(strKeyword)) keywords.Add(strKeyword);
                        }
                    }
            return keywords;

        }

        private void FrmImportKeywordFindWebSite_Load(object sender, EventArgs e)
        {
            RefreshDataKeyword();
        }

        private void RefreshDataKeyword()
        {
            this.gridControl1.DataSource = this.sqlDb.GetTblData(@"SELECT  [keyword]
      ,[processed]
  FROM [FindNewWebSite].[dbo].[keyword] ", CommandType.Text, null);
        
        }



    }
}
