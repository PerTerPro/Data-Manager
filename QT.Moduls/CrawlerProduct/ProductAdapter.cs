using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using QT.Moduls.RabbitMQ;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.Drivers.Redis;
using Websosanh.Core.JobServer;

namespace QT.Moduls.CrawlerProduct
{
    public class ProductAdapter
    {
        //BuidApp
        //BuidLan2
        //RabbitMQServer rabbitMQServer = null;

        JobClient updateProductJobClient_PushCompany = null;
        JobClient updateProductJobClient_ChangeData = null;
        JobClient updateProductJobClient_AddProduct = null;

      
        public QT.Moduls.Crawler.DBCrawlerTableAdapters.Price_LogsTableAdapter _adtPriceLog;

        private readonly SqlDb _sqlDb;

        public SqlDb GetSqlDb()
        {
            return _sqlDb;
        }

        public ProductAdapter(SqlDb sqlDb)
        {
            // TODO: Complete member initialization
            this._sqlDb = sqlDb;
            InitData();
        }

        public ProductAdapter()
        {
            InitData();
        }



        private void InitData()
        {

            //try
            //{
            //    while (this.rabbitMQServer == null || this.rabbitMQServer.IsStarted == false)
            //    {
            //        try
            //        {
            //            this.rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            //        }
            //        catch (Exception ex01)
            //        {
            //            _log.Error(ex01);
            //            Thread.Sleep(10000);
            //        }
            //    }

            
            //    this._adtPriceLog = new Crawler.DBCrawlerTableAdapters.Price_LogsTableAdapter();
            //    this._adtPriceLog.Connection.ConnectionString = QT.Entities.Server.LogConnectionString;
            //}
            //catch (Exception ex01)
            //{
            //    _log.Error(ex01);
            //    Thread.Sleep(10000);
            //}
        }

