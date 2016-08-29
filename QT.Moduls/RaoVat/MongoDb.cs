using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using QT.Entities.RaoVat;
using QT.Entities.Data;
using QT.Entities.Model.SaleNews;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace QT.Moduls.CrawlSale
{

    public class MySqlAdapterRaoVat
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(MySqlAdapterRaoVat));

        MySql.Data.MySqlClient.MySqlDataAdapter mySqlAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
        MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection("server=183.91.14.85;Port=3306;uid=root;pwd=123456a@;database=wssraovat;");

        public MySqlAdapterRaoVat()
        {

        }

        public Dictionary<int, string> GetDicTerms()
        {
            var dicResult = new Dictionary<int, string>();
            DataTable tblTerm = new DataTable();
            mySqlAdapter.SelectCommand = new MySql.Data.MySqlClient.MySqlCommand("SELECT id,name FROM terms", this.mySqlConnection);
            mySqlAdapter.Fill(tblTerm);

            foreach (DataRow row in tblTerm.Rows)
            {
                dicResult.Add(Convert.ToInt32(row["id"]), Convert.ToString(row["name"]));
            }
            return dicResult;
        }

        public Dictionary<int, string> GetDicCity()
        {
            var dicResult = new Dictionary<int, string>();
            DataTable tblTerm = new DataTable();
            mySqlAdapter.SelectCommand = new MySql.Data.MySqlClient.MySqlCommand("SELECT id, name FROM cities where level =1 ", this.mySqlConnection);
            mySqlAdapter.Fill(tblTerm);
            foreach (DataRow row in tblTerm.Rows)
            {
                dicResult.Add(Convert.ToInt32(row["id"]), Convert.ToString(row["name"]).ToLower());
            }
            return dicResult;
        }

        public DataTable GetTableCategories()
        {
            DataTable tblTerm = new DataTable();
            mySqlAdapter.SelectCommand = new MySql.Data.MySqlClient.MySqlCommand("SELECT id, name, slug, parent_id, path, level FROM categories", this.mySqlConnection);
            mySqlAdapter.Fill(tblTerm);
            return tblTerm;
        }

        public List<int> GetListPathOfCategory(int itemCat)
        {
            List<int> lst = new List<int>();
            DataTable tblTerm = new DataTable();
            mySqlAdapter.SelectCommand = new MySql.Data.MySqlClient.MySqlCommand(
                string.Format("SELECT id, name, slug, parent_id, path FROM categories where id = {0}", itemCat), this.mySqlConnection);
            mySqlAdapter.Fill(tblTerm);
            if (tblTerm.Rows.Count > 0)
            {
                string[] arpath = tblTerm.Rows[0]["path"].ToString().Split(new char[] { '-' }, 10, StringSplitOptions.RemoveEmptyEntries);
                foreach (var itemPar in arpath)
                {
                    int iCat = 0;
                    if (int.TryParse(itemPar, out iCat)) lst.Add(iCat);
                }
            }
            return lst;
        }


    }


    public class MongoDbRaoVat
    {
        public IMongoCollection<BsonDocument> colProduct;
        public IMongoCollection<BsonDocument> colHtml;
        public IMongoCollection<BsonDocument> colKeyWord;

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(MongoDbRaoVat));

        public async Task<long> UpdateWaitQuickReload()
        {
            //Kiểm tra số tin chờ Reload.
            int numberItem = 0;
            long a = this.colProduct.CountAsync("{'wait_quick_reload':true}", new CountOptions() { Limit = 1000, Skip = 0 }).Result;
            if (a < 1000)
            {
                var builder = Builders<BsonDocument>.Filter;
                var filterSerach = "{$and:[{'wait_quick_reload':false},{'status':1}]}";
                using (var cursor = await this.colProduct.FindAsync(filterSerach, new FindOptions<BsonDocument, BsonDocument>()
                {
                    Limit = 1000,
                    Sort = "{source_view_count:-1}"
                }))
                {
                    while (await cursor.MoveNextAsync())
                    {
                        var batch = cursor.Current;
                        foreach (var document in batch)
                        {
                            numberItem++;
                            await this.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", document["_id"]),
                             "{'wait_quick_reload':true}", new UpdateOptions() { IsUpsert = false });
                        }
                    }
                }
            }
            return numberItem;
        }

        public async Task<int> UpdateWaitQuickReload(string queryFilter)
        {
            int count = 0;
            var builder = Builders<BsonDocument>.Filter;
            var filterSerach = queryFilter;
            using (var cursor = await this.colProduct.FindAsync(filterSerach, new FindOptions<BsonDocument, BsonDocument>()
            {
                Limit = 100
            }))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        count++;
                        await this.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", document["_id"]),
                         "{'wait_quick_reload':true}", new UpdateOptions() { IsUpsert = false });
                    }
                }
            }
            return count;
        }

        public async Task<int> UpdateWaitQuickReload(string queryFilter, string updateQuery, int iLimit)
        {
            int count = 0;
            var builder = Builders<BsonDocument>.Filter;
            var filterSerach = queryFilter;
            var updateQuery1 = Builders<BsonDocument>.Update.Set("wait_quick_reload", true);
            using (var cursor = await this.colProduct.FindAsync(filterSerach, new FindOptions<BsonDocument, BsonDocument>()
            {
                Limit = iLimit
            }))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        count++;
                        await this.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", document["_id"])
                            , updateQuery1, new UpdateOptions() { IsUpsert = true });
                    }
                }
            }
            return count;
        }


        public MongoDbRaoVat()
        {
            var credentialFirst = MongoCredential.CreateMongoCRCredential("wssraovat", "wssraovat2", "wssraovat2123");
            MongoDB.Driver.IMongoDatabase database = (new MongoDB.Driver.MongoClient(new MongoDB.Driver.MongoClientSettings()
            {
                Server = new MongoDB.Driver.MongoServerAddress("183.91.14.85", 27017),
                Credentials = new[] { credentialFirst }
            })).GetDatabase("wssraovat");

            this.colKeyWord = database.GetCollection<BsonDocument>("keywords");
            this.colProduct = database.GetCollection<BsonDocument>("crawled_products");
            this.colHtml = database.GetCollection<BsonDocument>("crawled_html");


        }

        /// <summary>
        /// 0 - HTML DB
        /// 1. Product DB
        /// </summary>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <param name="iDB"></param>
        /// <returns></returns>
        public async Task<List<BsonDocument>> GetListExtractKeyWord(string query, int limit, int iDB)
        {
            List<BsonDocument> lstResult = new List<BsonDocument>();
            var collection = (iDB == 0) ? this.colHtml : this.colProduct;
            var filter = new BsonDocument();
            FindOptions<BsonDocument> options = new FindOptions<BsonDocument> { Limit = limit };
            var builder = Builders<BsonDocument>.Filter;
            using (var cursor = await collection.FindAsync(query, options))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        lstResult.Add(document);
                    }
                }
            }
            return lstResult;
        }





        public async Task<List<BsonDocument>> GetProductLastUpdateFrom(DateTime dtStartJob, int limit)
        {
            List<BsonDocument> lstResult = new List<BsonDocument>();
            var collection = this.colProduct;
            var filter = new BsonDocument();
            FindOptions<BsonDocument> options = new FindOptions<BsonDocument> { Limit = limit };

            var builder = Builders<BsonDocument>.Filter;
            var filterSerach = builder.Eq("processed", false);

            using (var cursor = await collection.FindAsync(filterSerach, options))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        lstResult.Add(document);
                    }
                }
            }
            return lstResult;
        }

        public async Task<List<BsonDocument>> GetProductNeedReload(int limit)
        {
            List<BsonDocument> lstResult = new List<BsonDocument>();
            var collection = this.colProduct;
            var filter = new BsonDocument();
            FindOptions<BsonDocument> options = new FindOptions<BsonDocument> { Limit = limit };

            var builder = Builders<BsonDocument>.Filter;
            var filterSerach = builder.Eq("wait_quick_reload", true);

            using (var cursor = await collection.FindAsync(filterSerach, options))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        lstResult.Add(document);
                    }
                }
            }
            return lstResult;
        }


        public async Task<List<BsonDocument>> GetProductProcessExtraData(DateTime dtStartJob, int limit)
        {
            List<BsonDocument> lstResult = new List<BsonDocument>();
            var collection = this.colProduct;
            var filter = new BsonDocument();
            FindOptions<BsonDocument> options = new FindOptions<BsonDocument> { Limit = limit };

            var builder = Builders<BsonDocument>.Filter;
            var filter1 = builder.Exists("processed", false) & builder.Eq("processed", true);

            using (var cursor = await collection.FindAsync(filter1, options))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        lstResult.Add(document);
                    }
                }
            }
            return lstResult;
        }

        public async Task<string> GetProductbyID(long ProductID)
        {
            using (var cursor1 = await colProduct.FindAsync<BsonDocument>(new BsonDocument()
                {
                    {"id",ProductID}
                }))
            {
                while (await cursor1.MoveNextAsync())
                {
                    var batch = cursor1.Current;
                    foreach (var document1 in batch)
                    {
                        return (document1 as BsonDocument)["_id"].AsObjectId.ToString();
                    }
                }
            }
            return "";
        }

        public async Task<BsonDocument> GetKeywordByName(string nameKeyword)
        {
            using (var cursor1 = await colProduct.FindAsync<BsonDocument>(new BsonDocument()
                {
                    {"name",nameKeyword}
                }))
            {
                while (await cursor1.MoveNextAsync())
                {
                    var batch = cursor1.Current;
                    foreach (var document1 in batch)
                    {
                        return document1;
                    }
                }
            }
            return null;
        }

        public async Task<BsonDocument> GetKeywordByNameKeyWord(string nameKeyword)
        {
            using (var cursor1 = await this.colKeyWord.FindAsync<BsonDocument>(new BsonDocument()
                {
                    {"name",nameKeyword}
                }))
            {
                while (await cursor1.MoveNextAsync())
                {
                    var batch = cursor1.Current;
                    foreach (var document1 in batch)
                    {
                        return document1;
                    }
                }
            }
            return null;
        }

        public async Task<BsonDocument> GetKeyWordID(long keywordID)
        {
            using (var cursor1 = await this.colKeyWord.FindAsync<BsonDocument>(Builders<BsonDocument>.Filter.Eq("crc", keywordID)))
            {
                while (await cursor1.MoveNextAsync())
                {
                    var batch = cursor1.Current;
                    foreach (var document1 in batch)
                    {
                        return (document1 as BsonDocument);
                    }
                }
            }
            return null;
        }

        public async Task<BsonDocument> GetKeyWordID(string _id)
        {
            using (var cursor1 = await this.colKeyWord.FindAsync<BsonDocument>(Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(_id))))
            {
                while (await cursor1.MoveNextAsync())
                {
                    var batch = cursor1.Current;
                    foreach (var document1 in batch)
                    {
                        return (document1 as BsonDocument);
                    }
                }
            }
            return null;
        }

        public bool CheckExistsKeyWord(long idProduct)
        {
            var result = colKeyWord.Find(Builders<BsonDocument>.Filter.Eq("crc", idProduct)).FirstOrDefaultAsync();
            if (result.Result != null) return true;
            else return false;
        }

        public string GetObjectIDOfKeyword (long idProduct)
        {
            var result = colKeyWord.Find(Builders<BsonDocument>.Filter.Eq("crc", idProduct)).FirstOrDefaultAsync();
            if (result.Result != null) return result.Result["_id"].AsObjectId.ToString();
            else return "";
        }


        public bool CheckExistsProductSalenew(long idProduct)
        {
            while (true)
            {
                try
                {
                    var result = colProduct.Find(Builders<BsonDocument>.Filter.Eq("id", idProduct)).FirstOrDefaultAsync();
                    if (result.Result != null) return true;
                    else return false;
                }
                catch (Exception ex)
                {
                    log.Error(string.Format("Can't connect to server" + ex.Message + ex.StackTrace));
                    Thread.Sleep(10000);

                }
            }
        }




        public async void InsertProduct(ProductSaleNew product)
        {
            try
            {

                //INSERT
                await colProduct.InsertOneAsync(new BsonDocument
               {
                {"id",product.id},
                {"name",product.name},
                {"slug", product.slug},
                {"description",product.description},
                {"price",Convert.ToInt64( product.price)},
                {"currency",product.currency.ToLower()},
                {"order_price", product.price},
                {"created_at",DateTime.Now},
                {"updated_at",DateTime.Now},
                {"source_updated_at",product.source_updated_at},
                {"url",product.url},
                {"thumb_url",product.thumb_url},
                {"images",new BsonArray(product.images)},
                {"source_view_count",0},
                {"source_view",product.source_view_count},
                {"view_count",0},
                {"source_id",product.website_id},
                {"status",product.status},
                {"category_ids",new BsonArray(product.category_ids)},
                {"tags",new BsonArray(product.tags)},
                {"processed",false},
                {"province",product.province},
                {"id_text",product.id.ToString()},
                {"web_category",product.web_category},
                {"is_solr_updated",false},
                {"wait_quick_reload",false},
                {"have_price",product.have_price},
                {"source_name",product.source_name},
                {"classification_id",product.classification_id},
                {"is_crawled",product.is_crawled},
                {"city_ids", new BsonArray(product.city_ids)},
               });

                await colHtml.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("id", product.id), Builders<BsonDocument>.Update
               .Set("content", product.content)
               .Set("id_text", product.id.ToString())
               .AddToSetEach("category_ids", new BsonArray(product.category_ids))
               , new UpdateOptions() { IsUpsert = true });
            }
            catch (Exception ex)
            {
                log.ErrorFormat(ex.Message);
            }
        }


        /// <summary>
        /// Update dữ liệu nhanh. Các trường cơ bản: 
        /// </summary>
        /// <param name="product"></param>
        public void UpdateProduct(ProductSaleNew product)
        {
            try
            {
                //UPDATE
                var a1 = colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("id", product.id)
                , Builders<BsonDocument>.Update
                .Set("name", product.name)
                .Set("slug", product.slug)
                .Set("description", product.description)
                .Set("price", product.price)
                .Set("curency", product.currency.ToLower())
                .Set("order_price", product.price)
                .Set("source_updated_at", product.source_updated_at)
                .Set("thumb_url", product.thumb_url)
                .Set("images", new BsonArray(product.images))
                .Set("source_view_count", product.source_view_count)
                .Set("category_ids", new BsonArray(product.category_ids))
                .Set("tags", new BsonArray(product.tags))
                .Set("province", product.province)
                .Set("id_text", product.id.ToString())
                .Set("web_category", product.web_category)
                .Set("is_solr_updated", false)
                .Set("wait_quick_reload", false)
                .Set("have_price", product.have_price)
                .Set("source_name", product.source_name)
                .Set("classification_id", product.classification_id)
                .Set("city_ids", product.city_ids)
                .Set("source_id", product.website_id)
                .CurrentDate("updated_at")).Result;

                var a2 = colHtml.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("id", product.id), Builders<BsonDocument>.Update
                .Set("content", product.content)
                .Set("id_text", product.id.ToString())
                .Set("wait_quick_reload", false)
                .AddToSet("category_ids", new BsonArray(product.category_ids))
                , new UpdateOptions() { IsUpsert = true }).Result;
            }
            catch (Exception ex)
            {
                log.ErrorFormat(ex.Message);
            }
        }

        public async void UpdateClosedProduct(long productID, int status)
        {
            //UPDATE
            await colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("id", productID)
            , Builders<BsonDocument>.Update
            .Set("status", status)
            .CurrentDate("updated_at")
            .Set("is_solr_updated", false)
            .Set("wait_quick_reload", false)
           , new UpdateOptions() { IsUpsert = true });

        }


        public async void SetWaitToUpdateSolr(long productID)
        {
            //UPDATE
            await colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("id", productID),
                Builders<BsonDocument>.Update.Set("is_solr_updated", false));
        }



        public async void SaveHtml(long productID, string html, bool bExits)
        {
            //if (!bExits)
            //{
            //    await this.colHtml.InsertOneAsync(new BsonDocument
            //   {
            //    {"id",productID},
            //    {"html",html},
            //    {"update_at",DateTime.Now}
            //   });
            //}
            //else
            //{
            //    await this.colHtml.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("id", productID)
            //   , Builders<BsonDocument>.Update
            //   .Set("html", html).CurrentDate("update_at"));
            //}
        }

        public async void InsertKeyWord(string source_id, long crcKeyWord, string keywords, string slug, int view_count, string TermIds, string CategoryIds)
        {
            List<string> categoryIDs = CategoryIds.Split(new char[] { ',' }, 100, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> terms = TermIds.Split(new char[] { ',' }, 100, StringSplitOptions.RemoveEmptyEntries).ToList();

            //INSERT
            await this.colKeyWord.InsertOneAsync(new BsonDocument
               {
                {"crc",crcKeyWord},
                {"name",keywords},
                {"slug",slug},
                {"view_count",0},
                {"category_ids",new BsonArray(categoryIDs)},
                {"term_ids",new BsonArray(terms)},
                {"crc_text",crcKeyWord.ToString()},
                {"source_ids",new BsonArray( new string[]{source_id})}
               });

        }

        public void UpdateKeyWord(string source_id, long crcKeyWord
            , string keywords, string slug
            , string TermIds, string CategoryIds)
        {

            List<string> categoryIDs = CategoryIds.Split(new char[] { ',' }, 100, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> terms = TermIds.Split(new char[] { ',' }, 100, StringSplitOptions.RemoveEmptyEntries).ToList();

            var A1 = colKeyWord.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("crc", crcKeyWord)
           , Builders<BsonDocument>.Update
           .Set("name", keywords)
           .Set("slug", QT.Entities.Common.GetSplug(keywords))
           .Set("crc_text", crcKeyWord.ToString())
           .Set("is_solr_updated", false)
           .CurrentDate("updated_at"), new UpdateOptions() { IsUpsert = true }).Result;

            foreach (var itemCategoryID in categoryIDs)
            {
                var A2 = colKeyWord.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("crc", crcKeyWord)
                , Builders<BsonDocument>.Update
                .AddToSet("category_ids", itemCategoryID)
                .CurrentDate("updated_at"));
            }

            foreach (var itemTerms in terms)
            {
                var A3 = colKeyWord.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("crc", crcKeyWord)
                , Builders<BsonDocument>.Update
                .AddToSet("term_ids", itemTerms)
                .CurrentDate("updated_at"));
            }
        }

        public void UpdateKeyWordRaoVat(string source_id, long crcKeyWord
            , string keywords, string slug
            , string TermIds, string CategoryIds)
        {

            List<string> categoryIDs = CategoryIds.Split(new char[] { ',' }, 100, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> terms = TermIds.Split(new char[] { ',' }, 100, StringSplitOptions.RemoveEmptyEntries).ToList();

            var A1 = colKeyWord.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("crc", crcKeyWord)
           , Builders<BsonDocument>.Update
           .Set("name", keywords)
           .Set("slug", QT.Entities.Common.GetSplug(keywords))
           .Set("crc_text", crcKeyWord.ToString())
           .Set("is_solr_updated", false)
           .Set("is_special", true)
           .Set("priority", 0)
           .Set("status", 1)
           .CurrentDate("updated_at"), new UpdateOptions() { IsUpsert = true }).Result;

            foreach (var itemCategoryID in categoryIDs)
            {
                var A2 = colKeyWord.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("crc", crcKeyWord)
                , Builders<BsonDocument>.Update
                .AddToSet("category_ids", itemCategoryID)
                .CurrentDate("updated_at"));
            }

            foreach (var itemTerms in terms)
            {
                var A3 = colKeyWord.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("crc", crcKeyWord)
                , Builders<BsonDocument>.Update
                .AddToSet("term_ids", itemTerms)
                .CurrentDate("updated_at"));
            }
        }

        public void UpdateKeyWord(string source_id, long crcKeyWord
            , string keywords, string slug, string TermIds
            , BsonArray CategoryIds, string fieldIncreate
            , int amountIncr
            , bool isGoodKeyWord)
        {
            List<string> terms = TermIds.Split(new char[] { ',' }, 100, StringSplitOptions.RemoveEmptyEntries).ToList();

            var A1 = colKeyWord.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("crc", crcKeyWord)

           , Builders<BsonDocument>.Update
           .Set("name", keywords)
           .Set("slug", QT.Entities.Common.GetSplug(keywords))
           .Set("crc_text", crcKeyWord.ToString())
           .Set("is_solr_updated", false)
           .Set("is_blocked", isGoodKeyWord)
           .Inc(fieldIncreate, 1)
           .AddToSetEach("category_ids", CategoryIds.ToArray())
           .CurrentDate("updated_at")
           , new UpdateOptions() { IsUpsert = true }).Result;

            foreach (var itemTerms in terms)
            {
                var A3 = colKeyWord.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("crc", crcKeyWord)
                , Builders<BsonDocument>.Update
                .AddToSet("term_ids", itemTerms)
                .CurrentDate("updated_at"));
            }
        }

        private IMongoCollection<BsonDocument> GetDB(int iDB)
        {
            return (iDB == 0) ? this.colHtml : this.colProduct;
        }

        public async void UpdateLoadKeyWord(BsonObjectId _id, string queryUpdate, int iDB)
        {
            await this.GetDB(iDB).UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", _id)
                        , queryUpdate, new UpdateOptions() { IsUpsert = false });
        }

        public async void UpdateLoadKeyWordOfProduct(BsonObjectId _id)
        {
            await this.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", _id)
                        , Builders<BsonDocument>.Update
                        .Set("is_extract_keyword", true));
        }

        public async void SetAllhtmlToNoExtractkeyWord()
        {
            await this.colHtml.UpdateManyAsync(Builders<BsonDocument>.Filter.Eq("is_extract_keyword", true)
                        , Builders<BsonDocument>.Update
                        .Set("is_extract_keyword", false), new UpdateOptions() { IsUpsert = false });
        }

        public async void SetAllProductNoExtractKeyWord()
        {
            await this.colProduct.UpdateManyAsync(Builders<BsonDocument>.Filter.Eq("is_extract_keyword", true)
                        , Builders<BsonDocument>.Update
                        .Set("is_extract_keyword", false), new UpdateOptions() { IsUpsert = false });
        }

        public async void UpdateCitys(BsonObjectId _id, List<int> cityIDs)
        {
            foreach (int cityID in cityIDs)
            {
                await this.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", _id)
                           , Builders<BsonDocument>.Update
                           .AddToSet("city_ids", cityID)
                           .CurrentDate("updated_at"));
            }
        }

        public async void SetWaitToUpdateSolr(BsonObjectId bsonObjectId)
        {
            await this.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", bsonObjectId)
                           , Builders<BsonDocument>.Update
                           .Set("is_solr_updated", false));
        }

        public async void ProcessedData(BsonObjectId bsonObjectId)
        {
            await this.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", bsonObjectId)
                           , Builders<BsonDocument>.Update
                           .Set("processed", true));
        }




        public async Task<List<BsonDocument>> GetDataProcess(FindOptions<BsonDocument> findOption, string query, int iColection)
        {
            List<BsonDocument> lstResult = new List<BsonDocument>();
            IMongoCollection<BsonDocument> collection = null;
            if (iColection == 0) collection = this.colProduct;
            else if (iColection == 1) collection = this.colKeyWord;
            var filter = new BsonDocument();
            var builder = Builders<BsonDocument>.Filter;
            FilterDefinition<BsonDocument> filterDefinition = query;
            var filterSerach = filterDefinition;
            using (var cursor = await collection.FindAsync(filterSerach, findOption))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        lstResult.Add(document);
                    }
                }
            }
            return lstResult;
        }



        public async void UpdateFieldData(BsonObjectId bsonObjectId, string query)
        {
            List<BsonDocument> lstResult = new List<BsonDocument>();
            UpdateDefinition<BsonDocument> filterDefinition = query;
            await this.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", bsonObjectId), filterDefinition, null);
        }

        public async void UpdateStateProcessedImage(BsonObjectId bsonObjectId, bool bStatus)
        {
            await this.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", bsonObjectId)
                          , Builders<BsonDocument>.Update
                          .Set("processed_image", false));
        }


        public async Task<List<BsonDocument>> GetListExtractKeyWordFromTitle()
        {
            List<BsonDocument> lstResult = new List<BsonDocument>();
            var collection = this.colProduct;
            var filter = new BsonDocument();
            FindOptions<BsonDocument> options = new FindOptions<BsonDocument> { Limit = 100 };

            var builder = Builders<BsonDocument>.Filter;

            using (var cursor = await this.colProduct.FindAsync("{}", options))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        lstResult.Add(document);
                    }
                }
            }
            return lstResult;
        }



        public async Task<BsonDocument> GetLastData(int sourceID)
        {
            try
            {
                SortDefinition<BsonDocument> a = "{'updated_at':-1}";
                FindOptions<BsonDocument> findOp = new FindOptions<BsonDocument>() { Limit = 1, Sort = a };
                string query = "{$and:[{'source_id':" + sourceID.ToString() + "},{'status':1}]}";
                using (var cursor = await this.colProduct.FindAsync(query, findOp))
                {
                    while (await cursor.MoveNextAsync())
                    {
                        var batch = cursor.Current;
                        foreach (var document in batch)
                        {
                            return document;
                        }
                    }
                }
                return new BsonDocument();
            }
            catch (Exception ex)
            {
                return new BsonDocument();
            }
        }

        internal int GetScoreOfKeyWord(long crc)
        {
            throw new NotImplementedException();
        }

        public async void UpdateKeyWordForProduct(BsonObjectId objectId, IEnumerable<string> crcKeyWord)
        {
            await this.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", objectId)
                  , Builders<BsonDocument>.Update
                  .Set("is_wait_keyword", false)
                  .Set("is_solr_updated", false)
                  .AddToSetEach("keyword_ids", new BsonArray(crcKeyWord)));
        }

        public bool CheckBlackLink(long idKeyword)
        {
            return this.colKeyWord.CountAsync(Builders<BsonDocument>.Filter
                .Eq("crc", idKeyword) & Builders<BsonDocument>.Filter
                .Eq("status", 0)
                ).Result > 0;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="product_id">_id of product in mongodb</param>
        /// <param name="status"0. lock in wss. 1. visible. 2. lock by app. 3. Not visible></param>
        public void UpdateStatusOfProduct(string product_id, int status)
        {
            var a = this.colProduct.UpdateOneAsync
                (Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(product_id)),
                (Builders<BsonDocument>.Update.Set("status", status)), new UpdateOptions()
                {
                    IsUpsert = false
                }).Result;
        }

        public void UpdateStatusOfKeyword(string product_id, int status)
        {
            if (status == 2)
            {
                var a = this.colKeyWord.UpdateOneAsync
                   (Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(product_id)),
                   (Builders<BsonDocument>.Update.Set("status", status)
                   .Set("is_blocked", true))
                   .CurrentDate("updated_at"),
                    new UpdateOptions()
                    {
                        IsUpsert = false
                    }).Result;
            }
            else
            {
                var a = this.colKeyWord.UpdateOneAsync
                    (Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(product_id)),
                    (Builders<BsonDocument>.Update.Set("status", status)
                    .CurrentDate("updated_at")),
                     new UpdateOptions()
                     {
                         IsUpsert = false
                     }).Result;
            }
        }

        public void UpdateStatusOfKeyword(ObjectId product_id, int status)
        {
            var a = this.colKeyWord.UpdateOneAsync
                (Builders<BsonDocument>.Filter.Eq("_id", product_id),
                (Builders<BsonDocument>.Update
                .Set("status", status)
                .Set("is_solr_updated", false)
                .CurrentDate("updated_at")),
                 new UpdateOptions()
                 {
                     IsUpsert = false
                 }).Result;
        }

        public bool CheckBlackLink(string _id)
        {
            try
            {
                return this.colKeyWord.CountAsync(Builders<BsonDocument>.Filter.Eq("_id", _id)).Result > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdatePriorityKeyword(string keyword_id, int priority)
        {
            var a = this.colKeyWord.UpdateOneAsync
               (Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(keyword_id))
               , Builders<BsonDocument>.Update.Set("is_solr_updated", false)
               .Set("priority", priority)
               .CurrentDate("updated_at")
               , new UpdateOptions()
               {
                   IsUpsert = false
               });
            return a.Result.ModifiedCount > 0;
        }

        public async void InsertKeyword(KeywordSaleNew product)
        {
            try
            {
                //INSERT
                await this.colKeyWord.InsertOneAsync(new BsonDocument
               {
                {"crc",product.crc},
                {"name",product.name},
                {"slug", product.slug},
                {"category_ids",new BsonArray( product.category_ids)},
                {"priority",product.priority},
                {"view_count",0},
                {"term_ids",new BsonArray(new int[]{})},
                {"crc_text",product.crc.ToString()},
                {"processed",false},
                {"is_solr_updated",false},
                {"status",product.status},
                {"word_number",product.name.Split(new char[]{' '}).Count()},
                {"score_gram",1},
                {"updated_at",DateTime.Now},
                {"is_blocked",product.is_blocked}
                });
            }
            catch (Exception ex)
            {
                log.ErrorFormat(ex.Message);
            }
        }

        public async Task<long> IncrementScoreGramKeyWord(long p)
        {
            try
            {
                var a = await this.colKeyWord.UpdateOneAsync
             (Builders<BsonDocument>.Filter.Eq("crc", p)
             , Builders<BsonDocument>.Update.Set("is_solr_updated", false)
             .Inc("score_gram", 1)
             .CurrentDate("updated_at")
             , new UpdateOptions()
             {
                 IsUpsert = false
             });
                return a.ModifiedCount;
            }
            catch (Exception ex)
            {
                log.ErrorFormat(ex.Message);
            }
            return 0;
        }

        public List<KeywordSaleNew> GetListKeywordNeedUpdate()
        {
            List<KeywordSaleNew> lstKeyWordResult = new List<KeywordSaleNew>();
            using (var cursor = this.colKeyWord.FindAsync(Builders<BsonDocument>.Filter.Eq("is_solr_updated", false), new FindOptions<BsonDocument, BsonDocument>()
            {
                Limit = 1000
            }).Result)
            {
                while (cursor.MoveNextAsync().Result)
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        KeywordSaleNew keyword = ParseKeyWord(document);
                        if (keyword != null)
                        {
                            lstKeyWordResult.Add(keyword);
                        }
                    }
                }
            }
            return lstKeyWordResult;
        }


        public List<ProductSaleNew> GetListProductNeedUpdate(int iLimit)
        {
            List<ProductSaleNew> lstProductResult = new List<ProductSaleNew>();
            try
            {
                using (var cursor = this.colProduct.FindAsync(
                    Builders<BsonDocument>.Filter.Eq("is_solr_updated", false)
                    , new FindOptions<BsonDocument, BsonDocument>()
                    {
                        Limit = iLimit
                    }).Result)
                {
                    while (cursor.MoveNextAsync().Result)
                    {
                        var batch = cursor.Current;
                        foreach (var document in batch)
                        {
                            ProductSaleNew product = ParseProduct(document);
                            if (product != null)
                            {
                                lstProductResult.Add(product);
                            }
                            else
                            {
                                long modified = this.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id",
                                    document["_id"].AsObjectId), Builders<BsonDocument>.Update.Set("is_solr_updated", true)
                                    .CurrentDate("solr_updated_at"),
                                    new UpdateOptions() { IsUpsert = false }).Result.ModifiedCount;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.ErrorFormat(ex.Message);
            }
            return lstProductResult;
        }

        private ProductSaleNew ParseProduct(BsonDocument document)
        {
            ProductSaleNew psn = new ProductSaleNew();
            try
            {
                psn._id = Convert.ToString(document["_id"]);
                psn.name = Convert.ToString(document["name"]);
                psn.description = Convert.ToString(document["description"]);
                psn.currency = Convert.ToString(document["currency"]);
                psn.city_ids = ParseToArrayInt(document["city_ids"].AsBsonArray);
                psn.slug = Convert.ToString(document["slug"]);
                psn.price = Convert.ToInt64(document["price"]);
                psn.wss_view_count = (document.Contains("view_count")) ? Convert.ToInt32(document["view_count"]) : 0;
                psn.source_view_count = (document.Contains("source_view_count")) ? Convert.ToInt32(document["source_view_count"]) : 0;
                psn.created_at = (document.Contains("created_at")) ? document["created_at"].ToUniversalTime().AddHours(7) : DateTime.Now;
                psn.updated_at = (document.Contains("updated_at")) ? document["updated_at"].ToUniversalTime().AddHours(7) : DateTime.Now;
                psn.source_updated_at = (document.Contains("source_updated_at")) ? document["source_updated_at"].ToUniversalTime().AddHours(7) : DateTime.Now;
                psn.is_crawled = (document.Contains("is_crawled")) ? document["is_crawled"].AsBoolean : true;
                psn.url = document["url"].AsString;
                psn.thumb_url = document["thumb_url"].AsString;
                psn.category_ids = ParseToArrayInt(document["category_ids"].AsBsonArray);
                psn.term_ids = new int[] { };
                psn.keyword_ids = (document.Contains("keyword_ids")) ? ParseToArrayInt(document["keyword_ids"].AsBsonArray) : new List<int> { };
                psn.source_name = document["source_name"].AsString;
            }
            catch (Exception ex)
            {
                return null;
            }
            return psn;
        }


        public KeywordSaleNew ParseKeyWord(BsonDocument document)
        {
            try
            {
                KeywordSaleNew keyword = new KeywordSaleNew();
                keyword._id = document["_id"].AsObjectId.ToString();
                keyword.name = document["name"].AsString;
                keyword.crc = document["crc"].AsInt64;
                keyword.slug = document["slug"].AsString;
                keyword.view_count = (document.Contains("view_count")) ? Convert.ToInt32(document["view_count"]) : 0;
                keyword.category_ids = document.Contains("category_ids") ? ParseToArrayInt(document["category_ids"].AsBsonArray) : new List<int> { };
                keyword.term_ids = document.Contains("term_ids") ? ParseToArrayInt(document["term_ids"].AsBsonArray) : new List<int> { };
                keyword.status = (document.Contains("status")) ? Convert.ToInt32(document["status"]) : 0;
                keyword.name_suggest = keyword.slug.Replace("-", " ");
                keyword.priority = (document.Contains("priority")) ? Convert.ToInt32(document["priority"]) : 0;
                return keyword;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private List<int> ParseToArrayInt(BsonArray bsonArray)
        {
            try
            {
                List<int> lst = new List<int>();
                foreach (var item in bsonArray)
                {
                    if (item.IsInt32) lst.Add(item.AsInt32);
                }
                return lst;
            }
            catch (Exception ex)
            {
                return new List<int> { };
            }
        }

        private long[] ParseToArrayInt64(BsonArray bsonArray)
        {
            List<long> lst = new List<long>();
            foreach (var item in bsonArray)
            {
                lst.Add(item.AsInt64);
            }
            return lst.ToArray();
        }

        public List<BsonDocument> GetLstProductReload(string query, int limit)
        {
            using (var cursor = this.colProduct.FindAsync(query, new FindOptions<BsonDocument, BsonDocument>()
            {
                Limit = limit
            }).Result)
            {
                while (cursor.MoveNextAsync().Result)
                {
                    return cursor.Current.ToList();
                }
            }
            return null;
        }

        internal List<BsonDocument> GetListKeywordNeedCheck(DateTime dtFrom, bool CheckStatus)
        {
            string query =
                @"
{
    $and:
    [
        {
            'updated_at':{$lt:ISODate('" + dtFrom.AddHours(-7).ToString("yyyy-MM-ddTHH:mm:sssZ") + @"')}
        }, {'is_blocked':false}
"
            +
            ((CheckStatus == true) ? @"        ,
        {
            'status':1
        }" : "")
          +
            @"
    ]
}";

            using (var cursor = this.colKeyWord.FindAsync(query, new FindOptions<BsonDocument, BsonDocument>()
            {
                Limit = 10000
            }).Result)
            {
                while (cursor.MoveNextAsync().Result)
                {
                    return cursor.Current.ToList();
                }
            }
            return null;
        }

        public Task<UpdateResult> SetPriority(string objectID, int Priority)
        {
            return this.colKeyWord.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(objectID))
                , Builders<BsonDocument>.Update
                .Set("priority", Priority)
                .Set("status", 1)
                .Set("is_solr_updated", false).CurrentDate("updated_at"), new UpdateOptions() { IsUpsert = false });


        }

        public Task<UpdateResult> SetStatus (string objectID, int Status)
        {
            return this.colKeyWord.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(objectID))
                , Builders<BsonDocument>.Update
                .Set("priority", 11)
                .Set("status", Status)
                .Set("is_solr_updated", false)
                .CurrentDate("updated_at"), new UpdateOptions() { IsUpsert = false });
        }
    }
}
