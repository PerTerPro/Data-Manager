using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using WSS.Image.GetSize.Object;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Net;
using System.Drawing;
using log4net;
using System.Threading;

namespace WSS.Image.GetSize
{
    public class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Analysic();
            Console.Read();
            Console.WriteLine("Done!");
        }
        public void Analysic()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                var lstCompany = db.Query<Company>("Select a.ID,b.TimeDelay from Company a inner join Configuration b on a.ID = b.CompanyID where TotalValid > 0 and (status = 1 or status = 18 or status = 19) order by a.TotalValid desc").ToList();
                foreach (var item in lstCompany)
                {
                    //item.ID = 3502170206813664485;
                    List<Product> lstProduct = new List<Product>();
                    int PageIndex = 1;
                    string Query1 = @"SELECT * FROM (
                                                            SELECT ROW_NUMBER() OVER(ORDER BY ID) AS NUMBER,
                                                                ID, ImageUrls FROM Product 
					                                            where Company = @Company and Valid = 1
                                                                     ) AS TBL
                                                            WHERE NUMBER BETWEEN ((@PageIndex - 1) * @PageSize + 1) AND (@PageIndex * @PageSize)
                                                            ORDER BY ID";

                    string Query2 = @"SELECT ID, ImageUrls
                                        FROM Product where Company = @Company and Valid = 1 and (ImageWidth = 0 or ImageWidth is null)
                                        ORDER BY ID 
                                        OFFSET ((@PageIndex - 1) * @PageSize) ROWS
                                        FETCH NEXT @PageSize ROWS ONLY;";
                    string Query3 = @"Select ID, ImageUrls from Product where Company = @Company and Valid = 1 and (ImageWidth = 0 or ImageWidth is null)";
                    if (CheckCount(item.ID))
                    {
                        do
                        {
                            lstProduct = db.Query<Product>(Query2, new { Company = item.ID, PageIndex = PageIndex, PageSize = 10000 }).ToList();
                            foreach (var product in lstProduct)
                            {
                                if (!string.IsNullOrEmpty(product.ImageUrls))
                                {
                                    UdpateSize(product);
                                    Thread.Sleep(item.TimeDelay);
                                }
                            }
                            PageIndex++;
                        } while (lstProduct != null && lstProduct.Count > 0);
                    }
                    else
                    {
                        lstProduct = db.Query<Product>(Query3, new { Company = item.ID }).ToList();
                        foreach (var product in lstProduct)
                        {
                            if (!string.IsNullOrEmpty(product.ImageUrls))
                            {
                                UdpateSize(product);
                                Thread.Sleep(item.TimeDelay);
                            }
                        }
                    }
                    Log.InfoFormat("Update Complete Image Size Company: {0}", item.ID);
                }
            }
            Log.Info("Done!");
        }
        public bool CheckCount(long company)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                if (db.Query<Product>("Select Count(*) as Count from Product where Company = @Company", new { Company = company }).FirstOrDefault().Count > 10000)
                {
                    return true;
                }
            }
            return false;
        }
        public void UdpateSize(Product product)
        {
            string url = product.ImageUrls;
            url = url.Replace(@"///", @"//").Replace(@"////", @"//");
            var regexhttp = Regex.Match(url, "http").Captures;
            if (regexhttp.Count > 1)
                url = url.Substring(url.LastIndexOf("http", StringComparison.Ordinal));
            else if (regexhttp.Count == 0)
                url = "http://" + url;
            var requestdownload = (HttpWebRequest)WebRequest.Create(url);
            requestdownload.Credentials = CredentialCache.DefaultCredentials;
            requestdownload.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                   | SecurityProtocolType.Tls11
                                                   | SecurityProtocolType.Tls12
                                                   | SecurityProtocolType.Ssl3;
            ServicePointManager
                .ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => true;
            
            try
            {
                var responseImageDownload = (HttpWebResponse)requestdownload.GetResponse();
                var streamImageDownload = responseImageDownload.GetResponseStream();
                System.Drawing.Image img = System.Drawing.Image.FromStream(streamImageDownload);
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    db.Execute("Update Product Set ImageWidth = @Width, ImageHeight = @Height where ID = @ID",
                    new
                    {
                        ID = product.ID,
                        Width = img.Width,
                        Height = img.Height
                    });
                    Log.InfoFormat("Update Product: {0}, width: {1}, height: {2}", product.ID, img.Width, img.Height);
                }
                streamImageDownload.Close();
            }
            catch (Exception ex)
            {
                Log.ErrorFormat("Error when Update Product: {0} ({1})", product.ID, ex);
                Thread.Sleep(10000);
                
            }
        }
    }
}