        log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ProductAdapter));

        public void SetBlackListForProduct(List<long> productIds)
        {
            string query = "Update Product Set Valid = 0, IsBlackList = 1 Where Id = @Id";
            foreach (var productId in productIds)
            {
                this._sqlDb.RunQuery(query, CommandType.Text, new SqlParameter[]
                {
                    SqlDb.CreateParamteterSQL("Id", productId, SqlDbType.BigInt)
                });
            }
        }

        public bool CheckExistInDb(long idProduct)
        {
            var a = this._sqlDb.GetTblData("SELECT  ID FROM product WHERE ID = @ID", System.Data.CommandType.Text,
                new SqlParameter[]{
                     _sqlDb.CreateParamteter("Id",idProduct,System.Data.SqlDbType.BigInt)
                });
            return a.Rows.Count > 0;
        }

        public List<ProductEntity> GetProductEntitieBy(List<long> productIds)
        {
            string query = string.Format(@"select top 10000 a.ID, a.Name, a.ShortDescription
	, a.HashName
	, a.ImageUrls
	, a.company as CompanyId
	, a.Price
	, a.OriginPrice
	, a.LastPriceChange
	, a.IsNews
	, a.Valid
	, a.Status
	, a.InStock
	, a.DetailUrl
    , b.Domain
    , a.VATInfo
    , a.PromotionInfo
    , a.StartDeal
    , a.EndDeal
    , a.Warranty
    , a.IsNews
from Product a
inner join Company b on a.company = b.id
where a.id in ({0})", string.Join(",", productIds));
            ProductParse productParse = new ProductParse();
            DataTable tblProducts = _sqlDb.GetTblData(query, CommandType.Text, null);
            List<ProductEntity> lst = new List<ProductEntity>();
            foreach (DataRow dataRow in tblProducts.Rows)
            {
                ProductEntity productEntity = new ProductEntity();
                productParse.ParseProduct(productEntity, dataRow);
                lst.Add(productEntity);
            }
            return lst;
        }

        public void UpdateNotLoadProduct(long idProduct)
        {
            this._sqlDb.RunQuery("UPDATE PRODUCT SET LastUpdate=GETDATE() WHERE ID = @ID", System.Data.CommandType.Text, new SqlParameter[]{
                this._sqlDb.CreateParamteter("ID",idProduct,System.Data.SqlDbType.BigInt)
            });
        }


        public void UpdateExtraInfo(long idProduct, string sortDescription)
        {
            this._sqlDb.RunQuery("Update Product Set SortDescription = @SortDescription Where Id = @Id",
                System.Data.CommandType.Text, new SqlParameter[]
                {
                    _sqlDb.CreateParamteter("Id",idProduct,System.Data.SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("SortDescription",sortDescription,System.Data.SqlDbType.NVarChar)
                });
        }

        public bool UpdateProduct(ProductEntity pt)
        {
            return this._sqlDb.RunQuery(@"
              Update Product Set 
              Price = @Price
            , PriceChange = @PriceChange
            , VATInfo = @VATInfo
            , PromotionInfo = @PromotionInfo
            , ShortDescription=@ShortDescription
            , OriginPrice = @OriginPrice
            , DeliveryInfo = @DeliveryInfo
            , LastUpdate = GETDATE() 
            , StartDeal = @StartDeal
            , EndDeal=@EndDeal
            , IsDeal = @IsDeal
            , Summary = @Summary
            , Name = @Name
            , ProductContent = @ProductContent
            , ImageUrls = CASE @ImageUrls WHEN '' THEN ImageUrls ELSE @ImageUrls END
            , Valid = CASE IsNews WHEN 1 THEN Valid ELSE @Valid END
            , IsNews= CASE @Valid WHEN 1 THEN IsNews ELSE 0 END
            , ClassificationId = @ClassificationId
            , VATStatus = @VATStatus
            , InStock = @InStock, ProductDuplicate = @ProductDuplicate
            , IsBlackList = CASE @ProductDuplicate WHEN 0 THEN IsBlackList ELSE 1 END
            , HashName = @HashName
            Where Id = @Id"
                , CommandType.Text
                , new SqlParameter[]
                {
                    _sqlDb.CreateParamteter("Valid", true, SqlDbType.Bit),
                    _sqlDb.CreateParamteter("Id", pt.ID, SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("ClassificationId", pt.IdCategories, SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("Price", pt.Price, SqlDbType.Int),
                    _sqlDb.CreateParamteter("Warranty", pt.Warranty, SqlDbType.Int),
                    _sqlDb.CreateParamteter("ImageUrls", pt.ImageUrl, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("Company", pt.CompanyId, SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("DetailUrl", pt.DetailUrl, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("Name", pt.Name, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("Summary", pt.Summary, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("ProductContent", pt.ProductContent, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("NameFT", pt.NameFT, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("PriceChange", 0, SqlDbType.Int),
                    _sqlDb.CreateParamteter("VATInfo", pt.VatInfo, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("PromotionInfo", pt.Promotion, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("DeliveryInfo", pt.DeliveryInfo, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("ShortDescription", pt.ShortDescription, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("OriginPrice", pt.OriginPrice, SqlDbType.Int),
                    _sqlDb.CreateParamteter("StartDeal",
                        (pt.StartDeal == SqlDb.MinDateDb) ? DBNull.Value : (object) pt.StartDeal,
                        SqlDbType.DateTime),
                    _sqlDb.CreateParamteter("EndDeal",
                        (pt.EndDeal == SqlDb.MinDateDb) ? DBNull.Value : (object) pt.EndDeal,
                        SqlDbType.DateTime),
                    _sqlDb.CreateParamteter("IsDeal", pt.IsDeal, SqlDbType.Bit),
                    _sqlDb.CreateParamteter("VATStatus", pt.VATStatus, SqlDbType.Int),
                    _sqlDb.CreateParamteter("InStock", pt.Instock, SqlDbType.Int),
                    _sqlDb.CreateParamteter("ProductDuplicate", pt.ProductDuplicate, SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("HashName", pt.GetHashChange(), SqlDbType.BigInt)
                }, false);

            this._sqlDb.RunQuery("prc_Product_AutoFindCategoryID", CommandType.StoredProcedure,  new SqlParameter[] {SqlDb.CreateParamteterSQL("@ProductID", pt.ID, SqlDbType.BigInt)});
        }

        private bool UpdateProduct(string Name, long ClassificationID, long Price, int Warranty, int Status, string ImageUrls, long Company
            , DateTime LastUpdate, string DetailUrl, string Promotion, string Summary, string ProductContent, string NameFT
            , DateTime LastPriceChange, int PriceChange, int AddPositio, string DeliveryInfo
            , int OriginPrice, long ID, string VATInfo, string PromotionInfo, string ShortDescription, DateTime StartDeal, DateTime EndDeal
            , bool IsDeal, int ProductStock, bool Valid = true, int VATStatus = QT.Entities.Common.VATStatus.UndefinedVAT, long ProductDumplicate = 0)
        {
            return this._sqlDb.RunQuery(@"
              Update Product Set Price = @Price, PriceChange = @PriceChange
            , VATInfo = @VATInfo
            , PromotionInfo = @PromotionInfo
            , ShortDescription=@ShortDescription
            , OriginPrice = Price
            , DeliveryInfo = @DeliveryInfo
            , LastUpdate = GETDATE() 
            , StartDeal = @StartDeal
            , EndDeal=@EndDeal
            , IsDeal = @IsDeal
            , Summary = @Summary
            , Name = @Name
            , ProductContent = @ProductContent
            , ImageUrls = CASE @ImageUrls WHEN '' THEN ImageUrls ELSE @ImageUrls END
            , Valid = CASE IsNews WHEN 1 THEN Valid ELSE @Valid END
            , IsNews= CASE @Valid WHEN 1 THEN IsNews ELSE 0 END
            , ClassificationId = @ClassificationId
            , VATStatus = @VATStatus
            , InStock = @InStock, ProductDuplicate = @ProductDuplicate
            , IsBlackList = CASE @ProductDuplicate WHEN 0 THEN IsBlackList ELSE 1 END
            Where Id = @Id"
                 , System.Data.CommandType.Text
                 , new SqlParameter[]{
                    _sqlDb.CreateParamteter("Valid",Valid,System.Data.SqlDbType.Bit),
                    _sqlDb.CreateParamteter("Id",ID,System.Data.SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("ClassificationId", ClassificationID,System.Data.SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("Price",Price,System.Data.SqlDbType.Int),
                    _sqlDb.CreateParamteter("Warranty",Warranty,System.Data.SqlDbType.Int),
                    _sqlDb.CreateParamteter("ImageUrls",ImageUrls,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("Company",Company,System.Data.SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("DetailUrl",DetailUrl,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("Name",Name,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("Summary",Summary,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("ProductContent",ProductContent,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("NameFT",NameFT,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("PriceChange",PriceChange,System.Data.SqlDbType.Int),
                    _sqlDb.CreateParamteter("VATInfo",VATInfo,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("PromotionInfo",PromotionInfo,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("DeliveryInfo",DeliveryInfo,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("ShortDescription",ShortDescription,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("OriginPrice",OriginPrice,System.Data.SqlDbType.Int),
                    _sqlDb.CreateParamteter("StartDeal",(StartDeal==SqlDb.MinDateDb)?DBNull.Value:(object)StartDeal,System.Data.SqlDbType.DateTime),
                    _sqlDb.CreateParamteter("EndDeal",(EndDeal==SqlDb.MinDateDb)?DBNull.Value:(object)EndDeal,System.Data.SqlDbType.DateTime),
                    _sqlDb.CreateParamteter("IsDeal",IsDeal,System.Data.SqlDbType.Bit),
                    _sqlDb.CreateParamteter("VATStatus",VATStatus,System.Data.SqlDbType.Int),
                    _sqlDb.CreateParamteter("InStock",ProductStock,System.Data.SqlDbType.Int),
                    _sqlDb.CreateParamteter("ProductDuplicate",ProductDumplicate,System.Data.SqlDbType.BigInt)
                }, false);
        }

    
        private bool InsertToSQLDB(long id, string name, long classificationId, long price, int warranty,
               string imageUrls,
               long company,
               string detailUrl,
               int productId,
               string promotion,
               string summary,
               string productContent,
               string nameFt,
               long hashName,
               long priceChange,
               int addPosition,
               string vatInfo,
               string promotionInfo,
               string deliveryInfo,
               int originPrice,
                string shortDescription,
       DateTime startDeal,
       DateTime endDeal,
       bool isDeal, int vatStatus, int instock)
        {
            var bOK = this._sqlDb.RunQuery(@"IF NOT EXISTS (SELECT ID FROM PRODUCT WHERE ID = @ID) 
                BEGIN Insert Into Product (Name, Id, ClassificationId, Price, Warranty, Company, LastUpdate, DetailUrl, ProductID, Summary, ProductContent, 
                NameFT, Valid, LastPriceChange, IsNews, HashName, PriceChange, AddPosition, VATInfo, PromotionInfo, DeliveryInfo, OriginPrice,
                IsDeal, StartDeal, EndDeal, ImageUrls, ShortDescription, Instock) Values 
                (@Name, @Id, @ClassificationId, @Price, @Warranty, @Company, GETDATE(), @DetailUrl, @ProductID, @Summary, @ProductContent, 
                @NameFT, @Valid, GETDATE(), @IsNews, @HashName, @PriceChange, @AddPosition, @VATInfo, @PromotionInfo, @DeliveryInfo, @OriginPrice,
                @IsDeal, @StartDeal, @EndDeal, @ImageUrls, @ShortDescription, @Instock) END"
                 , System.Data.CommandType.Text
                 , new SqlParameter[]{
                    _sqlDb.CreateParamteter("Name",name,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("Id",id,System.Data.SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("ClassificationId", classificationId,System.Data.SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("Price",price,System.Data.SqlDbType.Int),
                    _sqlDb.CreateParamteter("Warranty",warranty,System.Data.SqlDbType.Int),
                    _sqlDb.CreateParamteter("Instock",instock,System.Data.SqlDbType.Int),
                    _sqlDb.CreateParamteter("ImageUrls",imageUrls,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("Company",company,System.Data.SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("DetailUrl",detailUrl,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("ProductID",productId,System.Data.SqlDbType.Int),
                    _sqlDb.CreateParamteter("Summary",summary,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("ProductContent",productContent,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("NameFT",nameFt,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("Valid",false,System.Data.SqlDbType.Bit), //Khi Insert sản phẩm vào chưa cho hiện lên.
                    _sqlDb.CreateParamteter("IsNews",true,System.Data.SqlDbType.Bit),
                    _sqlDb.CreateParamteter("HashName",hashName,System.Data.SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("PriceChange",priceChange,System.Data.SqlDbType.Int),
                    _sqlDb.CreateParamteter("AddPosition",addPosition,System.Data.SqlDbType.Int),
                    _sqlDb.CreateParamteter("VATInfo",vatInfo,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("PromotionInfo",promotionInfo,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("DeliveryInfo",deliveryInfo,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("ShortDescription",shortDescription,System.Data.SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("OriginPrice",originPrice,System.Data.SqlDbType.Int),
                    _sqlDb.CreateParamteter("StartDeal",(startDeal==SqlDb.MinDateDb)?DBNull.Value:(object)startDeal,System.Data.SqlDbType.DateTime),
                    _sqlDb.CreateParamteter("EndDeal",(endDeal==SqlDb.MinDateDb)?DBNull.Value:(object)endDeal,System.Data.SqlDbType.DateTime),
                    _sqlDb.CreateParamteter("IsDeal",isDeal,System.Data.SqlDbType.Bit),
                    _sqlDb.CreateParamteter("VATStatus",vatStatus,System.Data.SqlDbType.Int),
                });
            return bOK;
        }

        public bool DeleteProduct(long Id)
        {
            return _sqlDb.RunQuery("delete product where id = @id", CommandType.Text,
                new SqlParameter[] { SqlDb.CreateParamteterSQL("id", Id, SqlDbType.BigInt) });
        }

        public bool InsertProduct(ProductEntity pt)
        {
            if (pt.IdCategories > 0)
                this.UpsertCategory(pt.IdCategories, Common.ConvertToString(pt.Categories, "->"),
                    pt.CompanyId);
            return _sqlDb.RunQuery(@"IF NOT EXISTS (SELECT ID FROM PRODUCT WHERE ID = @ID) 
                BEGIN Insert Into Product (Name, Id, ClassificationId, Price, Warranty, Company, LastUpdate, DetailUrl, Summary, ProductContent, 
                NameFT, Valid, LastPriceChange, IsNews, HashName, PriceChange, AddPosition, VATInfo, PromotionInfo, DeliveryInfo, OriginPrice,
                IsDeal, StartDeal, EndDeal, ImageUrls, ShortDescription, Instock, VatStatus) Values 
                (@Name, @Id, @ClassificationId, @Price, @Warranty, @Company, GETDATE(), @DetailUrl, @Summary, @ProductContent, 
                @NameFT, @Valid, GETDATE(), @IsNews, @HashName, @PriceChange, @AddPosition, @VATInfo, @PromotionInfo, @DeliveryInfo, @OriginPrice,
                @IsDeal, @StartDeal, @EndDeal, @ImageUrls, @ShortDescription, @Instock, @VatStatus) END"
                , CommandType.Text
                , new SqlParameter[]
                {
                    _sqlDb.CreateParamteter("Name", pt.Name, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("Id", pt.ID, SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("ClassificationId", pt.IdCategories, SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("Price", pt.Price, SqlDbType.Int),
                    _sqlDb.CreateParamteter("Warranty", pt.Warranty, SqlDbType.Int),
                    _sqlDb.CreateParamteter("Instock", pt.Instock, SqlDbType.Int),
                    _sqlDb.CreateParamteter("ImageUrls", pt.ImageUrl, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("Company", pt.CompanyId, SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("DetailUrl", pt.DetailUrl, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("Summary", pt.Summary, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("ProductContent", pt.ProductContent, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("NameFT",pt.NameFT,SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("Valid", false, SqlDbType.Bit),
                    _sqlDb.CreateParamteter("IsNews", true, SqlDbType.Bit),
                    _sqlDb.CreateParamteter("HashName", pt.HashName, SqlDbType.BigInt),
                    _sqlDb.CreateParamteter("PriceChange", 0, SqlDbType.Int),
                    _sqlDb.CreateParamteter("AddPosition", pt.AddPosition, SqlDbType.Int),
                    _sqlDb.CreateParamteter("VATInfo", pt.VatInfo, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("PromotionInfo", pt.PromotionInfo, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("DeliveryInfo", pt.DeliveryInfo, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("ShortDescription", pt.ShortDescription, SqlDbType.NVarChar),
                    _sqlDb.CreateParamteter("OriginPrice", pt.OriginPrice, SqlDbType.Int),
                    _sqlDb.CreateParamteter("StartDeal",
                        (pt.StartDeal == SqlDb.MinDateDb) ? DBNull.Value : (object) pt.StartDeal, SqlDbType.DateTime),
                    _sqlDb.CreateParamteter("EndDeal",
                        (pt.EndDeal == SqlDb.MinDateDb) ? DBNull.Value : (object) pt.EndDeal, SqlDbType.DateTime),
                    _sqlDb.CreateParamteter("IsDeal", pt.IsDeal, SqlDbType.Bit),
                    _sqlDb.CreateParamteter("VATStatus", pt.VATStatus, SqlDbType.Int),
                });

             this._sqlDb.RunQuery("prc_Product_AutoFindCategoryID", CommandType.StoredProcedure, new SqlParameter[] {SqlDb.CreateParamteterSQL("@ProductID", pt.ID, SqlDbType.BigInt)});

        }

        public void AutoFindCategoryID(long p)
        {
            this._sqlDb.RunQuery("EXEC prc_Product_AutoFindCategoryID @ProductID", System.Data.CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("ProductID",p,System.Data.SqlDbType.BigInt)
                });
        }

        public void UpsertCategory(long category_id, string name, long IDCompany)
        {
            this._sqlDb.RunQuery(@"IF not exists (select top 1 ID from classification where id = @id) 
            begin Insert Into Classification (Id, Name, IDCompany) values (@Id, @Name, @IDCompany) end
            else begin update Classification set IDCompany = @IDCompany, Name = @Name Where Id = @Id end", System.Data.CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@Id",category_id,System.Data.SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("@Name",name,System.Data.SqlDbType.NVarChar),
                    SqlDb.CreateParamteterSQL("@IDCompany", IDCompany, System.Data.SqlDbType.BigInt)
                });
        }


        public System.Data.DataTable GetListCompanyNeedRecrawler(string p)
        {
            return this._sqlDb.GetTblData(p, System.Data.CommandType.Text, null);
        }

        public void UpdateLastPushForCompany(long CompanyID, int typeCrawler)
        {
            if (typeCrawler == 0)
            {
                this._sqlDb.RunQuery("update company set LastCrawlerFindNew = GetDate(), IsStopCrawlerImediate = 0 Where ID = @ID", System.Data.CommandType.Text,
                    new SqlParameter[]{
               SqlDb.CreateParamteterSQL("ID",CompanyID,System.Data.SqlDbType.BigInt)
               });
            }
            else if (typeCrawler == 1)
            {
                this._sqlDb.RunQuery("update company set LastCrawlerReload = GetDate() Where ID = @ID", System.Data.CommandType.Text,
                 new SqlParameter[]{
               SqlDb.CreateParamteterSQL("ID",CompanyID,System.Data.SqlDbType.BigInt)
               });
            }
        }

        /// <summary>
        /// Cập nhật kết thúc Crawler dữ liệu.
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="iTypeCrawler"></param>
        public void UpdateLastEndForCompany(long CompanyID, int iTypeCrawler, string Note = "")
        {
            if (iTypeCrawler == 0)
            {
                this._sqlDb.RunQuery("update company set LastEndCrawlerFindNew = GetDate(), IsStopCrawlerImediate = 0 Where ID = @ID", System.Data.CommandType.Text,
                    new SqlParameter[]{
               SqlDb.CreateParamteterSQL("ID",CompanyID,System.Data.SqlDbType.BigInt)
               });

                this._sqlDb.RunQuery("[prc_UpdateCountProductForCompany_151221]", CommandType.StoredProcedure, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("TypeCrawler",0,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("Note",Note,SqlDbType.NVarChar)
                });
            }
            else if (iTypeCrawler == 1)
            {
                this._sqlDb.RunQuery("update company set LastEndCrawlerReload = GetDate() Where ID = @ID", System.Data.CommandType.Text,
                    new SqlParameter[]{
               SqlDb.CreateParamteterSQL("ID",CompanyID,System.Data.SqlDbType.BigInt)});

                this._sqlDb.RunQuery("[prc_UpdateCountProductForCompany_151221]", CommandType.StoredProcedure, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("TypeCrawler",1,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("Note",Note,SqlDbType.NVarChar)
                });
            }
            //PushQueueIndexCompany(CompanyID);
        }

        public bool CheckIsRunningCrawler(long CompanyId)
        {

            bool b = Convert.ToBoolean(this._sqlDb.GetTblData("select a = dbo.func_check_company_is_crawling(@CompanyId)", System.Data.CommandType.Text,
                new SqlParameter[]{
               SqlDb.CreateParamteterSQL("CompanyId", CompanyId, System.Data.SqlDbType.BigInt)
               }).Rows[0][0]);
            return b;
        }

        public void UpdateStateIsCloseImediate(long CompanyId, bool IsStopCrawlerImediate)
        {
            this._sqlDb.RunQuery("update Company set IsStopCrawlerImediate = @IsStopCrawlerImediate where ID = @CompanyId", System.Data.CommandType.Text, new SqlParameter[]
                {
                    SqlDb.CreateParamteterSQL("IsStopCrawlerImediate",IsStopCrawlerImediate,System.Data.SqlDbType.Bit),
                    SqlDb.CreateParamteterSQL("CompanyId",CompanyId,System.Data.SqlDbType.BigInt)
                });
        }

        public void InsertErrorCrawler(long company, string p)
        {
            this._sqlDb.RunQuery("insert into CompanyErrrorCrawler (ComanyId, Error) values (@CompanyId, @Error)", System.Data.CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("CompanyId",company,System.Data.SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("Error",p,System.Data.SqlDbType.NVarChar)
                });
        }



        public System.Data.DataTable GetTblCompanyNeedFix()
        {
            return this._sqlDb.GetTblData(@"select top 1000 ID, Website
                                            from company 
                                            where ([StatusLive] is null
                                             or  [StatusLive] = 0)
                                            and ID > 0
                                            and ISNULL(DataFeedUrl, '')=''
                                            and Website not like '%http%'");
        }

        public void UpdateStateCheckValidCompany(long CompanyId, int StatusLive)
        {
            this._sqlDb.RunQuery("update company set StatusLive = @StatusLive where id = @id", System.Data.CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("id",CompanyId,System.Data.SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("StatusLive",StatusLive,System.Data.SqlDbType.Int)
           });
        }


        private static object objLockNeedReloadProduct = new object();
        public System.Data.DataTable GetNeedReloadProduct(long _idCongTy, DateTime dateTime)
        {
            lock (objLockNeedReloadProduct)
            {
                DataTable tbl = null;
                {
                    tbl = this._sqlDb.GetTblData("[prc_Product_GetNeedReloadByCompany]",
                   System.Data.CommandType.StoredProcedure, new SqlParameter[]{
                        SqlDb.CreateParamteterSQL("CompanyId",_idCongTy,System.Data.SqlDbType.BigInt),
                        SqlDb.CreateParamteterSQL("DateCheck",dateTime,System.Data.SqlDbType.DateTime)
                        });

                }
                return tbl;
            }
        }


        private static Object thisLock = new object();
        public System.Data.DataTable GetNeedReloadProductRL(long _idCongTy, DateTime dateTime)
        {
            DataTable tbl = null;
            lock (thisLock)
            {
                do
                {
                    tbl = this._sqlDb.GetTblData("prc_Product_GetNeedReloadForCompany",
                                System.Data.CommandType.StoredProcedure, new SqlParameter[]{
                        SqlDb.CreateParamteterSQL("CompanyId",_idCongTy,System.Data.SqlDbType.BigInt),
                        SqlDb.CreateParamteterSQL("DateCheck",dateTime,System.Data.SqlDbType.DateTime),
                        SqlDb.CreateParamteterSQL("UpdateLastUpdate",true,SqlDbType.Bit)
                        }, null, true, 1000);
                }
                while (tbl == null);
            }
            return tbl;
        }

        public void UpdateValidProduct(long ProductId, bool Valid)
        {
            this._sqlDb.RunQuery("Update Product Set Valid = @Valid, LastUpdate =GETDATE() Where Id = @ProductId", System.Data.CommandType.Text,
               new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("ProductId",ProductId,System.Data.SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("Valid",Valid,System.Data.SqlDbType.Bit)
                });
        }

        public System.Data.DataTable GetListHashCompanyID()
        {
            return this._sqlDb.GetTblData("select top 500  ID, Domain from company where Status = 1 And LastSyncHashNameToRedis is null and ID>0");
        }

        public System.Data.DataTable GetListCompanyIDToPush()
        {
            return this._sqlDb.GetTblData("select top 100  ID, Domain from company where LastSyncProductToRedis is null and ID>0");
        }

        public System.Data.DataTable GetTblProductPushRedisForCompany(long CompanyID, int page)
        {
            return this._sqlDb.GetTblData("select ID, Price, Valid, Name, Company, Status, IsDeal from product where company = @companyId order by ID OFFSET @page * 10000  ROWS FETCH NEXT 10000 ROWS only", System.Data.CommandType.Text,
                new SqlParameter[]{
                   SqlDb.CreateParamteterSQL("CompanyID",CompanyID,System.Data.SqlDbType.BigInt),
                   SqlDb.CreateParamteterSQL("page",page,System.Data.SqlDbType.Int)
                });
        }

        public System.Data.DataTable GetTblProductHashPushRedisForCompany(long CompanyID, int page)
        {
            return this._sqlDb.GetTblData("select ID, Name, Price, ImageUrls from product where company = @companyId and (Valid = 1 or IsNews = 1) order by ID OFFSET @page * 10000  ROWS FETCH NEXT 10000 ROWS only", System.Data.CommandType.Text,
                new SqlParameter[]{
                   SqlDb.CreateParamteterSQL("CompanyID",CompanyID,System.Data.SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("page",page,System.Data.SqlDbType.Int)
                });
        }


        public void UpdateLastSyncClassificationRedisForCompany(long companyID)
        {
            this._sqlDb.RunQuery("update company set [LastSyncClassificationToRedis] = GETDATE () WHERE ID = @CompanyID",
                System.Data.CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("CompanyID",companyID,System.Data.SqlDbType.BigInt)
                });
        }

        public void UpdateLastSyncProductRedisForCompany(long companyID)
        {
            this._sqlDb.RunQuery("update company set LastSyncProductToRedis = GETDATE () WHERE ID = @CompanyID",
                System.Data.CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("CompanyID",companyID,System.Data.SqlDbType.BigInt)
                });
        }



        public System.Data.DataTable GetListCompanySynClassification()
        {
            return this._sqlDb.GetTblData("select top 100  ID, Domain from company where LastSyncClassificationToRedis is null and status = 1");
        }

        public System.Data.DataTable GetTblClassificationPushRedisForCompany(long companyID)
        {
            return this._sqlDb.GetTblData("select ID From Classification Where IDCompany = @CompanyId",
                System.Data.CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("CompanyId",companyID,System.Data.SqlDbType.BigInt)
                });
        }



        public void UpdateLastSyncProductHashRedisForCompany(long companyID)
        {
            this._sqlDb.RunQuery("update company set LastSyncHashNameToRedis = GETDATE () WHERE ID = @CompanyID",
                System.Data.CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("CompanyID",companyID,System.Data.SqlDbType.BigInt)
                });
        }

        public void SyncToCache(long ProductID)
        {

            //Đồng họa 1 bản ghi Product lên Redis.
            DataTable tblData = this._sqlDb.GetTblData(@"select a.ID, a.Price, a.Valid, a.Name, a.HashName, a.Status, a.ImageUrls, ISNULL(b.PercentVAT, 0)  AS PercentVAT, c.Domain
                                                        From Product a
                                                        Inner Join Company c on a.Company = c.Id
                                                        Left Join ListClassification b on a.CategoryID = b.Id
                                                        Where a.Id = @Id ", CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("Id",ProductID,SqlDbType.BigInt)
                });

            if (tblData.Rows.Count == 1)
            {
                var rowProduct = tblData.Rows[0];
                string ProductName = Common.Obj2String(rowProduct["Name"]);
                string ImageUrls = Common.Obj2String(rowProduct["ImageUrls"]);
                int ProductPrice = Common.Obj2Int(rowProduct["Price"]);
                long ID = Common.Obj2Int64(rowProduct["ID"]);
                bool Valid = Common.Obj2Bool(rowProduct["Valid"]);
                long Hashname = Common.Obj2Int64(rowProduct["HashName"]);
                int Status = Common.Obj2Int(rowProduct["Status"]);
                int PercentVAT = Common.Obj2Int(rowProduct["PercentVAT"]);
                string Domain = Common.Obj2String(rowProduct["Domain"]);
                string FullNameHast = Domain + "_" + ProductName + "_" + ProductPrice.ToString() + "_" + ImageUrls;

                RedisCacheProductInfo.Instance().SyncProductInfoToRedis(new Product()
                {
                    ID = ID,
                    Valid = Valid,
                    Price = ProductPrice,
                    HashName = Hashname,
                    Status = (Common.ProductStatus)Status,
                    ImageUrls = new List<string> { ImageUrls },
                    Name = ProductName,
                    Domain = Domain
                });
            }
        }



        public bool CheckIsUseDataFeed(long p)
        {
            return this._sqlDb.GetTblData("select Id from company where ISNULL(DataFeedType,0)<>0 and id = @CompanyId", CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@CompanyId",p,SqlDbType.BigInt)
                }).Rows.Count > 0;
        }

        public bool CheckAllowCrawler(long companyId)
        {
            return QT.Entities.Common.Obj2Bool(_sqlDb.GetTblData("select a= dbo.func_b_Company_AllowCrawler(@CompanyID)",
                   CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@CompanyID",companyId,SqlDbType.BigInt)
                }, null, true).Rows[0][0]);
        }

        public bool AllowCrawlReload(long companyId)
        {
            return Common.Obj2Bool(_sqlDb.GetTblData("select a= dbo.func_b_Company_AllowCrawlerReload(@CompanyID)",
                  CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@CompanyID",companyId,SqlDbType.BigInt)
                }, null, true).Rows[0][0]);
        }

        public bool AllowCrawlFindNew(long companyId)
        {
            return QT.Entities.Common.Obj2Bool(_sqlDb.GetTblData("select a= dbo.func_b_Company_AllowCrawlerFindNew(@CompanyID)",
                  CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@CompanyID",companyId,SqlDbType.BigInt)
                }, null, true).Rows[0][0]);
        }

        private bool CheckVisibleProductForComany(long p)
        {
            DataTable tbl01 = this._sqlDb.GetTblData("select IsNull(NotVisibleProduct,0) as NotVisibleProduct from company where id = @id"
                , CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("id",p,SqlDbType.BigInt)
                });
            return !Convert.ToBoolean(tbl01.Rows[0][0]);
        }

        public DateTime LastJobCrawlerFindNew(long CompanyID)
        {
            DateTime dtCurrent = Convert.ToDateTime(this._sqlDb.GetTblData("update company set LastJobCrawlerFindNew = getdate(), IsStopCrawlerImediate = 0 where id = @CompanyID; select a = getdate()", CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)
                }).Rows[0][0]);
            return dtCurrent;
        }


        public DateTime UpdateLastJobForDb(long CompanyID, bool CloseConnect = true)
        {
            DateTime dtCurrent = Convert.ToDateTime(this._sqlDb.GetTblData("update company set LastJobCrawlerReload = getdate() where id = @CompanyID; select a = getdate()", CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)
                }).Rows[0][0]);
            this._sqlDb.connection.Close();
            return dtCurrent;
        }

        public bool CheckIsRunningCrawler(TaskCrawlerCompany task)
        {
            DataTable tbl = this._sqlDb.GetTblData(@"select ISNULL(IsStopCrawlerImediate,0) AS IsStopCrawlerImediate, IsNull(LastJobCrawlerFindNew,'2010-10-10 10:10') as LastJobCrawlerFindNew, 
            IsNull(LastJobCrawlerReload,'2010-10-10 10:10') as LastJobCrawlerReload, GetDate() as CurrentDate from company where id = @CompanyId", CommandType.Text, new SqlParameter[]                                                                                                                                              {
            SqlDb.CreateParamteterSQL("CompanyId",task.IdCompany,SqlDbType.BigInt)                                                                                   });
            if (task.iType == 0)
            {
                if (Convert.ToInt32(tbl.Rows[0]["IsStopCrawlerImediate"]) == 1) return false;
                return (Convert.ToDateTime(tbl.Rows[0]["CurrentDate"]) - Convert.ToDateTime(tbl.Rows[0]["LastJobCrawlerFindNew"])).TotalMinutes < 120;
            }
            else if (task.iType == 1) return (Convert.ToDateTime(tbl.Rows[0]["CurrentDate"]) - Convert.ToDateTime(tbl.Rows[0]["LastJobCrawlerReload"])).TotalMinutes < 120;
            return true;
        }

        public void SyncClassificationDbToRedis(long ClassificationID)
        {

        }

        public void UpdateLastUpdate(long ProductID)
        {
            this._sqlDb.RunQuery("update product set LastUpdate = GetDate() where ID = @ID", CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("ID",ProductID,SqlDbType.BigInt)
                });
        }

        public DataTable GetCompanyNeedReload()
        {
            return this._sqlDb.GetTblData("prc_Company_GetNeedCrawlerReload", CommandType.StoredProcedure, new SqlParameter[] { });
        }

        public DataTable GetCompanyNeedReload(long CompanyID)
        {
            return this._sqlDb.GetTblData("Select Domain, ID, GETDATE() AS CurrentDate From Company Where ID = @ID", CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("ID",CompanyID,SqlDbType.BigInt)
                });
        }
        public DataTable GetCompanyNeedFindNew()
        {
            return this._sqlDb.GetTblData("prc_Company_GetNeedCrawlerFindNew", CommandType.StoredProcedure,
                new SqlParameter[]{
                });
        }

        public DataTable GetCompanyNeedCrawler(int p)
        {
            if (p == 0) return this.GetCompanyNeedFindNew();
            else return this.GetCompanyNeedReload();
        }

        public DataTable GetCompanyNeedCrawler(string procedure, CommandType commandType)
        {
            while (true)
            {
                Thread.Sleep(DateTime.Now.Second);
                DataTable tbl = this._sqlDb.GetTblData(procedure, commandType, new SqlParameter[] { }, null, false, 5);
                if (tbl != null && tbl.Rows.Count > 0)
                {
                    return tbl;
                }
                else
                {
                    _log.Error("Not find company need crawler!=> Wait 5'");
                    Thread.Sleep(300000);
                }
            }
        }


    
        public bool InsertProduct(Product product)
        {
            if (product.IDCategories > 0)
                this.UpsertCategory(product.IDCategories, Common.ConvertToString(product.Categories, "->"),
                    product.IDCongTy);
            bool bOK = InsertToSQLDB(
                product.ID,
                product.Name,
                product.IDCategories,
                product.Price,
                product.Warranty,
                product.ImageUrl,
                product.IDCongTy,
                product.DetailUrl,
                0,
                product.Promotion,
                product.Summary,
                product.ProductContent,
                Common.UnicodeToKoDauFulltext(product.Name + " " + product.Domain),
                product.HashName, 0, 0, product.VATInfo
                , product.PromotionInfo
                , product.DeliveryInfo
                , product.OriginPrice, product.ShortDescription
                , product.StartDeal
                , product.EndDeal
                , product.IsDeal
                , product.VATStatus, Convert.ToInt32(product.Instock));
            return bOK;
        }

        public bool InsertProductToDb(Product _product)
        {
            try
            {
                if (_product.IDCategories > 0) this.UpsertCategory(_product.IDCategories, Common.ConvertToString(_product.Categories, "->"), _product.IDCongTy);
            }
            catch (Exception ex1)
            {
                _log.ErrorFormat(ex1.Message);
            }
            return InsertToSQLDB(
                     _product.ID,
                     _product.Name,
                     _product.IDCategories,
                     _product.Price,
                     _product.Warranty,
                     _product.ImageUrl,
                     _product.IDCongTy,
                     _product.DetailUrl,
                     0,
                     _product.Promotion,
                     _product.Summary,
                     _product.ProductContent,
                     Common.UnicodeToKoDauFulltext(_product.Name + " " + _product.Domain),
                     _product.HashName, 0, 0, _product.VATInfo
                     , _product.PromotionInfo
                     , _product.DeliveryInfo
                     , _product.OriginPrice, _product.ShortDescription
                     , _product.StartDeal
                     , _product.EndDeal
                     , _product.IsDeal
                     , _product.VATStatus, Convert.ToInt32(_product.Instock));
        }


        public bool InsertProductToDb(List<Product> _product)
        {
            foreach (var item in _product) this.InsertProductToDb(item);
            return true;

        }



        /// <summary>
        /// Push product to RabbitMQ to reload info in Solr.
        /// </summary>
        /// <param name="CompanyID"></param>
        public void PushQueueIndexCompany(long CompanyID)
        {
            try
            {
                var updateProductJob = new Websosanh.Core.JobServer.Job();
                updateProductJob.Data = BitConverter.GetBytes(CompanyID);
                int updateProductJobExpirationMS = 3600000;
                updateProductJobClient_PushCompany.PublishJob(updateProductJob, updateProductJobExpirationMS);
            }
            catch (Exception ex01)
            {
                _log.Error(string.Format("Error push job ChangeMainInfo to MQ:{0}.{1}", ex01.Message, ex01.StackTrace));
                Thread.Sleep(10000);
            }
        }

        public void PushQueueReloadCacheProductInfo(long CompanyID, string Domain)
        {
            throw new Exception("Not support by xuantrang");
            //try
            //{
            //    JobClient jobClientReloadCacheProductInfo = new JobClient("CacheCrawlerProduct", GroupType.Topic, "CacheCrawlerProduct.Refresh.ProductInfo.#", true, this.rabbitMQServer);
            //    QT.Entities.CrawlerProduct.RabbitMQ.MssRefreshCacheProductInfo mss = new Entities.CrawlerProduct.RabbitMQ.MssRefreshCacheProductInfo()
            //    {
            //        CompanyID = CompanyID,
            //        Domain = Domain
            //    };

            //    var updateProductJob = new Websosanh.Core.JobServer.Job();
            //    updateProductJob.Data = System.Text.Encoding.UTF8.GetBytes(mss.GetMss());
            //    int updateProductJobExpirationMS = 3600000;
            //    jobClientReloadCacheProductInfo.PublishJob(updateProductJob, updateProductJobExpirationMS);
            //}
            //catch (Exception ex01)
            //{
            //    _log.Error(string.Format("Error push job ChangeMainInfo to MQ:{0}.{1}", ex01.Message, ex01.StackTrace));
            //    Thread.Sleep(10000);
            //}
        }
       
      

        public bool UpdateNotShowProductForCompany(long CompanyID, bool IsShow)
        {
            bool bOK = this._sqlDb.RunQuery("prc_Company_SetSateNotShowProductOnWeb", CommandType.StoredProcedure, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("IsShow",IsShow,SqlDbType.Bit)
            });
            if (bOK)
            {
                ProductAdapter productAdapter = new ProductAdapter();
                productAdapter.PushQueueIndexCompany(CompanyID);
            }
            return bOK;
        }

        public DataTable GetListCompanyByStatus(int TypeCompany)
        {
            return this._sqlDb.GetTblData(@"  select IDCompany as id
  from [ManagerTypeRCompany]
  where IDType = @IDType ", CommandType.Text, new SqlParameter[] { new SqlParameter("IDType", TypeCompany) });
        }

       
        public void UpdateProductsChangeToDb(List<Product> lstProductChangeNeedUpdate)
        {
            foreach (Product _product in lstProductChangeNeedUpdate)
            {
                bool bOK = this.UpdateProduct(_product.Name,
                     _product.IDCategories,
                     _product.Price,
                     _product.Warranty,
                     (short)_product.Status,
                     _product.ImageUrl,
                     _product.IDCongTy,
                     DateTime.Now,
                     _product.DetailUrl,
                     _product.Promotion,
                     _product.Summary,
                     _product.ProductContent,
                     Common.UnicodeToKoDauFulltext(_product.Name + " " + _product.Domain),
                     DateTime.Now,
                      0,
                      0, _product.DeliveryInfo
                      , _product.OriginPrice
                      , _product.ID
                     , _product.VATInfo
                     , _product.PromotionInfo
                     , _product.ShortDescription
                     , _product.StartDeal
                     , _product.EndDeal
                     , _product.IsDeal, Convert.ToInt32(_product.Instock)
                     , _product.Valid, _product.VATStatus, _product.ProductDuplicate);
                
                if (_product.Valid == true && _product.IDCategories > 0)
                    this.UpsertCategory(_product.IDCategories, Common.ConvertToString(_product.Categories, "->"), _product.IDCongTy);
            }
            this._sqlDb.connection.Close();
        }

        public delegate void EventProcessProduct(ProductEntity pt);

       

        public void CloseConnect()
        {
            try
            {
                this._sqlDb.connection.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void UpdateCountProduct()
        {
            this._sqlDb.RunQuery("prc_UpdateCountProduct", CommandType.StoredProcedure, new SqlParameter[] { });
        }

      
        public void InsertListProduct(List<Product> lstInsertProduct)
        {
            foreach (Product product in lstInsertProduct)
            {
                this.InsertProduct(product);
            }
        }



        public DataTable GetCompanyCrawler(string domain = "")
        {
            if (domain == "")
            {
                return this._sqlDb.GetTblData("select ID, Domain From Company Where Status = 1 And DataFeedType = 0 ORDER BY ID");
            }
            else
            {
                return this._sqlDb.GetTblData("select ID, Domain From Company Where Status = 1 And DataFeedType = 0 And Domain = @Domain ORDER BY ID", CommandType.Text,
                    new SqlParameter[]{
                        SqlDb.CreateParamteterSQL("Domain",domain,SqlDbType.NVarChar)
                    });
            }
        }

       

        public DataTable GetTblPriceLog(int iFrom, int iTo)
        {
            return this._sqlDb.GetTblData("select * from Price_Logs where ID < @iTo And ID > @iFrom and DateUpdate>'2015-01-01'", CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@iTo",iTo,SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("@iFrom",iFrom,SqlDbType.BigInt),
                });
        }

        public void MapCatAndClassAutoForCompany(long CompanyID)
        {
            this._sqlDb.RunQuery("prc_Company_AutoMapClassificationAndCategory", CommandType.StoredProcedure, new SqlParameter[]
                {
                    SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)
                });
        }


        public DataTable GetProductByPage(int ID)
        {
            while (true)
            {
                DataTable tbl = this._sqlDb.GetTblData(@"SELECT ID, Price FROM (
             SELECT ROW_NUMBER() OVER(ORDER BY ID) AS NUMBER,
                    ID, Price From Product WHERE Price>0 AND ID > 2508326604886150573
               ) AS TBL
WHERE NUMBER BETWEEN ((@PageNumber - 1) * @RowspPage + 1) AND (@PageNumber * @RowspPage)
ORDER BY ID", CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("PageNumber",ID,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("RowspPage",10000,SqlDbType.Int),
            });
                if (tbl != null) return tbl;
                else Thread.Sleep(10000);
            }
        }
        internal int GetTblPriceLogCount()
        {
            return Convert.ToInt32(_sqlDb.GetTblData("select count(*) from Price_Logs", CommandType.Text, new SqlParameter[] { }).Rows[0][0]);
        }

        

        public void UpdateLastReloadCrawler(long CompanyID)
        {
            bool bOK = true;
            while (true)
            {
                bOK = this._sqlDb.RunQuery("Update Company Set LastCrawler = GetDate(), LastCrawlerReload = GetDate() Where Id = @Id", CommandType.Text,
                      new SqlParameter[] { SqlDb.CreateParamteterSQL("Id", CompanyID, SqlDbType.BigInt) });
                if (bOK == true) break;
                else Thread.Sleep(10000);
            }
        }



        public DateTime GetLastChangeOfProduct(long ProductID)
        {
            try
            {
                return Convert.ToDateTime(_sqlDb.GetTblData(string.Format("select lastupdate from product where id = {0}", ProductID), CommandType.Text, null).Rows[0][0]);
            }
            catch (Exception ex01)
            {
                return DateTime.Now;
            }
        }

        public void UpdateIsDealForCompany(long CompanyID)
        {
            _sqlDb.RunQuery("prc_Company_UpdateDealState", CommandType.StoredProcedure, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt)
            });
        }

        public void UpdateCompanyImediateStopReload(long CompanyID)
        {
            this._sqlDb.RunQuery("Update Company Set LastJobCrawlerReload = '2015-05-05 05:05' Where ID = @CompanyID", CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)
                });
        }

        public void UpdateLastCrawlerFindNew(long CompanyID)
        {
            while (true)
            {
                if (this._sqlDb.RunQuery("update company set LastCrawlerFindNew = getdate() where id = @CompanyID", CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt)})) return;
                else Thread.Sleep(10000);
            }
        }

        internal DataTable GetProductOfCompany(long CompanyID, int PageIndex)
        {
            return this._sqlDb.GetTblData("prc_Product_GetProductByCompany", CommandType.StoredProcedure, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("@PageIndex",PageIndex, SqlDbType.Int)}, null);
        }

        public void UpdateCompanyImediateStopFindNew(long CompanyID)
        {
            this._sqlDb.RunQuery("Update Company Set LastJobCrawlerFindNew = '2015-05-05 05:05' Where ID = @CompanyID", CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)
                }, true);
        }

        internal void UpdateToWaitFindNew(long p)
        {
            throw new NotImplementedException();
        }

        public long GetCompanyIDNeedReload()
        {
            return 6454450782341730;
        }

        internal DataTable GetProductIsNew(long CompanyID)
        {
            return this._sqlDb.GetTblData("Select Id From Product Where Company = @Company And IsNews = 1 And IsNull(IsBlackList,0)=0", CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@Company",CompanyID,SqlDbType.BigInt)
               }, null, true);
        }

        public object GetReportCrawlerHistory(long CompanyID)
        {
            return this._sqlDb.GetTblData("prc_Report_HistoryCrawlerByCompany", CommandType.StoredProcedure, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt)
            });
        }

        public void UpdateLastJobForCompany(long CompanyID, int TypeCrawler)
        {
            _sqlDb.RunQuery("Update Company_CurrentCrawler Set LastJobCrawlerReload = GetDate () Where CompanyID = @CompanyID", CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt)
                });
        }

        public void UpdateCountProductAfterCrawler(long CompanyID, DateTime dtStartCrawler, DateTime DateEnd, int TypeCrawler, string Note)
        {
            this._sqlDb.RunQuery("[prc_UpdateCountProductForCompany_151221]", CommandType.StoredProcedure, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("TypeCrawler",TypeCrawler,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("Note",Note,SqlDbType.NVarChar),
                    SqlDb.CreateParamteterSQL("DateStart",dtStartCrawler,SqlDbType.DateTime),
                    SqlDb.CreateParamteterSQL("DateEnd",DateEnd,SqlDbType.DateTime)
                });
        }

        internal DataTable GetProductFixImage(long CompanyID)
        {
            return _sqlDb.GetTblData("prc_Product_GetNeedFixImageByCompany", CommandType.StoredProcedure, new SqlParameter[]
               {
                   SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt)
               }, null, true, 10);
        }

        internal void UpdateImageForProduct(long ProductID, string newImage)
        {
            this._sqlDb.GetTblData("update Product set ImageUrls = @ImageUrls Where ID = @ID", CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("ID",ProductID,SqlDbType.BigInt),
                 SqlDb.CreateParamteterSQL("ImageUrls",newImage,SqlDbType.NVarChar),
            });
        }

        internal DataTable GetProductNotImageLInk(long CompanyID)
        {
            return this._sqlDb.GetTblData("Select Id From Product Where Company = @Company And IsNull(ImagePath,'')='' And IsNull(IsBlackList,0)=0", CommandType.Text,
                 new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@Company",CompanyID,SqlDbType.BigInt)
               }, null, true);
        }

        internal DataTable GetListErrorImageIsNew(long Company)
        {
            return this._sqlDb.GetTblData(@"select a.ID, a.Name, a.Price, a.ImageUrls, a.ImagePath, DetailUrl
                                            from Product a
                                            where 1=1
                                            and a.Company = @CompanyID
                                            and a.IsNews = 1
                                            and isnull(a.ImagePath,'') = ''", CommandType.Text, new SqlParameter[]{
                                SqlDb.CreateParamteterSQL("@CompanyID",Company,SqlDbType.BigInt)
                                });
        }

        internal void UpdateWaitFNCrawler(long id)
        {
            this._sqlDb.RunQuery("update Company set WaitCrawlerFindNew = 1 where id = @id", CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@id",id,SqlDbType.BigInt)
            }, false, 1);
        }

        public void UpdateWaitRLCrawler(long id)
        {
            this._sqlDb.RunQuery("update Company set WaitCrawlerReload = 1 where id = @id", CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@id",id,SqlDbType.BigInt)
            }, false, 1);
        }

        public DataTable GetCompanyCheckDupName()
        {
            return
               this._sqlDb.GetTblData("Select ID From Company Where Status = 1 And DataFeedType = 0");
        }

        internal DataTable GetProductNameValidOfCompany(long CompanyID)
        {
            return this._sqlDb.GetTblData("Select Name From Product Where Company = @CompanyID And Valid = 1", CommandType.Text,
                new SqlParameter[]{
                SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)
                });
        }

        internal void UpdateMaxDup(long CompanyID, int MaxDup, string ProductName)
        {
            this._sqlDb.RunQuery("update [Company_CheckDupName] SET TotalDuplicateMax = @TotalDuplicateMax, LastUpdate = GetDate(), ProductName= @ProductName Where CompanyID = @CompanyID",
                CommandType.Text, new SqlParameter[]{ SqlDb.CreateParamteterSQL("@CompanyID", CompanyID, SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("TotalDuplicateMax", MaxDup, SqlDbType.Int),
                SqlDb.CreateParamteterSQL("ProductName", ProductName, SqlDbType.NVarChar)
                });
        }

        internal DataTable GetListClassiicationToCheck()
        {
            return this._sqlDb.GetTblData(@" select a.ID, a.Name, a.ParentID, b.CheckData
  from ListClassification a
  left join ListClassification_Checked b on a.ID = b.ID", CommandType.Text,
                new SqlParameter[]{
                });
        }

        internal void SaveListClassifcation(long ID, bool Checked)
        {
            if (Checked)
            {
                this._sqlDb.RunQuery("IF NOT EXISTS (SELECT * FROM [ListClassification_Checked] WHERE ID = @ID) INSERT INTO [ListClassification_Checked] (ID) VALUES (@ID)"
                    , CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("ID",ID,SqlDbType.BigInt)});
            }
            else
            {
                this._sqlDb.RunQuery("Delete ListClassification_Checked Where ID = @ID"
                    , CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("ID",ID,SqlDbType.BigInt)});
            }
        }

        public DataTable GetCompanyForSetRatting()
        {
            return this._sqlDb.GetTblData("prc_ProductRatting_GetAll", CommandType.StoredProcedure, new SqlParameter[]{SqlDb.CreateParamteterSQL("UserName", 
                (QT.Users.User.UserName.ToLower()=="admin")?"":QT.Users.User.UserName ,SqlDbType.NVarChar)});
        }
        internal void InsertRatting(long p)
        {
            this._sqlDb.RunQuery("IF NOT EXISTS (Select CompanyID From Company_Ratting Where CompanyID = @CompanyID) Insert Into Company_Ratting (CompanyID) Values (@CompanyID)", CommandType.Text, new SqlParameter[]{
           SqlDb.CreateParamteterSQL("@CompanyID",p,SqlDbType.BigInt)
            });
        }

        internal void UpdateRattingProduct(long CompanyID, int Reputation, int BigStore, int Scandal
            , int Genuine, int Quanlity, int Attitude, int Delivery, int Guarantee, int Swap, int Price, int OldCustomer)
        {
            this._sqlDb.RunQuery(@"UPDATE [dbo].[Company_Ratting]
SET  [Reputation] = @Reputation
           ,[BigStore] = @BigStore
           ,[Scandal] = @Scandal
           ,[Genuine] = @Genuine
           ,[Quanlity] = @Quanlity
           ,[Attitude] = @Attitude
           ,[Delivery] = @Delivery
           ,[Guarantee] = @Guarantee
           ,[Swap] = @Swap
           ,[Price]= @Price, UserID = @UserID, OldCustomer=@OldCustomer WHERE  [CompanyID] = @CompanyID", CommandType.Text, new SqlParameter[]{
                                                                SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt),
                                                                SqlDb.CreateParamteterSQL("@Reputation",Reputation,SqlDbType.Int),
                                                                SqlDb.CreateParamteterSQL("@BigStore",BigStore,SqlDbType.Int),
                                                                SqlDb.CreateParamteterSQL("@Scandal",Scandal,SqlDbType.Int),
                                                                SqlDb.CreateParamteterSQL("@Genuine",Genuine,SqlDbType.Int),
                                                                SqlDb.CreateParamteterSQL("@Quanlity",Quanlity,SqlDbType.Int),
                                                                SqlDb.CreateParamteterSQL("@Attitude",Attitude,SqlDbType.Int),
                                                                SqlDb.CreateParamteterSQL("@Delivery",Delivery,SqlDbType.Int),
                                                                SqlDb.CreateParamteterSQL("@Guarantee",Guarantee,SqlDbType.Int),
                                                                SqlDb.CreateParamteterSQL("@Swap",Swap,SqlDbType.Int),
                                                                SqlDb.CreateParamteterSQL("@Price",Price,SqlDbType.Int),
                                                                SqlDb.CreateParamteterSQL("@UserID",QT.Entities.Server.UserID,SqlDbType.Int),
                                                                SqlDb.CreateParamteterSQL("@OldCustomer",OldCustomer,SqlDbType.Int)                                        
                                                                                                        });
        }

        internal DataTable GetProductToCheckUrlRegex(long CompanyID)
        {
            return this._sqlDb.GetTblData(@"  select id, DetailUrl
  from product where companyID = @CompanyID", CommandType.Text, new SqlParameter[]{
                                            SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)    
                                            });
        }

        internal void DeleteProduct(long CompanyID, string Domain, long p)
        {
            _sqlDb.RunQuery("delete product where id = @id", CommandType.Text, new SqlParameter[]{
            SqlDb.CreateParamteterSQL("id",p,SqlDbType.BigInt)});

        }

        public int DeleteProductFailRegex(string Domain)
        {
            return 0;
            //int countData = 0;
            //long CompanyID = thisn(Domain);
            //if (CompanyID == 0) return -1;
            //else
            //{
            //    QT.Entities.Configuration config = new Entities.Configuration(CompanyID);
            //    QT.Entities.Company company = new Entities.Company(CompanyID);
            //    DataTable tblProduct = this._sqlDb.GetTblData(@"select Valid, DetailUrl, Company, ID, Price, Name, ImageUrls From Product where Company = @CompanyID", CommandType.Text,
            //        new SqlParameter[]{
            //        SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)
            //    });
            //    foreach (DataRow rowInfo in tblProduct.Rows)
            //    {
            //        string DetailUrl = QT.Entities.Common.Obj2String(rowInfo["DetailUrl"]);
            //        long Price = QT.Entities.Common.Obj2Int64(rowInfo["Price"]);
            //        string Name = QT.Entities.Common.Obj2String(rowInfo["Name"]);
            //        string ImageUrl = QT.Entities.Common.Obj2String(rowInfo["ImageUrls"]);
            //        long ProductID = QT.Entities.Common.Obj2Int64(rowInfo["ID"]);
            //        bool Valid = QT.Entities.Common.Obj2Bool(rowInfo["Valid"]);
            //        if (!QT.Entities.Common.CheckRegex(DetailUrl, config.ProductUrlsRegex, config.NoVisitUrlRegex, false))
            //        {
            //            countData++;
            //            _sqlDb.RunQuery("delete product where id = @id", CommandType.Text, new SqlParameter[] { SqlDb.CreateParamteterSQL("id", ProductID, SqlDbType.BigInt) });
            //            RedisCacheProductInfo.Instance().DeleteProductCache(CompanyID, ProductID);
            //            long ProductCurrent = QT.Moduls.CrawlerProduct.Cache.RedisCheckDuplicateAdapter.Instace().GetProductIDOfHash(CompanyID, Product.GetHashDuplicate(Domain, Price, Name, ImageUrl));
            //            if (ProductCurrent == ProductID)
            //            {
            //                QT.Moduls.CrawlerProduct.Cache.RedisCheckDuplicateAdapter.Instace().SetCheckDuplicate(CompanyID, ProductID, Domain, Price, Name, ImageUrl, false);
            //            }
            //        }
            //    }
            //    return countData;
            //}
        }

        public long GetCompanyIDFromDomain(string Domain)
        {
           DataTable tbl =  this._sqlDb.GetTblData("Select ID  From Company Where Domain = @Domain", CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@Domain",Domain,SqlDbType.NVarChar)
            });
           if (tbl != null && tbl.Rows.Count > 0) return Convert.ToInt64(tbl.Rows[0]["ID"]);
           else return 0;
        }

        public int NoValidProductDuplicate(string Domain)
        {
            int CountDup = 0;
            Dictionary<long, List<long>> checkDuplicate = new Dictionary<long, List<long>>();

            long CompanyID = this.GetCompanyIDFromDomain(Domain);
            DataTable proTable = new DataTable();

            proTable = this._sqlDb.GetTblData(@"SELECT 50000 InStock,  ID, ClassificationID, Status, Valid, Price, Name, ImageUrls, IsDeal, IsNews
FROM            Product
WHERE        (Company = @CompanyID)  AND Valid = 1
ORDER BY ID"
                , CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)}, null, true);
            for (int j = 0; j < proTable.Rows.Count; j++)
            {
                    long ProductID = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["ID"].ToString());
                    int InStock = QT.Entities.Common.Obj2Int(proTable.Rows[j]["InStock"].ToString());
                    bool Valid = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["Valid"].ToString());
                    long Price = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["Price"].ToString());
                    string Name = QT.Entities.Common.Obj2String(proTable.Rows[j]["Name"].ToString());
                    bool IsNew = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["IsNews"]);
                    string ImageUrl = proTable.Rows[j]["ImageUrls"].ToString();
                    bool IsDeal = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["IsDeal"].ToString());
                    long CategoryID = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["ClassificationID"].ToString());
                    long DupCheck = Product.GetHashDuplicate(Domain, Price, Name, ImageUrl);

                    if (!checkDuplicate.ContainsKey(DupCheck)) checkDuplicate.Add(DupCheck, new List<long>());
                    checkDuplicate[DupCheck].Add(ProductID);
            }

            foreach(var item in checkDuplicate)
            {
                if (item.Value.Count>1)
                {
                    List<long> lstProductDup = item.Value;
                    for(int i=1;i<lstProductDup.Count;i++)
                    {
                        CountDup++;
                        this.SetDuplicateForProduct(lstProductDup[i], lstProductDup[0]);
                    }
                }
            }

            return CountDup;
        }

        private void SetDuplicateForProduct(long ProductDup, long ProductValid)
        {
            this._sqlDb.RunQuery("update product set Valid = 0, IsBlackList = 1 , ProductDuplicate = @ProductValid where id = @ProductDup", CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("ProductDup",ProductDup,SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("ProductValid",ProductValid,SqlDbType.BigInt),
            });
        }

        public void UpdateEndCrawl(long companyId, int typeCrawler, DateTime startAt, DateTime endAt, int countLink, int countVisited, int countProduct, int countChange, string session, int totalProduct, string ip, string domain)
        {
            if (typeCrawler == 1)
            {
                bool bOK = this._sqlDb.RunQuery(@"insert into Company_TrackCrawler (CompanyID, TypeCrawler, StartAt, EndAt, CountLink, CountVisited, CountProduct, CountChange, session, TotalProduct, IP, Domain) values 
            (@CompanyID, @TypeCrawler, @StartAt, @EndAt, @CountLink, @CountVisited, @CountProduct, @CountChange, @session, (select count(*) from product where company = @CompanyID), @IP,@Domain);
update company set 
LastEndCrawlerReload = getdate (),
LastCrawlerReload = @LastCrawlerReload,
TotalProduct = (select count(*) from product where company = @CompanyID)
where id = @CompanyID", CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@CompanyID",companyId,SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("@TypeCrawler",typeCrawler,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("@StartAt",startAt,SqlDbType.DateTime),
                SqlDb.CreateParamteterSQL("@EndAt",endAt,SqlDbType.DateTime),
                SqlDb.CreateParamteterSQL("@CountLink",countLink,SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("@CountVisited",countVisited,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("@CountProduct",countProduct,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("@CountChange",countChange,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("@Session",session,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@LastCrawlerReload",startAt,SqlDbType.DateTime),
                SqlDb.CreateParamteterSQL("@LastEndCrawlerReload",endAt,SqlDbType.DateTime),
                SqlDb.CreateParamteterSQL("@TotalProduct",totalProduct,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("@IP",ip,SqlDbType.VarChar),
                SqlDb.CreateParamteterSQL("@Domain",domain,SqlDbType.NVarChar)
                      });
            }
            else if (typeCrawler==0)
            {
                bool bOK = this._sqlDb.RunQuery(@"insert into Company_TrackCrawler (CompanyID, TypeCrawler, StartAt, EndAt, CountLink, CountVisited, CountProduct, CountChange, session, TotalProduct, IP,Domain) values 
            (@CompanyID, @TypeCrawler, @StartAt, @EndAt, @CountLink, @CountVisited, @CountProduct, @CountChange, @session, (select count(*) from product where company = @CompanyID), @IP,@Domain);
update company set LastEndCrawlerReload = getdate ()
, LastCrawlerFindNew = @LastCrawlerFindNew 
, LastEndCrawlerFindNew = @LastEndCrawlerFindNew
, TotalProduct = (select count(*) from product where company = @CompanyID)
where id = @CompanyID", CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@CompanyID",companyId,SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("@TypeCrawler",typeCrawler,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("@StartAt",startAt,SqlDbType.DateTime),
                SqlDb.CreateParamteterSQL("@EndAt",endAt,SqlDbType.DateTime),
                SqlDb.CreateParamteterSQL("@CountLink",countLink,SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("@CountVisited",countVisited,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("@CountProduct",countProduct,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("@CountChange",countChange,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("@Session",session,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@LastCrawlerFindNew",startAt,SqlDbType.DateTime),
                SqlDb.CreateParamteterSQL("@LastEndCrawlerFindNew",endAt,SqlDbType.DateTime),
                SqlDb.CreateParamteterSQL("@IP",ip,SqlDbType.VarChar),
                SqlDb.CreateParamteterSQL("@TotalProduct",totalProduct,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("@Domain",domain,SqlDbType.NVarChar)
                      });
            }
        }


        public bool UpdateEndCrawl(CrawlerSessionLog endSession)
        {
            return _sqlDb.RunQuery(@"
IF (@TypeCrawler=1)
    BEGIN
        UPDATE Company 
        SET
        LastEndCrawlerReload = @EndAt,
        LastCrawlerReload = @StartAt,
        TotalProduct = (select count(*) from product where company = @CompanyID),
        TotalValid = (select count(*) from product where company = @CompanyID and Valid = 1)
        where ID = @CompanyID
    END
ELSE
    BEGIN
        UPDATE Company 
        SET
        LastEndCrawlerFindNew = @EndAt,
        LastCrawlerFindNew = @StartAt,
        TotalProduct = (select count(*) from product where company = @CompanyID),
        TotalValid = (select count(*) from product where company = @CompanyID and Valid = 1)
        where ID = @CompanyID
    END

INSERT INTO Company_TrackCrawler 
    (CompanyID, TypeCrawler, StartAt, EndAt, CountLink, CountVisited, CountProduct, CountChange, session, TotalProduct, IP, Domain, TypeEnd, NumberDuplicates) 
VALUES 
    (@CompanyID, @TypeCrawler, @StartAt, @EndAt, @CountLink, @CountVisited, @CountProduct, @CountChange, @session, (select TotalProduct from Company where ID = @CompanyID), @IP,@Domain, @TypeEnd, @NumberDuplicates);

", CommandType.Text,
                new SqlParameter[]
                {
                    SqlDb.CreateParamteterSQL("@TypeRun", endSession.TypeRun, SqlDbType.NVarChar), SqlDb.CreateParamteterSQL("@CompanyID", endSession.CompanyId, SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("@TypeCrawler", endSession.TypeCrawler, SqlDbType.Int), 
                    SqlDb.CreateParamteterSQL("@StartAt", endSession.StartAt, SqlDbType.DateTime),
                    SqlDb.CreateParamteterSQL("@EndAt", endSession.EndAt, SqlDbType.DateTime), 
                    SqlDb.CreateParamteterSQL("@CountLink", 0, SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("@CountVisited", endSession.CountVisited, SqlDbType.Int), SqlDb.CreateParamteterSQL("@CountProduct", endSession.CountProduct, SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@CountChange", endSession.CountChange, SqlDbType.Int), SqlDb.CreateParamteterSQL("@Session", endSession.Session, SqlDbType.NVarChar),
                    SqlDb.CreateParamteterSQL("@LastCrawlerReload", endSession.StartAt, SqlDbType.DateTime), SqlDb.CreateParamteterSQL("@LastEndCrawlerReload", endSession.EndAt, SqlDbType.DateTime),
                    SqlDb.CreateParamteterSQL("@NumberDuplicates", endSession.NumberDuplicateProduct, SqlDbType.Int), SqlDb.CreateParamteterSQL("@IP", endSession.Ip, SqlDbType.VarChar),
                    SqlDb.CreateParamteterSQL("@Domain", string.IsNullOrEmpty(endSession.Domain) ? "" : endSession.Domain, SqlDbType.NVarChar),
                    SqlDb.CreateParamteterSQL("@TypeEnd", endSession.TypeEnd, SqlDbType.NVarChar)
                });
        }

        public void UpdateDuplicateProduct(Dictionary<long,long> productDuplicatedGroup)
        {
           if(productDuplicatedGroup.Count>0)
           {
               List<string> lstQUery = new List<string>();
               string query = "update product set isblacklist = 1, productduplicate = {0} where id={1}";
               foreach(var productDuplicate in productDuplicatedGroup)
               {
                   lstQUery.Add(string.Format(query, productDuplicate.Key, productDuplicate.Value));
                   this._sqlDb.RunQuery(QT.Entities.Common.ConvertToString(lstQUery, ";"), CommandType.Text, null);
               }
           }
        }

        public DataTable GetAllProductIDByCompany(long companyID)
        {
            var tbl = _sqlDb.GetTblData("select ID from product where company = @CompanyID", CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@CompanyID",companyID,SqlDbType.BigInt)
            });
            return tbl;
        }
        public HashSet<long> GetAllProductIDsByCompany(long companyID)
        {
            HashSet<long> lst = new HashSet<long>();
            DataTable tbl = _sqlDb.GetTblData("select ID from product where company = @CompanyID", CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@CompanyID",companyID,SqlDbType.BigInt)
            });
            if (tbl != null)
                foreach (DataRow rowInfo in tbl.Rows)
                    lst.Add(Convert.ToInt64(rowInfo["ID"]));
            return lst;
        }


        public long GetCompanyIdByDomain(string Domain)
        {
            long CompanyID = 0;
            DataTable tbl = _sqlDb.GetTblData("select ID from Company where  Domain = @Domain", CommandType.Text, new SqlParameter[] { 
                SqlDb.CreateParamteterSQL("@Domain",Domain,SqlDbType.NVarChar)
            });
            if (tbl.Rows.Count>0)
            {
                CompanyID = QT.Entities.Common.Obj2Int64(tbl.Rows[0]["ID"]);
                return CompanyID;
            }
            else
            {
                return 0;
            }
            
        }
        public List<long> GetAllCompanyIdCrawler()
        {
            DataTable tbl = this._sqlDb.GetTblData(
                "select id,Domain from company where status = 1 and datafeedtype = 0", CommandType.Text, null);
            List<long> lst = new List<long>();
            foreach (DataRow row in tbl.Rows) lst.Add(Convert.ToInt64(row["id"]));
            return lst;
        }

        public List<long> GetAllCompanyId()
        {
            DataTable tbl = this._sqlDb.GetTblData("select id,Domain from company where status = 1");
            List<long> lst = new List<long>();
            foreach (DataRow row in tbl.Rows) lst.Add(Convert.ToInt64(row["id"]));
            return lst;
        }

        public List<long> GetAllCompanyIdCrawlerHaveDescription()
        {
            DataTable tbl = this._sqlDb.GetTblData(@"
select a.id, a.Domain 
from company a 
	inner join Configuration b on a.ID = b.CompanyID
where 
a.status = 1 
and datafeedtype = 0
and isnull(ShortDescriptionXPath, '')!=''
"
                );
            List<long> lst = new List<long>();
            foreach (DataRow row in tbl.Rows) lst.Add(Convert.ToInt64(row["id"]));
            return lst;
        }

        public List<long> GetAllCompanyIdCrawlerFindNew()
        {
            DataTable tbl = this._sqlDb.GetTblData("select id from V_CompanyFindNew");
            List<long> lst = new List<long>();
            foreach (DataRow row in tbl.Rows) lst.Add(Convert.ToInt64(row["id"]));
            return lst;
        }

        public List<long> GetAllCompanyIdCrawlerReload()
        {
            DataTable tbl = this._sqlDb.GetTblData("select id from V_CompanyReload");
            List<long> lst = new List<long>();
            foreach (DataRow row in tbl.Rows) lst.Add(Convert.ToInt64(row["id"]));
            return lst;
        }



        public void DeleteBathProduct(List<long> productIdWaitDeleteGroup)
        {
            if (productIdWaitDeleteGroup.Count>0)
            {
                string preSql = "delete from product where id in ({0})";
                string queryProduct = string.Join(",", productIdWaitDeleteGroup);
                string queryData = string.Format(preSql, queryProduct);
                this._sqlDb.RunQuery(queryData, CommandType.Text, null);
            }
        }

        public List<long> GetListProductIdOfCompany(long companyID)
        {
            DataTable tbl = this._sqlDb.GetTblData("select id from product where company = @CompanyID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                            SqlDb.CreateParamteterSQL("@CompanyID",companyID,SqlDbType.BigInt)
                        });
            List<long> productIDs = new List<long>();
            foreach (DataRow rowInfo in tbl.Rows) productIDs.Add(Convert.ToInt64(rowInfo["id"]));
            return productIDs;
        }

        public void DeleteProductUnvalidOfCOmpany(long CompanyID)
        {
            this._sqlDb.RunQuery("prc_Product_DeleteUnvalidProductOverTime"
                , CommandType.StoredProcedure
                , new SqlParameter[]{SqlDb.CreateParamteterSQL("@company_id",CompanyID,SqlDbType.BigInt)
            });
        }

        public DataTable GetAllProductToReload(long CompanyID)
        {
            return this._sqlDb.GetTblData(@"SELECT ID, HashName, DetailUrl, ImageUrls, Price
FROM [Product]
WHERE Company = 1 ", CommandType.Text, new SqlParameter[]{
                   SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt)
                   });
        }

        public DataTable GetProductResetColumnDuplicateAndChange(long CompanyID)
        {
            DataTable tblProduct = _sqlDb.GetTblData(
@"
select ID,Price,Name,ImageUrls,InStock,Valid,IsDeal,ClassificationID,DetailUrl, ShortDescription, OriginPrice 
from Product 
where Company = @CompanyID", CommandType.Text, new SqlParameter[]{
                _sqlDb.CreateParamteter("@CompanyID",CompanyID,SqlDbType.BigInt)
            });
            return tblProduct;
        }

        public void UpdateData(long ProductID, long HashChange, long HashDuplicate)
        {
            this._sqlDb.RunQuery("update product set HashName = @HashName, ProductDUplicate = @ProductDuplicate where id = @id", CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("id",ProductID,SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("HashName",HashChange,SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("ProductDuplicate",HashDuplicate,SqlDbType.BigInt),
                });
        }

        public DataTable GetDescriptionData(long companyID)
        {
            return this._sqlDb.GetTblData("select ShortDescription from Product where Company = @CompanyID and IsNull(SHortDescription,'')<>''", CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@CompanyID",companyID,SqlDbType.BigInt)
            }, null, true, 1000);
        }

        public List<long> GetAllCompanyIdSystem()
        {
            DataTable tbl = this._sqlDb.GetTblData("select id,Domain from company where status = 1");
            List<long> lst = new List<long>();
            foreach (DataRow row in tbl.Rows) lst.Add(Convert.ToInt64(row["id"]));
            return lst;
        }

        public void UpdateCountProductForCompany(long companyID, int TotalProduct, int TotalValid)
        {
            this._sqlDb.RunQuery("update company set TotalProduct = @TotalProduct, TotalValid = @TotalValid, MaxValid = case when MaxValid < @TotalValid THEN @TotalValid ELSE MaxValid END WHERE Id = @CompanyID", CommandType.Text,
                new SqlParameter[] {
                    SqlDb.CreateParamteterSQL("@CompanyID",companyID,SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("@TotalProduct",TotalProduct,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@TotalValid",TotalValid,SqlDbType.Int)
                });
        }

        internal DataTable GetLinkTestCrawlerAllCompany()
        {
            DataTable tbl = this._sqlDb.GetTblData(@"
select a.Id, b.LinkAutoTest, a.Domain
from company a
inner join Configuration b on a.id = b.CompanyID
where 
status = 1 
and datafeedtype = 0
and isnull(b.LinkAutoTest,'') !=''
");
            return tbl;
        }

        public List<long> GetCOmpanyDownloadedHTML()
        {
            List<long> lst = new List<long>();
            foreach(DataRow item in this._sqlDb.GetTblData("select distinct (CompanyID) from Company_DownloadedHTML",CommandType.Text,null).Rows)
            {
                lst.Add(Convert.ToInt64(item["CompanyID"]));
            }
            return lst;
        }

        public List<string> GetEtraRegexByTypeWeb(long SourceType)
        {
            List<string> lst = new List<string>();
            DataTable tbl = this._sqlDb.GetTblData("select NoVisitRegex From Website_SourceType Where ID = @SourceType", CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@SourceType",SourceType,SqlDbType.BigInt)
                });
            if (tbl != null && tbl.Rows.Count > 0)
            {
                string strData = (tbl.Rows[0][0] != DBNull.Value) ? "" : tbl.Rows[0][0].ToString();
                lst.AddRange(strData.Split(';'));
            }
            return lst;
        }

        public List<long> GetCompanyIdsCheckBizweb()
        {
            DataTable tbl = _sqlDb.GetTblData(@"select a.ID, b.Website_SourceType
from Company a
inner join Configuration b on a.id = b.CompanyID
where a.DataFeedType = 0 
and a.Status = 1
and b.Website_SourceType != 1", CommandType.Text, null);
            List<long> lst = new List<long>();
            foreach (DataRow rowCompany in tbl.Rows) lst.Add(Convert.ToInt64(rowCompany["ID"]));
            return lst;
        }

        public void UpdateSourceWebType(List<long> lstCompanyCheckBizweb, int sourceType)
        {
            string queryPattern = "update configuration set website_SourceType = {0} where companyID = {1}";
            List<string> lstQuery = new List<string>();
            foreach(long companyID in lstCompanyCheckBizweb)
            {
                lstQuery.Add(string.Format(queryPattern, sourceType, companyID));
            }
            foreach(var arQuery in QT.Entities.Common.SplitArray<string>(lstQuery.ToArray(),20))
            {
                string queryAll = string.Join(";", arQuery);
                this._sqlDb.RunQuery(queryAll, CommandType.Text, null);
            }
            return;
        }

        internal DataTable GetTopLastChangeProduct(long companyID, int NumberProduct)
        {
            string query = @"
select top (@NumberProduct) a.Name, a.Price, a.DetailUrl, a.ImageUrls
from Product a
where 1=1
and a.Company = @CompanyID
and a.Valid = 1
and a.IsBlackList = 0 
ORDER BY LastUpdate DESC";
            return this._sqlDb.GetTblData(query, CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@CompanyID",companyID,SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("@NumberProduct",NumberProduct,SqlDbType.Int),
            });


        }

        public DataTable GetAllDataProduct(long companyId, int pageIndex)
        {
            return this._sqlDb.GetTblData(@"
SELECT * FROM (
             SELECT ROW_NUMBER() OVER(ORDER BY ID) AS NUMBER, ID, 
                    ClassificationID, Warranty, Promotion, Summary,ProductContent, VATInfo, DeliveryInfo, ShortDescription,Status, VATStatus   
            FROM Product
            WHERE Company = @CompanyID
               ) AS TBL
WHERE NUMBER BETWEEN ((@PageNumber - 1) * @RowspPage + 1) AND (@PageNumber * @RowspPage)
ORDER BY ID", CommandType.Text,
                new SqlParameter[] {
                SqlDb.CreateParamteterSQL("@CompanyID",companyId,SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("@PageNumber",pageIndex,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("@RowspPage",1000,SqlDbType.Int),
                });
        }

        public DataTable GetProductValidToFindDesc(long p)
        {
            return this._sqlDb.GetTblData("Select * from Product Where Company = @CompanyID"
                , CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@CompanyID",p,SqlDbType.BigInt)
               });
        }



        public void UpdateFieldReport(long companyId, int totalProduct, int warranty, int status, int promotion, int summary, int productContent, int vatInfo, int promotionInfo
            , int shortDescription, int instock, int startDeal, int endDeal, int deliveryInfo, int vatStatus)
        {
            _sqlDb.RunQuery(@"
            If not exists (Select CompanyID FROM Company_ReportFieldCrawler WHERE CompanyID = @CompanyID) 
            BEGIN
                INSERT Company_ReportFieldCrawler (CompanyID) VALUES (@CompanyID)
            END

                    UPDATE Company_ReportFieldCrawler
                    SET 
                      TotalProduct = @TotalProduct
                    , Warranty = @Warranty
                    , Status = @Status
                    , Promotion = @Promotion
                    , Summary = @Summary
                    , ProductContent = @ProductContent
                    , VATInfo = @VATInfo
                    , PromotionInfo = @PromotionInfo 
                    , ShortDescription = @ShortDescription
                    , Instock = @Instock
                    , StartDeal = @StartDeal
                    , EndDeal = @EndDeal
                    , TimeUpdate= GetDate()
                    , DeliveryInfo = @DeliveryInfo
                    , VATStatus = @VATStatus
                    WHERE COmpanyID = @CompanyID

", CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@CompanyID",companyId,SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("@TotalProduct",totalProduct,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@Warranty",warranty,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@Status",status,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@Promotion",promotion,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@Summary",summary,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@ProductContent",productContent,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@VATInfo",vatInfo,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@PromotionInfo",promotionInfo,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@ShortDescription",shortDescription,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@Instock",instock,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@StartDeal",startDeal,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@EndDeal",endDeal,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@DeliveryInfo",deliveryInfo,SqlDbType.Int),
                      SqlDb.CreateParamteterSQL("@VATStatus",vatStatus,SqlDbType.Int),
                });

        }

        public DataTable GetProductLinkPushDownloadHtml(long companyId, int page)
        {
            string strSql = @"SELECT ID, DetailUrl 
FROM dbo.Product
WHERE Company = @CompanyID 
ORDER BY ID 
OFFSET @PageSize * (@PageNumber - 1) ROWS
FETCH NEXT @PageSize ROWS ONLY;";
            return _sqlDb.GetTblData(strSql, CommandType.Text, new SqlParameter[]
            {
                SqlDb.CreateParamteterSQL("PageSize", 100, SqlDbType.Int),
                SqlDb.CreateParamteterSQL("PageNumber", page, SqlDbType.Int),
                SqlDb.CreateParamteterSQL("CompanyID", companyId, SqlDbType.BigInt)
            });

        }

        public Entities.DB.ReportCrawlerPropertiesDataTable GetReportTrackCrawlerProperties()
        {
            DataTable tblData = this._sqlDb.GetTblData("Select * From [V_Company_TrackCrawler]", CommandType.Text, null);
            Entities.DB.ReportCrawlerPropertiesDataTable tbl = new Entities.DB.ReportCrawlerPropertiesDataTable();

            foreach (DataColumn colOrigin in tblData.Columns)
            {
                Entities.DB.ReportCrawlerPropertiesRow row = tbl.NewRow() as Entities.DB.ReportCrawlerPropertiesRow;
                string rowName = colOrigin.ColumnName.Replace("x_", "").Replace("c_", "");
                if (tbl.FindByProperty(rowName) == null)
                {
                    row.Property = colOrigin.ColumnName.Replace("x_", "").Replace("c_", "");
                    row.CountCompanyConfiged = 0;
                    row.CountProductCrawlerd = 0;
                    tbl.Rows.Add(row);
                }
            }

            foreach (DataRow rowOrigin in tblData.Rows)
            {
                foreach (DataColumn col in tblData.Columns){
                    string parameter = col.ColumnName;
                    if (parameter.StartsWith("c_"))
                    {
                        string rowPrime = parameter.Replace("x_", "").Replace("c_", "");
                        tbl.FindByProperty(rowPrime).CountProductCrawlerd += QT.Entities.Common.Obj2Int(rowOrigin[col]);
                    }
                    else if (parameter.StartsWith("x_"))
                    {
                        string rowPrime = parameter.Replace("x_", "").Replace("c_", "");
                        tbl.FindByProperty(rowPrime).CountCompanyConfiged += QT.Entities.Common.Obj2Int(rowOrigin[col]);
                    }
                }
            }

            return tbl;
        }
    }
}
