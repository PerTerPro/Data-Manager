using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Websosanh.SearchEngines;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using UpdateSolrTools.DBTableAdapters;
using GABIZ.Base;

namespace UpdateSolrTools
{
    public class IndexTools
    {
        public static long ID_Websosanh = 6619858476258121218;
        public static bool DoInsertProductFilterProperties(string connProductString)
        {
            //Get Product Id
            DBTool2.Product_SolrDataTable dtProductId = new DBTool2.Product_SolrDataTable();
            DBTool2TableAdapters.Product_SolrTableAdapter adtProduct = new DBTool2TableAdapters.Product_SolrTableAdapter();
            DBTableAdapters.ProductFilterPropertiesTableAdapter adtTemProduct = new ProductFilterPropertiesTableAdapter();
            adtProduct.Connection.ConnectionString = connProductString;
            adtTemProduct.Connection.ConnectionString = connProductString;
            try
            {
                adtProduct.FillBy_ProductSanPhamGocId(dtProductId, DateTime.Now.AddDays(-100));
            }
            catch (Exception ex)
            {
                return false;
            }

            //Truncate Table ProductFilterProperties;
            var conn = new SqlConnection(connProductString);
            try
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM ProductFilterProperties", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            int count = 0;
            for (int i = 0; i < dtProductId.Rows.Count; i++)
            {

                var tmpProductId = QT.Entities.Common.Obj2Int64(dtProductId.Rows[i]["ID"]);

                DB.ViewValueDataTable dtProductProperties = new DB.ViewValueDataTable();
                var adtProductProperties = new DBTableAdapters.ViewValueTableAdapter();
                adtProductProperties.Connection.ConnectionString = connProductString;
                try
                {
                    adtProductProperties.FillBy_ThamSo(dtProductProperties, tmpProductId);
                    var propertiesString = "";
                    ProductProperties obj = new ProductProperties();
                    for (int propertyIndex = 0; propertyIndex < dtProductProperties.Rows.Count; propertyIndex++)
                    {
                        var propertyId = QT.Entities.Common.Obj2String(dtProductProperties.Rows[propertyIndex]["PropertyID"]);
                        var propertiesValueID =
                            QT.Entities.Common.Obj2String(dtProductProperties.Rows[propertyIndex]["PropertiesValueID"]);
                        var propertyValue = QT.Entities.Common.Obj2String(dtProductProperties.Rows[propertyIndex]["NameValue"]);
                        // => propertyValueID:PropertyValue
                        propertyValue = propertiesValueID + ":" + propertyValue;
                        var unit = QT.Entities.Common.Obj2String(dtProductProperties.Rows[propertyIndex]["Unit"]);
                        propertyValue = string.IsNullOrEmpty(unit) ? propertyValue : "number:" + propertyValue;
                        switch (propertyIndex + 1)
                        {
                            case 1:
                                obj.exname1 = propertyId;
                                obj.exValue1 = propertyValue;
                                break;
                            case 2:
                                obj.exname2 = propertyId;
                                obj.exValue2 = propertyValue;
                                break;
                            case 3:
                                obj.exname3 = propertyId;
                                obj.exValue3 = propertyValue;
                                break;
                            case 4:
                                obj.exname4 = propertyId;
                                obj.exValue4 = propertyValue;
                                break;
                            case 5:
                                obj.exname5 = propertyId;
                                obj.exValue5 = propertyValue;
                                break;
                            case 6:
                                obj.exname6 = propertyId;
                                obj.exValue6 = propertyValue;
                                break;
                            case 7:
                                obj.exname7 = propertyId;
                                obj.exValue7 = propertyValue;
                                break;
                            case 8:
                                obj.exname8 = propertyId;
                                obj.exValue8 = propertyValue;
                                break;
                            case 9:
                                obj.exname9 = propertyId;
                                obj.exValue9 = propertyValue;
                                break;
                            case 10:
                                obj.exname10 = propertyId;
                                obj.exValue10 = propertyValue;
                                break;
                        }

                    }
                    adtTemProduct.InsertQuery(tmpProductId,GroupId, obj.exname1, obj.exname2, obj.exname3, obj.exname4,
                        obj.exname5, obj.exname6, obj.exname7, obj.exname8, obj.exname9, obj.exname10,
                        obj.exValue1, obj.exValue2, obj.exValue3, obj.exValue4, obj.exValue5, obj.exValue6, obj.exValue7, obj.exValue8, obj.exValue9, obj.exValue10,
                        DateTime.UtcNow);

                }
                catch (Exception ex)
                {
                    return false;
                }
                count++;
            }
            return true;
        }

