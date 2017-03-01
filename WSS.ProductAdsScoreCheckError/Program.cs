using log4net;
using QT.Entities;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WSS.ProductAdsScoreCheckError
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));
        static SqlDb sqldb = new SqlDb(ConfigurationManager.AppSettings["ConnectionString"]);
        static string Domain = @"http://websosanh.vn/";
        static void Main(string[] args)
        {
            Program.CheckError();
        }
        public static void CheckError()
        {

            var tblProductAdsScore = sqldb.GetTblData(@"select * from Product_AdsScore order by ProductId");
            foreach (DataRow row in tblProductAdsScore.Rows)
            {
                long ProductID = Common.Obj2Int64(row["ProductId"]);
                long CompanyID = Common.Obj2Int64(row["CompanyId"]);
                string Keyword = row["Keyword"].ToString();
                string KeywordLink = UnsignedChar(Keyword);
                string LinkDirect = Domain + KeywordLink + "/" + ProductID.ToString() + "/" + CompanyID.ToString() + "/" + "dealdirect.htm";

                var tblProduct = sqldb.GetTblData(string.Format("Select DetailUrl from Product where ID = {0}", ProductID));
                if (tblProduct != null && tblProduct.Rows.Count > 0)
                {

                    string LinkProduct = Common.Obj2String(tblProduct.Rows[0]["DetailUrl"]);
                    if (CompanyID == 3502170206813664485)
                    {
                        string urlencode = Common.Obj2String(tblProduct.Rows[0]["DetailUrl"]);
                        string urldecode = HttpUtility.UrlDecode(urlencode);
                        char charRange = '?';
                        int startIndex = urldecode.IndexOf(charRange) + 1;
                        int endIndex = urldecode.LastIndexOf(charRange) - 1;
                        int length = endIndex - startIndex + 1;
                        LinkProduct = urldecode.Substring(startIndex, length).Replace("url=", "");
                    }

                    try
                    {
                        HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(LinkProduct);
                        webRequest.AllowAutoRedirect = false;
                        webRequest.Credentials = CredentialCache.DefaultCredentials;
                        webRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36";
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                               | SecurityProtocolType.Tls11
                                                               | SecurityProtocolType.Tls12
                                                               | SecurityProtocolType.Ssl3;
                        ServicePointManager
                            .ServerCertificateValidationCallback +=
                            (sender, cert, chain, sslPolicyErrors) => true;
                        HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                        //Returns "MovedPermanently", not 301 which is what I want.

                        if (response.StatusCode.ToString() != "OK" && response.StatusCode.ToString() != "MovedPermanently")
                        {
                            Log.InfoFormat("Product {0}: Error", ProductID);
                            sqldb.RunQuery(string.Format("Insert into Product_AdsScore_Error (ProductId,CompanyId,Keyword,LinkDirect) values ({0}, {1}, N'{2}',N'{3}')", ProductID, CompanyID, Keyword,LinkDirect), CommandType.Text, new System.Data.SqlClient.SqlParameter[] { });
                        }
                        Log.InfoFormat("Product {0}: OK", ProductID);
                        response.Close();
                        Thread.Sleep(5000);
                    }
                    catch (WebException ex)
                    {
                        Thread.Sleep(60000);
                    }

                }
                else
                {
                    sqldb.RunQuery(string.Format("Insert into Product_AdsScore_Error (ProductId,CompanyId,Keyword,LinkDirect) values ({0}, {1}, N'{2}',N'{3}')", ProductID, CompanyID, Keyword, LinkDirect), CommandType.Text, new System.Data.SqlClient.SqlParameter[] { });
                    Log.InfoFormat("Product {0}: Error", ProductID);
                }
            }

            //sqldb.ProcessDataTableLarge(@"select * from Product_AdsScore order by ProductId", 1000, (row, iRow) =>
            //{
            //    long ProductID = Common.Obj2Int64(row["ProductId"]);
            //    long CompanyID = Common.Obj2Int64(row["CompanyId"]);
            //    string Keyword = row["Keyword"].ToString();
            //    string KeywordLink = UnsignedChar(Keyword);
            //    string LinkDirect = Domain + KeywordLink + "/" + ProductID.ToString() + "/" + CompanyID.ToString() + "/" + "dealdirect.htm";

            //    var tblProduct = sqldb.GetTblData(string.Format("Select DetailUrl from Product where ID = {0}", ProductID));
            //    if (tblProduct!=null&&tblProduct.Rows.Count>0)
            //    {

            //        string LinkProduct = Common.Obj2String(tblProduct.Rows[0]["DetailUrl"]);
            //        if (CompanyID == 3502170206813664485)
            //        {
            //            string urlencode = Common.Obj2String(tblProduct.Rows[0]["DetailUrl"]);
            //            string urldecode = HttpUtility.UrlDecode(urlencode);
            //            char charRange = '?';
            //            int startIndex = urldecode.IndexOf(charRange) + 1;
            //            int endIndex = urldecode.LastIndexOf(charRange) - 1;
            //            int length = endIndex - startIndex + 1;
            //            LinkProduct = urldecode.Substring(startIndex, length).Replace("url=", "");
            //        }
            //        HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(LinkProduct);
            //        webRequest.AllowAutoRedirect = false;
            //        HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
            //        //Returns "MovedPermanently", not 301 which is what I want.
            //        if (response.StatusCode.ToString()=="NotFound")
            //        {
            //            Console.WriteLine("404");
            //        }
            //        Console.WriteLine("{0}: {1}", ProductID, response.StatusCode.ToString());
            //        response.Close();
            //    }
            //    return true;
            //});
        }
        public static string UnsignedChar(string unicodeString)
        {
            unicodeString = unicodeString.Trim().ToLower();
            unicodeString = Regex.Replace(unicodeString, "[àáảãạâầấẩẫậăằắẳẵặÀÁẢÃẠÂẦẤẨẪẬĂẰẮẲẴẶ]", "a");
            unicodeString = Regex.Replace(unicodeString, "[òóỏõọôồốổỗộơờớởỡợÒÓỎÕỌÔỒỐỔỖỘƠỜỚỞỠỢ]", "o");
            unicodeString = Regex.Replace(unicodeString, "[èéẻẽẹêềếểễệÈÉẺẼẸÊỀẾỂỄỆ]", "e");
            unicodeString = Regex.Replace(unicodeString, "[íìỉĩịÌÍỈĨỊ]", "i");
            unicodeString = Regex.Replace(unicodeString, "[úùủũụưứừửữựÙÚỦŨỤƯỪỨỬỮỰ]", "u");
            unicodeString = Regex.Replace(unicodeString, "[ýỳỷỹỵỲÝỶỸỴ]", "y");
            unicodeString = Regex.Replace(unicodeString, "[đĐ]", "d");
            unicodeString = Regex.Replace(unicodeString, "\\W+", "-");
            return unicodeString;
        }
    }
}
