using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Core.Crawler
{
    public class InitQueue
    {
        public void Start()
        {

            while (true)
            {
                try
                {
                    RabbitMQServer rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler);
                    RabbitMQ.Client.IModel channel = null;

                    while (channel == null)
                    {
                        channel = rabbitMqServer.CreateChannel();
                    }

                    channel.ExchangeDeclare("CrawlerProduct", "topic", true);

                    channel.QueueDeclare(ConfigCrawler.QueueErrorCrawler, true, false, false, null);
                    channel.QueueBind(ConfigCrawler.QueueErrorCrawler, ConfigCrawler.ExchangeErorrCrawler, ConfigCrawler.RoutingKeyErrorCrawler);

                    channel.QueueDeclare(ConfigCrawler.QueueHistoryToSolr, true, false, false, null);
                    channel.QueueBind(ConfigCrawler.QueueHistoryToSolr, ConfigCrawler.ExchangeChangeProduct, ConfigCrawler.RoutingkeyChangeProduct);

                    channel.QueueDeclare(ConfigCrawler.QueueVisitedLinkFindNewToSolr, true, false, false, null);
                    channel.QueueBind(ConfigCrawler.QueueVisitedLinkFindNewToSolr, ConfigCrawler.ExchangeVisitedLinkFindNew, ConfigCrawler.RoutingKeyVisitedLinkFindNew);

                    channel.ExchangeDeclare(ConfigCrawler.ExchangeSessionRunning, "topic", true);
                    channel.QueueDeclare(ConfigCrawler.QueueTrackRunning, true, false, false, null);
                    channel.QueueDeclare(ConfigCrawler.QueueUpdateSessionRunning, true, false, false, null);
                    channel.QueueBind(ConfigCrawler.QueueUpdateSessionRunning, ConfigCrawler.ExchangeSessionRunning, ConfigCrawler.RoutingkeySessionRunning);
                    channel.QueueBind(ConfigCrawler.QueueTrackRunning, ConfigCrawler.ExchangeSessionRunning, ConfigCrawler.RoutingkeySessionRunning);

                    channel.QueueDeclare(ConfigCrawler.QueueCompanyFindnew, true, false, false, null);
                    channel.QueueBind(ConfigCrawler.QueueCompanyFindnew, ConfigCrawler.ExchangeCompanyFindNew, ConfigCrawler.RoutingkeyCompanyFindNew);

                    channel.QueueDeclare(ConfigCrawler.QueueCompanyReload, true, false, false, null);
                    channel.QueueBind(ConfigCrawler.QueueCompanyReload, ConfigCrawler.ExchangeCompanyReload, ConfigCrawler.RoutingkeyCompanyReload);

                    channel.QueueDeclare(ConfigCrawler.QueueEndSessionToSql, true, false, false, null);
                    channel.QueueBind(ConfigCrawler.QueueEndSessionToSql, ConfigCrawler.ExchangeEndSession, ConfigCrawler.RoutingEndSession);
                    channel.QueueDeclare(ConfigCrawler.QueueProductChangeToSql, true, false, false, null);
                    channel.QueueBind(ConfigCrawler.QueueProductChangeToSql, ConfigCrawler.ExchangeChangeProduct, ConfigCrawler.RoutingkeyChangeProduct);

                    channel.QueueDeclare(ConfigCrawler.QueueResetDuplicate, true, false, false, null);
                    channel.QueueBind(ConfigCrawler.QueueResetDuplicate, ConfigCrawler.ExchangeResetDuplicate, ConfigCrawler.RoutingkeyResetDuplicate);

                    channel.QueueDeclare(ConfigCrawler.QueueDuplicateToCache, true, false, false, null);
                    channel.QueueBind(ConfigCrawler.QueueDuplicateToCache, ConfigCrawler.ExchangeDuplicateProductToCache, ConfigCrawler.RoutingKeyDuplicateProductToCache);



                    channel.QueueDeclare(ConfigCrawler.QueueProductChangeToCache, true, false, false, null);
                    channel.QueueBind(ConfigCrawler.QueueProductChangeToCache, ConfigCrawler.ExchangeChangeProduct, ConfigCrawler.RoutingkeyChangeProduct);

                    channel.QueueDeclare(ConfigCrawler.QueueChangeDesc, true, false, false, null);
                    channel.QueueBind(ConfigCrawler.QueueChangeDesc, ConfigCrawler.ExchangeChangeDesc, ConfigCrawler.RoutingkeyChangeDesc);

                    channel.QueueDeclare(ConfigCrawler.QueueAddClassification, true, false, false, null);
                    return;
                }
                catch (Exception ex)
                {
                    
                }
            }
               
            
        }
    }
}