using QT.Entities.Data.SolrDb.SaleNews;
using SolrNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Model.SaleNews
{
    public class ProductStandard
    {
        public ProductStandard()
        {
            XuatXu = "";
            DongXe = "";
            MauNoiThat = "";
            MauNgoaiThat = "";
            SoCuaSo = 0;
            SoChoNgoi = 0;
            NhienLieu = "";
            HeThongNapNhienLieu = "";
            HopSo = "";
            DanDong = "";
            TieuDe = "";
            Url = "";
            TieuThuNhienLieu = "";
            Category = "";
            ID = 0;
        }


        public string XuatXu { get; set; }

        public string DongXe { get; set; }
        public string MauNgoaiThat { get; set; }
        public string MauNoiThat { get; set; }
        public int SoCuaSo { get; set; }
        public int SoChoNgoi { get; set; }
        public string NhienLieu { get; set; }
        public string HeThongNapNhienLieu { get; set; }
        public string HopSo { get; set; }
        public string DanDong { get; set; }

        public string TieuDe { get; set; }

        public string Url { get; set; }

        public long ID { get; set; }

        public string TieuThuNhienLieu { get; set; }

        public object Category { get; set; }
    }
}
