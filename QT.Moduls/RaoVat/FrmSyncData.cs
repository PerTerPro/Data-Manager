using MongoDB.Bson;
using MongoDB.Driver;
using QT.Entities;
using QT.Entities.RaoVat;
using QT.Entities.Data;
using QT.Entities.Data.SolrDb.SaleNews;
using QT.Entities.Model.SaleNews;
using QT.Moduls.RaoVat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlSale
{
    public partial class FrmSyncData : Form
    {
        bool bStarted = false;
        bool bPause = true;
        private Thread thread;
        public delegate void SyncMethod();
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmSyncData));
     

        public FrmSyncData()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int nmberItem = Convert.ToInt32(spinEdit1.Value);
            if (this.bStarted == false)
            {
                this.bStarted = true;
                this.bPause = false;
                if (TypeProcess == TypeRunSync.AnalysicKeywordFromProduct)
                {
                    this.thread = new Thread(() => AnalysicKeyWordFromNameProduct(new int[] { 1, 2, 3 }, true));
                }
                else if (TypeProcess==TypeRunSync.SyncKeyWordMongoAndSolr)
                {
                    this.thread = new Thread(() => SyncKeywordMongoAndSolr());
                }
                else if (TypeProcess==TypeRunSync.SyncProductSolrAndMongo)
                {
                    int iLimit = Convert.ToInt32(spinEdit1.Value);
                    this.thread = new Thread(() => SyncProductMongoAndSolr(iLimit));
                }
                else
                {
                    this.thread = new Thread(() => RunSync(nmberItem));
                }
                this.thread.Start();
                this.btnStart.Text = "Run";
            }
            else
            {
                bPause = !bPause;
                this.btnStart.Text = (bPause == true) ? "Run" : "Pause";
            }
        }

        private void SyncKeywordMongoAndSolr()
        {
            try
            {
                int iCount = 0;
                while (!bPause)
                {
                    var slr = SolrRaoVatKeywordDriver.GetDriver(SolrRaoVatKeywordDriver.GetInstance());
                    MongoDbRaoVat mongoDb = new MongoDbRaoVat();
                    while (!this.bPause)
                    {
                        List<KeywordSaleNew> lstKeywordNeedUpdate = mongoDb.GetListKeywordNeedUpdate();
                        if (lstKeywordNeedUpdate.Count > 0)
                        {
                            foreach (var item in lstKeywordNeedUpdate)
                            {
                                bool bOK = slr.UpdateData(item);
                                if (bOK)
                                {
                                    long iOK = mongoDb.colKeyWord.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(item._id)),
                                        Builders<BsonDocument>.Update.Set("is_solr_updated", true)
                                        .CurrentDate("solr_updated_at")).Result.ModifiedCount;
                                    if (iOK > 0)
                                    {
                                        iCount++;
                                        WriteLog(string.Format("Updated keyword {0}: {1}", iCount, item.name));
                                    }
                                }
                            }
                        }
                        else
                        {
                            this.Invoke(new Action(() =>
                                {
                                    WriteLog(string.Format("\r\nNot item need upload. Sleep 10s"));
                                }));
                            Thread.Sleep(10000);
                        }
                    }
                    Thread.Sleep(5000);
                }
            }
            catch (ThreadAbortException threadAbortEx)
            {
                return;
            }
            catch (Exception ex)
            {
                log.ErrorFormat(ex.Message);
            }
        }

        private void SyncProductMongoAndSolr(int iLimit)
        {
            int iCount = 0;
            while (!bPause)
            {
                try
                {
                    var slr = SolrRaoVatDriver.GetDriver(SolrRaoVatDriver.GetInstance());
                    MongoDbRaoVat mongoDb = new MongoDbRaoVat();
                    List<ProductSaleNew> lstKeywordNeedUpdate = mongoDb.GetListProductNeedUpdate(iLimit);
                    foreach (var item in lstKeywordNeedUpdate)
                    {
                        bool bDelData = false;

                        if (item.status != 1)
                        {
                            slr.DeleteByQuery(string.Format("_id:{0}", item._id));
                            bDelData = true;
                        }
                        else
                        {
                            if (item.category_ids.Contains(14))
                            {
                                bool bOK = slr.IndexItems(new List<ProductSaleNew>() { item });
                                bDelData = false;
                            }
                        }

                        long iOK = mongoDb.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(item._id))
                            , Builders<BsonDocument>.Update.Set("is_solr_updated", true)
                            .CurrentDate("solr_updated_at")).Result.ModifiedCount;

                        if (iOK > 0)
                        {
                            iCount++;
                            WriteLog(string.Format("PushToSolr {2} product {0}: {1}. Id:{3}", iCount
                                , item.name
                                , (bDelData) ? "Deleted" : "Updated"
                                , item._id));
                        }
                    }

                    WriteLog("SoftCommit");
                    slr.SoftCommit();
                    WriteLog("SoftCommit Sucess");

                    WriteLog("Sleep 5 s continute...");
                    Thread.Sleep(5000);
                }
                catch (ThreadAbortException threadAbortEx)
                {
                    return;
                }
                catch (Exception ex)
                {
                    WriteLog(string.Format("Exception:{0}", ex.Message));
                    log.ErrorFormat(ex.Message);
                    Thread.Sleep(1000);
                }
            }
        }


        public void RunSync(int numberItem)
        {

            MySqlAdapterRaoVat mySqlAdapterRaoVat = null;
            Dictionary<int, string> dicCity=null;
            RaoVatSQLAdapter configXPathAdapter = new RaoVatSQLAdapter(
                new SqlDb(QT.Entities.Server.ConnectionStringCrawler));

            MongoDbRaoVat mongoDb = new MongoDbRaoVat();
            while (!this.bPause)
            {
                try
                {
                    if (TypeProcess == TypeRunSync.ReloadAllProuduct)
                    {
                        bool bOK = ReloadAllProduct(numberItem, mongoDb).Result;
                        WriteLog(string.Format("Commit {0} data", numberItem));
                        Thread.Sleep(1000);
                    }
                    else if (TypeProcess == TypeRunSync.AnalyscFieldProduct)
                    {
                        mySqlAdapterRaoVat = new MySqlAdapterRaoVat();
                        dicCity = mySqlAdapterRaoVat.GetDicCity();
                        bool bOK = AnalysicField(numberItem, mongoDb, dicCity).Result;
                        WriteLog(string.Format("Commit {0} data", numberItem));
                        Thread.Sleep(1000);
                    }
                    else if (TypeProcess==TypeRunSync.FixSlug)
                    {
                        bool OK = AnalysicKeyword(10000, mongoDb, null).Result;
                        WriteLog(string.Format("Commit {0} data", numberItem));
                        Thread.Sleep(1000);
                    }
                    else if (TypeProcess == TypeRunSync.ReloadAllKeyWord)
                    {
                        bool iProductAnalysic = AnalysicKeyword(10000, mongoDb, null).Result;
                    }
                }
                catch (OperationAbortedException ex1)
                {
                    break;
                }
                catch (Exception ex)
                {
                    WriteLog(ex.Message);
                    Thread.Sleep(10000);
                }
            }
        }

        private async Task<bool> ReloadAllProduct(int p, MongoDbRaoVat mongoDbAdapter)
        {
            try
            {
                int numberItem = 0;
                var builder = Builders<BsonDocument>.Filter;
                //var filterSerach = "{$and:[{'wait_quick_reload':false},{'status':1}]}";
                DateTime dt = new DateTime(2015, 9, 19, 11, 0, 0);
                using (var cursor = await mongoDbAdapter.colProduct.FindAsync(Builders<BsonDocument>.Filter.Exists
                    ("source_name", false), new FindOptions<BsonDocument, BsonDocument>()
                {
                    Limit = p
                }))
                {
                    while (await cursor.MoveNextAsync())
                    {
                        var batch = cursor.Current;
                        foreach (var document in batch)
                        {
                            //Dich lai source name
                            string url = document["url"].AsString;
                            string source_name = "";
                            foreach (var item in ProductSaleNew.lst)
                            {
                                if (url.Contains(item))
                                {
                                    source_name = item;
                                }
                            }
                            await mongoDbAdapter.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", document["_id"].AsObjectId),
                                Builders<BsonDocument>.Update.Set("source_name", source_name)
                                .Set("is_solr_updated", false)
                                .CurrentDate("updated_at")
                                , new UpdateOptions() { IsUpsert = false });
                            WriteLog("Updated for :" + document["_id"].AsObjectId.ToString());
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message);
                return false;
            }
        }

        private async Task<bool> AnalysicField(int p, MongoDbRaoVat mongoDbAdapter, Dictionary<int, string> dicCity)
        {
            try
            {
                int numberItem = 0;
                var builder = Builders<BsonDocument>.Filter;
                DateTime dt = new DateTime(2015, 9, 19, 11, 0, 0);
                using (var cursor = await mongoDbAdapter.colProduct.FindAsync(Builders<BsonDocument>.Filter.Size
                    ("city_ids", 0), new FindOptions<BsonDocument, BsonDocument>()
                    {
                        Limit = p
                    }))
                {
                    while (await cursor.MoveNextAsync())
                    {
                        //Khoi tao=>Toan QUoc

                        var batch = cursor.Current;
                        foreach (var product in batch)
                        {
                            //Dịch City.
                            List<int> cityIDs = new List<int>()
                        {
                            0
                        };

                            string strProvince = product["province"].AsString;
                            if (!string.IsNullOrEmpty(strProvince))
                            {

                                foreach (var item in dicCity)
                                {
                                    string strProvinceChuan = strProvince.ToLower();
                                    if (Regex.IsMatch(strProvinceChuan, item.Value))
                                    {
                                        cityIDs.Add(item.Key);
                                    }
                                }
                            }

                            if (cityIDs.Count == 0) cityIDs.Add(0);
                            await mongoDbAdapter.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", product["_id"].AsObjectId),
                                    Builders<BsonDocument>.Update
                                    .AddToSetEach("city_ids", cityIDs)
                                    .Set("is_solr_updated", false)
                                    .CurrentDate("updated_at")
                                    , new UpdateOptions() { IsUpsert = false });

                            this.WriteLog(string.Format("Process for _id:{0} url:{1} province:{2}"
                                , (product["_id"] as BsonObjectId).ToString()
                                , product["url"].AsString
                                , Common.ConvertToString(cityIDs, ",")));
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                WriteLog(string.Format("Exception {0}:", ex.Message));
                Thread.Sleep(10000);
                return false;
            }
        }

        /// <summary>
        /// Phân tích từ khóa từ Product.
        /// </summary>
        /// <param name="arNumberWord"></param>
        /// <param name="useRegex"></param>
        public void AnalysicKeyWordFromNameProduct(int[] arNumberWord, bool useRegex)
        {
            try
            {
                MongoDbRaoVat mongoDb = new MongoDbRaoVat();
                while (true)
                {
                    while (this.bPause) Thread.Sleep(10000);
                    using (var cursor = mongoDb.colProduct.FindAsync(Builders<BsonDocument>.Filter.Eq
                        ("is_extract_keyword", false), new FindOptions<BsonDocument, BsonDocument>()
                        {
                            Limit = 100
                        }).Result)
                    {

                        Dictionary<long, KeywordSaleNew> lstResultKeyWord = new Dictionary<long, KeywordSaleNew>();
                        List<string> lstIdProductProcessed = new List<string>();
                        while (cursor.MoveNextAsync().Result)
                        {

                            //Khoi tao=>Toan QUoc
                            var batch = cursor.Current;
                            foreach (BsonDocument itemDocument in batch)
                            {
                                string strName = itemDocument["name"].AsString.ToLower().Trim();
                                lstIdProductProcessed.Add(itemDocument["_id"].AsObjectId.ToString());
                                string[] ar1 = GABIZ.Base.Tools.stringSeparate(strName);
                                foreach (string title in ar1)
                                {
                                    List<string> lstWordNGram = new List<string>();

                                    foreach (var item in arNumberWord)
                                    {
                                        lstWordNGram.AddRange(GABIZ.Base.Tools.NGramDocument(item, title));
                                    }

                                    for (int i = lstWordNGram.Count - 1; i >= 0; i--)
                                    {
                                        if (!(Common.ValidKeyword(lstWordNGram[i])
                                            && (useRegex == false || Common.ValidKeyWordGrammar(lstWordNGram[i]))))
                                            lstWordNGram.RemoveAt(i);
                                    }

                                    foreach (var itemCanKeyword in lstWordNGram)
                                    {
                                        long crcKeyword = Math.Abs(Common.GetID_Keywords64(itemCanKeyword));
                                        if (!lstResultKeyWord.ContainsKey(crcKeyword) && !CheckInBlackLink(mongoDb, crcKeyword))
                                        {
                                            List<int> lst = new List<int>();
                                            foreach (var itemCategory in itemDocument["category_ids"].AsBsonArray)
                                            {
                                                lst.Add(itemCategory.AsInt32);
                                            };
                                            lstResultKeyWord.Add(crcKeyword, new KeywordSaleNew()
                                            {
                                                crc = crcKeyword,
                                                category_ids = lst,
                                                name = itemCanKeyword,
                                                is_selected = false,
                                                slug = QT.Entities.Common.GetSplug(Name, false),
                                                priority = 0,
                                                status = 1,
                                                view_count = 0,
                                                score_gram = 1
                                            });
                                        }
                                        else
                                        {
                                            if (lstResultKeyWord.ContainsKey(crcKeyword))
                                            {
                                                lstResultKeyWord[crcKeyword].score_gram = lstResultKeyWord[crcKeyword].score_gram + 1;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        foreach (var keywordItem in lstResultKeyWord)
                        {
                            bool bInsert = false;
                            if (!mongoDb.CheckExistsKeyWord(keywordItem.Value.crc))
                            {
                                mongoDb.InsertKeyword(keywordItem.Value);
                                bInsert = true;
                            }
                            long iModify = mongoDb.IncrementScoreGramKeyWord(keywordItem.Value.crc).Result;
                            if (iModify > 0)
                            {
                                WriteLog(string.Format("{0} Keyword: {1}", ((bInsert) ? "Insert" : "Update"), keywordItem.Value.name));
                            }
                        }

                        long CountProductExtract = 0;
                        foreach (var item in lstIdProductProcessed)
                        {
                            var result = mongoDb.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(item)), Builders<BsonDocument>.Update
                                 .Set("is_extract_keyword", true), new UpdateOptions() { IsUpsert = false }).Result;
                            CountProductExtract += result.ModifiedCount;
                        }
                        WriteLog("Processed {0} product");
                    }
                }
            }
            catch (ThreadAbortException threadAbortEx)
            {
                return;
            }
        }

        private bool CheckInBlackLink(MongoDbRaoVat mongoDb, long idKeyword)
        {
            return mongoDb.CheckBlackLink(idKeyword);
        }

        private async Task<bool> AnalysicKeyword(int p, MongoDbRaoVat mongoDbAdapter, Dictionary<int, string> dicCity)
        {
            try
            {
                var builder = Builders<BsonDocument>.Filter;
                DateTime dt = new DateTime(2015, 9, 19, 11, 0, 0);
                using (var cursor = await mongoDbAdapter.colKeyWord.FindAsync(Builders<BsonDocument>.Filter.Lt
                    ("updated_at", new DateTime(2015,9,23,10,10,10)), new FindOptions<BsonDocument, BsonDocument>()
                    {
                        Limit = p
                    }))
                {
                    while (await cursor.MoveNextAsync())
                    {
                        var batch = cursor.Current;
                        foreach (var document in batch)
                        {
                            string strName = document["name"].AsString;
                            string strOldSlug = document["slug"].AsString;
                            string strNewSlug = QT.Entities.Common.GetSplug(strName, false);
                            if (strOldSlug!=strNewSlug)
                            {
                                await mongoDbAdapter.colKeyWord.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", document["_id"].AsObjectId),
                                    Builders<BsonDocument>.Update
                                    .Set("slug", strNewSlug)
                                    .CurrentDate("updated_at")
                                    , new UpdateOptions() { IsUpsert = false });
                            }
                            else
                            {
                                await mongoDbAdapter.colKeyWord.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", document["_id"].AsObjectId),
                                  Builders<BsonDocument>.Update
                                  .CurrentDate("updated_at")
                                  , new UpdateOptions() { IsUpsert = false });
                            }
                            this.WriteLog(string.Format("Fixed keyword:{0}. Slug:{1}->{2}"
                               , strName
                               , strOldSlug
                               , strNewSlug));
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                WriteLog(string.Format("Exception {0}:", ex.Message));
                Thread.Sleep(10000);
                return false;
            }
        }

        private void WriteLog(string p)
        {
            try
            {
                this.Invoke(new Action(() =>
                    {
                        if (richTextBox1.TextLength > 100000) richTextBox1.Clear();
                        else richTextBox1.AppendText(string.Format("\n {1}:{0} ", p, DateTime.Now.ToString("HH:mm:ss")));
                    }));
            }
            catch (Exception ex)
            {
                
            }
        }

        /// <summary>
        /// 2- Dịch lại thông tin nội bộ của product.
        /// </summary>
        public RaoVat.TypeRunSync TypeProcess { get; set; }

        private void FrmSyncData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.thread != null && this.thread.IsAlive) this.thread.Abort();
        }

        private void btnSoftCommit_Click(object sender, EventArgs e)
        {
            string Webdomain = "raovat";
            string URLSolrConnect = "http://183.91.14.85:8983/solr/keywords";

        }
    }
}