        public static bool DoInsertProductFilterProperties(int categoryId, string connProductString)
        {
            //Get Product Id
            DBTool2.Product_SolrDataTable dtProductId = new DBTool2.Product_SolrDataTable();
            DBTool2TableAdapters.Product_SolrTableAdapter adtProduct = new DBTool2TableAdapters.Product_SolrTableAdapter();
            DBTableAdapters.ProductFilterPropertiesTableAdapter adtTemProduct = new ProductFilterPropertiesTableAdapter();
            adtProduct.Connection.ConnectionString = connProductString;
            adtTemProduct.Connection.ConnectionString = connProductString;
            try
            {
                adtProduct.FillBy_ProductSanPhamGocIdByCategory(dtProductId, DateTime.Now.AddDays(-100), categoryId);
            }
            catch (Exception ex)
            {
                return false;
            }

            //Truncate Table ProductFilterProperties;
            var conn = new SqlConnection(connProductString);
            try
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM ProductFilterProperties", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                return false;
            }

            int count = 0;
            for (int i = 0; i < dtProductId.Rows.Count; i++)
            {

                var tmpProductId = QT.Entities.Common.Obj2Int64(dtProductId.Rows[i]["ID"]);

                DB.ViewValueDataTable dtProductProperties = new DB.ViewValueDataTable();
                var adtProductProperties = new DBTableAdapters.ViewValueTableAdapter();
                adtProductProperties.Connection.ConnectionString = connProductString;
                try
                {
                    adtProductProperties.FillBy_ThamSo(dtProductProperties, tmpProductId);
                    var propertiesString = "";
                    ProductProperties obj = new ProductProperties();
                    for (int propertyIndex = 0; propertyIndex < dtProductProperties.Rows.Count; propertyIndex++)
                    {
                        var propertyId = QT.Entities.Common.Obj2String(dtProductProperties.Rows[propertyIndex]["PropertyID"]);
                        var propertiesValueID =
                            QT.Entities.Common.Obj2String(dtProductProperties.Rows[propertyIndex]["PropertiesValueID"]);
                        var propertyValue = QT.Entities.Common.Obj2String(dtProductProperties.Rows[propertyIndex]["NameValue"]);
                        // => propertyValueID:PropertyValue
                        propertyValue = propertiesValueID + ":" + propertyValue;
                        var unit = QT.Entities.Common.Obj2String(dtProductProperties.Rows[propertyIndex]["Unit"]);
                        propertyValue = string.IsNullOrEmpty(unit) ? propertyValue : "number:" + propertyValue;
                        switch (propertyIndex + 1)
                        {
                            case 1:
                                obj.exname1 = propertyId;
                                obj.exValue1 = propertyValue;
                                break;
                            case 2:
                                obj.exname2 = propertyId;
                                obj.exValue2 = propertyValue;
                                break;
                            case 3:
                                obj.exname3 = propertyId;
                                obj.exValue3 = propertyValue;
                                break;
                            case 4:
                                obj.exname4 = propertyId;
                                obj.exValue4 = propertyValue;
                                break;
                            case 5:
                                obj.exname5 = propertyId;
                                obj.exValue5 = propertyValue;
                                break;
                            case 6:
                                obj.exname6 = propertyId;
                                obj.exValue6 = propertyValue;
                                break;
                            case 7:
                                obj.exname7 = propertyId;
                                obj.exValue7 = propertyValue;
                                break;
                            case 8:
                                obj.exname8 = propertyId;
                                obj.exValue8 = propertyValue;
                                break;
                            case 9:
                                obj.exname9 = propertyId;
                                obj.exValue9 = propertyValue;
                                break;
                            case 10:
                                obj.exname10 = propertyId;
                                obj.exValue10 = propertyValue;
                                break;
                        }

                    }
                    adtTemProduct.InsertQuery(tmpProductId, obj.exname1, obj.exname2, obj.exname3, obj.exname4,
                        obj.exname5, obj.exname6, obj.exname7, obj.exname8, obj.exname9, obj.exname10,
                        obj.exValue1, obj.exValue2, obj.exValue3, obj.exValue4, obj.exValue5, obj.exValue6, obj.exValue7, obj.exValue8, obj.exValue9, obj.exValue10,
                        DateTime.UtcNow);

                }
                catch (Exception ex)
                {

                    return false;
                }
                count++;

            }
            return true;
        }

