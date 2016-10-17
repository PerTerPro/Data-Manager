using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.QAComment.Core
{
    public  class Config
    {
        public static string RabbitMQServerComment = "CommentMQ";
        public static string QueueDownloadHtml = "Comment.WaitDownloadHtml";
        public static string QueueWaitDownloadHtml = "Comment.WaitDownloadHtml";
        public static string QueueWaitAsComment = "Comment.Html.WaitToAS";
        public static string ExchangeHtml = "Comment";
        public static string RoutingKeyHtml = "Comment.Html.#";
        public static string ConnectionSQL =@"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
        public static string QueueCommentToSql="Comment.Review.ToSql";
    }
}
