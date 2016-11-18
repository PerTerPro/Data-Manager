using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using GABIZ.Base.NGenerics.Algorithms.Graph;
using log4net;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;

namespace ImboForm
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

        public HandlerTransferFolder()
        {
            
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

        private void TransferImage(string file)
        {
            string imgId = "";
            long productId = GetProductId(file);
            if (!RedisImage.GetIns().Contain(productId))
            {
                bool bExistproduct = false;
                if (productId > 0)
                {
                    bExistproduct = _imageAdapter.CheckExitProduct(productId);
                    if (bExistproduct)
                    {
                        imgId = ImboImageService.PushFromFile(ConfigImbo.PublicKey, ConfigImbo.PrivateKey, file, ConfigImbo.User, ConfigImbo.Host);
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
                }
                _iCount++;
                _log.Info(string.Format("{0}/{1} {2}=>{3} {4} ExistsProduct: {5}", _iCountSuccess, _iCount, productId, imgId, file, bExistproduct));

                if (imgId != "" || bExistproduct == false)
                {
                    this._producerWaitDelFile.PublishString(file);
                }
                if (_iCountSuccess%1000 == 0) _log.Info(string.Format("Speech: {0}/s", (_iCountSuccess/(DateTime.Now - _dtStart).TotalSeconds)));
            }
            else
            {
                _iPushed++;
                if (_iPushed%1000 == 0) _log.Info(string.Format("Pushed: {0}", _iPushed));
            }
            RedisImage.GetIns().Add(productId);
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
    }
}
