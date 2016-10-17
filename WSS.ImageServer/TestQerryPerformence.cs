using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace ImboForm
{
    public class TestQerryPerformence
    {
        private ILog log = log4net.LogManager.GetLogger(typeof (TestQerryPerformence));

        public void TestCode(string url, int thread)
        {
            for (int i = 0; i < thread; i++)
            {
                int jTHread = i;
                Task.Factory.StartNew(() =>
                {
                    while (true)
                    {
                        DateTime dtStart = DateTime.Now;
                        string localFilename = "ImageTest\\" + Guid.NewGuid() + ".jpg";
                        using (WebClient client = new WebClient())
                        {
                            using (var stream = client.OpenRead(new Uri(url)))
                            {
                                
                            }
                            //client.DownloadFile(url, localFilename);
                        }
                        int timeRun = Convert.ToInt32((DateTime.Now - dtStart).TotalMilliseconds);
                        log.Info(string.Format("{0} -> {1}", jTHread, timeRun));
                    }
                });
            }

        }
    }
}
