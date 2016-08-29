using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities.Data;

namespace QT.Entities.CrawlerProduct
{

    public class ReportSessionRunning
    {
        public long CompanyId { get; set; }
        public string Session { get; set; }
        public string Ip { get; set; }
        public string Thread { get; set; }
        public string Type { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime TimeReport { get; set; }
        public string MachineCode { get; set; }


        public byte[] GetArbyteJson()
        {
            return Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(this));
        }

        public static ReportSessionRunning GetFromJson(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ReportSessionRunning>(input);
        }

        public static ReportSessionRunning GetFromJson(byte[] input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ReportSessionRunning>(Encoding.UTF8.GetString(input));
        }

        public ReportSessionRunning()
        {
            TimeReport=DateTime.Now;
        }
    }

    public class CrawlerSessionLog
    {
        public long CompanyId { get; set; }
        public int TypeCrawler { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
       
        public int CountVisited { get; set; }
        public int CountProduct { get; set; }
        public int CountChange { get; set; }
        public string Session { get; set; }
        public int TotalProduct { get; set; }
        public string Ip { get; set; }
        public string Domain { get; set; }
        public string TypeRun { get; set; }
        public string TypeEnd { get; set; }
        public int NumberDuplicateProduct { get; set; }

        public byte[] GetArbyteJson()
        {
            return Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(this));
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static CrawlerSessionLog GetFromJson(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CrawlerSessionLog>(input);
        }

        public static CrawlerSessionLog GetFromJson(byte[] input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CrawlerSessionLog>(Encoding.UTF8.GetString(input));
        }

        public CrawlerSessionLog()
        {
            CompanyId = 0;
            TypeCrawler = -1;
            StartAt = SqlDb.MinDateDb;
            EndAt = SqlDb.MinDateDb;
            CountVisited = 0;
            CountProduct = 0;
            CountChange = 0;
            Session = "";
            TotalProduct = 0;
            Ip = "";
            Domain = "";
            TypeRun = "";
            TypeEnd = "";
            NumberDuplicateProduct = 0;

        }
    }
}