        public static bool DoUpdateSolrIndex(string connProductString, string solrUrl)
        {

            DBTool.CompanyDataTable dtCom = new DBTool.CompanyDataTable();
            DBToolTableAdapters.CompanyTableAdapter adtCom = new DBToolTableAdapters.CompanyTableAdapter();
            adtCom.Connection.ConnectionString = connProductString;
            DBTool2.Product_SolrDataTable dtProduct = new DBTool2.Product_SolrDataTable();
            DBTool2TableAdapters.Product_SolrTableAdapter adtProduct = new DBTool2TableAdapters.Product_SolrTableAdapter();
            adtProduct.Connection.ConnectionString = connProductString;

            adtCom.FillBy_WebsiteCoSanPham(dtCom);
            SolrDriver.Init(solrUrl);
            int x = 0;
            foreach (DBTool.CompanyRow drCom in dtCom)
            {
                x++;
                try
                {
                    adtProduct.FillBy_Company(dtProduct, drCom.ID);
                }
                catch (Exception)
                {
                }
                SolrDriver.DeleteByCompanyId(drCom.ID);
                int count = 0;
                List<SolrProductItem> ls = new List<SolrProductItem>();

                for (int i = 0; i < dtProduct.Rows.Count; i++)
                {
                    DataRow dr = dtProduct.Rows[i];
                    try
                    {
                        SolrProductItem item = new SolrProductItem
                        {
                            Id = QT.Entities.Common.Obj2Int64(dr["ID"]),
                            Price = QT.Entities.Common.Obj2Int(dr["Price"]),
                            Warranty = QT.Entities.Common.Obj2Int(dr["Warranty"]),
                            Status = QT.Entities.Common.Obj2Int(dr["Status"]),
                            Company = QT.Entities.Common.Obj2Int64(dr["Company"]),
                            LastUpdate = QT.Entities.Common.ObjectToDataTime(dr["LastUpdate"]),
                            Summary = dr["Summary"].ToString(),
                            Description = "",
                            ProductId = QT.Entities.Common.Obj2Int(dr["ProductID"]),
                            ProductType = 2,
                            Name = dr["Name"].ToString(),
                            NameFT = dr["NameFT"].ToString(),
                            DetailUrl = dr["DetailUrl"].ToString(),
                            ImagePath = dr["ImagePath"].ToString(),
                            CategoryId = QT.Entities.Common.Obj2Int(dr["CategoryID"]),
                            ContentFT = dr["ContentFT"].ToString() + " " + Tools.removeHTML(dr["ProductContent"].ToString()),
                            ViewCount = QT.Entities.Common.Obj2Int(dr["ViewCount"]),
                            AddPosition = QT.Entities.Common.Obj2Int(dr["AddPosition"]),
                            StringFilterFields = new Dictionary<string, object>(),
                            DoubleFilterFields = new Dictionary<string, object>(),
                            DateTimeFilterFields = new Dictionary<string, object>(),
                            IntFilterFields = new Dictionary<string, object>()
                        };
                        for (int exIndex = 1; exIndex <= 10; exIndex++)
                        {
                            string filterPropertyName = QT.Entities.Common.Obj2String(dr["EX" + exIndex]);
                            string filterPropertyValue = QT.Entities.Common.Obj2String(dr["EXVALUE" + exIndex]);
                            if (!string.IsNullOrEmpty(filterPropertyName) && !string.IsNullOrEmpty(filterPropertyValue))
                            {
                                try
                                {
                                    if (filterPropertyValue.StartsWith("number:"))
                                    {
                                        double filterDoubleValue;
                                        string filterIDAndValue = filterPropertyValue.Substring(7);
                                        string filterValueID = filterIDAndValue.Substring(0,
                                            filterIDAndValue.IndexOf(":"));
                                        string filterValue = filterIDAndValue.Length > filterValueID.Length + 1
                                            ? filterIDAndValue.Substring(filterValueID.Length + 1)
                                            : "";
                                        item.IntFilterFields.Add(filterPropertyName + "_id", filterValueID);
                                        if (Double.TryParse(filterValue, out filterDoubleValue))
                                            item.DoubleFilterFields.Add(filterPropertyName, filterDoubleValue);
                                    }
                                    else
                                    {
                                        string filterValueID = filterPropertyValue.Substring(0,
                                            filterPropertyValue.IndexOf(":"));
                                        string filterValue = filterPropertyValue.Length > filterValueID.Length + 1
                                            ? filterPropertyValue.Substring(filterValueID.Length + 1)
                                            : "";
                                        item.IntFilterFields.Add(filterPropertyName + "_id", filterValueID);
                                        item.StringFilterFields.Add(filterPropertyName, filterValue);
                                    }
                                }
                                catch (Exception ex)
                                {

                                    throw ex;
                                }

                            }
                        }
                        ls.Add(item);
                        count++;
                    }
                    catch (Exception oex)
                    {
                    }

                    if (count == 1000)
                    {
                        try
                        {
                            SolrDriver.IndexProducts(ls);
                            SolrDriver.Commit();
                            count = 0;
                            ls = new List<SolrProductItem>();

                        }
                        catch (Exception)
                        {
                        }

                    }
                }
                try
                {
                    SolrDriver.IndexProducts(ls);
                    SolrDriver.Commit();
                }
                catch (Exception)
                {
                }
                adtCom.UpdateQuery_LastUpdateSolr(DateTime.Now, drCom.ID);
            }

            //var products = SolrDriver.SearchProducts(SolrDriver.SortCategory.SortByPriceIncrease, 1, 20, 100000, 10000000, "may tinh",
            //    "c100,x430");
            dtProduct.Dispose();
            dtCom.Dispose();
            adtProduct.Dispose();
            adtCom.Dispose();
            return true;
        }

