using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.FindWeb
{
    public partial class FrmFindWebInGoogle : Form
    {
        

        public FrmFindWebInGoogle()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(new Action(() =>
                {
                    SqlDb sqlDb = new SqlDb(@"Data Source=WIN-6ICNIQVFE0A;Initial Catalog=SaleNews;Integrated Security=True");
                    DataTable tbl = sqlDb.GetTblData("", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { });
                    foreach(DataRow rowInfo in tbl.Rows)
                    {
                        string key = "";
                        GABIZ.Base.HtmlAgilityPack.HtmlDocument document = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                        string url = string.Format(@"https://www.google.com/?gws_rd=ssl#safe=off&q=con+ch%C3%B3", key.Replace(" ", "-"));
                        document.Load(url);
                        document.DocumentNode.SelectNodes("");
                    }
                }));
        }
    }
}
