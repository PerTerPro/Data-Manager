using log4net;
using QT.Entities;
using QT.Entities.Images;
using QT.Moduls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using WSS.ImageServer;

namespace WSS.Image.Download.All
{
    class Program
    {
        private Worker[] _workers;
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        private string _connectionString =
            "Data Source = 172.22.1.82; Initial Catalog = QT_2; Persist Security Info=True;User ID = wss_price; Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout = 200";
        private bool _isRunning = true;
        RabbitMQServer _rabbitMqServer;
        RabbitMQServer _rabbitMqServerDownload;
        private int _workerProduct;
        private int _workerCompany;
        private JobClient _checkErrorJobClient;
        //private List<Tuple<int, int>> _widthHeightImages;
        //Imbo
        private string _publicKeyImbo = "wss";
        private string _privateKeyImbo = "123websosanh@195";
        private string _userNameImbo = "wss";
        private string _hostImbo = "https://172.22.1.226";
        private int _portImbo = 443;
        public Program()
        {
            _workerProduct = Common.Obj2Int(ConfigurationManager.AppSettings["workerProduct"]);
            _workerCompany = Common.Obj2Int(ConfigurationManager.AppSettings["workerCompany"]);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Download();
            Console.ReadLine();
            Console.WriteLine("Done");
        }
        //public void Analysic()
        //{
        //    _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
        //    var producerUpdateImageIdSql = new ProducerBasic(_rabbitMqServer, ConfigImages.ImboExchangeImages, ConfigImages.ImboRoutingKeyUploadImageIdSql);
        //    //var producerDelByImageId = new ProducerBasic(_rabbitMqServer, ConfigImages.ImboExchangeImages, ConfigImages.ImboRoutingKeyUploadImageIdSql);


        //    _checkErrorJobClient = new JobClient(ConfigImages.ImboExchangeImages, GroupType.Topic, ConfigImages.ImboRoutingKeyCheckErrorDownload, true, _rabbitMqServer);
        //    Producer productcer = new Producer();
        //    CompanyProcess companyProcess = new CompanyProcess();
        //    var lstCompany = companyProcess.GetListCompany();

        //    foreach (var item in lstCompany)
        //    {
        //        List<ImageProductInfo> lstProduct = new List<ImageProductInfo>();
        //        int PageIndex = 1;
        //        if (companyProcess.CheckCount(item.ID) < 10000)
        //        {
        //            lstProduct = productcer.GetListProductDownloadImg(item.ID);
        //            foreach (var product in lstProduct)
        //            {
        //                DownloadImageProduct(product, producerUpdateImageIdSql);
        //            }
        //        }
        //        else
        //        {
        //            do
        //            {
        //                lstProduct = productcer.GetListProductDownloadImgPagging(item.ID, PageIndex);
        //                foreach (var product in lstProduct)
        //                {
        //                    DownloadImageProduct(product, producerUpdateImageIdSql);
        //                }
        //                PageIndex++;
        //            } while (lstProduct != null && lstProduct.Count > 0);
        //        }
        //    }
        //    Log.Info("Done!");
        //}
        public void Download()
        {
            
            for (var i = 0; i < _workerProduct; i++)
            {
                var worker = new WorkerDownload();
                var workerTask = new Task(() =>
                {
                    WorkerDownload wk = new WorkerDownload();
                    wk.StartConsume();
                });
                workerTask.Start();
                Log.InfoFormat("Worker {0} started", i);
            }
        }
        
    }
}
