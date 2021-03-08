using Newtonsoft.Json;

namespace DataConversion
{
    public class Package
    {
        [JsonProperty("packageName")]
        public string PackageName { get; set; }
    }
}
