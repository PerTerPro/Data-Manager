using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GABIZ.Base;
using System.Data;

namespace QT.Entities
{
    public static class ContentAnalytic
    {
        private static List<int> lisIDGroup;
        private static List<int> lisIDProperties;
        private static List<int> lisIDValue;
        public static void InitProperties()
        {
            // nạp dữ liệu từ db vào
        }
        public static void UpdateContent(long IDProduct, List<PropertyEntyties> lsEn)
        {
            DBTableAdapters.PropertiesGroupTableAdapter adtGroup = new DBTableAdapters.PropertiesGroupTableAdapter();
            adtGroup.Connection.ConnectionString = Server.ConnectionString;
            if (adtGroup.Connection.State == ConnectionState.Closed) adtGroup.Connection.Open();

            DBTableAdapters.PropertiesTableAdapter adtProperties = new DBTableAdapters.PropertiesTableAdapter();
            adtProperties.Connection.ConnectionString = Server.ConnectionString;
            if (adtProperties.Connection.State == ConnectionState.Closed) adtProperties.Connection.Open();

            DBTableAdapters.PropertiesValueTableAdapter adtValue = new DBTableAdapters.PropertiesValueTableAdapter();
            adtValue.Connection.ConnectionString = Server.ConnectionString;
            if (adtValue.Connection.State == ConnectionState.Closed) adtValue.Connection.Open();

            // kiểm tra group có chưa nếu chưa có thì insert vào
            if (lisIDGroup == null)
            {
                lisIDGroup = new List<int>();
                DB.PropertiesGroupDataTable dt = new DB.PropertiesGroupDataTable();
                adtGroup.Fill(dt);
                foreach (DB.PropertiesGroupRow dr in dt)
                {
                    int i0 = 0;
                    i0 = lisIDGroup.BinarySearch(dr.ID);
                    if (i0 < 0)
                        lisIDGroup.Insert(~i0, dr.ID);
                }
            }
            // kiểm tra properties of group có chưa nếu chưa có thì insert vào
            if (lisIDProperties == null)
            {
                lisIDProperties = new List<int>();
                DB.PropertiesDataTable dt1 = new DB.PropertiesDataTable();
                adtProperties.Fill(dt1);
                foreach (DB.PropertiesRow dr in dt1)
                {
                    int i1 = 0;
                    i1 = lisIDProperties.BinarySearch(dr.ID);
                    if (i1 < 0)
                        lisIDProperties.Insert(~i1, dr.ID);
                }
            }

            if (lisIDValue == null)
            {
                lisIDValue = new List<int>();
                DB.PropertiesValueDataTable dtValue = new DB.PropertiesValueDataTable();
                adtValue.Fill(dtValue);
                foreach (DB.PropertiesValueRow dr in dtValue)
                {
                    int i1 = 0;
                    i1 = lisIDValue.BinarySearch(dr.ID);
                    if (i1 < 0)
                        lisIDValue.Insert(~i1, dr.ID);
                }
            }
            // kiểm tra value of properties có chưa nếu chưa có thì insert vào
            for (int i = 0; i < lsEn.Count; i++)
            {
                /// check group
                /// check value
                /// check properties
                int index = 0;
                index = lisIDGroup.BinarySearch(lsEn[i].IDType);
                if (index < 0)
                {
                    lisIDGroup.Insert(~index, lsEn[i].IDType);
                    adtGroup.Insert(lsEn[i].IDType, lsEn[i].NameType);
                }
                index = lisIDProperties.BinarySearch(lsEn[i].ID);
                if (index < 0)
                {
                    lisIDProperties.Insert(~index, lsEn[i].ID);
                    adtProperties.Insert(lsEn[i].ID, lsEn[i].Name, lsEn[i].IDType);
                }
                index = lisIDValue.BinarySearch(lsEn[i].IDValue);
                if (index < 0)
                {
                    lisIDValue.Insert(~index, lsEn[i].IDValue);
                    adtValue.Insert(lsEn[i].IDValue, lsEn[i].Value, lsEn[i].ID);
                }
            }
            adtGroup.Connection.Close();
            adtGroup.Dispose();
            adtProperties.Connection.Close();
            adtProperties.Dispose();
            adtValue.Connection.Close();
            adtValue.Dispose();

            if (IDProduct > 0)
            {
                DBTableAdapters.Product_PropertiesTableAdapter adtPP = new DBTableAdapters.Product_PropertiesTableAdapter();
                adtPP.Connection.ConnectionString = Server.ConnectionString;
                if (adtPP.Connection.State == ConnectionState.Closed) adtPP.Connection.Open();
                adtPP.DeleteQuery_ProductID(IDProduct);
                for (int i = 0; i < lsEn.Count; i++)
                {
                    adtPP.Insert(IDProduct,
                        lsEn[i].ID,
                        lsEn[i].IDType,
                        lsEn[i].IDValue,
                        i);
                }
                adtPP.Dispose();
            }
        }
        public static List<PropertyEntyties> GetListProperties(string html, string url)
        {
            List<PropertyEntyties> r = new List<PropertyEntyties>();
            Uri root = new Uri(url);
            switch (root.DnsSafeHost)
            {
                case "vatgia.com":
                    r = GetListPropertiesVatGia(html);
                    break;
                case "trananh.vn":
                    r = GetListPropertiesTranAnh(html);
                    break;
                case "phucanh.vn":
                    r = GetListPropertiesPhucAnh(html);
                    break;
                case "pico.vn":
                case "lazada.vn":
                    r = GetListPropertiesTr(html);
                    break;
                case "fyi.vn":
                    r = GetListPropertiesFyi(html);
                    break;
            }
            return r;
        }
        private static List<PropertyEntyties> GetListPropertiesFyi(string html)
        {
            List<PropertyEntyties> rlist = new List<PropertyEntyties>();
            try
            {
                GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                var nodes = doc.DocumentNode.SelectNodes("//tr");
                var nodesTD = doc.DocumentNode.SelectNodes("//tr[1]");
                if (nodes != null)
                {
                    string tenNhom = "", tenthuoctinh = "", giatri = "";
                    tenNhom = "Thông số chung";
                    PropertyEntyties item = new PropertyEntyties();
                    int stt = 1;
                    bool check3cot = false;
                    for (int i = 0; i < nodes.Count; i++)
                    {
                        //if (nodes[i].ChildNodes[1].InnerText.Trim().Length > 0)
                        //{
                        //    check3cot = true;   
                        //}
                        //if (check3cot)
                        //{
                        
                        //}
                        //else
                        //{
                        tenthuoctinh = nodes[i].ChildNodes[1].InnerText.Trim();
                        giatri = nodes[i].ChildNodes[3].InnerText.Trim();
                        //}
                        //tenNhom = nodes[i].ChildNodes[1].InnerText.Trim();
                        //tenthuoctinh = nodes[i].ChildNodes[3].InnerText.Trim();
                        //giatri = nodes[i].ChildNodes[5].InnerText.Trim();
                            item = new PropertyEntyties();
                            item.ID = Common.GetID_Properties(tenthuoctinh + tenNhom);
                            item.IDType = Common.GetID_Properties(tenNhom);
                            item.IDValue = Common.GetID_Properties(giatri);
                            item.Name = tenthuoctinh;
                            item.NameType = tenNhom;
                            item.Value = giatri;
                            item.STT = stt;
                            stt++;
                            rlist.Add(item);
                    }
                }
            }
            catch (Exception)
            {
            }
            return rlist;
        }

