
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.Tool
{
    public partial class FrmAutoAddCampaign : Form
    {
        SqlDb sqldbProduct = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        SqlDb sqldbLandingPage = new SqlDb("Data Source=172.22.1.83;Initial Catalog=ReviewsCMS;Persist Security Info=True;User ID=wss_news;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        DataTable tblLandingPage = new DataTable();
        public FrmAutoAddCampaign()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tblLandingPage = ReadDataFromExcelFile(openFileDialog1.FileName);
                txtPathEx.Text = openFileDialog1.FileName;
                txtPathEx.Enabled = false;
                lblB.Text = tblLandingPage.Rows.Count.ToString();
            }
        }
        private void btnCreateLandingPage_Click(object sender, EventArgs e)
        {
            Thread Run = new Thread(() => AutoCreateLandingPage());
            Run.Start();
            
        }

        private void AutoCreateLandingPage()
        {
            int Count = 0;
            if (tblLandingPage != null && tblLandingPage.Rows.Count > 0)
            {
                foreach (DataRow row in tblLandingPage.Rows)
                {
                    string KeySearch = row["KeySearch"].ToString();
                    if (!string.IsNullOrEmpty(KeySearch))
                    {
                        try
                        {
                            string NameCheck = string.Format("{0} {1}", "Top", KeySearch);
                            string LinkLandingPage = row["LinkLandingpage"].ToString();
                            string UrlCampaign = LinkLandingPage.Replace(@"http://websosanh.vn/", "").Replace(".htm", "").Trim();
                            if (Check_Exist_LandingPage(UrlCampaign, NameCheck) == false)
                            {
                                Campaign objCamp = new Campaign();
                                objCamp.Name = string.Format("{0} {1}", "Top", KeySearch);
                                objCamp.UrlCampaign = UrlCampaign;
                                objCamp.IsActive = true;
                                objCamp.Order = 1;
                                objCamp.BackgroundColor = "#f0f2f9";
                                objCamp.Repeat = 1;
                                objCamp.MetaTitle = objCamp.Name;
                                objCamp.IsIndex = true;
                                objCamp.IsFollow = true;
                                objCamp.IsFlashSale = true;
                                objCamp.Type = 2;
                                objCamp.BannerImagePath = "";
                                objCamp.BannerUrl = "";
                                objCamp.BackgroundImage = "";
                                int CampaignId = Campaign_Insert(objCamp);

                                AdvCateHotdeal objCat = new AdvCateHotdeal();
                                objCat = GetCateFromAPI(KeySearch, CampaignId);

                                int AdvIdCate = AdvCateHotdeal_Insert(objCat);
                                var lstProduct = Get_List_Product_Insert(KeySearch, AdvIdCate, "[SEO]" + objCamp.Name, DateTime.Now, DateTime.Now.AddDays(30));

                                foreach (var item in lstProduct)
                                {
                                    Insert_AdvProductHotdeal(item);
                                }
                                Count++;
                                this.Invoke(new Action(() =>
                                {
                                    lblA.Text = Count.ToString();
                                    richTextBox1.AppendText(string.Format("\nĐã tạo landing page: {0}, Đường dẫn: {1}, có: {2} sản phẩm", NameCheck, LinkLandingPage, lstProduct.Count.ToString()));
                                }));
                            }
                            else
                            {
                                this.Invoke(new Action(() =>
                                {
                                    richTextBox1.AppendText(string.Format("\nLanding Page: {0} đã tồn tại hoặc có lỗi khi tạo", LinkLandingPage));
                                }));
                            }
                        }
                        catch (Exception ex)
                        {
                            
                            
                        }
                        
                    }
                }
            }
            MessageBox.Show("Done!");
        }

        private void Insert_AdvProductHotdeal(AdvProductHotdeal objProduct) 
        {
            sqldbLandingPage.RunQuery("CMS_LandingPageSeo_InsertProruct", CommandType.StoredProcedure, new System.Data.SqlClient.SqlParameter[] { 
                        SqlDb.CreateParamteterSQL("@AdvIdCate",(object)objProduct.AdvIdCate,SqlDbType.Int),
                        SqlDb.CreateParamteterSQL("@MerchantId",(object)objProduct.MerchantId,SqlDbType.BigInt),
                        SqlDb.CreateParamteterSQL("@MaHopDong",(object)objProduct.MaHopDong,SqlDbType.NVarChar),
                        SqlDb.CreateParamteterSQL("@ProductId",(object)objProduct.ProductId,SqlDbType.BigInt),
                        SqlDb.CreateParamteterSQL("@Name",(object)objProduct.Name,SqlDbType.NVarChar),
                        SqlDb.CreateParamteterSQL("@FilePath",(object)objProduct.FilePath,SqlDbType.NVarChar),
                        SqlDb.CreateParamteterSQL("@StartDate",(object)objProduct.StartDate,SqlDbType.DateTime),
                        SqlDb.CreateParamteterSQL("@EndDate",(object)objProduct.EndDate,SqlDbType.DateTime),
                        SqlDb.CreateParamteterSQL("@Description",(object)objProduct.Description,SqlDbType.NVarChar),
                        SqlDb.CreateParamteterSQL("@IsActive",(object)objProduct.IsActive,SqlDbType.Bit),
                        SqlDb.CreateParamteterSQL("@Linkwss",(object)objProduct.Linkwss,SqlDbType.NVarChar),
                        SqlDb.CreateParamteterSQL("@Link",(object)objProduct.Link,SqlDbType.NVarChar),
                        SqlDb.CreateParamteterSQL("@Price",(object)objProduct.Price,SqlDbType.Int),
                        SqlDb.CreateParamteterSQL("@PriceOld",(object)objProduct.PriceOld,SqlDbType.Int),
                        SqlDb.CreateParamteterSQL("@Order",(object)objProduct.Order,SqlDbType.Int),
                        SqlDb.CreateParamteterSQL("@IsHot",(object)objProduct.IsHot,SqlDbType.Int)
            });
        }

        private List<AdvProductHotdeal> Get_List_Product_Insert(string KeySearch, int AdvIdCate, string MaHopDong, DateTime startDate, DateTime endDate)
        {
            DataTable tblProduct = new DataTable();
            tblProduct = sqldbProduct.GetTblData(string.Format("select top 50 * from Product where Contains(Name,'{0}') and Company <> 6619858476258121218 and Valid = 1", KeySearch.Replace(" ", "*").Trim()));
            List<AdvProductHotdeal> lstProduct = new List<AdvProductHotdeal>();
           
            foreach (DataRow row in tblProduct.Rows)
            {
                AdvProductHotdeal objProduct = new AdvProductHotdeal();

                objProduct.AdvIdCate = AdvIdCate;
                objProduct.MerchantId = Common.Obj2Int64(row["Company"]);
                objProduct.MaHopDong = MaHopDong;
                objProduct.ProductId = Common.Obj2Int64(row["ID"]);
                objProduct.Name = Common.Obj2String(row["Name"]);
                objProduct.FilePath = string.Format("{0}{1}", "http://img.websosanh.vn/", Common.Obj2String(row["ImagePath"]));
                objProduct.StartDate = startDate;
                objProduct.EndDate = endDate;
                objProduct.Description = "";
                objProduct.IsActive = true;
                objProduct.Linkwss = "";
                objProduct.Link = Common.Obj2String(row["DetailUrl"]);
                objProduct.Price = Common.Obj2Int(row["Price"]);
                objProduct.PriceOld = Common.Obj2Int(row["Price"]);
                objProduct.Order = 100;
                objProduct.IsHot = false;

                lstProduct.Add(objProduct);
            }
            return lstProduct;
        }

        private int AdvCateHotdeal_Insert(AdvCateHotdeal objCat)
        {
            DataTable tbl = new DataTable();
            tbl = sqldbLandingPage.RunQueryAndReturn("CMS_LandingPageSeo_Insert_AdvCateHotdeal", CommandType.StoredProcedure, new System.Data.SqlClient.SqlParameter[] { 
                SqlDb.CreateParamteterSQL("@Name",(object)objCat.Name,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@Order",(object)objCat.Order,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@DetailUrl",(object)objCat.DetailUrl,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@IdType",(object)objCat.IdType,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@CategoryId",(object)objCat.CategoryId,SqlDbType.NVarChar),
            }, true);
            if (tbl != null && tbl.Rows.Count > 0)
            {
                return Common.Obj2Int(tbl.Rows[0]["Id"]);
            }
            return 0;
        }

        private AdvCateHotdeal GetCateFromAPI(string KeySearch, int CampaignId)
        {
            AdvCateHotdeal objAdvCate = new AdvCateHotdeal();
            string strAPI = "http://172.22.1.108/api/MLAPI/suggest.htm?restoreResults=2&original=true&keyword=" + System.Uri.EscapeDataString(KeySearch);
            WebClient client = new WebClient();
            string value = string.Empty;
            client.Headers.Add("Accept-Language", " en-US");
            client.Headers.Add("Accept-Encoding", "gzip, deflate");
            client.Headers.Add("Accept", " text/html, application/xhtml+xml, */*");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)");
            client.Encoding = Encoding.UTF8;
            value = client.DownloadString(strAPI);
            var result = JsonConvert.DeserializeObject<GetCategoryResult>(value);

            objAdvCate.Name = result.results[0].categoryName;
            objAdvCate.Order = 1;
            objAdvCate.DetailUrl = "";
            objAdvCate.IdType = CampaignId;
            objAdvCate.CategoryId = result.results[0].categoryId;

            return objAdvCate;
        }

        private int Campaign_Insert(Campaign objCamp)
        {
            DataTable tbl = new DataTable();
            tbl = sqldbLandingPage.RunQueryAndReturn("CMS_LandingPageSeo_InsertCampaign", CommandType.StoredProcedure, new System.Data.SqlClient.SqlParameter[] { 
                SqlDb.CreateParamteterSQL("@Name",(object)objCamp.Name,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@UrlCampaign",(object)objCamp.UrlCampaign,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@IsActive",(object)objCamp.IsActive,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@Order",(object)objCamp.Order,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@BackgroundColor",(object)objCamp.BackgroundColor,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@Repeat",(object)objCamp.Repeat,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@MetaTitle",(object)objCamp.MetaTitle,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@IsIndex",(object)objCamp.IsIndex,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@IsFollow",(object)objCamp.IsFollow,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@IsFlashSale",(object)objCamp.IsFlashSale,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@Type",(object)objCamp.Type,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@BannerImagePath",objCamp.BannerImagePath,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@BannerUrl",objCamp.BannerUrl,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@BackgroundImage",objCamp.BackgroundImage,SqlDbType.NVarChar)
            }, true);
            if (tbl != null && tbl.Rows.Count > 0)
            {
                return Common.Obj2Int(tbl.Rows[0]["Id"]);
            }
            return 0;
        }

        public bool Check_Exist_LandingPage(string urlCampaign, string nameCampaign)
        {
            DataTable tblChect = new DataTable();
            tblChect = sqldbLandingPage.GetTblData(string.Format("select * from AdvCampaign where UrlCampaign = '{0}' or Name = '{1}'", urlCampaign, nameCampaign));
            if (tblChect != null && tblChect.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private DataTable ReadDataFromExcelFile(string path)
        {
            //string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path.Trim() + ";Extended Properties=Excel 8.0";
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path.Trim() + ";Extended Properties=Excel 12.0;";
            // Tạo đối tượng kết nối
            OleDbConnection oledbConn = new OleDbConnection(connectionString);
            DataTable data = null;
            try
            {
                // Mở kết nối
                oledbConn.Open();

                // Tạo đối tượng OleDBCommand và query data từ sheet có tên "Keywords"
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", oledbConn);

                // Tạo đối tượng OleDbDataAdapter để thực thi việc query lấy dữ liệu từ tập tin excel
                OleDbDataAdapter oleda = new OleDbDataAdapter();

                oleda.SelectCommand = cmd;

                // Tạo đối tượng DataSet để hứng dữ liệu từ tập tin excel
                DataSet ds = new DataSet();

                // Đổ đữ liệu từ tập excel vào DataSet
                oleda.Fill(ds);

                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Đóng chuỗi kết nối
                oledbConn.Close();
            }
            return data;
        }
        #region Models
        public class Campaign
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string UrlCampaign { get; set; }
            public bool IsActive { get; set; }
            public int Order { get; set; }
            public string BackgroundColor { get; set; }
            public int Repeat { get; set; }
            public string MetaTitle { get; set; }
            public bool IsIndex { get; set; }
            public bool IsFollow { get; set; }
            public bool IsFlashSale { get; set; }
            public int Type { get; set; }
            public string BannerImagePath { get; set; }
            public string BannerUrl { get; set; }
            public string BackgroundImage { get; set; }
        }

        public class AdvCateHotdeal
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Order { get; set; }
            public string DetailUrl { get; set; }
            public int IdType { get; set; }
            public int CategoryId { get; set; }
        }

        public class GetCategoryResult
        {
            public string keyword { get; set; }
            public Category[] results { get; set; }
        }

        public class Category
        {
            public double prob { get; set; }
            public string categoryName { get; set; }
            public int categoryId { get; set; }
        }
        public class AdvProductHotdeal
        {
            public int AdvIdCate { get; set; }
            public long MerchantId { get; set; }
            public string MaHopDong { get; set; }
            public long ProductId { get; set; }
            public string Name { get; set; }
            public string FilePath { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Description { get; set; }
            public bool IsActive { get; set; }
            public string Linkwss { get; set; }
            public string Link { get; set; }
            public int Price { get; set; }
            public int PriceOld { get; set; }
            public int Order { get; set; }
            public bool IsHot { get; set; }
        }
        #endregion

    }
}
