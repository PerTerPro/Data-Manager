using QT.Entities.CrawlerProduct.Reload;

public class JobCompanyCrawler
{
    public long CompanyId { get; set; }
    public bool CheckRunning { get; set; }

    public string GetJSon()
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(this);
    }

    public static JobCompanyCrawler ParseFromJson(string str)
    {
        return Newtonsoft.Json.JsonConvert.DeserializeObject<JobCompanyCrawler>(str);
    }
}