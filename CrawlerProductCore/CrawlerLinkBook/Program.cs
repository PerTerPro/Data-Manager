using QT.Moduls;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Core.Crawler;using WSS.Core.Crawler.CrawlerLinkBook;

namespace CrawlerLinkBook
{
    class Program{
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            QT.Entities.Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLinkDownload());

        }
        

        //static void Main(string[] args)
        //{
        //   // CreateDatabase();

        //    ProducerBasic producerBasic = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), "DownloadBookPdf");
        //    string rootLink = @"http://it-ebooks.info/";
        //    for (int i = 0; i < 5; i++)
        //    {
        //        producerBasic.PublishString(rootLink);
        //    }

        //    ConsumerDownloadBook consumerDownloadBook = new ConsumerDownloadBook(ConfigDownloadBook.QueueDownloadBook);
        //    consumerDownloadBook.StartConsume();

        //}



        private static void CreateDatabase()
        {
            string connStr = "Data Source = DownloadBook.sdf; Password = SomePassword";
            if (File.Exists("DownloadBook.sdf"))
                File.Delete("DownloadBook.sdf");

            SqlCeEngine engine = new SqlCeEngine(connStr);
            engine.CreateDatabase();

            SqlCeConnection conn = null;


            try
            {
                conn = new SqlCeConnection(connStr);
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "CREATE TABLE CrcVisited (col1 int, col2 ntext)";
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
