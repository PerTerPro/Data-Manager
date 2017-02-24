using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.NGenerics.Enumerations;

namespace WSS.LibExtra
{
    public interface IUtilZipFile
    {
        byte[] Zip(string str);

        string UnzipOfEncode(string htmlAfterEncode);
        string ZipOfEncode(string htmlAfterEncode);



    }


    public class UtilZipFile : IUtilZipFile
    {
        private  void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

        public  byte[] Zip(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);

            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }

        public  string UnzipOfEncode(string htmlAfterEncode)
        {
            var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(htmlAfterEncode);
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }
                return Encoding.GetEncoding("iso-8859-1").GetString(mso.ToArray());
            }
        }

        public  string ZipOfEncode(string htmlAfterEncode)
        {
            var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(htmlAfterEncode);

            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    //msi.CopyTo(gs);
                    CopyTo(msi, gs);
                }

                return Encoding.GetEncoding("iso-8859-1").GetString(mso.ToArray());
            }
        }

        public  string Unzip(byte[] bytes)
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
