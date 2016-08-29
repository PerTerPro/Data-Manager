using log4net;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities
{
    public struct JobName 
    {
        public const int Data = 1;
        public const int Config = 2;
        
        
        public const int XMain = 9;
        public const int XMain_CrawlerReloadManual = 10;
        public const int XMain_CrawlerFindNewManual = 11;
        public const int San_pham = 13;

        public const int Thiet_lap_san_pham = 31;
        public const int Dinh_nghia_Thong_so_ki_thuat = 32;
        public const int Ghep_chuyen_muc_voi_dinh_nghia = 33;
        public const int Chuan_hoa_Gia_tri_thuoc_tinh = 34;
        public const int Chon_chuyen_muc_voi_thuoc_tinh = 35;
        public const int Nhom_thuoc_tinh = 36;
        public const int Thuoc_tinh_san_pham = 37;
        public const int Map_Category_Classification = 38;
        public const int Nhap_Tag_san_pham_goc = 39;
        public const int Nhap_Tag_theo_Cong_ty = 40;
        public const int Login = 41;
        
        public const int TatCa = 51;

        public const int FrmCompany = 3;
        #region Form FrmCongTy
        //public const int FrmCompany_ChangeCompany = 4;
        //public const int FrmCompany_ChangeConfig = 5;
        public const int FrmCompany_XoaDiaChi = 6;
        public const int FrmCompany_UpdateAlexa = 7;
        public const int FrmCompany_UpdateAnhMerchant = 8;
        public const int FrmCompany_TestLink = 43;
        public const int FrmCompany_ClearQueue = 45;
        public const int FrmCompany_ClearVisited = 44;
        public const int FrmCompany_ReloadIsDealState = 46;
        public const int FrmCompany_ThayNhomQuanLy = 47;
        public const int FrmCompany_Redownload = 48;
        public const int FrmCompany_TestDatafeed = 58;
        public const int FrmCompany_UpdateDatafeed = 59;
        public const int FrmCompany_PushMessageDownloadImage = 60;
        public const int frmAddweb = 65;
        public const int FrmCompany_AddNew	=67;
        public const int FrmCompany_Delete = 68;                                                                                                
        //Update config của datafeed
        public const int FrmDatafeedConfig_SaveData = 57;

        public const int FrmCompany_ChangeConfig_New = 63;
        public const int FrmCompany_ChangeConfig_Fix = 64;

        public const int FrmCompanyRatting_ChangeData = 62;
        #endregion
        
        public const int Nhap_san_pham_goc = 14;
        #region Form FrmEditeProductByCat
        public const int FrmEditeProductByCat_Them_moi_san_pham_goc	= 22;
        public const int FrmEditeProductByCat_Chuyen_trang_thai_san_pham = 49;
        //Lưu thay đổi ở danh sách sản phẩm gốc trên form Nhập sản phẩm gốc
        public const int FrmEditeProductByCat_Luu_danh_sach = 50;
        public const int FrmEditeProductByCat_AutoSave = 52;
        //Lưu giá trị thuộc tính của sản phẩm gốc
        public const int FrmEditeProductByCat_Save_gia_tri_thuoc_tinh = 53;
        public const int FrmEditeProductByCat_Xoa_San_pham_goc = 54;
        public const int FrmEditeProductByCat_Xoa_het_gia_tri_thuoc_tinh = 55;
        public const int FrmEditeProductByCat_Xoa_gia_tri_thuoc_tinh = 56;
        #endregion

        public const int Doi_ten_san_pham = 15;
        #region FrmEditeTenSanPham
        public const int FrmEditeTenSanPham_Doi_Category =	23;
        public const int FrmEditeTenSanPham_Noi_dung_thay_the	=24;
        public const int FrmEditeTenSanPham_Load_Cat =	25;
        public const int FrmEditeTenSanPham_Load_All	=26;
        public const int FrmEditeTenSanPham_Luu_du_lieu = 27;
        #endregion

        public const int Phan_tich_san_pham = 16;
        #region FrmManagerProduct
        public const int FrmManagerProduct_Nhan_dien_san_pham =	17;
        public const int FrmManagerProduct_Upload_Image=18;
        public const int FrmManagerProduct_Luu=	19;
        public const int FrmManagerProduct_LuuTam =20;
        public const int FrmManagerProduct_UploadAllImageSPGoc=	21;
        public const int FrmManagerProduct_Load_Cat=28;
        public const int FrmManagerProduct_Load_All	=29;
        public const int FrmManagerProduct_Xoa_trung_ten = 30;
        public static int FrmRankingCompany_SaveRanking = 66;
        //lưu thông tin sản phẩm ở form nhận diện
        public static int FrmManagerProduct_Luu_Product = 69;
        #endregion


    }

    public enum JobTypeData
    {
        Company = 1,
        Product = 2,
        KhongXacDinh = 0
    }

    public enum UserDepartment
    {
        Code = 0,
        Data = 1,
        Config = 2,
        Marketing = 3,
        Content = 4
    }

    public  class LogJobAdapter
    {
        public static readonly ILog Log = LogManager.GetLogger(typeof(LogJobAdapter));
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUser">ID của user</param>
        /// <param name="idJob">ID công việc -> Bảng Job SQL</param>
        /// <param name="contentJob">Mô tả hoặc ghi chú job</param>
        /// <param name="idData">hành động tương tác tới ID</param>
        /// <param name="typeData">(enum JobTypeData) Loại ID : Company = 1. Product = 2. Không xác định = 0</param>
        public static void SaveLog(int idJob, string contentJob, long idData, int typeData)
        {
            DBJobTableAdapters.LogJobTableAdapter logjobAdapter = new DBJobTableAdapters.LogJobTableAdapter();
            logjobAdapter.Connection.ConnectionString = Server.ConnectionString;
            try
            {
                logjobAdapter.Insert(QT.Entities.Server.UserID, idJob, contentJob, DateTime.Now, idData, typeData);
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("ERROR Log Job with IDJob = {0}. IDData ={1}", idJob, idData), ex);
            }
        }

        //public static void SaveLogUser(int idUser, int idJob, string contentJob, long idData, int typeData)
        //{
        //    DBJobTableAdapters.LogJobTableAdapter logjobAdapter = new DBJobTableAdapters.LogJobTableAdapter();
        //    logjobAdapter.Connection.ConnectionString = Server.ConnectionString;
        //    try
        //    {
        //        logjobAdapter.Insert(idUser, idJob, contentJob, DateTime.Now, idData, typeData);
        //    }
        //    catch (Exception ex)
        //    {
        //        Log.Error(string.Format("ERROR Log Job with IDJob = {0}. IDData ={1}", idJob, idData), ex);
        //    }
        //}
    }
}
