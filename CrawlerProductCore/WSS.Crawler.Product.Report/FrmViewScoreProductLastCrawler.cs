using QT.Moduls.CrawlerProduct.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmViewScoreProductLastCrawler : Form
    {

        private RedisLastUpdateProduct redisProductLastUpdate = RedisLastUpdateProduct.Instance();
        private long companyID;
        public FrmViewScoreProductLastCrawler()
        {
            InitializeComponent();
        }

        public FrmViewScoreProductLastCrawler(long companyID)
        {
            InitializeComponent();
            this.companyID = companyID;
            this.RefreshData();
          
        }

        private void RefreshData()
        {
            Dictionary<long, long> lst = redisProductLastUpdate.GetAllData(this.companyID);
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ProductID", typeof(long));
            tbl.Columns.Add("Score", typeof(long));
            tbl.Columns.Add("DateScore", typeof(DateTime));
            foreach(var item in lst)
            {
                DataRow rowInfo = tbl.NewRow();
                rowInfo["ProductID"] = item.Key;
                rowInfo["Score"] = item.Value;
                tbl.Rows.Add(rowInfo);
            }
            this.gridControl1.DataSource = tbl;
        }

        private void FrmViewScoreProductLastCrawler_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void btnSetScore_Click(object sender, EventArgs e)
        {
            List<long> lstProduct = new List<long>();
            foreach(var indexRow in this.gridView1.GetSelectedRows())
            {
                lstProduct.Add(Convert.ToInt64(this.gridView1.GetRowCellValue(indexRow, "ProductID")));
            }
            this.redisProductLastUpdate.UpdateBathLastUpdateProduct(this.companyID, lstProduct, dateTimePicker1.Value);
            MessageBox.Show(string.Format("Updated for {0} product", lstProduct.Count));
        }
    }
}