        private static List<PropertyEntyties> GetListPropertiesPhucAnh(string html)
        {
            List<PropertyEntyties> rlist = new List<PropertyEntyties>();
            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var nodes = doc.DocumentNode.SelectNodes("//tr");
            if (nodes != null)
            {
                string tenNhom = "", tenthuoctinh = "", giatri = "";
                PropertyEntyties item = new PropertyEntyties();
                int stt = 1;
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (nodes[i].Attributes.Count == 0)
                    {
                        // tên nhóm
                        tenNhom = "Thông số chung";
                        tenthuoctinh = nodes[i].ChildNodes[1].InnerText.Trim();
                        giatri = nodes[i].ChildNodes[3].InnerText.Trim();
                        item = new PropertyEntyties();
                        item.ID = Common.GetID_Properties(tenthuoctinh + tenNhom);
                        item.IDType = Common.GetID_Properties(tenNhom);
                        item.IDValue = Common.GetID_Properties(giatri);
                        item.Name = tenthuoctinh;
                        item.NameType = tenNhom;
                        item.Value = giatri;
                        item.STT = stt;
                        stt++;
                        rlist.Add(item);
                    }
                    else
                    {

                    }

                }
            }
            return rlist;
        }
        private static List<PropertyEntyties> GetListPropertiesTr(string html)
        {
            List<PropertyEntyties> rlist = new List<PropertyEntyties>();
            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var nodes = doc.DocumentNode.SelectNodes("//tr");
            if (nodes != null)
            {
                string tenNhom = "", tenthuoctinh = "", giatri = "";
                PropertyEntyties item = new PropertyEntyties();
                int stt = 1;
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (nodes[i].Attributes.Count == 0)
                    {
                        // tên nhóm
                        tenNhom = "Thông số chung";
                        tenthuoctinh = nodes[i].ChildNodes[1].InnerText.Trim();
                        giatri = nodes[i].ChildNodes[3].InnerText.Trim();
                        item = new PropertyEntyties();
                        item.ID = Common.GetID_Properties(tenthuoctinh + tenNhom);
                        item.IDType = Common.GetID_Properties(tenNhom);
                        item.IDValue = Common.GetID_Properties(giatri);
                        item.Name = tenthuoctinh;
                        item.NameType = tenNhom;
                        item.Value = giatri;
                        item.STT = stt;
                        stt++;
                        rlist.Add(item);
                    }
                    else
                    {

                    }

                }
            }
            return rlist;
        }

        private static List<PropertyEntyties> GetListPropertiesTranAnh(string html)
        {
            List<PropertyEntyties> rlist = new List<PropertyEntyties>();
            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var nodes = doc.DocumentNode.SelectNodes("//tr");
            if (nodes != null)
            {
                string tenNhom = "", tenthuoctinh = "", giatri = "";
                PropertyEntyties item = new PropertyEntyties();
                int stt = 1;
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (nodes[i].Attributes.Count == 0)
                    {
                        // tên nhóm
                        tenNhom = "Thông số chung";
                        tenthuoctinh = nodes[i].ChildNodes[1].InnerText.Trim();
                        giatri = nodes[i].ChildNodes[3].InnerText.Trim();
                        item = new PropertyEntyties();
                        item.ID = Common.GetID_Properties(tenthuoctinh + tenNhom);
                        item.IDType = Common.GetID_Properties(tenNhom);
                        item.IDValue = Common.GetID_Properties(giatri);
                        item.Name = tenthuoctinh;
                        item.NameType = tenNhom;
                        item.Value = giatri;
                        item.STT = stt;
                        stt++;
                        rlist.Add(item);
                    }
                    else
                    {
                       
                    }

                }
            }
            return rlist;
        }
        private static List<PropertyEntyties> GetListPropertiesVatGia(string html)
        {
            List<PropertyEntyties> rlist = new List<PropertyEntyties>();
            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var nodes = doc.DocumentNode.SelectNodes("//tr");
            if (nodes != null)
            {
                string tenNhom = "", tenthuoctinh = "", giatri = "";
                PropertyEntyties item = new PropertyEntyties();
                int stt = 1;
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (nodes[i].Attributes.Count == 0)
                    {
                        // tên nhóm
                        tenNhom = nodes[i].ChildNodes[1].InnerText.Trim();
                    }
                    else
                    {
                        tenthuoctinh = nodes[i].ChildNodes[1].InnerText.Trim();
                        giatri = nodes[i].ChildNodes[3].InnerText.Trim();
                        item = new PropertyEntyties();
                        item.ID = Common.GetID_Properties(tenthuoctinh + tenNhom);
                        item.IDType = Common.GetID_Properties(tenNhom);
                        item.IDValue = Common.GetID_Properties(giatri);
                        item.Name = tenthuoctinh;
                        item.NameType = tenNhom;
                        item.Value = giatri;
                        item.STT = stt;
                        stt++;
                        rlist.Add(item);
                    }

                }
            }
            return rlist;
        }


        public static string BuildContentProduct(DataTable dt)
        {
            ///NameGroup  NameProperties Value STT ProductID NameShowGroup  NameShowProperties
            String r = "";
            String group = "";
            // chuan hóa lại dữ liệu
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["NameShowGroup"].ToString().Trim().Length > 1)
                {
                    dt.Rows[i]["NameGroup"] = dt.Rows[i]["NameShowGroup"];
                }
                if (dt.Rows[i]["NameShowProperties"].ToString().Trim().Length > 1)
                {
                    dt.Rows[i]["NameProperties"] = dt.Rows[i]["NameShowProperties"];
                }
            }
            dt.AcceptChanges();

            if (dt.Rows.Count > 0)
            {
                r += "\n" + "<div style='width:100%; overflow:hidden;'>";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string gt = dt.Rows[i]["NameGroup"].ToString().Trim();
                    if (gt != group)
                    {
                        group = gt;
                        r += "\n" + string.Format("    <div style='width:100%;overflow:hidden;padding:7px; font-size:14px;font-weight:bold;font-family:Arial;border-bottom:1px solid #E1E6E6; border-bottom-color: #E1E6E6;'>{0}</div>", group);
                    }
                    String value = dt.Rows[i]["Value"].ToString().Trim().Replace("\n", "</br>");
                    if ((value.Length < 50) && (i < 5))
                    {
                        value = string.Format("<a href='http://websosanh.vn/s/{0}.htm' title='{1}'>{1}</a>", value.Replace(' ', '+'), value);
                    }
                    if (value.ToLower().Trim() == "chi tiết")
                    {
                        value = "";
                    }
                    r += "\n" + "    <div style='width:100%;overflow:hidden;'>";
                    r += "\n" + string.Format("        <div style='float: left; max-width: 200px; padding: 7px; width: 30%;'>{0}</div>", dt.Rows[i]["NameProperties"].ToString().Trim());
                    r += "\n" + string.Format("        <div style='float:left;padding:7px;'>{0}</div>", value);
                    r += "\n" + "    </div>";
                }

                r += "\n" + " </div>";
            }
            return r;
        }
        public static string BuildContentProductMobile(DataTable dt)
        {
            ///NameGroup  NameProperties Value STT ProductID NameShowGroup  NameShowProperties
            String r = "";
            String group = "";
            // chuan hóa lại dữ liệu
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["NameShowGroup"].ToString().Trim().Length > 1)
                {
                    dt.Rows[i]["NameGroup"] = dt.Rows[i]["NameShowGroup"];
                }
                if (dt.Rows[i]["NameShowProperties"].ToString().Trim().Length > 1)
                {
                    dt.Rows[i]["NameProperties"] = dt.Rows[i]["NameShowProperties"];
                }
            }
            dt.AcceptChanges();

            if (dt.Rows.Count > 0)
            {
                r += "\n" + "<div class='block_table block_item_state'>";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string gt = dt.Rows[i]["NameGroup"].ToString().Trim();
                    if (gt != group)
                    {
                        group = gt;
                        r += "\n" + string.Format("    <div class='table_row table_row_header'> <div class='table_col table_col_6'>{0}</div></div>", group);
                    }
                    String value = dt.Rows[i]["Value"].ToString().Trim().Replace("\n", "</br>");
                    if ((value.Length < 50) && (i < 5))
                    {
                        value = string.Format("<a href='http://websosanh.vn/s/{0}.htm' title='{1}'>{1}</a>", value.Replace(' ', '+'), value);
                    }
                    if (value.ToLower().Trim() == "chi tiết")
                    {
                        value = "";
                    }
                    //<div class="table_row item_info">
                    //    <div class="table_col table_col_2">Hãng sản xuất</div>
                    //    <div class="table_col table_col_4">ASUS</div>
                    //</div>
				

                    r += "\n" + "    <div class='table_row item_info'>";
                    r += "\n" + string.Format("        <div class='table_col table_col_2'>{0}</div>", dt.Rows[i]["NameProperties"].ToString().Trim());
                    r += "\n" + string.Format("        <div class='table_col table_col_4'>{0}</div>", value);
                    r += "\n" + "    </div>";
                }

                r += "\n" + " </div>";
            }
            return r;
        }

    }
    public class PropertyEntyties
    {
        public int ID { get; set; }
        public int IDType { get; set; }
        public int IDValue { get; set; }
        public String Name { get; set; }
        public String NameType { get; set; }
        public String Value { get; set; }
        public int STT { get; set; }
    }




    public class Product_KeyComparison
    {
        public Product_KeyComparisonEntyties SelectOne(int ID)
        {
            Product_KeyComparisonEntyties obj = new Product_KeyComparisonEntyties();
            DB.Product_KeyComparisonDataTable dt = new DB.Product_KeyComparisonDataTable();
            DBTableAdapters.Product_KeyComparisonTableAdapter adt = new DBTableAdapters.Product_KeyComparisonTableAdapter();
            adt.Connection.ConnectionString = Server.ConnectionString;
            adt.FillBy_SelectOne(dt, ID);
            if (dt.Rows.Count > 0)
            {
                obj = obj.MapObject((DataRow)dt.Rows[0]);
            }
            adt.Dispose();
            dt.Dispose();
            return obj;
        }
        public Product_KeyComparisonEntyties SelectByProductID(long IDProduct)
        {
            Product_KeyComparisonEntyties obj = new Product_KeyComparisonEntyties();
            DB.Product_KeyComparisonDataTable dt = new DB.Product_KeyComparisonDataTable();
            DBTableAdapters.Product_KeyComparisonTableAdapter adt = new DBTableAdapters.Product_KeyComparisonTableAdapter();
            adt.Connection.ConnectionString = Server.ConnectionString;
            adt.FillBy_IDProduct(dt, IDProduct);
            if (dt.Rows.Count > 0)
            {
                obj = obj.MapObject((DataRow)dt.Rows[0]);
            }
            adt.Dispose();
            dt.Dispose();
            return obj;
        }
        public Product_KeyComparisonEntyties UpdatePriceAndTongSP_ProductAndKeyComparision(long IDProduct)
        {
            Product_KeyComparisonEntyties obj = new Product_KeyComparisonEntyties();
            obj = this.SelectByProductID(IDProduct);
            if (obj.Code != null)
            {
                if (obj.Code.Trim().Length <= 0)
                { return obj; }
                obj.InitKeyword();
                DBTableAdapters.ProductTableAdapter adt = new DBTableAdapters.ProductTableAdapter();
                adt.Connection.ConnectionString = Server.ConnectionString;
                DB.ProductAnalyticDataTable dtAN = new DB.ProductAnalyticDataTable();
                DBTableAdapters.ProductAnalyticTableAdapter adtAN = new DBTableAdapters.ProductAnalyticTableAdapter();
                adtAN.Connection.ConnectionString = Server.ConnectionString;
                DBTableAdapters.Price_LogsTableAdapter adtPriceLog = new DBTableAdapters.Price_LogsTableAdapter();
                adtPriceLog.Connection.ConnectionString = Server.ConnectionString;
                int priceMin = 0, priceMax = 0, tong = 0;
                try
                {
                    adtAN.CMS_Product_SearchAnaytic_v2(dtAN,
                    obj.PriceMin,
                    obj.PriceMax,
                    obj.codeContains,
                    obj.codeLike,
                    obj.codeLike1,
                    obj.codeLike2,
                    obj.codeLike3,
                    obj.notCode,
                    obj.notCodeLike,
                    obj.notCodeLike1,
                    obj.notCodeLike2,
                    obj.notCodeLike3,
                    0);
                    /// hiện thời đang không dùng đên idproduct sản phẩm gốc để check
                    /// 
                    if (dtAN.Rows.Count > 0)
                    {
                        tong = dtAN.Rows.Count;
                        priceMin = Common.Obj2Int(dtAN.Rows[0]["Price"].ToString());
                        priceMax = Common.Obj2Int(dtAN.Rows[tong - 1]["Price"].ToString());
                        if (dtAN.Rows.Count > 1)
                        {
                            obj.GiaChenh = Common.Obj2Int(dtAN.Rows[1]["Price"].ToString()) - priceMin;
                        }
                        else
                        {
                            obj.GiaChenh = 0;
                        }
                        /// Map lại toàn bộ product ID
                        /// 
                        int proid = Common.Obj2Int(IDProduct);
                        foreach (DB.ProductAnalyticRow dr in dtAN)
                        {
                            adt.UpdateQuery_ProductID(proid, dr.ID);
                        }

                    }
                    // return xem log
                    obj.TongSanPham = tong;
                    obj.PriceMin = priceMin;
                    obj.PriceMax = priceMax;
                }
                catch (Exception)
                {
                }
                try
                {
                    adt.UpdateQuery_GiaSPGoc(priceMin, DateTime.Now, String.Format("Tìm thấy {0} sản phẩm", tong), IDProduct);
                    if (priceMin > 0)
                    {
                        adtPriceLog.Insert(IDProduct, DateTime.Now, priceMin, 0);
                    }
                }
                catch (Exception)
                {

                }
                try
                {
                    DBTableAdapters.Product_KeyComparisonTableAdapter adtKey = new DBTableAdapters.Product_KeyComparisonTableAdapter();
                    adtKey.Connection.ConnectionString = Server.ConnectionString;
                    adtKey.UpdateQuery_GiaSauPhanTich(tong, priceMin, priceMax, DateTime.Now, obj.GiaChenh, IDProduct);
                }
                catch (Exception)
                {

                }
                dtAN.Dispose();
                adt.Dispose();
                adtAN.Dispose();
                adtPriceLog.Dispose();
            }

            return obj;
        }

        public void GetRootProductMinPriceAndNumProducts(long productID, out int minprice, out int numProducts)
        {
            Product_KeyComparisonEntyties obj = this.SelectByProductID(productID);
            minprice = 0;
            numProducts = 0;
            if (obj.Code != null)
            {
                if (obj.Code.Trim().Length <= 0)
                    return;
                obj.InitKeyword();
                var adt = new DBTableAdapters.ProductTableAdapter
                {
                    Connection = { ConnectionString = Server.ConnectionString }
                };
                var productAnalyticDataTable = new DB.ProductAnalyticDataTable();
                var productAnalyticTableAdapter = new DBTableAdapters.ProductAnalyticTableAdapter();
                productAnalyticTableAdapter.Connection.ConnectionString = Server.ConnectionString;
                productAnalyticTableAdapter.CMS_Product_SearchAnaytic_v2(productAnalyticDataTable,
                    obj.PriceMin,
                    obj.PriceMax,
                    obj.codeContains,
                    obj.codeLike,
                    obj.codeLike1,
                    obj.codeLike2,
                    obj.codeLike3,
                    obj.notCode,
                    obj.notCodeLike,
                    obj.notCodeLike1,
                    obj.notCodeLike2,
                    obj.notCodeLike3,
                    0);
                /// hiện thời đang không dùng đên idproduct sản phẩm gốc để check
                /// 
                if (productAnalyticDataTable.Rows.Count > 0)
                {
                    numProducts = productAnalyticDataTable.Rows.Count;
                    minprice = Common.Obj2Int(productAnalyticDataTable.Rows[0]["Price"].ToString());
                }
                productAnalyticDataTable.Dispose();
                adt.Dispose();
                productAnalyticTableAdapter.Dispose();

            }
        }

        public int UpdateProductIDTinLienQuan(int IDProduct)
        {
            int r = 0;
            Product_KeyComparisonEntyties obj = new Product_KeyComparisonEntyties();
            obj = this.SelectByProductID(IDProduct);
            if (obj.Code != null)
            {
                if (obj.Code.Trim().Length <= 0)
                { return 0; }
                obj.InitKeyword();

                DB.NewsDataTable dtNews = new DB.NewsDataTable();
                DBTableAdapters.NewsTableAdapter adtNews = new DBTableAdapters.NewsTableAdapter();
                adtNews.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
                try
                {
                    adtNews.FillBy_SearchAnalytic(dtNews, obj.codeContains, 
                        obj.codeLike,
                        obj.codeLike1,
                        obj.codeLike2,
                        obj.codeLike3
                        );
                    
                }
                catch (Exception)
                {
                }
                if (dtNews.Rows.Count > 0)
                {
                    for (int i = 0; i < dtNews.Rows.Count; i++)
                    {
                        int newsID = Common.Obj2Int(dtNews.Rows[i]["NewsID"]);
                        try
                        {
                            adtNews.UpdateQuery_ProductID(IDProduct, newsID);
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                r = dtNews.Rows.Count;
                dtNews.Dispose();
                adtNews.Dispose();



                //try
                //{
                //    DBTableAdapters.Product_KeyComparisonTableAdapter adtKey = new DBTableAdapters.Product_KeyComparisonTableAdapter();
                //    adtKey.Connection.ConnectionString = Server.ConnectionString;
                //    adtKey.UpdateQuery_GiaSauPhanTich(tong, priceMin, priceMax, DateTime.Now, obj.GiaChenh, IDProduct);
                //}
                //catch (Exception)
                //{

                //    throw;
                //}
              
            }

            return r;
        }


    }
    public class Product_KeyComparisonEntyties
    {
        public int ID { get; set; }
        public Int64 IDProduct { get; set; }
        public string Code { get; set; }
        public int PriceMin { get; set; }
        public int PriceMax { get; set; }
        public string LikeKeyword { get; set; }
        public string NotLikeKeyword { get; set; }// khong dung den
        public string NotLikeKeywordOneChar { get; set; }
        public int TongSanPham { get; set; }
        public int GiaNhoNhat { get; set; }
        public int GiaLonNhat { get; set; }
        public int GiaChenh { get; set; }
        public DateTime LastUpdate { get; set; }

        public string codeContains { get; set; }
        public string codeLike { get; set; }
        public string codeLike1 { get; set; }
        public string codeLike2 { get; set; }
        public string codeLike3 { get; set; }
        public string notCode { get; set; }
        public string notCodeLike { get; set; }
        public string notCodeLike1 { get; set; }
        public string notCodeLike2 { get; set; }
        public string notCodeLike3 { get; set; }

        public void InitKeyword()
        {
            string makhongtontai = "123456qwertasdfgcvzn";
            if (NotLikeKeyword.Trim().Length <= 1)
            {
                notCode = "123456qwertasdfgcvzn";
            }
            else
            {
                notCode = NotLikeKeyword.Trim();
            }
            string[] ls = Code.Replace("  ", " ").Split(' ');
            if (ls.Length == 1)
            {
                codeContains = String.Format(@"""{0}*""", ls[0]);
            }
            else
            {
                codeContains = string.Format(@"NEAR((""{0}*""),5,FALSE)", Code.Trim().Replace("  ", " ").Replace(" ", @"*"","""));
            }

            string exl = "", exl1 = "", exl2 = "", exl3 = "";
            string[] ls1 = LikeKeyword.Trim().Split(',');
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
            codeLike = exl;
            codeLike1 = exl1;
            codeLike2 = exl2;
            codeLike3 = exl3;

            string exnl = "", exnl1 = "", exnl2 = "", exnl3 = "";
            string[] lsn1 = NotLikeKeywordOneChar.Split(',');
            switch (lsn1.Length)
            {
                case 1:
                    if (lsn1[0].Length == 0)
                    {
                        exnl = makhongtontai;
                    }
                    else
                    {
                        exnl = "%" + lsn1[0] + "%";
                    }
                    exnl1 = makhongtontai;
                    exnl2 = makhongtontai;
                    exnl3 = makhongtontai;
                    break;
                case 2:
                    exnl = "%" + lsn1[0] + "%";
                    exnl1 = "%" + lsn1[1] + "%";
                    exnl2 = makhongtontai;
                    exnl3 = makhongtontai;
                    break;
                case 3:
                    exnl = "%" + lsn1[0] + "%";
                    exnl1 = "%" + lsn1[1] + "%";
                    exnl2 = "%" + lsn1[2] + "%";
                    exnl3 = makhongtontai;
                    break;
                case 4:
                    exnl = "%" + lsn1[0] + "%";
                    exnl1 = "%" + lsn1[1] + "%";
                    exnl2 = "%" + lsn1[2] + "%";
                    exnl3 = "%" + lsn1[3] + "%";
                    break;
            }
            notCodeLike = exnl;
            notCodeLike1 = exnl1;
            notCodeLike2 = exnl2;
            notCodeLike3 = exnl3;
        }

        public Product_KeyComparisonEntyties() { }
        public Product_KeyComparisonEntyties(int id, Int64 idproduct, string code, int pricemin, int pricemax, string likekeyword, string notlikekeyword, string notlikekeywordonechar, int tongsanpham, int gianhonhat, int gialonnhat, DateTime lastupdate)
        {
            this.ID = id;
            this.IDProduct = idproduct;
            this.Code = code;
            this.PriceMin = pricemin;
            this.PriceMax = pricemax;
            this.LikeKeyword = likekeyword;
            this.NotLikeKeyword = notlikekeyword;
            this.NotLikeKeywordOneChar = notlikekeywordonechar;
            this.TongSanPham = tongsanpham;
            this.GiaNhoNhat = gianhonhat;
            this.GiaLonNhat = gialonnhat;
            this.LastUpdate = lastupdate;
        }
        public Product_KeyComparisonEntyties MapObject(DataRow row)
        {
            return new Product_KeyComparisonEntyties()
            {
                ID = row["ID"] != DBNull.Value ? Convert.ToInt32(row["ID"]) : 0,
                IDProduct = row["IDProduct"] != DBNull.Value ? Convert.ToInt64(row["IDProduct"]) : 0,
                Code = row["Code"] != DBNull.Value ? row["Code"].ToString() : string.Empty,
                PriceMin = row["PriceMin"] != DBNull.Value ? Convert.ToInt32(row["PriceMin"]) : 0,
                PriceMax = row["PriceMax"] != DBNull.Value ? Convert.ToInt32(row["PriceMax"]) : 0,
                LikeKeyword = row["LikeKeyword"] != DBNull.Value ? row["LikeKeyword"].ToString() : string.Empty,
                NotLikeKeyword = row["NotLikeKeyword"] != DBNull.Value ? row["NotLikeKeyword"].ToString() : string.Empty,
                NotLikeKeywordOneChar = row["NotLikeKeywordOneChar"] != DBNull.Value ? row["NotLikeKeywordOneChar"].ToString() : string.Empty,
                TongSanPham = row["TongSanPham"] != DBNull.Value ? Convert.ToInt32(row["TongSanPham"]) : 0,
                GiaNhoNhat = row["GiaNhoNhat"] != DBNull.Value ? Convert.ToInt32(row["GiaNhoNhat"]) : 0,
                GiaLonNhat = row["GiaLonNhat"] != DBNull.Value ? Convert.ToInt32(row["GiaLonNhat"]) : 0,
                LastUpdate = row["LastUpdate"] != DBNull.Value ? Convert.ToDateTime(row["LastUpdate"]) : DateTime.Now
            };
        }
    }



}
