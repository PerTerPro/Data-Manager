using QT.Entities.Data;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlSale
{
    public class RedisSession
    {
        public string PrefixSession = "crl_sale:session:";

        private IDatabase redisDb;

        public RedisSession()
        {
            var redisMultiplexer = ConnectionMultiplexer.Connect(QT.Entities.Server.RedisDB_Host + ":" + QT.Entities.Server.RedisDB_Port);
            this.redisDb = redisMultiplexer.GetDatabase(2);
        }

        public bool CheckRunning(long company, int typeCrawler)
        {
            string key = PrefixSession + typeCrawler + ":" + company.ToString();
            if (!this.redisDb.KeyExists(key)) return false;
            else
            {
                if (!this.redisDb.HashExists(key, "is_end")) return false;
                else
                {
                    bool bEnd = Convert.ToBoolean(this.redisDb.HashGet(key, "is_end"));
                    if (bEnd == false)
                    {
                        if (this.redisDb.HashExists(key, "last_job_at"))
                        {
                            DateTime dtLastJobAt = Convert.ToDateTime(this.redisDb.HashGet(key, "last_job_at"));
                            if ((DateTime.Now - dtLastJobAt).TotalHours > 10)
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                        else return true;
                    }
                    else return false;
                }
            }
        }

        private DateTime GetLastJob(long company, int typeCrawler)
        {
            throw new NotImplementedException();
        }
        public bool CheckKey(string key)
        {
            return this.redisDb.KeyExists(key);
        }

        public void InitSession(long company, int typeCrawler)
        {
            string key = PrefixSession + typeCrawler + ":" + company.ToString();
            this.redisDb.HashSet(key, "last_job_at", DateTime.Now.ToString(QT.Entities.Common.Format_DateTime));
            this.redisDb.HashSet(key, "is_end", "False");
        }

        public void CleanSession(long company, int typeCrawler)
        {
            //Xoa SetAddesQueue.
            SetAddedQueueRedis setAdded = new SetAddedQueueRedis(company, typeCrawler);
            setAdded.Clean();

            //Xóa queueWait.
            QueueWaitRedis queueWait = new QueueWaitRedis(company, typeCrawler);
            queueWait.Clean();

            //Xoa session

            string key = PrefixSession + typeCrawler + ":" + company.ToString();
            this.redisDb.HashSet(key, "is_end", "True");
            this.redisDb.HashSet(key, "product", "0");
            this.redisDb.HashSet(key, "length_queue", "0");
            this.redisDb.HashSet(key, "visited", "0");
        }

        public void IncrVisited(long company, int typeCrawler)
        {
            string key = PrefixSession + typeCrawler + ":" + company.ToString();
            this.redisDb.HashIncrement(key, "visited");
        }

        public void IncrFieldLengthQueue(long company, int typeCrawler)
        {
            string key = PrefixSession + typeCrawler + ":" + company.ToString();
            this.redisDb.HashIncrement(key, "length_queue");
        }

        public void IncrFieldNumberProduct(long company, int typeCrawler)
        {
            string key = PrefixSession + typeCrawler + ":" + company.ToString();
            this.redisDb.HashIncrement(key, "product");
        }

        public void Decrfield(long company, int typeCrawler)
        {
            string key = PrefixSession + typeCrawler + ":" + company.ToString();
            this.redisDb.HashDecrement(key, "length_queue");
        }

        public int QueueWait(long company, int typeCrawler)
        {
            try
            {
                string key = PrefixSession + typeCrawler + ":" + company.ToString();
                return Convert.ToInt32(this.redisDb.HashGet(key, "length_queue"));
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int GetNumeberProduct(long company, int typeCrawler)
        {
            try
            {
                string key =  + typeCrawler + ":" + company.ToString();
                return Convert.ToInt32(this.redisDb.HashGet(key, "product"));
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public object VisitedUrl(long company, int typeCrawler)
        {
            try
            {
                string key = PrefixSession + typeCrawler + ":" + company.ToString();
                return Convert.ToInt32(this.redisDb.HashGet(key, "visited"));
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public DateTime GetLastAtJob(long companyID, int typeCrawler)
        {
            string str = "crl_sale:session:" + typeCrawler + ":" + companyID;
            if (!this.redisDb.HashExists(str, "last_job_at")) return SqlDb.MinDateDb;
            else return Convert.ToDateTime(this.redisDb.HashGet(str, "last_job_at"));
        }

        public DateTime GetStartOfSession(long companyID, int typeCrawler)
        {
            string str = "crl_sale:session:" + typeCrawler + ":" + companyID;
            if (!this.redisDb.HashExists(str, "start_at")) return SqlDb.MinDateDb;
            else return Convert.ToDateTime(this.redisDb.HashGet(str, "start_at"));
        }

        public void UpdateLastJob(long companyID, int typeCrawler,string value)
        {
            string str = "crl_sale:session:" + typeCrawler + ":" + companyID;
            if (!this.redisDb.HashSet(str, "last_job_at", value)) ;
        }
        public void SetStartFrom (long companyID, int typeCrawler, DateTime dtFrom)
        {
            string str = "crl_sale:session:" + typeCrawler + ":" + companyID;
            if (!this.redisDb.HashSet(str, "start_at", dtFrom.ToString(QT.Entities.Common.Format_DateTime))) ;
        }

        public int GetVisitedLink(long company, int typeCrawler)
        {
            string key = +typeCrawler + ":" + company.ToString();
            if (!this.redisDb.HashExists(key, "visited")) return 0;
            else return Convert.ToInt32(this.redisDb.HashGet(key, "product"));
        }
    }
}
