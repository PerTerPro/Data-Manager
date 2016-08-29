using log4net;
using ProtoBuf;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core;
using Websosanh.NotificationSystem.Common.DAL;

namespace Websosanh.NotificationSystem.Common
{
    public class NotificationProducer : Producer
    {
        
        private static readonly ILog Logger = LogManager.GetLogger(typeof(NotificationProducer));
        public NotificationProducer(string serverNameEndPoint, string channelName,string rootingKey, bool messagePersistent)
            : base(RabbitMQManager.GetRabbitMQServer(serverNameEndPoint), channelName, rootingKey, "")
        {
            this._queueName = _routingKey;
            ChannelDAL channelDAL = new ChannelDAL();
            if (!channelDAL.CheckChannelNameExist(channelName))
                throw new Exception("Channel Name does not exist");

            AddConnectionShutdownHandler(this.ConnectionShutdown);
            SetMessagePersitent(messagePersistent);
            try
            {
                var channel = GetChannel();
                //channel.ExchangeDeclare(_exchangeName, ExchangeType.Direct);
                CloseChannel(channel);
            }
            catch (Exception exception)
            {
                Logger.Error("Init producer error", exception);
                AsyncWaitAndReInitialize();
            }
        }
        public override bool Init()
        {
            return true;
        }

        /// <summary>
        /// Send a notification to channel
        /// </summary>
        /// <param name="message">message</param>
        /// <param name="timeToLive">Time to live of message (minute). Default (0 minute) is never expire</param>
        public void PublishMessage(string message, int timeToLive = 0)
        {
            try
            {
                
                var channel = GetChannel();
                channel.BasicReturn += MessageReturn;
                var properties = channel.CreateBasicProperties();
                properties.DeliveryMode = 2;
                if (timeToLive > 0)
                    properties.Expiration = (timeToLive * 60000).ToString();
               
                byte failedTime = 0;
                bool published = false;
                while (failedTime < 3)
                {
                    try
                    {
                        Publish(channel, true, properties, Websosanh.Core.Common.BAL.ProtobufTool.Serialize(message));
                        Logger.InfoFormat("Published message {0}", message);
                        published = true;
                        break;
                    }
                    catch (Exception exception)
                    {
                        #region process exception
                        Logger.Error("Publish error", exception);
                        if (exception is AlreadyClosedException || exception is IOException)
                        {
                            failedTime++;
                            Logger.Info("Wait 3 second and create new channel");
                            Thread.Sleep(3000);
                            channel = GetChannel();
                        }
                        else if (exception is PublishNAckException || exception is PublishTimeoutException)
                            failedTime++;
                        else
                        {
                            Logger.Fatal("Abort - Then Insert mistake message into Sql Server");
                            break;
                        }
                        #endregion
                    }
                }//end while
                if (!published)
                {
                    try
                    {
                        (new MessageDAL()).InsertMessage(message, _queueName,"");//Insert misstake to backup
                    }
                    catch (Exception ex)
                    {
                        Logger.Error("Error when Insert misstake message to backup: " + ex);
                    }
                }
                //  CloseChannel(channel);
            }
            catch (Exception ex01)
            {
                (new MessageDAL()).InsertMessage(message, _queueName, "");
            }
        }
        protected override void MessageReturn(object sender, BasicReturnEventArgs args)
        {
            var message = Websosanh.Core.Common.BAL.ProtobufTool.DeSerialize<string>(args.Body);
            Logger.WarnFormat("Message returned, message {0}", message);
        }

        public void ConnectionShutdown(object sender, ShutdownEventArgs shutdownEventArgs)
        {
            Logger.WarnFormat("Connection shutdowned, Cause:{0}, Message: {1}", shutdownEventArgs.Cause, shutdownEventArgs.ReplyText);
            if (shutdownEventArgs.Initiator != ShutdownInitiator.Application)
            {
                Logger.InfoFormat("Recovery in 3s");
                AsyncWaitAndReInitialize();
            }
        }
    }
}