        public static bool DoUpdateSolrIndex(int categoryID, string connProductString, string solrUrl)
        {
            DBTool.CompanyDataTable dtCom = new DBTool.CompanyDataTable();
            DBToolTableAdapters.CompanyTableAdapter adtCom = new DBToolTableAdapters.CompanyTableAdapter();
            adtCom.Connection.ConnectionString = connProductString;
            DBTool2.Product_SolrDataTable dtProduct = new DBTool2.Product_SolrDataTable();
            DBTool2TableAdapters.Product_SolrTableAdapter adtProduct = new DBTool2TableAdapters.Product_SolrTableAdapter();
            adtProduct.Connection.ConnectionString = connProductString;

            adtCom.FillBy_WebsiteCoSanPham(dtCom);
            SolrDriver.Init(solrUrl);
            int x = 0;
            foreach (DBTool.CompanyRow drCom in dtCom)
            {
                x++;
                try
                {
                    adtProduct.FillBy_CompanyAndCategory(dtProduct, drCom.ID, categoryID);
                }
                catch (Exception)
                {
                }
                SolrDriver.DeleteByCompanyId(drCom.ID);
                int count = 0;
                List<SolrProductItem> ls = new List<SolrProductItem>();

                for (int i = 0; i < dtProduct.Rows.Count; i++)
                {
                    DataRow dr = dtProduct.Rows[i];
                    try
                    {
                        SolrProductItem item = new SolrProductItem
                        {
                            Id = QT.Entities.Common.Obj2Int64(dr["ID"]),
                            Price = QT.Entities.Common.Obj2Int(dr["Price"]),
                            Warranty = QT.Entities.Common.Obj2Int(dr["Warranty"]),
                            Status = QT.Entities.Common.Obj2Int(dr["Status"]),
                            Company = QT.Entities.Common.Obj2Int64(dr["Company"]),
                            LastUpdate = QT.Entities.Common.ObjectToDataTime(dr["LastUpdate"]),
                            Summary = dr["Summary"].ToString(),
                            Description = "",
                            ProductId = QT.Entities.Common.Obj2Int(dr["ProductID"]),
                            ProductType = 2,
                            Name = dr["Name"].ToString(),
                            NameFT = dr["NameFT"].ToString(),
                            DetailUrl = dr["DetailUrl"].ToString(),
                            ImagePath = dr["ImagePath"].ToString(),
                            CategoryId = QT.Entities.Common.Obj2Int(dr["CategoryID"]),
                            ContentFT = dr["ContentFT"].ToString() + " " + Tools.removeHTML(dr["ProductContent"].ToString()),
                            ViewCount = QT.Entities.Common.Obj2Int(dr["ViewCount"]),
                            AddPosition = QT.Entities.Common.Obj2Int(dr["AddPosition"]),
                            StringFilterFields = new Dictionary<string, object>(),
                            DoubleFilterFields = new Dictionary<string, object>(),
                            DateTimeFilterFields = new Dictionary<string, object>(),
                            IntFilterFields = new Dictionary<string, object>()
                        };
                        for (int exIndex = 1; exIndex <= 10; exIndex++)
                        {
                            string filterPropertyName = QT.Entities.Common.Obj2String(dr["EX" + exIndex]);
                            string filterPropertyValue = QT.Entities.Common.Obj2String(dr["EXVALUE" + exIndex]);
                            if (!string.IsNullOrEmpty(filterPropertyName) && !string.IsNullOrEmpty(filterPropertyValue))
                            {
                                try
                                {
                                    if (filterPropertyValue.StartsWith("number:"))
                                    {
                                        double filterDoubleValue;
                                        string filterIDAndValue = filterPropertyValue.Substring(7);
                                        string filterValueID = filterIDAndValue.Substring(0,
                                            filterIDAndValue.IndexOf(":"));
                                        string filterValue = filterIDAndValue.Length > filterValueID.Length + 1
                                            ? filterIDAndValue.Substring(filterValueID.Length + 1)
                                            : "";
                                        item.IntFilterFields.Add(filterPropertyName + "_id", filterValueID);
                                        if (Double.TryParse(filterValue, out filterDoubleValue))
                                            item.DoubleFilterFields.Add(filterPropertyName, filterDoubleValue);
                                    }
                                    else
                                    {
                                        string filterValueID = filterPropertyValue.Substring(0,
                                            filterPropertyValue.IndexOf(":"));
                                        string filterValue = filterPropertyValue.Length > filterValueID.Length + 1
                                            ? filterPropertyValue.Substring(filterValueID.Length + 1)
                                            : "";
                                        item.IntFilterFields.Add(filterPropertyName + "_id", filterValueID);
                                        item.StringFilterFields.Add(filterPropertyName, filterValue);
                                    }
                                }
                                catch (Exception ex)
                                {

                                    throw ex;
                                }

                            }
                        }
                        ls.Add(item);
                        count++;
                    }
                    catch (Exception oex)
                    {
                    }

                    if (count == 1000)
                    {
                        try
                        {
                            SolrDriver.IndexProducts(ls);
                            SolrDriver.Commit();
                            count = 0;
                            ls = new List<SolrProductItem>();

                        }
                        catch (Exception)
                        {
                        }

                    }
                }
                try
                {
                    SolrDriver.IndexProducts(ls);
                    SolrDriver.Commit();

                }
                catch (Exception)
                {
                }
                adtCom.UpdateQuery_LastUpdateSolr(DateTime.Now, drCom.ID);

            }

            //var products = SolrDriver.SearchProducts(SolrDriver.SortCategory.SortByPriceIncrease, 1, 20, 100000, 10000000, "may tinh",
            //    "c100,x430");
            dtProduct.Dispose();
            dtCom.Dispose();
            adtProduct.Dispose();
            adtCom.Dispose();
            return true;
        }

