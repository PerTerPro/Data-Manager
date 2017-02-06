namespace WSS.Crl.ProducProperties.Core.Entity
{
    public class JobDownloadHtml
    {
        public long ProductId { get; set; }
        public string GetJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static JobDownloadHtml FromJson(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobDownloadHtml>(str);
        }

        public string DetailUrl { get; set; }

        public string Domain { get; set; }
        public long ClassificationId { get; set; }
        public string Classification { get; set; }
    }
}
