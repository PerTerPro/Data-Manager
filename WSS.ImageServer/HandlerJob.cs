using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ImboForm
{
    public  class HandlerJob
    {
        private WebRequest request = null;
        private string PreLInk = "";

     
        public  HandlerJob()
        {
            dynamic data = JsonConvert.DeserializeObject<dynamic>((File.ReadAllText("Setting.txt")));
            PreLInk = data.Path;
           
        }

        private  ILog log = LogManager.GetLogger(typeof (HandlerJob));

        public void ProcessJob(ref MssReport ms)
        {
            try
            {
                request =
               (HttpWebRequest)WebRequest.Create("http://192.168.100.34/users/xtpu/images");
                request.Headers.Add("X-Imbo-PublicKey", "xtpu");
                request.ContentType = "application/json";
                request.Method = "POST";

                string file = PreLInk + @"/" + ms.PathImage;
                if (File.Exists(file))
                {
                    using (Stream stream = request.GetRequestStream())
                    {
                        Stream ftpStream = File.OpenRead(file);
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
                                log.Info(responseContent);
                                ms.ImageId = idImageNew;
                            }
                        }
                    }
                }
                else
                {
                    ms.Error = "NoImage";
                    ms.ImageId = "-1";
                }
            }
            catch (Exception ex1)
            {
                ms.Error = ex1.Message;
                log.Info(ex1);
            }
        }
    }
}
