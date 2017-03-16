using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.FtpClient;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using WSS.ImageImbo.Lib;

namespace WSS.ImageServer
{
    public static class ImboImageService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(ImboImageService));
        private static string CreateToken(string message, string secret)
        {
            secret = secret ?? "";
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return ImboImageService.ToHexString(hashmessage);
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


        public static string CallThumb(string imgId, List<Tuple<int, int>> sizes)
        {

            ServicePointManager
                  .ServerCertificateValidationCallback +=
                  (sender, cert, chain, sslPolicyErrors) => true;
            foreach (var variable in sizes)
            {
                try
                {
                    var str = string.Format(@"{5}:{6}/users/{0}/images/{1}.{2}?t[]=maxSize:width={3}", "wss", imgId, "jpg", variable.Item1, variable.Item2, ConfigImbo.Host,
                        ConfigImbo.Port);
                    HttpWebRequest imageRequest = (HttpWebRequest) WebRequest.Create(str);
                    imageRequest.Accept= "image/webp,image/*,*/*;q=0.8";
                    var imageResponse = (HttpWebResponse) imageRequest.GetResponse();
                    string strSize = imageResponse.Headers["Content-Length"];
                    Log.Info(string.Format("{0} {1} size: {2} {3}", imageResponse.StatusCode, imgId, strSize, (variable.Item1 + ":" + variable.Item2)));
                    imageResponse.Close();
                }
                catch (Exception ex)
                {
                    Log.Error(ex);
                }
            }
            return "";
        }

        public static string PushFromFile(string publicKey, string privateKey, string path, string userName, string host, int port)
        {
            ServicePointManager
               .ServerCertificateValidationCallback +=
               (sender, cert, chain, sslPolicyErrors) => true;
            string idImageNew = "";

            string urlQuery = host + ":" + port + @"/users/" + userName + @"/images";
            string strDate = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
            string str = "POST" + "|" + host + ":" + port + @"/users/" + userName + @"/images" + "|" + publicKey + "|" + strDate;

            var signleData = CreateToken(str, privateKey);
            try
            {
                if (File.Exists(path))
                    using (var ftpStream = File.OpenRead(path))
                    {
                        var request = (HttpWebRequest)WebRequest.Create(urlQuery);
                        request.Headers.Add("X-Imbo-PublicKey", publicKey);
                        request.Headers.Add("X-Imbo-Authenticate-Timestamp", strDate);
                        request.Headers.Add("X-Imbo-Authenticate-Signature", signleData);
                        request.ContentType = "application/json";
                        request.Method = "POST";
                        using (Stream stream = request.GetRequestStream())
                        {
                            ftpStream.CopyTo(stream);
                        }
                        using (WebResponse response = request.GetResponse())
                        {
                            using (var stream = response.GetResponseStream())
                            {
                                using (StreamReader sr99 = new StreamReader(stream))
                                {
                                    var responseContent = sr99.ReadToEnd();
                                    dynamic d = JObject.Parse(responseContent);
                                    idImageNew = d.imageIdentifier;
                                }
                            }
                        }
                    }
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
            return idImageNew;
        }

        public static bool DelteImage(string publicKey, string privateKey, string imageId, string userName, string host, int port)
        {
            try
            {
                ImboService.DeleteImg(publicKey, privateKey, imageId, userName, host, port);
            }
            catch (Exception ex)
            {
                Log.Error(imageId + ":" + ex.Message);
                return false;
            }
            return true;
        }

        public static string PushFromUrl(string publicKey, string privateKey, string path, string userName, string host, int port)
        {
            return QT.Entities.Common.DownloadImageProductWithImboServer(path, publicKey, privateKey, userName, host, port);
        }

        public static string PushFromFtpServer(string publicKey, string privateKey, string path, string userName, string host, int port)
        {
            ServicePointManager
                       .ServerCertificateValidationCallback +=
                       (sender, cert, chain, sslPolicyErrors) => true;
            string idImageNew = "";

            string urlQuery = host + ":" + port + @"/users/" + userName + @"/images";
            string strDate = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
            string str = "POST" + "|" + host + @"/users/" + userName + @"/images" + "|" + publicKey + "|" + strDate;

            var signleData = CreateToken(str, privateKey);
            try
            {
                string readyPath = path.Replace("Store/", "");
                using (var ftpClient = new FtpClient())
                {
                    ftpClient.Host = "183.91.14.84";
                    ftpClient.Credentials = new NetworkCredential("xuantrang_dev", "123456!@#$%^");
                    ftpClient.Connect();
                    if (ftpClient.FileExists(readyPath))
                        using (var ftpStream = ftpClient.OpenRead(readyPath))
                        {
                            var request = (HttpWebRequest)WebRequest.Create(urlQuery);
                            request.Headers.Add("X-Imbo-PublicKey", "wss");
                            request.Headers.Add("X-Imbo-Authenticate-Timestamp", strDate);
                            request.Headers.Add("X-Imbo-Authenticate-Signature", signleData);
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
                                        idImageNew = d.imageIdentifier;
                                        Log.Info(responseContent);
                                    }
                                }
                            }
                        }
                    ftpClient.Disconnect();
                }
            }
            catch (Exception ex)
            {
                // ignored
            }
            return idImageNew;
        }

    }
}