        public static bool DoUpdateSolrRootProductIndex(string connProductString, string solrUrl)
        {

            DBTool2.Product_SolrDataTable dtProduct = new DBTool2.Product_SolrDataTable();
            DBTool2TableAdapters.Product_SolrTableAdapter adtProduct = new DBTool2TableAdapters.Product_SolrTableAdapter();
            adtProduct.Connection.ConnectionString = QT.Entities.Server.ConnectionString;

            SolrDriver.Init(solrUrl);
            try
            {
                adtProduct.FillBy_ProductSanPhamGoc(dtProduct, DateTime.Now.AddDays(-100));
            }
            catch (Exception ex)
            {

            }
            int count = 0;
            List<SolrProductItem> ls = new List<SolrProductItem>();
            SolrDriver.DeleteByCompanyId(ID_Websosanh);
            for (int i = 0; i < dtProduct.Rows.Count; i++)
            {
                DataRow dr = dtProduct.Rows[i];
                try
                {
                    SolrProductItem item = new SolrProductItem
                    {
                        Id = QT.Entities.Common.Obj2Int64(dr["ID"]),
                        Price = QT.Entities.Common.Obj2Int(dr["GiaNhoNhat"]),
                        Warranty = QT.Entities.Common.Obj2Int(dr["Warranty"]),
                        Status = QT.Entities.Common.Obj2Int(dr["Status"]),
                        Company = QT.Entities.Common.Obj2Int64(dr["Company"]),
                        LastUpdate = QT.Entities.Common.ObjectToDataTime(dr["LastUpdate"]),
                        Summary = dr["Summary"].ToString(),
                        Description = "",
                        ProductId = QT.Entities.Common.Obj2Int(dr["ProductID"]),
                        ProductType = 1,
                        Name = dr["Name"].ToString(),
                        NameFT = dr["NameFT"].ToString(),
                        DetailUrl = dr["DetailUrl"].ToString(),
                        ImagePath = dr["ImagePath"].ToString(),
                        CategoryId = QT.Entities.Common.Obj2Int(dr["CategoryID"]),
                        ContentFT = dr["ContentFT"].ToString() + " " + Tools.removeHTML(dr["ProductContent"].ToString()),
                        ViewCount = QT.Entities.Common.Obj2Int(dr["ViewCount"]),
                        AddPosition = QT.Entities.Common.Obj2Int(dr["AddPosition"]),
                        StringFilterFields = new Dictionary<string, object>(),
                        DoubleFilterFields = new Dictionary<string, object>(),
                        DateTimeFilterFields = new Dictionary<string, object>(),
                        IntFilterFields = new Dictionary<string, object>()
                    };
                    for (int exIndex = 1; exIndex <= 10; exIndex++)
                    {
                        string filterPropertyName = QT.Entities.Common.Obj2String(dr["EX" + exIndex]);
                        string filterPropertyValue = QT.Entities.Common.Obj2String(dr["EXVALUE" + exIndex]);
                        if (!string.IsNullOrEmpty(filterPropertyName) && !string.IsNullOrEmpty(filterPropertyValue))
                        {
                            try
                            {
                                if (filterPropertyValue.StartsWith("number:"))
                                {
                                    double filterDoubleValue;
                                    string filterIDAndValue = filterPropertyValue.Substring(7);
                                    string filterValueID = filterIDAndValue.Substring(0,
                                        filterIDAndValue.IndexOf(":"));
                                    string filterValue = filterIDAndValue.Length > filterValueID.Length + 1
                                        ? filterIDAndValue.Substring(filterValueID.Length + 1)
                                        : "";
                                    item.IntFilterFields.Add(filterPropertyName + "_id", filterValueID);
                                    if (Double.TryParse(filterValue, out filterDoubleValue))
                                        item.DoubleFilterFields.Add(filterPropertyName, filterDoubleValue);
                                }
                                else
                                {
                                    string filterValueID = filterPropertyValue.Substring(0,
                                        filterPropertyValue.IndexOf(":"));
                                    string filterValue = filterPropertyValue.Length > filterValueID.Length + 1
                                        ? filterPropertyValue.Substring(filterValueID.Length + 1)
                                        : "";
                                    item.IntFilterFields.Add(filterPropertyName + "_id", filterValueID);
                                    item.StringFilterFields.Add(filterPropertyName, filterValue);
                                }
                            }
                            catch (Exception ex)
                            {

                                throw ex;
                            }

                        }
                    }
                    ls.Add(item);
                    count++;
                }
                catch (Exception ex)
                {

                }

                if (count == 1000)
                {
                    try
                    {
                        SolrDriver.IndexProducts(ls);
                        SolrDriver.Commit();
                        count = 0;
                        ls = new List<SolrProductItem>();

                    }
                    catch (Exception ex)
                    {


                    }

                }
            }
            try
            {
                SolrDriver.IndexProducts(ls);
                SolrDriver.Commit();

            }
            catch (Exception ex)
            {

            }

            dtProduct.Dispose();
            adtProduct.Dispose();
            return true;
        }

