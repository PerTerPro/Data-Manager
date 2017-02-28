using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using WSS.ImageImbo.Lib;

namespace WSS.ImageImbo.DownloadImageService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //string url = @"https://cdn02.static-adayroi.com/0/2016/08/16/1471336164901_4874299.jpg";
            //string x = ImboService.PostImgToImboChangeBackgroundTransference(url, "wss_write", "123websosanh@195", "wss", @"http://192.168.100.34", 40000);

            //string url1 = @"http://192.168.100.34:40000/users/wss/images/4tzvqVzK2axk.png";
            //string x1 = ImboService.PostImgToImboChangeBackgroundTransference(url, "wss_write", "123websosanh@195", "wss", @"https://172.22.1.226", 443);


         


            //Console.Write(x + " : " + x1  );
            //Console.ReadLine();

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new DownloadImageService() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
