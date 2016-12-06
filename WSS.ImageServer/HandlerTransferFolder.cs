using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using GABIZ.Base.NGenerics.Algorithms.Graph;
using ImboForm;
using log4net;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.ImageServer
{
    public class HandlerTransferFolder
    {
        private readonly ProducerBasic _pb = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo),
            ConfigImbo.ExchangeImage, ConfigImbo.RoutingKeyUploadImb);
        private readonly ProducerBasic _producerWaitDelFile = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo),
            ConfigImbo.QueueWaitDelFile);
        private readonly ProducerBasic _producerErrorPushImbo = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo),
            ConfigImbo.QueueErrorUpImbo);
        private readonly ProducerBasic _producerNoProduct = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo),
         ConfigImbo.QueueNoProduct); 
     
        private int _iCount = 0;
        private int _iCountSuccess = 0;
        private DateTime _dtStart = DateTime.Now;
        private long _iPushed = 0;

        private bool _isDelData = false;
        private  ImageAdapterSql _imageAdapter = new ImageAdapterSql();
        private ILog _log = LogManager.GetLogger(typeof (HandlerTransferFolder));

        private readonly HashSet<long> _hsProductIds;
        private readonly HashSet<long> _hsPushed;
     

        public HandlerTransferFolder()
        {
            _hsProductIds = _imageAdapter.GetProductIds();
            _hsPushed = RedisImage.GetIns().GetAllPushed();
        }

        public void TransferData(string directory)
        {
            string[] files = Directory.GetFiles(directory);
            foreach (var file in files)
            {
                TransferImage(file);
            }
            string[] arStrings = Directory.GetDirectories(directory);
            foreach (var variable in arStrings)
            {
                TransferData(variable);
            }
        }

        public void TransferImage(string file)
        {
            while (true)
            {
                try
                {
                    string imgId = "";
                    long productId = GetProductId(file);
                    if (!_hsPushed.Contains(productId))
                    {
                        bool bExistproduct = false;
                        if (productId > 0)
                        {
                            bExistproduct = this._hsProductIds.Contains(productId);
                            if (bExistproduct)
                            {
                                imgId = ImboImageService.PushFromFile(ConfigImbo.PublicKey, ConfigImbo.PrivateKey, file, "landingpage", ConfigImbo.Host, ConfigImbo.Port);
                                if (!string.IsNullOrEmpty(imgId))
                                {
                                    this._pb.PublishString(new JobUploadedImg()
                                    {
                                        ImageId = imgId,
                                        ProductId = productId,
                                        TimeUpload = DateTime.Now,
                                        NameImage = GetNameFile(file)
                                    }.ToJson());
                                    _iCountSuccess++;
                                }
                                else
                                {
                                    this._producerErrorPushImbo.PublishString(new JobFailPushImage()
                                    {
                                        File = file,
                                        ProductId = productId
                                    }.ToJson());
                                }
                            }
                            else
                            {
                                this._producerNoProduct.PublishString(file);
                            }

                            RedisImage.GetIns().Add(productId);
                        }
                        _iCount++;
                        _log.Info(string.Format("{0}/{1} {2}=>{3} {4} ExistsProduct: {5}", _iCountSuccess, _iCount, productId, imgId, file, bExistproduct));

                        if (imgId != "" || bExistproduct == false)
                        {
                            this._producerWaitDelFile.PublishString(file);
                        }
                        if (_iCountSuccess % 1000 == 0) _log.Info(string.Format("Speech: {0}/s", (_iCountSuccess / (DateTime.Now - _dtStart).TotalSeconds)));
                    
                    }
                    else
                    {
                        this._producerWaitDelFile.PublishString(file);
                        _iPushed++;
                        if (_iPushed % 1000 == 0) _log.Info(string.Format("Pushed: {0} {1}", _iPushed, productId, file));
                    }

                   
                    return;
                }
                catch (Exception ex)
                {
                    _log.Error(ex);
                }
            }
        }

        private string GetNameFile(string file)
        {
            if (file.Contains("/")) return Regex.Match(file, @"\\[^\\]*$").Captures[0].Value;
            else return file;
        }

        private long GetProductId(string file)
        {
            if (Regex.IsMatch(file, @"_\d*\."))
            {
                string productId = Regex.Match(file, @"_\d*\.").Captures[0].Value.Replace("_", "").Replace(".", "");
                return Convert.ToInt64(productId);
            }
            return 0;
        }

        public static void RePushThumb()
        {
            SqlDb sqlDb = new SqlDb(ConfigImbo.ConnectionProduct);
            ProducerBasic producerBasic = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo),
                "Img.Product.Thumb");

            sqlDb.ProcessDataTableLarge(
                @"select ImageId, Id
from product
where valid = 1
order by Id", 10000, (rowData,iRow) =>
                {
                    string imgId = Common.Obj2String(rowData["ImageId"]);
                    long Id = Common.Obj2Int64(rowData["Id"]);
                    if (!string.IsNullOrEmpty(imgId))
                    {
                        producerBasic.PublishString(new JobUploadedImg()
                        {
                            ImageId = imgId,
                            ProductId = Id
                        }.ToJson());
                    }
                });
        }

        public static void PushImgCompany(string rootDirectory)
        {
           HandlerTransferLogoCompany h = new HandlerTransferLogoCompany();
           h.Start();
        }
    }
}
