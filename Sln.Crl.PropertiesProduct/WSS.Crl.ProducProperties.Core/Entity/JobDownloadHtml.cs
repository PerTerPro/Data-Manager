namespace WSS.Crl.ProducProperties.Core.Entity
{
    public class JobCrlProperties
    {
        public long ProductId { get; set; }
        public string GetJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static JobCrlProperties FromJson(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobCrlProperties>(str);
        }

        public string DetailUrl { get; set; }

        public string Domain { get; set; }
        public long ClassificationId { get; set; }
        public string Classification { get; set; }
        public string Html { get; set; }
    }
}
