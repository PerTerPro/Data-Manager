using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WSS.Service.Report.ProductOnClick.Error.Model;

namespace WSS.Service.Report.ProductOnClick.Error.ImplementCode
{
    public  class CheckLinkValid:ICheckLinkValid
    {
        public bool CheckLink(string link)
        {
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest) WebRequest.Create(link);
                webRequest.AllowAutoRedirect = false;
                webRequest.Credentials = CredentialCache.DefaultCredentials;
                webRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                       | SecurityProtocolType.Tls11
                                                       | SecurityProtocolType.Tls12
                                                       | SecurityProtocolType.Ssl3;
                ServicePointManager
                    .ServerCertificateValidationCallback +=
                    (sender, cert, chain, sslPolicyErrors) => true;
                HttpWebResponse response = (HttpWebResponse) webRequest.GetResponse();
                int status = (int) response.StatusCode;
                string strStatus = status.ToString();
                response.Close();
                return strStatus.StartsWith("2") || strStatus.StartsWith("3");
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
