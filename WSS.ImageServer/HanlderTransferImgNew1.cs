using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using QT.Entities.Data;

namespace WSS.ImageServer
{
    public class HanlderTransferImgNew1
    {
        private readonly SqlDb _sqlDb = new SqlDb(ConfigImbo.ConnectionNew);
        private readonly ILog _log = log4net.LogManager.GetLogger(typeof (HanlderTransferImgNew1));
        private string _folderImg;
        private  RedisTransfer _redisTransfer = new RedisTransfer();

        public HanlderTransferImgNew1()
        {
            this._folderImg = ConfigurationSettings.AppSettings.Get("FoldeImage");
        }

        public void TransferData()
        {
            while (true)
            {
                this._sqlDb.ProcessDataTableLarge(
                    @"   
        SELECT [AdvID]
      ,   REPLACE([FilePath], 'http://img.websosanh.vn/Store', '') as FullFile
  FROM [ReviewsCMS].[dbo].[AdvProductHotdeal]
  where [FilePath] like N'http://img.websosanh.vn/%' AND [FilePath] != 'http://img.websosanh.vn/null' AND [FilePath] != 'http://img.websosanh.vn/'
  and LEN(FilePath) > 20
ORDER BY AdvID

", 10000, (row, iRow) =>
                    {
                        var advId = Common.Obj2Int64(row["AdvID"]);
                        var filePath = Common.Obj2String(row["FullFile"]);
                        if (!this._redisTransfer.CheckExit(advId))
                        {
                            this.TransferData(advId, filePath);
                            this._redisTransfer.SetTrans(advId);
                        }
                        else
                        {
                            _log.Info(string.Format("Transfered for {0}", advId));
                        }
                    });
                Thread.Sleep(30000);
            }

        }

        private void TransferData(long advId, string filePath)
        {
            var fullFile = _folderImg + @"/" + filePath;
            var imageId = ImboImageService.PushFromFile(ConfigImbo.PublicKey, ConfigImbo.PrivateKey, fullFile, "landingpage", ConfigImbo.Host, ConfigImbo.Port);
            if (!string.IsNullOrEmpty(imageId))
            {
                this._sqlDb.RunQuery(string.Format("Update [AdvProductHotdeal] Set [FilePath] = '{0}' where AdvID = {1}",
                    imageId, advId), CommandType.Text, null);
                _log.Info(string.Format("Pushed for {0} {1} => {2}", advId, filePath, imageId));
            }
            else
            {
                _log.Info(string.Format("Error push at img: {0} {1}", advId, fullFile));
            }
        }
    }
}