        public static bool DoUpdateSolrRootProductIndex(int categoryId, string connProductString, string solrUrl)
        {
            DBTool2.Product_SolrDataTable dtProduct = new DBTool2.Product_SolrDataTable();
            DBTool2TableAdapters.Product_SolrTableAdapter adtProduct = new DBTool2TableAdapters.Product_SolrTableAdapter();
            adtProduct.Connection.ConnectionString = QT.Entities.Server.ConnectionString;

            SolrDriver.Init(solrUrl);
            try
            {
                adtProduct.FillBy_ProductSanPhamGocByCategory(dtProduct, DateTime.Now.AddDays(-100), categoryId);
            }
            catch (Exception ex)
            {
            }
            int count = 0;
            List<SolrProductItem> ls = new List<SolrProductItem>();
            //SolrDriver.DeleteByCompanyId(ID_WEBSOSANH);
            for (int i = 0; i < dtProduct.Rows.Count; i++)
            {
                DataRow dr = dtProduct.Rows[i];
                try
                {
                    SolrProductItem item = new SolrProductItem
                    {
                        Id = QT.Entities.Common.Obj2Int64(dr["ID"]),
                        Price = QT.Entities.Common.Obj2Int(dr["GiaNhoNhat"]),
                        Warranty = QT.Entities.Common.Obj2Int(dr["Warranty"]),
                        Status = QT.Entities.Common.Obj2Int(dr["Status"]),
                        Company = QT.Entities.Common.Obj2Int64(dr["Company"]),
                        LastUpdate = QT.Entities.Common.ObjectToDataTime(dr["LastUpdate"]),
                        Summary = dr["Summary"].ToString(),
                        Description = "",
                        ProductId = QT.Entities.Common.Obj2Int(dr["ProductID"]),
                        ProductType = 1,
                        Name = dr["Name"].ToString(),
                        NameFT = dr["NameFT"].ToString(),
                        DetailUrl = dr["DetailUrl"].ToString(),
                        ImagePath = dr["ImagePath"].ToString(),
                        CategoryId = QT.Entities.Common.Obj2Int(dr["CategoryID"]),
                        ContentFT = dr["ContentFT"].ToString() + " " + Tools.removeHTML(dr["ProductContent"].ToString()),
                        ViewCount = QT.Entities.Common.Obj2Int(dr["ViewCount"]),
                        AddPosition = QT.Entities.Common.Obj2Int(dr["AddPosition"]),
                        StringFilterFields = new Dictionary<string, object>(),
                        DoubleFilterFields = new Dictionary<string, object>(),
                        DateTimeFilterFields = new Dictionary<string, object>(),
                        IntFilterFields = new Dictionary<string, object>()
                    };
                    for (int exIndex = 1; exIndex <= 10; exIndex++)
                    {
                        string filterPropertyName = QT.Entities.Common.Obj2String(dr["EX" + exIndex]);
                        string filterPropertyValue = QT.Entities.Common.Obj2String(dr["EXVALUE" + exIndex]);
                        if (!string.IsNullOrEmpty(filterPropertyName) && !string.IsNullOrEmpty(filterPropertyValue))
                        {
                            try
                            {
                                if (filterPropertyValue.StartsWith("number:"))
                                {
                                    double filterDoubleValue;
                                    string filterIDAndValue = filterPropertyValue.Substring(7);
                                    string filterValueID = filterIDAndValue.Substring(0,
                                        filterIDAndValue.IndexOf(":"));
                                    string filterValue = filterIDAndValue.Length > filterValueID.Length + 1
                                        ? filterIDAndValue.Substring(filterValueID.Length + 1)
                                        : "";
                                    item.IntFilterFields.Add(filterPropertyName + "_id", filterValueID);
                                    if (Double.TryParse(filterValue, out filterDoubleValue))
                                        item.DoubleFilterFields.Add(filterPropertyName, filterDoubleValue);
                                }
                                else
                                {
                                    string filterValueID = filterPropertyValue.Substring(0,
                                        filterPropertyValue.IndexOf(":"));
                                    string filterValue = filterPropertyValue.Length > filterValueID.Length + 1
                                        ? filterPropertyValue.Substring(filterValueID.Length + 1)
                                        : "";
                                    item.IntFilterFields.Add(filterPropertyName + "_id", filterValueID);
                                    item.StringFilterFields.Add(filterPropertyName, filterValue);
                                }
                            }
                            catch (Exception ex)
                            {

                                throw ex;
                            }

                        }
                    }
                    ls.Add(item);
                    count++;
                }
                catch (Exception ex)
                {
                }

                if (count == 1000)
                {
                    try
                    {
                        SolrDriver.IndexProducts(ls);
                        SolrDriver.Commit();
                        count = 0;
                        ls = new List<SolrProductItem>();
                    }
                    catch (Exception ex)
                    {

                    }

                }
            }
            try
            {
                SolrDriver.IndexProducts(ls);
                SolrDriver.Commit();
            }
            catch (Exception ex)
            {
            }

            dtProduct.Dispose();
            adtProduct.Dispose();
            return true;
        }
    }
}
