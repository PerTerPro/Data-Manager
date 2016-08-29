using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmAutoFixWebsite : Form
    {
        ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));

        public FrmAutoFixWebsite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread threadRun = new Thread(() => StartRun());
            threadRun.Start();
        }

        private bool RemoteFileExists(string url)
        {
            try
            {
                //Creating the HttpWebRequest
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                
                //Setting the Request method HEAD, you can also use GET too.
                request.Method = "HEAD";
                
                //Getting the Web Response.
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                
                //Returns TRUE if the Status code == 200
                return (response.StatusCode == HttpStatusCode.OK);

            }
            catch
            {
                //Any exception will returns false.
                return false;
            }
        }

        private void StartRun()
        {
            DataTable tblCompanyNeedFix = this.productAdapter.GetTblCompanyNeedFix();
            foreach (DataRow row in tblCompanyNeedFix.Rows)
            {
                long CompanyId = Convert.ToInt64(row["ID"]);
                string Website = Convert.ToString(row["Website"]);
                if (RemoteFileExists(Website))
                {
                    this.productAdapter.UpdateStateCheckValidCompany(CompanyId, 1);
                }
                else if (RemoteFileExists(@"http://" + Website))
                {
                    this.productAdapter.UpdateStateCheckValidCompany(CompanyId, 2);
                }
                else if (RemoteFileExists(@"https://" + Website))
                {
                    this.productAdapter.UpdateStateCheckValidCompany(CompanyId, 2);
                }
            }
        }
    }
}
