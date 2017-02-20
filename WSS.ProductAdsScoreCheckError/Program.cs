using QT.Entities;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WSS.ProductAdsScoreCheckError
{
    class Program
    {
        static SqlDb sqldb = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        static string Domain = @"http://websosanh.vn/";
        static void Main(string[] args)
        {
            Program.CheckError();
        }
        public static void CheckError()
        {
            sqldb.ProcessDataTableLarge(@"select * from Product_AdsScore order by ProductId", 1000, (row, iRow) =>
            {
                long ProductID = Common.Obj2Int64(row["ProductId"]);
                long CompanyID = Common.Obj2Int64(row["CompanyId"]);
                string Keyword = row["Keyword"].ToString();
                string KeywordLink = UnsignedChar(Keyword);
                string LinkDirect = Domain + KeywordLink + "/" + ProductID.ToString() + "/" + CompanyID.ToString() + "/" + "dealdirect.htm";
                StringBuilder sb = new StringBuilder();
                string location = string.Copy(LinkDirect);
                while (!string.IsNullOrWhiteSpace(location))
                {
                    sb.AppendLine(location); // you can also use 'Append'
                    HttpWebRequest request = HttpWebRequest.CreateHttp(location);
                    request.AllowAutoRedirect = false;
                    request.Timeout = 10000;
                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    {
                        location = response.GetResponseHeader("Location");
                    }
                }
                string a = sb.ToString();
                string b = a;

                //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(LinkDirect);
                //request.Method = "HEAD";
                //request.AllowAutoRedirect = false;
                //try
                //{
                //    request.GetResponse();
                //}
                //catch (WebException ex)
                //{
                //    HttpWebResponse errorResponse = ex.Response as HttpWebResponse;
                //    if (errorResponse.StatusCode == HttpStatusCode.NotFound)
                //    {
                //        Console.WriteLine("false");
                //    }
                //}

                //request.Credentials = MyCredentialCache;
                return true;
            });
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
