using ChuckNorrisFact.Repositories.ApiRepository;
using System.Threading.Tasks;

namespace ChuckNorrisFact.Repositories.Tests
{
    public class MockHttpClient : IHttpClient
    {
        private string _json;
        public MockHttpClient(string json)
        {
            _json = json;
        }
        public Task<string> GetString(string url)
        {
            return Task.FromResult(_json);
        }
    }
}