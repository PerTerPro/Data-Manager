using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.FtpClient;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GABIZ.Base.Statistics.Kernels;
using log4net;
using Newtonsoft.Json.Linq;
using QT.Moduls;
using QT.Moduls.CrawlerProduct;
using Websosanh.Core.Drivers.RabbitMQ;


namespace ImboForm
{
    internal class Program
    {
        private static ILog log = LogManager.GetLogger(typeof (Program));
        private static ManualResetEvent m_reset = new ManualResetEvent(false);
        private static int itemInPage = 10000;

        
        private static void Main(string[] args)
        {
            TestReadImbo t1 = new TestReadImbo();
            t1.TestPerformanceDownload();

            Thread.Sleep(10000000);


            //WorkerUploadImage w1 = new WorkerUploadImage();
            //w1.StartConsume();
            //while (true)
            //{
            //    try
            //    {
            //        ImboImage imboImage = ImboImage.Instance();
            //        imboImage.PushImage("xtpu", "xtpi", @"C:\Users\xuantrang\Documents\bb3249c2-fd7c-4858-a9d0-491eae5f0cd4.jpg","xtpu");
            //        return;
            //    }
            //    catch (Exception ex)
            //    {
            //        log.Error(ex);
            //        Console.ReadLine();}
            //}

            return;
            
            string help = "1. PushJob. 2. Download 3.TestHanlder";
            Console.WriteLine(help);
            string str = Console.ReadLine();
            if (str == "1"){
                    Task.Factory.StartNew(PushImageData);
            
            }
            else if (str == "2")
            {
                SettingSystem ss = SettingSystem.GetSetting();
                for (int i = 0; i < ss.Thread; i++)
                {Task.Factory.StartNew(() =>
                    {
                        WorkerUploadImage w = new WorkerUploadImage();
                        w.StartConsume();
                        return;
                    });
                }
                Thread.Sleep(10000000);
                return;
            }
            else if (str == "3")
            {
               Tester t = new Tester();
               t.Test1();
                Thread.Sleep(1000000);
            }
            return;
         


            TestData();
            Thread.Sleep(10000000);
            return;

            //for (int i = 0; i < 5; i++)
            //{
            //    Task.Factory.StartNew(() =>
            //    {
            DownloadImage();
            //    });

            //}
            //Thread.Sleep(10000000);
        }

        private static void TestData()
        {
            string url =
                @"http://192.168.100.34/users/xtpu/images/QKhF15G6q6M4?t[]=thumbnail:width=200,height=200,fit=inset";
            TestQerryPerformence t = new TestQerryPerformence();
            t.TestCode(url, 100);
        }

