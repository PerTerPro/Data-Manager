using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QT.Entities;

namespace QT.Moduls.Maps
{
    public partial class ctrProducAnanytic : UserControl
    {
        private string nameProduct = "";
        public delegate void UpdateEventHandler(int status);
        public event UpdateEventHandler UpdateMapIDClick;
        public ctrProducAnanytic()
        {
            InitializeComponent();
            this.productAnanyticTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.product_KeyComparisonTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productIDTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
        }
        private int _productID = 0;
        public void LoadData()
        {

        }
        public void SetProductID(int productID)
        {
            _productID = productID;
            dBPMan.ProductAnanytic.Clear();
            DBPManTableAdapters.ProductTableAdapter adt = new DBPManTableAdapters.ProductTableAdapter();
            adt.Connection.ConnectionString = Server.ConnectionString;
            DBPMan.ProductDataTable dt = new DBPMan.ProductDataTable();
            adt.FillBy_SelectOne(dt, productID);
            if (dt.Rows.Count > 0) { nameProduct = dt.Rows[0]["Name"].ToString(); }
            adt.Dispose();
            dt.Dispose();



            this.product_KeyComparisonTableAdapter.FillBy_ProductID(dBPMan.Product_KeyComparison, productID);
            
            if (dBPMan.Product_KeyComparison.Rows.Count <= 0)
            {
                this.dBPMan.Product_KeyComparison.IDProductColumn.DefaultValue = productID;
                //this.dBPMan.Product_KeyComparison.IDKeySearchColumn.DefaultValue = 0;
                this.product_KeyComparisonBindingSource.AddNew();
                this.product_KeyComparisonBindingSource.EndEdit();
            }
            txttcode.Text = "";
        }
        public void Ananytic()
        {
            if (txtCode.Text.Trim().Length == 0)
            {
                nameProduct = nameProduct.Replace("–", "-");
                nameProduct = nameProduct.Replace("&", "-");
                if (nameProduct.IndexOf('-') > 0)
                {
                    string[] s = nameProduct.Split('-');
                    this.txtCode.Text = s[0].Trim().ToString();
                    this.product_KeyComparisonBindingSource.EndEdit();
                }
            }
            string maxkhongtontai = "123456qwertasdfgcvznQWERTY";
            this.txtCode.Text = this.txtCode.Text.Replace("/", " ");
            this.txtCode.Text = this.txtCode.Text.Replace("*", " ");
            this.txtCode.Text = this.txtCode.Text.Replace("&", " ");
            this.txtCode.Text = this.txtCode.Text.Replace("$", " ");
            this.txtCode.Text = this.txtCode.Text.Trim().Replace("  ", " ");
            this.txtKeywordLike.Text = this.txtKeywordLike.Text;
            this.txtNotKeywordLike.Text = this.txtNotKeywordLike.Text.Trim();
            this.lastUpdateDateTimePicker.Value = DateTime.Now;

            this.product_KeyComparisonBindingSource.EndEdit();
            try
            {
                this.product_KeyComparisonTableAdapter.Update(this.dBPMan.Product_KeyComparison);
            }
            catch (Exception)
            {
                MessageBox.Show("Tên sản phẩm này đã có, bạn hãy nhập lại");
            }

            if (txtCode.Text.Trim().Length > 0)
            {
                String key = "";
                string notKey = "";
                if (txtNotKeywordLike.Text.Trim().Length <= 1)
                {
                    notKey = "123456qwertasdfgcvzn";
                }
                else
                {
                    notKey = txtNotKeywordLike.Text.Trim();
                }
                string[] ls = txtCode.Text.Trim().Replace("*", " ").Replace("  ", " ").Split(' ');
                if (ls.Length == 1)
                {
                    key = String.Format(@"""*{0}*""", ls[0]);
                }
                else
                {
                    string s = "";
                    foreach (string sitem in ls)
                    {
                        s += @"""*" + sitem + @"*"",";
                    }
                    s += ",";
                    s = s.Replace(",,", "");
                    key = string.Format(@"NEAR(({0}),MAX,FALSE)", s);
                }

                string exl = "", exl1 = "", exl2 = "", exl3 = "";
                string[] ls1 = txtKeywordLike.Text.Trim().Split(',');
                switch (ls1.Length)
                {
                    case 1:
                        exl = "%" + ls1[0] + "%";
                        exl1 = "%%";
                        exl2 = "%%";
                        exl3 = "%%";
                        break;
                    case 2:
                        exl = "%" + ls1[0] + "%";
                        exl1 = "%" + ls1[1] + "%";
                        exl2 = "%%";
                        exl3 = "%%";
                        break;
                    case 3:
                        exl = "%" + ls1[0] + "%";
                        exl1 = "%" + ls1[1] + "%";
                        exl2 = "%" + ls1[2] + "%";
                        exl3 = "%%";
                        break;
                    case 4:
                        exl = "%" + ls1[0] + "%";
                        exl1 = "%" + ls1[1] + "%";
                        exl2 = "%" + ls1[2] + "%";
                        exl3 = "%" + ls1[3] + "%";
                        break;
                }

                string exnl = "", exnl1 = "", exnl2 = "", exnl3 = "";
                string[] lsn1 = txtNotLikeKeywordOneCharTextEdit.Text.Split(',');
                switch (lsn1.Length)
                {
                    case 1:
                        if (lsn1[0].Length == 0)
                        {
                            exnl = maxkhongtontai;
                        }
                        else
                        {
                            exnl = "%" + lsn1[0] + "%";
                        }
                        exnl1 = maxkhongtontai;
                        exnl2 = maxkhongtontai;
                        exnl3 = maxkhongtontai;
                        break;
                    case 2:
                        exnl = "%" + lsn1[0] + "%";
                        exnl1 = "%" + lsn1[1] + "%";
                        exnl2 = maxkhongtontai;
                        exnl3 = maxkhongtontai;
                        break;
                    case 3:
                        exnl = "%" + lsn1[0] + "%";
                        exnl1 = "%" + lsn1[1] + "%";
                        exnl2 = "%" + lsn1[2] + "%";
                        exnl3 = maxkhongtontai;
                        break;
                    case 4:
                        exnl = "%" + lsn1[0] + "%";
                        exnl1 = "%" + lsn1[1] + "%";
                        exnl2 = "%" + lsn1[2] + "%";
                        exnl3 = "%" + lsn1[3] + "%";
                        break;
                }

                this.productAnanyticTableAdapter.FillBy_Analytic_V2(dBPMan.ProductAnanytic,
                    Common.Obj2Int(this.priceMinium.Value),
                    Common.Obj2Int(this.priceMaximum.Value),
                    key,
                    exl,
                    exl1,
                    exl2,
                    exl3,
                    notKey,
                    exnl,
                    exnl1,
                    exnl2,
                    exnl3,
                    _productID);
                this.tongSanPhamTextBox.Text = dBPMan.ProductAnanytic.Rows.Count.ToString();
                if (dBPMan.ProductAnanytic.Rows.Count > 0)
                {
                    this.spGiaNhoNhat.EditValue = dBPMan.ProductAnanytic.Rows[0]["Price"].ToString();
                    this.spGiaLonNhat.EditValue = dBPMan.ProductAnanytic.Rows[dBPMan.ProductAnanytic.Rows.Count-1]["Price"].ToString();
                }
                else
                {
                    this.spGiaNhoNhat.EditValue = 0;
                    this.spGiaLonNhat.EditValue = 0;
              
                }
                this.product_KeyComparisonBindingSource.EndEdit();
                try
                {
                    this.product_KeyComparisonTableAdapter.Update(this.dBPMan.Product_KeyComparison);
                }
                catch (Exception)
                {
                    MessageBox.Show("Tên sản phẩm này đã có, bạn hãy nhập lại");
                }
            }
            else
            {
                txtKeywordLike.Focus();
            }
        }

        private void btAnanytic_Click(object sender, EventArgs e)
        {
            Ananytic();
            this.productIDTableAdapter.FillBy_ProductID(dBPMan.ProductID, _productID);
            UpdateMapIDClick(0);
        }

        private int indexName = 0, indexkeyword = 0, indexnotkeyword = 0;
        private void btGetCode_Click(object sender, EventArgs e)
        {
            string[] s = nameProduct.Split('-');
            if (s.Length > 0)
            {
                if (indexName < s.Length)
                {
                    this.txttcode.Text = s[indexName++].ToString();
                }
                else
                {
                    indexName = 0;
                }
            }
            
        }

        private void btCodeAdd_Click(object sender, EventArgs e)
        {
            this.txtCode.Text += " " + txttcode.Text;
            indexName = 0;
        }
     
        private void btGetPriceMin_Click(object sender, EventArgs e)
        {
            this.priceMinium.Value = this.priceProduct.Value;
        }

        private void btGetPriceMax_Click(object sender, EventArgs e)
        {
            this.priceMaximum.Value = this.priceProduct.Value;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            indexnotkeyword = 0;
            indexName = 0;
            indexkeyword = 0;
        }


        public void MapAllAndUpdate()
        {
            MapAllID();
            SaveAnanytic();
            if (dBPMan.ProductAnanytic.Rows.Count > 0)
            {
                UpdateMapIDClick(1);
            }
            else
            {
                UpdateMapIDClick(0);
            }
        }
        private void btUpDate_Click(object sender, EventArgs e)
        {
            MapAllAndUpdate();
            //productAnanyticBindingSource.MoveFirst();
            //for (int i = 0; i < dBPMan.ProductAnanytic.Rows.Count; i++)
            //{
            //    this.productIDTextBox.Text = _productID.ToString();
            //    productAnanyticBindingSource.MoveNext();
            //}
            //productAnanyticBindingSource.EndEdit();
            //this.productAnanyticTableAdapter.Update(dBPMan.ProductAnanytic);
           
        }

        public void SaveAnanytic()
        {
            try
            {
                foreach (DBPMan.ProductAnanyticRow dr in dBPMan.ProductAnanytic)
                {
                    this.productAnanyticTableAdapter.UpdateQuery_ProductID(dr.ProductID, dr.ID);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btRemoveID_Click(object sender, EventArgs e)
        {
            this.productIDTextBox.Text = "0";
            this.productAnanyticBindingSource.EndEdit();
        }
        private void MapAllID()
        {
            productAnanyticBindingSource.MoveFirst();
            for (int i = 0; i < dBPMan.ProductAnanytic.Rows.Count; i++)
            {
                this.productIDTextBox.Text = _productID.ToString();
                productAnanyticBindingSource.MoveNext();
            }
            productAnanyticBindingSource.EndEdit();
        }
        private void btMapID_Click(object sender, EventArgs e)
        {
            
        }

        private void btMapCurrentID_Click(object sender, EventArgs e)
        {
            this.productIDTextBox.Text = _productID.ToString();
            this.productAnanyticBindingSource.EndEdit();
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            if (this.productIDTextBox.Text == "0")
            {
                this.productIDTextBox.Text = _productID.ToString();
            }
            else
            {
                this.productIDTextBox.Text = "0";
            }
            productAnanyticBindingSource.EndEdit();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void btRemoveAll_Click(object sender, EventArgs e)
        {
            productAnanyticBindingSource.MoveFirst();
            for (int i = 0; i < dBPMan.ProductAnanytic.Rows.Count; i++)
            {
                this.productIDTextBox.Text = "0";
                productAnanyticBindingSource.MoveNext();
            }
            productAnanyticBindingSource.EndEdit();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

    }
}
