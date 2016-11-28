using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Images
{
    public class ConfigImages
    {
        public static string UrlImage = "http://img.websosanh.vn/";
        public static string UrlThumbImage = "http://img.websosanh.net/";
        public static string RabbitMqServerName = "rabbitMQ177";
        public static string ExchangeImages = "UpdateImageBatch";

        public static string RoutingKeyChangeImageProduct = "UpdateProduct.ChangeImageProductVer2.#";
        public static string QueueChangeImageProduct = "UpdateProduct.ChangeImage.ProductVer2";

        public static string RoutingKeyChangeImageRootProduct = "UpdateProduct.ChangeImageRootProductVer2.#";
        public static string QueueChangeImageRootProduct = "UpdateProduct.ChangeImage.RootProductVer2";

        public static string RoutingKeyChangeImageCompany = "UpdateProduct.ChangeImageCompanyVer2";
        public static string QueueChangeImageCompany = "UpdateProduct.ChangeImage.CompanyVer2";


        public static string RoutingKeyDeleteThumbImage = "UpdateProduct.DeleteImageThumbVer2";
        public static string QueueDeleteThumbImage = "UpdateProduct.ChangeImage.DeleteThumbVer2";

        public static string RoutingKeyUpdateImagePath = "UpdateProduct.UpdateImagePathVer2";
        public static string QueueUpdateImagePath = "UpdateProduct.ChangeImage.UpdateImagePathVer2";

        public static string RoutingKeyHistoryDownloadImage = "UpdateProduct.HistoryImageVer2";
        public static string QueueHistoryDownloadImage = "UpdateProduct.ChangeImage.InsertHistoryVer2";

        public static string RoutingKeyCheckErrorDownload = "UpdateProduct.ChangeImageCheckErrorDownloadVer2";
        public static string QueueCheckErrorDownload = "UpdateProduct.ChangeImage.CheckErrorDownloadVer2";
        // a quang
        public static string RoutingKeyThumbImage = "UpdateProduct.ChangeImageThumbVer2";
        public static string QueueThumbImage = "UpdateProduct.ChangeImage.ThumbImageVer2";

        //Redis error image Database(0)
        public static string KeyRedisCheckErrorDownloadImageProduct = "redisFPT201";

        //Imbo Image
        public static string ImboExchangeImages = "ImboImageBatch";
        public static string ImboRoutingKeyDownloadImageProduct = "ImboImage.DownloadImageProduct.#";
        public static string ImboQueueDownloadImageProduct = "ImboImage.DownloadImageProduct";

        public static string ImboRoutingKeyDownloadImageRootProduct = "ImboImage.DownloadImageRootProduct.#";
        public static string ImboQueueDownloadImageRootProduct = "ImboImage.DownloadImageRootProduct";

        public static string ImboRoutingKeyCheckErrorDownload = "ImboImage.CheckErrorProduct.#";
        public static string ImboQueueCheckErrorDownload = "ImboImage.CheckErrorProduct";

        public static string ImboRoutingKeyHistoryDownloadImage = "ImboImage.HistoryDownload.#";
        public static string ImboQueueHistoryDownloadImage = "ImboImage.HistoryDownload";

        public static string ImboRoutingKeyUploadImageIdSql = "ImboImage.UpdateImageIdSql.#";
        public static string ImboQueueUploadImageIdSql = "ImboImage.UpdateImageIdSql";

        public static string ImboRoutingKeyThumbImage = "ImboImage.ThumbImage.#";
        public static string ImboQueueThumbImage = "ImboImage.ThumbImage";

        public static string ImboRoutingKeyDownloadImageCompany = "ImboImage.DownloadImageCompany.#";
        public static string ImboQueueDownloadImageCompany = "ImboImage.DownloadImageCompany";
    }
}
