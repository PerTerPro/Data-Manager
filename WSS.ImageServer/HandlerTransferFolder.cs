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
        private ProducerBasic pb = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo),
            ConfigImbo.ExchangeImage, ConfigImbo.RoutingKeyUploadImb);
        
        private int _iCount = 0;
        private int _iCountSuccess = 0;
        private DateTime _dtStart = DateTime.Now;

        private bool _isDelData = false;
        private  ImageAdapterSql _imageAdapter = new ImageAdapterSql();
        private ILog _log = LogManager.GetLogger(typeof (HandlerTransferFolder));

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
            if (productId > 0)
            {
                if (_imageAdapter.CheckExitProduct(productId))
                {
                    imgId = ImboImageService.PushFromFile(ConfigImbo.PublicKey, ConfigImbo.PrivateKey, file, ConfigImbo.User, ConfigImbo.Host);
                    if (!string.IsNullOrEmpty(imgId))
                    {
                       
                        this.pb.PublishString(new JobUploadedImg()
                        {
                            ImageId = imgId,
                            ProductId = productId,
                            TimeUpload = DateTime.Now
                        }.ToJson());
                        _iCountSuccess++;
                    }
                }
            }
            _iCount++;
            _log.Info(string.Format("{0}/{1} {2}=>{3}", _iCountSuccess, _iCount, productId, imgId));
            if (_iCountSuccess%100 == 0) _log.Info(string.Format("Speech: {0}/s", (_iCountSuccess/(DateTime.Now - _dtStart).TotalSeconds)));
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
