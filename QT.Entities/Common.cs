using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using TidyNet;
using System.IO;
using System.Globalization;
using GABIZ.Base.HtmlAgilityPack;
using GABIZ.Base;
using GABIZ.Base.HtmlUrl;
using System.Web;
using System.Drawing;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.IO.Compression;
using System.Configuration;
using QT.Entities.Data;
using QT.Entities.Model.SaleNews;
using QT.Entities.RaoVat;
using System.Data.SqlClient;
using System.Data.OleDb;
using log4net;
using System.Threading;
using System.Data.Odbc;
using OpenQA.Selenium.Firefox;
namespace QT.Entities
{
    public delegate string EventProcessString<T>(T itemInput);

    public class Crypto
    {
        /// <summary>
        /// Encrypts a string
        /// </summary>
        /// <param name="PlainTextBytes">Bytes to be encrypted</param>
        /// <param name="Password">Password to encrypt with</param>
        /// <param name="Salt">Salt to encrypt with</param>
        /// <param name="HashAlgorithm">Can be either SHA1 or MD5</param>
        /// <param name="PasswordIterations">Number of iterations to do</param>
        /// <param name="InitialVector">Needs to be 16 ASCII characters long</param>
        /// <param name="KeySize">Can be 128, 192, or 256</param>
        /// <returns>An encrypted bytes</returns>
        public static byte[] Encrypt(
            byte[] PlainTextBytes,
            string Password,
            string Salt,
            string HashAlgorithm,
            int PasswordIterations,
            string InitialVector,
            int KeySize)
        {
            if ((Salt == null) || (Salt == "")) Salt = "thoweb";
            if ((HashAlgorithm == null) || (HashAlgorithm == "")) HashAlgorithm = "SHA1";
            if (PasswordIterations == 0) PasswordIterations = 2;
            if ((InitialVector == null) || (InitialVector == "") || (InitialVector.Length != 16)) InitialVector = "ANGh9M&op-*UL$W%";
            if ((KeySize != 128) && (KeySize != 192) && (KeySize != 256)) PasswordIterations = 256;

            if (PlainTextBytes == null)
                return null;

            byte[] InitialVectorBytes = Encoding.ASCII.GetBytes(InitialVector);
            byte[] SaltValueBytes = Encoding.ASCII.GetBytes(Salt);

            PasswordDeriveBytes DerivedPassword = new PasswordDeriveBytes(Password, SaltValueBytes, HashAlgorithm, PasswordIterations);

            byte[] KeyBytes = DerivedPassword.GetBytes(KeySize / 8);

            RijndaelManaged SymmetricKey = new RijndaelManaged();
            SymmetricKey.Mode = CipherMode.CBC;

            byte[] CipherTextBytes = null;

            using (ICryptoTransform Encryptor = SymmetricKey.CreateEncryptor(KeyBytes, InitialVectorBytes))
            {
                using (MemoryStream MemStream = new MemoryStream())
                {
                    using (CryptoStream CryptoStream = new CryptoStream(MemStream, Encryptor, CryptoStreamMode.Write))
                    {
                        CryptoStream.Write(PlainTextBytes, 0, PlainTextBytes.Length);
                        CryptoStream.FlushFinalBlock();
                        CipherTextBytes = MemStream.ToArray();
                        MemStream.Close();
                        CryptoStream.Close();
                    }
                }
            }

            SymmetricKey.Clear();

            return CipherTextBytes;

        }

        /// <summary>
        /// Decrypts a string
        /// </summary>
        /// <param name="CipherTextBytes">Bytes to be decrypted</param>
        /// <param name="Password">Password to decrypt with</param>
        /// <param name="Salt">Salt to decrypt with</param>
        /// <param name="HashAlgorithm">Can be either SHA1 or MD5</param>
        /// <param name="PasswordIterations">Number of iterations to do</param>
        /// <param name="InitialVector">Needs to be 16 ASCII characters long</param>
        /// <param name="KeySize">Can be 128, 192, or 256</param>
        /// <returns>A decrypted bytes</returns>
        public static byte[] Decrypt(
            byte[] CipherTextBytes,
            string Password,
            string Salt,
            string HashAlgorithm,
            int PasswordIterations,
            string InitialVector,
            int KeySize)
        {
            if ((Salt == null) || (Salt == "")) Salt = "thoweb";
            if ((HashAlgorithm == null) || (HashAlgorithm == "")) HashAlgorithm = "SHA1";
            if (PasswordIterations == 0) PasswordIterations = 2;
            if ((InitialVector == null) || (InitialVector == "") || (InitialVector.Length != 16)) InitialVector = "ANGh9M&op-*UL$W%";
            if ((KeySize != 128) && (KeySize != 192) && (KeySize != 256)) PasswordIterations = 256;

            if (CipherTextBytes == null)
                return null;

            byte[] InitialVectorBytes = Encoding.ASCII.GetBytes(InitialVector);

            byte[] SaltValueBytes = Encoding.ASCII.GetBytes(Salt);

            PasswordDeriveBytes DerivedPassword = new PasswordDeriveBytes(Password, SaltValueBytes, HashAlgorithm, PasswordIterations);
            byte[] KeyBytes = DerivedPassword.GetBytes(KeySize / 8);
            RijndaelManaged SymmetricKey = new RijndaelManaged();
            SymmetricKey.Mode = CipherMode.CBC;

            byte[] PlainTextBytes = new byte[CipherTextBytes.Length];
            int ByteCount = 0;

            using (ICryptoTransform Decryptor = SymmetricKey.CreateDecryptor(KeyBytes, InitialVectorBytes))
            {
                using (MemoryStream MemStream = new MemoryStream(CipherTextBytes))
                {
                    using (CryptoStream CryptoStream = new CryptoStream(MemStream, Decryptor, CryptoStreamMode.Read))
                    {
                        ByteCount = CryptoStream.Read(PlainTextBytes, 0, PlainTextBytes.Length);
                        MemStream.Close();
                        CryptoStream.Close();
                    }
                }
            }
            SymmetricKey.Clear();
            return PlainTextBytes;
        }

        /// <summary>
        /// Compresses the string using G-Zip algorithm.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>Compressed bytes array</returns>
        public static byte[] GZip_CompressString(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            var memoryStream = new MemoryStream();
            using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
            {
                gZipStream.Write(buffer, 0, buffer.Length);
            }

            memoryStream.Position = 0;

            var compressedData = new byte[memoryStream.Length];
            memoryStream.Read(compressedData, 0, compressedData.Length);

            var gZipBuffer = new byte[compressedData.Length + 4];
            Buffer.BlockCopy(compressedData, 0, gZipBuffer, 4, compressedData.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gZipBuffer, 0, 4);
            return gZipBuffer;
        }

        /// <summary>
        /// Decompresses the string using Gzip algorithm..
        /// </summary>
        /// <param name="gZipBuffer">The compressed bytes.</param>
        /// <returns></returns>
        public static string GZip_DeCompressString(byte[] gZipBuffer)
        {
            using (var memoryStream = new MemoryStream())
            {
                int dataLength = BitConverter.ToInt32(gZipBuffer, 0);
                memoryStream.Write(gZipBuffer, 4, gZipBuffer.Length - 4);

                var buffer = new byte[dataLength];

                memoryStream.Position = 0;
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    gZipStream.Read(buffer, 0, buffer.Length);
                }

                return Encoding.UTF8.GetString(buffer);
            }
        }

        /// <summary>
        /// Compresses the string using Deflate algorithm.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>Compressed bytes array</returns>
        public static byte[] Deflate_CompressString(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            var memoryStream = new MemoryStream();
            using (var deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress, true))
            {
                deflateStream.Write(buffer, 0, buffer.Length);
            }

            memoryStream.Position = 0;

            var compressedData = new byte[memoryStream.Length];
            memoryStream.Read(compressedData, 0, compressedData.Length);