        private static void PushImageData()
        {
            long idStart = 0l;
            int iCount = 0;
            ProducerBasic pbc = new ProducerBasic(RabbitMQManager.GetRabbitMQServer("rabbitMQ177"),
                "TestImboServer.WaitUpToServer");
            const string connection =
                @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;";
            string query = @"
select a.ImagePath, a.id
from product  a
inner join company b on a.company = b.id 
where 
b.status = 1 
and a.Valid = 1
and a.id > @idStart
order by a.id asc 
OFFSET ((@PageNumber - 1) * @RowspPage) ROWS
FETCH NEXT @RowspPage ROWS ONLY;
";
            int page = 1;
            SqlDb sqlConnection = new SqlDb(connection);
            DataTable tblProduct = null;
            do
            {
                tblProduct = sqlConnection.GetTblData(query, CommandType.Text, new SqlParameter[]
                {
                    SqlDb.CreateParamteterSQL("PageNumber", page++, SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("RowspPage", itemInPage, SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("idStart", idStart, SqlDbType.BigInt),
                });
                if (tblProduct != null)
                {
                    foreach (DataRow variable in tblProduct.Rows)
                    {
                        try
                        {
                            long productId = Convert.ToInt64(variable["id"]);
                            var path = variable["ImagePath"].ToString();
                            string readyPath = path.Replace("Store/", "");
                            string mss = productId.ToString() + ":" + readyPath;
                            pbc.PublishString(Newtonsoft.Json.JsonConvert.SerializeObject(new MssReport()
                            {
                                Error = "",
                                ImageId = "",
                                PathImage = readyPath,
                                ProductId = productId
                            }));
                            iCount++;
                            if (iCount%100 == 0) log.Info(string.Format("pushed {0} {1} page: {2} item", iCount, productId, page-1));
                        }
                        catch (Exception ex)
                        {
                            log.Error(ex.Message);
                        }
                    }
                   
                }
            } while (tblProduct == null || tblProduct.Rows.Count > 0);
        }





        private static
            void DownloadImage()
        {
            int page = 1;


            const string connection =
                @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;";
            string query = @"
select a.ImagePath, a.id
from product  a
inner join company b on a.company = b.id 
where b.status = 1
and b.DataFeedType = 0 
and a.Valid = 1
and isnull(a.imagepath,'')!=''
and a.ImageId is  null
order by a.id asc 
OFFSET ((@PageNumber - 1) * @RowspPage) ROWS
FETCH NEXT @RowspPage ROWS ONLY;
";
            SqlDb sqlConnection = new SqlDb(connection);
            using (FtpClient ftpClient = new FtpClient())
            {
                ftpClient.Host = "183.91.14.84";
                ftpClient.Credentials = new NetworkCredential("xuantrang_dev", "123456!@#$%^");
                ftpClient.Connect();
                DataTable tbl = sqlConnection.GetTblData(query, CommandType.Text, new SqlParameter[]
                {
                    SqlDb.CreateParamteterSQL("PageNumber", page++, SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("RowspPage", itemInPage, SqlDbType.Int),
                });
                string path = "";
                while (tbl.Rows.Count > 0)
                {
                    foreach (DataRow variable in tbl.Rows)
                    {
                        try
                        {
                            long productId =Convert.ToInt64( variable["id"])
                            ;
                             path = variable["ImagePath"].ToString();
                            string readyPath = path.Replace("Store/", "");
                            if (ftpClient.FileExists(readyPath))
                                using (var ftpStream = ftpClient.OpenRead(readyPath))
                                {
                                    var request =
                                        (HttpWebRequest)WebRequest.Create("http://192.168.100.34/users/xtpu/images");
                                    request.Headers.Add("X-Imbo-PublicKey", "xtpu");
                                    // request.Headers.Add("Content-Type", "application/json");
                                    request.ContentType = "application/json";
                                    request.Method = "POST";
                                    using (Stream stream = request.GetRequestStream())
                                    {
                                        ftpStream.CopyTo(stream);
                                    }
                                    using (WebResponse response = request.GetResponse())
                                    {
                                        using (Stream stream = response.GetResponseStream())
                                        {
                                            using (StreamReader sr99 = new StreamReader(stream))
                                            {
                                                var responseContent = sr99.ReadToEnd();
                                                dynamic d = JObject.Parse(responseContent);
                                                string idImageNew = d.imageIdentifier;
                                                string query1 =
                                                    string.Format("update product set ImageId = '{0}' where Id = {1}",
                                                        idImageNew, productId
                                                        );
                                                sqlConnection.RunQuery(query1
                                                    , CommandType.Text, null);
                                                log.Info(responseContent);
                                            }
                                        }
                                    }
                                }
                        }
                        catch (Exception ex)
                        {
                            log.Error(ex);
                        }
                    }
                    ftpClient.Disconnect();
                    log.InfoFormat("SUccess page : {0}", page);
                    tbl = sqlConnection.GetTblData(query, CommandType.Text, new SqlParameter[]
                    {
                        SqlDb.CreateParamteterSQL("PageNumber", page++, SqlDbType.Int),
                        SqlDb.CreateParamteterSQL("RowspPage", itemInPage, SqlDbType.Int),
                    });

                }
            }
        }


        private static
            void BeginOpenReadCallback(IAsyncResult ar)
        {
            FtpClient conn = ar.AsyncState as FtpClient;
            try
            {
                if (conn == null)
                    throw new InvalidOperationException("The FtpControlConnection object is null!");

                using (Stream istream = conn.EndOpenRead(ar))
                {
                    byte[] buf = new byte[8192];

                    try
                    {
                        DateTime start = DateTime.Now;

                        while (istream.Read(buf, 0, buf.Length) > 0)
                        {
                            double perc = 0;

                            if (istream.Length > 0)
                                perc = (double) istream.Position/(double) istream.Length;
                        }
                    }
                    finally
                    {
                        Console.WriteLine();
                        istream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                m_reset.Set();
            }
        }


        private static void ConnectCallback(IAsyncResult ar)
        {
            FtpClient conn = ar.AsyncState as FtpClient;

            try
            {
                if (conn == null)
                    throw new InvalidOperationException("The FtpControlConnection object is null!");

                conn.EndConnect(ar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                m_reset.Set();
            }
        }
    }
}
