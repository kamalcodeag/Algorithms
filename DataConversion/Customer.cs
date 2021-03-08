using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataConversion
{
    public class Customer
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("services")]
        public List<Service> Services { get; set; }
    }
}
