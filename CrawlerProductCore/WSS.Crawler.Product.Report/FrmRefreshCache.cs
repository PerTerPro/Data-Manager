using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
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
using WSS.Core.Crawler;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmRefreshCache : Form
    {
        private long _CompanyID = 0;
        public FrmRefreshCache()
        {
            InitializeComponent();
        }
        public FrmRefreshCache(long CompanyID)
        {
            InitializeComponent();
            this._CompanyID = CompanyID;
        }
        private void FrmRefreshCache_Load(object sender, EventArgs e)
        {Thread Start = new Thread(() => ResetCacheProduct(_CompanyID));
            Start.Start();
        }


        private void ResetCacheProduct(long companyID)
        {
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(ConfigCrawler.ConnectProduct));
            QT.Entities.Server.ConnectionString = ConfigCrawler.ConnectProduct;
            QT.Moduls.CrawlerProduct.Cache.CacheProductHash cashProductHash = QT.Moduls.CrawlerProduct.Cache.CacheProductHash.Instance();
            QT.Moduls.CrawlerProduct.Cache.RedisLastUpdateProduct cacheLastUpdateProduct = QT.Moduls.CrawlerProduct.Cache.RedisLastUpdateProduct.Instance();
            List<QT.Entities.CrawlerProduct.Cache.ProductHash> lst = new List<QT.Entities.CrawlerProduct.Cache.ProductHash>();
            List<long> lstLastUpdate = new List<long>();
            Company cmp = new Company(companyID);
            productAdapter.DeleteProductUnvalidOfCOmpany(companyID);
            DataTable tbl = productAdapter.GetProductResetColumnDuplicateAndChange(companyID);
            foreach (DataRow rowProduct in tbl.Rows)
            {
                long ProductId = QT.Entities.Common.Obj2Int64(rowProduct["ID"]);
                string Name = rowProduct["Name"].ToString();
                long Price = QT.Entities.Common.Obj2Int64(rowProduct["Price"]);
                string ImageUrl = Convert.ToString(rowProduct["ImageUrls"]);
                string DetailUrl = Convert.ToString(rowProduct["DetailUrl"]);
                int InStock = QT.Entities.Common.Obj2Int(rowProduct["InStock"]);long OriginPrice = QT.Entities.Common.Obj2Int(rowProduct["OriginPrice"]);
                bool Valid = QT.Entities.Common.Obj2Bool(rowProduct["Valid"]);
                string shortDescription = QT.Entities.Common.CellToString(rowProduct["ShortDescription"], "");
                bool IsDeal = QT.Entities.Common.Obj2Bool(rowProduct["IsDeal"]);
                long CategoryID = rowProduct["ClassificationID"] == DBNull.Value ? 0 : QT.Entities.Common.Obj2Int64(rowProduct["ClassificationID"]);
                long HashChange = QT.Entities.ProductEntity.GetHashChangeInfo(InStock, Valid, Price, Name, ImageUrl, CategoryID, shortDescription, OriginPrice);
                long HashDuplicate = QT.Entities.Product.GetHashDuplicate(cmp.Domain, Price, Name, ImageUrl);
                long HashImage = QT.Entities.Product.GetHashImageInfo(ImageUrl);
                lst.Add(new QT.Entities.CrawlerProduct.Cache.ProductHash()
                {
                    HashChange = HashChange,
                    HashDuplicate = HashDuplicate,
                    HashImage = HashImage,
                    Id = ProductId,
                    Price = Price,
                    url = DetailUrl
                });
                lstLastUpdate.Add(ProductId);
            }
            cashProductHash.SetCacheProductHash(companyID, lst, 100);
            cacheLastUpdateProduct.RemoveAllLstProduct(companyID);
            cacheLastUpdateProduct.UpdateBathLastUpdateProduct(companyID, lstLastUpdate, DateTime.Now.AddDays(-1));
            productAdapter.UpdateCountProductForCompany(companyID, lstLastUpdate.Count, lstLastUpdate.Count);
            lst.Clear();
            lstLastUpdate.Clear();
            this.Invoke(new Action(() =>
            {
                try
                {
                    richTextBox1.AppendText(string.Format("Refresh Complete Company: {0}", _CompanyID));
                }
                catch (Exception ex01)
                {
                }
            }));
        }
    }
}
