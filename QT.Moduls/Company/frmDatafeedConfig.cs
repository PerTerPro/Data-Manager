using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QT.Moduls.Company
{
    public partial class frmDatafeedConfig : Form
    {
        private long IDCompany;
        private string Status = string.Empty;
        public frmDatafeedConfig(long companyid)
        {
            InitializeComponent();
            IDCompany = companyid;
            InitData();
      
        }
        private void InitData()
        {
            // gán datasource cho lookupedit CurrencyFormat
            DataTable dt = new DataTable();
            dt.Columns.Add("Key", typeof(int));
            dt.Columns.Add("Value", typeof(string));
            DataRow dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "Vietnamese";
            dt.Rows.Add(dr);
            DataRow dr2 = dt.NewRow();
            dr2[0] = 2;
            dr2[1] = "US";
            dt.Rows.Add(dr2);
            CurrencyFomatLookupedit.Properties.DataSource = dt;
            this.datafeedConfigTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            //Kiểm tra xem trong database đã có config của COmpany này chưa, nếu chưa có thì GetDefault DatafeedConfig ra
            datafeedConfigTableAdapter.FillByCompanyID(dBCom.DatafeedConfig,IDCompany);
            if (dBCom.DatafeedConfig.Rows.Count == 0)
            {
                #region Gán dữ liệu default
                companyIDTextEdit.Text = IDCompany.ToString();
                DatafeedConfig datafeedConfig = DatafeedConfig.GetDefaultXMLDatafeedConfig();
                productListNodeTextEdit.Text = datafeedConfig.ProductListNode;
                productItemNodeTextEdit.Text = datafeedConfig.ProductItemNode;
                skuNodeTextEdit.Text = datafeedConfig.SkuNode;
                instockNodeTextEdit.Text = datafeedConfig.InstockNode;
                brandNodeTextEdit.Text = datafeedConfig.BrandNode;
                productNameNodeTextEdit.Text = datafeedConfig.ProductNameNode;
                descriptionNodeTextEdit.Text = datafeedConfig.DescriptionNode;
                currencyNodeTextEdit.Text = datafeedConfig.CurrencyNode;
                priceNodeTextEdit.Text = datafeedConfig.PriceNode;
                discountedPriceNodeTextEdit.Text = datafeedConfig.DiscountedPriceNode;
                discountNodeTextEdit.Text = datafeedConfig.DiscountNode;
                CurrencyFomatLookupedit.EditValue = 1;
                category1NodeTextEdit.Text = datafeedConfig.Category1Node;
                category2NodeTextEdit.Text = datafeedConfig.Category2Node;
                parentOfCategory1NodeTextEdit.Text = datafeedConfig.ParentOfCategory1Node;
                parentOfCategory2NodeTextEdit.Text = datafeedConfig.ParentOfCategory2Node;
                parentOfParentOfCategory1NodeTextEdit.Text = datafeedConfig.ParentOfParentOfCategory1Node;
                parentOfParentOfCategory2NodeTextEdit.Text = datafeedConfig.ParentOfParentOfCategory2Node;
                pictureUrl1NodeTextEdit.Text = datafeedConfig.PictureUrl1Node;
                pictureUrl2NodeTextEdit.Text = datafeedConfig.PictureUrl2Node;
                pictureUrl3NodeTextEdit.Text = datafeedConfig.PictureUrl3Node;
                pictureUrl4NodeTextEdit.Text = datafeedConfig.PictureUrl4Node;
                pictureUrl5NodeTextEdit.Text = datafeedConfig.PictureUrl5Node;
                urlNodeTextEdit.Text = datafeedConfig.UrlNode;
                warrantyNodeTextEdit.Text = datafeedConfig.WarrantyNode;
                #endregion
            }
        }
        private void frmDatafeedConfig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBCom.DatafeedConfig' table. You can move, or remove it, as needed.
            //this.datafeedConfigTableAdapter.Fill(this.dBCom.DatafeedConfig);
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            datafeedConfigBindingSource.EndEdit();
            int i = 0;
            if (datafeedConfigIDTextEdit.Text == "")
            {
                int curentcyfomat = 0;
                int.TryParse(CurrencyFomatLookupedit.EditValue.ToString(), out curentcyfomat);
                // nếu curtencufomat
                if (curentcyfomat == 0 || curentcyfomat > 2)
                {
                    curentcyfomat = 1;
                }
                i = datafeedConfigTableAdapter.Insert(IDCompany, productListNodeTextEdit.Text, productItemNodeTextEdit.Text, skuNodeTextEdit.Text, instockNodeTextEdit.Text,
                    brandNodeTextEdit.Text, productNameNodeTextEdit.Text, descriptionNodeTextEdit.Text, currencyNodeTextEdit.Text, priceNodeTextEdit.Text, discountedPriceNodeTextEdit.Text,
                    discountNodeTextEdit.Text, category1NodeTextEdit.Text, parentOfCategory1NodeTextEdit.Text, parentOfParentOfCategory1NodeTextEdit.Text,
                    category2NodeTextEdit.Text, parentOfCategory2NodeTextEdit.Text, parentOfParentOfCategory2NodeTextEdit.Text, pictureUrl1NodeTextEdit.Text,
                    pictureUrl2NodeTextEdit.Text, pictureUrl3NodeTextEdit.Text, pictureUrl4NodeTextEdit.Text, pictureUrl5NodeTextEdit.Text, urlNodeTextEdit.Text, curentcyfomat,warrantyNodeTextEdit.Text,xNameSpaceTextEdit.Text,regexConfigUrlTextEdit.Text,shortDescriptionNodeTextEdit.Text,vATStatusNodeTextEdit.Text);
            }
            else
                i = datafeedConfigTableAdapter.Update(dBCom.DatafeedConfig);
            if (i == 1)
            {
                XtraMessageBox.Show("Cấu hình datafeed thành công!");
                this.Close();
            }
            else
                XtraMessageBox.Show("Xảy ra lỗi! Kiểm tra lại!");
        }
        private void ClearAllText()
        {
            productListNodeTextEdit.Text = string.Empty;
            productItemNodeTextEdit.Text = string.Empty;
            skuNodeTextEdit.Text = string.Empty;
            instockNodeTextEdit.Text = string.Empty;
            brandNodeTextEdit.Text = string.Empty;
            productNameNodeTextEdit.Text = string.Empty;
            descriptionNodeTextEdit.Text = string.Empty;
            currencyNodeTextEdit.Text = string.Empty;
            priceNodeTextEdit.Text = string.Empty;
            discountedPriceNodeTextEdit.Text = string.Empty;
            discountNodeTextEdit.Text = string.Empty;
            CurrencyFomatLookupedit.EditValue = 1;
            category1NodeTextEdit.Text = string.Empty;
            category2NodeTextEdit.Text = string.Empty;
            parentOfCategory1NodeTextEdit.Text = string.Empty;
            parentOfCategory2NodeTextEdit.Text = string.Empty;
            parentOfParentOfCategory1NodeTextEdit.Text = string.Empty;
            parentOfParentOfCategory2NodeTextEdit.Text = string.Empty;
            pictureUrl1NodeTextEdit.Text = string.Empty;
            pictureUrl2NodeTextEdit.Text = string.Empty;
            pictureUrl3NodeTextEdit.Text = string.Empty;
            pictureUrl4NodeTextEdit.Text = string.Empty;
            pictureUrl5NodeTextEdit.Text = string.Empty;
            urlNodeTextEdit.Text = string.Empty;
            warrantyNodeTextEdit.Text = string.Empty;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ClearAllText();
            DatafeedConfig datafeedConfig = DatafeedConfig.GetDefaultXMLDatafeedConfig();
            productListNodeTextEdit.Text = datafeedConfig.ProductListNode;
            productItemNodeTextEdit.Text = datafeedConfig.ProductItemNode;
            skuNodeTextEdit.Text = datafeedConfig.SkuNode;
            instockNodeTextEdit.Text = datafeedConfig.InstockNode;
            brandNodeTextEdit.Text = datafeedConfig.BrandNode;
            productNameNodeTextEdit.Text = datafeedConfig.ProductNameNode;
            descriptionNodeTextEdit.Text = datafeedConfig.DescriptionNode;
            currencyNodeTextEdit.Text = datafeedConfig.CurrencyNode;
            priceNodeTextEdit.Text = datafeedConfig.PriceNode;
            discountedPriceNodeTextEdit.Text = datafeedConfig.DiscountedPriceNode;
            discountNodeTextEdit.Text = datafeedConfig.DiscountNode;
            CurrencyFomatLookupedit.EditValue = 1;
            category1NodeTextEdit.Text = datafeedConfig.Category1Node;
            category2NodeTextEdit.Text = datafeedConfig.Category2Node;
            parentOfCategory1NodeTextEdit.Text = datafeedConfig.ParentOfCategory1Node;
            parentOfCategory2NodeTextEdit.Text = datafeedConfig.ParentOfCategory2Node;
            parentOfParentOfCategory1NodeTextEdit.Text = datafeedConfig.ParentOfParentOfCategory1Node;
            parentOfParentOfCategory2NodeTextEdit.Text = datafeedConfig.ParentOfParentOfCategory2Node;
            pictureUrl1NodeTextEdit.Text = datafeedConfig.PictureUrl1Node;
            pictureUrl2NodeTextEdit.Text = datafeedConfig.PictureUrl2Node;
            pictureUrl3NodeTextEdit.Text = datafeedConfig.PictureUrl3Node;
            pictureUrl4NodeTextEdit.Text = datafeedConfig.PictureUrl4Node;
            pictureUrl5NodeTextEdit.Text = datafeedConfig.PictureUrl5Node;
            urlNodeTextEdit.Text = datafeedConfig.UrlNode;
            vATStatusNodeTextEdit.Text = datafeedConfig.VATStatus;
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            ClearAllText();
        }

        private void defaultCSVButton_Click(object sender, EventArgs e)
        {
            ClearAllText();
            DatafeedConfig datafeedConfig = DatafeedConfig.GetDefaultCSVDatafeedConfig();
            productListNodeTextEdit.Text = datafeedConfig.ProductListNode;
            productItemNodeTextEdit.Text = datafeedConfig.ProductItemNode;
            skuNodeTextEdit.Text = datafeedConfig.SkuNode;
            instockNodeTextEdit.Text = datafeedConfig.InstockNode;
            brandNodeTextEdit.Text = datafeedConfig.BrandNode;
            productNameNodeTextEdit.Text = datafeedConfig.ProductNameNode;
            descriptionNodeTextEdit.Text = datafeedConfig.DescriptionNode;
            currencyNodeTextEdit.Text = datafeedConfig.CurrencyNode;
            priceNodeTextEdit.Text = datafeedConfig.PriceNode;
            discountedPriceNodeTextEdit.Text = datafeedConfig.DiscountedPriceNode;
            discountNodeTextEdit.Text = datafeedConfig.DiscountNode;
            CurrencyFomatLookupedit.EditValue = 1;
            category1NodeTextEdit.Text = datafeedConfig.Category1Node;
            category2NodeTextEdit.Text = datafeedConfig.Category2Node;
            parentOfCategory1NodeTextEdit.Text = datafeedConfig.ParentOfCategory1Node;
            parentOfCategory2NodeTextEdit.Text = datafeedConfig.ParentOfCategory2Node;
            parentOfParentOfCategory1NodeTextEdit.Text = datafeedConfig.ParentOfParentOfCategory1Node;
            parentOfParentOfCategory2NodeTextEdit.Text = datafeedConfig.ParentOfParentOfCategory2Node;
            pictureUrl1NodeTextEdit.Text = datafeedConfig.PictureUrl1Node;
            pictureUrl2NodeTextEdit.Text = datafeedConfig.PictureUrl2Node;
            pictureUrl3NodeTextEdit.Text = datafeedConfig.PictureUrl3Node;
            pictureUrl4NodeTextEdit.Text = datafeedConfig.PictureUrl4Node;
            pictureUrl5NodeTextEdit.Text = datafeedConfig.PictureUrl5Node;
            urlNodeTextEdit.Text = datafeedConfig.UrlNode;
        }

    }
}
