using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Cassandra;
using System.Data;
using System.Data.Common;
using QT.Entities.Model.SaleNews;
using System.Text.RegularExpressions;
using QT.Entities.RaoVat;

namespace QT.Entities.Data
{
    public class CassandraDb
    {
        string queryTotalProductByConfigID = @"select count(*) from sale.product where config_crawl_id = {0}";
        string querySelectIdProduct = @"select id from product where id = {0}";
        string queryInsertProduct = @"INSERT INTO product (id) VALUES ({0})";
        string querySelectProduct = @"SELECT * FROM product WHERE id = {0}";
        string queryUpdateReloadFail = @"update product set wss_number_reload_fail=1 where id = {0}";
        string queryUpdateProduct = @"UPDATE product SET 
   title={1}
, phone_saler={2}
, address={3}
, price={4}
, content={5}
, quality={6}
, avaiable={7}
, post_date={8}
, last_change={9}
, url = {10}
, web_category = {11}
, wss_last_update = {12}
, config_crawl_id = {13}
, tag = {14}
, images = {15}
, car_all={17}
, car_basic={18}
, car_basic_warranty={19}
, car_bluetooth={20}
, car_bore={21}
, car_camp_type={22}
, car_camshaft={23}
, car_compression_ratio={24}
, car_consumer_rating={25}
, car_curb_weight={26}
, car_cylinders={27}
, car_drive_train={28}
, car_driver_type={29}
, car_engine_size={30}
, car_engine_type={31}
, car_epa_interior_volume={32}
, car_epa_mileage_est={33}
, car_epa_mpg={34}
, car_free_maintenance={35}
, car_fuel_capacity={36}
, car_fuel_type={37}
, car_gross_vehicle_weight_for_trucks={38}
, car_gross_weight={39}
, car_head_room={40}
, car_heated_seats={41}
, car_height={42}
, car_horsepower={43}
, car_leg_room={44}
, car_length={45}
, car_maximum_payload={46}
, car_navigation={47}
, car_number_of_cylinders={48}
, car_overall_length={49}
, car_payload_capacity_for_trucks={50}
, car_price_msrp={51}
, car_range_in_miles={52}
, car_rear_head_room={53}
, car_rear_leg_room={54}
, car_rear_shoulder_room={55}
, car_seating_capacity={56}
, car_shoulder_room={57}
, car_stroke={58}
, car_tires={59}
, car_torque={60}
, car_total_seating={61}
, car_towing_capacity_max={62}
, car_transmission={63}
, car_turning_circle={64}
, car_valves_per_cylinder={65}
, car_wheelbase={66}
, car_width={67}
, car_cargo_capacity_all_seats_in_place={68}
, car_cargo_capacity_for_cars={69}
, car_cargo_maximum_cargo_capacity = {70}
, wss_number_reload_fail = {71}
, last_edit = {72}
, last_comment = {73}
where id = {0}";

        private static readonly ILog log = LogManager.GetLogger(typeof(CassandraDb));
        private static CassandraDb instance;
        private static object syncRoot = new Object();
        private const String HOST1 = "10.0.0.11";
        private const String HOST2 = "10.0.0.12";
        private const String HOST3 = "10.0.0.13";
        private const String HOST4 = "10.0.0.14";
        private const String CRAWLER_KEYSPACE = "sale";
        private const String CRAWLER_WEBPAGE_TABLE = "product";
        public Cluster _Cluster { get; private set; }
        public ISession _session { get; private set; }

        private PreparedStatement PreUpdateLastConfig;
        private PreparedStatement PreUpdateConfig;
        private PreparedStatement PreInsertProductNewSale;
        private PreparedStatement PreparedSelectConfig;
        private PreparedStatement PreCheckExitProductNewSale;
        private PreparedStatement PreSelectProductNewSale;

