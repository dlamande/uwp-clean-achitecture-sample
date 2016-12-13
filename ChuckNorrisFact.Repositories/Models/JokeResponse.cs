using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChuckNorrisFact.Repositories.Models
{
    public class JokeResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public IList<Joke> Jokes { get; set; }
    }
}
