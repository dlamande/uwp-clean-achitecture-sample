using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChuckNorrisFact.Repositories.Models
{
    public class Joke
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("joke")]
        public string Label { get; set; }
        [JsonProperty("categories")]
        public IList<string> categories { get; set; }
    }
}