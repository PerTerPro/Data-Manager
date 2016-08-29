
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using QT.Entities.Data.SolrDb.SaleNews;
using QT.Entities.Model.SaleNews;
using System;
using System.Collections;
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

namespace QT.Moduls.CrawlSale
{
    public partial class FrmManagerProductSale : Form
    {
        SolrRaoVatDriver solrRaoVat = SolrRaoVatDriver.GetInstance();
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmManagerProductSale));

        public FrmManagerProductSale()
        {
            InitializeComponent();
        }



        string GetFileName(string color)
        {

            if (color == null || color == string.Empty)

                return string.Empty;

            return color + ".jpg";

        }

        string ImageDir = @"Images\";

        Hashtable Images = new Hashtable();

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "image" && e.IsGetData && ckLoadImage.Checked)
            {
                GridView view = sender as GridView;
                Image img = null;
                try
                {
                    string url = (e.Row as ProductSaleNew).thumb_url;
                    var request = WebRequest.Create(url);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        img = Image.FromStream(stream);
                    }
                }
                catch
                {
                }
                e.Value = img;
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            List<ProductSaleNew> lstProductSaleNew = solrRaoVat.GetListProduct(txtQuery.Text,Convert.ToInt32(spinNumberItem.Value));
        }

        private void btnRequest1000_Click(object sender, EventArgs e)
        {
            try
            {
                List<ProductSaleNew> lstProductSaleNew = solrRaoVat.GetListProductLast(Convert.ToInt32(spinNumberItem.Value));
                this.gridControl1.DataSource = lstProductSaleNew;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Thread threadHideData = new Thread(() =>
            {
                MongoDbRaoVat mongoDb = new MongoDbRaoVat();
                try
                {
                    List<string> lstDelItem = new List<string>();

                   
                    int iRowCount = this.gridView1.DataRowCount;
                    for (int iRow = 0; iRow < iRowCount; iRow++)
                    {
                        ProductSaleNew productSalenew = this.gridView1.GetRow(iRow) as ProductSaleNew;
                        if (productSalenew.is_selected) lstDelItem.Add(productSalenew._id);
                       
                    }
                    //Xóa dữ liệu trên solr.
                    this.solrRaoVat.DelProductById(lstDelItem);
                    //Ẩn dữ liệu từ mongo.
                    foreach (var item in lstDelItem)
                    {
                        mongoDb.UpdateStatusOfProduct(item, 0);
                    }

                }
                catch (Exception ex)
                {
                    log.ErrorFormat(ex.Message);
                }
            });
            threadHideData.Start();
            threadHideData.Join();
            MessageBox.Show("Hoan Tat");
          

        }

        private void FrmManagerProduct_Load(object sender, EventArgs e)
        {
            gridControl1.ForceInitialize();

            // Create an unbound column.
            GridColumn unbColumn = gridView1.Columns.AddField("image");
            unbColumn.VisibleIndex = gridView1.Columns.Count;
            unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            // Disable editing.
            unbColumn.OptionsColumn.AllowEdit = false;
            // Specify format settings.
            unbColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            unbColumn.ColumnEdit = this.repositoryItemPictureEdit2;
            unbColumn.DisplayFormat.FormatString = "c";
            // Customize the appearance settings.
            unbColumn.AppearanceCell.BackColor = Color.LemonChiffon;

            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(gridView1_CustomUnboundColumnData);
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {

        }

        private void btnVisible_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFindByName_Click(object sender, EventArgs e)
        {
            try
            {
                List<ProductSaleNew> lstProductSaleNew = solrRaoVat.GetListProduct(
                    string.Format("name:*{0}* price:[{1} TO {2}]"
                    , txtNameItem.Text
                    , this.GetPriceFrom()
                    , this.GetPriceTo())
                    , Convert.ToInt32(spinNumberItem.Value));
                this.gridControl1.DataSource = lstProductSaleNew;
                this.gridView1.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int GetPriceFrom ()
        {
            return Convert.ToInt32(spinEditPriceFrom.Value);
        }

        public int GetPriceTo ()
        {
            return Convert.ToInt32(spinEditPriceTo.Value);
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void txtNameItem_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode==Keys.Enter)
           {
               btnFindByName.PerformClick();
           }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            int[] arSelected = this.gridView1.GetSelectedRows();
            foreach(var itemRow in arSelected)
            {
                ProductSaleNew ptsn = this.gridView1.GetRow(itemRow) as ProductSaleNew;
                ptsn.is_selected = true;
            }
            this.gridView1.RefreshData();
        }

        private void btnUnCheckAll_Click(object sender, EventArgs e)
        {
            int[] arSelected = this.gridView1.GetSelectedRows();
            foreach (var itemRow in arSelected)
            {
                ProductSaleNew ptsn = this.gridView1.GetRow(itemRow) as ProductSaleNew;
                ptsn.is_selected = false;
            }
            this.gridView1.RefreshData();
        }

        private void FrmManagerProductSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F5)
            {
                this.btnFindByName.PerformClick();
            }
        }

      
    }
}