            var defalteBuffer = new byte[compressedData.Length + 4];
            Buffer.BlockCopy(compressedData, 0, defalteBuffer, 4, compressedData.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, defalteBuffer, 0, 4);
            return defalteBuffer;
        }

        /// <summary>
        /// Decompresses the string using Deflate algorithm.
        /// </summary>
        /// <param name="gZipBuffer">The compressed bytes.</param>
        /// <returns></returns>
        public static string Deflate_DeCompressString(byte[] deflateBuffer)
        {
            using (var memoryStream = new MemoryStream())
            {
                int dataLength = BitConverter.ToInt32(deflateBuffer, 0);
                memoryStream.Write(deflateBuffer, 4, deflateBuffer.Length - 4);

                var buffer = new byte[dataLength];

                memoryStream.Position = 0;
                using (var deflateStream = new DeflateStream(memoryStream, CompressionMode.Decompress))
                {
                    deflateStream.Read(buffer, 0, buffer.Length);
                }

                return Encoding.UTF8.GetString(buffer);
            }
        }

        /// <summary>
        /// Formal string encryption for Gabiz Project
        /// </summary>
        /// <param name="plainText">Plain text</param>
        /// <returns>Cipher text in bytes array</returns>
        public static byte[] Encrypt(string plainText)
        {
            UnicodeEncoding unicode = new UnicodeEncoding();
            return Crypto.Encrypt(unicode.GetBytes(plainText), "c#a1o*nt%d>-@d]v4&9d", "thoweb", "SHA1", 2, "ANGh9M&op-*UL$W%", 256);
        }
        /// <summary>
        /// Formal string decryption for Gabiz Project
        /// </summary>
        /// <param name="cipherText">Cipher text in bytes array</param>
        /// <returns>Plain text</returns>
        public static string Decrypt(byte[] cipherText)
        {
            UnicodeEncoding unicode = new UnicodeEncoding();
            return unicode.GetString(Crypto.Decrypt(cipherText, "c#a1o*nt%d>-@d]v4&9d", "thoweb", "SHA1", 2, "ANGh9M&op-*UL$W%", 256)).TrimEnd('\0');
        }
    }

    //public sealed class Cryption
    //{
    //    private RijndaelManaged Algorithm;
    //    private MemoryStream memStream;
    //    private ICryptoTransform EncryptorDecryptor;
    //    private CryptoStream crStream;
    //    private StreamWriter strWriter;
    //    private StreamReader strReader;

    //    private string m_key;
    //    private string m_iv;

    //    private byte[] key;
    //    private byte[] iv;

    //    private string pwd_str;
    //    private byte[] pwd_byte;

    //    public Cryption(string key_val, string iv_val)
    //    {
    //        key = new byte[32];
    //        iv = new byte[32];

    //        int i;
    //        m_key = key_val;
    //        m_iv = iv_val;

    //        for (i = 0; i < m_key.Length; i++)
    //        {
    //            key[i] = Convert.ToByte(m_key[i]);
    //        }
    //        for (i = 0; i < m_iv.Length; i++)
    //        {
    //            iv[i] = Convert.ToByte(m_iv[i]);
    //        }

    //    }

    //    public string Encrypt(string s)
    //    {
    //        Algorithm = new RijndaelManaged();

    //        Algorithm.BlockSize = 256;
    //        Algorithm.KeySize = 256;

    //        memStream = new MemoryStream();

    //        EncryptorDecryptor = Algorithm.CreateEncryptor(key, iv);

    //        crStream = new CryptoStream(memStream, EncryptorDecryptor, CryptoStreamMode.Write);

    //        strWriter = new StreamWriter(crStream);

    //        strWriter.Write(s);

    //        strWriter.Flush();
    //        crStream.FlushFinalBlock();

    //        pwd_byte = new byte[memStream.Length];
    //        memStream.Position = 0;
    //        memStream.Read(pwd_byte, 0, (int)pwd_byte.Length);

    //        pwd_str = new UnicodeEncoding().GetString(pwd_byte);

    //        return pwd_str;
    //    }

    //    public string Decrypt(string s)
    //    {
    //        Algorithm = new RijndaelManaged();

    //        Algorithm.BlockSize = 256;
    //        Algorithm.KeySize = 256;

    //        MemoryStream memStream = new MemoryStream(new UnicodeEncoding().GetBytes(s));

    //        ICryptoTransform EncryptorDecryptor = Algorithm.CreateDecryptor(key, iv);
    //        memStream.Position = 0;
    //        CryptoStream crStream = new CryptoStream(memStream, EncryptorDecryptor, CryptoStreamMode.Read);
    //        strReader = new StreamReader(crStream);

    //        return strReader.ReadToEnd();
    //    }

    //}

    public static class WordCounting
    {
        /// <summary>
        /// Count words with Regex.
        /// </summary>
        public static int CountWords1(string s)
        {
            MatchCollection collection = Regex.Matches(s, @"[\S]+");
            return collection.Count;
        }

        /// <summary>
        /// Count word with loop and character tests.
        /// </summary>
        public static int CountWords2(string s)
        {
            int c = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (char.IsWhiteSpace(s[i - 1]) == true)
                {
                    if (char.IsLetterOrDigit(s[i]) == true ||
                        char.IsPunctuation(s[i]))
                    {
                        c++;
                    }
                }
            }
            if (s.Length > 2)
            {
                c++;
            }
            return c;
        }
    }
    public static class Common
    {
        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }

        public static List<List<T>> SplitArray<T>(this T[] data, int length)
        {
            List<List<T>> lst = new List<List<T>>();
            int iStart = 0;
            while (iStart < data.Length)
            {
                int iEnd = (iStart + length < data.Length - 1) ? (iStart + length) : data.Length;
                T[] arSub = new T[iEnd - iStart];
                Array.Copy(data, iStart, arSub, 0, iEnd - iStart);
                lst.Add(arSub.ToList());
                iStart = iEnd;
                arSub = null;
            }
            return lst;

        }

        public static List<List<T>> SplitArray<T>(this List<T> data, int length)
        {
            List<List<T>> lst = new List<List<T>>();
            int iStart = 0;
            while (iStart < data.Count)
            {
                int iEnd = (iStart + length < data.Count - 1) ? (iStart + length) : data.Count;
                T[] arSub = new T[iEnd - iStart];
                Array.Copy(data.ToArray(), iStart, arSub, 0, iEnd - iStart);
                lst.Add(arSub.ToList());
                iStart = iEnd;
                arSub = null;
            }
            return lst;

        }

        public static readonly ILog Log = LogManager.GetLogger(typeof(Common));
        public static string CompactUrl(string url)
        {
            string urlresult = url.Replace("https://www.", "")
                .Replace("http://www.", "").Replace("http://", "")
                .Replace("https://", "").Replace("//", "/");
            ;

            if (urlresult.EndsWith("/")) urlresult = urlresult.Substring(0, urlresult.Length - 1);
            if (urlresult.StartsWith("/")) urlresult = urlresult.Substring(1, urlresult.Length - 1);
            if (urlresult.EndsWith("#")) urlresult = urlresult.Substring(0, urlresult.Length - 1);

            return urlresult;
        }

        public static int ParsePromotionInfo(string tempPromotion)
        {
            return 1;
        }

        public static int ParseVATInfo(string strVAT)
        {
            return 1;
        }
        public static string CatSapo(string input, int sotu)
        {
            if (input == null)
            {
                return "";
            }
            string[] strArray = input.Split(new char[] { ' ' });
            if (strArray.Length <= sotu)
            {
                return input;
            }
            return (string.Join(" ", strArray, 0, sotu));
        }

        public enum ProductInstock
        {
            LienHe = 0,
            ConHang = 1,
            HetHang = 2,
            DatHang = 3
        }

        public static ProductInstock GetProductInstockFormStatus(ProductStatus productStatus)
        {
            ProductInstock result = ProductInstock.LienHe;
            switch (productStatus)
            {
                case ProductStatus.LienHe: result = ProductInstock.LienHe; break;
                case ProductStatus.Available: result = ProductInstock.ConHang; break;
                case ProductStatus.Clear: result = ProductInstock.HetHang; break;
                case ProductStatus.Order: result = ProductInstock.DatHang; break;
                case ProductStatus.NotDefine: result = ProductInstock.LienHe; break;
                default: result = ProductInstock.LienHe; break;
            }
            return result;
        }

        public enum ProductStatus
        {
            LienHe = 0,
            Available = 1,
            Clear = 2,
            Order = 3,
            NotDefine = 4,
            SPGocNew = 10,
            SPGocConfig = 11,
            SPGocTrung = 12,
            SPGocKhongXacDinh = 14
        }


        public enum ProductIDStatus
        {
            NotValid = 0,
            Valid = 1
        }
        public enum ListWebCommand
        {
            FindNewManual = 1,
            CrawlerAllQueue = 2,
            ReloadManual = 3,
            CrawlerAll = 4,
            CrawlerAllSanPhamCu = 5,
            CrawlerSanPhamCu = 6, 
            ViewWeb, 
            ViewProfile, 
            AddNewWeb, 
            ViewProduct,
            ExportProduct,
            ViewProduct1, 
            LoadImage, 
            DownloadAllImage, 
            DownloadImage, 
            DownloadAll_Image, 
            ViewQuangCao, 
            ViewThongKeClick, 
            AddNewProductMerchant,
            CrawlerByNewSystem,
            CrawlProductInRedis,
            MapCatAndClassForCompany,

            /// <summary>
            /// Đẩy vào Queue chờ crawler dữ liệu.
            /// </summary>
            PushToJobCrawler,
            MapCatAndClass,
            ReloadNoValidManual,
            DanhGiaCongTy,
            UpdateCategory
        };
        public enum CrawlerCommand { Init, Start, Stop, Pause, Restart, Finish, LoadClassification }

        public static String GetImage(String ImagePath, Int32 ImageWidth)
        {
            if (ImagePath.Trim().Length == 0)
            {
                return "";
            }
            try
            {
                if (ImagePath.IndexOf("http://") >= 0)
                {
                    Uri rootUri = new Uri(ImagePath);
                    ImagePath = rootUri.LocalPath;
                }
                string fileNameOrgin = ImagePath.Substring(ImagePath.LastIndexOf('/') + 1); //FileName.Extension
                string[] fileName = new string[2];// fileNameOrgin.Split('.');
                fileName[1] = fileNameOrgin.Substring(fileNameOrgin.LastIndexOf(".") + 1);
                fileName[0] = fileNameOrgin.Substring(0, fileNameOrgin.LastIndexOf("."));
                string fileName_Thumb = Common.UnicodeToKoDauAndGach(fileName[0]) + "." + fileName[1]; //FilenName_Width.Extension
                string folderName = "";
                folderName = ImagePath.Replace("/" + fileNameOrgin, "");
                ImagePath = "/" + folderName.TrimStart('/') + "/" + fileName_Thumb; //Đường dẫn file Thumb

                if (ImagePath.Length > 0 && ImagePath.LastIndexOf(".") != -1)
                {
                    string strFirst = ImagePath.Substring(0, ImagePath.LastIndexOf("."));
                    string strLast = ImagePath.Substring(ImagePath.LastIndexOf("."), ImagePath.Length - ImagePath.LastIndexOf("."));
                    ImagePath = strFirst + "_" + ImageWidth + strLast;
                }
                return (ImagePath.Length > 0) ? "http://img.websosanh.net/ThumbImages/" + ImagePath.TrimStart('/') : string.Empty;
            }
            catch (Exception)
            {
                return "";
            }
        }
        public static string GetImageOnError(String ImagePath, int Width)
        {
            string path = "";
            path = "http://img.websosanh.vn/Services/GetThumbNail.ashx?ImgFilePath=" + ImagePath;
            path += "&width=" + (Width);
            return path;
        }



        public struct CompanyStatus
        {
            public const byte NOTCONFIG = 0;
            public const byte CONFIG = 1;
            public const byte NOTPRODUCT = 2;
            public const byte TIMEOUT = 3;
            public const byte NOAVAILABLE = 4;

            public const byte SPGOC = 5;
            public const byte TIN = 6;
            public const byte WEB_ADDNEWS = 7;
            public const byte WEB_CRAWLERDOMAIN = 14;
            public const byte WEB_HARAVAN = 18;
            public const byte WEB_BIZWEB = 19;
            public const byte WEB_NOMERCHANT = 20;
        }
        public struct VATStatus
        {
            public const int NotVAT = 0;
            public const int HaveVAT = 1;
            public const int UndefinedVAT = 2;
        }
        public struct DeliveryType
        {
            public const int NotFree = 0;
            public const int Free = 1;
            public const int FreeAndCondition = 2;
            public const int UndefinedDelivery = 3;
        } 
        public struct WEBPartnerStatus
        {
            public const byte NEWS = 0;
            public const byte UNINSTALL = 1;
            public const byte REINSTALL = 2;
        }
        public struct JobType
        {
            public const int Job_DuyetWeb = 1;
            public const int Job_ConfigWebErr = 2;
            public const int Job_ConfigWebOK = 3;
            public const int Job_DayWeb = 4;
        }
        public struct JobNhapLieuStatus
        {
            public const int Job_TaoMoi = 1;
            public const int Job_NhapXong = 2;
            public const int Job_KiemTraOK = 3;
            public const int Job_NhapLai = 4;
        }
        public static bool ValidKeyword(String k)
        {
            k = k.Trim();
            if (k.Trim().Length == 0)
                return false;
            if (k.Trim().Length >= 28)
                return false;
            if (k.Trim().Length <= 2)
                return false;
            if (
                (k.IndexOf('~') >= 0)
                || (k.IndexOf("!") >= 0)
                || (k.IndexOf('@') >= 0)
                || (k.IndexOf('#') >= 0)
                || (k.IndexOf('$') >= 0)
                || (k.IndexOf('%') >= 0)
                || (k.IndexOf('^') >= 0)
                || (k.IndexOf('&') >= 0)
                || (k.IndexOf('*') >= 0)
                || (k.IndexOf('(') >= 0)
                || (k.IndexOf(')') >= 0)
                || (k.IndexOf('-') >= 0)
                || (k.IndexOf('+') >= 0)
                || (k.IndexOf('{') >= 0)
                || (k.IndexOf('}') >= 0)
                || (k.IndexOf('|') >= 0)
                || (k.IndexOf(':') >= 0)
                || (k.IndexOf('"') >= 0)
                || (k.IndexOf('"') >= 0)
                || (k.IndexOf('<') >= 0)
                || (k.IndexOf('>') >= 0)
                || (k.IndexOf('?') >= 0)
                || (k.IndexOf('[') >= 0)
                || (k.IndexOf(']') >= 0)
                || (k.IndexOf('\\') >= 0)
                || (k.IndexOf(';') >= 0)
                || (k.IndexOf('\'') >= 0)
                || (k.IndexOf(',') >= 0)
                || (k.IndexOf('.') >= 0)
                || (k.IndexOf('/') >= 0)

                )
            {
                return false;
            }
            if ((k[0] == '[')
                || (k[0] == ']')
                || (k[0] == ',')
                || (k[0] == '-')
                || (k[0] == '+')
                || (k[0] == '&')
                || (k[0] == '%')
                || (k[0] == '!')
                || (k[0] == '#')
                || (k[0] == '?')
                || (k[0] == '@')
                || (k[0] == '*')
                || (k[0] == '{')
                || (k[0] == '~')
                || (k[0] == '<')
                || (k[0] == '>')
                || (k[0] == '/')
                || (k[0] == ' ')
                )
            {
                return false;
            }
            if ((k[k.Length - 1] == '.')
                || (k[k.Length - 1] == ']')
                || (k[k.Length - 1] == '[')
                || (k[k.Length - 1] == ',')
                || (k[k.Length - 1] == '\\')
                || (k[k.Length - 1] == '%')
                || (k[k.Length - 1] == '!')
                || (k[k.Length - 1] == '#')
                || (k[k.Length - 1] == '?')
                || (k[k.Length - 1] == '@')
                || (k[k.Length - 1] == '>')
                || (k[k.Length - 1] == ':')
                || (k[k.Length - 1] == '/')
                || (k[k.Length - 1] == '-')
                || (k[k.Length - 1] == ' ')
                )
            {
                return false;
            }
            if (


                (k.IndexOf("»") >= 0)
                || (k.IndexOf("Ф") >= 0)
                || (k.IndexOf("®") >= 0)
                || (k.IndexOf("™") >= 0)
                || (k.IndexOf("★") >= 0)
                || (k.IndexOf("`") >= 0)
                || (k.IndexOf("’") >= 0)
                || (k.IndexOf("“") >= 0)
                || (k.IndexOf("”") >= 0)
                || (k.IndexOf("…") >= 0)
                || (k.IndexOf("–") >= 0)
                 || (k.IndexOf("베") >= 0)
                || (k.IndexOf("트") >= 0)
                || (k.IndexOf("남") >= 0)
                || (k.IndexOf("어") >= 0)

                    )
            {
                return false;
            }
            return true;
        }
        public static string TidyCleanR(string html)
        {
            try
            {
                Tidy doc = new Tidy();

                TidyMessageCollection tmc = new TidyMessageCollection();
                MemoryStream input = new MemoryStream();
                MemoryStream output = new MemoryStream();

                //Set some Tidy options, refer to the HTML Tidy docs for more info
                doc.Options.DocType = DocType.Strict;
                doc.Options.Xhtml = true;
                doc.Options.LogicalEmphasis = true;
                doc.Options.DropFontTags = true;
                doc.Options.DropEmptyParas = true;
                doc.Options.QuoteAmpersand = true;
                doc.Options.TidyMark = true;
                doc.Options.MakeClean = true;
                doc.Options.CharEncoding = CharEncoding.UTF8;
                doc.Options.Word2000 = true;
                doc.Options.Spaces = 4;
                doc.Options.WrapLen = 100;
                doc.Options.EncloseText = true;
                //Turn our html into an array of bytes




                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(html);

                //Write out the byte array to the input stream
                input.Write(byteArray, 0, byteArray.Length);

                //Reset the position of the memory stream to the beginning
                input.Position = 0;

                //Parse the input stream, outputting to output, with messages written
                //to our collection of Tidy messages
                doc.Parse(input, output, tmc);

                //Let's check each message
                //foreach (TidyMessage message in tmc)
                //{
                //    //If an error has been thrown, we want to trap for it
                //    if (message.Level == MessageLevel.Error)
                //    {
                //        //Throw a simple ApplicationException
                //        throw new ApplicationException(String.Format("{0} at line {1} column {2}",
                //        message.Message, message.Line,
                //         message.Column));
                //    }
                //}

                //If we got this far, Tidy was able to successfully clean the source.

                string cleanedMarkUp = System.Text.Encoding.UTF8.GetString(output.ToArray()).Replace("<\\/", "</");

                if (cleanedMarkUp.Trim() == "") cleanedMarkUp = html;
                return cleanedMarkUp;
            }
            catch (Exception)
            {
                return html;
            }
        }
        public static string ChuanHoaContent(String html)
        {
            String r = "";
            r = TidyCleanR(html);
            r = RemoveHTMLWord(r);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(r);
            var node = doc.DocumentNode.SelectSingleNode("//body");
            if (node != null)
            {
                r = node.InnerHtml;
            }
            return r;
        }
        public static string ChuanHoaContentRichEdite(String html)
        {
            String r = "";
            r = TidyCleanR(html);
            r = RemoveHTMLWord(r);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(r);
            string style = "";
            var nodestyle = doc.DocumentNode.SelectSingleNode("//style");
            if (nodestyle != null)
            {
                style = nodestyle.OuterHtml;
            }
            var node = doc.DocumentNode.SelectSingleNode("//body");
            if (node != null)
            {
                r = node.InnerHtml;
            }
            return style + r;
        }
        /// <summary>
        /// Ex: nomerchant.websosanh.vn
        /// domain = nomerchant
        /// Trả về detailurl sản phẩm và out ID sản phẩm
        /// </summary>
        /// <summary>
        /// idredis = _productMapRedisServer.IncreaseBy("WSS_MERCHANT_PRODUCT_ID", 1000000777);
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="productname"></param>
        /// <param name="idredis"></param>
        /// <param name="productid"></param>
        /// <returns></returns>
        public static string GetDetailUrlProductNomerchant(string domain, string productname, long idredis, out long productid)
        {
            string urltemp = "http://websosanh.vn/" + domain + "/" + idredis.ToString() + ".htm";
            productid = GetIDProduct(urltemp);
            return "http://websosanh.vn/" + domain + "/" + UnicodeToKoDauAndGach(productname) + "-" + productid.ToString() + "/detail.htm";
        }


        public static long GetIDProduct(String Url)
        {
            long id = 0;
            id = Math.Abs(GABIZ.Base.Tools.getCRC64(Url.Trim().ToLower()));
            return id;
        }

        public static string GetPassWord(String Password)
        {
            return Math.Abs(GABIZ.Base.Tools.getCRC64(Password.Trim())).ToString();
        }
        public static int GetID_ProductID(String Name, int Cat)
        {
            int id = 0;
            id = Math.Abs(GABIZ.Base.Tools.getCRC32(Cat.ToString() + "_" + Name.Trim().ToLower()));
            return id;
        }

        public static long GetID_RootProductIDIndividual(string Name)
        {
            long id = 0;
            id = Math.Abs(GABIZ.Base.Tools.getCRC64(Name.Trim().ToLower()));
            return id;
        }
        public static int GetID_Properties(String Name)
        {
            int id = 0;
            id = Math.Abs(GABIZ.Base.Tools.getCRC32(Name.Trim().ToLower()));
            return id;
        }
        public static int GetID_Value(String Name)
        {
            int id = 0;
            Name = Name.ToString().Trim();
            id = Math.Abs(GABIZ.Base.Tools.getCRC32(Name));
            return id;
        }
        public static int GetID_Properties(String Name, int CategoryID)
        {
            int id = 0;
            id = Math.Abs(GABIZ.Base.Tools.getCRC32(Name.Trim().ToLower() + "_" + CategoryID.ToString()));
            return id;
        }
        public static int GetID_Keywords(String Name)
        {
            int id = 0;
            id = GABIZ.Base.Tools.getCRC32(Name.Trim().ToLower());
            return id;
        }
        public static long GetID_Keywords64(String Name)
        {
            long id = 0;
            id = GABIZ.Base.Tools.getCRC64(Name.Trim().ToLower());
            return id;
        }
        public static long GetIDCompany(String Domain)
        {
            long id = 0;
            if (Domain.Trim().ToLower() == "true")
            {
                return 1;
            }
            if (Domain.Trim().ToLower() == "false")
            {
                return 0;
            }
            id = Math.Abs(GABIZ.Base.Tools.getCRC64(Domain.Trim().ToLower()));
            return id;
        }
        //public static Int32 GetCRCKeyword(String key)
        //{
        //    return GABIZ.Base.Tools.getCRC32(key.Trim().ToUpper());
        //}
        public static string GetKeywordByString(int soTu, string source)
        {
            string r = "";
            int count = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == ' ')
                {
                    count++;
                    if (count == soTu)
                    {
                        r = source.Substring(0, i);
                        break;
                    }
                }
            }
            return r;
        }
        public static long GetIDClassification(String Class)
        {
            long id = 0;
            id = Math.Abs(GABIZ.Base.Tools.getCRC64(Class.Trim().ToLower()));
            return id;
        }
        public static long GetHashNameProduct(String Domain, String Name)
        {
            long id = 0;
            id = GABIZ.Base.Tools.getCRC64(Domain.Trim().ToLower() + Name.Trim().ToLower());
            return id;
        }

        public static string ReplateContenSearchHTML(String text, string keyword)
        {
            String r = "";


            string txt = text.ToLower().Trim();
            string key = keyword.ToLower();
            //int i = txt.IndexOf(key);
            //if (i >= 0)
            //{
            //    r = text.Substring(0, i) + "<span class='highlight'>" + text.Substring(i, key.Length) + "</span>" + text.Substring(i + key.Length);
            //}
            //else
            //{
            //    r = text;
            //}

            string[] ls = keyword.Split(' ');
            string[] lsr = text.Split(' ');

            for (int i1 = 0; i1 < lsr.Length; i1++)
            {
                bool ok = false;
                for (int i2 = 0; i2 < ls.Length; i2++)
                {
                    if (lsr[i1].ToLower() == ls[i2].ToLower())
                    {
                        ok = true;
                        break;
                    }
                }
                if (ok)
                {
                    r += " <strong>" + lsr[i1] + "</strong>";
                }
                else
                {
                    r += " " + lsr[i1];
                }
            }
            r = r.Replace("</strong> <strong>", " ");
            r = r.Replace("  ", " ").Trim();
            //for (int ii = 0; ii < ls.Length; ii++)
            //{
            //    int j = txt.IndexOf(key);
            //    if (j >= 0)
            //    {
            //        r = text.Substring(0, i) + "<span class='highlight'>" + text.Substring(i, key.Length) + "</span>" + text.Substring(i + key.Length);
            //    }
            //}
            return r;
        }

        private static string RemoveHTMLWord(string p)
        {
            if (p == null)
            {
                return string.Empty;
            }
            p = p.Replace(" class=\"MsoNormal\" style=\"margin: 0in 0in 0pt;\"", string.Empty);
            p = p.Replace("<span style=\"color: black;\"><o:p>&nbsp;</o:p></span></p>", string.Empty);
            p = p.Replace("<span style=\"\"><o:p>&nbsp;</o:p></span></p>", string.Empty);
            p = p.Replace("<span style=\"color: black;\"><o:p></o:p></span>", string.Empty);
            p = p.Replace("style=\"color: black;\" lang=\"VI\"", string.Empty);
            p = p.Replace("<span style=\"\"><o:p></o:p></span>", string.Empty);
            p = p.Replace("<p></p>", string.Empty);
            p = p.Replace("</o:p>", string.Empty);
            p = p.Replace("<p><p>", "<p>");
            p = p.Replace("<o:p>", string.Empty);
            p = p.Replace("class=\"MsoNormal\"", string.Empty);
            p = RemoveHTMLCommentTag(p);
            return p;
        }
        private static string RemoveHTMLCommentTag(string htmlString)
        {
            if (htmlString == null)
            {
                return string.Empty;
            }
            string pattern = "<!--(.*?)-->";
            return Regex.Replace(htmlString, pattern, string.Empty);
        }


        #region Chuyen doi xau dang unicode co dau sang dang khong dau
        private const string KoDauChars =
            "aaaaaaaaaaaaaaaaaeeeeeeeeeeediiiiiooooooooooooooooouuuuuuuuuuuyyyyyAAAAAAAAAAAAAAAAAEEEEEEEEEEEDIIIOOOOOOOOOOOOOOOOOOOUUUUUUUUUUUYYYYYAADOOU";

        private const string uniChars =
            "àáảãạâầấẩẫậăằắẳẵặèéẻẽẹêềếểễệđìíỉĩịòóỏõọôồốổỗộơờớởỡợùúủũụưừứửữựỳýỷỹỵÀÁẢÃẠÂẦẤẨẪẬĂẰẮẲẴẶÈÉẺẼẸÊỀẾỂỄỆĐÌÍỈĨỊÒÓỎÕỌÔỒỐỔỖỘƠỜỚỞỠỢÙÚỦŨỤƯỪỨỬỮỰỲÝỶỸỴÂĂĐÔƠƯ";
        public static string Format_DateTime = "yyyy-MM-dd HH:mm:ss";
        /// <summary>
        /// Chuyển đổi 1 xâu từ dạng unicode có dấu sang dạng unicode không dấu
        /// </summary>
        /// <param name="s">xâu unicode có dấu</param>
        /// <returns>xâu unicode không dấu đã convert</returns>
        public static string UnicodeToKoDau(string s)
        {
            string retVal = String.Empty;
            s = s.Trim();
            int pos;
            for (int i = 0; i < s.Length; i++)
            {
                pos = uniChars.IndexOf(s[i].ToString());
                if (pos >= 0)
                    retVal += KoDauChars[pos];
                else
                    retVal += s[i];
            }
            return retVal;
        }
        private static string FormatKeyword(string s)
        {
            string r = s;
            string[] blackword = new string[] { 
                                "`", "~", "!", "@", "#", "$", "%", "^", "&","*", "(", ")","-","_","+","=",
                                 "{", "}", "[", "]", "|", @"\",
                                ":", ";", "'", "\"",
                                "<", ">", ",", ".", "?", "/"  
                            };
            int num;
            for (num = 0; num < blackword.Length; num++)
            {
                r = r.Replace(blackword[num], " ");
            }
            r = r.Trim().Replace("  ", " ");
            r = r.Replace('+', ' ');
            return r;
        }
        public static string UnicodeToKoDauFulltext(string s)
        {
            string retVal = String.Empty;
            s = s.Trim();
            int pos;
            for (int i = 0; i < s.Length; i++)
            {
                pos = uniChars.IndexOf(s[i].ToString());
                if (pos >= 0)
                    retVal += KoDauChars[pos];
                else
                    retVal += s[i];
            }
            return FormatKeyword(retVal);
        }
        public static string UnicodeToKoDauAndGach(string s)
        {
            string strChar = "-abcdefghiklmnopqrstxyzuvxw0123456789 ";
            //string retVal = UnicodeToKoDau(s);
            //s = s.Replace("-", " ");
            //s = s.Replace("–", "");
            s = s.Replace("  ", " ");
            //s = s.Replace("  ", " ");
            s = s.Replace("+", "-");
            s = UnicodeToKoDau(s.ToLower().Trim());
            string sReturn = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (strChar.IndexOf(s[i]) > -1)
                {
                    if (s[i] != ' ')
                        sReturn += s[i];
                    else if (i > 0 && s[i - 1] != '-')
                        sReturn += "-";
                }
            }
            sReturn = sReturn.Replace("--", "-");
            return sReturn;
        }
        #endregion

        public static string GetAbsoluteUrl(string relativeUrl, Uri rootUri)
        {
            try
            {

                Uri temp = new Uri(rootUri, relativeUrl);
                return temp.AbsoluteUri;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string GetAbsoluteUrl(string relative, string baseUrl)
        {
            if (relative.EndsWith("/")) relative = relative.Remove(relative.Length - 1, 1);
            if (relative.ToLower().StartsWith("http:") || relative.ToLower().StartsWith("https:")) return relative;
            else
            {
                return baseUrl + (relative.StartsWith("/") ? relative : "/" + relative);
            }
        }

        public static string ParseDomain(string urlString)
        {
            try
            {
                urlString = Common.CompactUrl(urlString);
                return urlString;
            }
            catch (Exception)
            {
                return "";
            }
        }
        public static bool IsRelevantUrl(string url, List<String> crawlerRegex)
        {
            for (int i = 0; i < crawlerRegex.Count; i++)
            {
                Match m = Regex.Match(url, crawlerRegex[i]);
                if (m.Success)
                    return true;
            }
            return false;
        }
        public static List<string> ParseImage(string input, Uri rootUri, bool getFromRoot)
        {
            List<string> r = new List<string>();
            MatchCollection m = Regex.Matches(input, "[^'\"]*['\"]([^'\"]*.(jpeg|jpg|png|gif|bmp|ashx|\\d+))['\"]\\.*", RegexOptions.IgnoreCase);
            //MatchCollection m = Regex.Matches(input, "[^'\"]*['\"]([^'\"]*.(jpeg|jpg|png|gif|bmp|ashx|\\d+))([&a-zZ-Z0-9=/]+)['\"]\\.*", RegexOptions.IgnoreCase);
            if (rootUri.DnsSafeHost.IndexOf("1top.vn") >= 0)
            {
                m = Regex.Matches(input, "[^'\"]*['\"]([^'\"]*.(jpeg|jpg|png|gif|bmp|ashx|\\d+))([&a-zZ-Z0-9=/]+)['\"]\\.*", RegexOptions.IgnoreCase);
            }
            int L = m.Count;
            for (int i = 0; i < L; i++)
            {
                if (m[i].Success)
                {
                    if ((m[i].Value.Contains("src="))
                        || (m[i].Value.Contains("SRC="))
                        || (m[i].Value.Contains("content="))
                        || (m[i].Value.Contains("CONTENT="))
                        || (m[i].Value.Contains("ImageHolder="))
                        || (m[i].Value.Contains("IMAGEHOLDER="))
                        || (m[i].Value.Contains("imageholder="))
                        || ((m[i].Value.Contains("href=")) && (m[i].Value.Contains(".jpg")))

                        )
                    {
                        if (m[i].Value.IndexOf("noimage") < 0)
                        {
                            // check cos ky tự ~ của shoptretho
                            string img = m[i].Groups[1].Value;
                            if (img.IndexOf('~') >= 0)
                            {
                                img = img.Substring(img.IndexOf('~') + 1);
                            }
                            if (img.IndexOf("../") >= 0)
                            {
                                img = img.Replace("../../../../", "/");
                                img = img.Replace("../../../", "/");
                                img = img.Replace("../../", "/");
                                img = img.Replace("../", "/");
                                img = img.Replace("//", "/");
                            }
                            if (img.IndexOf("./") >= 0)
                            {
                                img = img.Replace("./", "/");
                            }
                            string s = "";
                            if ((img.IndexOf("http://") < 0) && (img.IndexOf("https://") < 0))
                            {
                                if (img[0] != '/')
                                {
                                    if (getFromRoot)
                                    {
                                        img = "http://" + rootUri.DnsSafeHost + "/" + img;
                                    }
                                    //if (
                                    //    (rootUri.DnsSafeHost.IndexOf("bkc.vn") >= 0)
                                    //    || (rootUri.DnsSafeHost.IndexOf("dangcap9x.com") >= 0)
                                    //    || (rootUri.DnsSafeHost.IndexOf("conyeuoi.com") >= 0)
                                    //    || (rootUri.DnsSafeHost.IndexOf("muabanhangngay.com") >= 0)
                                    //    || (rootUri.DnsSafeHost.IndexOf("starmobile.com.vn") >= 0)
                                    //    )
                                    //{
                                    //    img = "http://" + rootUri.DnsSafeHost + "/" + img;
                                    //}
                                    else
                                    {

                                        string sd = rootUri.AbsolutePath.TrimEnd('/');
                                        for (int j = rootUri.AbsolutePath.Length - 1; j >= 0; j--)
                                        {
                                            if (rootUri.AbsolutePath[j] == '/')
                                            {
                                                sd = rootUri.AbsolutePath.Substring(0, j);
                                                break;
                                            }
                                        }
                                        img = sd + "/" + img;
                                    }
                                }
                                s = GetAbsoluteUrl(img, rootUri);
                            }
                            else
                            {
                                s = img;
                            }
                            //if (s.IndexOf(".ashx") >= 0)
                            //{
                            //    s = s.Substring(0, s.IndexOf(".ashx"));
                            //}
                            if (rootUri.DnsSafeHost.IndexOf("1top.vn") >= 0)
                            {
                                s = s + "top/products";
                            }
                            s = HttpUtility.HtmlDecode(s);
                            r.Add(s);
                        }
                    }
                }
            }
            return r;
        }


        public static string ConvertToString(IList<string> input, string split)
        {
            if (input == null)
                return "";
            return string.Join(split, input);
        }

        public static int ParsePrice(string input, bool priceVn)
        {
            input = input.Replace(" ", "");
            if (input.IndexOf('$') >= 0)
            {
                input = input.Split('$')[1];
            }
            var m = Regex.Match(input, @"([\d\.,]+|liên hệ)");
            int r = -1;
            if (m.Success)
            {
                string price = m.Groups[1].Value.ToString();
                if (price.Length >= 3)
                {
                    string tem = price.Substring(0, 2);
                    switch (tem)
                    {
                        case "04":
                        case "08":
                            return 0;
                    }
                }
                var s = price;
                if ((price.IndexOf(",", StringComparison.Ordinal) >= 0) && (price.IndexOf(".", StringComparison.Ordinal) >= 0))
                {
                    if (s.EndsWith(",00")) s = price.Replace(",00", string.Empty);
                    else if (s.EndsWith(".00")) s = price.Replace(".00", string.Empty);
                }
                s = s.Replace(",", String.Empty).Replace(".", String.Empty);
                switch (s)
                {
                    case "liên hệ":
                        r = 0;
                        break;
                    default:
                        int.TryParse(s, out r);
                        break;
                }
                if (r > 1000000000)
                {
                    if (s.IndexOf("1900", StringComparison.Ordinal) >= 0)
                    {
                        return 0;
                    }
                }
            }
            return r;
        }

        public static int ParsePriceMediaMart(string input)
        {
            //<span class="price-0 price-number-8"></span>
            //<span class="price-1 price-number-dot-1 price-number-dot"></span>
            //<span class="price-2 price-number-3"></span>
            //<span class="price-3 price-number-0"></span>
            //<span class="price-4 price-number-0"></span>
            //<span class="price-5 price-number-dot-5 price-number-dot" style="left:-30px;">
            //</span>
            //<span class="price-6 price-number-0"></span>
            //<span class="price-7 price-number-0"></span>
            //<span class="price-8 price-number-0"></span>
            //<span class="price-number-dash-9 price-number-dash"></span>

            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(input);
            for (int i = 0; i < doc.DocumentNode.ChildNodes.Count; i++)
            {

            }


            input = input.Replace(" ", "");
            if (input.IndexOf('$') >= 0)
            {
                input = input.Split('$')[1];
            }
            Match m = Regex.Match(input, @"");
            int r = -1;
            if (m.Success)
            {
                String price = m.Groups[1].Value.ToString();
                if (price.Length >= 3)
                {
                    string tem = price.Substring(0, 2);
                    switch (tem)
                    {
                        case "04":
                        case "08":
                            return 0;
                    }
                }
                //string s = priceVn ? m.Groups[1].Value.Replace(",00", string.Empty).Split(',')[0].Replace(".", string.Empty) : m.Groups[1].Value.Replace(",00", string.Empty).Replace(",", String.Empty).Replace(".", String.Empty);
                string s = price;
                if ((price.IndexOf(",") >= 0) && (price.IndexOf(".") >= 0))
                {
                    s = price.Replace(",00", string.Empty);
                }
                s = s.Replace(",", String.Empty).Replace(".", String.Empty);
                switch (s)
                {
                    case "liên hệ":
                        r = 0;
                        break;
                    default:
                        int.TryParse(s, out r);
                        break;
                }
                if (r > 1000000000)
                {
                    if (s.IndexOf("1900") >= 0)
                    {
                        return 0;
                    }
                }
            }
            return r;
        }

        public static int ParseWarranty(string input)
        {


            string _input = input.ToLower();
            Match m = Regex.Match(_input, @"(\d+)\s*(ngày|tuần|tháng|năm)*");
            int r;
            if (m.Success)
            {
                string s = m.Groups[1].Value.Replace(",", String.Empty).Replace(".", String.Empty);

                r = -1;
                if (int.TryParse(s, out r))
                {
                    string t = m.Groups[2].Value;
                    switch (t)
                    {
                        case "tuần":
                            r = r * 7;
                            break;
                        case "năm":
                            r = r * 360;
                            break;
                        case "tháng":
                        default:
                            r = r * 30;
                            break;
                    }
                    return r;
                }
            }
            return -1;
        }

        public static ProductStatus ParseStatus(string input)
        {
            string _input = input.ToLower();
            Match m = Regex.Match(_input, @"(sẵn hàng|còn hàng|có sẵn|có hàng|\d+|hết hàng|đặt hàng|yêu cầu|liên hệ)");
            ProductStatus stt = ProductStatus.NotDefine;
            if (m.Success)
            {
                string s = m.Groups[1].Value.Replace(",", String.Empty).Replace(".", String.Empty);
                switch (s)
                {
                    case "sẵn hàng":
                    case "còn hàng":
                    case "có hàng":
                    case "có sẵn":
                    case "mua ngay":
                        stt = ProductStatus.Available;
                        break;
                    case "hết hàng":
                    case "hết hạn":
                        stt = ProductStatus.Clear;
                        break;
                    case "đặt hàng":
                    case "yêu cầu":
                        stt = ProductStatus.Order; break;
                    case "liên hệ":
                        stt = ProductStatus.LienHe; break;
                        break;
                    default:
                        int r = -1;
                        if (int.TryParse(s, out r))
                        {
                            stt = r > 0 ? ProductStatus.Available : ProductStatus.Clear;
                        }
                        break;
                }
            }
            return stt;
        }
        public static String ParsePhone(string input)
        {

            string r = input.Replace("Điện thoại : ", "");
            //Match m = Regex.Match(input, @"([\d\.,]+|liên hệ)");
            //int r = -1;
            //if (m.Success)
            //{
            //    string s = m.Groups[1].Value.Replace(",", String.Empty).Replace(".", String.Empty);
            //    switch (s)
            //    {
            //        case "liên hệ":
            //            r = 0;
            //            break;
            //        default:
            //            int.TryParse(s, out r);
            //            break;
            //    }
            //}
            return r;
        }
        public static String ParseYahoo(string input)
        {

            string r = input.Replace("Điện thoại : ", "");
            //Match m = Regex.Match(input, @"([\d\.,]+|liên hệ)");
            //int r = -1;
            //if (m.Success)
            //{
            //    string s = m.Groups[1].Value.Replace(",", String.Empty).Replace(".", String.Empty);
            //    switch (s)
            //    {
            //        case "liên hệ":
            //            r = 0;
            //            break;
            //        default:
            //            int.TryParse(s, out r);
            //            break;
            //    }
            //}
            return r;
        }
        public static String ParseName(string input)
        {
            string r = input.Replace('\t', ' ');
            r = r.TrimEnd(new char[] { '-', ' ', '>' });
            r = r.TrimStart(new char[] { '-', ' ', '>' });
            for (int i = 0; i < r.Length; i++)
            {
                if (r.IndexOf("  ") > 0)
                {
                    r = r.Replace("  ", " ");
                }
                else
                {
                    break;
                }
            }
            return r;
        }

        public static Byte Obj2Byte(object obj)
        {
            if (obj == null)
                return 0;
            try
            {
                return Convert.ToByte(obj.ToString().Replace(",", string.Empty), CultureInfo.InvariantCulture);
            }
            catch
            {
                return 0;
            }
        }
        public static String Obj2String(object obj)
        {
            if (obj == null)
                return "";
            try
            {
                return obj.ToString();
            }
            catch
            {
                return "";
            }
        }
        public static int Obj2Int(object obj, int defaultValue = 0)
        {
            if (obj == null)
                return 0;
            try
            {
                return Convert.ToInt32(obj.ToString().Replace(",", string.Empty), CultureInfo.InvariantCulture);
            }
            catch
            {
                return defaultValue;
            }
        }
        public static Boolean Obj2Bool(object obj)
        {
            if (obj == null)
                return false;
            try
            {
                return Convert.ToBoolean(obj.ToString());
            }
            catch
            {
                return false;
            }
        }

        public static double Obj2Double(object value)
        {
            if (value == null || value.ToString().Trim() == "")
                return 0;
            try
            {
                return Convert.ToDouble(value, CultureInfo.InvariantCulture);
            }
            catch
            {
                return 0;
            }
        }

        public static decimal Obj2Decimal(object value)
        {
            if (value == null || value.ToString().Trim() == "")
                return 0;
            try
            {
                return Convert.ToDecimal(value, CultureInfo.InvariantCulture);
            }
            catch
            {
                return 0;
            }
        }

        public static long Obj2Int64(object obj)
        {
            try
            {
                return Convert.ToInt64(obj);
            }
            catch
            {
                return 0;
            }
        }

        public static DateTime ObjectToDataTime(object value)
        {
            DateTime dt = DateTime.MinValue;
            try
            {
                dt = Convert.ToDateTime(value);
            }
            catch
            {
                dt = DateTime.MinValue;
            }
            return dt;
        }

      

        public static Alexa GetRankAlexa(String c_url)
        {
            Alexa r = new Alexa();
            c_url = c_url.Trim();
            if (!string.IsNullOrEmpty(c_url))
            {
                try
                {
                    c_url = c_url.Replace("www.", "");

                    string url = string.Format("http://www.alexa.com/siteinfo/{0}#trafficstats", c_url);
                    string html = Common.RemoveHTMLCommentTag(HTMLTransmitter.getHTML(url, 60, 3));
                    // html = TidyCleanR(html);
                    var doc = new HtmlDocument();
                    doc.LoadHtml(html);
                    // id="results"
                    //string AlexaRankXPath = "//*[@id='traffic-rank-content']/div/span[2]/div[1]/span/span/div/strong/a";
                    string AlexaRankXPath = "//*[@data-cat='globalRank']/div/strong";
                    var node_AlexaRank = doc.DocumentNode.SelectNodes(AlexaRankXPath);
                    if (node_AlexaRank != null)
                    {
                        try
                        {
                            var rank = node_AlexaRank[0].InnerText.Replace("\n", "").Replace("\t", "").Trim();
                            r.AlexaRank = Obj2Int(rank);
                        }
                        catch (Exception)
                        {
                        }
                    }
                    string AlexaRankVNXPath = "//*[@data-cat='countryRank']/div/strong";
                    var node_AlexaRankVN = doc.DocumentNode.SelectNodes(AlexaRankVNXPath);
                    if (node_AlexaRank != null)
                    {
                        try
                        {
                            var rankVN = node_AlexaRankVN[0].InnerText.Replace("\n", "").Replace("\t", "").Trim();
                            r.AlexaRankContries = Obj2Int(rankVN);
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                catch (Exception)
                {
                    return null;
                    //throw;
                }

            }
            else
            {
                return null;
            }
            return r;
        }

        public static String GetInnerTextXPath(string html, string xPath)
        {
            string r = "";
            // html = TidyCleanR(html);
            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            var node = doc.DocumentNode.SelectSingleNode(xPath);
            if (node != null)
            {
                r = Tools.removeHTML(node.InnerText);
            }
            return r;
        }
        public static string SaveFile(string url, string directory)
        {
            string fileName = url.Substring(url.LastIndexOf("/") + 1);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            WebClient wc = new WebClient();
            try
            {
                wc.DownloadFile(url, directory + @"\" + fileName);
                wc.Dispose();
                return fileName;
            }
            catch (Exception)
            {
                wc.Dispose();
                return "";
            }
        }
        //public static string SaveFile(string url, string directory, string fileName)
        //{
        //    //string fileName = url.Substring(url.LastIndexOf("/") + 1);
        //    if (!Directory.Exists(directory))
        //        Directory.CreateDirectory(directory);

        //    WebClient wc = new WebClient();
        //    try
        //    {
        //        wc.DownloadFile(url, directory + @"\" + fileName);
        //        wc.Dispose();
        //        return fileName;
        //    }
        //    catch (Exception)
        //    {
        //        wc.Dispose();
        //        return "";
        //    }
        //}
        public static string GetFileNameFromURL(string url)
        {
            string fileName = url.Substring(url.LastIndexOf("/") + 1);
            return fileName;
        }

        //public static string SaveFile(string uri, string directory, string fileName)
        //{
        //    if (!Directory.Exists(directory))
        //        Directory.CreateDirectory(directory);
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
        //    HttpWebResponse response;
        //    try
        //    {
        //        response = (HttpWebResponse)request.GetResponse();
        //    }
        //    catch (Exception)
        //    {
        //        return "";
        //    }

        //    // Check that the remote file was found. The ContentType
        //    // check is performed since a request for a non-existent
        //    // image file might be redirected to a 404-page, which would
        //    // yield the StatusCode "OK", even though the image was not
        //    // found.
        //    if ((response.StatusCode == HttpStatusCode.OK ||
        //        response.StatusCode == HttpStatusCode.Moved ||
        //        response.StatusCode == HttpStatusCode.Redirect) &&
        //        response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase))
        //    {

        //        // if the remote file was found, download it
        //        using (Stream inputStream = response.GetResponseStream())
        //        using (Stream outputStream = File.OpenWrite(directory + @"\" + fileName))
        //        {
        //            byte[] buffer = new byte[4096];
        //            int bytesRead;
        //            do
        //            {
        //                bytesRead = inputStream.Read(buffer, 0, buffer.Length);
        //                outputStream.Write(buffer, 0, bytesRead);
        //            } while (bytesRead != 0);
        //        }
        //        return fileName;
        //    }
        //    else
        //        return "";
        //}

        public static string SaveFile(string url, string directory, string fileName, out int width, out int height, bool resizeImage)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            try
            {
                url = url.Substring(url.LastIndexOf("http"));

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Bitmap thumbBitmap = null;
                thumbBitmap = new Bitmap(response.GetResponseStream());
                //
                width = thumbBitmap.Width;
                height = thumbBitmap.Height;
                if (resizeImage)
                {
                    Resize(thumbBitmap, directory + @"\" + fileName, 450);
                }
                else
                {
                    thumbBitmap.Save(directory + @"\" + fileName);
                }
                return fileName;
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("SaveFile ERROR with url = {0}", url), ex);
                width = 0; height = 0;
                return "";
            }
        }

        /// <summary>
        /// Viết lại để check log Lỗi download
        /// </summary>
        /// <param name="url"></param>
        /// <param name="directory"></param>
        /// <param name="fileName"></param>
        /// <param name="IdProduct"></param>
        /// <returns></returns>
        //public static bool SaveFileDownloadImage(string url, string directory, string fileName, long IdProduct, long companyId)
        //{
        //    try
        //    {
        //        if (!Directory.Exists(directory))
        //            Directory.CreateDirectory(directory);
        //        var a = Regex.Match(url, "http").Captures;
        //        if (a.Count > 1)
        //            url = url.Substring(url.LastIndexOf("http"));
        //        else if (a.Count ==0)
        //            url = "http://" + url;
        //        HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
        //        request.Credentials = CredentialCache.DefaultCredentials;
        //        request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36";
        //        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //        Bitmap thumbBitmap = null;
        //        thumbBitmap = new Bitmap(response.GetResponseStream());
        //        thumbBitmap.Save(directory + @"\" + fileName);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        if (companyId != 0)
        //            Log.Error(string.Format("CompanyID = {0} ProductID = {1}, ImageUrls = {2} Download Error.", companyId, IdProduct, url), ex);
        //        else
        //            Log.Error(string.Format("ProductID = {0}, ImageUrls = {1} Download Error.", IdProduct, url), ex);
        //        return false;
        //    }
        //}

        public static void SaveImageProduct(string url, string directory, string fileName)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            var a = Regex.Match(url, "http").Captures;
            if (a.Count > 1)
                url = url.Substring(url.LastIndexOf("http"));
            else if (a.Count == 0)
                url = "http://" + url;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            request.UserAgent =
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36";
            var response = (HttpWebResponse)request.GetResponse();
            Bitmap thumbBitmap = null;
            thumbBitmap = new Bitmap(response.GetResponseStream());
            thumbBitmap.Save(directory + @"\" + fileName);
        }

        #region Download Image
        public static string GetFolderSaveImageProduct(string nameProduct, string detailUrl)
        {
            string folder;
            try
            {
                var root = new Uri(detailUrl);
                var domain = root.DnsSafeHost.Replace("www.", "");
                folder = domain.Substring(0, 1) + "\\" + root.DnsSafeHost.Replace("www.", "").Replace('.', '_');

                var tempFolder = nameProduct.Replace("-", "");
                if (tempFolder.Length < 3)
                {
                    if (tempFolder.Length == 1)
                        folder = folder + "\\" + tempFolder + "01";
                    else
                        folder = folder + "\\" + tempFolder + "1";
                }
                else
                {
                    var temp = tempFolder.Substring(0, 3);
                    if (folder == "bin") folder = "bin1";
                    if (folder == "con") folder = "con1";
                    if (folder == "aux") folder = "aux1";
                    if (folder == "prn") folder = "prn1";
                    if (folder == "nul") folder = "nul1";
                    folder = folder + "\\" + temp;
                }
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("Product: {0}, DetailUrl: {1}", nameProduct, detailUrl), exception);
                throw;
            }
            return folder;
        }
        /// <summary>
        /// Lấy folder chứa ảnh sản phẩm gốc khi download về
        /// </summary>
        /// <param name="nameProduct">Name Product -> Unicode KoDau & Gach</param>
        /// <returns></returns>
        public static string GetFolderSaveImageRootProduct(string nameProduct)
        {
            string folder;
            var tempFolder = nameProduct.Replace("-", "");
            if (tempFolder.Length < 3)
            {
                if (tempFolder.Length == 1)
                    folder = tempFolder + "01";
                else
                    folder = tempFolder + "1";
            }
            else
            {
                folder = tempFolder.Substring(0, 3);
                if (folder == "bin") folder = "bin1";
                if (folder == "con") folder = "con1";
                if (folder == "aux") folder = "aux1";
                if (folder == "prn") folder = "prn1";
                if (folder == "nul") folder = "nul1";
            }
            return folder;
        }
        /// <summary>
        /// ImagePath of Product in SQL
        /// </summary>
        public static string GetImagePathProduct(string folder, string fileName)
        {
            return "Store/" + folder.Replace("\\","/") + "/" + fileName ;
        }
        /// <summary>
        /// ImagePath of RootProduct in SQL
        /// </summary>
        public static string GetImagePathRootProduct(string folder, string fileName)
        {
            return "Store/images/" + folder.Replace("\\", "/") + "/" + fileName;
        }
        #endregion
        public static string FolderImage
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["FolderImage"].ToString();
                }
                catch (Exception)
                {
                    return "D:\\Image\\";
                }
            }
        }
        public static string FolderThumbImage
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["FolderThumbImage"].ToString();
                }
                catch (Exception)
                {
                    return "F:\\img.websosanh.net\\ThumbImages\\Store\\";
                }
            }
        }
        public static bool DowloadFullImage
        {
            get
            {
                try
                {
                    return Obj2Bool(ConfigurationManager.AppSettings["DowloadFullImage"].ToString());
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        enum AnchorPosition
        {
            Top,
            Center,
            Bottom,
            Left,
            Right
        }
        public static string Resize(Bitmap bmp, string strFileThumb, int P_Width)
        {
            string thumbnailFilePath = string.Empty;
            string FileName = string.Empty;

            try
            {
                float ratio = (float)bmp.Height / bmp.Width;
                if (P_Width > bmp.Width)
                {
                    P_Width = bmp.Width;
                }

                //int imgHeight = 0;
                System.Drawing.Image img = Crop(bmp, P_Width, (int)(P_Width * ratio), AnchorPosition.Center);
                //int iz = HttpContext.Current.Request.QueryString["iz"] != null ? Convert.ToInt32(HttpContext.Current.Request.QueryString["iz"]) : 0;
                //switch (iz)
                //{
                //    case 0 : 
                //        //3x4
                //        imgHeight = Convert.ToInt32( 0.75 * P_Width);
                //        break;
                //    case 1:
                //        //16x9
                //        imgHeight = Convert.ToInt32((float)9 / 16 * P_Width);
                //        break;
                //    default:
                //        // normal:
                //        imgHeight = Convert.ToInt32( ratio * P_Width);
                //        break;
                //}

                ////imgHeight = Convert.ToInt32((float)9 / 16 * P_Width);

                //System.Drawing.Image img = Crop(bmp, P_Width + 1, imgHeight + 1, AnchorPosition.Center);
                using (Bitmap thumb = new Bitmap(img))
                {
                    //thumb.SetResolution(P_Width, P_Width);
                    using (Graphics g = Graphics.FromImage(thumb)) // Create Graphics object from original Image
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                        g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                        //Set Image codec of JPEG type, the index of JPEG codec is "1"
                        System.Drawing.Imaging.ImageCodecInfo codec = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()[1];
                        //Set the parameters for defining the quality of the thumbnail... here it is set to 100%
                        System.Drawing.Imaging.EncoderParameters eParams = new System.Drawing.Imaging.EncoderParameters(1);
                        eParams.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 92L);
                        //Now draw the image on the instance of thumbnail Bitmap object
                        g.DrawImage(thumb, new Rectangle(0, 0, thumb.Width, thumb.Height));
                        thumb.Save(strFileThumb, codec, eParams);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FileName;
        }

        static Image Crop(Image imgPhoto, int Width, int Height, AnchorPosition Anchor)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
            {
                nPercent = nPercentW;
                switch (Anchor)
                {
                    case AnchorPosition.Top:
                        destY = 0;
                        break;
                    case AnchorPosition.Bottom:
                        destY = (int)(Height - (sourceHeight * nPercent));
                        break;
                    default:
                        destY = (int)((Height - (sourceHeight * nPercent)) / 2);
                        break;
                }
            }
            else
            {
                nPercent = nPercentH;
                switch (Anchor)
                {
                    case AnchorPosition.Left:
                        destX = 0;
                        break;
                    case AnchorPosition.Right:
                        destX = (int)(Width - (sourceWidth * nPercent));
                        break;
                    default:
                        destX = (int)((Width - (sourceWidth * nPercent)) / 2);
                        break;
                }
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width - 1, Height - 1, PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.White);
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight - 2),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }






        public static bool SaveFileWatermarked(string url, string directory, string fileName, string text)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Bitmap bmp = null;
                bmp = new Bitmap(response.GetResponseStream());
                Graphics canvas = Graphics.FromImage(bmp);
                Bitmap bmpNew = new Bitmap(bmp.Width, bmp.Height);
                canvas = Graphics.FromImage(bmpNew);
                canvas.DrawImage(bmp, new Rectangle(0, 0,
                        bmpNew.Width, bmpNew.Height), 0, 0, bmp.Width, bmp.Height,
                        GraphicsUnit.Pixel);
                bmp = bmpNew;
                canvas.DrawString(text,
                    new Font("Verdana", 14, FontStyle.Bold), new SolidBrush(Color.Beige), (bmp.Width / 2), (bmp.Height / 2));
                bmp.Save(directory + @"\" + fileName);
            }
            catch (Exception)
            {

                return false;
            }
            return true;

        }


        public static string getTuKhoa(string nameProduct, int p)
        {
            string r = "";
            string[] blackword = new string[] { 
                                " ", "!", "@", "#", "$", "%", "^", "&", "(", ")", "{", "}", "[", "]", "<", ">", 
                                ",", ".", "?", "/", "|", @"\", "`", "~"
                            };
            int num;
            for (num = 0; num < blackword.Length; num++)
            {
                nameProduct = nameProduct.Replace(blackword[num], " ");
            }
            nameProduct = nameProduct.Trim().Replace("  ", " ");

            string[] sa = nameProduct.Split(' ');
            if (p < sa.Length)
            {
                r = sa[p].ToString();
            }
            else
            {
                r = sa[sa.Length - 1].ToString();
            }
            return r;
        }

        public static string BuildNotLikeOneCharSQLWhere(string p)
        {
            String sql = "";
            sql = "'%xxxxxxxxx%'";
            if (p.Length == 0)
            {
            }
            else
            {
                string[] s = p.Split(' ');
                for (int i = 0; i < s.Length; i++)
                {
                    sql += String.Format(")OR (NameFT not like N'%{0}%'", s[i]);
                }
            }
            return sql;
        }

        public static List<string> GetListXPathFromString(string input)
        {
            return input.Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
        }



        public static bool CellToBool(DataRow dataRow, string column, bool defaultValue)
        {
            if (dataRow[column] == DBNull.Value) return defaultValue;
            else return Convert.ToBoolean(dataRow[column]);
        }

      

        internal static DateTime ParseToDateTime()
        {
            throw new NotImplementedException();
        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="xPath"></param>
        /// <returns></returns>
        public static List<string> GetTextInNode(HtmlDocument document, string xPath, ConfigXPaths config = null)
        {
            string oldXPath = xPath;
            List<string> lst = new List<string>();
            string prefixField = "";
            if (xPath.Contains('{'))
            {
                xPath = oldXPath.Split('{')[0].Trim();
                prefixField = oldXPath.Split('{')[1].Replace("}", "").Trim();
            }

            string absoluteApath = xPath;
            string atribute = "";
            if (Regex.IsMatch(xPath, @".*/@[\w]{1,}"))
            {
                absoluteApath = xPath.Substring(0, xPath.LastIndexOf("@") - 1);
                atribute = xPath.Substring(xPath.LastIndexOf("@") + 1);
            }
            var nodesSuccess = document.DocumentNode.SelectNodes(absoluteApath);
            if (nodesSuccess != null && nodesSuccess.Count > 0)
            {
                foreach (var node in nodesSuccess)
                {
                    if (atribute == "")
                    {
                        string text = node.InnerText.Trim();
                        if (!string.IsNullOrEmpty(text))
                            lst.Add(text);
                    }
                    else
                    {
                        if (node.Attributes.Contains(atribute)) lst.Add(node.Attributes[atribute].Value.ToString());
                    }
                }
            }
            return lst;
        }

        public static string GetSplug(string url, bool bIngoneSign = true)
        {
            string result = Common.RemoveDumplicateSpace(url.ToLower()); //chữ thường+bỏ nhiều cách

            if (result.EndsWith("/")) result = url.Remove(url.Length - 1, 1);
            if (result.Contains("/"))
            {
                result = result.Substring(result.LastIndexOf('/') + 1);
            }

            if (bIngoneSign) result = Common.UnicodeToKoDau(result); //bỏ dấu
            result = result.Replace(" ", "-").Replace(".", "-");
            while (result.Contains("--")) result = result.Replace("--", "-");


            StringBuilder sb = new StringBuilder();
            foreach (char c in result)
            {
                if (Char.IsLetterOrDigit(c) || (c == '-') || uniChars.Contains(c)
                    || KoDauChars.Contains(c))
                {
                    sb.Append(c);
                }
            }

            result = sb.ToString();
            return result;
        }


        /// <summary>
        /// Kí tự thông thường, có dấu. 
        /// Không xuống dòng
        /// Max 200 kí tự
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ParseExcerpt(string input)
        {
            string result = input;
            result = Common.RemoveDumplicateSpace(result);
            StringBuilder sb = new StringBuilder();
            foreach (char c in result)
            {
                if (Char.IsLetterOrDigit(c) || uniChars.Contains(c)
                    || KoDauChars.Contains(c)
                    || c == ' ' || c == '.' || c == ',')
                {
                    sb.Append(c);
                    if ((sb.Length > 200 && c == '.') || sb.Length > 600) break;
                }
            }
            string a = sb.ToString();
            return a;
        }


        public static string GetParaForCassDb(string strInput)
        {
            StringBuilder builder = new StringBuilder(strInput.Length * 2);
            for (int i = 0; i < strInput.Length; i++)
            {
                char charCurrent = strInput[i];
                if (charCurrent == '\'')
                {
                    builder.Append('\'');
                    builder.Append(charCurrent);
                }
                else
                {
                    builder.Append(charCurrent);
                }
            }
            return builder.ToString();
        }

        public static List<string> GetLstParaCas(List<string> lstInput)
        {
            List<string> lstResult = new List<string>();
            foreach (string a in lstInput)
            {
                lstResult.Add(GetParaForCassDb(a));
            }
            return lstResult;
        }

        public static string GetParaForCassDb(decimal input)
        {
            return input.ToString();
        }




        public static GABIZ.Base.HtmlAgilityPack.HtmlNode GetNodeChildByName(GABIZ.Base.HtmlAgilityPack.HtmlNode input, string[] Name)
        {
            foreach (var node in input.ChildNodes)
                if (Name.Contains(node.Name)) return node;
            return null;
        }
        public static string ChuanHoaUnicode(string txtdata)
        {
            string result = Regex.Replace(txtdata, "\t|\n", "").Replace("&gt;", "").Trim();
            result = System.Web.HttpUtility.HtmlDecode(result);
            return result;
        }
        public static string ConvertArByeToString(byte[] source)
        {
            return source != null ? Encoding.UTF8.GetString(source) : null;
        }

        public static string GetUrlNotSchemar(string currentUrl)
        {
            string str = currentUrl;
            str = str.Replace(@"http://", "");
            str = str.Replace(@"https://", "");
            return str;
        }
        /// <summary>
        /// Xóa kí tự trắng bị lặp.
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static string RemoveDumplicateSpace(string result)
        {
            while (result.Contains("  ")) result = result.Replace("  ", " ");
            return result;
        }

        public static string CellToString(Cassandra.Row row, string p1, string p2)
        {
            throw new NotImplementedException();
        }

        public static decimal CellToDecimal(Cassandra.Row row, string p1, decimal p2)
        {
            throw new NotImplementedException();
        }

      

        public static int CellToInt(DataRow rowInfo, string field, int defaultValue)
        {
            return (rowInfo[field] == DBNull.Value) ? defaultValue : Convert.ToInt32(rowInfo[field]);
        }

        public static DateTime CellToDateTime(Cassandra.Row row, string p, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public static DateTime CellToDateTime(DataRow rowInfo, string field, DateTime defaultValue)
        {
            return (rowInfo[field] == DBNull.Value) ? defaultValue : Convert.ToDateTime(rowInfo[field]);
        }

        internal static List<string> ConvertToList(string p)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Xóa mọi kí tự trống
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ChangeSpaceCharacter(string input)
        {
            input = Regex.Replace(input, @"\n|\r|\t", " ");
            return input;
        }

        public static string ConvertToString(List<string> input, string split = ";\n")
        {
            if (input == null)
                return "";
            return string.Join(split, input);
        }

        public static DateTime ParseDateTime(string input)
        {
            string strInput = Common.RemoveDumplicateSpace(input).Replace("-", "/");

            try
            {
                bool bSubFromCurrent = false;
                string dateText = "";
                string timeText = "";
                foreach (string strRegex in arFixedRegex)
                {
                    Match match = Regex.Match(strInput, @".*" + strRegex + @".*");
                    if (match != null && match.Captures.Count > 0)
                    {
                        //Các trường hợp đặc biệt xử lí ngay
                        if (strRegex == RegexTime10)
                        {
                            string strInput1 = Common.RemoveDumplicateSpace(strInput.Replace("lúc", " "));
                            return ParseDateTime(strInput1);
                        }
                        else if (strRegex == RegexTime9)
                        {
                            string strTime = Regex.Match(strInput, strRegex).Captures[0].Value.ToString();
                            dateText = Regex.Match(strTime, @"\d{1,2}\/\d{1,2}/\d{1,4}").Captures[0].Value.ToString();
                            timeText = Regex.Match(strTime, @"\d{1,2}\:\d{1,2}").Captures[0].Value.ToString();
                        }
                        else if (strRegex == RegexTime1)
                        {
                            //@"\d{1,2}\/\d{1,2}\s\d{1,2}\:\d{1,2}"
                            string strTime = Regex.Match(strInput, strRegex).Captures[0].Value.ToString();
                            dateText = Regex.Match(strTime, @"\d{1,2}\/\d{1,2}").Captures[0].Value.ToString();
                            timeText = Regex.Match(strTime, @"\d{1,2}\:\d{1,2}").Captures[0].Value.ToString();
                            bSubFromCurrent = false;
                            break;
                        }
                        else if (strRegex == RegexTime7)
                        {
                            string strTime = Regex.Match(strInput, strRegex).Captures[0].Value.ToString();
                            dateText = Regex.Match(strTime, @"\d{1,2}\/\d{1,2}").Captures[0].Value.ToString();
                            timeText = Regex.Match(strTime, @"\d{1,2}\:\d{1,2}").Captures[0].Value.ToString();
                            bSubFromCurrent = false;
                            break;
                        }
                        else if (strRegex == RegexTime6)
                        {
                            //\d{1,2}\/\d{1,2}\/\d{2,4}\s\d{1,2}\:\d{1,2}
                            string strTime = Regex.Match(strInput, strRegex).Captures[0].Value.ToString();
                            dateText = Regex.Match(strTime, @"\d{1,2}\/\d{1,2}\/\d{2,4}").Captures[0].Value.ToString();
                            timeText = Regex.Match(strTime, @"\d{1,2}\:\d{1,2}").Captures[0].Value.ToString();
                            bSubFromCurrent = false;
                            break;
                        }
                        else if (strRegex == RegexTime4)
                        {
                            string timeSpan = Regex.Match(strInput, strRegex).Captures[0].Value.ToString();
                            timeSpan = timeSpan.Replace("đăng", "");
                            timeSpan = timeSpan.Replace("phút trước", "");
                            timeSpan = timeSpan.Replace(" ", "");
                            timeText = "0:" + timeSpan.Trim();
                            dateText = DateTime.Now.ToString("dd/MM/yyyy");
                            bSubFromCurrent = true;
                            break;
                        }
                        else if (strRegex == RegexTime3)
                        {
                            //đăng hôm qua \d{1,2}\:\d{1,2}
                            string timeSpan = Regex.Match(strInput, strRegex).Captures[0].Value.ToString();
                            timeSpan = timeSpan.Replace("đăng hôm qua", "").Trim();
                            timeText = timeSpan;
                            dateText = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
                            break;
                        }
                        else if (strRegex == RegexTime8)
                        {
                            //ngày đăng : hôm nay, lúc \d{1,2}:\d{1,2}
                            string timeSpan = Regex.Match(strInput, strRegex).Captures[0].Value.ToString();
                            timeSpan = timeSpan.Replace("ngày đăng : ", "").Replace("lúc", "").Replace("hôm nay", "").Replace(",", "").Trim();
                            timeText = timeSpan;
                            dateText = DateTime.Now.AddDays(0).ToString("dd/MM/yyyy");
                            break;
                        }
                        else if (strRegex == @"\d{1,2} giờ \d{1,2} phút trước")
                        {
                            string timeSpan = Regex.Match(strInput, strRegex).Captures[0].Value.ToString();
                            timeSpan = timeSpan.Replace("giờ", ":");
                            timeSpan = timeSpan.Replace("phút trước", "");
                            timeSpan = timeSpan.Replace(" ", "");
                            timeText = timeSpan;
                            dateText = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
                            bSubFromCurrent = true;
                            break;
                        }
                        else if (strRegex == @"đăng ngày \d{1,2} tháng \d{1,2} \d{1,2}:\d{1,2}")
                        {
                            string timePost = Regex.Match(strInput, strRegex).Captures[0].Value.ToString();
                            timePost = timePost.Replace("đăng ngày", "").Trim();
                            timePost = timePost.Replace(" tháng ", "/").Trim();
                            dateText = timePost.Split(' ')[0].Trim() + "/" + DateTime.Now.Year.ToString();
                            timeText = timePost.Split(' ')[1].Trim();
                        }
                        else if (strRegex == RegexTime5)
                        {
                            dateText = Regex.Match(strInput, strRegex).Captures[0].Value.ToString();
                        }

                        else
                        {
                            dateText = Regex.Match(strInput, strRegex).Captures[0].Value.ToString();
                        }
                    }
                }
                CultureInfo cultureInfo = new CultureInfo("en-US");
                DateTime date = SqlDb.MinDateDb;
                bool bOK = DateTime.TryParseExact(dateText, new string[] { "d/MM", "dd/MM", "dd/MM/yy", "dd/M/yy", "d/MM/yy", "d/M/yy", "dd/MM/yyyy", "dd/M/Myyyy", "d/MM/yyyy", "d/M/yyyy" }
                , cultureInfo, DateTimeStyles.AllowInnerWhite, out date);
                if (bOK)
                {
                    TimeSpan timeSpan = (!string.IsNullOrEmpty(timeText) && timeText.Contains(':')) ? new TimeSpan(0, Convert.ToInt32(timeText.Split(':')[0]), Convert.ToInt32(timeText.Split(':')[1]), 0) : new TimeSpan(0, 0, 0);
                    if (bSubFromCurrent)
                    {
                        date = DateTime.Now - timeSpan;
                    }
                    else
                    {
                        date = date + timeSpan;
                    }
                }
                else
                {
                    date = SqlDb.MinDateDb;
                }
                if (date != SqlDb.MinDateDb) return date;
            }
            catch (Exception ex1)
            {
                return SqlDb.MinDateDb;
            }
            return SqlDb.MinDateDb;
        }


        static string RegexTime1 = @"\d{1,2}\/\d{1,2}\s\d{1,2}\:\d{1,2}";
        static string RegexTime6 = @"\d{1,2}\/\d{1,2}\/\d{2,4}\s\d{1,2}\:\d{1,2}";
        static string RegexTime10 = @"\d{1,2}\/\d{1,2}\/\d{2,4}\s*lúc\s*\d{1,2}\:\d{1,2}";
        static string RegexTime3 = @"đăng hôm qua \d{1,2}\:\d{1,2}";
        static string RegexTime2 = @"\d{1,2}\/\d{1,2}\s\d{1,2}";
        static string RegexTime4 = @"đăng \d{1,2} phút trước";
        static string RegexTime5 = @"\d{1,2}\/\d{1,2}\/\d{2,4}";
        static string RegexTime7 = @"gửi lúc:\s*\d{1,2}:\d{1,2},\s*\d{1,2}/\d{1,2}";
        static string RegexTime8 = @"ngày đăng : hôm nay, lúc \d{1,2}:\d{1,2}";
        static string RegexTime9 = @"\d{1,2}:\d{1,2}\s*\|\s*\d{1,2}/\d{1,2}/\d{1,4}";
        static string[] arFixedRegex = new string[]{    
             RegexTime10
            ,RegexTime9
            ,RegexTime8
            ,RegexTime7
            ,RegexTime6
            ,RegexTime5
            ,RegexTime1
            ,RegexTime2
            ,RegexTime3
            ,RegexTime4
            , @"đăng ngày \d{1,2} tháng \d{1,2} \d{1,2}:\d{1,2}"
, @"\d{1,2} giờ \d{1,2} phút trước"
, @"đăng \d\{1,2} phút trước"};
        public static int TiGiaUsd = 22500;

        public static long ParsePriceLong(string input, bool priceVn)
        {
            input = input.Replace(" ", "");
            if (input.IndexOf('$') >= 0)
            {
                input = input.Split('$')[1];
            }
            var m = Regex.Match(input, @"([\d\.,]+|liên hệ)");
            var r = -1;
            if (m.Success)
            {
                var price = m.Groups[1].Value;
                if (price.Length >= 3)
                {
                    var tem = price.Substring(0, 2);
                    if (tem == "04" || tem == "08")
                    {
                        return 0;
                    }
                }
                var s = price;
                if ((price.IndexOf(",", StringComparison.Ordinal) >= 0) && (price.IndexOf(".", StringComparison.Ordinal) >= 0))
                {
                    if (s.EndsWith(",00")) s = price.Replace(",00", string.Empty);
                    else if (s.EndsWith(".00")) s = price.Replace(".00", string.Empty);
                }
                s = s.Replace(",", String.Empty).Replace(".", String.Empty);
                switch (s)
                {
                    case "liên hệ":
                        r = 0;
                        break;
                    default:
                        int.TryParse(s, out r);
                        break;
                }
                if (r > 1000000000)
                {
                    if (s.IndexOf("1900", StringComparison.Ordinal) >= 0)
                    {
                        return 0;
                    }
                }
            }
            return r;
        }

        /// <summary>
        /// one node
        /// </summary>
        /// <param name="document"></param>
        /// <param name="InputXpath"></param>
        /// 
        /// <param name="isGroup">Cộng gộp nếu có nhiều phần tử</param>
        /// <returns></returns>
        public static string GetTextOfXPath(GABIZ.Base.HtmlAgilityPack.HtmlDocument document, string InputXpath, bool isGroup = false, string split = "")
        {
            string strAtribute = "";
            string sxPath = InputXpath;
            if (Regex.IsMatch(InputXpath, @".*\{.*\}.*"))
            {
                sxPath = Regex.Replace(InputXpath, @"\{.*\}", "");
                strAtribute = Regex.Replace(Regex.Matches(InputXpath, @"\{.*\}")[0].Value, @"\{|\}", "");
            }
            if (strAtribute != "")
            {
                if (strAtribute.StartsWith("@Table"))
                {
                    strAtribute = strAtribute.Replace("@Table", "");
                    var node = document.DocumentNode.SelectSingleNode(sxPath);
                    if (node != null)
                    {
                        string[] strData = node.Attributes[strAtribute].Value.ToString().Split(new char[] { '\n', '\t' }, 200, StringSplitOptions.RemoveEmptyEntries);
                        if (strData.Length > 0)
                        {
                            for (int i = 0; i < strData.Length; i++)
                            {
                                if (strData[i] == strAtribute && (i + 1) < strData.Length)
                                {
                                    return strData[i + 1];
                                }
                            }
                        }
                        return "";
                    }
                    return "";
                }
                else
                {
                    var node = document.DocumentNode.SelectSingleNode(sxPath);
                    if (node != null) return node.Attributes[strAtribute].Value.ToString();
                    else return "";

                }
            }
            else
            {

                var nodes = document.DocumentNode.SelectNodes(sxPath);
                if (nodes != null && nodes.Count > 0)
                {
                    List<string> lst = new List<string>();
                    foreach (var nodeItem in nodes) lst.Add(nodeItem.InnerText);
                    return Common.ConvertToString(lst, " ");
                }
                else return "";
            }
        }

        public static bool CheckRegex(string url, IEnumerable<string> crawlerRegex, IEnumerable<string> noCrawlerRegex, bool bDefault)
        {
            if (noCrawlerRegex != null)
            {
                foreach (var a in noCrawlerRegex)
                {
                    if (!string.IsNullOrEmpty(a))
                    {
                        Match m = Regex.Match(url, a, RegexOptions.IgnoreCase);
                        if (m.Success)
                            return false;
                    }
                }
            }
            if (crawlerRegex != null)
                foreach (var a in crawlerRegex)
                {
                    if (!string.IsNullOrEmpty(a))
                    {
                        Match m = Regex.Match(url, a, RegexOptions.IgnoreCase);
                        if (m.Success) return true;
                    }
                }
            return bDefault;
        }

        public static string ReplaceCassCharacter(string inpute, string changeTo)
        {
            return inpute.Replace("'", changeTo);
        }

        public static string RemoveCommentXML(string desMaker)
        {
            string Result = desMaker;
            int iBegin = 0;
            int iEnd = 0;
            while ((iBegin = Result.IndexOf(@"<!--")) >= 0 && (iEnd = Result.IndexOf(@"-->") + 3) >= 3)
            {
                if (iBegin >= iEnd) return desMaker;
                else
                {
                    Result = Result.Substring(0, iBegin)
                        + Result.Substring(iEnd);
                }
            }
            return Result;
        }

        public static Int64 CellToInt64(Cassandra.Row row, string p1, int p2)
        {
            try
            {
                return Convert.ToInt64(row[p1]);
            }
            catch (Exception ex)
            {
                return p2;
            }
        }

        public static string CellToString(DataRow row, string field, string defaultStr)
        {
            return (row[field] == DBNull.Value) ? defaultStr : row[field].ToString();
        }


        public static object ConvertToString(IEnumerable<int> cityIDs, string split)
        {
            if (cityIDs == null)
                return "";
            return string.Join(split, cityIDs);
        }

        /// <summary>
        /// Xóa mọi kí tự đặc biệt. Để lại a-z, 0-9, , , .
        /// </summary>
        /// <param name="strInput"></param>
        /// <returns></returns>
        public static string RemoveSpecialCharacter(string strInput)
        {
            StringBuilder strBuilderOutput = new StringBuilder(strInput.Length);
            for (int i = 0; i < strInput.Length; i++)
            {
                if (char.IsLetterOrDigit(strInput[i])
                    || strInput[i] == ' ')
                {
                    strBuilderOutput.Append((strBuilderOutput.Length == 0) ? Char.ToUpper(strInput[i]) : strInput[i]);
                }
                else
                {
                    strBuilderOutput.Append(' ');
                }
            }
            return RemoveDumplicateSpace(strBuilderOutput.ToString());
        }



        /// <summary>
        /// Bỏ tất cả các kí tự đặc biệt.
        /// Kí tự đầu viết hoa.
        /// </summary>
        /// <param name="strInput"></param>
        /// <returns></returns>
        public static string ChuanHoaTieuDe(string strInput)
        {
            StringBuilder strBuilderOutput = new StringBuilder(strInput.Length);
            for (int i = 0; i < strInput.Length; i++)
            {
                if (char.IsLetterOrDigit(strInput[i])
                    || strInput[i] == ' '
                    || strInput[i] == '%'
                    || strInput[i] == '.')
                {
                    strBuilderOutput.Append((strBuilderOutput.Length == 0) ? Char.ToUpper(strInput[i]) : strInput[i]);
                }
            }
            return strBuilderOutput.ToString();
        }

        public static List<string> SplitToExtractKeyword(string title)
        {
            return title.Split(new char[] { ',' }, 10000, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        /// <summary>
        /// Bổ nội dung theo các dấu '.', ',', ':', 
        /// </summary>
        /// <param name="titleData"></param>
        /// <returns></returns>
        public static List<string> ExtractBySentence(string titleData)
        {
            try
            {
                string processData = titleData.Trim();
                List<string> lstReuslt = new List<string>();
                int iStartData = 0;
                for (int i = 0; i < titleData.Length; i++)
                {
                    if (titleData[i] == '.' || titleData[i] == ':' || titleData[i] == '-' || titleData[i] == ',')
                    {
                        if (lstReuslt.Count == 0)
                        {
                            iStartData = i;
                        }

                        if (i != 0 && i != titleData.Length - 1 &&
                            (titleData[i - 1] == ' ' || titleData[i + 1] == ' '))
                        {
                            string extract = titleData.Substring(iStartData, i - iStartData).Trim();
                            if (!string.IsNullOrEmpty(extract)) lstReuslt.Add(extract);
                            iStartData = i + 1;
                        }
                    }
                    else if (i == titleData.Length - 1)
                    {
                        lstReuslt.Add(processData.Substring(iStartData, i - iStartData + 1));
                    }
                }
                return lstReuslt;
            }
            catch (Exception ex)
            {
                return new List<string> { titleData };
            }
        }

        /// <summary>
        /// Kiểm tra ngữ nghĩa keyword
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public static bool ValidKeyWordGrammar(string keyword, List<RaoVat.RegexCheckKeyword> lstRegex, bool bDefault)
        {
            foreach (var str in lstRegex)
            {
                if (Regex.IsMatch(keyword, str.Regex))
                {
                    return str.Vaid;
                }
            }
            return bDefault;
        }


        public static List<QT.Entities.RaoVat.RegexCheckKeyword> lstRegexCheckKeyword = null;
        public static bool ValidKeyWordGrammar(string keyword, bool CheckByBlackRegex = true)
        {
            if (lstRegexCheckKeyword != null)
            {
                foreach (var str in lstRegexCheckKeyword)
                {
                    if (CheckByBlackRegex && str.Vaid == false && Regex.IsMatch(keyword, str.Regex))
                    {
                        return false;
                    }
                    else if (!CheckByBlackRegex && str.Vaid == true && Regex.IsMatch(keyword, str.Regex))
                    {
                        return true;
                    }
                }
            }
            return CheckByBlackRegex;
        }


        #region UploadImageSPGoc
        /// <summary>
        /// Upload Image SPGoc using FTP by ImageUrl or ImagePath
        /// </summary>
        /// <param name="NameProduct"></param>
        /// <param name="ImageUrl"></param>
        /// <param name="ImagePath"></param>
        /// <returns></returns>
        public static bool UploadImageSPGoc(long ProductID, string NameProduct, string ImageUrl = null, string ImagePath = null)
        {
            try
            {
                //check = false : Upload by ImageUrl ; check = true : Upload by ImagePath
                bool check = false;
                string filename = UnicodeToKoDauAndGach(NameProduct);
                string tempf = filename.Replace("-", "");
                string folder = tempf.Substring(0, 3);
                if (folder == "bin") folder = "bin1";
                if (folder == "con") folder = "con1";
                if (filename.Length > 100)
                    filename = filename.Substring(0, 99);
                string localFileName = "";
                string newPath = folder + "/" + filename + ".jpg";
                if (string.IsNullOrEmpty(ImageUrl))
                {
                    if (string.IsNullOrEmpty(ImagePath))
                        return false;
                    else
                    {
                        localFileName = ImagePath;
                        check = true;
                    }
                }
                else
                {
                    localFileName = "C:\\ImageTemp\\" + folder + "\\" + filename + ".jpg";
                    int w = 0, h = 0;
                    string fileSave = SaveFile(ImageUrl, "C:\\ImageTemp\\" + folder + "\\", filename + ".jpg", out w, out h, false);
                    if (fileSave == "") return false;
                }

                if (QT.Entities.FTP.CreateDirectory(SPGocImageFTP.HostIP, SPGocImageFTP.UserAccount, SPGocImageFTP.Password, folder))
                {
                    if (QT.Entities.FTP.UploadFile(SPGocImageFTP.HostIP, SPGocImageFTP.UserAccount, SPGocImageFTP.Password, newPath, localFileName))
                    {
                        #region Update ImagePath
                        string path = "Store/images/" + newPath;
                        DBProductTableAdapters.ProductTableAdapter productApdater = new DBProductTableAdapters.ProductTableAdapter();
                        productApdater.Connection.ConnectionString = Server.ConnectionString;
                        try
                        {
                            productApdater.UpdateImagePath(path, ProductID);
                            if (!check) File.Delete(localFileName);

                            //#region Kiểm tra ảnh Thumb trên img.websosanh.net
                            //Nếu đã có ảnh Thum thì xóa ảnh đi.
                            //string pathThumb = folder + "/" + filename + SPGocImageThumbFTP.SizeThumb + ".jpg";
                            //try
                            //{
                            //    if (QT.Entities.FTP.CheckFileExists(SPGocImageThumbFTP.HostIP, SPGocImageThumbFTP.UserAccount, SPGocImageThumbFTP.Password, pathThumb))
                            //        QT.Entities.FTP.DeleteFile(SPGocImageThumbFTP.HostIP, SPGocImageThumbFTP.UserAccount, SPGocImageThumbFTP.Password, pathThumb);
                            //}
                            //catch (Exception) { }
                            //#endregion

                            return true;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                        #endregion
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Upload ảnh sản phẩm của cửa hàng
        /// <summary>
        /// Upload Image Product of Store using FTP by ImageUrl or ImagePath
        /// </summary>
        /// <param name="NameProduct"></param>
        /// <param name="DomainStore"></param>
        /// <param name="ImageUrl"></param>
        /// <param name="ImagePath"></param>
        /// <returns></returns>
        public static string UploadImageProductStore(string NameProduct, string DomainStore, string ImageUrl = null, string ImagePath = null)
        {
            try
            {
                //check = false : Upload by ImageUrl ; check = true : Upload by ImagePath
                bool check = false;
                string filename = UnicodeToKoDauAndGach(NameProduct);
                string folder = DomainStore.Substring(0, 1) + "/" + DomainStore.Replace("www.", "").Replace('.', '_') + "/";
                string tempf = filename.Replace("-", "");
                string sf = tempf.Substring(0, 3);
                if (sf == "bin") sf = "bin1"; if (sf == "con") sf = "con1";
                folder += sf;
                if (filename.Length > 100)
                {
                    filename = filename.Substring(0, 99);
                }
                string localFileName = "";
                string newpath = folder + "/" + filename + ".jpg";
                if (string.IsNullOrEmpty(ImageUrl))
                {
                    if (string.IsNullOrEmpty(ImagePath))
                        return "";
                    else
                    {
                        localFileName = ImagePath;
                        check = true;
                    }
                }
                else
                {
                    localFileName = "C:\\ImageTemp\\" + folder + "\\" + filename + ".jpg";
                    int w = 0, h = 0;
                    string fileSave = SaveFile(ImageUrl, "C:\\ImageTemp\\" + folder + "\\", filename + ".jpg", out w, out h, false);
                    if (fileSave == "") return "";
                }
                if (QT.Entities.FTP.CreateDirectory(ProductStoreImageFTP.HostIP, ProductStoreImageFTP.UserAccount, ProductStoreImageFTP.Password, folder))
                {
                    if (QT.Entities.FTP.UploadFile(ProductStoreImageFTP.HostIP, ProductStoreImageFTP.UserAccount, ProductStoreImageFTP.Password, newpath, localFileName))
                    {
                        try
                        {
                            if (!check) File.Delete(localFileName);
                            string pathThumb = folder + "/" + filename + ProductStoreImageThumbFTP.SizeThumb + ".jpg";
                            #region Check ImageThumb
                            if (QT.Entities.FTP.CheckFileExists(ProductStoreImageThumbFTP.HostIP, ProductStoreImageThumbFTP.UserAccount, ProductStoreImageThumbFTP.Password, pathThumb))
                                QT.Entities.FTP.DeleteFile(ProductStoreImageThumbFTP.HostIP, ProductStoreImageThumbFTP.UserAccount, ProductStoreImageThumbFTP.Password, pathThumb);
                            #endregion
                        }
                        catch (Exception) { }
                        return "Store/" + newpath;
                    }
                    else return "";
                }
                else return "";
            }
            catch (Exception)
            {
                return "";
            }
        }
        #endregion

        #region Upload ảnh cửa hàng
        /// <summary>
        /// Upload image Store using FTP by ImagePath
        /// </summary>
        /// <param name="CompanyId"></param>
        /// <param name="Domain"></param>
        /// <param name="localImagePath"></param>
        /// <param name="imageindex"></param>
        /// <returns></returns>
        public static bool UploadImageStore(long CompanyId, string Domain, string localImagePath, int imageindex)
        {
            try
            {
                string imagefolder = Domain.Replace(".", "").Substring(0, 3);
                if (imagefolder == "con") imagefolder = "con1";
                if (imagefolder == "bin") imagefolder = "bin1";
                string imagename = Domain.Replace(".", "_") + imageindex.ToString();
                if (FTP.CreateDirectory(StoreImageFTP.HostIP, StoreImageFTP.UserAccount, StoreImageFTP.Password, imagefolder))
                {
                    if (FTP.UploadFile(StoreImageFTP.HostIP, StoreImageFTP.UserAccount, StoreImageFTP.Password, imagefolder + "/" + imagename + ".jpg", localImagePath))
                    {
                        string imagepath = "images/merchant/" + imagefolder + "/" + imagename + ".jpg";
                        #region Lưu vào bảng Company_Image
                        try
                        {
                            DBProductTableAdapters.Company_ImageTableAdapter companyImageAdapter = new DBProductTableAdapters.Company_ImageTableAdapter();
                            companyImageAdapter.Connection.ConnectionString = Server.ConnectionString;
                            companyImageAdapter.Insert(CompanyId, imagename, imagepath, imageindex, DateTime.Now);

                            //#region Check ImageThumb
                            //string pathThumb = imagefolder + "/" + imagename + StoreImageThumbFTP.SizeThumb + ".jpg";
                            //if (FTP.CheckFileExists(StoreImageThumbFTP.HostIP, StoreImageThumbFTP.UserAccount, StoreImageThumbFTP.Password, pathThumb))
                            //    FTP.DeleteFile(StoreImageThumbFTP.HostIP, StoreImageThumbFTP.UserAccount, StoreImageThumbFTP.Password, pathThumb);
                            //#endregion

                            return true;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                        #endregion
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
        public static void ReloadRegexKeyWord()
        {
            //Load Regex Check Black Keyword.
            SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
            DataTable tbl = sqlDb.GetTblData("SELECT * FROM RegexFindKeyWord", CommandType.Text,
                new SqlParameter[] { }, null);
            var lstRegex = new List<RegexCheckKeyword>();
            foreach (DataRow row in tbl.Rows)
            {
                Common.lstRegexCheckKeyword.Add(new RegexCheckKeyword()
                {
                    Regex = row["RegexKeyword"].ToString(),
                    Vaid = Convert.ToBoolean(row["IsValid"])
                });
            }
            Common.lstRegexCheckKeyword = lstRegex;
        }

        public static int[] StringToArrayInt(string strInput)
        {
            string[] arData = strInput.Split(new char[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> lstResult = new List<int>();
            int iOut = 0;
            foreach (var item in arData)
            {
                bool bOK = int.TryParse(item, out iOut);
                lstResult.Add(iOut);
            }
            return lstResult.ToArray();
        }
        public static string ChuanHoaTextOfHtml(string p)
        {
            string result = p;
            string regex = @"<!--(.|\s)*?-->";
            while (Regex.IsMatch(result, regex))
            {
                result = Regex.Replace(result, regex, "");
            }
            return result;
        }

        public static long CrcProductID(string linkToCRC)
        {
            return GetIDProduct(linkToCRC);
        }

        public static void ReplaceNodeValue(HtmlNode node, string nodeName, string replateToValue)
        {
            if (node.Attributes.Contains("style")) node.Attributes["style"].Value = "";
            foreach (var nodeChild in node.ChildNodes)
            {
                ReplaceNodeValue(nodeChild, nodeName, replateToValue);
            }
        }


        /// <summary>
        /// Phân tích giá tiền từ nội dung tin đăng.
        /// </summary>
        /// <param name="ContentData"></param>
        /// <returns></returns>
        public static Int64 PhanTichGiaTuNoiDung(string ContentDataInput, Int64 iMaxAllow, Int64 iMinAllow)
        {
            string ContentData = ContentDataInput.ToLower();

            //Giá:3.500.000.vnđ
            bool IsUSD = true;
            //Phân tích loại tiền tệ.
            if (Regex.IsMatch(ContentData, "vnđ|vnd|đồng")) IsUSD = true;
            else if (Regex.IsMatch(ContentData, "usd")) IsUSD = false;

            //Regex01.
            if (Regex.IsMatch(ContentData, @"giá:[\d\s\.\,]*vnđ"))
            {
                string strPrice = Regex.Match(ContentData, @"giá\s*:\s*[\d\s\.\,]*vnđ", RegexOptions.IgnoreCase).Captures[0].Value;
                strPrice = ClearToTextNumber(strPrice);
                long Price = PareNumberFromText(strPrice);
                if (Price > 0) return Price;
            }
            else if (Regex.IsMatch(ContentData, @"[:\s]*[\d\s\.\,]*tr[\d\s\.\,]*\s+"))
            {
                //Giá tiền: 3tr500
                string strPrice = Regex.Match(ContentData, @"[:\s]*[\d\s\.\,]*tr[\d\s\.\,]*\s+", RegexOptions.IgnoreCase).Captures[0].Value;
                string[] arPrice = strPrice.Split(new string[] { "tr" }, StringSplitOptions.RemoveEmptyEntries);
                long a1 = PareNumberFromText(ClearToTextNumber(arPrice[0]));
                long a2 = PareNumberFromText(ClearToTextNumber(arPrice[1]));
                if (a2 > 0)
                {
                    int soKyTu = a2.ToString().Length;
                    int soKhongThem = 6 - soKyTu;
                    a2 = Convert.ToInt64(a2.ToString() + new string('0', soKhongThem));
                }
            }

            return 0;
        }

        private static string ClearToTextNumber(string strPrice)
        {
            strPrice = Regex.Replace(strPrice, @"[^\s\d\.\,]", "").Trim();
            bool bOK = true;
            while (bOK)
            {
                if (Regex.Match(strPrice, ",").Captures.Count > 2 && Regex.Match(strPrice, ".").Captures.Count == 1)
                {
                    strPrice = strPrice.Replace(",", "");
                    strPrice = strPrice.Replace(".", ",");
                }
                else if (Regex.Match(strPrice, ".").Captures.Count > 2 && Regex.Match(strPrice, ",").Captures.Count == 1)
                {
                    strPrice = strPrice.Replace(".", "");
                }
                if (Regex.IsMatch(strPrice, @"[\.\,]$"))
                {
                    strPrice = strPrice.Remove(strPrice.Length - 1, 1);
                    bOK = true;
                }
                else if (Regex.IsMatch(strPrice, @"^[\.\,].*"))
                {
                    strPrice = strPrice.Remove(0, 1);
                    bOK = true;
                }
                bOK = false;
            }
            return strPrice;
        }

        private static long PareNumberFromText(string strPrice)
        {
            string strContent = strPrice;
            if (!strPrice.Contains("."))
            {
                strContent = strContent.Replace(",", "");
            }
            else if (!strPrice.Contains(","))
            {
                strContent = strContent.Replace(".", "");
            }
            Int64 result = 0;
            Int64.TryParse(strContent, out result);
            return result;
        }

        public static string JoinList<T>(List<T> lstItem, string strSpli, EventProcessString<T> eventProcessString)
        {
            List<string> lst = new List<string>();
            foreach (var VARIABLE in lstItem)
            {
                lst.Add(eventProcessString(VARIABLE));
            }
            return string.Join(strSpli, lst);
        }
        /// <summary>
        ///  Run with 64bit - not in 32bit
        /// </summary>
        /// <param name="directoryName"></param>
        /// <returns></returns>
        public static DataTable GetDataTableFromCSVFileUsingODBC(string directoryName)
        {
            DataTable dataTable = null;
            string folder = Path.GetDirectoryName(directoryName);
            string file = Path.GetFileName(directoryName);
            try
            {
                using (var odbcConnection = new OdbcConnection(@"Driver={Microsoft Access Text Driver (*.txt, *.csv)};Dbq=" + folder + ";Extensions=csv,tab,txt;Persist Security Info=False;HDR=true"))
                {
                    dataTable = new DataTable();
                    var odbcAdapter = new OdbcDataAdapter("select  *  from [" + file + "]", odbcConnection);
                    odbcAdapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("Connect by ODBCConnection fails with directory {0}!", directoryName), ex);
            }
            return dataTable;
        }
        /// <summary>
        /// Run with 32bit - not in 64bit
        /// </summary>
        /// <param name="directoryName">Đường dẫn đến file csv</param>
        /// <param name="header">Yes: dòng đầu tiên là header ; No: dòng đầu tiên là dữ liệu</param>
        /// <returns></returns>
        public static DataTable GetDataTableFromCSVFileUsingOLEDB(string directoryName, string header)
        {
            DataTable dataTable = null;
            string pathOnly = string.Empty;
            string fileName = string.Empty;
            string sql = string.Empty;
            try
            {
                pathOnly = Path.GetDirectoryName(directoryName);
                fileName = Path.GetFileName(directoryName);
                sql = @"SELECT * FROM [" + fileName + "]";
                using (OleDbConnection connection = new OleDbConnection(
                    @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathOnly +
                    ";Extended Properties=\"Text;CharacterSet=65001;IMEX=1;TypeGuessRows=2;ImportMixedTypes=Text;HDR=" + header + "\""))
                {
                    //connection.Open();
                    using (OleDbCommand command = new OleDbCommand(sql, connection))
                    {
                        //int rowCount = (int)command.ExecuteScalar();
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            dataTable = new DataTable();
                            dataTable.Locale = CultureInfo.CurrentCulture;
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("Connect by OleDbConnection fails with directory {0}!", directoryName), ex);
            }
            return dataTable;
        }
        public static string GetDomainFromUrl(string p)
        {
            try
            {
                var uri = new Uri(p);
                return uri.Host.Replace("www.", "");
            }
            catch (Exception)
            {
                return "";
            }
            //string regexPattern = @"(\w|\.)*\.(com|net|org|info|coop|int|co|uk|org|vn|xyz)";
            //if (Regex.IsMatch(p, regexPattern, RegexOptions.IgnoreCase))
            //    return Regex.Match(p, regexPattern, RegexOptions.IgnoreCase).Captures[0].Value.ToString();
            //else return "";
        }

        public static string GetDomainFromUrl(Uri p)
        {
            return p.Host.Replace("www.", "");
        }



        public static string GetWebsiteFromUrl(string p)
        {
            try
            {
                string str = HttpUtility.HtmlDecode(p);
                if (str.Contains("http://") || str.Contains("https://"))
                {
                    str = str.Split(' ')[0];
                    if (str.IndexOf('/') > 0) str = str.Substring(0, str.IndexOf('/', 9));
                    return str;
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex01)
            {
                return "";
            }
        }

        public static int GetIntOfDate(DateTime dateTime)
        {
            return dateTime.Year * 10000 + dateTime.Month * 100 + dateTime.Day;
        }

        public static string FixLengStrng(string p)
        {
            StringBuilder _sb = new StringBuilder();
            _sb.Append(p.PadLeft(5)); // serie to cancel
            return _sb.ToString();
        }

        public static string FixLengStrng(string ProductID, int p)
        {
            StringBuilder _sb = new StringBuilder();
            _sb.Append(ProductID.PadLeft(p)); // serie to cancel
            return _sb.ToString();
        }

        public static Uri GetUriFromUrl(string rootUrl)
        {
            try
            {
                return new Uri(rootUrl);
            }
            catch (Exception ex02)
            {
                Log.Error(rootUrl + ":" + ex02);
                return null;
            }
        }

        public static string GetRealPathInWeb(string ImageUrl)
        {
            try
            {
                Uri uri = new Uri(ImageUrl);
                string path = uri.AbsolutePath;
                return Regex.Match(path, "[^/].*$").Captures[0].Value.ToString();
            }
            catch (Exception ex)
            {
                Log.Error(ImageUrl+ex.Message+ex.StackTrace);
                return ImageUrl;
            }
        }

        internal static long DateToInt(DateTime dateTime)
        {
            return dateTime.Ticks;
        }


        public static string FixParalinkImage(string image)
        {
            if (Regex.IsMatch(image, "http.*http.*", RegexOptions.None))
            {
                string regexCode = "jpeg|jpg|png|gif|bmp|ashx";
                int indexOfHttp = image.IndexOf("http", 5);
                int extenction = Regex.Match(image, regexCode).Captures[0].Index;
                string result = image.Substring(indexOfHttp, extenction - indexOfHttp + Regex.Match(image, regexCode).Captures[0].Value.Length);
                return result;
            }
            else
            {
                return image;
            }
        }

        public static string ConvertToString(IEnumerable<long> arService, string p)
        {
            string str = "";
            foreach (var item in arService)
            {
                str = str + p + item;
            }
            return str;
        }

        public static string ByteToString(byte[] p)
        {
            try
            {
                return System.Text.Encoding.UTF8.GetString(p);
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public static byte[] StringToArByte(string input)
        {
            try
            {
                return System.Text.Encoding.UTF8.GetBytes(input);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string GetParaForCassDb(DateTime dateLog)
        {
            return "2012-12-12 10:10:10";
        }


        static Dictionary<string, string> dicRegex = null;

        public static IEnumerable<string> noCrawlerRegexDefault = new string[]
        {
            @"(http(s?):).*(?:jpg|gif|png)$",
            @"(http(s?):).*#response",
            @".*twitter.com.*",
            @".*facebook.com.*",
            @".*add.to.cart\=.*",
            @".*tin.tuc.*",
            @".*lien.he.*",
            @".*gioi-thieu.*",
            @".*don-hang",
            @".*filter.*",
            @".+dispatch.+",
            @".*product_compare.*",
            @".*login.*",
            @".*search.*",
            @".*rao-vat.*",
            @".*sort.*",@".+view=.+",
            @".+=.+=.+=.+",
            @".*javascript.*",
            @".*report.*",
            @".*direct.*",
            @".*google.com.*",
            @".*http.*http.*"};

        public static char[] arSplitToList = new char[] { '\n', ';', '\r' };
        public static string SubPriceString(string preSub)
        {
            if (dicRegex == null)
            {
                dicRegex = new Dictionary<string, string>();
                dicRegex.Add(@"giá bán:\s*[\d\.\,]+\s*đ", @"[\d\.\,]+\s*");
                dicRegex.Add(@"giá\s*:\s*[\d\.\,]+\s*vnđ", @"[\d\.\,]+\s*");
                dicRegex.Add(@" [\d\.\,]+đ", @" [\d\.\,]+đ");
            }

            foreach (var item in dicRegex)
            {
                if (Regex.IsMatch(preSub, item.Key)) return Regex.Match(preSub, item.Value).Captures[0].Value.Trim();
            }
            return preSub;
        }

        public static DateTime Obj2Date(object p, DateTime dateTime)
        {
            try
            {
                return Convert.ToDateTime(p);
            }
            catch (Exception ex)
            {
                return dateTime;
            }
        }

        public static bool IsNoVisitCrawler(string url)
        {
            Match m0 = Regex.Match(url, ".+.jpg$");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+.png$");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+facebook.+");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+twitter.+");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+filter.+");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+dispatch.+");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+product_compare.+");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+login.+");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+print.+");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+search.+");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+rao-vat.+");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+sort.+");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+price.+");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+view=.+");
            if (m0.Success) { return true; }
            m0 = Regex.Match(url, ".+=.+=.+=.+");
            if (m0.Success) { return true; }
            return false;
        }

        public static string CellToString(object p1, string p2)
        {
            if (p1 == DBNull.Value) return p2;
            else return p1.ToString();
        }

        public static string GetPathFromUrl(string url)
        {
            return url;
        }

        public static List<string> GetAllLinkOfDocuemnt(HtmlDocument doc)
        {
            List<string> lstLink = new List<string>();
            var nodesLink = doc.DocumentNode.SelectNodes("//a");
            if (nodesLink != null)
            {
                foreach (var node in nodesLink)
                {
                    lstLink.Add(node.Attributes["href"].Value.ToString());
                }
            }
            return lstLink;
        }

        public static string GetFullUrlFromLink(string urlData, Uri host)
        {
            try
            {
                string strReturn = "";
                string prefixSchema = host.Scheme + "://" + host.Host.Trim();
                if (Regex.IsMatch(urlData, "^[/]*$"))
                {
                    strReturn = prefixSchema;
                }
                else if (Regex.IsMatch(urlData, "[^/].*$"))
                {
                    string relPath = Regex.Match(urlData, "[^/].*").Captures[0].Value.ToString();
                    strReturn = host.Scheme + "://" + host.Host + "/" + relPath;
                }
                else if (!string.IsNullOrEmpty(GetDomainFromUrl(urlData)))
                {
                    strReturn = urlData;
                }
                else
                {
                    strReturn = urlData;
                }
                return strReturn;
            }
            catch (Exception ex01)
            {
                Log.Error(ex01);
                return urlData;
            }
        }

        public static bool IsImageLink(string newLinkFull)
        {
            return newLinkFull.Contains("png") || newLinkFull.Contains("jpg") || newLinkFull.Contains("gif") || newLinkFull.Contains("svg");
            //return Regex.IsMatch(newLinkFull, @"http.*(png|jpg|gif|svg|jpeg)", RegexOptions.IgnoreCase);
        }

        internal static string ArParaToString(SqlParameter[] arPara)
        {
            List<string> lst = new List<string>();
            foreach (var par in arPara) lst.Add(par.ParameterName.ToString() + " " + par.Value.ToString());
            return string.Join("\r\n", lst);
        }

        public static string GetStrCassForList(List<string> list)
        {
            if (list == null || list.Count == 0) return "[]";
            else
            {
                List<string> lstConvert = Common.GetLstParaCas(list);
                return "['" + string.Join("','", lstConvert) + "']";
            }
        }

        public static string GetStrCassForSet(IEnumerable<string> list)
        {
            if (list == null) return "{}";
            else
            {
                var lst = list.ToList();
                if (lst.Count == 0) return "{}";
                else
                {
                    List<string> lstConvert = Common.GetLstParaCas(lst);
                    return "{'" + string.Join("','", lst) + "'}";
                }
            }
        }

        public static Int64 CellToInt64(DataRow rowProduct, string field, Int64 def)
        {
            return (rowProduct[field] == DBNull.Value) ? def : Convert.ToInt64(rowProduct[field]);
        }
    }

    public static class NewWebInGoogle
    {
        
        public static Dictionary<string, string> GetWebsiteFromGoogle(string keyword, int pages, int timeSleep)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(NewWebInGoogle));
            FirefoxDriver fireFoxDriver = null;
            string websiteUrl = "";
            string domain = "";

            Regex regex = new Regex(ConfigurationManager.AppSettings["regexWebsite"]);
            Dictionary<string, string> dicWebNew = new Dictionary<string, string>();
            try
            {
                for (int i = 0; i <= pages; i++)
                {
                    Thread.Sleep(timeSleep);
                    if (fireFoxDriver == null) fireFoxDriver = new FirefoxDriver();
                    string urlSearch = "https://www.google.com.vn/#q=" + System.Web.HttpUtility.UrlEncode(keyword) + "&start=" + (i * 10).ToString();
                    fireFoxDriver.Navigate().GoToUrl(urlSearch);
                    var elements = fireFoxDriver.FindElementsByXPath("//h3[@class='r']/a");
                    foreach (var element in elements)
                    {
                        websiteUrl = element.GetAttribute("href");
                        domain = QT.Entities.Common.GetDomainFromUrl(websiteUrl);
                        if (!string.IsNullOrEmpty(domain) && !dicWebNew.ContainsKey(domain) && regex.IsMatch(domain))
                        {
                            dicWebNew.Add(domain, websiteUrl);
                        }
                    }
                }
                fireFoxDriver.Close();
                fireFoxDriver = null;
            }
            catch (Exception ex01)
            {
                log.Error(ex01);
            }
            return dicWebNew;
        }
    }

    public static class FileLog
    {
        public static void WriteText(string txt, string fileName)
        {
            try
            {
                if (!Directory.Exists("C:\\QTLog"))
                {
                    DirectoryInfo di = Directory.CreateDirectory("C:\\QTLog");
                    di = null;
                }

                string defaultPath = "C:\\QTLog\\" + fileName;
                if (!File.Exists(defaultPath))
                {
                    using (File.CreateText(defaultPath))
                    {

                    }
                }
                File.WriteAllText(defaultPath, txt);
            }
            catch (Exception)
            {
            }
        }
        //public static void WriteLog(string logMessage, string SiteName)
        //{
        //    try
        //    {
        //        if (!Directory.Exists("C:\\QTLog"))
        //        {
        //            DirectoryInfo di = Directory.CreateDirectory("C:\\QTLog");
        //            di = null;
        //        }
        //        string defaultPath = "C:\\QTLog\\"+SiteName;
        //        if (!File.Exists(defaultPath))
        //        {
        //            using (File.CreateText(defaultPath))
        //            {

        //            }
        //        }
        //        using (StreamWriter w = File.AppendText(defaultPath))
        //        {
        //            Log(SiteName + ": " + logMessage, w);
        //            w.Close();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}
        //private static void Log(string  logMessage, TextWriter  w)
        //{
        //    w.WriteLine("{0} {1}", DateTime.Now.ToShortDateString(),
        //        DateTime.Now.ToShortTimeString());

        //    w.WriteLine("{0}", logMessage);
        //    w.WriteLine();
        //    w.WriteLine("-----------------");
        //    w.Flush();
        //}
        public static void WriteAppendText(string txt, string fileName)
        {
            try
            {
                if (!Directory.Exists("C:\\QTLog"))
                {
                    DirectoryInfo di = Directory.CreateDirectory("C:\\QTLog");
                    di = null;
                }

                string defaultPath = "C:\\QTLog\\" + fileName;
                if (!File.Exists(defaultPath))
                {
                    using (File.CreateText(defaultPath))
                    {

                    }
                }
                using (StreamWriter w = File.AppendText(defaultPath))
                {
                    w.WriteLine(txt);
                    w.Flush();
                    w.Close();
                }
            }
            catch (Exception)
            {
            }
        }
        public static String ReadText(string fileName)
        {
            string r = "";
            try
            {
                if (!Directory.Exists("C:\\QTLog"))
                {
                    DirectoryInfo di = Directory.CreateDirectory("C:\\QTLog");
                    di = null;
                }

                string defaultPath = "C:\\QTLog\\" + fileName;
                if (!File.Exists(defaultPath))
                {
                    using (File.CreateText(defaultPath))
                    {

                    }
                }

                using (StreamReader w = File.OpenText(defaultPath))
                {
                    r = w.ReadToEnd();
                    w.Close();
                }
            }
            catch (Exception)
            {
            }
            return r;
        }
        public static List<String> ReadAllLineText(string fileName)
        {
            List<string> r = new List<string>();
            try
            {
                if (!Directory.Exists("C:\\QTLog"))
                {
                    DirectoryInfo di = Directory.CreateDirectory("C:\\QTLog");
                    di = null;
                }

                string defaultPath = "C:\\QTLOG\\" + fileName;
                if (!File.Exists(defaultPath))
                {
                    using (File.CreateText(defaultPath))
                    {

                    }
                }

                using (StreamReader w = File.OpenText(defaultPath))
                {
                    while (!w.EndOfStream)
                    {
                        r.Add(w.ReadLine());
                    }
                    w.Close();
                }
            }
            catch (Exception)
            {
            }
            return r;
        }
    }

    public static class Wait
    {
        private static DevExpress.Utils.WaitDialogForm frm;

        static Wait()
        {
            frm = new DevExpress.Utils.WaitDialogForm();
            frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        }

        public static void Show(String msg)
        {
            try
            {
                frm.Show();
                frm.Caption = msg;
            }
            catch (Exception)
            {
                frm = new DevExpress.Utils.WaitDialogForm();
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            }

        }

        public static void CreateWaitDialog()
        {
            try
            {
                if (frm == null)
                {
                    frm = new DevExpress.Utils.WaitDialogForm();
                    frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                }
                frm.Show();
            }
            catch (Exception)
            {
                frm = new DevExpress.Utils.WaitDialogForm();
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            }
        }

        public static void Close()
        {
            try
            {
                frm.Close();
            }
            catch (Exception)
            {
                frm = new DevExpress.Utils.WaitDialogForm();
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            }
        }

        private static byte[] DownloadRemoteImageFile(string uri, string fileName)
        {
            byte[] buffer = new byte[2048];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Check that the remote file was found. The ContentType
            // check is performed since a request for a non-existent
            // image file might be redirected to a 404-page, which would
            // yield the StatusCode "OK", even though the image was not
            // found.
            if ((response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Moved ||
                response.StatusCode == HttpStatusCode.Redirect) &&
                response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase))
            {

                // if the remote file was found, download oit
                using (Stream inputStream = response.GetResponseStream())
                using (Stream outputStream = File.OpenWrite(fileName))
                {
                    int bytesRead;
                    do
                    {
                        bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                        outputStream.Write(buffer, 0, bytesRead);
                    } while (bytesRead != 0);
                }
            }
            return buffer;
        }
    }
    public enum TypeJobWithRabbitMQ
    {
        Product = 2,
        Company = 1,
        ReloadAll = 9999
    }
}
