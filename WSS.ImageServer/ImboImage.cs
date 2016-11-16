﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.FtpClient;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;

namespace ImboForm
{
    public static class ImboImage
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (ImboImage));
        private static string CreateToken(string message, string secret)
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

    

        public static string PushFromFtpServer(string publicKey, string privateKey, string path, string userName, string host)
        {
            string idImageNew = "";
            string urlQuery = host + @"/users/" + userName + @"/images";
            string strDate = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
            string str = "POST" + "|" + urlQuery + "|" + "wss" + "|" + strDate;
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
