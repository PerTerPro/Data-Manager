using ProtoBuf;
namespace WSS.Crl.ProducProperties.Core.Entity
{
    [ProtoContract]
    public class JobCrlProperties
    {
        [ProtoMember(1)]
        public long ProductId { get; set; }
        public string GetJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static JobCrlProperties FromJson(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobCrlProperties>(str);
        }
        [ProtoMember(2)]
        public string DetailUrl { get; set; }
        [ProtoMember(3)]
        public string Domain { get; set; }
        [ProtoMember(4)]
        public long ClassificationId { get; set; }
        [ProtoMember(5)]
        public string Classification { get; set; }
        [ProtoMember(6)]
        public string Html { get; set; }
    }
}
