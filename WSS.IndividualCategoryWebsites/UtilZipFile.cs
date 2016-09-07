using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.IndividualCategoryWebsites
{
    public class UtilZipFile
    {
        public static void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

        public static byte[] Zip(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);

            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    //msi.CopyTo(gs);
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }

        public static string UnzipOfEncode (string htmlAfterEncode)
        {
            var arByte = Encoding.GetEncoding("iso-8859-1").GetBytes(htmlAfterEncode); 
            var strHtml = Unzip(arByte);
            return strHtml;
        }


        public static string ByteToString (byte[] htmlAfterEncode)
        {
            return Encoding.GetEncoding("iso-8859-1").GetString(htmlAfterEncode);
        }
        public static byte[] StringToByte (string htmlAfterEncode)
        {
            return Encoding.GetEncoding("iso-8859-1").GetBytes(htmlAfterEncode);
        }


        public static string Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }

        
    }
}
