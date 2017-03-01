using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ImboForm;

namespace WSS.ImageServer.Service
{
    class Program
    {
        static void Main(string[] args){
            try
            {
                //args = new[] {"-cmd UdpImgIdToSql"};
                //args = new[] {"-cmd DelImgImbo"};\
                //args = new[] {"-cmd PushImgCompany"};
                //args = new[] {"-cmd ImgCallThumb"};
                //args = new[] { "-cmd PushRootProductWaitTrans" };
                //args = new[] { "-cmd UdpImgIdToSql" };

                //args = new[] { "-cmd PushUpImboReview" };
                //args = new[] { "-cmd DelImgImbo" };
                

                //string s = ImboImageService.PushFromFile(ConfigImbo.PublicKey, "123websosanh@195",
                //    @"C:\Image\y\yes24_vn\nuo\nuoc-hoa-nu-ines-de-la-fressange-eau-de-parfum-100ml-vang_6619017604755523100.jpg",
                //    "landingpage", ConfigImbo.Host, ConfigImbo.Port);

                string strDeirectory = "";
                Parameter pt = null;

                if (args.Length == 0)
                {
                    Console.WriteLine(@"Input location directory: ");
                    strDeirectory = Console.ReadLine();
                    pt = Parameter.FromStr(strDeirectory);
                }
                else
                {
                    pt = Parameter.FromStr(string.Join(" ", args));

                }

                if (pt.Cmd == "PushImgLocalToImbo")
                {
                    HandlerTransferFolder h = new HandlerTransferFolder();
                    h.TransferData(pt.Directory);
                }
                else if (pt.Cmd == "HanlderTransferImgNew1")
                {
                    while (true)
                    {
                        HanlderTransferImgNew1 h = new HanlderTransferImgNew1();
                        h.TransferData();
                        Thread.Sleep(6000000);
                    }
                }
                else if (pt.Cmd == "PushUpImboReview")
                {
                    HandlerNewPublisher h = new HandlerNewPublisher();
                    h.RePushJob();
                }
                else if (pt.Cmd == "PushFixRootProduct")
                {
                    HandlerTransRootProduct h = new HandlerTransRootProduct();
                    h.PushFixRootProduct();
                }
                else if (pt.Cmd == "FixRootProduct")
                {
                    Console.WriteLine("Input number thread:");
                    int iThread = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < iThread; i++)
                    {
                        Task.Factory.StartNew(() =>
                        {
                            WorkerFixDownloadRootProduct h = new WorkerFixDownloadRootProduct();
                            h.StartConsume();
                        });
                    }
                    Thread.Sleep(100000000);
                }
                else if (pt.Cmd == "PushRootProductWaitTrans")
                {
                    HandlerTransRootProduct h = new HandlerTransRootProduct();
                    h.PushRootProduct();
                }
                else if (pt.Cmd == "DownloadRootProduct")
                {
                    WorkerDownloadRootProduct w = new WorkerDownloadRootProduct();
                    w.StartConsume();
                }
                else if (pt.Cmd == "PushImgCompany")
                {
                    HandlerTransferLogoCompany f = new HandlerTransferLogoCompany();
                    f.Start();
                }
                else if (pt.Cmd == "RePushThumb")
                {
                    HandlerTransferFolder.RePushThumb();
                }
                else if (pt.Cmd == "DelImgLocalPushedImbo")
                {
                    WorkerDelFileLocal w = new WorkerDelFileLocal(pt.Directory);
                    w.StartConsume();

                }
                else if (pt.Cmd == "DelImgImbo")
                {
                    WorkerDelImgImbo w = new WorkerDelImgImbo();
                    w.StartConsume();
                }
                else if (pt.Cmd == "UdpImgIdToSql")
                {
                    WorkerImgIdToSql w = new WorkerImgIdToSql();
                    w.StartConsume();
                }
                else if (pt.Cmd == "PushProductIdCurrentToRedis")
                {
                    ImageAdapterSql img = new ImageAdapterSql();
                    img.ProcessAddProduct();
                }
                else if (pt.Cmd == "ImgCallThumb")
                {
                    WorkerThumbImg w = new WorkerThumbImg();
                    w.StartConsume();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                Console.ReadLine();
            }
            return;


            //switch (pt.Cmd)
            //{
            //    case "p_cpn_transf":
            //    {
                    
            //    } break;
            //    case "w_phc_tranf":
            //    {
                    
            //    }
            //        break;
            //    case "upbylocal":
            //    {
                    
            //    }
            //        break;
            //}

        }
    }
}
