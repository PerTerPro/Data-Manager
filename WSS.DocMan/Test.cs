using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.DocMan
{
    public class Test
    {
        private ILog log = log4net.LogManager.GetLogger(typeof (Test));

        public void PushQueueAs()
        {
            ProducerBasic producerBasic =
                new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigDocMan.KeyRabbitMqWaitDl),
                    ConfigDocMan.QueueDl);

            for (int i = 1; i < 100000; i++)
            {
                producerBasic.PublishString(Newtonsoft.Json.JsonConvert.SerializeObject(new JobQueue()
                {
                    Deep = 0,
                    Url =
                        string.Format("http://moj.gov.vn/vbpq/Lists/Vn%20bn%20php%20lut/View_Detail.aspx?ItemID={0}", i)
                }));
                if (i%10 == 0) log.Info(i);
            }
        }

        internal void PushQueueAsDocInfo()
        {
             ProducerBasic producerBasic =
                new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigDocMan.KeyRabbitMqWaitDl),
                    ConfigDocMan.QueueDocInfo);
            DocManAdapter docManAdapter = new DocManAdapter();
            DataTable tbl = docManAdapter.GetUrls();
            foreach (DataRow row in tbl.Rows)
            {
                producerBasic.PublishString(Newtonsoft.Json.JsonConvert.SerializeObject(new JobResetDocInfo()
                {
                    Url = Convert.ToString(row["Url"]),
                    Id = Convert.ToInt64(row["Id"])
                }));
            }

        }
    }
}
