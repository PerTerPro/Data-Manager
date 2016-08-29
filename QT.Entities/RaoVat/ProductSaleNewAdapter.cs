using QT.Entities.Data;
using QT.Entities.Model.SaleNews;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.RaoVat
{
    public class ProductSaleNewDataAdapter
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(ProductSaleNewDataAdapter));

        SqlDb sqlDb = null;
        public ProductSaleNewDataAdapter(SqlDb sqlDb)
        {
            this.sqlDb = sqlDb;
        }

        public bool InsertFirstTimeProduct(ProductSaleNew product)
        {
            return true;
//            long ID = product.id;
//            string Title = product.name;
//            decimal Price = product.price;
//            DateTime PostDate = product.post_date;
//            DateTime LastChange = DateTime.Now;
//            string Province = product.province;
//            string PhoneSaler = product.phone_saler;
//            string Quality = product.quality;
//            string Address = product.address;
//            string Content = product.content;
//            int Avaiable = product.Avaiable;

//            try
//            {
//                string sql = string.Format(@"INSERT INTO ProductSaleNew (
//            {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23}, {24}, {25}, {26}
//            ) VALUES (
//@{0}, @{1}, @{2}, @{3}, @{4}, @{5}, @{6}, @{7}, @{8}, @{9}, @{10}, @{11}, @{12}, @{13}, @{14}, @{15}, @{16}, @{17}, @{18}, @{19}, @{20}, @{21}, @{22}, @{23}, @{24}, @{25}, @{26}
//               )"
//                    , "ID", "Content", "Title", "Price",
//                    "PostDate", "LastChange", "Province", "PhoneSaler", "Quality", "Address", "Avaiable",
//                    "FieldS01", "FieldS02", "FieldS03", "FieldS04", "FieldS05", "FieldS06", "FieldS07", "FieldS08", "FieldS09",
//                    "FieldS10", "FieldI01", "FieldI02", "FieldI03", "Category", "CategoryID", "ImageUrls");
//                SqlParameter[] arPara = new SqlParameter[]
//               {
//                  this.sqlDb.CreateParamteter("ID",ID,System.Data.SqlDbType.BigInt),
//                  this.sqlDb.CreateParamteter("Title",Title,System.Data.SqlDbType.NVarChar),
//                  this.sqlDb.CreateParamteter("Price",Price,System.Data.SqlDbType.Decimal),
//                  this.sqlDb.CreateParamteter("PostDate",PostDate,System.Data.SqlDbType.DateTime),
//                  this.sqlDb.CreateParamteter("LastChange",LastChange,System.Data.SqlDbType.DateTime),
//                  this.sqlDb.CreateParamteter("Province",Province,System.Data.SqlDbType.NVarChar),
//                  this.sqlDb.CreateParamteter("PhoneSaler",PhoneSaler,System.Data.SqlDbType.NVarChar),
//                  this.sqlDb.CreateParamteter("Quality",Quality,System.Data.SqlDbType.NVarChar),
//                  this.sqlDb.CreateParamteter("Address",Address,System.Data.SqlDbType.NVarChar),
//                  this.sqlDb.CreateParamteter("Content",Content,System.Data.SqlDbType.NText),
//                  this.sqlDb.CreateParamteter("Avaiable",Avaiable,System.Data.SqlDbType.Int),
//                  this.sqlDb.CreateParamteter("Category",Convert.ToString(product.Category),System.Data.SqlDbType.NVarChar),
//                  this.sqlDb.CreateParamteter("CategoryID",Convert.ToInt32(product.category_id),System.Data.SqlDbType.Int),
//                  this.sqlDb.CreateParamteter("ImageUrls",Common.ConvertToString( product.images,";"),System.Data.SqlDbType.NVarChar)
//               };

//                this.sqlDb.RunQuery(sql, System.Data.CommandType.Text, arPara);
//                return true;
//            }
//            catch (Exception ex)
//            {
//                log.ErrorFormat("Exception:{0}", ex.Message);
//                return false;
//            }
        }

        public bool CheckExistsInDb(long ID)
        {
            DataTable tbl = this.sqlDb.GetTblData("SELECT ID FROM [ProductSaleNew] WHERE ID = @ID", System.Data.CommandType.Text,
                new SqlParameter[] { sqlDb.CreateParamteter("ID", ID, System.Data.SqlDbType.BigInt) });
            return tbl.Rows.Count > 0;
        }

        public bool UpdateProduct(ProductSaleNew product)
        {
            try
            {
                string sql = string.Format(@"UPDATE ProductSaleNew 
            {0}=@{0}, {1}=@{1}, {2}=@{2}, {3}=@{3}, {4}=@{4}, {5}=@{5}, {6}=@{6}, {7}=@{7}, {8}=@{8}, {9}=@{9}, {10}=@{10}, {11}=@{11}, {12}=@{12}, {13}=@{13}, {14}=@{14}, {15}=@{15}, {16}=@{16}, {17}=@{17}, {18}=@{18}, {19}=@{19}, {20}=@{20}, {21}=@{21}, {22}=@{22}, {23}=@{23} WHERE @{0} = @{0}"
                    , "ID", "Content", "Title", "Price",
                    "PostDate", "LastChange", "Province", "PhoneSaler", "Quality", "Address", "Avaiable",
                    "FieldS01", "FieldS02", "FieldS03", "FieldS04", "FieldS05", "FieldS06", "FieldS07", "FieldS08", "FieldS09",
                    "FieldS10", "FieldI01", "FieldI02", "FieldI03");
                SqlParameter[] arPara = new SqlParameter[]
               {
                  this.sqlDb.CreateParamteter("ID",product.id,System.Data.SqlDbType.BigInt),
                  this.sqlDb.CreateParamteter("Title",product.name,System.Data.SqlDbType.NVarChar),
                  this.sqlDb.CreateParamteter("Price",product.price,System.Data.SqlDbType.Decimal),
                  this.sqlDb.CreateParamteter("PostDate",product.post_date,System.Data.SqlDbType.DateTime),
                  this.sqlDb.CreateParamteter("LastChange",product.source_updated_at,System.Data.SqlDbType.DateTime),
                  this.sqlDb.CreateParamteter("Province",product.province,System.Data.SqlDbType.NVarChar),
                  this.sqlDb.CreateParamteter("PhoneSaler",product.phone_saler,System.Data.SqlDbType.NVarChar),
                  this.sqlDb.CreateParamteter("Quality",product.quality,System.Data.SqlDbType.NVarChar),
                  this.sqlDb.CreateParamteter("Address",product.address,System.Data.SqlDbType.NVarChar),
                  this.sqlDb.CreateParamteter("Content",product.content,System.Data.SqlDbType.NText),
                  this.sqlDb.CreateParamteter("Avaiable",product.Avaiable,System.Data.SqlDbType.Int)
               };

                this.sqlDb.RunQuery(sql, System.Data.CommandType.Text, arPara);
                return true;
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Exception:{0}", ex.Message);
                return false;
            }
        }

        public int SaveCategoryLevel1(string CategoryName, string ParentCategory, string Description, string url, int Level, string FullCategory, string imageUrls)
        {
            try
            {
                DataTable tblParentCategory = this.sqlDb.GetTblData("SELECT CategoryID FROM Categories WHERE CategoryName = @CategoryName", CommandType.Text,
                    new SqlParameter[]
                {
                     this.sqlDb.CreateParamteter("CategoryName",ParentCategory,SqlDbType.NVarChar)
                });
                if (tblParentCategory.Rows.Count > 0)
                {
                    DataTable tbl = this.sqlDb.GetTblData("SELECT ISNULL(MAX(CategoryID),0)+1 FROM Categories", CommandType.Text, null);
                    int newID = Convert.ToInt32(tbl.Rows[0][0]);
                    int IDParent = Convert.ToInt32(tblParentCategory.Rows[0][0]);

                    DataTable tblDumplicate = sqlDb.GetTblData(@"  SELECT CategoryID from [Categories]
  WHERE [CategoryName]=@CategoryName AND [ParentCategoryID]=@ParentCategoryID", CommandType.Text, new SqlParameter[]{
                                                                                  sqlDb.CreateParamteter("@CategoryName",CategoryName,SqlDbType.NVarChar),
                                                                                  sqlDb.CreateParamteter("@ParentCategoryID",IDParent,SqlDbType.Int)
                                                                              });
                    //Kiểm trùng
                    if (tblDumplicate.Rows.Count == 0)
                    {
                        string sql = string.Format("INSERT INTO Categories ({0},{1},{2},{3},{4}, {5}, {6}, {7}) VALUES (@{0},@{1},@{2},@{3},@{4}, @{5}, @{6}, @{7})"
                            , "CategoryID", "CategoryName", "ParentCategoryID", "Description", "Url", "FullCategory", "Level", "ImageUrls");
                        this.sqlDb.RunQuery(sql, CommandType.Text, new SqlParameter[]
                                        {
                                            sqlDb.CreateParamteter("@CategoryID",newID,SqlDbType.Int),
                                            sqlDb.CreateParamteter("@CategoryName",CategoryName,SqlDbType.NVarChar),
                                            sqlDb.CreateParamteter("@ParentCategoryID",IDParent ,SqlDbType.Int),
                                            sqlDb.CreateParamteter("@Description",Description,SqlDbType.NVarChar),
                                            sqlDb.CreateParamteter("@Url",url,SqlDbType.NVarChar),
                                            sqlDb.CreateParamteter("@FullCategory",FullCategory,SqlDbType.NVarChar),
                                            sqlDb.CreateParamteter("@Level",Level,SqlDbType.Int),
                                            sqlDb.CreateParamteter("@ImageUrls",imageUrls,SqlDbType.NVarChar)
                                        });
                        return newID;
                    }
                    else
                    {
                        int CategoryOldID = Convert.ToInt32(tblDumplicate.Rows[0][0]);
                        this.sqlDb.RunQuery("UPDATE Categories SET Description=@Description WHERE CategoryID=@CategoryID", CommandType.Text,
                            new SqlParameter[]{
                             sqlDb.CreateParamteter("@CategoryID",CategoryOldID,SqlDbType.Int),
                             sqlDb.CreateParamteter("@Description",Description,SqlDbType.NVarChar),
                        });
                        return CategoryOldID;
                    }
                }
                else
                {

                    log.ErrorFormat("Not find ParentCategory:{0}=>Not insert model:{1}", ParentCategory, CategoryName);
                    return -1;
                }
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Exception:{0}", ex.Message);
                return -1;
            }
        }

        public int SaveCategoriesLevel1(string CategoryName, int IDParent, string Description, string url, int Level)
        {
            try
            {
                int idCheckDumplicate = this.GetCategoriesID(CategoryName, IDParent);
                if (idCheckDumplicate < 0)
                {
                    DataTable tbl = this.sqlDb.GetTblData("SELECT ISNULL(MAX(CategoryID),0)+1 FROM Categories", CommandType.Text, null);
                    int newID = Convert.ToInt32(tbl.Rows[0][0]);
                    string sql = string.Format("INSERT INTO Categories ({0},{1},{2},{3},{4},{5}) VALUES (@{0},@{1},@{2},@{3},@{4},@{5})", "CategoryID", "CategoryName", "ParentCategoryID", "Description", "Url", "Level");
                    this.sqlDb.RunQuery(sql, CommandType.Text, new SqlParameter[]
                                        {
                                            sqlDb.CreateParamteter("@CategoryID",newID,SqlDbType.Int),
                                            sqlDb.CreateParamteter("@CategoryName",CategoryName,SqlDbType.NVarChar),
                                            sqlDb.CreateParamteter("@ParentCategoryID",IDParent ,SqlDbType.Int),
                                            sqlDb.CreateParamteter("@Description",Description,SqlDbType.NVarChar),
                                            sqlDb.CreateParamteter("@Url",url,SqlDbType.NVarChar) ,sqlDb.CreateParamteter("@Level",Level,SqlDbType.Int)
                                        });
                    return newID;
                }
                else
                {
                    return idCheckDumplicate;
                }
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Exception:{0}", ex.Message);
                return -1;
            }

        }

        public int GetCategoriesID(string CategoryName, int CategoryParentID)
        {
            if (CategoryParentID < 0)
            {
                DataTable tblDumplicate = this.sqlDb.GetTblData("SELECT CategoryID FROM Categories WHERE CategoryName = @CategoryName AND ParentCategoryID IS NULL", CommandType.Text,
                    new SqlParameter[] { sqlDb.CreateParamteter("CategoryName", CategoryName, SqlDbType.NVarChar) });
                if (tblDumplicate.Rows.Count == 0) return -1;
                else return Convert.ToInt32(tblDumplicate.Rows[0][0]);
            }
            else
            {
                DataTable tblDumplicate = this.sqlDb.GetTblData("SELECT CategoryID FROM Categories WHERE CategoryName = @CategoryName AND ParentCategoryID = @ParentCategoryID", CommandType.Text,
                 new SqlParameter[] { sqlDb.CreateParamteter("CategoryName", CategoryName, SqlDbType.NVarChar),
                                      sqlDb.CreateParamteter("ParentCategoryID",CategoryParentID,SqlDbType.Int)});
                if (tblDumplicate.Rows.Count == 0) return -1;
                else return Convert.ToInt32(tblDumplicate.Rows[0][0]);
            }
        }

        public int SaveConfigRootToDb(string CategoryName, int ParentCategoryID, string Description, string url, string ImageUrls)
        {
            int CategoryCurrent = this.GetCategoriesID(CategoryName, -1);
            if (CategoryCurrent < 0)
            {
                DataTable tbl = this.sqlDb.GetTblData("SELECT ISNULL(MAX(CategoryID),0)+1 FROM Categories", CommandType.Text, null);
                int newID = Convert.ToInt32(tbl.Rows[0][0]);
                string sql = string.Format("INSERT INTO Categories ({0},{1},{2},{3}, {4}, {5}, {6}) VALUES (@{0},@{1},@{2},@{3}, @{4}, @{5}, @{6})", "CategoryID", "CategoryName", "ParentCategoryID", "Description", "Url", "FullCategory", "ImageUrls");
                this.sqlDb.RunQuery(sql, CommandType.Text, new SqlParameter[]
                {
                    sqlDb.CreateParamteter("@CategoryID",newID,SqlDbType.Int),
                    sqlDb.CreateParamteter("@CategoryName",CategoryName,SqlDbType.NVarChar),
                    sqlDb.CreateParamteter("@ParentCategoryID",DBNull.Value,SqlDbType.Int),
                    sqlDb.CreateParamteter("@Description",Description,SqlDbType.NVarChar),
                    sqlDb.CreateParamteter("@Url",url,SqlDbType.NVarChar),
                    sqlDb.CreateParamteter("@FullCategory",CategoryName,SqlDbType.NVarChar),
                    sqlDb.CreateParamteter("@ImageUrls",ImageUrls,SqlDbType.NVarChar)
                });
                return newID;
            }
            else
            {
                this.sqlDb.RunQuery("UPDATE Categories SET Description = @Description WHERE CategoryID = @CategoryID", CommandType.Text,
                    new SqlParameter[]{
                         sqlDb.CreateParamteter("@CategoryID",CategoryCurrent,SqlDbType.Int),
                         sqlDb.CreateParamteter("@Description",Description,SqlDbType.NVarChar),
                    });
                return CategoryCurrent;
            }
        }

        public int CheckExitFullLink(string FullCategory)
        {
            DataTable tbl01 = this.sqlDb.GetTblData("SELECT * FROM Categories WHERE FullCategory = @FullCategory", CommandType.Text, new SqlParameter[]{
                sqlDb.CreateParamteter("FullCategory",FullCategory,SqlDbType.NVarChar)
            });
            if (tbl01.Rows.Count == 0) return -1;
            else return Convert.ToInt32(tbl01.Rows[0][0]);
        }

        public void SaveKeyWord(string Maker, string ModelCar, string KeyWord, string FullKeyWord, string Description)
        {
            string textFull = Maker.Replace(" ", "") + "->" + ModelCar.Replace(" ", "");
            int iID = CheckExitFullLink(textFull);
            if (iID >= 0)
            {
                int idWebCategories = Convert.ToInt32(iID);
                this.sqlDb.RunQuery(@"IF NOT EXISTS(SELECT * FROM KeyWords WHERE Name = @Name and WebCategoryID = @WebCategoryID)
                                      BEGIN
INSERT INTO KeyWords (Name, WebCategoryID, CategoryID, Description, FullText) VALUES (@Name, @WebCategoryID, @CategoryID, @Description, @FullText)
                                      END
                ", CommandType.Text,
                    new SqlParameter[]{
                        this.sqlDb.CreateParamteter("Name",KeyWord,SqlDbType.NVarChar),
                        this.sqlDb.CreateParamteter("WebCategoryID",idWebCategories,SqlDbType.Int),
                        this.sqlDb.CreateParamteter("CategoryID",9,SqlDbType.Int),
                        this.sqlDb.CreateParamteter("Description",Description,SqlDbType.NVarChar),
                        this.sqlDb.CreateParamteter("FullText",FullKeyWord,SqlDbType.NVarChar)
                    });
            }
        }

        public void SaveKeyWord()
        {
            throw new NotImplementedException();
        }

        public void SaveKeyWord(ProductSaleNew productSaleNew)
        {
            string strQuery = string.Format(@"IF NOT EXISTS(SELECT KeyHash FROM KeyWords WHERE KeyHash=@KeyHash) BEGIN INSERT INTO KeyWords ({0}, {1}, {2}) VALUES
                                            (@{0}, @{1}, @{2}) END", "KeyHash", "KeyName", "ProductID");
            string strQuery1 = string.Format(@"IF NOT EXISTS(SELECT KeyHash, ProductID FROM KeyWordProduct WHERE KeyHash=@KeyHash AND ProductID=@ProductID) BEGIN
                                              INSERT INTO KeyWordProduct(KeyHash, ProductID) VALUES (@KeyHash, @ProductID)
                                             END");
            try
            {
                List<string> list = productSaleNew.tags;
                foreach (string str in list)
                {
                    long hashKeyWord = Math.Abs(GABIZ.Base.Tools.getCRC32(str));
                    this.sqlDb.RunQuery(
                        strQuery, CommandType.Text, new SqlParameter[] { 
                                             this.sqlDb.CreateParamteter("KeyHash",hashKeyWord,SqlDbType.BigInt),
                                             this.sqlDb.CreateParamteter("KeyName",str,SqlDbType.NVarChar),
                                             this.sqlDb.CreateParamteter("ProductID",productSaleNew.id,SqlDbType.BigInt)
                                         });
                    this.sqlDb.RunQuery(strQuery1, CommandType.Text, new SqlParameter[]
                        {
                             this.sqlDb.CreateParamteter("KeyHash",hashKeyWord,SqlDbType.BigInt),
                            this.sqlDb.CreateParamteter("ProductID",productSaleNew.id,SqlDbType.BigInt),
                        });
                }
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Exeception:SaveKeyWord:0{}", ex.Message);
            }
        }

        public DataTable GetTableKeyWord()
        {
            return this.sqlDb.GetTblData("SELECT KeyHash, KeyName FROM KeyWords", CommandType.Text, null);
        }

        public void SaveNumberKeyWordInProduct(long keyHash, string keyWord, int iCount)
        {
            this.sqlDb.RunQuery("UPDATE KeyWords SET NumberInProduct = @NumberInProduct WHERE KeyHash = @KeyHash", CommandType.Text, new SqlParameter[]{
             this.sqlDb.CreateParamteter("NumberInProduct", iCount,SqlDbType.Int),
             this.sqlDb.CreateParamteter("KeyHash",keyHash,SqlDbType.BigInt)
            });
        }

        public DataTable GetTableKeyWordCategories()
        {
            return this.sqlDb.GetTblData("SELECT KeyHash, KeyName FROM KeyWordsCategories", CommandType.Text, null);
        }

        public int CheckExitFullLink01(string FullCategory)
        {
            DataTable tbl01 = this.sqlDb.GetTblData("SELECT [CategoryID] AS FullCategory FROM Categories WHERE LTRIM(RTRIM( ISNULL(REPLACE([FullCategory], '->', ' '),CategoryName))) = @FullCategory", CommandType.Text, new SqlParameter[]{
                sqlDb.CreateParamteter("FullCategory",FullCategory,SqlDbType.NVarChar)
            });
            if (tbl01.Rows.Count == 0) return -1;
            else return Convert.ToInt32(tbl01.Rows[0][0]);
        }

        public void SaveKeyWord1(string p1, string strModelCar, string p2, string keyWord, string description)
        {
            throw new NotImplementedException();
        }

        public void SaveKeyWord(int iCategories, string KeyWord, string FullKeyWord, string description)
        {
            if (iCategories >= 0)
            {
                int idWebCategories = Convert.ToInt32(iCategories);
                this.sqlDb.RunQuery(@"IF NOT EXISTS(SELECT * FROM KeyWords1 WHERE Name = @Name and WebCategoryID = @WebCategoryID)
                                      BEGIN
INSERT INTO KeyWords1 (Name, WebCategoryID, CategoryID, Description, FullText) VALUES (@Name, @WebCategoryID, @CategoryID, @Description, @FullText)
                                      END
                ", CommandType.Text,
                    new SqlParameter[]{
                        this.sqlDb.CreateParamteter("Name",KeyWord,SqlDbType.NVarChar),
                        this.sqlDb.CreateParamteter("WebCategoryID",idWebCategories,SqlDbType.Int),
                        this.sqlDb.CreateParamteter("CategoryID",9,SqlDbType.Int),
                        this.sqlDb.CreateParamteter("Description","",SqlDbType.NVarChar),
                        this.sqlDb.CreateParamteter("FullText",FullKeyWord,SqlDbType.NVarChar)
                    });
            }
        }

        public bool CheckExistInDb(long p)
        {
            return false;
        }

        public List<RegexCheckKeyword> GetListRegexBlackLink()
        {
            List<RegexCheckKeyword> lst = new List<RegexCheckKeyword>();
            foreach (var item in GetListRegexKeyWord())
                if (item.Vaid == false) lst.Add(item);
            return lst;
        }

        public List<RegexCheckKeyword> GetListRegexKeyWord()
        {
            List<RegexCheckKeyword> lst = new List<RegexCheckKeyword>();
            DataTable tbl = this.sqlDb.GetTblData("select RegexKeyword, IsValid from RegexFindKeyWord");
            foreach(DataRow item in tbl.Rows)
            {
                lst.Add(new RegexCheckKeyword()
                    {
                        Regex = item["RegexKeyword"].ToString(),
                        Vaid = Convert.ToBoolean(item["IsValid"])
                    });
            }
            return lst;
        }

        public List<RegexCheckKeyword> GetListRegexValidLink()
        {
           List<RegexCheckKeyword> lst = new List<RegexCheckKeyword>();
           foreach (var item in GetListRegexKeyWord())
               if (item.Vaid == true) lst.Add(item);
           return lst;
        }

    
    }
}


