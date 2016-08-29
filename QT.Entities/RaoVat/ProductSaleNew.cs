using QT.Entities.Data;
using QT.Entities.Data.SolrDb.SaleNews;
using SolrNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Model.SaleNews
{
    public class ProductSaleNew
    {
      

        public static List<string> lst = new List<string>()
        {
            "nhattao.com",
            "muaban.net",
            "rongbay.com",
            "chotot.vn",
            "vatgia.com",
            "vozforums.com",
            "muare.vn",
            "5giay.vn",
            "enbac.com"
        };

        public bool IsDetailSucess
        {
            get
            {
                return id > 0
                    && !string.IsNullOrEmpty(name)
                    && source_updated_at != SqlDb.MinDateDb
                    && !(string.IsNullOrEmpty(web_category))
                    && (source_updated_at - DateTime.Now).TotalDays < 1;
            }
        }

        public string name_no_accent
        {
            get
            {
                return Common.UnicodeToKoDau(name);
            }
        }

        public static int Cat_Oto = 9;
        public static int CAT_DienThoai = 15;
        public static int CAT_MayTinhBang = 16;
        public static int CAT_MayTinh = 17;
        public static int CAT_Camera = 18;
        public static int CAT_DoCongNghe = 19;
        public static int CAT_XeMay = 10;
        public int wss_type_crawl;

        [SolrUniqueKey(SolrFieldSaleNew.created_at_product)]
        public DateTime created_at { get; set; }

        [SolrUniqueKey(SolrFieldSaleNew.source_name_product)]
        public string source_name { get; set; }

        [SolrUniqueKey(SolrFieldSaleNew.source_updated_at_product)]
        public DateTime source_updated_at { get; set; }

        [SolrUniqueKey(SolrFieldSaleNew.is_crawed_product)]
        public bool is_crawled { get; set; }

        [SolrUniqueKey(SolrFieldSaleNew.id_product)]
        [MongoDB.Bson.Serialization.Attributes.BsonElement("id")]
        public long id { set; get; }

        [SolrUniqueKey(SolrFieldSaleNew._id_product)]
        public string _id { get; set; }

        [SolrUniqueKey(SolrFieldSaleNew.updated_at_product)]
        public DateTime updated_at { get; set; }

        [SolrUniqueKey(SolrFieldSaleNew.city_ids)]
        public List<int> city_ids { get; set; }

        /// <summary>
        /// 0. Không duyệt trên site mình.
        /// 1. OK.
        /// 2. Đã đóng bên source
        /// 3. Not processed
        /// </summary>
     
        public int status { set; get; }
        /// <summary>
        /// 0. Chua phan loai
        /// </summary>
        [SolrUniqueKey(SolrFieldSaleNew.category_ids_product)]
        public List<int> category_ids { get; set; }





        public long classification_id { get; set; }
        public decimal change_price { get; set; }


       

        //[SolrUniqueKey(SolrFieldSaleNew.SOLR_FIELD_LAST_COMMENT)]
        //public DateTime last_comment { get; set; }
        public int wss_number_visited_link { get; set; }
        public int wss_index_product { get; set; }
        public int wss_deep_crawl { get; set; }

        public string contact_text
        {
            get
            {
                return
                    (string.IsNullOrEmpty(this.phone_saler) ? "" : this.phone_saler) + " " +
                    (string.IsNullOrEmpty(this.Saler) ? "" : this.Saler) + " " +
                    (string.IsNullOrEmpty(this.address) ? "" : this.address);
            }
        }

     

      

        /// <summary>
        /// Mã hóa Crc từ  Url (không schema)
        /// </summary>
    

       




        


        public int Category { get; set; }

        [SolrUniqueKey(SolrFieldSaleNew.slug_product)]
        public string slug { get; set; }


        public int ParentID { get; set; }

        [SolrUniqueKey(SolrFieldSaleNew.name_product)]
        public string name { get; set; }

        [SolrUniqueKey(SolrFieldSaleNew.thumb_url_product)]
        public string thumb_url { get; set; }


        public int order_index { get; set; }


        public bool is_standard { get; set; }

      
        public List<string> tags { get; set; }


        public string TagsString { get; set; }

        [SolrUniqueKey(SolrFieldSaleNew.description_product)]
        public string description { get; set; }

        [SolrUniqueKey(SolrFieldSaleNew.price_product)]
        public long price { get; set; }


        public DateTime post_date { get; set; }


        public string content { get; set; }

   
        public long Version { get; set; }

        [SolrUniqueKey(SolrFieldSaleNew.url_product)]
        public string url { get; set; }


       [SolrUniqueKey(SolrFieldSaleNew.view_count_product)]
        public int wss_view_count { get; set; }

        [SolrUniqueKey(SolrFieldSaleNew.source_view_count_product)]
        public int source_view_count { get; set; }

        public string phone_saler { get; set; }

        public string address { get; set; }

        public string quality { get; set; }

        public ProductSaleNew()
        {
            source_name = "";
            is_selected = false;
            category_ids = new List<int>() { 31 };
            status = 1;

            change_price = 1;
            web_category = "";
            quality = "";
            province = "";
            Avaiable = 0;
            name = "";
            phone_saler = "";
            address = "";
            post_date = SqlDb.MinDateDb;
            currency = "vnd";
            Phone_Image = null;
            website_id = 0;
            source_name = "";
            city_ids = new List<int>() { 0 };
            Saler = "";

            car_shoulder_room = "";
            car_all = "";
            car_bore = "";
            car_camshaft = "";
            car_compression_ratio = "";
            car_curb_weight = "";
            car_driver_type = "";
            car_engine_size = "";
            car_engine_type = "";
            car_epa_mpg = "";
            car_fuel_capacity = "";
            car_gross_vehicle_weight_for_trucks = "";
            car_head_room = "";
            car_height = "";
            car_horsepower = "";
            car_leg_room = "";
            car_length = "";
            car_number_of_cylinders = "";
            car_overall_length = "";
            car_payload_capacity_for_trucks = "";
            car_seating_capacity = "";
            car_stroke = ""; car_tires = "";
            car_torque = "";
            car_towing_capacity_max = "";
            car_transmission = "";
            car_valves_per_cylinder = "";
            car_wheelbase = "";
            car_width = "";
            car_cargo_capacity_for_cars = "";

            images = new List<string>();
            tags = new List<string>();
        }

        public override string ToString()
        {
            string str = ""
                + "\nSuccessData:" + this.IsDetailSucess.ToString()
                + "\nID:" + this.id
                + "\nTitle:" + this.name
                + "\nlast_edit:" + this.source_updated_at.ToString(Common.Format_DateTime)
                + "\nProvince:" + this.province
                + "\nWebCategory:" + this.web_category
                + "\nCategoryID:" + Common.ConvertToString(this.category_ids, ",")
                + "\nViewCount:" + this.source_view_count
                + "\nUrl:" + this.url
                + "\nTagsString:" + this.TagsString
                + "\nSlug:" + this.slug
                + "\nThumbUrl:" + this.thumb_url
                + "\nImageUrls:" + Common.ConvertToString(this.images)
                + "\nDescription:" + ((this.content.Length > 500) ? this.content.Substring(0, 500) : this.content)
                + "\nPrice:" + this.price.ToString();

            return str;
        }


        public string Marker { get; set; }
        public string TypeSim { get; set; }
        public string NumberSim { get; set; }
        public string OS { get; set; }
        public string SizeScreen { get; set; }
        public string TypeScreen { get; set; }
        public string Resolution { get; set; }

        public int Avaiable { get; set; }

        public string province { get; set; }

        public List<string> images { get; set; }

        public string web_category { get; set; }

        public byte[] Phone_Image { get; set; }

        [SolrUniqueKey(SolrFieldSaleNew.currency_product)]
        public string currency { get; set; }

        public Dictionary<string, string> extend_properties { get; set; }


        public int website_id { get; set; }



        public string Saler { get; set; }
        public string attribute_XuatXu { get; set; }
        public string attribute_MauNgoaiThat { get; set; }
        public string attribute_DongXe { get; set; }
        public string attribute_MauNoiThat { get; set; }

        public int attribute_SoCuaSo { get; set; }
        public string attribute_SoCuaSo_Solr
        {
            get
            {
                return attribute_SoCuaSo.ToString();
            }
        }

        public int attribute_SoChoNgoi { get; set; }

        public string attribute_SoChoNgoi_Solr
        {
            get
            {
                return attribute_SoChoNgoi.ToString();
            }
        }
        public string attribute_NhienLieu { get; set; }
        public string attribute_HeThongNapNhienLieu { get; set; }
        public string attribute_HopSo { get; set; }
        public string attribute_TieuThuNhienLieu { get; set; }
        public string attribute_DanDong { get; set; }
        public string car_driver_type { get; set; }
        public string car_engine_size { get; set; }
        public string car_number_of_cylinders { get; set; }
        public string car_horsepower { get; set; }
        public string car_torque { get; set; }
        public string car_compression_ratio { get; set; }
        public string car_camshaft { get; set; }
        public string car_engine_type { get; set; }
        public string car_bore { get; set; }
        public string car_stroke { get; set; }
        public string car_valves_per_cylinder { get; set; }
        public string car_epa_mpg { get; set; }
        public string car_fuel_capacity { get; set; }
        public string car_wheelbase { get; set; }
        public string car_overall_length { get; set; }
        public string car_width { get; set; }
        public string car_height { get; set; }
        public string car_curb_weight { get; set; }
        public string car_leg_room { get; set; }
   
        public string car_head_room { get; set; }
        
        public string car_seating_capacity { get; set; }
        
        public string car_cargo_capacity_for_cars { get; set; }
      
        public string car_towing_capacity_max { get; set; }
        
        public string car_payload_capacity_for_trucks { get; set; }
       
        public string car_gross_vehicle_weight_for_trucks { get; set; }
      
        public string car_tires { get; set; }
      
        public string car_transmission { get; set; }
        
        public string car_all { get; set; }

        public string ImageUrlWait { get; set; }

    
        public string car_length { get; set; }

   
        public string car_shoulder_room { get; set; }

       
        public string car_rear_head_room { get; set; }
       
        public string car_rear_leg_room { get; set; }
     
        public string car_rear_shoulder_room { get; set; }
      
        public string car_fuel_type { get; set; }
     
        public string car_range_in_miles { get; set; }
      
        public string car_epa_mileage_est { get; set; }

        public string car_epa_interior_volume { get; set; }
      
        public string car_maximum_payload { get; set; }
    
        public string car_gross_weight { get; set; }
      
        public string car_cargo_maximum_cargo_capacity { get; set; }
     
        public string car_cargo_capacity_all_seats_in_place { get; set; }
     
        public string car_camp_type { get; set; }
     
        public string car_cylinders { get; set; }
  
        public string car_basic { get; set; }
   
        public string car_drive_train { get; set; }
        public string car_free_maintenance { get; set; }
     
        public string car_turning_circle { get; set; }
      
        public string car_basic_warranty { get; set; }
    
        public string car_bluetooth { get; set; }
      
        public string car_heated_seats { get; set; }
    
        public string car_total_seating { get; set; }
       
        public string car_consumer_rating { get; set; }
      
        public string car_navigation { get; set; }

        public int SubCategoryID { get; set; }

        public string car_price_msrp { get; set; }

        public string car_color { get; set; }

        public int have_price
        {
            get
            {
                return (this.price < 10000) ? 0 : 1;
            }
        }

      

        public bool is_selected { get; set; }

        public int[] term_ids { get; set; }

        public List<int> keyword_ids { get; set; }

       
    }
}
