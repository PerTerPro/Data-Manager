using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QT.Entities;
using System.Threading;

namespace QT.Moduls.Maps
{
    public partial class ctrProductInCategory : UserControl
    {
        private Category objCat = new Category();
        private Classification objClass = new Classification();
        DBMapTableAdapters.ProductIDTableAdapter adtID = new DBMapTableAdapters.ProductIDTableAdapter();
        public ctrProductInCategory()
        {
            InitializeComponent();
            this.productTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            adtID.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            webImage.ScriptErrorsSuppressed = true;
            webContent.ScriptErrorsSuppressed = true;
        }

        private long _IDClassification = 0;
        private int _IDCat = 0;
        public long IDClassification
        {
            set
            {
                _IDClassification = value;
                objClass.SelectOne(value);
                IDCategory = objClass.IDCategory;
            }
            get { return _IDClassification; }
        }
        /// <summary>
        /// Số cấp level chuyên mục gộp lấy dữ liệu
        /// </summary>
        public int LevelMap
        {
            set;
            get;

        }
        public string NameCategory { set; get; }
        public int IDCategory
        {
            set
            {
                _IDCat = value;
                objCat.SelectOne(value);
                if (value > 0)
                {
                    this.laIDCateMap.Text = value.ToString() + " - " + objCat.Name;
                    NameCategory = objCat.Name;
                }
                else
                {
                    this.laIDCateMap.Text = " - ";
                }
            }
            get { return _IDCat; }
        }

        public bool LoadData()
        {
            bool r = true;
            try
            {
                /// tìm theo id classification
                //this.productTableAdapter.FillBy_Classification(this.dBMap.Product, _IDClassification);

                // tìm tất cả sản phẩm trong level
                String like = "";
                int count = 0;
                for (int i = 0; i < objClass.Name.Length - 2; i++)
                {
                    if (objClass.Name.ToString().Substring(i, 2).ToString() == "->")
                    {
                        count++;
                        if (count >= LevelMap)
                        {
                            like = objClass.Name.Substring(0, i) + "%";
                            break;
                        }
                    }
                }
                if (like == "")
                {
                    like = objClass.Name.ToString() + "%";
                }
                this.productTableAdapter.FillBy_LikeNameClassificationChuaMap(this.dBMap.Product, like);
                r = true;
            }
            catch (Exception)
            {
                r = false;
            }
            return r;
        }
        public bool LoadDataAll()
        {
            bool r = true;
            try
            {
                // tìm tất cả sản phẩm trong level
                String like = "";
                int count = 0;
                for (int i = 0; i < objClass.Name.Length; i++)
                {
                    if (objClass.Name.Substring(i, 2) == "->")
                    {
                        count++;
                        if (count >= LevelMap)
                        {
                            like = objClass.Name.Substring(0, i) + "%";
                            break;
                        }
                    }
                }

                this.productTableAdapter.FillBy_LikeNameClassification(this.dBMap.Product, like);
                r = true;
            }
            catch (Exception)
            {
                r = false;
            }
            return r;
        }

        private void productContentTextBox_TextChanged(object sender, EventArgs e)
        {
            webContent.DocumentText = productContentTextBox.Text;
        }