        public static CassandraDb Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            log.Info("New cassandra instance");
                            instance = new CassandraDb();
                        }
                    }
                }
                return instance;
            }
        }
        private CassandraDb()
        {
            Connect();
            Init();
        }
        private void Connect()
        {
            _Cluster = Cluster.Builder()
                 .AddContactPoint(HOST1).AddContactPoint(HOST2).AddContactPoint(HOST3).AddContactPoint(HOST4)
                 .WithCompression(CompressionType.NoCompression)
                 .Build();
            log.Info("Connected to cluster: " + _Cluster.Metadata.ClusterName.ToString());
            foreach (var host in _Cluster.Metadata.AllHosts())
            {
                log.Info("Data Center: " + host.Datacenter + ", " +
                    "Host: " + host.Address + ", " +
                    "Rack: " + host.Rack);
            }
            _session = _Cluster.Connect(CRAWLER_KEYSPACE);
        }
        private void Close()
        {
            _Cluster.Shutdown();
        }
        void Init()
        {
            string strPreUpdateProduct = Regex.Replace(this.queryUpdateProduct, @"{\d*}", "?");
            string strPreSElectProduct = Regex.Replace(this.querySelectProduct, @"{\d*}", "?");
            string strPreInsertProduct = Regex.Replace(this.queryInsertProduct, @"{\d*}", "?");
            string strPreSelectIdProduct = Regex.Replace(this.querySelectIdProduct, @"{\d*}", "?");
            string strPreUpdateReloadFail = Regex.Replace(this.queryUpdateReloadFail, @"{\d*}", "?");
            string strPreTotalProductByConfigID = Regex.Replace(this.queryTotalProductByConfigID, @"{\d*}", "?");

            this.PreTotalProductByConfigID = _session.Prepare(strPreTotalProductByConfigID);
            this.PreInsertProductNewSale = _session.Prepare(strPreInsertProduct);
            this.PreUpdateNewSale = _session.Prepare(strPreUpdateProduct);
            this.PreSelectProductNewSale = _session.Prepare(strPreSElectProduct);
            this.PreCheckExitProductNewSale = _session.Prepare(strPreSelectIdProduct);
            this.PreUpdateReloadFailProduct = _session.Prepare(strPreUpdateReloadFail);
        }


        public ProductSaleNew GetProductById(long ProductID)
        {
            RowSet rowSet = this._session.Execute(string.Format("SELECT * FROM sale.product WHERE id = {0} ", ProductID));
            IEnumerable<Row> rows = rowSet.GetRows();
            ProductSaleNew product = new ProductSaleNew();
            foreach (Row row in rows)
            {
                ParseProduct(ref product, row);
                return product;
            }
            return product;
        }

        private void ParseProduct(ref ProductSaleNew product, Row row)
        {
            //product.id = Common.CellToInt64(row, "id", 0);
            //product.name = Common.CellToString(row, "title", "");
            //product.phone_saler = Common.CellToString(row, "phone_saler", "");
            //product.address = Common.CellToString(row, "address", "");
            //product.price = Convert.ToInt64(Common.CellToInt64(row, "price", 0));
            //product.content = Common.CellToString(row, "content", "");
            //product.quality = Common.CellToString(row, "quality", "");
            //product.Avaiable = Common.CellToInt(row, "avaiable", 0);
            //product.post_date = Common.CellToDateTime(row, "post_date", SqlDb.MinDateDb);
            //product.last_edit = DateTime.Now;
            //product.url = Common.CellToString(row, "url", "");
            //product.web_category = Common.CellToString(row, "web_category", "");
            //product.wss_last_update = Common.CellToDateTime(row, "wss_last_update", SqlDb.MinDateDb);
            //product.website_id = Common.CellToInt(row, "config_crawl_id", 0);
            //product.tags = Common.ConvertToList(Common.CellToString(row, "tag", ""));
            //product.images = Common.ConvertToList(Common.CellToString(row, "images", ""));
            //product.car_all = Common.CellToString(row, "car_all", "");
            //product.car_basic = Common.CellToString(row, "car_basic", "");
            //product.car_basic_warranty = Common.CellToString(row, "car_basic_warranty", "");
            //product.car_bluetooth = Common.CellToString(row, "car_bluetooth", "");
            //product.car_bore = Common.CellToString(row, "car_bore", "");
            //product.car_camp_type = Common.CellToString(row, "car_camp_type", "");
            //product.car_camshaft = Common.CellToString(row, "car_camshaft", "");
            //product.car_compression_ratio = Common.CellToString(row, "car_compression_ratio", "");
            //product.car_consumer_rating = Common.CellToString(row, "car_consumer_rating", "");
            //product.car_compression_ratio = Common.CellToString(row, "car_compression_ratio", "");
            //product.car_consumer_rating = Common.CellToString(row, "car_consumer_rating", "");
            //product.car_curb_weight = Common.CellToString(row, "car_curb_weight", "");
            //product.car_cylinders = Common.CellToString(row, "car_cylinders", "");
            //product.car_drive_train = Common.CellToString(row, "car_drive_train", "");
            //product.car_driver_type = Common.CellToString(row, "car_driver_type", "");
            //product.car_engine_size = Common.CellToString(row, "car_engine_size", "");
            //product.car_engine_type = Common.CellToString(row, "car_engine_type", "");
            //product.car_epa_interior_volume = Common.CellToString(row, "car_epa_interior_volume", "");
            //product.car_epa_mileage_est = Common.CellToString(row, "car_epa_mileage_est", "");
            //product.car_epa_mpg = Common.CellToString(row, "car_epa_mpg", "");
            //product.car_free_maintenance = Common.CellToString(row, "car_free_maintenance", "");
            //product.car_fuel_capacity = Common.CellToString(row, "car_fuel_capacity", "");
            //product.car_fuel_type = Common.CellToString(row, "car_fuel_type", "");
            //product.car_gross_vehicle_weight_for_trucks = Common.CellToString(row, "car_gross_vehicle_weight_for_trucks", "");
            //product.car_gross_weight = Common.CellToString(row, "car_gross_weight", "");
            //product.car_head_room = Common.CellToString(row, "car_head_room", "");
            //product.car_heated_seats = Common.CellToString(row, "car_heated_seats", "");
            //product.car_horsepower = Common.CellToString(row, "car_horsepower", "");
            //product.car_height = Common.CellToString(row, "car_height", "");
            //product.car_leg_room = Common.CellToString(row, "car_leg_room", "");
            //product.car_length = Common.CellToString(row, "car_length", "");
            //product.car_maximum_payload = Common.CellToString(row, "car_maximum_payload", "");
            //product.car_navigation = Common.CellToString(row, "car_navigation", "");
            //product.car_number_of_cylinders = Common.CellToString(row, "car_number_of_cylinders", "");
            //product.car_overall_length = Common.CellToString(row, "car_overall_length", "");
            //product.car_payload_capacity_for_trucks = Common.CellToString(row, "car_payload_capacity_for_trucks", "");
            //product.car_price_msrp = Common.CellToString(row, "car_price_msrp", "");
            //product.car_range_in_miles = Common.CellToString(row, "car_range_in_miles", "");
            //product.car_rear_head_room = Common.CellToString(row, "car_rear_head_room", "");
            //product.car_rear_leg_room = Common.CellToString(row, "car_rear_leg_room", "");
            //product.car_rear_shoulder_room = Common.CellToString(row, "car_rear_shoulder_room", "");
            //product.car_seating_capacity = Common.CellToString(row, "car_seating_capacity", "");
            //product.car_shoulder_room = Common.CellToString(row, "car_shoulder_room", "");
            //product.car_stroke = Common.CellToString(row, "car_stroke", "");
            //product.car_tires = Common.CellToString(row, "car_tires", "");
            //product.car_torque = Common.CellToString(row, "car_torque", "");
            //product.car_total_seating = Common.CellToString(row, "car_total_seating", "");
            //product.car_towing_capacity_max = Common.CellToString(row, "car_towing_capacity_max", "");
            //product.car_transmission = Common.CellToString(row, "car_transmission", "");
            //product.car_turning_circle = Common.CellToString(row, "car_turning_circle", "");
            //product.car_valves_per_cylinder = Common.CellToString(row, "car_valves_per_cylinder", "");
            //product.car_wheelbase = Common.CellToString(row, "car_wheelbase", "");
            //product.car_width = Common.CellToString(row, "car_width", "");
            //product.car_cargo_capacity_all_seats_in_place = Common.CellToString(row, "car_cargo_capacity_all_seats_in_place", "");
            //product.car_cargo_capacity_for_cars = Common.CellToString(row, "car_cargo_capacity_for_cars", "");
            //product.car_cargo_maximum_cargo_capacity = Common.CellToString(row, "car_cargo_maximum_cargo_capacity", "");
        }

        public int GetViewCount(long ProductID)
        {
            RowSet rs = this._session.Execute(string.Format("SELECT wss_view_count FROM sale.product where id = {0}", ProductID));
            if (rs.Count<Row>() == 0) return 0;
            try
            {
                return Common.Obj2Int(rs.First<Row>()["wss_view_count"]);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public bool SaveProductSaleNew(QT.Entities.Model.SaleNews.ProductSaleNew pro)
        {
            try
            {
                string value = Common.ConvertArByeToString(pro.Phone_Image) == null ? "" : Common.ConvertArByeToString(pro.Phone_Image);
                if (!this.CheckExistProductNewSale(pro.id))
                {
                    string query = string.Format(@"INSERT INTO product (id) values ({0})", pro.id);
                    _session.Execute(query);
                }
                string queryUpdate = string.Format(this.queryUpdateProduct
                    , Common.GetParaForCassDb(pro.id)
                    , Common.GetParaForCassDb(pro.name)
                    , Common.GetParaForCassDb(pro.phone_saler)
                    , Common.GetParaForCassDb(pro.address)
                    , Common.GetParaForCassDb(pro.price)
                    , Common.GetParaForCassDb(pro.content)
                    , Common.GetParaForCassDb(pro.quality)
                    , Common.GetParaForCassDb(pro.Avaiable)
                    , Common.GetParaForCassDb(pro.post_date.ToString(Common.Format_DateTime))
                    , Common.GetParaForCassDb(pro.source_updated_at.ToString(Common.Format_DateTime))
                    , Common.GetParaForCassDb(pro.url)
                    , Common.GetParaForCassDb(pro.web_category)
                    , Common.GetParaForCassDb(DateTime.Now.ToString(Common.Format_DateTime))
                    , Common.GetParaForCassDb(pro.website_id)
                    , Common.GetParaForCassDb(pro.TagsString)
                    , Common.GetParaForCassDb(Common.ConvertToString(pro.images))
                    , ""
                    , Common.GetParaForCassDb(pro.car_all)
                    , Common.GetParaForCassDb(pro.car_basic)
                    , Common.GetParaForCassDb(pro.car_basic_warranty)
                    , Common.GetParaForCassDb(pro.car_bluetooth)
                    , Common.GetParaForCassDb(pro.car_bore)
                    , Common.GetParaForCassDb(pro.car_camp_type)
                    , Common.GetParaForCassDb(pro.car_camshaft)
                    , Common.GetParaForCassDb(pro.car_compression_ratio)
                    , Common.GetParaForCassDb(pro.car_consumer_rating)
                    , Common.GetParaForCassDb(pro.car_curb_weight)
                    , Common.GetParaForCassDb(pro.car_cylinders)
                    , Common.GetParaForCassDb(pro.car_drive_train)
                    , Common.GetParaForCassDb(pro.car_driver_type)
                    , Common.GetParaForCassDb(pro.car_engine_size)
                    , Common.GetParaForCassDb(pro.car_engine_type)
                    , Common.GetParaForCassDb(pro.car_epa_interior_volume)
                    , Common.GetParaForCassDb(pro.car_epa_mileage_est)
                    , Common.GetParaForCassDb(pro.car_epa_mpg)
                    , Common.GetParaForCassDb(pro.car_free_maintenance)
                    , Common.GetParaForCassDb(pro.car_fuel_capacity)
                    , Common.GetParaForCassDb(pro.car_fuel_type)
                    , Common.GetParaForCassDb(pro.car_gross_vehicle_weight_for_trucks)
                    , Common.GetParaForCassDb(pro.car_gross_weight)
                    , Common.GetParaForCassDb(pro.car_head_room)
                    , Common.GetParaForCassDb(pro.car_heated_seats)
                    , Common.GetParaForCassDb(pro.car_height)
                    , Common.GetParaForCassDb(pro.car_horsepower)
                    , Common.GetParaForCassDb(pro.car_leg_room)
                    , Common.GetParaForCassDb(pro.car_length)
                    , Common.GetParaForCassDb(pro.car_maximum_payload)
                    , Common.GetParaForCassDb(pro.car_navigation)
                    , Common.GetParaForCassDb(pro.car_number_of_cylinders)
                    , Common.GetParaForCassDb(pro.car_overall_length)
                    , Common.GetParaForCassDb(pro.car_payload_capacity_for_trucks)
                    , Common.GetParaForCassDb(pro.car_price_msrp)
                    , Common.GetParaForCassDb(pro.car_range_in_miles)
                    , Common.GetParaForCassDb(pro.car_rear_head_room)
                    , Common.GetParaForCassDb(pro.car_rear_leg_room)
                    , Common.GetParaForCassDb(pro.car_rear_shoulder_room)
                    , Common.GetParaForCassDb(pro.car_seating_capacity)
                    , Common.GetParaForCassDb(pro.car_shoulder_room)
                    , Common.GetParaForCassDb(pro.car_stroke)
                    , Common.GetParaForCassDb(pro.car_tires)
                    , Common.GetParaForCassDb(pro.car_torque)
                    , Common.GetParaForCassDb(pro.car_total_seating)
                    , Common.GetParaForCassDb(pro.car_towing_capacity_max)
                    , Common.GetParaForCassDb(pro.car_transmission)
                    , Common.GetParaForCassDb(pro.car_turning_circle)
                    , Common.GetParaForCassDb(pro.car_valves_per_cylinder)
                    , Common.GetParaForCassDb(pro.car_wheelbase)
                    , Common.GetParaForCassDb(pro.car_width)
                    , Common.GetParaForCassDb(pro.car_cargo_capacity_all_seats_in_place)
                    , Common.GetParaForCassDb(pro.car_cargo_capacity_for_cars)
                    , Common.GetParaForCassDb(pro.car_cargo_maximum_cargo_capacity)
                    , "1"
                    , Common.GetParaForCassDb(pro.source_updated_at.ToString(Common.Format_DateTime))
                    , Common.GetParaForCassDb(DateTime.Now.ToString())
                    );
                _session.Execute(queryUpdate);
                return true;
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Exception cassandra:{0}", ex.Message);
                return false;
            }
        }

        private void NomarlineTextCass(string p)
        {
            throw new NotImplementedException();
        }



        private bool CheckExistProductNewSale(long ID)
        {
            string query = string.Format("SELECT id FROM product WHERE id = {0}", ID);
            RowSet rowSet = this._session.Execute(query);
            int i = rowSet.Count<Row>();
            return i > 0;
        }

        public ConfigXPaths GetConfigByID(int ConfigID)
        {
            ConfigXPaths config = null;
            RowSet rows = this._session.Execute(string.Format("SELECT * FROM Config_Crawl WHERE ID = {0}", ConfigID), 1);
            if (rows.Info.TriedHosts.Count == 1)
            {
                foreach (Row row in rows)
                {
                    config = new ConfigXPaths();
                    config.ID = Convert.ToInt32(row.GetValue(typeof(int), CassandraColumn.id));
                    config.AddressXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.address_xpaths));
                    config.AvaiableXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.avaiable_xpaths));
                    config.CategoryXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.category_xpaths));
                    config.ContentXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.content_xpaths));
                    config.ImageUrlsXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.image_url_xpaths));
                    config.ProvinceXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.province_xpaths));
                    config.QualityXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.quality_xpaths));
                    config.ThumbUrlXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.thumb_url_xpaths));
                    config.TitleXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.title_xpaths));
                    config.WebCategoryXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.web_category_xpaths));
                    config.PostDateXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.post_date_xpaths));
                    config.LastChangeXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.last_change_xpaths));
                    config.PhoneSalerXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.phone_saler_xpaths));
                    config.PriceXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.price_xpaths));
                    config.WebCategoryXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.web_category_xpaths));
                    config.UserNameXPaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.saler_name_xpaths));

                    config.UrlTest = row.GetValue<string>(CassandraColumn.url_test);
                    config.TimeDelay = Common.Obj2Int(row.GetValue(typeof(string), CassandraColumn.time_delay));
                    config.ItemReCrawler = Common.Obj2Int(row.GetValue(typeof(string), CassandraColumn.item_recrawl));
                    config.CategoryID = Common.Obj2Int(row.GetValue(typeof(string), CassandraColumn.category_id));

                    config.NoVisitUrlRegex = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.novisit_url_regex));
                    config.NoProductUrlRegex = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.noproduct_url_regex));
                    config.ProductUrlsRegex = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.product_url_regex));
                    config.VisitUrlsRegex = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.visit_url_regex));
                    config.tags_xpaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.tags_xpaths));

                    string str = row.GetValue<string>(CassandraColumn.extend_xpaths);
                    if (!string.IsNullOrEmpty(str))
                        config.extend_xpaths = str.Split(new char[] { '\n' }, 200, StringSplitOptions.RemoveEmptyEntries).ToList();

                    config.spe_car_carmaker_xpaths = Common.GetListXPathFromString(row.GetValue<string>(CassandraColumn.spe_car_carmaker_xpaths));
                    return config;
                }
            }
            return null;
        }

     


        public PreparedStatement PreparedInsertConfig = null;

        public PreparedStatement PreUpdateNewSale = null;
        private PreparedStatement PreUpdateReloadFailProduct;
        private PreparedStatement PreTotalProductByConfigID;

        public RowSet GetTblConfigXPath()
        {
            return this._session.Execute("SElECT ID, Root_Link, category_id From config_crawl limit 1000");
        }

        public IEnumerable<ProductSaleNew> GetTblProduct(int ConfigID)
        {
            List<ProductSaleNew> lst = new List<ProductSaleNew>();
            RowSet rowSetProduct = this._session.Execute(string.Format("SELECT * FROM sale.product WHERE ID = {0}", ConfigID));
            foreach (Row row in rowSetProduct)
            {
                lst.Add(ParesProductFromRow(row));
            }
            return lst;
        }

        private ProductSaleNew ParesProductFromRow(Row row)
        {
            ProductSaleNew product = new ProductSaleNew();
            product.id = Common.Obj2Int64(row["ID"]);
            product.address = Common.Obj2String(row["address"]);
            product.Avaiable = Common.Obj2Int(row["avaiable"]);
            product.website_id = Common.Obj2Int(row["config_crawl_id"]);
            product.content = Common.Obj2String(row["content"]);
            product.is_standard = Common.Obj2Bool(row["is_standard"]);
            product.source_updated_at = Common.ObjectToDataTime(row["last_change"]);
            product.phone_saler = Common.Obj2String(row["phone_saler"]);
            product.post_date = Common.ObjectToDataTime(row["post_date"]);
            product.price = Convert.ToInt64(Common.Obj2Decimal(row["price"]));
            product.province = Common.Obj2String(row["province"]);
            product.quality = Common.Obj2String(row["quality"]);
            product.tags = Common.GetListXPathFromString(Common.Obj2String(row["tags"]));
            product.name = Common.Obj2String(row["title"]);
            product.url = Common.Obj2String(row["url"]);
            product.web_category = Common.Obj2String(row["web_category"]);
            product.address = Common.Obj2String(row["address"]);

            return product;
        }

        public void SaveLastCrawl(int categoryID)
        {


        }

        public void UpdateReloadFailProduct(long productID)
        {
            try
            {
                string queryUpdate = string.Format(this.queryUpdateReloadFail, "1");
                this._session.Execute(queryUpdate);
            }
            catch (Exception ex)
            {
                log.ErrorFormat(ex.Message);
            }
        }

        public int GetTotalProductByConfigID(int configID)
        {
            string query = string.Format(this.queryTotalProductByConfigID, configID);
            var totalResutl = this._session.Execute(query);
            foreach (Row row in totalResutl)
            {
                return Convert.ToInt32(row[0]);
            }
            return 0;
        }
    }
}
