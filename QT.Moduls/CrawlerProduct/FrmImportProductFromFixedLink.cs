using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities;
using QT.Entities.Data;
using System.Data.SqlClient;
using System.Threading;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmImportProductFromFixedLink : Form
    {
        private Dictionary<string, string> DicDetailUrl = new Dictionary<string, string>();
        private SqlDb sqldb = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;Connect Timeout=5000");
        private Configuration config = new Configuration();
        private long companyID = 0;
        private bool bDeleteProductData;
        private List<long> lstProductIDChangeImage = new List<long>();
        public FrmImportProductFromFixedLink(long _companyID)
        {
            InitializeComponent();
            this.companyID = _companyID;

            this.bDeleteProductData = true;
            this.bDeleteProduct.Checked = true;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                DicDetailUrl = LoadFileToList(openFileDialog1.FileName);
                txtFile.Text = openFileDialog1.FileName;
                txtFile.Enabled = false;
            }
        }
        private void btnAnalysicData_Click(object sender, EventArgs e)
        {
            Thread Run = new Thread(() => Analysic());
            Run.Start();
        }

        public void Analysic()
        {
            try
            {
                long productID = 0;
                ProductAdapter productAdapter = new ProductAdapter(sqldb);
                Configuration configXPath = new Configuration(companyID);
                QT.Entities.Company company = new Entities.Company(companyID);
                DataTable tblProduct = sqldb.GetTblData("Select ID,DetailUrl From Product Where Company = @CompanyID", CommandType.Text,
                    new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@CompanyID",companyID,SqlDbType.BigInt)
                }, null, true);
                foreach (DataRow rowInfo in tblProduct.Rows)
                {
                    productID = QT.Entities.Common.Obj2Int64(rowInfo["ID"]);
                    if (!DicDetailUrl.ContainsKey(QT.Entities.Common.Obj2String(rowInfo["DetailUrl"])))
                    {
                        sqldb.RunQuery("update Product set Valid = 0 where Company = @CompanyID and ID = @productID", CommandType.Text, new SqlParameter[]{
                        sqldb.CreateParamteter("@CompanyID",companyID,SqlDbType.BigInt),
                        sqldb.CreateParamteter("@productID",productID,SqlDbType.BigInt)
                    });
                    }
                }
                foreach (var DetailUrl in DicDetailUrl)
                {
                    string strDetailUrl = DetailUrl.Key.ToString();
                    productID = QT.Entities.Common.GetIDProduct(strDetailUrl);
                    if (this.bDeleteProductData)
                    {
                        sqldb.RunQuery("delete product where id = @id", CommandType.Text, new SqlParameter[]{
                        SqlDb.CreateParamteterSQL("@id",productID,SqlDbType.BigInt)
                    });
                    }
                    Product pt = new Product();
                    GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(GetHtmlCode(strDetailUrl, false));
                    pt.Analytics(doc, strDetailUrl, configXPath, false, company.Domain, null);
                    if (pt.IsSuccessData(this.config.CheckPrice))
                    {
                        productAdapter.InsertProduct(pt);
                        lstProductIDChangeImage.Add(productID);
                        
                        this.Invoke(new Action(() =>
                            {
                                richTextBox1.AppendText("\r\nSuccess link: " + strDetailUrl);
                            }));
                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            richTextBox1.AppendText("\r\nNo product link: " + strDetailUrl);
                        }));
                    }
                }
              
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }));
            }
            MessageBox.Show(string.Format("Crawler {0} \nSuccess Link {1} \nFail link {2}", DicDetailUrl.Count, lstProductIDChangeImage.Count, (DicDetailUrl.Count - lstProductIDChangeImage.Count)));
        }

        private string GetHtmlCode(string urlCurrent, bool UseClearHtml)
        {
            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(urlCurrent, 45, 2);
            html = html.Replace("<form", "<div");
            html = html.Replace("</form", "</div");
            return html;
        }

        private Dictionary<string, string> LoadFileToList(string path)
        {
            Dictionary<string, string> DetailUrl = new Dictionary<string, string>();

            foreach (var worksheet in Workbook.Worksheets(path))
                foreach (var row in worksheet.Rows)
                    foreach (var cell in row.Cells)
                    {
                        var a = cell;
                        if (cell != null && !DetailUrl.ContainsKey(cell.Text.Trim()))
                        {
                            DetailUrl.Add(cell.Text.Trim(), "");
                        }
                    }
            return DetailUrl;
        }

        private void bDeleteProduct_CheckedChanged(object sender, EventArgs e)
        {
            this.bDeleteProductData = this.bDeleteProduct.Checked;
        }

        private void FrmImportProductFromFixedLink_Load(object sender, EventArgs e)
        {
           
        }
        private DataTable tblProduct = null;
        private void btnImportProductToSQL_Click(object sender, EventArgs e)
        {
            long productID;
            DataTable tbltemp = null;
            foreach (var DetailUrl in DicDetailUrl)
            {
                string strDetailUrl = DetailUrl.Key.ToString();
                productID = QT.Entities.Common.GetIDProduct(strDetailUrl);
                tbltemp = sqldb.GetTblData("select * from Product where ID = @ProductID", CommandType.Text, new SqlParameter[] { 
                        sqldb.CreateParamteter("@ProductID",productID,SqlDbType.BigInt)
                    });
                if (tbltemp == null)
                {
                    sqldb.RunQuery("insert into Product (ID,Company,DetailUrl) values (@ID,@CompanyID,@DetailUrl)", CommandType.Text, new SqlParameter[]{
                            sqldb.CreateParamteter("@ID",productID,SqlDbType.BigInt),
                            sqldb.CreateParamteter("@CompanyID",companyID,SqlDbType.BigInt),
                            sqldb.CreateParamteter("@DetailUrl",strDetailUrl,SqlDbType.NVarChar)
                            });
                }
            }
            lblImportProductToSQL.Text = "ImportProductDone!";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
