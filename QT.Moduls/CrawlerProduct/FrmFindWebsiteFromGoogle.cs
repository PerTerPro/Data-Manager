using QT.Entities;
using QT.Entities.Data;
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

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmFindWebsiteFromGoogle : Form
    {
        SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
        DataTable tblCompany = null;
        Dictionary<string, string> dicWebsite = new Dictionary<string, string>();
        Dictionary<long, string> dicOldWebsite = new Dictionary<long, string>();
        //Google g = new Google();
        public FrmFindWebsiteFromGoogle()
        {
            InitializeComponent();
        }

        private void FrmFindWebsiteFromGoogle_Load(object sender, EventArgs e)
        {
            tblCompany = sqldb.GetTblData("select ID,Domain from company");
            foreach (DataRow RowCompany in tblCompany.Rows)
            {
                if (!dicOldWebsite.ContainsKey(QT.Entities.Common.Obj2Int64(RowCompany["ID"])))
                {
                    dicOldWebsite.Add(QT.Entities.Common.Obj2Int64(RowCompany["ID"]), QT.Entities.Common.Obj2String(RowCompany["Domain"]));
                }
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            Thread Find = new Thread(() => Run());
            Find.Start();
        }
        public void Run()
        {
            int pageGoogle = QT.Entities.Common.Obj2Int(txtPageGoogle.Text);
            int timeDelay = QT.Entities.Common.Obj2Int(txtTimeDelay.Text);

            dicWebsite = QT.Entities.NewWebInGoogle.GetWebsiteFromGoogle(txtKeywordSearch.Text, pageGoogle, timeDelay);
            foreach (var item in dicWebsite)
            {
                long CompanyID = Math.Abs(GABIZ.Base.Tools.getCRC64(item.Key));
                if (!dicOldWebsite.ContainsKey(CompanyID))
                {
                    this.Invoke(new Action(() =>
                    {
                        richTextBoxWebsiteNew.AppendText(string.Format("\n{0}", item.Key));
                    }));
                }
            }
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            richTextBoxWebsiteNew.Clear();
        }
    }
}
