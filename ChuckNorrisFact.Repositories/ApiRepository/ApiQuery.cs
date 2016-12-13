using ChuckNorrisFact.Repositories.Entities;
using ChuckNorrisFact.Repositories.Models;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace ChuckNorrisFact.Repositories.ApiRepository
{
    public class ApiQuery : IApiQuery<ChuckNorrisJoke>
    {
        private IHttpClient _client;
        public ApiQuery(IHttpClient client)
        {
            _client = client;
        }

        public async Task<IList<ChuckNorrisJoke>> Query()
        {
            var response = await _client.GetString("http://api.icndb.com/jokes");
            var apiReponse = Newtonsoft.Json.JsonConvert.DeserializeObject<JokeResponse>(response);

            return TransformToEntity(apiReponse);
        }

        private IList<ChuckNorrisJoke> TransformToEntity(JokeResponse apiReponse)
        {

            if (apiReponse == null) return null;

            IList<ChuckNorrisJoke> result = new List<ChuckNorrisJoke>();

            foreach (var item in apiReponse.Jokes)
            {
                result.Add(new ChuckNorrisJoke { Label = WebUtility.HtmlDecode(item.Label) });
            }

            return result;
        }
    }
}
