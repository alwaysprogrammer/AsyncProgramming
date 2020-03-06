using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    public class Name
    {
        [JsonProperty("first")]
        public string first { get; set; }
        [JsonProperty("last")]
        public string last { get; set; }
    }

    public class User
    {
        [JsonProperty("_id")]
        public string _id { get; set; }
        [JsonProperty("name")]
        public Name name { get; set; }
    }

    public class All
    {
        [JsonProperty("_id")]
        public string _id { get; set; }
        [JsonProperty("text")]
        public string text { get; set; }
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("user")]
        public User user { get; set; }
        [JsonProperty("upvotes")]
        public int upvotes { get; set; }
        [JsonProperty("userUpvoted")]
        public object userUpvoted { get; set; }
    }

    public class RootObject
    {
        public List<All> all { get; set; }
    }
}
