using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.QAComment.Core;

namespace WSS.QAComment.ReviewToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumerReviewToSql c = new ConsumerReviewToSql(RabbitMQManager.GetRabbitMQServer(Config.RabbitMQServerComment), Config.QueueCommentToSql);
            c.StartConsume();
        }}
}