        private void promotionTextBox_TextChanged(object sender, EventArgs e)
        {
            List<String> limage = new List<string>();
            String[] images = promotionTextBox.Text.Split('\n');
            string html = "";
            String f = "<img src='{0}' /><br/>";
            if (images.Length > 0)
            {
                for (int i = 0; i < images.Length; i++)
                {
                    html += string.Format(f, images[i]);
                }
            }
            else
            {
                html += string.Format(f, imageUrlsTextBox.Text);
            }
            webImage.DocumentText = html;

        }
        private void imageUrlsTextBox_TextChanged(object sender, EventArgs e)
        {
            string html = "";
            String f = "<img src='{0}' /><br/>";
            if (promotionTextBox.Text.Trim().Length == 0)
            {
                html = string.Format(f, imageUrlsTextBox.Text);
            }
            webImage.DocumentText = html;
        }
        private void btMap_Click(object sender, EventArgs e)
        {
            LoadData();
            frmChonChuyenMucGoc frm = new frmChonChuyenMucGoc();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                laIDCateMap.Text = frm.IDClassification.ToString() + " - " + frm.NameClassification;
                labelControlListIDSearch.Text = frm.ListIDSearch;
                IDCategory = frm.IDClassification;
                DBMapTableAdapters.ClassificationTableAdapter adt = new DBMapTableAdapters.ClassificationTableAdapter();
                adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
                adt.UpdateQuery_IDCategory(frm.IDClassification, _IDClassification);
                adt.Dispose();
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private Thread ConvertSPGocThread;
        private void btConvertSPGoc_Click(object sender, EventArgs e)
        {
            ConvertSPGocThread = new Thread(doConvertSPGoc);
            ConvertSPGocThread.Start();
        }

        void doConvertSPGoc()
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.lamssconvert.Text = "Start convert";
            });
            DBPManTableAdapters.ProductTableAdapter adtProduct = new DBPManTableAdapters.ProductTableAdapter();
            DBPMan.ProductDataTable dtP = new DBPMan.ProductDataTable();
            adtProduct.Connection.ConnectionString = Server.ConnectionString;
            int i = 0;
            foreach (DBMap.ProductRow dr in dBMap.Product)
            {
                //if (Common.Obj2Int64(dr.ProductID) <= 0)
                //{
                //insert to productid
                // vatgia
                if ((dBMap.Product.Rows[i]["ImageUrls"].ToString().Trim() != "")
                    //&& (dBMap.Product.Rows[i]["ProductContent"].ToString().Trim().Length > 10)
                    && (dBMap.Product.Rows[i]["ImageUrls"].ToString().Trim() != ""))
                {
                    int ID = Common.GetID_ProductID(dr.Name, IDCategory);
                    try
                    {
                        string name = dr.Name.Replace("- Thông số kỹ thuật", "").Trim();
                        string contentft = Common.UnicodeToKoDauFulltext(name +" "+ labelControlListIDSearch.Text);
                        if (adtProduct.Connection.State == ConnectionState.Closed) adtProduct.Connection.Open();
                        try
                        {
                            /// check san pham nay da được tạo chưa
                            /// nếu chưa thì insert
                            /// đã có thì update lại thông số kỹ thuật
                            /// 
                            dtP = new DBPMan.ProductDataTable();
                            adtProduct.FillBy_CheckID(dtP, ID);
                            if (dtP.Rows.Count > 0)
                            {
                                //adtProduct.UpdateQuery_SPGoc(
                                //    12,
                                //    Common.GetIDCompany("quangtrung.vn"),
                                //    DateTime.Now,
                                //    dBMap.Product.Rows[i]["ProductContent"].ToString(),
                                //    name,
                                //    dr.DetailUrl,
                                //    dr.ImageUrls,
                                //    Common.UnicodeToKoDauFulltext(name),
                                //    false,
                                //    Common.GetHashNameProduct("quangtrung.vn", name),
                                //    "",
                                //    IDCategory,
                                //    ID);

                            }
                            else
                            {
                                // chuyển sang làm sản phẩm gốc
                                adtProduct.InsertQuery_SPGoc(
                                    ID,
                                    Common.GetIDCompany("quangtrung.vn"),
                                    DateTime.Now,
                                    name,
                                    dBMap.Product.Rows[i]["ProductContent"].ToString(),
                                    name,
                                    dr.DetailUrl,
                                    dr.ImageUrls,
                                    Common.UnicodeToKoDauFulltext(name) + " " + NameCategory + " " + Common.UnicodeToKoDauFulltext(NameCategory),
                                    false,
                                    Common.GetHashNameProduct("quangtrung.vn", name),
                                    "",
                                    IDCategory,
                                    Common.Obj2Int(dBMap.Product.Rows[i]["Price"].ToString()),
                                    dr.ID,  // lưu product id vào trường classification vì productid chỉ là kiểu int
                                    contentft);
                                LogJobAdapter.SaveLog(JobName.FrmEditeProductByCat_Them_moi_san_pham_goc, "Thêm mới sản phẩm gốc MAP PRODUCT!", ID, (int)JobTypeData.Product);
                            }
                            dtP.Dispose();
                            List<PropertyEntyties> ls = new List<PropertyEntyties>();
                            ls = ContentAnalytic.GetListProperties(dBMap.Product.Rows[i]["ProductContent"].ToString().Trim(),
                                dBMap.Product.Rows[i]["DetailUrl"].ToString().Trim());
                            ContentAnalytic.UpdateContent(ID, ls);
                        }
                        catch (Exception)
                        {
                            //  tên sản phẩm trong chuyên mục này đã có 
                        }

                        // update lại sản phẩm vừa chuyển đã chuyển
                        adtProduct.UpdateQuery_ProductID(ID, dr.ID);


                    }
                    catch (Exception)
                    {

                    }
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.lamssconvert.Text = string.Format("{0}/{1} - {2}", i, dBMap.Product.Count, dr.Name);
                    });
                    Application.DoEvents();
                    adtProduct.Connection.Close();
                    //String[] images = dBMap.Product.Rows[i++]["Promotion"].ToString().Split('\n');
                    //if ((images.Length > 0) && (images[0].Trim().Length > 0))
                    //{

                    //try
                    //{
                    //    adtID.Insert(
                    //    ID,
                    //    images[0].ToString(),
                    //    IDCategory,
                    //    0, 0, 0,
                    //    dr.ProductContent,
                    //    dr.DetailUrl,
                    //    dr.Name,
                    //    dr.NameFT,
                    //    Common.Obj2Int(Common.ProductIDStatus.NotValid));
                    //}
                    //catch (Exception)
                    //{

                    //}

                    //}

                }
                //}
                i++;
            }
        }

      
        private void btLoadAll_Click(object sender, EventArgs e)
        {
            LoadDataAll();
        }

        private void bt_Analytic_Click(object sender, EventArgs e)
        {
            List<PropertyEntyties> ls = new List<PropertyEntyties>();
            ls = ContentAnalytic.GetListProperties(this.productContentTextBox.Text.Trim(),
                                                        this.detailUrlTextBox.Text.Trim());
            string s = "";
            foreach (PropertyEntyties item in ls)
            {
                s += string.Format("{0}\t{1}\t{2}\n", item.STT, item.Name, item.Value);
            }
            this.webContent.DocumentText = s;
        }


    }
}
