using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using QT.Entities.Data;

namespace WSS.ImageServer
{
    public  class HanlderTransferImgNew1
    {
        private SqlDb sqlDb = new SqlDb(ConfigImbo.ConnectionNew);
        private  bool bUpdateSql = false;
        private ILog log = log4net.LogManager.GetLogger(typeof (HanlderTransferImgNew1));
        private string folderImg;

        public void TransferData()
        {
            Console.WriteLine("Input foler ImgSource:");
            this.folderImg = ConfigurationSettings.AppSettings.Get("FoldeImage");
           
        
            this.sqlDb.ProcessDataTableLarge(
                @"   SELECT [AdvID],[FilePath], REPLACE([FilePath], 'http://img.websosanh.vn/Store/', '') as FullFile
  FROM [ReviewsCMS].[dbo].[AdvProductHotdeal_BackUp]
  ORDER BY AdvID
", 10000, (row, iRow) =>
                {
                    long advID = Common.Obj2Int64(row["AdvID"]);
                    string filePath = Common.Obj2String(row["FullFile"]);
                    this.TransferData(advID, filePath);
                });
        }

        private void TransferData(long advID, string filePath)
        {
            string fullFile = this.folderImg + "/" + filePath;
            string imageId = ImboImageService.PushFromFile(ConfigImbo.PublicKey, ConfigImbo.PrivateKey, fullFile, "landingpage", ConfigImbo.Host, ConfigImbo.Port);
            if (!string.IsNullOrEmpty(imageId))
            {
                if (this.bUpdateSql)
                {
                    this.sqlDb.RunQuery("Update [AdvProductHotdeal_BackUp] Set [FilePath] = @FilePath where AdvID = @AdvID", CommandType.Text, new SqlParameter[]
                    {
                        SqlDb.CreateParamteterSQL("AdvID", advID, SqlDbType.BigInt),
                        SqlDb.CreateParamteterSQL("FilePath", imageId, SqlDbType.NVarChar)
                    });
                }
                log.Info(string.Format("Pushed for {0} {1} => {2}", advID, filePath, imageId));
            }
            else
            {
                log.Info(string.Format("Error push at img: {0} {1}", advID, fullFile));
            }
        }
    }
}
