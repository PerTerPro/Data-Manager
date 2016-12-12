using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.ImageServer
{
    public class HandlerTransferLogoCompany
    {
        private string _dicrectory;
        private SqlDb _sqlDb = new SqlDb(ConfigImbo.ConnectionProduct);
        private ILog _log = log4net.LogManager.GetLogger(typeof (HandlerTransferLogoCompany));

        public HandlerTransferLogoCompany()
        {
        }

        public void Start()
        {
            ProducerBasic producerDelImgImbo = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo),
                ConfigImbo.QueueDelImgImbo);

            _sqlDb.ProcessDataTableLarge(
                @"
select replace(Domain, '.', '_') as Domain, id, LogoImageId
from company 
where TotalProduct>0
order by id
", 10000, (row,iRow) =>
                {
                    string imgIdOld = Common.Obj2String(row["LogoImageId"]);
                    long id = Common.Obj2Int64(row["Id"]);
                    string domain = Common.Obj2String(row["Domain"]);

                    string fullLinkLog = string.Format(@"http://img.websosanh.vn/merchant/{0}.png", domain);
                   

                    try
                    {
                        string imgIdNew = ImboImageService.PushFromUrl(ConfigImbo.PublicKey, ConfigImbo.PrivateKey, fullLinkLog, "logo", ConfigImbo.Host, ConfigImbo.Port);
                        if (!string.IsNullOrEmpty(imgIdNew))
                        {
                            if (!string.IsNullOrEmpty(imgIdOld))
                            {
                                producerDelImgImbo.PublishString(imgIdOld);
                            }

                            bool bOK = this._sqlDb.RunQuery("Update Company Set LogoImageId = @LogoImageId Where Id = @Id", CommandType.Text, new SqlParameter[]
                            {
                                SqlDb.CreateParamteterSQL("Id", id, SqlDbType.BigInt),
                                SqlDb.CreateParamteterSQL("LogoImageId", imgIdNew, SqlDbType.NVarChar)
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        _log.Error(ex);
                    }

                    _log.Info(string.Format("Uploaded {0} {1}", iRow, id));

                });
        }
    }
}
