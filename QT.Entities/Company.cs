using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QT.Entities
{
    [ProtoBuf.ProtoContract]
    public class Company
    {

        public Configuration config { get; set; }

        public enum DataFeedType
        {
            None = 0,
            AllProductsFromFile = 1,
            AllProductsFromURL = 2,
            SpecialProductsFromFile = 3,
            SpecialProductsFromUrl = 4,
            MasOfferDatafeed =5
        };
        
        private DB.CompanyDataTable _dt;
        private DBTableAdapters.CompanyTableAdapter _adt;
        private DBTableAdapters.ProductTableAdapter _adtProduct;
        private DBTableAdapters.ManagerTypeRCompanyTableAdapter _adtmanagerTypeRCompany;
        public string TestLink;
        public int VATStatus { get; set; }

        [ProtoBuf.ProtoMember(27)]
        public long ID { get; set; }

        [ProtoBuf.ProtoMember(1)]
        public string Name { get; set; }

         [ProtoBuf.ProtoMember(2)]
        public string Description { get; set; }

         [ProtoBuf.ProtoMember(3)]
        public string Website { get; set; }

         [ProtoBuf.ProtoMember(4)]
        public string Domain { get; set; }

         [ProtoBuf.ProtoMember(5)]
        public DateTime AddDate { get; set; }

         [ProtoBuf.ProtoMember(6)]
        public string Phone { get; set; }

         public bool notVisibleProduct { get; set; }

         [ProtoBuf.ProtoMember(7)]
        public string Fax { get; set; }

         [ProtoBuf.ProtoMember(8)]
        public string Yahoo { get; set; }

         [ProtoBuf.ProtoMember(9)]
        public string Address { get; set; }

         [ProtoBuf.ProtoMember(10)]
        public Byte Status { get; set; }

         [ProtoBuf.ProtoMember(11)]
        public String DataFeedPath { get; set; } //DataFeedUrl or File Path

         [ProtoBuf.ProtoMember(12)]
        public DataFeedType CompanyDataFeedType { get; set; }

         [ProtoBuf.ProtoMember(13)]
        public TimeSpan UpdateDataFeedFrequency { get; set; }

         [ProtoBuf.ProtoMember(14)]
        public DateTime LastUpdateDataFeedTime { get; set; }

         [ProtoBuf.ProtoMember(15)]
        public string Image { get; set; }

         [ProtoBuf.ProtoMember(16)]
        public int PageRank { get; set; }

         [ProtoBuf.ProtoMember(17)]
        public int AlexaRank { get; set; }

         [ProtoBuf.ProtoMember(18)]
        public TimeSpan TimeStartUp { get; set; }

         [ProtoBuf.ProtoMember(19)]
        public int TimeDelay { get; set; }

         [ProtoBuf.ProtoMember(20)]
        public int TotalProduct { get; set; }

         [ProtoBuf.ProtoMember(21)]
        public DateTime LastCrawler { get; set; }

         [ProtoBuf.ProtoMember(22)]
        public int FullCrawlerDay { get; set; }

         [ProtoBuf.ProtoMember(23)]
        public TimeSpan TimeSleep { get; set; }

         [ProtoBuf.ProtoMember(24)]
        public DateTime LastFullCrawler { get; set; }

        //User and Password của URL datafeed
         [ProtoBuf.ProtoMember(25)]
        public string UserDatafeed { set; get; }

         [ProtoBuf.ProtoMember(26)]
        public string PasswordDatafeed { set; get; }

         //IDType trong bảng ManagerTypeRCompany
         public int IDManagerType { set; get; }
       
        public Company ()
        {
        }

        public Company(long id)
        {
            this.MaxHourCrawlerReload = 7;

            ID = id;
            _adt = new DBTableAdapters.CompanyTableAdapter();
            _dt = new DB.CompanyDataTable();
            _adt.Connection.ConnectionString = Server.ConnectionString;

            //_adt.Connection.Open();
            _adt.FillBy_ID(_dt, ID);
            //_adt.Connection.Close();

            _adtProduct = new DBTableAdapters.ProductTableAdapter();
            _adtProduct.Connection.ConnectionString = Server.ConnectionString;
            if (_dt.Rows.Count > 0)
            {
                Name = _dt.Rows[0]["Name"].ToString();
                Description = _dt.Rows[0]["Description"].ToString();
                Website = _dt.Rows[0]["Website"].ToString();
                Domain = _dt.Rows[0]["Domain"].ToString();
                AddDate = Common.ObjectToDataTime(_dt.Rows[0]["AddDate"].ToString());
                Phone = _dt.Rows[0]["Phone"].ToString();
                Fax = _dt.Rows[0]["Fax"].ToString();
                Yahoo = _dt.Rows[0]["Yahoo"].ToString();
                Address = _dt.Rows[0]["Address"].ToString();
                Status = Common.Obj2Byte(_dt.Rows[0]["Status"].ToString());
                //UseDataFeed = _dt.Rows[0]["UseDataFeed"] != DBNull.Value && (Boolean) _dt.Rows[0]["UseDataFeed"];
                Image = _dt.Rows[0]["Image"].ToString();
                PageRank = Common.Obj2Int(_dt.Rows[0]["PageRank"].ToString());
                AlexaRank = Common.Obj2Int(_dt.Rows[0]["AlexaRank"].ToString());
                //
                TimeDelay = Common.Obj2Int(_dt.Rows[0]["TimeDelay"].ToString());
                TotalProduct = Common.Obj2Int(_dt.Rows[0]["TotalProduct"].ToString());
                LastCrawler = Common.ObjectToDataTime(_dt.Rows[0]["LastCrawler"].ToString());
                FullCrawlerDay = Common.Obj2Int(_dt.Rows[0]["FullCrawlerDay"].ToString());
                //
                LastFullCrawler = Common.ObjectToDataTime(_dt.Rows[0]["LastCrawler"].ToString());
                //DaatFeed
                DataFeedPath = Common.Obj2String(_dt.Rows[0]["DataFeedUrl"].ToString());
                
                LastUpdateDataFeedTime = Common.ObjectToDataTime(_dt.Rows[0]["LastUpdateDataFeed"]);
                UpdateDataFeedFrequency = new TimeSpan(Common.Obj2Int(_dt.Rows[0]["UpdateFreq"]), 0, 0);
                CompanyDataFeedType = (DataFeedType)Common.Obj2Int(_dt.Rows[0]["DataFeedType"]);

                //User and Password của URL datafeed
                UserDatafeed = Common.Obj2String(_dt.Rows[0]["UserDatafeed"].ToString());
                PasswordDatafeed = Common.Obj2String(_dt.Rows[0]["PasswordDatafeed"].ToString());
                notVisibleProduct = (_dt.Rows[0]["NotVisibleProduct"] == DBNull.Value) ? false : Common.Obj2Bool(_dt.Rows[0]["NotVisibleProduct"]);

                AllowAutoPushNewProduct = Common.Obj2Bool(_dt.Rows[0]["AllowAutoPushNewProduct"]);
                AllowAutoBlackLink = Common.Obj2Bool(_dt.Rows[0]["AllowAutoBlackLink"]);
                ClearQueueWhenFN = Common.Obj2Bool(_dt.Rows[0]["ClearQueueWhenFN"]);
                /*
                 *   public String DataFeedPath { get; set; } //DataFeedUrl or File Path
        public DataFeedType CompanyDataFeedType { get; set; }
        public TimeSpan UpdateDataFeedFrequency { get; set; }
        public DateTime LastUpdateDataFeedTime { get; set; }
                 */

                #region Lấy Type của công ty
                _adtmanagerTypeRCompany = new DBTableAdapters.ManagerTypeRCompanyTableAdapter();
                _adtmanagerTypeRCompany.Connection.ConnectionString = Server.ConnectionString;
                DB.ManagerTypeRCompanyDataTable managerTable = new DB.ManagerTypeRCompanyDataTable();
                try
                {
                    _adtmanagerTypeRCompany.FillBy_IDCompany(managerTable, ID);
                }
                catch (Exception)
                {
                }
                if (managerTable.Rows.Count > 0)
                {
                    IDManagerType = Common.Obj2Int(managerTable.Rows[0]["IDType"].ToString());
                }
                else IDManagerType = 0;
                #endregion
            }
            else Name = "Not In Database";
        }
        public void UpdateAfterCrawler(bool full)
        {
            try
            {
                _adt.Connection.Open();
                _adtProduct.Connection.Open();
                int count = (int)Convert.ToInt32(_adtProduct.Product_SelectCountCompanyID(ID));
                if (full)
                {
                    _adt.UpdateQuery_TotalProduct_LastCrawler(count, DateTime.Now, ID);
                }
                else
                {
                    _adt.UpdateQuery_TotalProduct(count, ID);
                }
                _adt.Connection.Close();
                _adtProduct.Connection.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
       
        ~Company()
        {

            //_dt.Dispose();
            //_adt.Connection.Close();
            //_adt.Dispose();
            //_adtProduct.Connection.Close();
            //_adtProduct.Dispose();
        }

        public bool AllowAutoPushNewProduct { get; set; }

        public bool AllowAutoBlackLink { get; set; }

        public int MaxHourCrawlerReload { get; set; }

        public bool ClearQueueWhenFN { get; set; }
    }
}
