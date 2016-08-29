using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmKeywordManager : Form
    {
        private List<string> lstKeyword = new List<string>();
        private DataTable tblKeyword = null;
        SqlDb sqlDbQT2 = new SqlDb(@"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        int ID = 0;
        string Keyword = "";
        public FrmKeywordManager()
        {
            InitializeComponent();
        }
        private void FrmKeywordManager_Load(object sender, EventArgs e)
        {
            tblKeyword = sqlDbQT2.GetTblData("select * from KeywordFindNewWebsite", CommandType.Text, new SqlParameter[] { });
            gridControlKeyword.DataSource = tblKeyword;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogExel.ShowDialog();
            if (result == DialogResult.OK)
            {
                lstKeyword = LoadFileToList(openFileDialogExel.FileName);
                txtPathEx.Text = openFileDialogExel.FileName;
                txtPathEx.Enabled = false;
            }
            lblNotice.Text = "Load file exel done!";
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Thread Run = new Thread(() => InsertKeyword());
            Run.Start();
        }
        public void InsertKeyword()
        {

            if (lstKeyword != null)
            {
                foreach (string Keyword in lstKeyword)
                {
                    ID = QT.Entities.Common.GetID_Keywords(Keyword);
                    sqlDbQT2.RunQuery("if not exists (select ID from KeywordFindNewWebsite where ID = @ID) begin insert into KeywordFindNewWebsite (ID,Keyword) Values (@ID,@Keyword) end", CommandType.Text, new SqlParameter[]{
                    sqlDbQT2.CreateParamteter("@ID",ID,SqlDbType.Int),
                    sqlDbQT2.CreateParamteter("@Keyword",Keyword,SqlDbType.NVarChar)
                });

                    this.Invoke(new Action(() =>
                    {
                        richTextBox1.AppendText("\r\nInsert Complete: " + Keyword);
                    }));
                }
                MessageBox.Show("Add new keyword done!");
            }
            else if (!string.IsNullOrEmpty(txtKeyword.Text))
            {
                Keyword = txtKeyword.Text.Trim();
                ID = QT.Entities.Common.GetID_Keywords(Keyword);

                tblKeyword = sqlDbQT2.GetTblData("select ID from KeywordFindNewWebsite where ID = @ID", CommandType.Text, new SqlParameter[]{
                    sqlDbQT2.CreateParamteter("@ID",ID,SqlDbType.Int)
                });
                if (tblKeyword.Rows.Count == 0)
                {
                    sqlDbQT2.RunQuery("insert into KeywordFindNewWebsite (ID,Keyword) Values (@ID,@Keyword)", CommandType.Text, new SqlParameter[] { 
                        sqlDbQT2.CreateParamteter("@ID",ID,SqlDbType.Int),
                        sqlDbQT2.CreateParamteter("@Keyword",Keyword,SqlDbType.NVarChar)
                    });
                    MessageBox.Show("Add new keyword done!");
                }
                else
                {
                    MessageBox.Show("Keyword was existed!");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var RowSelected = GetListSelectedRow();
            if (RowSelected != null)
            {
                foreach (DataRowView rowView in RowSelected)
                {
                    ID = QT.Entities.Common.Obj2Int((this.gridView1.GetRow(this.gridView1.FocusedRowHandle) as DataRowView)["ID"]);
                    sqlDbQT2.RunQuery("delete from KeywordFindNewWebsite where ID = @ID", CommandType.Text, new SqlParameter[]{
                        sqlDbQT2.CreateParamteter("@ID",ID,SqlDbType.Int)
                    });
                }
            }
            btnReload_Click(null, null);
        }
        private List<string> LoadFileToList(string path)
        {
            List<string> lstKeyword = new List<string>();
            foreach (var worksheet in Workbook.Worksheets(path))
                foreach (var row in worksheet.Rows)
                    foreach (var cell in row.Cells)
                    {
                        var a = cell;
                        if (cell != null)
                        {
                            lstKeyword.Add(cell.Text.Trim());
                        }
                    }
            return lstKeyword;
        }

        private void txtKeyword_EditValueChanged(object sender, EventArgs e)
        {
            txtKeywordID.Text = QT.Entities.Common.GetID_Keywords(txtKeyword.Text).ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            FrmKeywordManager_Load(null, null);
        }

        private void gridControlKeyword_Click(object sender, EventArgs e)
        {

        }

        public List<DataRowView> GetListSelectedRow()
        {
            var lst = new List<DataRowView>();
            foreach (int i in this.gridView1.GetSelectedRows())
            {
                DataRowView row = this.gridView1.GetRow(i) as DataRowView;
                lst.Add(row);
            }
            return lst;
        }
    }
}
