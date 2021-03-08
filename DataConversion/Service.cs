using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataConversion
{
    public class Service
    {
        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }
        [JsonProperty("packages")]
        public List<Package> Packages { get; set; }
    }
}
