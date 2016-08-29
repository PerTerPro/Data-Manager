using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManager
{
    public class OnlineFridayResult
    {
        public int error;
        public int total;
        public long server_time;
        public List<OnlineFridayProduct> data;
    }

    public class OnlineFridayProduct
    {
        public long? business_id;
        public int? category_id;
        public int? category_level;
        public string category_name;
        public int? click;
        public string cluster_id;
        public string cluster_id_wss;
        public long? creation_time;
        public string description;
        public float? discount;
        public string image;
        public string image_url;
        public string market_price;
        public string market_price_wss;
        public int? num_badreport;
        public int? original_price;
        public int? point;
        public long? product_id;
        public string product_name;
        public long? publish_time;
        public string reason;
        public string referer_promotion_id;
        public int? sale_price;
        public string share_url;
        public int? status;
        public long? update_time;
        public string url;
        public int? user_id;
        public int? view;
    }
}
