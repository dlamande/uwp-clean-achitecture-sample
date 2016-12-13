using System.Net.Http;
using System.Threading.Tasks;

namespace ChuckNorrisFact.Repositories.ApiRepository
{
    public class HttpClientImpl : IHttpClient
    {
        public async Task<string> GetString(string url)
        {
            HttpClient client = new HttpClient();

            return await client.GetStringAsync(url);
        }
    }
}
