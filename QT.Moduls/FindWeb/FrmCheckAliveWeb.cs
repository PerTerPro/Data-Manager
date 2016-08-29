using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.FindWeb
{
    public partial class FrmCheckAliveWeb : Form
    {
        public FrmCheckAliveWeb()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            
            Task.Factory.StartNew(new Action(()=>
                {
                    SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);
                    DataTable tblCompanyNeed = sqlDb.GetTblData(@"select c.ID, c.Website, c.Domain,CountAlive
from ManagerType a
inner join ManagerTypeRCompany b on a.ID = b.IDType
inner join Company c on c.ID = b.IDCompany
where (a.name like 'KQ_Webchet' OR a.name like 'Err_All')
and isnull(c.CountAlive,0) = 0
and isnull(c.Domain,'') <>''
and ISNULL(c.website,'')<>''", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
            });

            foreach(DataRow rowInfo in tblCompanyNeed.Rows)
            {
                string website = rowInfo["website"].ToString();
                long CompanyID = QT.Entities.Common.Obj2Int64(rowInfo["ID"]);
                bool bCheck = CheckAliveWebSite(website);
                if (bCheck)
                {
                    sqlDb.RunQuery("update Company Set CountAlive = IsNUll(CountAlive,0)+1 Where Id = @CompanyID", CommandType.Text,
                        new System.Data.SqlClient.SqlParameter[]{
                            SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt)
                        });
                    this.Invoke(new Action(() =>
                    {
                        richTextBox1.AppendText(string.Format("\r\nWeb live:{0}", website));
                    }));
                }
                else 
                {
                    this.Invoke(new Action(()=>
                        {
                            richTextBox1.AppendText(string.Format("\r\nWeb die:{0}", website));
                        }));
                }
            }
            this.Invoke(new Action(() =>
            {
                richTextBox1.AppendText(string.Format("\r\nEnd process!"));
            }));

                }));
            
        }

        private bool CheckAliveWebSite(string website)
        {
            try
            {
                WebRequest request = WebRequest.Create(website);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response == null || response.StatusCode != HttpStatusCode.OK)
                    return false;
                else return true;
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                    {
                        richTextBox1.AppendText("\r\n" + ex.Message + ex.StackTrace);
                    }));
                return false;
            }
        }
    }
}
