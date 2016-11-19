using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmUnvalidProduct : Form
    {
        SqlDb sqldbProduct = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        DataTable tblLink = new DataTable();
        public FrmUnvalidProduct()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tblLink = ReadDataFromExcelFile(openFileDialog1.FileName);
                txtPathEx.Text = openFileDialog1.FileName;
                txtPathEx.Enabled = false;
                //lblB.Text = tblProduct.Rows.Count.ToString();
            }
        }
        private void btnUnvalid_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dicDetailUrl = new Dictionary<string, string>();
            foreach (DataRow row in tblLink.Rows)
            {
                if (!dicDetailUrl.ContainsKey(row["Link"].ToString().Trim()))
                {
                    dicDetailUrl.Add(row["Link"].ToString().Trim(), row["Link"].ToString());
                }
            }
            DataTable tblProduct = new DataTable();
            tblProduct = sqldbProduct.GetTblData("select * from product where company = 4257213322260895827 and IsBlackList = 0");
            foreach (DataRow row in tblProduct.Rows)
            {
                if (!dicDetailUrl.ContainsKey(row["DetailUrl"].ToString().Trim()))
                {
                    sqldbProduct.RunQuery("Update Product set IsBlackList = 1 where Company = 4257213322260895827 and DetailUrl = @DetailUrl", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { 
                        SqlDb.CreateParamteterSQL("@DetailUrl",row["DetailUrl"].ToString().Trim(),SqlDbType.NVarChar)
                    });
                }
            }
            MessageBox.Show("Done!");
        }
        private DataTable ReadDataFromExcelFile(string path)
        {
            //string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path.Trim() + ";Extended Properties=Excel 8.0";
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path.Trim() + ";Extended Properties=Excel 12.0;";
            // Tạo đối tượng kết nối
            OleDbConnection oledbConn = new OleDbConnection(connectionString);
            DataTable data = null;
            try
            {
                // Mở kết nối
                oledbConn.Open();

                // Tạo đối tượng OleDBCommand và query data từ sheet có tên "Keywords"
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Products$]", oledbConn);

                // Tạo đối tượng OleDbDataAdapter để thực thi việc query lấy dữ liệu từ tập tin excel
                OleDbDataAdapter oleda = new OleDbDataAdapter();

                oleda.SelectCommand = cmd;

                // Tạo đối tượng DataSet để hứng dữ liệu từ tập tin excel
                DataSet ds = new DataSet();

                // Đổ đữ liệu từ tập excel vào DataSet
                oleda.Fill(ds);

                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Đóng chuỗi kết nối
                oledbConn.Close();
            }
            return data;
        }


    }
}
