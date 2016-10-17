using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;

namespace ImboForm
{
    public class ImboImage
    {
        private static ImboImage _instance;

        public static ImboImage Instance()
        {
            return _instance ?? (_instance = new ImboImage());
        }

        private ILog _log = LogManager.GetLogger(typeof (ImboImage));
        private string PreLInk = "";
        private const string _salt = "P&0myWHq";


        private string CreateToken(string message, string secret)
        {
            secret = secret ?? "";
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return ImboImage.ToHexString(hashmessage);
            }
        }

        public static string ToHexString(byte[] array)
        {
            StringBuilder hex = new StringBuilder(array.Length*2);
            foreach (byte b in array)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }

        public string DownloadImage(string user, string pub, string imageId)
        {
            return "";

        }

        public string PushImage(string publicKey, string privateKey, string file, string userName)
        {
            string urlQuery = string.Format("http://192.168.100.34/users/{0}/images", userName);
            var request = (HttpWebRequest)WebRequest.Create(urlQuery);
            var accessToken = "";
            string strDate = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
            string str = "POST" + "|" + urlQuery + "|" + publicKey + "|" + strDate;
            string signleData = this.CreateToken(str, privateKey);
            request.Headers.Add("X-Imbo-PublicKey", "xtpu");
            request.Headers.Add("X-Imbo-Authenticate-Timestamp", strDate);
            request.Headers.Add("X-Imbo-Authenticate-Signature", signleData);
            request.ContentType = "application/json";
            request.Method = "POST";
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
                            _log.Info(responseContent);
                            return idImageNew;
                        }
                    }
                };
            }
            return null;
        }

    }
}
