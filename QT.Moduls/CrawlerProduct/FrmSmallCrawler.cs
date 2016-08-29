using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmSmallCrawler : Form
    {
        private Dictionary<string, string> listDetailUrl = new Dictionary<string, string>();

        SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
        private DataTable tblProduct = null; 
        public FrmSmallCrawler()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                listDetailUrl = LoadFileToDic(openFileDialog1.FileName);
                txtPath.Text = openFileDialog1.FileName;
                txtPath.Enabled = false;
            }
        }
        private void btnAnalysic_Click(object sender, EventArgs e)
        {
            tblProduct = sqldb.GetTblData("select * from Product where Company = 3413902645923357939 and Valid = 1");
            
            foreach (DataRow rowInfo in tblProduct.Rows)
            {
                //long companyId = QT.Entities.Common.Obj2Int64(rowInfo["Company"]);
                long ID = QT.Entities.Common.Obj2Int64(rowInfo["ID"]);
                if (!listDetailUrl.ContainsKey(rowInfo["DetailUrl"].ToString()))
                {
                    sqldb.RunQuery("Update Product set Valid = 0 where Company = 3413902645923357939 and ID = @ID", CommandType.Text, new SqlParameter[] { 
                        sqldb.CreateParamteter("@ID",ID,SqlDbType.BigInt)
                    });
                }
                
            }
            MessageBox.Show("Done!");
        }


        private Dictionary<string,string> LoadFileToDic(string path)
        {
            Dictionary<string,string> DetailUrl = new Dictionary<string,string>();

            foreach (var worksheet in Workbook.Worksheets(path))
                foreach (var row in worksheet.Rows)
                    foreach (var cell in row.Cells)
                    {
                        var a = cell;
                        if (cell != null && !DetailUrl.ContainsKey(cell.Text.Trim()))
                        {
                            DetailUrl.Add(cell.Text.Trim(),"");
                        }
                    }
            return DetailUrl;
        }

       
    }
}
